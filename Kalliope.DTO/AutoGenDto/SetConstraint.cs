// -------------------------------------------------------------------------------------------------
// <copyright file="SetConstraint.cs" company="RHEA System S.A.">
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

namespace Kalliope.DTO
{
    using System;
    using System.Collections.Generic;
 
    using Kalliope.Common;
 
    /// <summary>
    /// 
    /// </summary>
    public  abstract partial class SetConstraint : ConstraintRoleSequence
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SetConstraint"/> class.
        /// </summary>
        protected  SetConstraint()
        {
            this.FactTypes = new List<Guid>();
            this.Modality = ConstraintModality.Alethic;
        }
 
        /// <summary>
        /// Gets or sets the unique identifier of the contained <see cref="CompatibleRolePlayerTypeError"/>
        /// </summary>
        public Guid CompatibleRolePlayerTypeError { get; set; }
 
        /// <summary>
        /// Gets or sets the unique identifier of the contained <see cref="Definition"/>
        /// </summary>
        public Guid Definition { get; set; }
 
        /// <summary>
        /// Gets or sets the unique identifier of the referenced <see cref="ConstraintDuplicateNameError"/>
        /// </summary>
        public Guid DuplicateNameError { get; set; }
 
        /// <summary>
        /// Gets or sets a list unique identifiers of the referenced <see cref="FactType"/> instances
        /// </summary>
        public List<Guid> FactTypes { get; set; }
 
        /// <summary>
        /// Gets or sets the unique identifier of the contained <see cref="ImplicationError"/>
        /// </summary>
        public Guid ImplicationError { get; set; }
 
        /// <summary>
        /// Gets or sets a Modality
        /// </summary>
        public ConstraintModality Modality { get; set; }
 
        /// <summary>
        /// Gets or sets the unique identifier of the contained <see cref="Note"/>
        /// </summary>
        public Guid Note { get; set; }
 
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
