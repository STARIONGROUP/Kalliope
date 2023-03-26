// -------------------------------------------------------------------------------------------------
// <copyright file="HierarchyColorScheme.cs" company="RHEA System S.A.">
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
    /// A Data Transfer Object that represents a HierarchyColorScheme
    /// </summary>
    [Container(typeName: "ElementOrganizations", propertyName: "HierarchyColorSchemes")]
    public partial class HierarchyColorScheme : ModelThing
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HierarchyColorScheme"/> class.
        /// </summary>
        public HierarchyColorScheme()
        {
            this.Absorbed = new List<string>();
            this.AbsorptionAttachPoint = new List<string>();
            this.DisplayedHierarchies = new List<string>();
            this.NotIncluded = new List<string>();
            this.PrimaryLocation = new List<string>();
            this.ReferenceLocation = new List<string>();
            this.TopLevel = new List<string>();
        }
 
        /// <summary>
        /// Gets or sets the unique identifier of the container
        /// </summary>
        public string Container {get; set;}
 

        /// <summary>
        /// Gets or sets a list unique identifiers of the contained <see cref="DiagramDynamicColor"/> instances
        /// </summary>
        [Description("")]
        [Property(name: "Absorbed", aggregation: AggregationKind.Composite, multiplicity: "0..*", typeKind: TypeKind.Object, defaultValue: "", typeName: "DiagramDynamicColor", allowOverride: false, isOverride: false, isDerived: false)]
        public List<string> Absorbed { get; set; }
 
        /// <summary>
        /// Gets or sets a list unique identifiers of the contained <see cref="DiagramDynamicColor"/> instances
        /// </summary>
        [Description("")]
        [Property(name: "AbsorptionAttachPoint", aggregation: AggregationKind.Composite, multiplicity: "0..*", typeKind: TypeKind.Object, defaultValue: "", typeName: "DiagramDynamicColor", allowOverride: false, isOverride: false, isDerived: false)]
        public List<string> AbsorptionAttachPoint { get; set; }
 
        /// <summary>
        /// Gets or sets a list unique identifiers of the contained <see cref="Hierarchy"/> instances
        /// </summary>
        [Description("")]
        [Property(name: "DisplayedHierarchies", aggregation: AggregationKind.Composite, multiplicity: "0..*", typeKind: TypeKind.Object, defaultValue: "", typeName: "Hierarchy", allowOverride: false, isOverride: false, isDerived: false)]
        public List<string> DisplayedHierarchies { get; set; }
 
        /// <summary>
        /// Gets or sets a list unique identifiers of the contained <see cref="DiagramDynamicColor"/> instances
        /// </summary>
        [Description("")]
        [Property(name: "NotIncluded", aggregation: AggregationKind.Composite, multiplicity: "0..*", typeKind: TypeKind.Object, defaultValue: "", typeName: "DiagramDynamicColor", allowOverride: false, isOverride: false, isDerived: false)]
        public List<string> NotIncluded { get; set; }
 
        /// <summary>
        /// Gets or sets a list unique identifiers of the contained <see cref="DiagramDynamicColor"/> instances
        /// </summary>
        [Description("")]
        [Property(name: "PrimaryLocation", aggregation: AggregationKind.Composite, multiplicity: "0..*", typeKind: TypeKind.Object, defaultValue: "", typeName: "DiagramDynamicColor", allowOverride: false, isOverride: false, isDerived: false)]
        public List<string> PrimaryLocation { get; set; }
 
        /// <summary>
        /// Gets or sets a list unique identifiers of the contained <see cref="DiagramDynamicColor"/> instances
        /// </summary>
        [Description("")]
        [Property(name: "ReferenceLocation", aggregation: AggregationKind.Composite, multiplicity: "0..*", typeKind: TypeKind.Object, defaultValue: "", typeName: "DiagramDynamicColor", allowOverride: false, isOverride: false, isDerived: false)]
        public List<string> ReferenceLocation { get; set; }
 
        /// <summary>
        /// Gets or sets a list unique identifiers of the contained <see cref="DiagramDynamicColor"/> instances
        /// </summary>
        [Description("")]
        [Property(name: "TopLevel", aggregation: AggregationKind.Composite, multiplicity: "0..*", typeKind: TypeKind.Object, defaultValue: "", typeName: "DiagramDynamicColor", allowOverride: false, isOverride: false, isDerived: false)]
        public List<string> TopLevel { get; set; }
 
    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
