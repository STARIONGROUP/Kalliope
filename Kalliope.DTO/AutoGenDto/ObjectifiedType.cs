// -------------------------------------------------------------------------------------------------
// <copyright file="ObjectifiedType.cs" company="Starion Group S.A.">
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
    /// A Data Transfer Object that represents a ObjectifiedType
    /// </summary>
    /// <remarks>
    /// An entity type that objectifies a fact type
    /// </remarks>
    public partial class ObjectifiedType : ObjectType
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectifiedType"/> class.
        /// </summary>
        public ObjectifiedType()
        {
        }
 

        /// <summary>
        /// Gets or sets the unique identifier of the contained <see cref="Objectification"/>
        /// </summary>
        [Description("")]
        [Property(name: "NestedPredicate", aggregation: AggregationKind.Composite, multiplicity: "1..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "Objectification", allowOverride: false, isOverride: false, isDerived: false)]
        public string NestedPredicate { get; set; }
 
        /// <summary>
        /// Gets or sets the unique identifier of the referenced <see cref="UniquenessConstraint"/>
        /// </summary>
        [Description("A reference to the uniqueness constraint that provides the preferred identification scheme for this entity type")]
        [Property(name: "PreferredIdentifier", aggregation: AggregationKind.None, multiplicity: "0..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "UniquenessConstraint", allowOverride: false, isOverride: false, isDerived: false)]
        public string PreferredIdentifier { get; set; }
 
    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
