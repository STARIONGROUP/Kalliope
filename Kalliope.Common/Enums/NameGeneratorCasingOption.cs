// -------------------------------------------------------------------------------------------------
// <copyright file="NameGeneratorCasingOption.cs" company="RHEA System S.A.">
//
//   Copyright 2022-2023 RHEA System S.A.
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
    /// Specify casing modifications for name parts and combinations.
    /// If not specified, the default CasingOption is the value from the nearest refining parent with this attribute. The root default is None
    /// </summary>
    [Description("Specify casing modifications for name parts and combinations.")]
    public enum NameGeneratorCasingOption
    {
        [Description("")]
        Uninitialized = -1,

        /// <summary>
        /// No casing options specified
        /// </summary>
        [Description("No casing options specified")]
        None = 0,

        /// <summary>
        /// Generate names using camel casing (first letter of first word lower case, first letter of subsequent words upper case)
        /// </summary>
        /// <remarks>
        /// (DSL) Indicates the casing of the string is Camel
        /// </remarks>
        [Description("Indicates the casing of the string is Camel")]
        Camel = 1,

        /// <summary>
        /// Generate names using Pascal casing (first letter of all words upper case)
        /// </summary>
        /// <remarks>
        /// (DSL) Indicates the casing of the string is Pascal
        /// </remarks>
        [Description("Indicates the casing of the string is Pascal")]
        Pascal = 2,

        /// <summary>
        /// Generate names using all upper case letters
        /// </summary>
        /// <remarks>
        /// (DSL) Indicates the casing of the string is Upper
        /// </remarks>
        [Description("Indicates the casing of the string is Upper")]
        Upper = 3,

        /// <summary>
        /// Generate names using all lower case letters
        /// </summary>
        /// <remarks>
        /// (DSL) Indicates the casing of the string is Lower
        /// </remarks>
        [Description("Indicates the casing of the string is Lower")]
        Lower = 4
    }
}
