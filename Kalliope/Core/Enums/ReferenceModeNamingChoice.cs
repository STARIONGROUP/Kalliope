// -------------------------------------------------------------------------------------------------
// <copyright file="ReferenceModeNamingChoice.cs" company="RHEA System S.A.">
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
    /// Specify how a reference mode is to be represented in a generated name. Includes and option to use context default settings
    /// </summary>
    public enum ReferenceModeNamingChoice
    {
        /// <summary>
        /// The name of the ValueType is used for naming
        /// </summary>
        /// <remarks>
        /// (DSL) Use the name of the identifying value type as the item name
        /// </remarks>
        ValueTypeName = 0,

        /// <summary>
        /// The name of the EntityType is used for naming
        /// </summary>
        /// <remarks>
        /// (DSL) Use the name of the entity type as the item name
        /// </remarks>
        EntityTypeName = 1,

        /// <summary>
        /// The name of the ReferenceMode is used for naming
        /// </summary>
        /// <remarks>
        /// (DSL) Use the name of the reference mode as the item name
        /// </remarks>
        ReferenceModeName = 2,

        /// <summary>
        /// A custom format string with any combination of the ValueTypeName/EntityTypeName/ReferenceModeName values is allowed.
        /// Use CustomFormat if specified or the default CustomFormat for the corresponding reference mode kind
        /// </summary>
        /// <remarks>
        /// (DSL) Use a custom format string using the other three values as replacement fields
        /// </remarks>
        CustomFormat = 3,

        /// <summary>
        /// Use the default setting for the model
        /// </summary>
        /// <remarks>
        /// (DSL) Use the default setting from the model
        /// </remarks>
        ModelDefault = 4
    }
}
