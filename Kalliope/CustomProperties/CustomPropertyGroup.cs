// -------------------------------------------------------------------------------------------------
// <copyright file="CustomPropertyGroup.cs" company="RHEA System S.A.">
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

namespace Kalliope.CustomProperties
{
    using System.Collections.Generic;

    using Kalliope.Common;
    using Kalliope.Core;

    /// <summary>
    /// A collection of custom property definitions for a particular namespace
    /// </summary>
    [Description("A collection of custom property definitions for a particular namespace")]
    [Domain(isAbstract: false, general: "ModelThing")]
    [Container(typeName: "OrmRoot", propertyName: "CustomPropertyGroups")]
    public class CustomPropertyGroup : ModelThing
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomPropertyGroup"/>
        /// </summary>
        public CustomPropertyGroup()
        {
            this.PropertyDefinitions = new List<CustomPropertyDefinition>();
        }

        /// <summary>
        /// Name of the custom property group
        /// </summary>
        [Description("Name of the custom property group")]
        [Property(name: "Name", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.String, defaultValue: "", typeName: "")]
        public string Name { get; set; }

        /// <summary>
        /// Default group of which all defined properties will be loaded and cannot be deleted at the model level
        /// </summary>
        [Description("Default group of which all defined properties will be loaded and cannot be deleted at the model level")]
        [Property(name: "IsDefault", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Boolean, defaultValue: "false", typeName: "")]
        public bool IsDefault { get; set; }

        /// <summary>
        /// Short description of the custom property group
        /// </summary>
        [Description("Short description of the custom property group")]
        [Property(name: "Description", aggregation: AggregationKind.None, multiplicity: "0..1", typeKind: TypeKind.String, defaultValue: "", typeName: "")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the contained <see cref="CustomPropertyDefinition"/>
        /// </summary>
        [Description("Gets or sets the contained CustomPropertyDefinition")]
        [Property(name: "PropertyDefinitions", aggregation: AggregationKind.Composite, multiplicity: "0..*", typeKind: TypeKind.Object, defaultValue: "", typeName: "CustomPropertyDefinition")]
        public List<CustomPropertyDefinition> PropertyDefinitions { get; set; }
    }
}
