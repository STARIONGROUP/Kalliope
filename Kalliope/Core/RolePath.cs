// -------------------------------------------------------------------------------------------------
// <copyright file="RolePath.cs" company="RHEA System S.A.">
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
    /// An ordered sequence of roles through ORM space with a tail split branching into other subpaths
    /// </summary>
    public abstract class RolePath : ORMModelElement
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RolePath"/> class
        /// </summary>
        protected RolePath()
        {
            this.SplitCombinationOperator = LogicalCombinationOperator.And;
        }

        /// <summary>
        /// Should a negation be applied to the split combination operator?
        /// </summary>
        /// <remarks>
        /// (DSL) Indicates if the tail split in its entirety should be treated as a negation
        /// </remarks>
        public bool SplitIsNegated { get; set; }

        /// <summary>
        /// Determines the logical operator used to combine split paths
        /// </summary>

        public LogicalCombinationOperator SplitCombinationOperator { get; set; }
    }
}
