// -------------------------------------------------------------------------------------------------
// <copyright file="SubtypeDerivationPath.cs" company="Starion Group S.A.">
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

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------

namespace Kalliope.DTO
{
    using System;
    using System.Collections.Generic;

    using Kalliope.Common;

    /// <summary>
    /// A Data Transfer Object that represents a SubtypeDerivationPath
    /// </summary>
    /// <remarks>
    /// A role path used to define the population of a derived subtype
    /// </remarks>
    public partial class SubtypeDerivationPath : RolePathOwner
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubtypeDerivationPath"/> class.
        /// </summary>
        public SubtypeDerivationPath()
        {
            this.DerivationCompleteness = DerivationCompleteness.FullyDerived;
            this.DerivationStorage = DerivationStorage.NotStored;
        }
 

        /// <summary>
        /// Gets or sets a DerivationCompleteness
        /// </summary>
        [Description("")]
        [Property(name: "DerivationCompleteness", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Enumeration, defaultValue: "FullyDerived", typeName: "DerivationCompleteness", allowOverride: false, isOverride: false, isDerived: false)]
        public DerivationCompleteness DerivationCompleteness { get; set; }
 
        /// <summary>
        /// Gets or sets a DerivationStorage
        /// </summary>
        [Description("")]
        [Property(name: "DerivationStorage", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Enumeration, defaultValue: "NotStored", typeName: "DerivationStorage", allowOverride: false, isOverride: false, isDerived: false)]
        public DerivationStorage DerivationStorage { get; set; }
 
        /// <summary>
        /// Gets or sets a ExternalDerivation
        /// </summary>
        [Description("An empty derivation rule is externally defined")]
        [Property(name: "ExternalDerivation", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Boolean, defaultValue: "", typeName: "", allowOverride: false, isOverride: false, isDerived: false)]
        public bool ExternalDerivation { get; set; }
 
        /// <summary>
        /// Gets or sets the unique identifier of the contained <see cref="InformalDerivationRule"/>
        /// </summary>
        [Description("")]
        [Property(name: "InformalRule", aggregation: AggregationKind.Composite, multiplicity: "0..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "InformalDerivationRule", allowOverride: false, isOverride: false, isDerived: false)]
        public string InformalRule { get; set; }
 
    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
