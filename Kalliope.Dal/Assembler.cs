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

    using Kalliope.DTO;

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
        /// The list of <see cref="ModelThing"/> marked for deletion
        /// </summary>
        private List<Kalliope.Core.ModelThing> thingsMarkedForDeletion;

        /// <summary>
        /// The <see cref="List{ModelThing}"/> uresolved <see cref="Kalliope.DTO.ModelThing"/>
        /// </summary>
        private List<Kalliope.DTO.ModelThing> ModelThingThingToUpdate;

        /// <summary>
        /// The <see cref="List{ModelThing}"/> not completely resolved that are in the cache
        /// </summary>
        private List<Kalliope.DTO.ModelThing> unresolvedModelThings;
        
        /// <summary>
        /// Initializes a new instance of the <see cref="Assembler"/> class.
        /// </summary>
        /// <param name="uri">the <see cref="Uri"/> associated with this <see cref="Assembler"/></param>
        public Assembler(Uri uri)
        {
            this.Cache = new ConcurrentDictionary<string, Lazy<Kalliope.Core.ModelThing>>();
            this.unresolvedModelThings = new List<Kalliope.DTO.ModelThing>();
            this.IDalUri = uri;
        }

        /// <summary>
        /// Gets the Cache that contains all the <see cref="Core.ModelThing"/>s
        /// </summary>
        public ConcurrentDictionary<string, Lazy<Kalliope.Core.ModelThing>> Cache { get; private set; }


        public async Task Synchronize(IEnumerable<Kalliope.DTO.ModelThing> modelThings)
        {
            if (modelThings == null)
            {
                throw new ArgumentNullException(nameof(modelThings), $"The {nameof(modelThings)} may not be null");
            }

            await this.threadLock.WaitAsync().ConfigureAwait(false);

            try
            {
                var existingIdentifiers = this.Cache.Select(x => x.Key).ToList();

                // make record of deleted items and remove from cache (based on composite collections update

                // 
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        private void QueryIdentifierOfDeletedModelThing(Core.ModelThing poco, DTO.ModelThing dto)
        {

        }
    }
}
