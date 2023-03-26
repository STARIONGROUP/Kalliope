// -------------------------------------------------------------------------------------------------
// <copyright file="CompatibleRolePlayerTypeError.cs" company="RHEA System S.A.">
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
    /// A Data Transfer Object that represents a CompatibleRolePlayerTypeError
    /// </summary>
    /// <remarks>
    /// Incompatible Constrained Role Players
    /// </remarks>
    [Container(typeName: "SetComparisonConstraint", propertyName: "CompatibleRolePlayerTypeErrors")]
    [Container(typeName: "SetConstraint", propertyName: "CompatibleRolePlayerTypeError")]
    public partial class CompatibleRolePlayerTypeError : ModelError
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CompatibleRolePlayerTypeError"/> class.
        /// </summary>
        public CompatibleRolePlayerTypeError()
        {
        }
 

        /// <summary>
        /// Gets or sets a Column
        /// </summary>
        [Description("")]
        [Property(name: "Column", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Int32, defaultValue: "0", typeName: "", allowOverride: false, isOverride: false, isDerived: false)]
        public int Column { get; set; }
 
    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
