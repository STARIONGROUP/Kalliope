// -------------------------------------------------------------------------------------------------
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

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------

namespace Kalliope.DTO
{
    using System;
    using System.Collections.Generic;

    using Kalliope.Common;

    /// <summary>
    /// A Data Transfer Object that represents a CustomReferenceMode
    /// </summary>
    /// <remarks>
    /// Definition of a custom reference mode pattern
    /// </remarks>
    public partial class CustomReferenceMode : ReferenceMode
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomReferenceMode"/> class.
        /// </summary>
        public CustomReferenceMode()
        {
        }
 

        /// <summary>
        /// Gets or sets a CustomFormatString
        /// </summary>
        [Description("Custom format string for this reference mode pattern. Replacement field {0}=EntityTypeName, {1}=ReferenceModeName")]
        [Property(name: "CustomFormatString", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.String, defaultValue: "", typeName: "", allowOverride: false, isOverride: false, isDerived: false)]
        public string CustomFormatString { get; set; }
 
        /// <summary>
        /// Gets or sets the unique identifier of the referenced <see cref="DataType"/>
        /// </summary>
        [Description("A reference to the default data type. This is used when the reference mode sets the data type. The data type can subsequently be changed independently of the matched reference mode pattern")]
        [Property(name: "DefaultDataType", aggregation: AggregationKind.None, multiplicity: "0..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "DataType", allowOverride: false, isOverride: false, isDerived: false)]
        public string DefaultDataType { get; set; }
 
    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
