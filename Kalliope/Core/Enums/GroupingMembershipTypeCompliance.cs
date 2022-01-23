// -------------------------------------------------------------------------------------------------
// <copyright file="GroupingMembershipTypeCompliance.cs" company="RHEA System S.A.">
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
    /// Determine how strictly group types control the group contents
    /// </summary>
    public enum GroupingMembershipTypeCompliance
    {
        /// <summary>
        /// Allow any element that is not explicitly blocked by a group type
        /// </summary>
        /// <remarks>
        /// (DSL) Allow all elements that are not explicitly excluded by a GroupType
        /// </remarks>
        NotExcluded = 0,

        /// <summary>
        /// At least one associated group type recognizes the element
        /// </summary>
        /// <remarks>
        /// (DSL) Allow all elements that are explicitly approved by at least one GroupType
        /// </remarks>
        PartiallyApproved = 1,

        /// <summary>
        /// All associated group types recognize the element
        /// </summary>
        /// <remarks>
        /// (DSL) Allow elements that are explicitly approved by all GroupTypes
        /// </remarks>
        FullyApproved = 2
    }
}
