// -------------------------------------------------------------------------------------------------
// <copyright file="Objectification.cs" company="RHEA System S.A.">
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
    /// A Data Transfer Object that represents a Objectification
    /// </summary>
    /// <remarks>
    /// Represents the relationship between the entity type and the referenced fact type
    /// </remarks>
    public partial class Objectification : ORMModelElement
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Objectification"/> class.
        /// </summary>
        public Objectification()
        {
            this.ImpliedFactTypes = new List<string>();
        }
 

        /// <summary>
        /// Gets or sets a list unique identifiers of the contained <see cref="FactType"/> instances
        /// </summary>
        [Description("")]
        [Property(name: "ImpliedFactTypes", aggregation: AggregationKind.Composite, multiplicity: "1..*", typeKind: TypeKind.Object, defaultValue: "", typeName: "FactType")]
        public List<string> ImpliedFactTypes { get; set; }
 
        /// <summary>
        /// Gets or sets a IsImplied
        /// </summary>
        [Description("")]
        [Property(name: "IsImplied", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Boolean, defaultValue: "false", typeName: "")]
        public bool IsImplied { get; set; }
 
        /// <summary>
        /// Gets or sets the unique identifier of the referenced <see cref="FactType"/>
        /// </summary>
        [Description("")]
        [Property(name: "NestedFactType", aggregation: AggregationKind.None, multiplicity: "0..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "FactType")]
        public string NestedFactType { get; set; }
 
        /// <summary>
        /// Gets or sets the unique identifier of the referenced <see cref="ObjectType"/>
        /// </summary>
        [Description("")]
        [Property(name: "NestingType", aggregation: AggregationKind.None, multiplicity: "0..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "ObjectType")]
        public string NestingType { get; set; }
 
    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
