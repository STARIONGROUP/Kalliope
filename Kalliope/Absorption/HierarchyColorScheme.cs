// -------------------------------------------------------------------------------------------------
// <copyright file="HierarchyColorScheme.cs" company="RHEA System S.A.">
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

namespace Kalliope.Absorption
{
    using System.Collections.Generic;

    using Kalliope.Common;
    using Kalliope.Core;
    using Kalliope.Diagrams;

    [Description("")]
    [Domain(isAbstract: false, general: "ModelThing")]
    [Container(typeName: "ElementOrganizations", propertyName: "HierarchyColorSchemes")]
    public class HierarchyColorScheme : ModelThing
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HierarchyColorScheme"/>
        /// </summary>
        public HierarchyColorScheme()
        {
            this.TopLevel = new List<DiagramDynamicColor>();
            this.Absorbed = new List<DiagramDynamicColor>();
            this.NotIncluded = new List<DiagramDynamicColor>();
            this.AbsorptionAttachPoint = new List<DiagramDynamicColor>();
            this.PrimaryLocation = new List<DiagramDynamicColor>();
            this.ReferenceLocation = new List<DiagramDynamicColor>();
            this.DisplayedHierarchies = new List<DisplayedHierarchy>();
        }

        /// <summary>
        /// Gets or sets the TopLevel <see cref="List{DiagramDynamicColor}"/> contained by the <see cref="HierarchyColorScheme"/>
        /// </summary>
        [Property(name: "TopLevel", aggregation: AggregationKind.Composite, multiplicity: "0..*", typeKind: TypeKind.Object, defaultValue: "", typeName: "DiagramDynamicColor")]
        public List<DiagramDynamicColor> TopLevel { get; set; }

        /// <summary>
        /// Gets or sets the Absorbed <see cref="List{DiagramDynamicColor}"/> contained by the <see cref="HierarchyColorScheme"/>
        /// </summary>
        [Property(name: "Absorbed", aggregation: AggregationKind.Composite, multiplicity: "0..*", typeKind: TypeKind.Object, defaultValue: "", typeName: "DiagramDynamicColor")]
        public List<DiagramDynamicColor> Absorbed { get; set; }

        /// <summary>
        /// Gets or sets the NotIncluded <see cref="List{DiagramDynamicColor}"/> contained by the <see cref="HierarchyColorScheme"/>
        /// </summary>
        [Property(name: "NotIncluded", aggregation: AggregationKind.Composite, multiplicity: "0..*", typeKind: TypeKind.Object, defaultValue: "", typeName: "DiagramDynamicColor")]
        public List<DiagramDynamicColor> NotIncluded { get; set; }

        /// <summary>
        /// Gets or sets the AbsorptionAttachPoint <see cref="List{DiagramDynamicColor}"/> contained by the <see cref="HierarchyColorScheme"/>
        /// </summary>
        [Property(name: "AbsorptionAttachPoint", aggregation: AggregationKind.Composite, multiplicity: "0..*", typeKind: TypeKind.Object, defaultValue: "", typeName: "DiagramDynamicColor")]
        public List<DiagramDynamicColor> AbsorptionAttachPoint { get; set; }

        /// <summary>
        /// Gets or sets the PrimaryLocation <see cref="List{DiagramDynamicColor}"/> contained by the <see cref="HierarchyColorScheme"/>
        /// </summary>
        [Property(name: "PrimaryLocation", aggregation: AggregationKind.Composite, multiplicity: "0..*", typeKind: TypeKind.Object, defaultValue: "", typeName: "DiagramDynamicColor")]
        public List<DiagramDynamicColor> PrimaryLocation { get; set; }

        /// <summary>
        /// Gets or sets the ReferenceLocation <see cref="List{DiagramDynamicColor}"/> contained by the <see cref="HierarchyColorScheme"/>
        /// </summary>
        [Property(name: "ReferenceLocation", aggregation: AggregationKind.Composite, multiplicity: "0..*", typeKind: TypeKind.Object, defaultValue: "", typeName: "DiagramDynamicColor")]
        public List<DiagramDynamicColor> ReferenceLocation { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="List{DisplayedHierarchy}"/> contained by the <see cref="HierarchyColorScheme"/>
        /// </summary>
        [Property(name: "DisplayedHierarchies", aggregation: AggregationKind.Composite, multiplicity: "0..*", typeKind: TypeKind.Object, defaultValue: "", typeName: "DisplayedHierarchy")]
        public List<DisplayedHierarchy> DisplayedHierarchies { get; set; }
    }
}
