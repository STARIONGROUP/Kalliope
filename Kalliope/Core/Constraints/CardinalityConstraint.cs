// -------------------------------------------------------------------------------------------------
// <copyright file="CardinalityConstraint.cs" company="RHEA System S.A.">
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
    /// A constraint limiting the number of instances in a population
    /// </summary>
    [Description("")]
    [Domain(isAbstract: true, general: "ORMNamedElement")]
    public abstract class CardinalityConstraint : ORMNamedElement
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CardinalityConstraint"/> class
        /// </summary>
        protected CardinalityConstraint()
        {
            this.Modality = ConstraintModality.Alethic;
            this.Ranges = new List<CardinalityRange>();
        }

        /// <summary>
        /// The constraint Modality.
        /// Alethic modality means the constraint is structurally enforced and data violating the constraint cannot be entered in the system
        /// Deontic modality means that data violating the constraint can be recorded
        /// </summary>
        [Description("he constraint Modality. Alethic modality means the constraint is structurally enforced and data violating the constraint cannot be entered in the system. Deontic modality means that data violating the constraint can be recorded")]
        [Property(name: "Modality", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Enumeration, defaultValue: "Alethic", typeName: "ConstraintModality")]
        public ConstraintModality Modality { get; set; }

        /// <summary>
        /// Gets or sets the owned <see cref="Definition"/>
        /// </summary>
        [Description("")]
        [Property(name: "Definition", aggregation: AggregationKind.Composite, multiplicity: "0..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "Definition")]
        public Definition Definition { get; set; }

        /// <summary>
        /// Gets or sets the owned <see cref="Note"/>
        /// </summary>
        [Description("")]
        [Property(name: "Note", aggregation: AggregationKind.Composite, multiplicity: "0..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "Note")]
        public Note Note { get; set; }

        /// <summary>
        /// Set the ranges for this cardinality constraint.
        /// The following patterns are recognized:
        /// Range with a zero lower bound: 0..n, ..n, &lt;n, &lt;=n&#xd;&#xa;
        /// Range with no upper bound: &gt;n, &gt;=n, n..&#xd;&#xa;Fixed range: n..m&#xd;&#xa;&#xd;&#xa;Cardinality supports multiple non-overlapping ranges and single values. A range of 0 indicates that an empty population is allowed. For example, 0,4.. will allow either an empty population or a population with four or more instances
        /// </summary>
        [Description("Set the ranges for this cardinality constraint. The following patterns are recognized:&#xd;&#xa;&#xd;&#xa;Range with a zero lower bound: 0..n, ..n, &lt;n, &lt;=n&#xd;&#xa;Range with no upper bound: &gt;n, &gt;=n, n..&#xd;&#xa;Fixed range: n..m&#xd;&#xa;&#xd;&#xa;Cardinality supports multiple non-overlapping ranges and single values. A range of 0 indicates that an empty population is allowed. For example, 0,4.. will allow either an empty population or a population with four or more instances")]
        [Property(name: "Text", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.String, defaultValue: "", typeName: "")]
        public string Text { get; set; }

        /// <summary>
        /// Gets or sets the contained <see cref="CardinalityRange"/>s
        /// </summary>
        [Description("")]
        [Property(name: "Ranges", aggregation: AggregationKind.Composite, multiplicity: "1..*", typeKind: TypeKind.Object, defaultValue: "", typeName: "CardinalityRange")]
        public List<CardinalityRange> Ranges { get; set; }

        /// <summary>
        /// Gets or sets the owned <see cref="CardinalityRangeOverlapError"/>
        /// </summary>
        [Description("")]
        [Property(name: "CardinalityRangeOverlapError", aggregation: AggregationKind.Composite, multiplicity: "0..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "CardinalityRangeOverlapError")]
        public CardinalityRangeOverlapError CardinalityRangeOverlapError { get; set; }

        /// <summary>
        /// Gets or sets the referenced <see cref="ConstraintDuplicateNameError"/>
        /// </summary>
        [Description("")]
        [Property(name: "DuplicateNameError", aggregation: AggregationKind.None, multiplicity: "0..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "ConstraintDuplicateNameError")]
        public ConstraintDuplicateNameError DuplicateNameError { get; set; }
    }
}
