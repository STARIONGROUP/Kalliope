// -------------------------------------------------------------------------------------------------
// <copyright file="ValueRange.cs" company="RHEA System S.A.">
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

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------

namespace Kalliope.DTO
{
    using System;
    using System.Collections.Generic;

    using Kalliope.Common;

    /// <summary>
    /// A Data Transfer Object that represents a ValueRange
    /// </summary>
    [Container(typeName: "ValueConstraint", propertyName: "ValueRanges")]
    public partial class ValueRange : OrmModelElement
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ValueRange"/> class.
        /// </summary>
        public ValueRange()
        {
            this.MaxInclusion = RangeInclusion.NotSet;
            this.MinInclusion = RangeInclusion.NotSet;
        }
 
        /// <summary>
        /// Gets or sets the unique identifier of the container
        /// </summary>
        public string Container {get; set;}
 

        /// <summary>
        /// Gets or sets a InvariantMaxValue
        /// </summary>
        [Description("The culture-invariant form of the MaxValue property")]
        [Property(name: "InvariantMaxValue", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.String, defaultValue: "", typeName: "", allowOverride: false, isOverride: false, isDerived: false)]
        public string InvariantMaxValue { get; set; }
 
        /// <summary>
        /// Gets or sets a InvariantMinValue
        /// </summary>
        [Description("The culture-invariant form of the MinValue property")]
        [Property(name: "InvariantMinValue", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.String, defaultValue: "", typeName: "", allowOverride: false, isOverride: false, isDerived: false)]
        public string InvariantMinValue { get; set; }
 
        /// <summary>
        /// Gets or sets a MaxInclusion
        /// </summary>
        [Description("")]
        [Property(name: "MaxInclusion", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Enumeration, defaultValue: "NotSet", typeName: "RangeInclusion", allowOverride: false, isOverride: false, isDerived: false)]
        public RangeInclusion MaxInclusion { get; set; }
 
        /// <summary>
        /// Gets or sets a MaxValue
        /// </summary>
        [Description("The upper bound for the range. An equivalent MinValue indicates that the range represents a single value")]
        [Property(name: "MaxValue", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.String, defaultValue: "", typeName: "", allowOverride: false, isOverride: false, isDerived: false)]
        public string MaxValue { get; set; }
 
        /// <summary>
        /// Gets or sets the unique identifier of the contained <see cref="MaxValueMismatchError"/>
        /// </summary>
        [Description("")]
        [Property(name: "MaxValueMismatchError", aggregation: AggregationKind.Composite, multiplicity: "0..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "MaxValueMismatchError", allowOverride: false, isOverride: false, isDerived: false)]
        public string MaxValueMismatchError { get; set; }
 
        /// <summary>
        /// Gets or sets a MinInclusion
        /// </summary>
        [Description("")]
        [Property(name: "MinInclusion", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Enumeration, defaultValue: "NotSet", typeName: "RangeInclusion", allowOverride: false, isOverride: false, isDerived: false)]
        public RangeInclusion MinInclusion { get; set; }
 
        /// <summary>
        /// Gets or sets a MinValue
        /// </summary>
        [Description("The lower bound for the range. An equivalent MaxValue indicates that the range represents a single value")]
        [Property(name: "MinValue", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.String, defaultValue: "", typeName: "", allowOverride: false, isOverride: false, isDerived: false)]
        public string MinValue { get; set; }
 
        /// <summary>
        /// Gets or sets the unique identifier of the contained <see cref="MinValueMismatchError"/>
        /// </summary>
        [Description("")]
        [Property(name: "MinValueMismatchError", aggregation: AggregationKind.Composite, multiplicity: "0..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "MinValueMismatchError", allowOverride: false, isOverride: false, isDerived: false)]
        public string MinValueMismatchError { get; set; }
 
    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
