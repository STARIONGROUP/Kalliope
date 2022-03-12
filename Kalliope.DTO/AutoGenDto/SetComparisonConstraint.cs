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
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
 
namespace Kalliope.DTO
{
    using System;
    using System.Collections.Generic;
 
    using Kalliope.Common;
 
    /// <summary>
    /// A Data Transfer Object that represents a SetComparisonConstraint
    /// </summary>
    [Container(typeName: "ORMModel", propertyName: "SetComparisonConstraints")]
    public abstract partial class SetComparisonConstraint : ORMNamedElement
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SetComparisonConstraint"/> class.
        /// </summary>
        protected SetComparisonConstraint()
        {
            this.CompatibleRolePlayerTypeErrors = new List<string>();
            this.ContradictionError = new List<string>();
            this.FactTypes = new List<string>();
            this.Modality = ConstraintModality.Alethic;
            this.RoleSequences = new List<string>();
        }
 
        /// <summary>
        /// Gets or sets the unique identifier of the container
        /// </summary>
        public string Container {get; set;}
 

        /// <summary>
        /// Gets or sets the unique identifier of the contained <see cref="ExternalConstraintRoleSequenceArityMismatchError"/>
        /// </summary>
        [Description("")]
        [Property(name: "ArityMismatchError", aggregation: AggregationKind.Composite, multiplicity: "0..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "ExternalConstraintRoleSequenceArityMismatchError")]
        public string ArityMismatchError { get; set; }
 
        /// <summary>
        /// Gets or sets a list unique identifiers of the contained <see cref="CompatibleRolePlayerTypeError"/> instances
        /// </summary>
        [Description("")]
        [Property(name: "CompatibleRolePlayerTypeErrors", aggregation: AggregationKind.Composite, multiplicity: "0..*", typeKind: TypeKind.Object, defaultValue: "", typeName: "CompatibleRolePlayerTypeError")]
        public List<string> CompatibleRolePlayerTypeErrors { get; set; }
 
        /// <summary>
        /// Gets or sets a list unique identifiers of the referenced <see cref="ContradictionError"/> instances
        /// </summary>
        [Description("")]
        [Property(name: "ContradictionError", aggregation: AggregationKind.None, multiplicity: "0..*", typeKind: TypeKind.Object, defaultValue: "", typeName: "ContradictionError")]
        public List<string> ContradictionError { get; set; }
 
        /// <summary>
        /// Gets or sets the unique identifier of the contained <see cref="Definition"/>
        /// </summary>
        [Description("")]
        [Property(name: "Definition", aggregation: AggregationKind.Composite, multiplicity: "0..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "Definition")]
        public string Definition { get; set; }
 
        /// <summary>
        /// Gets or sets the unique identifier of the referenced <see cref="ConstraintDuplicateNameError"/>
        /// </summary>
        [Description("")]
        [Property(name: "DuplicateNameError", aggregation: AggregationKind.None, multiplicity: "0..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "ConstraintDuplicateNameError")]
        public string DuplicateNameError { get; set; }
 
        /// <summary>
        /// Gets or sets the unique identifier of the contained <see cref="EqualityOrSubsetImpliedByMandatoryError"/>
        /// </summary>
        [Description("")]
        [Property(name: "EqualityOrSubsetImpliedByMandatoryError", aggregation: AggregationKind.Composite, multiplicity: "0..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "EqualityOrSubsetImpliedByMandatoryError")]
        public string EqualityOrSubsetImpliedByMandatoryError { get; set; }
 
        /// <summary>
        /// Gets or sets the unique identifier of the referenced <see cref="ExclusionContradictsEqualityError"/>
        /// </summary>
        [Description("")]
        [Property(name: "ExclusionContradictsEqualityError", aggregation: AggregationKind.None, multiplicity: "0..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "ExclusionContradictsEqualityError")]
        public string ExclusionContradictsEqualityError { get; set; }
 
        /// <summary>
        /// Gets or sets the unique identifier of the referenced <see cref="ExclusionContradictsSubsetError"/>
        /// </summary>
        [Description("")]
        [Property(name: "ExclusionContradictsSubsetError", aggregation: AggregationKind.None, multiplicity: "0..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "ExclusionContradictsSubsetError")]
        public string ExclusionContradictsSubsetError { get; set; }
 
        /// <summary>
        /// Gets or sets a list unique identifiers of the referenced <see cref="FactType"/> instances
        /// </summary>
        [Description("")]
        [Property(name: "FactTypes", aggregation: AggregationKind.None, multiplicity: "0..*", typeKind: TypeKind.Object, defaultValue: "", typeName: "FactType")]
        public List<string> FactTypes { get; set; }
 
        /// <summary>
        /// Gets or sets a ImplicationError
        /// </summary>
        [Description("")]
        [Property(name: "ImplicationError", aggregation: AggregationKind.None, multiplicity: "0..1", typeKind: TypeKind.String, defaultValue: "", typeName: "ImplicationError")]
        public string ImplicationError { get; set; }
 
        /// <summary>
        /// Gets or sets a Modality
        /// </summary>
        [Description("The constraint Modality. Alethic modality means the constraint is structurally enforced and data violating the constraint cannot be entered in the system. Deontic modality means that data violating the constraint can be recorded.")]
        [Property(name: "Modality", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Enumeration, defaultValue: "Alethic", typeName: "ConstraintModality")]
        public ConstraintModality Modality { get; set; }
 
        /// <summary>
        /// Gets or sets the unique identifier of the contained <see cref="Note"/>
        /// </summary>
        [Description("")]
        [Property(name: "Note", aggregation: AggregationKind.Composite, multiplicity: "0..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "Note")]
        public string Note { get; set; }
 
        /// <summary>
        /// Gets or sets a list unique identifiers of the contained <see cref="SetComparisonConstraintRoleSequence"/> instances
        /// </summary>
        [Description("")]
        [Property(name: "RoleSequences", aggregation: AggregationKind.Composite, multiplicity: "0..*", typeKind: TypeKind.Object, defaultValue: "", typeName: "SetComparisonConstraintRoleSequence")]
        public List<string> RoleSequences { get; set; }
 
        /// <summary>
        /// Gets or sets the unique identifier of the contained <see cref="TooFewRoleSequencesError"/>
        /// </summary>
        [Description("")]
        [Property(name: "TooFewRoleSequencesError", aggregation: AggregationKind.Composite, multiplicity: "0..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "TooFewRoleSequencesError")]
        public string TooFewRoleSequencesError { get; set; }
 
        /// <summary>
        /// Gets or sets the unique identifier of the contained <see cref="TooManyRoleSequencesError"/>
        /// </summary>
        [Description("")]
        [Property(name: "TooManyRoleSequencesError", aggregation: AggregationKind.Composite, multiplicity: "0..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "TooManyRoleSequencesError")]
        public string TooManyRoleSequencesError { get; set; }
 
    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
