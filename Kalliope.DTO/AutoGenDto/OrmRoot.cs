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
            this.CustomPropertyGroups = new List<string>();
            this.Diagrams = new List<string>();
        }
 

        /// <summary>
        /// Gets or sets a list unique identifiers of the contained <see cref="CustomPropertyGroup"/> instances
        /// </summary>
        [Description("Gets or sets the CustomPropertyGroups contained by the .orm file")]
        [Property(name: "CustomPropertyGroups", aggregation: AggregationKind.Composite, multiplicity: "0..*", typeKind: TypeKind.Object, defaultValue: "", typeName: "CustomPropertyGroup", allowOverride: false, isOverride: false, isDerived: false)]
        public List<string> CustomPropertyGroups { get; set; }
 
        /// <summary>
        /// Gets or sets a list unique identifiers of the contained <see cref="OrmDiagram"/> instances
        /// </summary>
        [Description("Gets or sets the OrmDiagrams contained by the .orm file")]
        [Property(name: "Diagrams", aggregation: AggregationKind.Composite, multiplicity: "0..*", typeKind: TypeKind.Object, defaultValue: "", typeName: "OrmDiagram", allowOverride: false, isOverride: false, isDerived: false)]
        public List<string> Diagrams { get; set; }
 
        /// <summary>
        /// Gets or sets the unique identifier of the contained <see cref="GenerationState"/>
        /// </summary>
        [Description("")]
        [Property(name: "GenerationState", aggregation: AggregationKind.Composite, multiplicity: "1..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "GenerationState", allowOverride: false, isOverride: false, isDerived: false)]
        public string GenerationState { get; set; }
 
        /// <summary>
        /// Gets the derived Id
        /// </summary>
        [Description("A unique identifier for this element")]
        [Property(name: "Id", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.String, defaultValue: "", typeName: "", allowOverride: false, isOverride: true, isDerived: true)]
        public override string Id => this.ComputeId();
 
        /// <summary>
        /// Gets or sets the unique identifier of the contained <see cref="OrmModel"/>
        /// </summary>
        [Description("")]
        [Property(name: "Model", aggregation: AggregationKind.Composite, multiplicity: "1..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "OrmModel", allowOverride: false, isOverride: false, isDerived: false)]
        public string Model { get; set; }
 
        /// <summary>
        /// Gets or sets the unique identifier of the contained <see cref="NameGenerator"/>
        /// </summary>
        [Description("")]
        [Property(name: "NameGenerator", aggregation: AggregationKind.Composite, multiplicity: "1..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "NameGenerator", allowOverride: false, isOverride: false, isDerived: false)]
        public string NameGenerator { get; set; }
 
    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
