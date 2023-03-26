// -------------------------------------------------------------------------------------------------
// <copyright file="RoleProjectedDerivationRule.cs" company="RHEA System S.A.">
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

    /// <summary>
    /// Role path(s) projected onto a set of roles. Forms the base type for FactTypeDerivationRule and QueryDerivationRule
    /// </summary>
    [Description("Role path(s) projected onto a set of roles. Forms the base type for FactTypeDerivationRule and QueryDerivationRule")]
    [Domain(isAbstract: true, general: "RolePathOwner")]
    [Container(typeName: "FactType", propertyName: "DerivationRule")]
    public abstract class RoleProjectedDerivationRule : RolePathOwner
    {
        /// <summary>
        /// Gets or sets the owned <see cref="RoleProjectedDerivationRequiresProjectionError"/>
        /// </summary>
        [Description("")]
        [Property(name: "ProjectionRequiredError", aggregation: AggregationKind.Composite, multiplicity: "0..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "RoleProjectedDerivationRequiresProjectionError")]
        public RoleProjectedDerivationRequiresProjectionError ProjectionRequiredError { get; set; }
    }
}
