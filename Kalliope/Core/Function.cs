// -------------------------------------------------------------------------------------------------
// <copyright file="Function.cs" company="RHEA System S.A.">
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

using System.Collections.Generic;

namespace Kalliope.Core
{
    /// <summary>
    /// Specifies a function definition used for calculating values
    /// </summary>
    /// <remarks>
    /// (DSL) A function or operator used to represented a calculation algorithm
    /// </remarks>
    public class Function : ORMNamedElement
    {
        /// <summary>
        /// True if this function or operator returns a boolean value, making it appropriate for use as a path condition
        /// </summary>
        public bool IsBoolean { get; set; }

        /// <summary>
        /// Set if this function defines a bag input parameter
        /// </summary>
        public bool IsAggregate { get; set; }

        /// <summary>
        /// A symbol used to display this function as an operator. Treated as an infix operator for binary functions and a prefix operator for unary functions
        /// </summary>
        public string OperatorSymbol { get; set; }

        /// <summary>
        /// The model defining this function
        /// </summary>
        public ORMModel Model { get; set; }

        /// <summary>
        /// Gets or sets the contained <see cref="FunctionParameter"/>s
        /// </summary>
        /// <remarks>
        /// Parameters defined by this function
        /// </remarks>
        public List<FunctionParameter> Parameters { get; set; }
    }
}
