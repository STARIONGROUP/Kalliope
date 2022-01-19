﻿// -------------------------------------------------------------------------------------------------
// <copyright file="Multiplicity.cs" company="RHEA System S.A.">
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

namespace Kalliope.ObjectModel
{
    /// <summary>
    /// The UML-style multiplicity for a role in a binary fact type. Derived from internal uniqueness and mandatory constraints
    /// </summary>
    public enum Multiplicity
    {
        /// <summary>
        /// No internal constraints are specified
        /// </summary>
        Unspecified,

        /// <summary>
        /// Specified internal constraints are inconsistent, resulting in a multiplicity that cannot be determined
        /// </summary>
        Indeterminate,

        /// <summary>
        /// At most one instance of this role player may be associated with the opposite role player. Corresponds to a single role uniqueness constraint on the opposite role
        /// </summary>
        ZeroToOne,

        /// <summary>
        /// Zero or more instances of this role player can be associated a single instance of the opposite role player
        /// </summary>
        ZeroToMany,

        /// <summary>
        /// Exactly one instance of this role player may be associated with the opposite role player. Corresponds to single role uniqueness and mandatory constraints on the opposite role
        /// </summary>
        ExactlyOne,

        /// <summary>
        /// One or more instances of this role player can be associated a single instance of the opposite role player
        /// </summary>
        OneToMany
    }
}
