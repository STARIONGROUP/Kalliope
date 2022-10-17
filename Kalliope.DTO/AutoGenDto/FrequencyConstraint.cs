// -------------------------------------------------------------------------------------------------
// <copyright file="FrequencyConstraint.cs" company="RHEA System S.A.">
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
    /// A Data Transfer Object that represents a FrequencyConstraint
    /// </summary>
    /// <remarks>
    /// A constraint specifying the number of times an instance must occur in a set population. Applies only if the instance appears at all
    /// </remarks>
    public partial class FrequencyConstraint : SetConstraint
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FrequencyConstraint"/> class.
        /// </summary>
        public FrequencyConstraint()
        {
        }
 

        /// <summary>
        /// Gets or sets the unique identifier of the contained <see cref="FrequencyConstraintExactlyOneError"/>
        /// </summary>
        [Description("")]
        [Property(name: "FrequencyConstraintExactlyOneError", aggregation: AggregationKind.Composite, multiplicity: "0..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "FrequencyConstraintExactlyOneError", allowOverride: false, isOverride: false, isDerived: false)]
        public string FrequencyConstraintExactlyOneError { get; set; }
 
        /// <summary>
        /// Gets or sets the unique identifier of the contained <see cref="FrequencyConstraintMinMaxError"/>
        /// </summary>
        [Description("")]
        [Property(name: "FrequencyConstraintMinMaxError", aggregation: AggregationKind.Composite, multiplicity: "0..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "FrequencyConstraintMinMaxError", allowOverride: false, isOverride: false, isDerived: false)]
        public string FrequencyConstraintMinMaxError { get; set; }
 
        /// <summary>
        /// Gets or sets the unique identifier of the contained <see cref="FrequencyConstraintNonRestrictiveRangeError"/>
        /// </summary>
        [Description("")]
        [Property(name: "FrequencyConstraintNonRestrictiveRangeError", aggregation: AggregationKind.Composite, multiplicity: "0..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "FrequencyConstraintNonRestrictiveRangeError", allowOverride: false, isOverride: false, isDerived: false)]
        public string FrequencyConstraintNonRestrictiveRangeError { get; set; }
 
        /// <summary>
        /// Gets or sets the unique identifier of the contained <see cref="FrequencyConstraintViolatedByUniquenessConstraintError"/>
        /// </summary>
        [Description("")]
        [Property(name: "FrequencyConstraintViolatedByUniquenessConstraintError", aggregation: AggregationKind.Composite, multiplicity: "0..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "FrequencyConstraintViolatedByUniquenessConstraintError", allowOverride: false, isOverride: false, isDerived: false)]
        public string FrequencyConstraintViolatedByUniquenessConstraintError { get; set; }
 
        /// <summary>
        /// Gets or sets a MaxFrequency
        /// </summary>
        [Description("The maximum number of occurrences for each instance that plays the restricted roles")]
        [Property(name: "MaxFrequency", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Int32, defaultValue: "2", typeName: "", allowOverride: false, isOverride: false, isDerived: false)]
        public int MaxFrequency { get; set; }
 
        /// <summary>
        /// Gets or sets a MinFrequency
        /// </summary>
        [Description("The minimum number of occurrences for each instance that plays the restricted roles")]
        [Property(name: "MinFrequency", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Int32, defaultValue: "1", typeName: "", allowOverride: false, isOverride: false, isDerived: false)]
        public int MinFrequency { get; set; }
 
    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
