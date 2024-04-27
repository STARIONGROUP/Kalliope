// -------------------------------------------------------------------------------------------------
// <copyright file="CalculatedPathValueInput.cs" company="Starion Group S.A.">
//
//   Copyright 2022-2024 Starion Group S.A.
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
    /// An input value or bag passed to a function parameter calculate a value
    /// </summary>
    [Description("An input value or bag passed to a function parameter calculate a value")]
    [Domain(isAbstract: false, general: "OrmModelElement")]
    [Container(typeName: "CalculatedPathValue", propertyName: "Inputs")]
    public class CalculatedPathValueInput : OrmModelElement
    {
        /// <summary>
        /// Should the bag be limited to distinct values, resulting in a set of values instead of a bag of values?
        /// </summary>
        [Description("")]
        [Property(name: "DistinctValues", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Boolean, defaultValue: "false", typeName: "")]
        public bool DistinctValues { get; set; }

        /// <summary>
        /// Gets or sets the owned <see cref="PathConstant"/>
        /// </summary>
        /// <remarks>
        /// The constant value bound to this function input
        /// </remarks>
        [Description("The constant value bound to this function input")]
        [Property(name: "SourceConstant", aggregation: AggregationKind.Composite, multiplicity: "0..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "PathConstant")]
        public PathConstant SourceConstant { get; set; }

        /// <summary>
        /// The function parameter associated with this input value
        /// </summary>
        [Description("The function parameter associated with this input value")]
        [Property(name: "Parameter", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "FunctionParameter")]
        public FunctionParameter Parameter { get; set; }

        /// <summary>
        /// The pathed value bound to this function input
        /// </summary>
        [Description("The pathed value bound to this function input")]
        [Property(name: "SourceCalculatedValue", aggregation: AggregationKind.None, multiplicity: "0..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "CalculatedPathValue")]
        public CalculatedPathValue SourceCalculatedValue { get; set; }
    }
}
