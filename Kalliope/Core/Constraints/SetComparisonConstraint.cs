// -------------------------------------------------------------------------------------------------
// <copyright file="SetComparisonConstraint.cs" company="RHEA System S.A.">
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

    [Description("")]
    [Domain(isAbstract: true, general: "ORMNamedElement")]
    [Container(typeName: "ORMModel", propertyName: "SetComparisonConstraints")]
    public abstract class SetComparisonConstraint : ORMNamedElement
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SetComparisonConstraint"/> class.
        /// </summary>
        protected SetComparisonConstraint()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SetComparisonConstraint"/> class.
        /// </summary>
        /// <param name="model">
        /// The <see cref="ORMModel"/> that contains the current <see cref="SetComparisonConstraint"/>
        /// </param>
        protected SetComparisonConstraint(ORMModel model)
        {
            this.Modality = ConstraintModality.Alethic;
            this.FactTypes = new List<FactType>();
            this.RoleSequences = new List<SetComparisonConstraintRoleSequence>();
            this.CompatibleRolePlayerTypeErrors = new List<CompatibleRolePlayerTypeError>();
            this.ContradictionError = new List<ContradictionError>();

            this.Model = model;
            model.SetComparisonConstraints.Add(this);
        }

        /// <summary>
        /// Gets or sets the container <see cref="ORMModel"/>
        /// </summary>
        public ORMModel Model { get; set; }

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
        /// The constraint Modality.
        /// Alethic modality means the constraint is structurally enforced and data violating the constraint cannot be entered in the system;
        /// Deontic modality means that data violating the constraint can be recorded
        /// </summary>
        [Description("The constraint Modality. Alethic modality means the constraint is structurally enforced and data violating the constraint cannot be entered in the system. Deontic modality means that data violating the constraint can be recorded.")]
        [Property(name: "Modality", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Enumeration, defaultValue: "Alethic", typeName: "ConstraintModality")]
        public ConstraintModality Modality { get; set; }

        /// <summary>
        /// Gets or sets the referenced <see cref="FactType"/>s
        /// </summary>
        [Description("")]
        [Property(name: "FactTypes", aggregation: AggregationKind.None, multiplicity: "0..*", typeKind: TypeKind.Object, defaultValue: "", typeName: "FactType")]
        public List<FactType> FactTypes { get; set; }

        /// <summary>
        /// Gets or sets the contained <see cref="SetComparisonConstraintRoleSequence"/>s
        /// </summary>
        [Description("")]
        [Property(name: "RoleSequences", aggregation: AggregationKind.Composite, multiplicity: "0..*", typeKind: TypeKind.Object, defaultValue: "", typeName: "SetComparisonConstraintRoleSequence")]
        public List<SetComparisonConstraintRoleSequence> RoleSequences { get; set; }

        /// <summary>
        /// Gets or sets the contained <see cref="CompatibleRolePlayerTypeError"/>s
        /// </summary>
        [Description("")]
        [Property(name: "CompatibleRolePlayerTypeErrors", aggregation: AggregationKind.Composite, multiplicity: "0..*", typeKind: TypeKind.Object, defaultValue: "", typeName: "CompatibleRolePlayerTypeError")]
        public List<CompatibleRolePlayerTypeError> CompatibleRolePlayerTypeErrors { get; set; }

        /// <summary>
        /// Gets or sets the owned <see cref="TooFewRoleSequencesError"/>
        /// </summary>
        [Description("")]
        [Property(name: "TooFewRoleSequencesError", aggregation: AggregationKind.Composite, multiplicity: "0..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "TooFewRoleSequencesError")]
        public TooFewRoleSequencesError TooFewRoleSequencesError { get; set; }

        /// <summary>
        /// Gets or sets the owned <see cref="TooFewRoleSequencesError"/>
        /// </summary>
        [Description("")]
        [Property(name: "TooManyRoleSequencesError", aggregation: AggregationKind.Composite, multiplicity: "0..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "TooManyRoleSequencesError")]
        public TooManyRoleSequencesError TooManyRoleSequencesError { get; set; }

        /// <summary>
        /// Gets or sets the owned <see cref="ExternalConstraintRoleSequenceArityMismatchError"/>
        /// </summary>
        [Description("")]
        [Property(name: "ArityMismatchError", aggregation: AggregationKind.Composite, multiplicity: "0..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "ExternalConstraintRoleSequenceArityMismatchError")]
        public ExternalConstraintRoleSequenceArityMismatchError ArityMismatchError { get; set; }

        /// <summary>
        /// Gets or sets the owned <see cref="EqualityOrSubsetImpliedByMandatoryError"/>
        /// </summary>
        [Description("")]
        [Property(name: "EqualityOrSubsetImpliedByMandatoryError", aggregation: AggregationKind.Composite, multiplicity: "0..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "EqualityOrSubsetImpliedByMandatoryError")]
        public EqualityOrSubsetImpliedByMandatoryError EqualityOrSubsetImpliedByMandatoryError { get; set; }

        /// <summary>
        /// Gets or sets the referenced <see cref="ContradictionError"/>
        /// </summary>
        [Description("")]
        [Property(name: "ContradictionError", aggregation: AggregationKind.None, multiplicity: "0..*", typeKind: TypeKind.Object, defaultValue: "", typeName: "ContradictionError")]
        public List<ContradictionError> ContradictionError { get; set; }

        /// <summary>
        /// Gets or sets the referenced <see cref="ExclusionContradictsEqualityError"/>
        /// </summary>
        [Description("")]
        [Property(name: "ExclusionContradictsEqualityError", aggregation: AggregationKind.None, multiplicity: "0..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "ExclusionContradictsEqualityError")]
        public ExclusionContradictsEqualityError ExclusionContradictsEqualityError { get; set; }

        /// <summary>
        /// Gets or sets the referenced <see cref="ExclusionContradictsSubsetError"/>
        /// </summary>
        [Description("")]
        [Property(name: "ExclusionContradictsSubsetError", aggregation: AggregationKind.None, multiplicity: "0..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "ExclusionContradictsSubsetError")]
        public ExclusionContradictsSubsetError ExclusionContradictsSubsetError { get; set; }

        /// <summary>
        /// Gets or sets the referenced <see cref="ConstraintDuplicateNameError"/>
        /// </summary>
        [Description("")]
        [Property(name: "DuplicateNameError", aggregation: AggregationKind.None, multiplicity: "0..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "ConstraintDuplicateNameError")]
        public ConstraintDuplicateNameError DuplicateNameError { get; set; }

        /// <summary>
        /// Gets or sets the referenced <see cref="ImplicationError"/>
        /// </summary>
        [Description("")]
        [Property(name: "ImplicationError", aggregation: AggregationKind.None, multiplicity: "0..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "ImplicationError")]
        public ImplicationError ImplicationError { get; set; }
    }
}
