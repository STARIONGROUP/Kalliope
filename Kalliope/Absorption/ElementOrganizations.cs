// -------------------------------------------------------------------------------------------------
// <copyright file="ElementOrganizations.cs" company="RHEA System S.A.">
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

    [Description("")]
    [Domain(isAbstract: false, general: "ModelThing")]
    public class ElementOrganizations : ModelThing
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ElementOrganizations"/>
        /// </summary>
        public ElementOrganizations()
        {
            this.Hierarchies = new List<Hierarchy>();
            this.HierarchyColorSchemes = new List<HierarchyColorScheme>();
        }

        /// <summary>
        /// Gets or sets the <see cref="OrmModel"/> contained by .orm file
        /// </summary>
        [Property(name: "Model", aggregation: AggregationKind.Composite, multiplicity: "1..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "OrmModel")]
        public OrmModel Model { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="List{Hierarchy}"/> contained by the <see cref="ElementOrganizations"/>
        /// </summary>
        [Property(name: "Hierarchies", aggregation: AggregationKind.Composite, multiplicity: "0..*", typeKind: TypeKind.Object, defaultValue: "", typeName: "Hierarchy")]
        public List<Hierarchy> Hierarchies { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="List{HierarchyColorScheme}"/> contained by the <see cref="ElementOrganizations"/>
        /// </summary>
        [Property(name: "HierarchyColorSchemes", aggregation: AggregationKind.Composite, multiplicity: "0..*", typeKind: TypeKind.Object, defaultValue: "", typeName: "HierarchyColorScheme")]
        public List<HierarchyColorScheme> HierarchyColorSchemes { get; set; }

        /// <summary>
        /// Gets or sets the referenced <see cref="Hierarchy"/>
        /// </summary>
		[Property(name: "ActiveOrganization", aggregation: AggregationKind.None, multiplicity: "0..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "Hierarchy")]
		public Hierarchy ActiveOrganization { get; set; }
	}
}
