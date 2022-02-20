// -------------------------------------------------------------------------------------------------
// <copyright file="LogicalCombinationOperator.cs" company="RHEA System S.A.">
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
    using Kalliope.Attributes;

    /// <summary>
    /// Specifies the logical operator used to combine 2 or more elements
    /// </summary>
    [Description("Specifies the logical operator used to combine 2 or more elements")]
    public enum LogicalCombinationOperator
    {
        /// <summary>
        /// All values must be true
        /// </summary>
        /// <remarks>
        /// (DSL) The logical and operator
        /// </remarks>
        [Description("The logical and operator")]
        And = 0,

        /// <summary>
        /// At least one value must be true
        /// </summary>
        /// <remarks>
        /// (DSL) The logical inclusive-or operator
        /// </remarks>
        [Description("The logical inclusive-or operator")]
        Or = 1,

        /// <summary>
        /// Applied to two values, exactly one value must be true
        /// </summary>
        /// <remarks>
        /// (DSL) The logical exclusive-or operator
        /// </remarks>
        [Description("The logical exclusive-or operator")]
        Xor = 3
    }
}
