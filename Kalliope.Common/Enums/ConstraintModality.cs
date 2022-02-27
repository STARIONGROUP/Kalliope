// -------------------------------------------------------------------------------------------------
// <copyright file="ConstraintModality.cs" company="RHEA System S.A.">
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

namespace Kalliope.Common
{
    /// <summary>
    /// The strength of a <see cref="Constraint"/>
    /// </summary>
    [Description("The strength of a Constraint")]
    public enum ConstraintModality
    {
        /// <summary>
        /// A strong Constraint that is enforced by the structure of a generated system.
        /// The constraint must hold.
        /// </summary>
        [Description("A strong Constraint that is enforced by the structure of a generated system. The constraint must hold")]
        Alethic = 0,

        /// <summary>
        /// A weak Constraint that should not be violated. Instances violating a deontic constraint can be structurally stored in a generated system
        /// The constraint should hold
        /// </summary>
        [Description("A weak Constraint that should not be violated. Instances violating a deontic constraint can be structurally stored in a generated system. The constraint should hold")]
        Deontic = 1
    }
}
