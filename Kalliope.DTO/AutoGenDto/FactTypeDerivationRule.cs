// -------------------------------------------------------------------------------------------------
// <copyright file="FactTypeDerivationRule.cs" company="RHEA System S.A.">
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
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
 
namespace Kalliope.DTO
{
    using System;
    using System.Collections.Generic;
 
    using Kalliope.Common;
 
    /// <summary>
    /// A Data Transfer Object that represents a FactTypeDerivationRule
    /// </summary>
    /// <remarks>
    /// A role path defining a fact type derivation
    /// </remarks>
    public partial class FactTypeDerivationRule : RoleProjectedDerivationRule
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FactTypeDerivationRule"/> class.
        /// </summary>
        public FactTypeDerivationRule()
        {
            this.DerivationCompleteness = DerivationCompleteness.FullyDerived;
            this.DerivationStorage = DerivationStorage.NotStored;
        }
 
        /// <summary>
        /// Gets or sets the unique identifier of the container
        /// </summary>
        public string Container {get; set;}
 

        /// <summary>
        /// Gets or sets a DerivationCompleteness
        /// </summary>
        public DerivationCompleteness DerivationCompleteness { get; set; }
 
        /// <summary>
        /// Gets or sets the unique identifier of the contained <see cref="DerivationNote"/>
        /// </summary>
        public string DerivationNote { get; set; }
 
        /// <summary>
        /// Gets or sets a DerivationStorage
        /// </summary>
        public DerivationStorage DerivationStorage { get; set; }
 
        /// <summary>
        /// Gets or sets a ExternalDerivation
        /// </summary>
        public bool ExternalDerivation { get; set; }
 
        /// <summary>
        /// Gets or sets a Name
        /// </summary>
        public string Name { get; set; }
 
        /// <summary>
        /// Gets or sets a SetProjection
        /// </summary>
        public bool SetProjection { get; set; }
 
    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
