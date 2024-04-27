// -------------------------------------------------------------------------------------------------
// <copyright file="UniquenessConstraint.cs" company="Starion Group S.A.">
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
    /// A Data Transfer Object that represents a UniquenessConstraint
    /// </summary>
    /// <remarks>
    /// A constraint specifying that the population of a set must be unique
    /// </remarks>
    public partial class UniquenessConstraint : SetConstraint
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UniquenessConstraint"/> class.
        /// </summary>
        public UniquenessConstraint()
        {
        }
 

        /// <summary>
        /// Gets or sets a IsInternal
        /// </summary>
        [Description("")]
        [Property(name: "IsInternal", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Boolean, defaultValue: "false", typeName: "", allowOverride: false, isOverride: false, isDerived: false)]
        public bool IsInternal { get; set; }
 
        /// <summary>
        /// Gets or sets a IsPreferred
        /// </summary>
        [Description("Is this the preferred identifier for the EntityType role player of the opposite role(s)? The opposite role player of an internal constraint on an objectified FactType is the objectifying EntityType. Binary FactTypes with a spanning internal uniqueness constraint and ternary (or higher arity) FactTypes are automatically objectified")]
        [Property(name: "IsPreferred", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Boolean, defaultValue: "false", typeName: "", allowOverride: false, isOverride: false, isDerived: false)]
        public bool IsPreferred { get; set; }
 
        /// <summary>
        /// Gets or sets the unique identifier of the contained <see cref="NMinusOneError"/>
        /// </summary>
        [Description("")]
        [Property(name: "NMinusOneError", aggregation: AggregationKind.Composite, multiplicity: "0..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "NMinusOneError", allowOverride: false, isOverride: false, isDerived: false)]
        public string NMinusOneError { get; set; }
 
        /// <summary>
        /// Gets or sets the unique identifier of the referenced <see cref="ObjectType"/>
        /// </summary>
        [Description("")]
        [Property(name: "PreferredIdentifierFor", aggregation: AggregationKind.None, multiplicity: "0..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "ObjectType", allowOverride: false, isOverride: false, isDerived: false)]
        public string PreferredIdentifierFor { get; set; }
 
    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
