// -------------------------------------------------------------------------------------------------
// <copyright file="FrequencyConstraint.cs" company="RHEA System S.A.">
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
    /// A constraint specifying the number of times an instance must occur in a set population. Applies only if the instance appears at all
    /// </summary>
    public class FrequencyConstraint : SetConstraint
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExclusionConstraint"/> class.
        /// </summary>
        /// <param name="model">
        /// The <see cref="ORMModel"/> that contains the current <see cref="ExclusionConstraint"/>
        /// </param>
        public FrequencyConstraint(ORMModel model) :
            base(model)
        {
            this.MinFrequency = 1;
            this.MaxFrequency = 2;
        }

        /// <summary>
        /// The minimum number of times an instance must be played by the constrained role(s)
        /// </summary>
        /// <remarks>
        /// (DSL) The minimum number of occurrences for each instance that plays the restricted roles
        /// </remarks>
        public int MinFrequency { get; set; }

        /// <summary>
        /// The maximum number of times an instance must be played by the constrained role(s)
        /// </summary>
        /// <remarks>
        /// (DSL) The maximum number of occurrences for each instance that plays the restricted roles
        /// </remarks>
        public int MaxFrequency { get; set; }
    }
}
