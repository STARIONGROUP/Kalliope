// -------------------------------------------------------------------------------------------------
// <copyright file="ElementGrouping.cs" company="RHEA System S.A.">
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
    /// A Data Transfer Object that represents a ElementGrouping
    /// </summary>
    /// <remarks>
    /// A group of elements. A GroupType is associated with the Group to control the group contents
    /// </remarks>
    [Container(typeName: "ElementGroupingSet", propertyName: "Groupings")]
    public partial class ElementGrouping : OrmNamedElement
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ElementGrouping"/> class.
        /// </summary>
        public ElementGrouping()
        {
            this.ChildGroupings = new List<string>();
            this.ExcludedChildGroupings = new List<string>();
            this.ExcludedElements = new List<string>();
            this.IncludedChildGroupings = new List<string>();
            this.IncludedElements = new List<string>();
            this.MembershipContradictionErrors = new List<string>();
            this.TypeCompliance = GroupingMembershipTypeCompliance.NotExcluded;
        }
 
        /// <summary>
        /// Gets or sets the unique identifier of the container
        /// </summary>
        public string Container {get; set;}
 

        /// <summary>
        /// Gets or sets a list unique identifiers of the referenced <see cref="ElementGrouping"/> instances
        /// </summary>
        [Description("")]
        [Property(name: "ChildGroupings", aggregation: AggregationKind.None, multiplicity: "0..*", typeKind: TypeKind.Object, defaultValue: "", typeName: "ElementGrouping", allowOverride: false, isOverride: false, isDerived: false)]
        public List<string> ChildGroupings { get; set; }
 
        /// <summary>
        /// Gets or sets the unique identifier of the contained <see cref="Definition"/>
        /// </summary>
        [Description("")]
        [Property(name: "Definition", aggregation: AggregationKind.Composite, multiplicity: "0..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "Definition", allowOverride: false, isOverride: false, isDerived: false)]
        public string Definition { get; set; }
 
        /// <summary>
        /// Gets or sets the unique identifier of the referenced <see cref="ElementGroupingDuplicateNameError"/>
        /// </summary>
        [Description("")]
        [Property(name: "DuplicateNameError", aggregation: AggregationKind.None, multiplicity: "0..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "ElementGroupingDuplicateNameError", allowOverride: false, isOverride: false, isDerived: false)]
        public string DuplicateNameError { get; set; }
 
        /// <summary>
        /// Gets or sets a list unique identifiers of the referenced <see cref="ElementGrouping"/> instances
        /// </summary>
        [Description("")]
        [Property(name: "ExcludedChildGroupings", aggregation: AggregationKind.None, multiplicity: "0..*", typeKind: TypeKind.Object, defaultValue: "", typeName: "ElementGrouping", allowOverride: false, isOverride: false, isDerived: false)]
        public List<string> ExcludedChildGroupings { get; set; }
 
        /// <summary>
        /// Gets or sets a list unique identifiers of the referenced <see cref="OrmModelElement"/> instances
        /// </summary>
        [Description("")]
        [Property(name: "ExcludedElements", aggregation: AggregationKind.None, multiplicity: "0..*", typeKind: TypeKind.Object, defaultValue: "", typeName: "OrmModelElement", allowOverride: false, isOverride: false, isDerived: false)]
        public List<string> ExcludedElements { get; set; }
 
        /// <summary>
        /// Gets or sets a list unique identifiers of the referenced <see cref="ElementGrouping"/> instances
        /// </summary>
        [Description("")]
        [Property(name: "IncludedChildGroupings", aggregation: AggregationKind.None, multiplicity: "0..*", typeKind: TypeKind.Object, defaultValue: "", typeName: "ElementGrouping", allowOverride: false, isOverride: false, isDerived: false)]
        public List<string> IncludedChildGroupings { get; set; }
 
        /// <summary>
        /// Gets or sets a list unique identifiers of the referenced <see cref="OrmModelElement"/> instances
        /// </summary>
        [Description("")]
        [Property(name: "IncludedElements", aggregation: AggregationKind.None, multiplicity: "0..*", typeKind: TypeKind.Object, defaultValue: "", typeName: "OrmModelElement", allowOverride: false, isOverride: false, isDerived: false)]
        public List<string> IncludedElements { get; set; }
 
        /// <summary>
        /// Gets or sets a list unique identifiers of the contained <see cref="ElementGroupingMembershipContradictionError"/> instances
        /// </summary>
        [Description("")]
        [Property(name: "MembershipContradictionErrors", aggregation: AggregationKind.Composite, multiplicity: "0..*", typeKind: TypeKind.Object, defaultValue: "", typeName: "ElementGroupingMembershipContradictionError", allowOverride: false, isOverride: false, isDerived: false)]
        public List<string> MembershipContradictionErrors { get; set; }
 
        /// <summary>
        /// Gets or sets the unique identifier of the contained <see cref="Note"/>
        /// </summary>
        [Description("")]
        [Property(name: "Note", aggregation: AggregationKind.Composite, multiplicity: "0..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "Note", allowOverride: false, isOverride: false, isDerived: false)]
        public string Note { get; set; }
 
        /// <summary>
        /// Gets or sets a Priority
        /// </summary>
        [Description("Specify a priority relative to other Groups. If an element is included in two groups of the same type, the settings for the Group with the highest GroupPriority are given precedence")]
        [Property(name: "Priority", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Int32, defaultValue: "0", typeName: "", allowOverride: false, isOverride: false, isDerived: false)]
        public int Priority { get; set; }
 
        /// <summary>
        /// Gets or sets a TypeCompliance
        /// </summary>
        [Description("Specify the level of GroupType compliance for elements in this group. Not Excluded: Allow elements not explicitly excluded by a selected GroupType. by Some Type: Allow elements explicitly approved by at least one GroupType. Approved by All Types: Allow elements explicitly approved by all selected GroupTypes")]
        [Property(name: "TypeCompliance", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Enumeration, defaultValue: "NotExcluded", typeName: "GroupingMembershipTypeCompliance", allowOverride: false, isOverride: false, isDerived: false)]
        public GroupingMembershipTypeCompliance TypeCompliance { get; set; }
 
    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
