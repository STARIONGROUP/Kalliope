// -------------------------------------------------------------------------------------------------
// <copyright file="ValueComparisonConstraint.cs" company="RHEA System S.A.">
//
//   Copyright 2022-2023 RHEA System S.A.
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
    /// A Data Transfer Object that represents a ValueComparisonConstraint
    /// </summary>
    /// <remarks>
    /// A constraint specifying that a comparison between two related values must be satisfied
    /// </remarks>
    public partial class ValueComparisonConstraint : SetConstraint
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ValueComparisonConstraint"/> class.
        /// </summary>
        public ValueComparisonConstraint()
        {
            this.Operator = ValueComparisonOperator.Undefined;
        }
 

        /// <summary>
        /// Gets or sets a Operator
        /// </summary>
        [Description("")]
        [Property(name: "Operator", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Enumeration, defaultValue: "Undefined", typeName: "ValueComparisonOperator", allowOverride: false, isOverride: false, isDerived: false)]
        public ValueComparisonOperator Operator { get; set; }
 
        /// <summary>
        /// Gets or sets the unique identifier of the contained <see cref="ValueComparisonConstraintOperatorNotSpecifiedError"/>
        /// </summary>
        [Description("")]
        [Property(name: "OperatorNotSpecifiedError", aggregation: AggregationKind.Composite, multiplicity: "0..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "ValueComparisonConstraintOperatorNotSpecifiedError", allowOverride: false, isOverride: false, isDerived: false)]
        public string OperatorNotSpecifiedError { get; set; }
 
        /// <summary>
        /// Gets or sets the unique identifier of the contained <see cref="ValueComparisonRolesNotComparableError"/>
        /// </summary>
        [Description("")]
        [Property(name: "RolesNotComparableError", aggregation: AggregationKind.Composite, multiplicity: "0..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "ValueComparisonRolesNotComparableError", allowOverride: false, isOverride: false, isDerived: false)]
        public string RolesNotComparableError { get; set; }
 
    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
