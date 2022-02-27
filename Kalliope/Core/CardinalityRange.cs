// -------------------------------------------------------------------------------------------------
// <copyright file="CardinalityRange.cs" company="RHEA System S.A.">
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
    using Kalliope.Common;

    /// <summary>
    /// A single cardinality range
    /// </summary>
    [Description("")]
    [Domain(isAbstract: false, general: "ORMModelElement")]
    [Container(typeName: "CardinalityConstraint", propertyName: "Ranges")]
    public class CardinalityRange : ORMModelElement
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CardinalityRange"/> class
        /// </summary>
        public CardinalityRange()
        {
            this.LowerBound = 0;
            this.UpperBound = -1;
        }

        /// <summary>
        /// The lower bound of the cardinality range.
        /// A value of zero indicates than an empty population is allowed
        /// </summary>
        public int From { get; set; }

        /// <summary>
        /// The upper bound of the cardinality range.
        /// Set to the same value as the 'From' attribute for a single-valued range. If this is omitted, then an unbounded range is assumed
        /// </summary>
        public int To { get; set; }

        /// <summary>
        /// The lower bound for the cardinality range. An equivalent upper bound indicates a discrete value. This has a minimum number of 0
        /// </summary>
        [Description("The lower bound for the cardinality range. An equivalent upper bound indicates a discrete value. This has a minimum number of 0")]
        [Property(name: "LowerBound", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Int32, defaultValue: "0", typeName: "")]
        public int LowerBound { get; set; }

        /// <summary>
        /// The upper bound of the range, or -1 if the range is unbounded
        /// </summary>
        [Description("The upper bound of the range, or -1 if the range is unbounded")]
        [Property(name: "UpperBound", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Int32, defaultValue: "-1", typeName: "")]
        public int UpperBound { get; set; }
    }
}
