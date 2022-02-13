﻿// -------------------------------------------------------------------------------------------------
// <copyright file="RingConstraint.cs" company="RHEA System S.A.">
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
    /// <summary>
    /// A constraint specifying relationships between elements of the same type in a set population
    /// </summary>
    public class RingConstraint : SetConstraint
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RingConstraint"/> class.
        /// </summary>
        /// <param name="model">
        /// The <see cref="ORMModel"/> that contains the current <see cref="RingConstraint"/>
        /// </param>
        public RingConstraint(ORMModel model) :
            base(model)
        {
            this.RingType = RingConstraintType.Undefined;
        }

        /// <summary>
        /// Restriction type of this Ring constraint
        /// </summary>
        public RingConstraintType RingType { get; set; }

        /// <summary>
        /// Gets or sets the owned <see cref="RingConstraintTypeNotSpecifiedError"/>
        /// </summary>
        public RingConstraintTypeNotSpecifiedError RingConstraintTypeNotSpecifiedError { get; set; }
    }
}
