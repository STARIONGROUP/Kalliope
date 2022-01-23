// -------------------------------------------------------------------------------------------------
// <copyright file="NameGeneratorCasingOption.cs" company="RHEA System S.A.">
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
    /// Specify casing modifications for name parts and combinations.
    /// sIf not specified, the default CasingOption is the value from the nearest refining parent with this attribute. The root default is None
    /// </summary>
    public enum NameGeneratorCasingOption
    {
        Uninitialized = -1,

        /// <summary>
        /// No casing options specified
        /// </summary>
        None = 0,

        /// <summary>
        /// Generate names using camel casing (first letter of first word lower case, first letter of subsequent words upper case)
        /// </summary>
        /// <remarks>
        /// (DSL) Indicates the casing of the string is Camel
        /// </remarks>
        Camel = 1,

        /// <summary>
        /// Generate names using Pascal casing (first letter of all words upper case)
        /// </summary>
        /// <remarks>
        /// (DSL) Indicates the casing of the string is Pascal
        /// </remarks>
        Pascal = 2,

        /// <summary>
        /// Generate names using all upper case letters
        /// </summary>
        /// <remarks>
        /// (DSL) Indicates the casing of the string is Upper
        /// </remarks>
        Upper = 3,

        /// <summary>
        /// Generate names using all lower case letters
        /// </summary>
        /// <remarks>
        /// (DSL) Indicates the casing of the string is Lower
        /// </remarks>
        Lower = 4
    }
}
