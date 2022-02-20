// -------------------------------------------------------------------------------------------------
// <copyright file="EffectiveReferenceModeNamingChoice.cs" company="RHEA System S.A.">
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
    /// Specify default settings for how a reference mode is to be represented in a generated name
    /// </summary>
    [Description("Specify how reference mode names are used in generated names for an ObjectType")]
    public enum EffectiveReferenceModeNamingChoice
    {
        /// <summary>
        /// The name of the ValueType is used for naming
        /// </summary>
        [Description("Use the name of the identifying value type as the item names")]
        ValueTypeName,

        /// <summary>
        /// The name of the EntityType is used for naming
        /// </summary>
        [Description("Use the name of the entity type as the item name")]
        EntityTypeName,

        /// <summary>
        /// The name of the ReferenceMode is used for naming
        /// </summary>
        [Description("Use a custom format string using the other three values as replacement fields")]
        ReferenceModeName,

        /// <summary>
        /// A custom format string with any combination of the ValueTypeName/EntityTypeName/ReferenceModeName values is allowed.
        /// (DSL) Use CustomFormat if specified or the default CustomFormat for the corresponding reference mode kind
        /// </summary>
        [Description("Use a custom format with the other three values as replacement fields")]
        CustomFormat
    }
}
