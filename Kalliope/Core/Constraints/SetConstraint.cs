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

namespace Kalliope.Core
{
    using System.Collections.Generic;

    public abstract class SetConstraint : ConstraintRoleSequence
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SetConstraint"/> class.
        /// </summary>
        /// <param name="model">
        /// The <see cref="ORMModel"/> that contains the current <see cref="SetComparisonConstraint"/>
        /// </param>
        protected SetConstraint(ORMModel model)
        {
            this.Modality = ConstraintModality.Alethic;
            this.FactTypes = new List<FactType>();

            this.Model = model;
            model.SetConstraints.Add(this);
        }

        /// <summary>
        /// Gets or sets the container <see cref="ORMModel"/>
        /// </summary>
        public ORMModel Model { get; set; }

        /// <summary>
        /// Gets or sets the owned <see cref="Definition"/>
        /// </summary>
        public Definition Definition { get; set; }

        /// <summary>
        /// Gets or sets the owned <see cref="Note"/>
        /// </summary>
        public Note Note { get; set; }

        /// <summary>
        /// The constraint Modality.
        /// Alethic modality means the constraint is structurally enforced and data violating the constraint cannot be entered in the system
        /// Deontic modality means that data violating the constraint can be recorded
        /// </summary>
        public ConstraintModality Modality { get; set; }
        
        /// <summary>
        /// Gets or sets the referenced <see cref="FactType"/>s
        /// </summary>
        public List<FactType> FactTypes { get; set; }

        /// <summary>
        /// Gets or sets the owned <see cref="CompatibleRolePlayerTypeError"/>
        /// </summary>
        public CompatibleRolePlayerTypeError CompatibleRolePlayerTypeError { get; set; }

        /// <summary>
        /// Gets or sets the owned <see cref="TooFewRoleSequencesError"/>
        /// </summary>
        public TooFewRoleSequencesError TooFewRoleSequencesError { get; set; }

        /// <summary>
        /// Gets or sets the owned <see cref="TooManyRoleSequencesError"/>
        /// </summary>
        public TooManyRoleSequencesError TooManyRoleSequencesError { get; set; }

        /// <summary>
        /// Gets or sets the owned <see cref="ImplicationError"/>
        /// </summary>
        public ImplicationError ImplicationError { get; set; }
    }
}
