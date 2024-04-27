// -------------------------------------------------------------------------------------------------
// <copyright file="Function.cs" company="Starion Group S.A.">
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
    using System.Collections.Generic;

    using Kalliope.Common;

    /// <summary>
    /// Specifies a function definition used for calculating values
    /// </summary>
    /// <remarks>
    /// (DSL) A function or operator used to represented a calculation algorithm
    /// </remarks>
    [Description("A function or operator used to represented a calculation algorithm.")]
    [Domain(isAbstract: false, general: "OrmNamedElement")]
    [Container(typeName: "OrmModel", propertyName: "Functions")]
    public class Function : OrmNamedElement
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Function"/> class
        /// </summary>
        public Function()
        {
            this.DuplicateNameError = new FunctionDuplicateNameError();
            this.Parameters = new List<FunctionParameter>();
        }

        /// <summary>
        /// True if this function or operator returns a boolean value, making it appropriate for use as a path condition
        /// </summary>
        [Description("Set if this function returns a boolean value that can be evaluated directly as a condition")]
        [Property(name: "IsBoolean", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Boolean, defaultValue: "false", typeName: "")]
        public bool IsBoolean { get; set; }

        /// <summary>
        /// Set if this function defines a bag input parameter
        /// </summary>
        [Description("Set if this function defines a bag input parameter")]
        [Property(name: "IsAggregate", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Boolean, defaultValue: "false", typeName: "")]
        public bool IsAggregate { get; set; }

        /// <summary>
        /// A symbol used to display this function as an operator. Treated as an infix operator for binary functions and a prefix operator for unary functions
        /// </summary>
        [Description("A string indicating this function should be displayed as an operator instead of using functional notation. Represents infix notation for a binary operator and prefix notation for a unary")]
        [Property(name: "OperatorSymbol", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.String, defaultValue: "", typeName: "")]
        public string OperatorSymbol { get; set; }

        /// <summary>
        /// The model defining this function
        /// </summary>
        public OrmModel Model { get; set; }

        /// <summary>
        /// Gets or sets the contained <see cref="FunctionParameter"/>s
        /// </summary>
        /// <remarks>
        /// Parameters defined by this function
        /// </remarks>
        [Description("Parameters defined by this function")]
        [Property(name: "Parameters", aggregation: AggregationKind.Composite, multiplicity: "0..*", typeKind: TypeKind.Object, defaultValue: "", typeName: "FunctionParameter")]
        public List<FunctionParameter> Parameters { get; set; }

        /// <summary>
        /// Gets or sets the referenced <see cref="FunctionDuplicateNameError"/>
        /// </summary>
        [Description("")]
        [Property(name: "DuplicateNameError", aggregation: AggregationKind.None, multiplicity: "0..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "FunctionDuplicateNameError")]
        public FunctionDuplicateNameError DuplicateNameError { get; set; }
    }
}
