// -------------------------------------------------------------------------------------------------
// <copyright file="ObjectifiedUnaryRole.cs" company="RHEA System S.A.">
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
    /// A Data Transfer Object that represents a ObjectifiedUnaryRole
    /// </summary>
    /// <remarks>
    /// A role representing the identifying role in the fact type implied between the object type that objectifies a unary role and the unary role player. There is an implied equality constraint between this role and the referenced unary role
    /// </remarks>
    public partial class ObjectifiedUnaryRole : Role
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectifiedUnaryRole"/> class.
        /// </summary>
        public ObjectifiedUnaryRole()
        {
        }
 

        /// <summary>
        /// Gets or sets the unique identifier of the referenced <see cref="Role"/>
        /// </summary>
        [Description("Links a unary role with the objectified unary role in the implied FactType. Implies a single-column equality constraint between the two roles.")]
        [Property(name: "TargetRole", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "Role", allowOverride: false, isOverride: false, isDerived: false)]
        public string TargetRole { get; set; }
 
    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
