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
        /// Gets or sets a DerivationCompleteness
        /// </summary>
        [Description("Specify if a fact can be explicitly populated without satisfying the derivation path")]
        [Property(name: "DerivationCompleteness", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Enumeration, defaultValue: "FullyDerived", typeName: "DerivationCompleteness", allowOverride: false, isOverride: false, isDerived: false)]
        public DerivationCompleteness DerivationCompleteness { get; set; }
 
        /// <summary>
        /// Gets or sets the unique identifier of the contained <see cref="DerivationNote"/>
        /// </summary>
        [Description("")]
        [Property(name: "DerivationNote", aggregation: AggregationKind.Composite, multiplicity: "0..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "DerivationNote", allowOverride: false, isOverride: false, isDerived: false)]
        public string DerivationNote { get; set; }
 
        /// <summary>
        /// Gets or sets a DerivationStorage
        /// </summary>
        [Description("Specify if the derivation results are determined on demand or stored when derivation path components are changed")]
        [Property(name: "DerivationStorage", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Enumeration, defaultValue: "NotStored", typeName: "DerivationStorage", allowOverride: false, isOverride: false, isDerived: false)]
        public DerivationStorage DerivationStorage { get; set; }
 
        /// <summary>
        /// Gets or sets a ExternalDerivation
        /// </summary>
        [Description("An empty path is a placeholder for an externally defined derivation rule and is not validated")]
        [Property(name: "ExternalDerivation", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Boolean, defaultValue: "false", typeName: "", allowOverride: false, isOverride: false, isDerived: false)]
        public bool ExternalDerivation { get; set; }
 
        /// <summary>
        /// Gets or sets a Name
        /// </summary>
        [Description("The name for a fully derived fact type")]
        [Property(name: "Name", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.String, defaultValue: "", typeName: "", allowOverride: false, isOverride: false, isDerived: false)]
        public string Name { get; set; }
 
        /// <summary>
        /// Gets or sets a SetProjection
        /// </summary>
        [Description("The derivation rule results in a set of distinct facts instead of a bag that might contain duplicates.")]
        [Property(name: "SetProjection", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Boolean, defaultValue: "false", typeName: "", allowOverride: false, isOverride: false, isDerived: false)]
        public bool SetProjection { get; set; }
 
    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
