// -------------------------------------------------------------------------------------------------
// <copyright file="ValueComparisonOperatorValues.cs" company="RHEA System S.A.">
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
    /// Restriction on the comparison operators allowed by a value comparison constraint
    /// </summary>
    public enum ValueComparisonOperatorValues
    {
        /// <summary>
        /// The comparison operator is undefined. Corresponds to a model validation error
        /// </summary>
        Undefined,

        /// <summary>
        /// The two values must be equal
        /// </summary>
        Equal,

        /// <summary>
        /// The two values must not be equal
        /// </summary>
        NotEqual,

        /// <summary>
        /// The first value is less than the second
        /// </summary>
        LessThan,

        /// <summary>
        /// The first value is less than or equal to the second
        /// </summary>
        LessThanOrEqual,

        /// <summary>
        /// The first value is greater than the second
        /// </summary>
        GreaterThan,

        /// <summary>
        /// The first value is greater than or equal to the second
        /// </summary>
        GreaterThanOrEqual
    }
}
