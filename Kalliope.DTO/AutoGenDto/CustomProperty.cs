// -------------------------------------------------------------------------------------------------
// <copyright file="CustomProperty.cs" company="RHEA System S.A.">
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

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------

namespace Kalliope.DTO
{
    using System;
    using System.Collections.Generic;

    using Kalliope.Common;

    /// <summary>
    /// A Data Transfer Object that represents a CustomProperty
    /// </summary>
    /// <remarks>
    /// A custom property that can be used to annotate ModelThings
    /// </remarks>
    public partial class CustomProperty : Extension
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomProperty"/> class.
        /// </summary>
        public CustomProperty()
        {
        }
 

        /// <summary>
        /// Gets or sets the unique identifier of the referenced <see cref="CustomPropertyDefinition"/>
        /// </summary>
        [Description("Gets or sets the referenced CustomPropertyDefinition")]
        [Property(name: "CustomPropertyDefinition", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "CustomPropertyDefinition", allowOverride: false, isOverride: false, isDerived: false)]
        public string CustomPropertyDefinition { get; set; }
 
        /// <summary>
        /// Gets or sets a Value
        /// </summary>
        [Description("Gets or sets the value which can be of type String, Integer, Decimal, DateTime")]
        [Property(name: "Value", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Obj, defaultValue: "", typeName: "object", allowOverride: false, isOverride: false, isDerived: false)]
        public object Value { get; set; }
 
    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
