// -------------------------------------------------------------------------------------------------
// <copyright file="AbsorbedRole.cs" company="RHEA System S.A.">
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
    using Kalliope.Common;
    using Kalliope.Core;

    [Description("")]
    [Domain(isAbstract: false, general: "ModelThing")]
    [Container(typeName: "AbsorbedObjectType", propertyName: "AbsorbedRoles")]
    [Container(typeName: "AbsorbedFactType", propertyName: "AbsorbedRoles")]
    public class AbsorbedRole : ModelThing
    {
        [Property(name: "Role", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "Role")]
        public Role Role { get; set; }

        [Property(name: "Identifier", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.String, defaultValue: "")]
        public string Identifier { get; set; }

        [Property(name: "ObjectifiedRole", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Boolean, defaultValue: "false")]
        public bool ObjectifiedRole { get; set; }

        [Property(name: "XmlName", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.String, defaultValue: "")]
        public string XmlName { get; set; }

        [Property(name: "XmlReferenceName", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.String, defaultValue: "")]
        public string XmlReferenceName { get; set; }

        [Property(name: "XmlSimpleValueForm", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.String, defaultValue: "")]
        public string XmlSimpleValueForm { get; set; }

        [Property(name: "XmlReferenceSimpleValueForm", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.String, defaultValue: "")]
        public string XmlReferenceSimpleValueForm { get; set; }

        [Property(name: "AbsorbedFactType", aggregation: AggregationKind.None, multiplicity: "0..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "AbsorbedFactType")]
        public AbsorbedFactType AbsorbedFactType { get; set; }

        [Property(name: "AbsorbedObjectType", aggregation: AggregationKind.None, multiplicity: "0..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "AbsorbedObjectType")]
        public AbsorbedObjectType AbsorbedObjectType { get; set; }
    }
}
