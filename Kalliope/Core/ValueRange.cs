// -------------------------------------------------------------------------------------------------
// <copyright file="ValueRange.cs" company="RHEA System S.A.">
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

namespace Kalliope.Core
{
    using Kalliope.Common;

    /// <summary>
    /// A simple value range
    /// </summary>
    [Description("A simple value range")]
    [Domain(isAbstract: false, general: "OrmModelElement")]
    [Container(typeName: "ValueConstraint", propertyName: "ValueRanges")]
    public class ValueRange : OrmModelElement
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
        [Description("The lower bound for the range. An equivalent MaxValue indicates that the range represents a single value")]
        [Property(name: "MinValue", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.String, defaultValue: "", typeName: "")]
        public string MinValue { get; set; }

        /// <summary>
        /// The upper bound of the range. Duplicate of the MinValue for a single value
        /// </summary>
        [Description("The upper bound for the range. An equivalent MinValue indicates that the range represents a single value")]
        [Property(name: "MaxValue", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.String, defaultValue: "", typeName: "")]
        public string MaxValue { get; set; }

        /// <summary>
        /// Does the range include the lower bound?
        /// </summary>
        [Description("")]
        [Property(name: "MinInclusion", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Enumeration, defaultValue: "NotSet", typeName: "RangeInclusion")]
        public RangeInclusion MinInclusion { get; set; }

        /// <summary>
        /// Does the range include the upper bound?
        /// </summary>
        [Description("")]
        [Property(name: "MaxInclusion", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Enumeration, defaultValue: "NotSet", typeName: "RangeInclusion")]
        public RangeInclusion MaxInclusion { get; set; }

        /// <summary>
        /// A culture-invariant form of the minValue attribute.
        /// This value will not be set for a data type where any value is allowed (such as a string) or if the minValue could not be interpreted by the current data type
        /// </summary>
        [Description("The culture-invariant form of the MinValue property")]
        [Property(name: "InvariantMinValue", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.String, defaultValue: "", typeName: "")]
        public string InvariantMinValue { get; set; }

        /// <summary>
        /// A culture-invariant form of the maxValue attribute.
        /// This value will not be set for a data type where any value is allowed (such as a string) or if the minValue could not be interpreted by the current data type
        /// </summary>
        [Description("The culture-invariant form of the MaxValue property")]
        [Property(name: "InvariantMaxValue", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.String, defaultValue: "", typeName: "")]
        public string InvariantMaxValue { get; set; }

        /// <summary>
        /// Gets or sets the container <see cref="ValueConstraint"/>
        /// </summary>
        public ValueConstraint ValueConstraint { get; set; }

        /// <summary>
        /// Gets or sets the owned <see cref="MaxValueMismatchError"/>
        /// </summary>
        [Description("")]
        [Property(name: "MaxValueMismatchError", aggregation: AggregationKind.Composite, multiplicity: "0..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "MaxValueMismatchError")]
        public MaxValueMismatchError MaxValueMismatchError { get; set; }

        /// <summary>
        /// Gets or sets the owned <see cref="MinValueMismatchError"/>
        /// </summary>
        [Description("")]
        [Property(name: "MinValueMismatchError", aggregation: AggregationKind.Composite, multiplicity: "0..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "MinValueMismatchError")]
        public MinValueMismatchError MinValueMismatchError { get; set; }
    }
}
