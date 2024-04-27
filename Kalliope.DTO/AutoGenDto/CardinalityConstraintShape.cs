// -------------------------------------------------------------------------------------------------
// <copyright file="CardinalityConstraintShape.cs" company="Starion Group S.A.">
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
    /// A Data Transfer Object that represents a CardinalityConstraintShape
    /// </summary>
    /// <remarks>
    /// Shape that represents a ObjectTypeCardinalityConstraint or a UnaryRoleCardinalityConstraint
    /// </remarks>
    [Container(typeName: "ObjectTypeShape", propertyName: "CardinalityConstraintShapes")]
    public partial class CardinalityConstraintShape : FloatingTextShape
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CardinalityConstraintShape"/> class.
        /// </summary>
        public CardinalityConstraintShape()
        {
        }
 
        /// <summary>
        /// Gets or sets the unique identifier of the container
        /// </summary>
        public string Container {get; set;}
 

        /// <summary>
        /// Gets or sets the unique identifier of the referenced <see cref="CardinalityConstraint"/>
        /// </summary>
        [Description("The subject CardinalityConstraint that is represented by this shape")]
        [Property(name: "Subject", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "CardinalityConstraint", allowOverride: false, isOverride: false, isDerived: false)]
        public string Subject { get; set; }
 
    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
