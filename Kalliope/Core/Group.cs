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

namespace Kalliope.Core
{
    using System.Collections.Generic;

    using Kalliope.Common;

    /// <summary>
    /// References to set of related elements
    /// </summary>
    /// <remarks>
    /// (DSL) A group of elements. A <see cref="GroupType"/> is associated with the <see cref="Group"/> to control the <see cref="Group"/> contents
    /// </remarks>
    [Description("References to set of related elements")]
    [Domain(isAbstract: false, general: "OrmNamedElement")]
    public class Group : OrmNamedElement
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Group"/> class.
        /// </summary>
        public Group()
        {
            this.TypeCompliance = GroupingMembershipTypeCompliance.NotExcluded;

            this.GroupTypes = new List<ElementGroupingType>();
            this.ModelThings = new List<ModelThing>();
        }

        /// <summary>
        /// The priority of this group, used to determine precedence if the same element is included in more than one group with the same group type.
        /// Higher numbers have higher priority
        /// </summary>
        [Description("The priority of this group, used to determine precedence if the same element is included in more than one group with the same group type Higher numbers have higher priority.")]
        [Property(name: "Priority", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Int32, defaultValue: "", typeName: "")]
        public int Priority { get; set; }

        /// <summary>
        /// Determine how strictly group types control the group contents
        /// </summary>
        [Description("The priority of this group, used to determine precedence if the same element is included in more than one group with the same group type Higher numbers have higher priority.")]
        [Property(name: "TypeCompliance", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Enumeration, defaultValue: "NotExcluded", typeName: "GroupingMembershipTypeCompliance")]
        public GroupingMembershipTypeCompliance TypeCompliance { get; set; }

        /// <summary>
        /// Gets or sets the contained <see cref="IEnumerable{ElementGroupingType}"/>
        /// </summary>
        [Description("The contained GroupTypes")]
        [Property(name: "GroupTypes", aggregation: AggregationKind.Composite, multiplicity: "0..*", typeKind: TypeKind.Object, defaultValue: "", typeName: "ElementGroupingType")]
        public List<ElementGroupingType> GroupTypes { get; set; }

        /// <summary>
        /// Gets or sets the referenced (grouped) <see cref="ModelThing"/>s
        /// </summary>
        [Description("The referenced (grouped) ModelThings")]
        [Property(name: "ModelThings", aggregation: AggregationKind.None, multiplicity: "0..*", typeKind: TypeKind.Object, defaultValue: "", typeName: "ModelThing")]
        public List<ModelThing> ModelThings { get; set; }
    }
}
