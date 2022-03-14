// -------------------------------------------------------------------------------------------------
// <copyright file="ORMBaseShape.cs" company="RHEA System S.A.">
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
    /// A Data Transfer Object that represents a ORMBaseShape
    /// </summary>
    /// <remarks>
    /// Abstract super-type from which all shape classes derive
    /// </remarks>
    public abstract partial class ORMBaseShape : ModelThing
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ORMBaseShape"/> class.
        /// </summary>
        protected ORMBaseShape()
        {
        }
 

        /// <summary>
        /// Gets or sets a AbsoluteBounds
        /// </summary>
        [Description("absolute bounds")]
        [Property(name: "AbsoluteBounds", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.String, defaultValue: "", typeName: "")]
        public string AbsoluteBounds { get; set; }
 
        /// <summary>
        /// Gets or sets a IsExpanded
        /// </summary>
        [Description("a value indicating whether this shape is expanded or not")]
        [Property(name: "IsExpanded", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Boolean, defaultValue: "", typeName: "")]
        public bool IsExpanded { get; set; }
 
    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
