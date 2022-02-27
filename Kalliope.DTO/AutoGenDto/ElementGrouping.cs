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

namespace Kalliope.DTO
{
    using System;
    using System.Collections.Generic;
 
    using Kalliope.Common;
 
    /// <summary>
    /// A Data Transfer Object that represents a ElementGrouping
    /// </summary>
    /// <remarks>
    /// A group of elements. A GroupType is associated with the Group to control the group contents
    /// </remarks>
    public partial class ElementGrouping : ORMNamedElement
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ElementGrouping"/> class.
        /// </summary>
        public  ElementGrouping()
        {
            this.ChildGroupings = new List<Guid>();
            this.ExcludedChildGroupings = new List<Guid>();
            this.ExcludedElements = new List<Guid>();
            this.GroupingTypes = new List<Guid>();
            this.IncludedChildGroupings = new List<Guid>();
            this.IncludedElements = new List<Guid>();
            this.MembershipContradictionErrors = new List<Guid>();
            this.TypeCompliance = GroupingMembershipTypeCompliance.NotExcluded;
        }
 
        /// <summary>
        /// Gets or sets a list unique identifiers of the referenced <see cref="ElementGrouping"/> instances
        /// </summary>
        public List<Guid> ChildGroupings { get; set; }
 
        /// <summary>
        /// Gets or sets the unique identifier of the contained <see cref="Definition"/>
        /// </summary>
        public Guid Definition { get; set; }
 
        /// <summary>
        /// Gets or sets the unique identifier of the referenced <see cref="ElementGroupingDuplicateNameError"/>
        /// </summary>
        public Guid DuplicateNameError { get; set; }
 
        /// <summary>
        /// Gets or sets a list unique identifiers of the referenced <see cref="ElementGrouping"/> instances
        /// </summary>
        public List<Guid> ExcludedChildGroupings { get; set; }
 
        /// <summary>
        /// Gets or sets a list unique identifiers of the referenced <see cref="ORMModelElement"/> instances
        /// </summary>
        public List<Guid> ExcludedElements { get; set; }
 
        /// <summary>
        /// Gets or sets a list unique identifiers of the contained <see cref="ElementGroupingType"/> instances
        /// </summary>
        public List<Guid> GroupingTypes { get; set; }
 
        /// <summary>
        /// Gets or sets a list unique identifiers of the referenced <see cref="ElementGrouping"/> instances
        /// </summary>
        public List<Guid> IncludedChildGroupings { get; set; }
 
        /// <summary>
        /// Gets or sets a list unique identifiers of the referenced <see cref="ORMModelElement"/> instances
        /// </summary>
        public List<Guid> IncludedElements { get; set; }
 
        /// <summary>
        /// Gets or sets a list unique identifiers of the contained <see cref="ElementGroupingMembershipContradictionError"/> instances
        /// </summary>
        public List<Guid> MembershipContradictionErrors { get; set; }
 
        /// <summary>
        /// Gets or sets the unique identifier of the contained <see cref="Note"/>
        /// </summary>
        public Guid Note { get; set; }
 
        /// <summary>
        /// Gets or sets a Priority
        /// </summary>
        public int Priority { get; set; }
 
        /// <summary>
        /// Gets or sets a TypeCompliance
        /// </summary>
        public GroupingMembershipTypeCompliance TypeCompliance { get; set; }
 
    }
}
