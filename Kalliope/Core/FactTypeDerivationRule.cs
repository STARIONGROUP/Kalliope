// -------------------------------------------------------------------------------------------------
// <copyright file="QueryParameterBinding.cs" company="RHEA System S.A.">
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
    /// <summary>
    /// The formal derivation rule defining a fact type
    /// </summary>
    /// <remarks>
    /// (DSL) A role path defining a fact type derivation
    /// </remarks>
    public class FactTypeDerivationRule : RoleProjectedDerivationRule
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FactTypeDerivationRule"/> class
        /// </summary>
        public FactTypeDerivationRule()
        {
            this.DerivationCompleteness = DerivationCompleteness.FullyDerived;
            this.DerivationStorage = DerivationStorage.NotStored;
        }

        /// <summary>
        /// Specify if a fact can be explicitly populated without satisfying the derivation path
        /// </summary>
        public DerivationCompleteness DerivationCompleteness { get; set; }

        /// <summary>
        /// Specify if the derivation results are determined on demand or stored when derivation path components are changed
        /// </summary>
        public DerivationStorage DerivationStorage { get; set; }

        /// <summary>
        /// The derivation rule results in a set of distinct facts instead of a bag that might contain duplicates
        /// </summary>
        public bool SetProjection { get; set; }

        /// <summary>
        /// The name for a fully derived fact type
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// An empty path is a placeholder for an externally defined derivation rule and is not validated
        /// </summary>
        public bool ExternalDerivation { get; set; }

        /// <summary>
        /// Gets or sets the owned <see cref="DerivationNote"/>
        /// </summary>
        public DerivationNote DerivationNote {get; set; }
    }
}
