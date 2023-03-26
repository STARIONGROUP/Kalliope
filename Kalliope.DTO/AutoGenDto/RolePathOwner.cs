// -------------------------------------------------------------------------------------------------
// <copyright file="RolePathOwner.cs" company="RHEA System S.A.">
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
    /// A Data Transfer Object that represents a RolePathOwner
    /// </summary>
    /// <remarks>
    /// An abstract owner for one or more path objects
    /// </remarks>
    public abstract partial class RolePathOwner : OrmModelElement
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RolePathOwner"/> class.
        /// </summary>
        protected RolePathOwner()
        {
            this.CalculatedConditions = new List<string>();
            this.LeadRolePaths = new List<string>();
            this.OwnedLeadRolePaths = new List<string>();
            this.OwnedSubqueries = new List<string>();
            this.SharedLeadRolePaths = new List<string>();
            this.SharedSubqueries = new List<string>();
            this.Subqueries = new List<string>();
        }
 

        /// <summary>
        /// Gets or sets a list unique identifiers of the referenced <see cref="CalculatedPathValue"/> instances
        /// </summary>
        [Description("")]
        [Property(name: "CalculatedConditions", aggregation: AggregationKind.None, multiplicity: "0..*", typeKind: TypeKind.Object, defaultValue: "", typeName: "CalculatedPathValue", allowOverride: false, isOverride: false, isDerived: false)]
        public List<string> CalculatedConditions { get; set; }
 
        /// <summary>
        /// Gets or sets a list unique identifiers of the contained <see cref="LeadRolePath"/> instances
        /// </summary>
        [Description("")]
        [Property(name: "LeadRolePaths", aggregation: AggregationKind.Composite, multiplicity: "0..*", typeKind: TypeKind.Object, defaultValue: "", typeName: "LeadRolePath", allowOverride: false, isOverride: false, isDerived: false)]
        public List<string> LeadRolePaths { get; set; }
 
        /// <summary>
        /// Gets or sets a list unique identifiers of the referenced <see cref="LeadRolePath"/> instances
        /// </summary>
        [Description("")]
        [Property(name: "OwnedLeadRolePaths", aggregation: AggregationKind.None, multiplicity: "0..*", typeKind: TypeKind.Object, defaultValue: "", typeName: "LeadRolePath", allowOverride: false, isOverride: false, isDerived: false)]
        public List<string> OwnedLeadRolePaths { get; set; }
 
        /// <summary>
        /// Gets or sets a list unique identifiers of the referenced <see cref="Subquery"/> instances
        /// </summary>
        [Description("")]
        [Property(name: "OwnedSubqueries", aggregation: AggregationKind.None, multiplicity: "0..*", typeKind: TypeKind.Object, defaultValue: "", typeName: "Subquery", allowOverride: false, isOverride: false, isDerived: false)]
        public List<string> OwnedSubqueries { get; set; }
 
        /// <summary>
        /// Gets or sets the unique identifier of the referenced <see cref="LeadRolePath"/>
        /// </summary>
        [Description("")]
        [Property(name: "PathComponent", aggregation: AggregationKind.None, multiplicity: "0..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "LeadRolePath", allowOverride: false, isOverride: false, isDerived: false)]
        public string PathComponent { get; set; }
 
        /// <summary>
        /// Gets or sets a list unique identifiers of the referenced <see cref="LeadRolePath"/> instances
        /// </summary>
        [Description("")]
        [Property(name: "SharedLeadRolePaths", aggregation: AggregationKind.None, multiplicity: "0..*", typeKind: TypeKind.Object, defaultValue: "", typeName: "LeadRolePath", allowOverride: false, isOverride: false, isDerived: false)]
        public List<string> SharedLeadRolePaths { get; set; }
 
        /// <summary>
        /// Gets or sets a list unique identifiers of the referenced <see cref="Subquery"/> instances
        /// </summary>
        [Description("")]
        [Property(name: "SharedSubqueries", aggregation: AggregationKind.None, multiplicity: "0..*", typeKind: TypeKind.Object, defaultValue: "", typeName: "Subquery", allowOverride: false, isOverride: false, isDerived: false)]
        public List<string> SharedSubqueries { get; set; }
 
        /// <summary>
        /// Gets or sets the unique identifier of the referenced <see cref="LeadRolePath"/>
        /// </summary>
        [Description("")]
        [Property(name: "SingleLeadRolePath", aggregation: AggregationKind.None, multiplicity: "0..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "LeadRolePath", allowOverride: false, isOverride: false, isDerived: false)]
        public string SingleLeadRolePath { get; set; }
 
        /// <summary>
        /// Gets or sets the unique identifier of the referenced <see cref="LeadRolePath"/>
        /// </summary>
        [Description("")]
        [Property(name: "SingleOwnedLeadRolePath", aggregation: AggregationKind.None, multiplicity: "0..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "LeadRolePath", allowOverride: false, isOverride: false, isDerived: false)]
        public string SingleOwnedLeadRolePath { get; set; }
 
        /// <summary>
        /// Gets or sets a list unique identifiers of the contained <see cref="Subquery"/> instances
        /// </summary>
        [Description("")]
        [Property(name: "Subqueries", aggregation: AggregationKind.Composite, multiplicity: "0..*", typeKind: TypeKind.Object, defaultValue: "", typeName: "Subquery", allowOverride: false, isOverride: false, isDerived: false)]
        public List<string> Subqueries { get; set; }
 
    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
