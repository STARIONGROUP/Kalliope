﻿// -------------------------------------------------------------------------------------------------
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
    /// <summary>
    /// Specify default settings for how a reference mode is to be represented in a generated name
    /// </summary>
    public enum EffectiveReferenceModeNamingChoice
    {
        /// <summary>
        /// The name of the ValueType is used for naming
        /// </summary>
        ValueTypeName,

        /// <summary>
        /// The name of the EntityType is used for naming
        /// </summary>
        EntityTypeName,

        /// <summary>
        /// The name of the ReferenceMode is used for naming
        /// </summary>
        ReferenceModeName,

        /// <summary>
        /// A custom format string with any combination of the ValueTypeName/EntityTypeName/ReferenceModeName values is allowed.
        /// Use CustomFormat if specified or the default CustomFormat for the corresponding reference mode kind
        /// </summary>
        CustomFormat
    }
}