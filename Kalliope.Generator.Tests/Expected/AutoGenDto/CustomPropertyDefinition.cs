// -------------------------------------------------------------------------------------------------
// <copyright file="CustomPropertyDefinition.cs" company="Starion Group S.A.">
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
    /// A Data Transfer Object that represents a CustomPropertyDefinition
    /// </summary>
    /// <remarks>
    /// A custom property associated with a group
    /// </remarks>
    [Container(typeName: "CustomPropertyGroup", propertyName: "PropertyDefinitions")]
    public partial class CustomPropertyDefinition : ModelThing
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomPropertyDefinition"/> class.
        /// </summary>
        public CustomPropertyDefinition()
        {
            this.ORMTypes = new List<ORMType>();
        }
 
        /// <summary>
        /// Gets or sets the unique identifier of the container
        /// </summary>
        public string Container {get; set;}
 

        /// <summary>
        /// Gets or sets a Category
        /// </summary>
        [Description("Category the property belongs to")]
        [Property(name: "Category", aggregation: AggregationKind.None, multiplicity: "0..1", typeKind: TypeKind.String, defaultValue: "", typeName: "", allowOverride: false, isOverride: false, isDerived: false)]
        public string Category { get; set; }
 
        /// <summary>
        /// Gets or sets a CustomEnumValue
        /// </summary>
        [Description("Gets or sets the custom Enum value.")]
        [Property(name: "CustomEnumValue", aggregation: AggregationKind.None, multiplicity: "0..1", typeKind: TypeKind.String, defaultValue: "", typeName: "CustomEnumValue", allowOverride: false, isOverride: false, isDerived: false)]
        public string CustomEnumValue { get; set; }
 
        /// <summary>
        /// Gets or sets a DataType
        /// </summary>
        [Description("Data type of the property's value.")]
        [Property(name: "DataType", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Enumeration, defaultValue: "", typeName: "CustomPropertyDataType", allowOverride: false, isOverride: false, isDerived: false)]
        public CustomPropertyDataType DataType { get; set; }
 
        /// <summary>
        /// Gets or sets a DefaultValue
        /// </summary>
        [Description("Default value to be used for the property, zero (0) for numeric properties, empty string for all others.")]
        [Property(name: "DefaultValue", aggregation: AggregationKind.None, multiplicity: "0..1", typeKind: TypeKind.Obj, defaultValue: "", typeName: "object", allowOverride: false, isOverride: false, isDerived: false)]
        public object DefaultValue { get; set; }
 
        /// <summary>
        /// Gets or sets a Description
        /// </summary>
        [Description("Description of the property")]
        [Property(name: "Description", aggregation: AggregationKind.None, multiplicity: "0..1", typeKind: TypeKind.String, defaultValue: "", typeName: "", allowOverride: false, isOverride: false, isDerived: false)]
        public string Description { get; set; }
 
        /// <summary>
        /// Gets or sets a Name
        /// </summary>
        [Description("Name of the property")]
        [Property(name: "Name", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.String, defaultValue: "", typeName: "", allowOverride: false, isOverride: false, isDerived: false)]
        public string Name { get; set; }
 
        /// <summary>
        /// Gets or sets a list of ORMTypes
        /// </summary>
        [Description("Gets or sets the ORMTypes that this definition can be applied to.")]
        [Property(name: "ORMTypes", aggregation: AggregationKind.None, multiplicity: "1..*", typeKind: TypeKind.Enumeration, defaultValue: "", typeName: "ORMType", allowOverride: false, isOverride: false, isDerived: false)]
        public List<ORMType> ORMTypes { get; set; }
 
        /// <summary>
        /// Gets or sets a VerbalizeDefaultValue
        /// </summary>
        [Description("")]
        [Property(name: "VerbalizeDefaultValue", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Boolean, defaultValue: "true", typeName: "", allowOverride: false, isOverride: false, isDerived: false)]
        public bool VerbalizeDefaultValue { get; set; }
 
    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
