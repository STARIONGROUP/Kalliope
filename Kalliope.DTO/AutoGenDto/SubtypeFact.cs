// -------------------------------------------------------------------------------------------------
// <copyright file="SubtypeFact.cs" company="Starion Group S.A.">
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
    /// A Data Transfer Object that represents a SubtypeFact
    /// </summary>
    /// <remarks>
    /// A fact type representing the subtype meta relationship between a subtype and a supertype
    /// </remarks>
    public partial class SubtypeFact : FactType
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubtypeFact"/> class.
        /// </summary>
        public SubtypeFact()
        {
        }
 

        /// <summary>
        /// Gets or sets a IsPrimary
        /// </summary>
        [Description("")]
        [Property(name: "IsPrimary", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Boolean, defaultValue: "false", typeName: "", allowOverride: false, isOverride: false, isDerived: false)]
        public bool IsPrimary { get; set; }
 
        /// <summary>
        /// Gets or sets a PreferredIdentificationPath
        /// </summary>
        [Description("The subtype fact is a possible path through the subtype graph for retrieving the identifying supertype for the subtype.")]
        [Property(name: "PreferredIdentificationPath", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Boolean, defaultValue: "false", typeName: "", allowOverride: false, isOverride: false, isDerived: false)]
        public bool PreferredIdentificationPath { get; set; }
 
        /// <summary>
        /// Gets or sets a ProvidesPreferredIdentifier
        /// </summary>
        [Description("The preferred identification scheme for the subtype is provided by a supertype reached through this path")]
        [Property(name: "ProvidesPreferredIdentifier", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Boolean, defaultValue: "false", typeName: "", allowOverride: false, isOverride: false, isDerived: false)]
        public bool ProvidesPreferredIdentifier { get; set; }
 
    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
