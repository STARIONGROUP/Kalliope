// -------------------------------------------------------------------------------------------------
// <copyright file="SetConstraint.cs" company="RHEA System S.A.">
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

namespace Kalliope.Core
{
    using Common;

    [Description("")]
    [Domain(isAbstract: true, general: "OrmNamedElement")]
    public abstract class Constraint : OrmNamedElement
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SetConstraint"/> class.
        /// </summary>
        protected Constraint()
        {
            this.Modality = ConstraintModality.Alethic;
        }

        /// <summary>
        /// Gets or sets the owned <see cref="Definition"/>
        /// </summary>
        [Description("")]
        [Property(name: "Definition", aggregation: AggregationKind.Composite, multiplicity: "0..1",
            typeKind: TypeKind.Object, defaultValue: "", typeName: "Definition")]
        public Definition Definition { get; set; }

        /// <summary>
        /// Gets or sets the owned <see cref="Note"/>
        /// </summary>
        [Description("")]
        [Property(name: "Note", aggregation: AggregationKind.Composite, multiplicity: "0..1", typeKind: TypeKind.Object,
            defaultValue: "", typeName: "Note")]
        public Note Note { get; set; }

        /// <summary>
        /// The constraint Modality.
        /// Alethic modality means the constraint is structurally enforced and data violating the constraint cannot be entered in the system
        /// Deontic modality means that data violating the constraint can be recorded
        /// </summary>
        [Description(
            "The constraint Modality. Alethic modality means the constraint is structurally enforced and data violating the constraint cannot be entered in the system. Deontic modality means that data violating the constraint can be recorded.")]
        [Property(name: "Modality", aggregation: AggregationKind.None, multiplicity: "1..1",
            typeKind: TypeKind.Enumeration, defaultValue: "Alethic", typeName: "ConstraintModality")]
        public ConstraintModality Modality { get; set; }


        /// <summary>
        /// Gets or sets the owned <see cref="ImplicationError"/>
        /// </summary>
        [Description("")]
        [Property(name: "ImplicationError", aggregation: AggregationKind.Composite, multiplicity: "0..1",
            typeKind: TypeKind.Object, defaultValue: "", typeName: "ImplicationError")]
        public ImplicationError ImplicationError { get; set; }

        /// <summary>
        /// Gets or sets the referenced <see cref="ConstraintDuplicateNameError"/>
        /// </summary>
        [Description("")]
        [Property(name: "DuplicateNameError", aggregation: AggregationKind.None, multiplicity: "0..1",
            typeKind: TypeKind.Object, defaultValue: "", typeName: "ConstraintDuplicateNameError")]
        public ConstraintDuplicateNameError DuplicateNameError { get; set; }
    }
}