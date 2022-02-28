// -------------------------------------------------------------------------------------------------
// <copyright file="SubtypeDerivationPath.cs" company="RHEA System S.A.">
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
    /// A role path used to define the population of a derived subtype
    /// </summary>
    [Description("A role path used to define the population of a derived subtype")]
    [Domain(isAbstract: false, general: "RolePathOwner")]
    public class SubtypeDerivationPath : RolePathOwner
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubtypeDerivationPath"/>
        /// </summary>
        public SubtypeDerivationPath()
        {
            this.DerivationCompleteness = DerivationCompleteness.FullyDerived;
            this.DerivationStorage = DerivationStorage.NotStored;
        }

        /// <summary>
        /// An empty derivation rule is externally defined
        /// </summary>
        [Description("An empty derivation rule is externally defined")]
        [Property(name: "ExternalDerivation", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Boolean, defaultValue: "", typeName: "")]
        public bool ExternalDerivation { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="DerivationCompleteness"/>
        /// </summary>
        [Description("")]
        [Property(name: "DerivationCompleteness", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Enumeration, defaultValue: "FullyDerived", typeName: "DerivationCompleteness")]
        public DerivationCompleteness DerivationCompleteness { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="DerivationStorage"/>
        /// </summary>
        [Description("")]
        [Property(name: "DerivationStorage", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Enumeration, defaultValue: "NotStored", typeName: "DerivationStorage")]
        public DerivationStorage DerivationStorage { get; set; }

        /// <summary>
        /// Gets or sets the contained <see cref="InformalDerivationRule"/>
        /// </summary>
        [Description("")]
        [Property(name: "InformalRule", aggregation: AggregationKind.Composite, multiplicity: "0..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "InformalDerivationRule")]
        public InformalDerivationRule InformalRule { get; set; }
    }
}
