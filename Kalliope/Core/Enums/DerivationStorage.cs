// -------------------------------------------------------------------------------------------------
// <copyright file="DerivationStorage.cs" company="RHEA System S.A.">
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
    using Kalliope.Attributes;

    /// <summary>
    /// Specify if derived fact or object instances should be recalculated on demand, or calculated on change and stored
    /// </summary>
    [Description("Specify if derived fact or object instances should be recalculated on demand, or calculated on change and stored")]
    public enum DerivationStorage
    {
        /// <summary>
        /// Fact instances are recalculated on demand
        /// </summary>
        [Description("Fact instances are recalculated on demand")]
        NotStored = 0,

        /// <summary>
        /// Fact instances are calculated on change and stored
        /// </summary>
        [Description("Fact instances are calculated on change and stored")]
        Stored = 1
    }
}
