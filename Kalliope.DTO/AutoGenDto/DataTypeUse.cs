// -------------------------------------------------------------------------------------------------
// <copyright file="DataTypeUse.cs" company="Starion Group S.A.">
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
    /// A Data Transfer Object that represents a DataTypeUse
    /// </summary>
    /// <remarks>
    /// A use of a data type by a value type, including facet information
    /// </remarks>
    [Container(typeName: "ObjectType", propertyName: "ConceptualDataType")]
    public partial class DataTypeUse : OrmModelElement
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DataTypeUse"/> class.
        /// </summary>
        public DataTypeUse()
        {
        }
 
        /// <summary>
        /// Gets or sets the unique identifier of the container
        /// </summary>
        public string Container {get; set;}
 

        /// <summary>
        /// Gets or sets a AutoGenerated
        /// </summary>
        [Description("The values for this data type are autogenerated. This is not set if autogeneration applies to all uses of the data type")]
        [Property(name: "AutoGenerated", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Boolean, defaultValue: "false", typeName: "", allowOverride: false, isOverride: false, isDerived: false)]
        public bool AutoGenerated { get; set; }
 
        /// <summary>
        /// Gets or sets a Length
        /// </summary>
        [Description("The value of the Length facet. Holds the Precision fact for Decimal and Money data types")]
        [Property(name: "Length", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Int32, defaultValue: "", typeName: "", allowOverride: false, isOverride: false, isDerived: false)]
        public int Length { get; set; }
 
        /// <summary>
        /// Gets or sets a Reference
        /// </summary>
        [Description("The value of the referenced element's unique id")]
        [Property(name: "Reference", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.String, defaultValue: "", typeName: "", allowOverride: false, isOverride: false, isDerived: false)]
        public string Reference { get; set; }
 
        /// <summary>
        /// Gets or sets a Scale
        /// </summary>
        [Description("The value of the Scale facet")]
        [Property(name: "Scale", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Int32, defaultValue: "", typeName: "", allowOverride: false, isOverride: false, isDerived: false)]
        public int Scale { get; set; }
 
    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
