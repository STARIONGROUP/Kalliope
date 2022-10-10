// -------------------------------------------------------------------------------------------------
// <copyright file="RoleText.cs" company="RHEA System S.A.">
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

namespace Kalliope.Core
{
    using Kalliope.Common;

    /// <summary>
    /// Text bound to or occurring after a given role.
    /// Roles with no text are not represented
    /// </summary>
    [Description("Text bound to or occurring after a given role. Roles with no text are not represented")]
    [Domain(isAbstract: false, general: "ModelThing")]
    [Container(typeName: "Reading", propertyName: "ExpandedData")]
    public class RoleText : ModelThing
    {
        /// <summary>
        /// Gets the unique identifier of the <see cref="RoleText"/>
        /// </summary>
        [Description("A unique identifier for this element")]
        [Property(name: "Id", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.String, defaultValue: "", typeName: "", allowOverride: false, isOverride: true, isDerived: true)]
        public override string Id { get; set; }

        /// <summary>
        /// The zero-based index of the role
        /// </summary>
        [Description("The zero-based index of the role")]
        [Property(name: "RoleIndex", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Int32, defaultValue: "", typeName: "")]
        public int RoleIndex { get; set; }

        /// <summary>
        /// Text that is bound to the role as leading text through hyphen binding semantics in the full reading text
        /// </summary>
        [Description("Text that is bound to the role as leading text through hyphen binding semantics in the full reading text")]
        [Property(name: "PreBoundText", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.String, defaultValue: "", typeName: "")]
        public string PreBoundText { get; set; }

        /// <summary>
        /// Text that is bound to the role as trailing text through hyphen binding semantics in the full reading text
        /// </summary>
        [Description("Text that is bound to the role as trailing text through hyphen binding semantics in the full reading text")]
        [Property(name: "PostBoundText", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.String, defaultValue: "", typeName: "")]
        public string PostBoundText { get; set; }

        /// <summary>
        /// Text following a role replacement field and associated bound text
        /// </summary>
        [Description("Text following a role replacement field and associated bound text")]
        [Property(name: "FollowingText", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.String, defaultValue: "", typeName: "")]
        public string FollowingText { get; set; }
    }
}
