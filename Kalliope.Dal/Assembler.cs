// -------------------------------------------------------------------------------------------------
// <copyright file="Assembler.cs" company="RHEA System S.A.">
//
//   Copyright 2022 RHEA System S.A.
//
//   Licensed under the Apache License, Version 2.0 (the "License");
//   you may not use this file except in compliance with the License.
//   You may obtain a copy of the License at
//
//       http://www.apache.org/licenses/LICENSE-2.0
//
//   Unless required by applicable law or agreed to in writing, software
//   distributed under the License is distributed on an "AS IS" BASIS,
//   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//   See the License for the specific language governing permissions and
//   limitations under the License.
//
// </copyright>
// ------------------------------------------------------------------------------------------------

namespace Kalliope.Dal
{
    using System;
    using System.Collections.Concurrent;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;

    using Kalliope.Core;

    /// <summary>
    /// The purpose of the <see cref="Assembler"/> is to assemble a Kalliope POCO object graph from a
    /// list of data-transfer-objects
    /// </summary>
    public class Assembler
    {
        /// <summary>
        /// The <see cref="Uri"/> associated with this assembler
        /// </summary>
        public readonly Uri IDalUri;

        /// <summary>
        /// The lock object
        /// </summary>
        private SemaphoreSlim threadLock = new SemaphoreSlim(1);

        /// <summary>
        /// Initializes a new instance of the <see cref="Assembler"/> class.
        /// </summary>
        /// <param name="uri">the <see cref="Uri"/> associated with this <see cref="Assembler"/></param>
        public Assembler(Uri uri)
        {
            this.Cache = new ConcurrentDictionary<string, Lazy<Kalliope.Core.ModelThing>>();
            this.IDalUri = uri;
        }

        /// <summary>
        /// Gets the Cache that contains all the <see cref="Core.ModelThing"/>s
        /// </summary>
        public ConcurrentDictionary<string, Lazy<Kalliope.Core.ModelThing>> Cache { get; private set; }

        /// <summary>
        /// Synchronize the Cache based on the provided <paramref name="dtos"/>
        /// </summary>
        /// <param name="dtos">
        /// the DTOs used to update the cache with
        /// </param>
        /// <returns>
        /// The <see cref="Task"/> that can be awaited.
        /// </returns>
        public async Task Synchronize(IEnumerable<Kalliope.DTO.ModelThing> dtos)
        {
            if (dtos == null)
            {
                throw new ArgumentNullException(nameof(dtos), $"The {nameof(dtos)} may not be null");
            }
            
            await this.threadLock.WaitAsync().ConfigureAwait(false);
            
            try
            {
                var deletedIdentifiers = new List<string>();

                // update all POCOs based on provided DTOs, the result is a list unique identifiers of objects that may be removed
                foreach (var dto in dtos)
                {
                    Lazy<Kalliope.Core.ModelThing> lazyPoco;
                    if (this.Cache.TryGetValue(dto.Id, out lazyPoco))
                    {
                        var poco = lazyPoco.Value;
                        var deletedPocos= poco.UpdateValueAndRemoveDeletedReferenceProperties(dto).ToList();
                        deletedPocos.RemoveAll(x => x == "");
                        deletedIdentifiers.AddRange(deletedPocos);
                    }
                }

                // removed POCOs that are up for deletion
                foreach (var identifier in deletedIdentifiers)
                {
                    Lazy<Kalliope.Core.ModelThing> lazyPoco;
                    if (this.Cache.TryRemove(identifier, out lazyPoco))
                    {
                        Console.WriteLine($"{lazyPoco.Value.GetType().Name} with identifier {identifier} was deleted");
                    }
                    else
                    {
                        Console.WriteLine($"{lazyPoco.Value.GetType().Name} with identifier {identifier} was not deleted");
                    }
                }

                // add new POCOs to dictionary based on DTOs
                var modelThingFactory = new ModelThingFactory();
                var existingIdentifiers = this.Cache.Keys.ToList();
                var newIdentifiers = existingIdentifiers.Except(dtos.Select(x => x.Id));
                foreach (var identifier in newIdentifiers)
                {
                    var dto = dtos.Single(x => x.Id == identifier);
                    var poco = modelThingFactory.Create(dto);
                    this.Cache.AddOrUpdate(poco.Id, new Lazy<ModelThing>(() => poco), (key, oldValue) => oldValue);
                }

                // update reference properties (setting/adding POCO referenes -> deleted POCOs have already been removed)
                foreach (var dto in dtos)
                {
                    Lazy<Kalliope.Core.ModelThing> lazyPoco;
                    if (this.Cache.TryGetValue(dto.Id, out lazyPoco))
                    {
                        var poco = lazyPoco.Value;
                        poco.UpdateReferenceProperties(dto, this.Cache);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                this.threadLock.Release();
            }
        }
    }
}
