﻿// -------------------------------------------------------------------------------------------------
// <copyright file="ConstraintModalityValues.cs" company="RHEA System S.A.">
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
    /// The strength of a <see cref="Constraint"/>
    /// </summary>
    public enum ConstraintModalityValues
    {
        /// <summary>
        /// A strong <see cref="Constraint"/> that is enforced by the structure of a generated system
        /// </summary>
        Alethic,

        /// <summary>
        /// A weak <see cref="Constraint"/> that should not be violated. Instances violating a deontic constraint can be structurally stored in a generated system
        /// </summary>
        Deontic
    }
}
