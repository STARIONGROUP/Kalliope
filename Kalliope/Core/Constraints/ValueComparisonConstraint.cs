// -------------------------------------------------------------------------------------------------
// <copyright file="ValueComparisonConstraint.cs" company="RHEA System S.A.">
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
    /// A constraint specifying that a comparison between two related values must be satisfied
    /// </summary>
    public class ValueComparisonConstraint : SetConstraint
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ValueComparisonConstraint"/> class.
        /// </summary>
        /// <param name="model">
        /// The <see cref="ORMModel"/> that contains the current <see cref="ValueComparisonConstraint"/>
        /// </param>
        public ValueComparisonConstraint(ORMModel model) :
            base(model)
        {
        }

        /// <summary>
        /// The operator used for comparing constrained values
        /// </summary>
        public ValueComparisonOperator Operator { get; set; }
    }
}
