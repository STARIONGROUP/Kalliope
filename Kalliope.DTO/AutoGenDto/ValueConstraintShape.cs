// -------------------------------------------------------------------------------------------------
// <copyright file="ValueConstraintShape.cs" company="RHEA System S.A.">
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
    /// A Data Transfer Object that represents a ValueConstraintShape
    /// </summary>
    /// <remarks>
    /// Shape that represents a RoleValueConstraint or a ValueTypeValueConstraint
    /// </remarks>
    [Container(typeName: "ObjectTypeShape", propertyName: "ValueConstraintShapes")]
    public partial class ValueConstraintShape : FloatingTextShape
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ValueConstraintShape"/> class.
        /// </summary>
        public ValueConstraintShape()
        {
        }
 
        /// <summary>
        /// Gets or sets the unique identifier of the container
        /// </summary>
        public string Container {get; set;}
 

        /// <summary>
        /// Gets or sets a MaximumDisplayedColumns
        /// </summary>
        [Description("The maximum number of columns to be used to display the values and ranges in this shape")]
        [Property(name: "MaximumDisplayedColumns", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Int32, defaultValue: "0", typeName: "")]
        public int MaximumDisplayedColumns { get; set; }
 
        /// <summary>
        /// Gets or sets a MaximumDisplayedValues
        /// </summary>
        [Description("The maximum total number of values and ranges to be displayed with this shape")]
        [Property(name: "MaximumDisplayedValues", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Int32, defaultValue: "0", typeName: "")]
        public int MaximumDisplayedValues { get; set; }
 
        /// <summary>
        /// Gets or sets the unique identifier of the referenced <see cref="ValueConstraint"/>
        /// </summary>
        [Description("The subject ValueConstraint that is represented by this shape")]
        [Property(name: "Subject", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "ValueConstraint")]
        public string Subject { get; set; }
 
    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
