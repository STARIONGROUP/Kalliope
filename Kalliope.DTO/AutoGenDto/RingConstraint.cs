// -------------------------------------------------------------------------------------------------
// <copyright file="RingConstraint.cs" company="RHEA System S.A.">
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
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
 
namespace Kalliope.DTO
{
    using System;
    using System.Collections.Generic;
 
    using Kalliope.Common;
 
    /// <summary>
    /// A Data Transfer Object that represents a RingConstraint
    /// </summary>
    public partial class RingConstraint : SetConstraint
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RingConstraint"/> class.
        /// </summary>
        public RingConstraint()
        {
            this.RingType = RingConstraintType.Undefined;
        }
 

        /// <summary>
        /// Gets or sets the unique identifier of the contained <see cref="RingConstraintTypeNotSpecifiedError"/>
        /// </summary>
        [Description("")]
        [Property(name: "RingConstraintTypeNotSpecifiedError", aggregation: AggregationKind.Composite, multiplicity: "0..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "RingConstraintTypeNotSpecifiedError")]
        public string RingConstraintTypeNotSpecifiedError { get; set; }
 
        /// <summary>
        /// Gets or sets a RingType
        /// </summary>
        [Description("")]
        [Property(name: "RingType", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Enumeration, defaultValue: "Undefined", typeName: "RingConstraintType")]
        public RingConstraintType RingType { get; set; }
 
    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
