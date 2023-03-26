// -------------------------------------------------------------------------------------------------
// <copyright file="CardinalityConstraint.cs" company="RHEA System S.A.">
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
    /// A Data Transfer Object that represents a CardinalityConstraint
    /// </summary>
    [Container(typeName: "ObjectTypeCardinalityRestriction", propertyName: "CardinalityConstraint")]
    public abstract partial class CardinalityConstraint : OrmNamedElement
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CardinalityConstraint"/> class.
        /// </summary>
        protected CardinalityConstraint()
        {
            this.Modality = ConstraintModality.Alethic;
            this.Ranges = new List<string>();
        }
 
        /// <summary>
        /// Gets or sets the unique identifier of the container
        /// </summary>
        public string Container {get; set;}
 

        /// <summary>
        /// Gets or sets the unique identifier of the contained <see cref="CardinalityRangeOverlapError"/>
        /// </summary>
        [Description("")]
        [Property(name: "CardinalityRangeOverlapError", aggregation: AggregationKind.Composite, multiplicity: "0..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "CardinalityRangeOverlapError", allowOverride: false, isOverride: false, isDerived: false)]
        public string CardinalityRangeOverlapError { get; set; }
 
        /// <summary>
        /// Gets or sets the unique identifier of the contained <see cref="Definition"/>
        /// </summary>
        [Description("")]
        [Property(name: "Definition", aggregation: AggregationKind.Composite, multiplicity: "0..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "Definition", allowOverride: false, isOverride: false, isDerived: false)]
        public string Definition { get; set; }
 
        /// <summary>
        /// Gets or sets the unique identifier of the referenced <see cref="ConstraintDuplicateNameError"/>
        /// </summary>
        [Description("")]
        [Property(name: "DuplicateNameError", aggregation: AggregationKind.None, multiplicity: "0..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "ConstraintDuplicateNameError", allowOverride: false, isOverride: false, isDerived: false)]
        public string DuplicateNameError { get; set; }
 
        /// <summary>
        /// Gets or sets a Modality
        /// </summary>
        [Description("he constraint Modality. Alethic modality means the constraint is structurally enforced and data violating the constraint cannot be entered in the system. Deontic modality means that data violating the constraint can be recorded")]
        [Property(name: "Modality", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Enumeration, defaultValue: "Alethic", typeName: "ConstraintModality", allowOverride: false, isOverride: false, isDerived: false)]
        public ConstraintModality Modality { get; set; }
 
        /// <summary>
        /// Gets or sets the unique identifier of the contained <see cref="Note"/>
        /// </summary>
        [Description("")]
        [Property(name: "Note", aggregation: AggregationKind.Composite, multiplicity: "0..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "Note", allowOverride: false, isOverride: false, isDerived: false)]
        public string Note { get; set; }
 
        /// <summary>
        /// Gets or sets a list unique identifiers of the contained <see cref="CardinalityRange"/> instances
        /// </summary>
        [Description("")]
        [Property(name: "Ranges", aggregation: AggregationKind.Composite, multiplicity: "1..*", typeKind: TypeKind.Object, defaultValue: "", typeName: "CardinalityRange", allowOverride: false, isOverride: false, isDerived: false)]
        public List<string> Ranges { get; set; }
 
        /// <summary>
        /// Gets or sets a Text
        /// </summary>
        [Description("Set the ranges for this cardinality constraint. The following patterns are recognized:&#xd;&#xa;&#xd;&#xa;Range with a zero lower bound: 0..n, ..n, &lt;n, &lt;=n&#xd;&#xa;Range with no upper bound: &gt;n, &gt;=n, n..&#xd;&#xa;Fixed range: n..m&#xd;&#xa;&#xd;&#xa;Cardinality supports multiple non-overlapping ranges and single values. A range of 0 indicates that an empty population is allowed. For example, 0,4.. will allow either an empty population or a population with four or more instances")]
        [Property(name: "Text", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.String, defaultValue: "", typeName: "", allowOverride: false, isOverride: false, isDerived: false)]
        public string Text { get; set; }
 
    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
