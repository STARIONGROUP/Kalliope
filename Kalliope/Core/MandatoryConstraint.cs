// -------------------------------------------------------------------------------------------------
// <copyright file="MandatoryConstraint.cs" company="RHEA System S.A.">
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
    /// A constraint specifying that a set must be populated
    /// </summary>
    public class MandatoryConstraint : SetConstraint
    {
        /// <summary>
        /// True if this is an internal constraint associated with a single role
        /// </summary>
        public bool IsSimple { get; set; }

        /// <summary>
        /// True if this constraint is implied by a lack of a mandatory role on any non-existential role on the non-independent role player.
        /// An implied mandatory constraint may have a single role or multiple roles, but IsSimple is never true for an implied mandatory constraint
        /// </summary>
        public bool IsImplied { get; set; }
    }
}
