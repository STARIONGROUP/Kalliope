// -------------------------------------------------------------------------------------------------
// <copyright file="DerivationCompleteness.cs" company="Starion Group S.A.">
//
//   Copyright 2022-2024 Starion Group S.A.
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
    /// Specify if instances of a derived fact or object type can also be directly asserted
    /// </summary>
    [Description("Specify if instances of a derived fact or object type can also be directly asserted")]
    public enum DerivationCompleteness
    {
        /// <summary>
        /// The fact instance population is calculated on demand
        /// </summary>
        [Description("The fact instance population is calculated on demand")]
        FullyDerived = 0,

        /// <summary>
        /// The instance population can be both calculated and asserted
        /// </summary>
        [Description("The instance population can be both calculated and asserted")]
        PartiallyDerived = 1
    }
}
