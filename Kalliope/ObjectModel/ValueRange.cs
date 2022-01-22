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

namespace Kalliope.ObjectModel
{
    /// <summary>
    /// A simple value range
    /// </summary>
    public class ValueRange
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ValueRange"/> class
        /// </summary>
        public ValueRange()
        {
            this.MinInclusion = RangeInclusionValues.NotSet;
            this.MaxInclusion = RangeInclusionValues.NotSet;
        }

        /// <summary>
        /// A unique identifier for this element
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// The lower bound for the range
        /// </summary>
        public string MinValue { get; set; }

        /// <summary>
        /// The upper bound of the range. Duplicate of the MinValue for a single value
        /// </summary>
        public string MaxValue { get; set; }

        /// <summary>
        /// Does the range include the lower bound?
        /// </summary>
        public RangeInclusionValues MinInclusion { get; set; }

        /// <summary>
        /// Does the range include the upper bound?
        /// </summary>
        public RangeInclusionValues MaxInclusion { get; set; }

        /// <summary>
        /// A culture-invariant form of the minValue attribute.
        /// This value will not be set for a data type where any value is allowed (such as a string) or if the minValue could not be interpreted by the current data type
        /// </summary>
        public string InvariantMinValue { get; set; }

        /// <summary>
        /// A culture-invariant form of the maxValue attribute.
        /// This value will not be set for a data type where any value is allowed (such as a string) or if the minValue could not be interpreted by the current data type
        /// </summary>
        public string InvariantMaxValue { get; set; }
    }
}
