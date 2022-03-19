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

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------

namespace Kalliope.DTO
{
    using System;
    using System.Collections.Generic;

    using Kalliope.Common;

    /// <summary>
    /// A Data Transfer Object that represents a SubtypeDerivationRule
    /// </summary>
    /// <remarks>
    /// A role path defining subtype population
    /// </remarks>
    [Container(typeName: "ObjectType", propertyName: "DerivationRule")]
    public partial class SubtypeDerivationRule : RolePathOwner
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubtypeDerivationRule"/> class.
        /// </summary>
        public SubtypeDerivationRule()
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
        [Description("Specify if a subtype can be explicitly populated without satisfying the derivation path.")]
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
        /// Gets the derived Id
        /// </summary>
        [Description("A unique identifier for this element")]
        [Property(name: "Id", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.String, defaultValue: "", typeName: "", allowOverride: false, isOverride: true, isDerived: true)]
        public override string Id => this.ComputeId();
 
    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
