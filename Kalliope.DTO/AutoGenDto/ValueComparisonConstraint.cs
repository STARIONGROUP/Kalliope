// -------------------------------------------------------------------------------------------------
// <copyright file="ValueComparisonConstraint.cs" company="RHEA System S.A.">
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

namespace Kalliope.DTO
{
    using System;
    using System.Collections.Generic;
 
    using Kalliope.Common;
 
    /// <summary>
    /// A Data Transfer Object that represents a ValueComparisonConstraint
    /// </summary>
    public partial class ValueComparisonConstraint : SetConstraint
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ValueComparisonConstraint"/> class.
        /// </summary>
        public  ValueComparisonConstraint()
        {
            this.Operator = ValueComparisonOperator.Undefined;
        }
 
        /// <summary>
        /// Gets or sets a Operator
        /// </summary>
        public ValueComparisonOperator Operator { get; set; }
 
        /// <summary>
        /// Gets or sets the unique identifier of the contained <see cref="ValueComparisonConstraintOperatorNotSpecifiedError"/>
        /// </summary>
        public Guid OperatorNotSpecifiedError { get; set; }
 
        /// <summary>
        /// Gets or sets the unique identifier of the contained <see cref="ValueComparisonRolesNotComparableError"/>
        /// </summary>
        public Guid RolesNotComparableError { get; set; }
 
    }
}
