// -------------------------------------------------------------------------------------------------
// <copyright file="ChildRole.cs" company="Starion Group S.A.">
//
//   Copyright 2022-2024 Starion Group S.A.
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
    [Container(typeName: "AbsorbedFactType", propertyName: "PossibleChildRoles")]
    [Container(typeName: "AbsorbedObjectType", propertyName: "PossibleChildRoles")]
    public class ChildRole : ModelThing
    {
        [Property(name: "CanBePrimary", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Boolean, defaultValue: "", typeName: "false")]
        public bool CanBePrimary { get; set; }

        [Property(name: "ChosenAsPrimary", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Boolean, defaultValue: "", typeName: "false")]
        public bool ChosenAsPrimary { get; set; }

        [Property(name: "Identifier", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Boolean, defaultValue: "", typeName: "false")]
        public bool Identifier { get; set; }

        [Property(name: "Ignored", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Boolean, defaultValue: "", typeName: "false")]
        public bool Ignored { get; set; }

        [Property(name: "IsPrimary", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Boolean, defaultValue: "", typeName: "false")]
        public bool IsPrimary { get; set; }

        [Property(name: "ObjectifiedRole", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Boolean, defaultValue: "", typeName: "false")]
        public bool ObjectifiedRole { get; set; }

        [Property(name: "ReferenceLocation", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.String, defaultValue: "")]
        public string ReferenceLocation { get; set; }

        [Property(name: "XmlName", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.String, defaultValue: "")]
        public string XmlName { get; set; }

        [Property(name: "XmlReferenceName", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.String, defaultValue: "")]
        public string XmlReferenceName { get; set; }

        [Property(name: "XmlReferenceSimpleValueForm", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.String, defaultValue: "")]
        public string XmlReferenceSimpleValueForm { get; set; }

        [Property(name: "XmlSimpleValueForm", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.String, defaultValue: "")]
        public string XmlSimpleValueForm { get; set; }
        
        [Property(name: "ModelThing", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "ModelThing")]
        public ModelThing ModelThing { get; set; }
    }
}
