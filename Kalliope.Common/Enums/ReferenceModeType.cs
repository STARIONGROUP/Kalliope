// -------------------------------------------------------------------------------------------------
// <copyright file="ReferenceModeType.cs" company="Starion Group S.A.">
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
    /// Classification of reference mode patterns
    /// </summary>
    [Description("Classification of reference mode patterns")]
    public enum ReferenceModeType
    {
        /// <summary>
        /// The reference mode patterns resolves to a value type with no special semantics
        /// </summary>
        /// <remarks>
        /// (DSL) That other reference mode type
        /// </remarks>
        [Description("That other reference mode type")]
        General = 0,

        /// <summary>
        /// The reference mode patterns resolves to a value type with a name based on the identified entity type.
        /// The value type identifies exactly one entity type
        /// </summary>
        /// <remarks>
        /// (DSL) The 'in' and 'fashionable' reference mode type
        /// </remarks>
        [Description("The 'in' and 'fashionable' reference mode type")]
        Popular = 1,

        /// <summary>
        /// The reference mode patterns resolves to a value type that is associated with a measurable unit
        /// </summary>
        /// <remarks>
        /// (DSL) The reference mode type based on units
        /// </remarks>
        [Description("The reference mode type based on units")]
        UnitBased = 2
    }
}
