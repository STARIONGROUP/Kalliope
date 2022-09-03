// -------------------------------------------------------------------------------------------------
// <copyright file="RoleBase.cs" company="RHEA System S.A.">
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

    [Description("")]
    [Domain(isAbstract: true, general: "OrmModelElement")]
    [Container(typeName: "ConstraintRoleSequence", propertyName: "Roles")]
    [Container(typeName: "FactType", propertyName: "Roles")]
    public abstract class RoleBase : OrmModelElement
    {
        /// <summary>
        /// An explicit name for this role
        /// </summary>
        [Description("An explicit name for this role")]
        [Property(name: "Name", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.String, defaultValue: "", typeName: "")]
        public string Name { get; set; }
    }
}
