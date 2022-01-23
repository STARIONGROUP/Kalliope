// -------------------------------------------------------------------------------------------------
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

namespace Kalliope.ObjectModel
{
    /// <summary>
    /// References to set of related elements
    /// </summary>
    public class Group
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Group"/> class.
        /// </summary>
        public Group()
        {
            this.TypeCompliance = TypeCompliance.NotExcluded;
        }

        /// <summary>
        /// A unique identifier for this element
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// The group name. Validation errors will be present for any object type name that is not unique within the model
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The priority of this group, used to determine precedence if the same element is included in more than one group with the same group type.
        /// Higher numbers have higher priority
        /// </summary>
        public int Priority { get; set; }

        /// <summary>
        /// Determine how strictly group types control the group contents
        /// </summary>
        public TypeCompliance TypeCompliance { get; set; }
    }
}
