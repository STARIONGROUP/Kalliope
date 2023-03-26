// -------------------------------------------------------------------------------------------------
// <copyright file="Group.cs" company="RHEA System S.A.">
//
//   Copyright 2022-2023 RHEA System S.A.
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

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------

namespace Kalliope.DTO
{
    using System;
    using System.Collections.Generic;

    using Kalliope.Common;

    /// <summary>
    /// A Data Transfer Object that represents a Group
    /// </summary>
    /// <remarks>
    /// References to set of related elements
    /// </remarks>
    public partial class Group : OrmNamedElement
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Group"/> class.
        /// </summary>
        public Group()
        {
            this.GroupTypes = new List<string>();
            this.ModelThings = new List<string>();
            this.TypeCompliance = GroupingMembershipTypeCompliance.NotExcluded;
        }
 

        /// <summary>
        /// Gets or sets a list unique identifiers of the contained <see cref="ElementGroupingType"/> instances
        /// </summary>
        [Description("The contained GroupTypes")]
        [Property(name: "GroupTypes", aggregation: AggregationKind.Composite, multiplicity: "0..*", typeKind: TypeKind.Object, defaultValue: "", typeName: "ElementGroupingType", allowOverride: false, isOverride: false, isDerived: false)]
        public List<string> GroupTypes { get; set; }
 
        /// <summary>
        /// Gets or sets a list unique identifiers of the referenced <see cref="ModelThing"/> instances
        /// </summary>
        [Description("The referenced (grouped) ModelThings")]
        [Property(name: "ModelThings", aggregation: AggregationKind.None, multiplicity: "0..*", typeKind: TypeKind.Object, defaultValue: "", typeName: "ModelThing", allowOverride: false, isOverride: false, isDerived: false)]
        public List<string> ModelThings { get; set; }
 
        /// <summary>
        /// Gets or sets a Priority
        /// </summary>
        [Description("The priority of this group, used to determine precedence if the same element is included in more than one group with the same group type Higher numbers have higher priority.")]
        [Property(name: "Priority", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Int32, defaultValue: "", typeName: "", allowOverride: false, isOverride: false, isDerived: false)]
        public int Priority { get; set; }
 
        /// <summary>
        /// Gets or sets a TypeCompliance
        /// </summary>
        [Description("The priority of this group, used to determine precedence if the same element is included in more than one group with the same group type Higher numbers have higher priority.")]
        [Property(name: "TypeCompliance", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Enumeration, defaultValue: "NotExcluded", typeName: "GroupingMembershipTypeCompliance", allowOverride: false, isOverride: false, isDerived: false)]
        public GroupingMembershipTypeCompliance TypeCompliance { get; set; }
 
    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
