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

    /// <summary>
    /// A constraint limiting the number of instances in a population
    /// </summary>
    public abstract class CardinalityConstraint : ORMNamedElement
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CardinalityConstraint"/> class
        /// </summary>
        protected CardinalityConstraint()
        {
            this.Modality = ConstraintModality.Alethic;
        }

        /// <summary>
        /// The constraint Modality.
        /// Alethic modality means the constraint is structurally enforced and data violating the constraint cannot be entered in the system
        /// Deontic modality means that data violating the constraint can be recorded
        /// </summary>
        public ConstraintModality Modality { get; set; }

        /// <summary>
        /// Gets or sets the owned <see cref="Definition"/>
        /// </summary>
        public Definition Definition { get; set; }

        /// <summary>
        /// Gets or sets the owned <see cref="Note"/>
        /// </summary>
        public Note Note { get; set; }

        /// <summary>
        /// Set the ranges for this cardinality constraint.
        /// The following patterns are recognized:
        /// Range with a zero lower bound: 0..n, ..n, &lt;n, &lt;=n&#xd;&#xa;
        /// Range with no upper bound: &gt;n, &gt;=n, n..&#xd;&#xa;Fixed range: n..m&#xd;&#xa;&#xd;&#xa;Cardinality supports multiple non-overlapping ranges and single values. A range of 0 indicates that an empty population is allowed. For example, 0,4.. will allow either an empty population or a population with four or more instances
        /// </summary>
        public string Text { get; set; }
        
        /// <summary>
        /// Gets or sets the contained <see cref="CardinalityRange"/>s
        /// </summary>
        public List<CardinalityRange> Ranges { get; set; }

        /// <summary>
        /// Gets or sets the owned <see cref="CardinalityRangeOverlapError"/>
        /// </summary>
        public CardinalityRangeOverlapError CardinalityRangeOverlapError { get; set; }
    }
}
