// -------------------------------------------------------------------------------------------------
// <copyright file="SubtypeDerivationRule.cs" company="RHEA System S.A.">
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
    /// A role path defining subtype population
    /// </summary>
    /// <remarks>
    /// The formal derivation rule defining a subtype
    /// </remarks>
    [Description("A role path defining subtype population")]
    [Domain(isAbstract: false, general: "RolePathOwner")]
    [Container(typeName: "ObjectType", propertyName: "DerivationRule")]
    public class SubtypeDerivationRule : RolePathOwner
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubtypeDerivationRule"/> class
        /// </summary>
        public SubtypeDerivationRule()
        {
            this.DerivationCompleteness = DerivationCompleteness.FullyDerived;
            this.DerivationStorage = DerivationStorage.NotStored;
        }

        /// <summary>
        /// Gets the unique identifier of the <see cref="RoleText"/>
        /// </summary>
        [Description("A unique identifier for this element")]
        [Property(name: "Id", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.String, defaultValue: "", typeName: "", allowOverride: false, isOverride: true, isDerived: true)]
        public override string Id { get; set; }

        /// <summary>
        /// Specify if a subtype can be explicitly populated without satisfying the derivation path
        /// </summary>
        [Description("Specify if a subtype can be explicitly populated without satisfying the derivation path.")]
        [Property(name: "DerivationCompleteness", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Enumeration, defaultValue: "FullyDerived", typeName: "DerivationCompleteness")]
        public DerivationCompleteness DerivationCompleteness { get; set; }

        /// <summary>
        /// Specify if the derivation results are determined on demand or stored when derivation path components are changed
        /// </summary>
        [Description("Specify if the derivation results are determined on demand or stored when derivation path components are changed")]
        [Property(name: "DerivationStorage", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Enumeration, defaultValue: "NotStored", typeName: "DerivationStorage")]
        public DerivationStorage DerivationStorage { get; set; }

        /// <summary>
        /// An empty path is a placeholder for an externally defined derivation rule and is not validated
        /// </summary>
        [Description("An empty path is a placeholder for an externally defined derivation rule and is not validated")]
        [Property(name: "ExternalDerivation", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Boolean, defaultValue: "false", typeName: "")]
        public bool ExternalDerivation { get; set; }

        /// <summary>
        /// Gets or sets the owned <see cref="DerivationNote"/>
        /// </summary>
        [Description("")]
        [Property(name: "DerivationNote", aggregation: AggregationKind.Composite, multiplicity: "0..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "DerivationNote")]
        public DerivationNote DerivationNote { get; set; }

        /// <summary>
        /// Gets or sets the owned <see cref="SubtypeDerivationPath"/>
        /// </summary>
        public SubtypeDerivationPath SubtypeDerivationPath { get; set; }
    }
}
