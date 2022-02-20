// -------------------------------------------------------------------------------------------------
// <copyright file="ValueComparisonOperator.cs" company="RHEA System S.A.">
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
    /// Restriction on the comparison operators allowed by a value comparison constraint
    /// </summary>
    [Description("Restriction on the comparison operators allowed by a value comparison constraint")]
    public enum ValueComparisonOperator
    {
        /// <summary>
        /// The comparison operator is undefined. Corresponds to a model validation error
        /// </summary>
        [Description("The comparison operator is undefined. Corresponds to a model validation error")]
        Undefined = 0,

        /// <summary>
        /// The first value is less than the second
        /// </summary>
        [Description("The first value is less than the second")]
        LessThan = 1,

        /// <summary>
        /// The first value is greater than the second
        /// </summary>
        [Description("The first value is greater than the second")]
        GreaterThan = 2,

        /// <summary>
        /// The first value is less than or equal to the second
        /// </summary>
        [Description("The first value is less than or equal to the second")]
        LessThanOrEqual = 3,

        /// <summary>
        /// The first value is greater than or equal to the second
        /// </summary>
        [Description("The first value is greater than or equal to the second")]
        GreaterThanOrEqual = 4,

        /// <summary>
        /// The two values must be equal
        /// </summary>
        [Description("The two values must be equal")]
        Equal = 5,

        /// <summary>
        /// The two values must not be equal
        /// </summary>
        [Description("The two values must not be equal")]
        NotEqual = 6,
    }
}
