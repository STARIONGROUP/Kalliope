// -------------------------------------------------------------------------------------------------
// <copyright file="DerivationExpressionStorageType.cs" company="RHEA System S.A.">
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
    /// Specify how/whether the contents of the fact should be stored by generated systems
    /// </summary>
    [Description("Specify how/whether the contents of the fact should be stored by generated systems")]
    public enum DerivationExpressionStorageType
    {
        /// <summary>
        /// The fact instance population is calculated on demand
        /// </summary>
        [Description("The fact instance population is calculated on demand")]
        Derived = 0,

        /// <summary>
        /// The fact instance population is calculated immediately and stored
        /// </summary>
        [Description("The fact instance population is calculated immediately and stored")]
        DerivedAndStored = 1,

        /// <summary>
        /// The fact instance population can be asserted as well as calculated on demand
        /// </summary>
        [Description("The fact instance population can be asserted as well as calculated on demand")]
        PartiallyDerived = 2,

        /// <summary>
        /// The fact instance population can be asserted as well as calculated immediately and stored
        /// </summary>
        [Description("The fact instance population can be asserted as well as calculated immediately and stored")]
        PartiallyDerivedAndStored = 3
    }
}
