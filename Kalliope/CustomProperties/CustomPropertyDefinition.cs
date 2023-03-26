// -------------------------------------------------------------------------------------------------
// <copyright file="CustomPropertyDefinition.cs" company="RHEA System S.A.">
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

namespace Kalliope.CustomProperties
{
    using System.Collections.Generic;

    using Kalliope.Common;
    using Kalliope.Core;

    /// <summary>
    /// A custom property associated with a group
    /// </summary>
    [Description("A custom property associated with a group")]
    [Domain(isAbstract: false, general: "ModelThing")]
    [Container(typeName: "CustomPropertyGroup", propertyName: "PropertyDefinitions")]
    public class CustomPropertyDefinition : ModelThing
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomPropertyDefinition"/>
        /// </summary>
        public CustomPropertyDefinition()
        {
            this.VerbalizeDefaultValue = true;
            this.ORMTypes = new List<ORMType>();
        }

        /// <summary>
        /// Name of the property
        /// </summary>
        [Description("Name of the property")]
        [Property(name: "Name", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.String, defaultValue: "", typeName: "")]
        public string Name { get; set; }

        /// <summary>
        /// Description of the property
        /// </summary>
        [Description("Description of the property")]
        [Property(name: "Description", aggregation: AggregationKind.None, multiplicity: "0..1", typeKind: TypeKind.String, defaultValue: "", typeName: "")]
        public string Description { get; set; }

        /// <summary>
        /// Category the property belongs to
        /// </summary>
        [Description("Category the property belongs to")]
        [Property(name: "Category", aggregation: AggregationKind.None, multiplicity: "0..1", typeKind: TypeKind.String, defaultValue: "", typeName: "")]
        public string Category { get; set; }

        /// <summary>
        /// Data type of the property's value
        /// </summary>
        [Description("Data type of the property's value.")]
        [Property(name: "DataType", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Enumeration, defaultValue: "", typeName: "CustomPropertyDataType")]
        public CustomPropertyDataType DataType { get; set; }

        /// <summary>
        /// Default value to be used for the property, zero (0) for numeric properties, empty string for all others
        /// </summary>
        [Description("Default value to be used for the property, zero (0) for numeric properties, empty string for all others.")]
        [Property(name: "DefaultValue", aggregation: AggregationKind.None, multiplicity: "0..1", typeKind: TypeKind.Obj, defaultValue: "", typeName: "object")]
        public object DefaultValue { get; set; }

        [Description("")]
        [Property(name: "VerbalizeDefaultValue", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Boolean, defaultValue: "true", typeName: "")]
        public bool VerbalizeDefaultValue { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="List{ORMType}"/> that this definition can be applied to.
        /// </summary>
        [Description("Gets or sets the ORMTypes that this definition can be applied to.")]
        [Property(name: "ORMTypes", aggregation: AggregationKind.None, multiplicity: "1..*", typeKind: TypeKind.Enumeration, defaultValue: "", typeName: "ORMType")]
        public List<ORMType> ORMTypes { get; set; }

        /// <summary>
        /// Gets or sets the custom Enum value
        /// </summary>
        [Description("Gets or sets the custom Enum value.")]
        [Property(name: "CustomEnumValue", aggregation: AggregationKind.None, multiplicity: "0..1", typeKind: TypeKind.String, defaultValue: "", typeName: "CustomEnumValue")]
        public string CustomEnumValue { get; set; }
    }
}
