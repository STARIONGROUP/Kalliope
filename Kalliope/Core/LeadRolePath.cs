// -------------------------------------------------------------------------------------------------
// <copyright file="LeadRolePath.cs" company="RHEA System S.A.">
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

    /// <summary>
    /// A role path starting from a root object type
    /// </summary>
    /// <remarks>
    /// (DSL) A top level role path starting at a root object type. Provides a context for subpaths, functions, and constraints specific to this path
    /// </remarks>
    public class LeadRolePath : RolePath
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LeadRolePath"/> class
        /// </summary>
        public LeadRolePath()
        {
            this.ObjectUnifiers = new List<PathObjectUnifier>();
            this.CalculatedValues = new List<CalculatedPathValue>();
        }

        /// <summary>
        /// Gets or sets the owned <see cref="Note"/>
        /// </summary>
        public Note Note { get; set; }

        /// <summary>
        /// Gets or sets the object unifier that uses pathed roles and path roots in this role path
        /// </summary>
        public List<PathObjectUnifier> ObjectUnifiers { get; set; }

        /// <summary>
        /// Gets or sets the values calculated using roles in this component
        /// </summary>
        public List<CalculatedPathValue> CalculatedValues { get; set; }
    }
}
