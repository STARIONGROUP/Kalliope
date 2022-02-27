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
    public abstract partial class SetComparisonConstraint : ORMNamedElement
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SetComparisonConstraint"/> class.
        /// </summary>
        protected  SetComparisonConstraint()
        {
            this.CompatibleRolePlayerTypeErrors = new List<Guid>();
            this.ContradictionError = new List<Guid>();
            this.FactTypes = new List<Guid>();
            this.Modality = ConstraintModality.Alethic;
            this.RoleSequences = new List<Guid>();
        }
 
        /// <summary>
        /// Gets or sets the unique identifier of the contained <see cref="ExternalConstraintRoleSequenceArityMismatchError"/>
        /// </summary>
        public Guid ArityMismatchError { get; set; }
 
        /// <summary>
        /// Gets or sets a list unique identifiers of the contained <see cref="CompatibleRolePlayerTypeError"/> instances
        /// </summary>
        public List<Guid> CompatibleRolePlayerTypeErrors { get; set; }
 
        /// <summary>
        /// Gets or sets a list unique identifiers of the referenced <see cref="ContradictionError"/> instances
        /// </summary>
        public List<Guid> ContradictionError { get; set; }
 
        /// <summary>
        /// Gets or sets the unique identifier of the contained <see cref="Definition"/>
        /// </summary>
        public Guid Definition { get; set; }
 
        /// <summary>
        /// Gets or sets the unique identifier of the referenced <see cref="ConstraintDuplicateNameError"/>
        /// </summary>
        public Guid DuplicateNameError { get; set; }
 
        /// <summary>
        /// Gets or sets the unique identifier of the contained <see cref="EqualityOrSubsetImpliedByMandatoryError"/>
        /// </summary>
        public Guid EqualityOrSubsetImpliedByMandatoryError { get; set; }
 
        /// <summary>
        /// Gets or sets the unique identifier of the referenced <see cref="ExclusionContradictsEqualityError"/>
        /// </summary>
        public Guid ExclusionContradictsEqualityError { get; set; }
 
        /// <summary>
        /// Gets or sets the unique identifier of the referenced <see cref="ExclusionContradictsSubsetError"/>
        /// </summary>
        public Guid ExclusionContradictsSubsetError { get; set; }
 
        /// <summary>
        /// Gets or sets a list unique identifiers of the referenced <see cref="FactType"/> instances
        /// </summary>
        public List<Guid> FactTypes { get; set; }
 
        /// <summary>
        /// Gets or sets a ImplicationError
        /// </summary>
        public string ImplicationError { get; set; }
 
        /// <summary>
        /// Gets or sets a Modality
        /// </summary>
        public ConstraintModality Modality { get; set; }
 
        /// <summary>
        /// Gets or sets the unique identifier of the contained <see cref="Note"/>
        /// </summary>
        public Guid Note { get; set; }
 
        /// <summary>
        /// Gets or sets a list unique identifiers of the contained <see cref="SetComparisonConstraintRoleSequence"/> instances
        /// </summary>
        public List<Guid> RoleSequences { get; set; }
 
        /// <summary>
        /// Gets or sets the unique identifier of the contained <see cref="TooFewRoleSequencesError"/>
        /// </summary>
        public Guid TooFewRoleSequencesError { get; set; }
 
        /// <summary>
        /// Gets or sets the unique identifier of the contained <see cref="TooManyRoleSequencesError"/>
        /// </summary>
        public Guid TooManyRoleSequencesError { get; set; }
 
    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
