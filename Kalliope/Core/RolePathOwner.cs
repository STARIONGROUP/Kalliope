// -------------------------------------------------------------------------------------------------
// <copyright file="RolePathOwner.cs" company="RHEA System S.A.">
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

    using Kalliope.Attributes;

    /// <summary>
    /// An abstract owner for one or more path objects.
    /// </summary>
    [Description("An abstract owner for one or more path objects")]
    [Domain(isAbstract: true, general: "ORMModelElement")]
    public abstract class RolePathOwner : ORMModelElement
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RolePathOwner"/> class
        /// </summary>
        protected RolePathOwner()
        {
            this.LeadRolePaths = new List<LeadRolePath>();
            this.Subqueries = new List<Subquery>();
            this.OwnedLeadRolePaths = new List<LeadRolePath>();
            this.SharedLeadRolePaths = new List<LeadRolePath>();
            this.OwnedSubqueries = new List<Subquery>();
            this.SharedSubqueries = new List<Subquery>();
            this.CalculatedConditions = new List<CalculatedPathValue>();
        }

        /// <summary>
        /// Gets or sets the contained <see cref="LeadRolePath"/>s
        /// </summary>
        [Description("")]
        [Property(name: "LeadRolePaths", aggregation: AggregationKind.Composite, multiplicity: "0..*", typeKind: TypeKind.Object, defaultValue: "", typeName: "LeadRolePath")]
        public List<LeadRolePath> LeadRolePaths { get; set; }

        /// <summary>
        /// Gets or sets the contained <see cref="Subquery"/>s
        /// </summary>
        [Description("")]
        [Property(name: "Subqueries", aggregation: AggregationKind.Composite, multiplicity: "0..*", typeKind: TypeKind.Object, defaultValue: "", typeName: "Subquery")]
        public List<Subquery> Subqueries { get; set; }

        [Description("")]
        [Property(name: "PathComponent", aggregation: AggregationKind.None, multiplicity: "0..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "LeadRolePath")]
        public LeadRolePath PathComponent { get; set; }

        [Description("")]
        [Property(name: "OwnedLeadRolePaths", aggregation: AggregationKind.None, multiplicity: "0..*", typeKind: TypeKind.Object, defaultValue: "", typeName: "LeadRolePath")]
        public List<LeadRolePath> OwnedLeadRolePaths { get; set; }

        [Description("")]
        [Property(name: "SharedLeadRolePaths", aggregation: AggregationKind.None, multiplicity: "0..*", typeKind: TypeKind.Object, defaultValue: "", typeName: "LeadRolePath")]
        public List<LeadRolePath> SharedLeadRolePaths { get; set; }

        [Description("")]
        [Property(name: "SingleLeadRolePath", aggregation: AggregationKind.None, multiplicity: "0..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "LeadRolePath")]
        public LeadRolePath SingleLeadRolePath { get; set; }

        [Description("")]
        [Property(name: "SingleOwnedLeadRolePath", aggregation: AggregationKind.None, multiplicity: "0..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "LeadRolePath")]
        public LeadRolePath SingleOwnedLeadRolePath { get; set; }

        [Description("")]
        [Property(name: "OwnedSubqueries", aggregation: AggregationKind.None, multiplicity: "0..*", typeKind: TypeKind.Object, defaultValue: "", typeName: "Subquery")]
        public List<Subquery> OwnedSubqueries { get; set; }

        [Description("")]
        [Property(name: "SharedSubqueries", aggregation: AggregationKind.None, multiplicity: "0..*", typeKind: TypeKind.Object, defaultValue: "", typeName: "Subquery")]
        public List<Subquery> SharedSubqueries { get; set; }

        /// <summary>
        /// The calculated values that must be satisfied by the path
        /// </summary>
        [Description("")]
        [Property(name: "CalculatedConditions", aggregation: AggregationKind.None, multiplicity: "0..*", typeKind: TypeKind.Object, defaultValue: "", typeName: "CalculatedPathValue")]
        public List<CalculatedPathValue> CalculatedConditions { get; set; }
    }
}
