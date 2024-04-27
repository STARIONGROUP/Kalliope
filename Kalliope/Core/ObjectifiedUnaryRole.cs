﻿// -------------------------------------------------------------------------------------------------
// <copyright file="RoleProxy.cs" company="Starion Group S.A.">
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

namespace Kalliope.Core
{
    using Kalliope.Common;

    /// <summary>
    /// A role representing the identifying role in the fact type implied between the object type that objectifies a unary role and the unary role player.
    /// There is an implied equality constraint between this role and the referenced unary role
    /// </summary>
    [Description("A role representing the identifying role in the fact type implied between the object type that objectifies a unary role and the unary role player. There is an implied equality constraint between this role and the referenced unary role")]
    [Domain(isAbstract: false, general: "Role")]
    public class ObjectifiedUnaryRole : Role
    {
        /// <summary>
        /// Gets or sets the referenced <see cref="Role"/>
        /// </summary>
        [Description("Links a unary role with the objectified unary role in the implied FactType. Implies a single-column equality constraint between the two roles.")]
        [Property(name: "TargetRole", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "Role")]
        public Role TargetRole { get; set; }
    }
}
