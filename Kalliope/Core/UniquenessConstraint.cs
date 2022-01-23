﻿// -------------------------------------------------------------------------------------------------
// <copyright file="UniquenessConstraint.cs" company="RHEA System S.A.">
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
    /// A constraint specifying that the population of a set must be unique
    /// </summary>
    public class UniquenessConstraint : SetConstraint
    {
        /// <summary>
        /// Is this the preferred identifier for the EntityType role player of the opposite role(s)?
        /// The opposite role player of an internal constraint on an objectified FactType is the objectifying EntityType.
        /// Binary FactTypes with a spanning internal uniqueness constraint and ternary (or higher arity) FactTypes are automatically objectified
        /// </summary>
        public bool IsPreferred { get; set; }

        /// <summary>
        /// If true, this uniqueness constraint is internal to a single fact type
        /// </summary>
        public bool IsInternal { get; set; }
    }
}
