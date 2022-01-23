// -------------------------------------------------------------------------------------------------
// <copyright file="ElementGrouping.cs" company="RHEA System S.A.">
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
    /// User-defined and rule-based element groupings
    /// </summary>
    /// <remarks>
    /// A group of elements. A GroupType is associated with the Group to control the group contents
    /// </remarks>
    public class ElementGrouping : ORMNamedElement
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ElementGrouping"/> class
        /// </summary>
        public ElementGrouping()
        {
            this.TypeCompliance = GroupingMembershipTypeCompliance.NotExcluded;
            this.Priority = 0;
        }

        /// <summary>
        /// An informal description of this group
        /// /// To insert new lines, use Control-Enter in the dropdown editor, or open the 'ORM Informal Description Editor' tool window
        /// </summary>
        public string DefinitionText { get; set; }

        /// <summary>
        /// A note to associate with this group
        /// To insert new lines, use Control-Enter in the dropdown editor, or open the 'ORM Notes Editor' tool window
        /// </summary>
        public string NoteText { get; set; }

        /// <summary>
        /// Specify the level of GroupType compliance for elements in this group
        /// Not Excluded: Allow elements not explicitly excluded by a selected GroupType
        /// Approved by Some Type: Allow elements explicitly approved by at least one GroupType.
        /// Approved by All Types: Allow elements explicitly approved by all selected GroupTypes
        /// </summary>
        public GroupingMembershipTypeCompliance TypeCompliance { get; set; }

        /// <summary>
        /// Specify a priority relative to other Groups.
        /// If an element is included in two groups of the same type, the settings for the Group with the highest GroupPriority are given precedence
        /// </summary>
        public int Priority { get; set; }
    }
}
