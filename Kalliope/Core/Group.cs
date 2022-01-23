﻿// -------------------------------------------------------------------------------------------------
// <copyright file="Group.cs" company="RHEA System S.A.">
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
    /// References to set of related elements
    /// </summary>
    /// <remarks>
    /// (DSL) A group of elements. A <see cref="GroupType"/> is associated with the <see cref="Group"/> to control the <see cref="Group"/> contents
    /// </remarks>
    public class Group : ORMNamedElement
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Group"/> class.
        /// </summary>
        public Group()
        {
            this.TypeCompliance = GroupingMembershipTypeCompliance.NotExcluded;
        }

        /// <summary>
        /// The priority of this group, used to determine precedence if the same element is included in more than one group with the same group type.
        /// Higher numbers have higher priority
        /// </summary>
        public int Priority { get; set; }

        /// <summary>
        /// Determine how strictly group types control the group contents
        /// </summary>
        public GroupingMembershipTypeCompliance TypeCompliance { get; set; }
    }
}