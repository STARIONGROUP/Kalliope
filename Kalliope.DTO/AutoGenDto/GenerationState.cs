// -------------------------------------------------------------------------------------------------
// <copyright file="GenerationState.cs" company="RHEA System S.A.">
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
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
 
namespace Kalliope.DTO
{
    using System;
    using System.Collections.Generic;
 
    using Kalliope.Common;
 
    /// <summary>
    /// A Data Transfer Object that represents a GenerationState
    /// </summary>
    /// <remarks>
    /// State information relating to automatic mapping algorithms
    /// </remarks>
    public partial class GenerationState : ModelThing
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GenerationState"/> class.
        /// </summary>
        public GenerationState()
        {
            this.GenerationSettings = new List<string>();
        }
 

        /// <summary>
        /// Gets or sets a list unique identifiers of the contained <see cref="GenerationSetting"/> instances
        /// </summary>
        [Description("")]
        [Property(name: "GenerationSettings", aggregation: AggregationKind.Composite, multiplicity: "0..*", typeKind: TypeKind.Object, defaultValue: "", typeName: "GenerationSetting")]
        public List<string> GenerationSettings { get; set; }
 
        /// <summary>
        /// Gets or sets a Id
        /// </summary>
        [Description("A unique identifier for this element")]
        [Property(name: "Id", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.String, defaultValue: "", typeName: "")]
        public string Id { get; set; }
 
    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
