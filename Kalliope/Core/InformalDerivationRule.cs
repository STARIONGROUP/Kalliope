// -------------------------------------------------------------------------------------------------
// <copyright file="InformalDerivationRule.cs" company="RHEA System S.A.">
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
    /// An informal description of the intent of a derivation rule
    /// </summary>
    [Description("An informal description of the intent of a derivation rule")]
    [Domain(isAbstract: false, general: "OrmModelElement")]
    [Container(typeName: "SubtypeDerivationPath", propertyName: "InformalDerivationRule")]
    public class InformalDerivationRule : OrmModelElement
    {
        /// <summary>
        /// Gets the unique identifier of the <see cref="RoleText"/>
        /// </summary>
        [Description("A unique identifier for this element")]
        [Property(name: "Id", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.String, defaultValue: "", typeName: "", allowOverride: false, isOverride: true, isDerived: true)]
        public override string Id { get; set; }

        /// <summary>
        /// Gets or sets the owned <see cref="DerivationNote"/>
        /// </summary>
        [Description("")]
        [Property(name: "DerivationNote", aggregation: AggregationKind.Composite, multiplicity: "0..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "DerivationNote")]
        public DerivationNote DerivationNote { get; set; }
    }
}
