// -------------------------------------------------------------------------------------------------
// <copyright file="OrmRoot.cs" company="RHEA System S.A.">
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
    /// A Data Transfer Object that represents a OrmRoot
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    public partial class OrmRoot : ModelThing
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrmRoot"/> class.
        /// </summary>
        public OrmRoot()
        {
            this.Diagrams = new List<string>();
        }
 

        /// <summary>
        /// Gets or sets a list unique identifiers of the contained <see cref="ORMDiagram"/> instances
        /// </summary>
        [Description("")]
        [Property(name: "Diagrams", aggregation: AggregationKind.Composite, multiplicity: "0..*", typeKind: TypeKind.Object, defaultValue: "", typeName: "ORMDiagram")]
        public List<string> Diagrams { get; set; }
 
        /// <summary>
        /// Gets or sets the unique identifier of the contained <see cref="GenerationState"/>
        /// </summary>
        [Description("")]
        [Property(name: "GenerationState", aggregation: AggregationKind.Composite, multiplicity: "1..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "GenerationState")]
        public string GenerationState { get; set; }
 
        /// <summary>
        /// Gets or sets the unique identifier of the contained <see cref="ORMModel"/>
        /// </summary>
        [Description("")]
        [Property(name: "Model", aggregation: AggregationKind.Composite, multiplicity: "1..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "ORMModel")]
        public string Model { get; set; }
 
        /// <summary>
        /// Gets or sets the unique identifier of the contained <see cref="NameGenerator"/>
        /// </summary>
        [Description("")]
        [Property(name: "NameGenerator", aggregation: AggregationKind.Composite, multiplicity: "1..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "NameGenerator")]
        public string NameGenerator { get; set; }
 
    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
