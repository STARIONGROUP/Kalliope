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

namespace Kalliope.Absorption
{
    using System.Collections.Generic;

    using Kalliope.Common;
    using Kalliope.Core;

    [Description("")]
    [Domain(isAbstract: false, general: "ModelThing")]
    [Container(typeName: "Hierarchy", propertyName: "AbsorbedFactTypes")]
    public class AbsorbedFactType : ModelThing
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AbsorbedFactType"/> class.
        /// </summary>
        public AbsorbedFactType()
        {
            this.AbsorbedRoles = new List<AbsorbedRole>();
            this.PossibleChildRoles = new List<ChildRole>();
        }

        [Property(name: "Absorbed", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Boolean, defaultValue: "", typeName: "false")]
        public bool Absorbed { get; set; }

        [Property(name: "AbsorbedUnary", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Boolean, defaultValue: "", typeName: "false")]
        public bool AbsorbedUnary { get; set; }

        [Property(name: "Functional", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Boolean, defaultValue: "", typeName: "false")]
        public bool Functional { get; set; }
        
        [Property(name: "Nested", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Boolean, defaultValue: "", typeName: "false")]
        public bool Nested { get; set; }

        [Property(name: "TopLevel", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Boolean, defaultValue: "", typeName: "false")]
        public bool TopLevel { get; set; }

        [Property(name: "XmlName", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.String, defaultValue: "")]
        public string XmlName { get; set; }

        [Property(name: "AbsorbedRoles", aggregation: AggregationKind.Composite, multiplicity: "0..*", typeKind: TypeKind.Object, defaultValue: "", typeName: "AbsorbedRole")]
        public List<AbsorbedRole> AbsorbedRoles { get; set; }

        [Property(name: "PossibleChildRoles", aggregation: AggregationKind.Composite, multiplicity: "0..*", typeKind: TypeKind.Object, defaultValue: "", typeName: "ChildRole")]
        public List<ChildRole> PossibleChildRoles { get; set; }
    }
}
