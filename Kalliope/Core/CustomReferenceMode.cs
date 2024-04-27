﻿// -------------------------------------------------------------------------------------------------
// <copyright file="CustomReferenceMode.cs" company="Starion Group S.A.">
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

namespace Kalliope.Core
{
    using Kalliope.Common;

    /// <summary>
    /// Definition of a custom reference mode pattern
    /// </summary>
    [Description("Definition of a custom reference mode pattern")]
    [Domain(isAbstract: false, general: "ReferenceMode")]
    public class CustomReferenceMode : ReferenceMode
    {

        /// <summary>
        /// A reference to the default data type. This is used when the reference mode sets the data type. The data type can subsequently be changed independently of the matched reference mode pattern
        /// </summary>
        [Description("A reference to the default data type. This is used when the reference mode sets the data type. The data type can subsequently be changed independently of the matched reference mode pattern")]
        [Property(name: "DefaultDataType", aggregation: AggregationKind.None, multiplicity: "0..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "DataType")]
        public DataType DefaultDataType { get; set; }

        /// <summary>
        /// A string with replacement fields representing a custom format for a value type name based on the entity type name
        /// (replacement field {0}) and reference mode name (replacement field {1}). If not specified, defaults to the ReferenceModeKind FormatString attribute
        /// </summary>
        [Description("Custom format string for this reference mode pattern. Replacement field {0}=EntityTypeName, {1}=ReferenceModeName")]
        [Property(name: "CustomFormatString", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.String, defaultValue: "", typeName: "")]
        public string CustomFormatString { get; set; }
    }
}
