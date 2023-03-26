// -------------------------------------------------------------------------------------------------
// <copyright file="CustomPropertyGroup.cs" company="RHEA System S.A.">
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
    /// A Data Transfer Object that represents a CustomPropertyGroup
    /// </summary>
    /// <remarks>
    /// A collection of custom property definitions for a particular namespace
    /// </remarks>
    [Container(typeName: "OrmRoot", propertyName: "CustomPropertyGroups")]
    public partial class CustomPropertyGroup : ModelThing
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomPropertyGroup"/> class.
        /// </summary>
        public CustomPropertyGroup()
        {
            this.PropertyDefinitions = new List<string>();
        }
 
        /// <summary>
        /// Gets or sets the unique identifier of the container
        /// </summary>
        public string Container {get; set;}
 

        /// <summary>
        /// Gets or sets a Description
        /// </summary>
        [Description("Short description of the custom property group")]
        [Property(name: "Description", aggregation: AggregationKind.None, multiplicity: "0..1", typeKind: TypeKind.String, defaultValue: "", typeName: "", allowOverride: false, isOverride: false, isDerived: false)]
        public string Description { get; set; }
 
        /// <summary>
        /// Gets or sets a IsDefault
        /// </summary>
        [Description("Default group of which all defined properties will be loaded and cannot be deleted at the model level")]
        [Property(name: "IsDefault", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Boolean, defaultValue: "false", typeName: "", allowOverride: false, isOverride: false, isDerived: false)]
        public bool IsDefault { get; set; }
 
        /// <summary>
        /// Gets or sets a Name
        /// </summary>
        [Description("Name of the custom property group")]
        [Property(name: "Name", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.String, defaultValue: "", typeName: "", allowOverride: false, isOverride: false, isDerived: false)]
        public string Name { get; set; }
 
        /// <summary>
        /// Gets or sets a list unique identifiers of the contained <see cref="CustomPropertyDefinition"/> instances
        /// </summary>
        [Description("Gets or sets the contained CustomPropertyDefinition")]
        [Property(name: "PropertyDefinitions", aggregation: AggregationKind.Composite, multiplicity: "0..*", typeKind: TypeKind.Object, defaultValue: "", typeName: "CustomPropertyDefinition", allowOverride: false, isOverride: false, isDerived: false)]
        public List<string> PropertyDefinitions { get; set; }
 
    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
