// -------------------------------------------------------------------------------------------------
// <copyright file="PathConditionRoleValueRestriction.cs" company="RHEA System S.A.">
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

    [Description("Restrict the values required by a pathed role to satisfy the role path.")]
    [Domain(isAbstract: false, general: "ModelThing")]
    [Container(typeName: "PathedRole", propertyName: "ValueRestriction")]
    public class PathConditionRoleValueRestriction : ModelThing
    {
        /// <summary>
        /// The <see cref="ValueConstraint"/>
        /// </summary>
        [Description("The ValueConstraint")]
        [Property(name: "PathedRoleConditionValueConstraint", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "ValueConstraint")]
        public ValueConstraint PathedRoleConditionValueConstraint { get; set; }
    }
}
