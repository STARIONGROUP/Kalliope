﻿// -------------------------------------------------------------------------------------------------
// <copyright file="IAssembler.cs" company="Starion Group S.A.">
//
//   Copyright 2022-2024 Starion Group S.A.
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
    
    /// <summary>
    /// The purpose of the <see cref="IAssembler"/> is to assemble a Kalliope POCO object graph from a
    /// list of data-transfer-objects
    /// </summary>
    public interface IAssembler
    {
        /// <summary>
        /// Gets the Cache that contains all the <see cref="Core.ModelThing"/>s
        /// </summary>
        ConcurrentDictionary<string, Lazy<Kalliope.Core.ModelThing>> Cache { get; }

        /// <summary>
        /// Synchronize the Cache based on the provided <paramref name="dtos"/>
        /// </summary>
        /// <param name="dtos">
        /// the DTOs used to update the cache with
        /// </param>
        void Synchronize(IEnumerable<Kalliope.DTO.ModelThing> dtos);
    }
}
