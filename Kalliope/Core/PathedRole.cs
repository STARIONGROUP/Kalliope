// -------------------------------------------------------------------------------------------------
// <copyright file="PathedRole.cs" company="RHEA System S.A.">
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

namespace Kalliope.Core
{
    using Kalliope.Common;
    using System.Collections.Generic;

    [Description("A role in connected path.")]
    [Domain(general: "ModelThing")]
    [Container(typeName: "RolePath", propertyName: "PathedRole")]
    public class PathedRole : ModelThing
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PathedRole"/> class
        /// </summary>
        public PathedRole()
        {
        }

        /// <summary>
        /// The <see cref="PathConditionRoleValueRestriction"/>
        /// </summary>
        [Description("The PathConditionRoleValueRestriction")]
        [Property(name: "ValueRestriction", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "PathConditionRoleValueRestriction")]
        public PathConditionRoleValueRestriction ValueRestriction { get; set; }

        /// <summary>
        /// The Purpose specification for a PathedRole.
        /// </summary>
        [Description("The Purpose specification for a PathedRole.")]
        [Property(name: "Purpose", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Enumeration, defaultValue: "SameFactType", typeName: "PathedRolePurpose")]
        public PathedRolePurpose Purpose { get; set; }

        /// <summary>
        /// Is this PathedRole Negated
        /// </summary>
        [Description("Is this PathedRole Negated")]
        [Property(name: "IsNegated", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Boolean, defaultValue: "false")]
        public bool IsNegated { get; set; }

        /// <summary>
        /// Gets or sets the referenced <see cref="RoleBase"/>
        /// </summary>
        [Description("")]
        [Property(name: "Role", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "RoleBase")]
        public RoleBase Role { get; set; }
    }
}
