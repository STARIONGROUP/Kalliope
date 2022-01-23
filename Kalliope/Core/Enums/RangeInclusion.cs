// -------------------------------------------------------------------------------------------------
// <copyright file="RangeInclusion.cs" company="RHEA System S.A.">
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
    /// <summary>
    /// Specify whether the endpoint of a range is included in the range
    /// </summary>
    public enum RangeInclusion
    {
        /// <summary>
        /// Inclusion not explicitly set
        /// </summary>
        NotSet = 0,

        /// <summary>
        /// The endpoint is not included in the range of values
        /// </summary>
        /// <remarks>
        /// (DSL) Indicates the specific value is not included in the range
        /// </remarks>
        Open = 1,

        /// <summary>
        /// The endpoint is included in the range of values
        /// </summary>
        /// <remarks>
        /// (DSL) Indicates the specific value is included in the range
        /// </remarks>
        Closed = 2
    }
}
