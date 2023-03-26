// -------------------------------------------------------------------------------------------------
// <copyright file="AbsorbedFactType.cs" company="RHEA System S.A.">
//
//   Copyright 2022-2023 RHEA System S.A.
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

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------

namespace Kalliope.DTO
{
    using System;
    using System.Collections.Generic;

    using Kalliope.Common;

    /// <summary>
    /// A Data Transfer Object that represents a AbsorbedFactType
    /// </summary>
    [Container(typeName: "Hierarchy", propertyName: "AbsorbedFactTypes")]
    public partial class AbsorbedFactType : ModelThing
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AbsorbedFactType"/> class.
        /// </summary>
        public AbsorbedFactType()
        {
            this.AbsorbedRoles = new List<string>();
            this.PossibleChildRoles = new List<string>();
        }
 
        /// <summary>
        /// Gets or sets the unique identifier of the container
        /// </summary>
        public string Container {get; set;}
 

        /// <summary>
        /// Gets or sets a Absorbed
        /// </summary>
        [Description("")]
        [Property(name: "Absorbed", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Boolean, defaultValue: "", typeName: "false", allowOverride: false, isOverride: false, isDerived: false)]
        public bool Absorbed { get; set; }
 
        /// <summary>
        /// Gets or sets a list unique identifiers of the contained <see cref="AbsorbedRole"/> instances
        /// </summary>
        [Description("")]
        [Property(name: "AbsorbedRoles", aggregation: AggregationKind.Composite, multiplicity: "0..*", typeKind: TypeKind.Object, defaultValue: "", typeName: "AbsorbedRole", allowOverride: false, isOverride: false, isDerived: false)]
        public List<string> AbsorbedRoles { get; set; }
 
        /// <summary>
        /// Gets or sets a AbsorbedUnary
        /// </summary>
        [Description("")]
        [Property(name: "AbsorbedUnary", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Boolean, defaultValue: "", typeName: "false", allowOverride: false, isOverride: false, isDerived: false)]
        public bool AbsorbedUnary { get; set; }
 
        /// <summary>
        /// Gets or sets a Functional
        /// </summary>
        [Description("")]
        [Property(name: "Functional", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Boolean, defaultValue: "", typeName: "false", allowOverride: false, isOverride: false, isDerived: false)]
        public bool Functional { get; set; }
 
        /// <summary>
        /// Gets or sets a Nested
        /// </summary>
        [Description("")]
        [Property(name: "Nested", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Boolean, defaultValue: "", typeName: "false", allowOverride: false, isOverride: false, isDerived: false)]
        public bool Nested { get; set; }
 
        /// <summary>
        /// Gets or sets a list unique identifiers of the contained <see cref="ChildRole"/> instances
        /// </summary>
        [Description("")]
        [Property(name: "PossibleChildRoles", aggregation: AggregationKind.Composite, multiplicity: "0..*", typeKind: TypeKind.Object, defaultValue: "", typeName: "ChildRole", allowOverride: false, isOverride: false, isDerived: false)]
        public List<string> PossibleChildRoles { get; set; }
 
        /// <summary>
        /// Gets or sets a TopLevel
        /// </summary>
        [Description("")]
        [Property(name: "TopLevel", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Boolean, defaultValue: "", typeName: "false", allowOverride: false, isOverride: false, isDerived: false)]
        public bool TopLevel { get; set; }
 
        /// <summary>
        /// Gets or sets a XmlName
        /// </summary>
        [Description("")]
        [Property(name: "XmlName", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.String, defaultValue: "", typeName: "", allowOverride: false, isOverride: false, isDerived: false)]
        public string XmlName { get; set; }
 
    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
