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

namespace Kalliope.Core
{
    using System;
    using System.Xml;

    /// <summary>
    /// A simple value range
    /// </summary>
    public class ValueRange : ORMModelElement
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ValueRange"/> class
        /// </summary>
        public ValueRange()
        {
            this.MinInclusion = RangeInclusion.NotSet;
            this.MaxInclusion = RangeInclusion.NotSet;
        }

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
        public RangeInclusion MinInclusion { get; set; }

        /// <summary>
        /// Does the range include the upper bound?
        /// </summary>
        public RangeInclusion MaxInclusion { get; set; }

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

        /// <summary>
        /// Gets or sets the container <see cref="ValueConstraint"/>
        /// </summary>
        public ValueConstraint ValueConstraint { get; set; }

        /// <summary>
        /// Gets or sets the owned <see cref="MaxValueMismatchError"/>
        /// </summary>
        public MaxValueMismatchError MaxValueMismatchError { get; set; }

        /// <summary>
        /// Gets or sets the owned <see cref="MinValueMismatchError"/>
        /// </summary>
        public MinValueMismatchError MinValueMismatchError { get; set; }

        /// <summary>
        /// Generates a <see cref="ValueRange"/> object from its XML representation.
        /// </summary>
        /// <param name="reader">
        /// an instance of <see cref="XmlReader"/> used to read the .orm file
        /// </param>
        internal override void ReadXml(XmlReader reader)
        {
            base.ReadXml(reader);

            this.MinValue = reader.GetAttribute("MinValue");
            this.MaxValue = reader.GetAttribute("MaxValue");

            var minInclusionAttribute = reader.GetAttribute("MinInclusion");
            if (Enum.TryParse(minInclusionAttribute, out RangeInclusion minInclusion))
            {
                this.MinInclusion = minInclusion;
            }

            var maxInclusionAttribute = reader.GetAttribute("MaxInclusion");
            if (Enum.TryParse(maxInclusionAttribute, out RangeInclusion maxInclusion))
            {
                this.MaxInclusion = maxInclusion;
            }
        }
    }
}
