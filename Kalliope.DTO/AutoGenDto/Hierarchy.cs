// -------------------------------------------------------------------------------------------------
// <copyright file="Hierarchy.cs" company="Starion Group S.A.">
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
    /// A Data Transfer Object that represents a Hierarchy
    /// </summary>
    [Container(typeName: "ElementOrganizations", propertyName: "Hierarchies")]
    public partial class Hierarchy : OrmNamedElement
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Hierarchy"/> class.
        /// </summary>
        public Hierarchy()
        {
            this.AbsorbedFactTypes = new List<string>();
            this.AbsorbedObjectTypes = new List<string>();
        }
 
        /// <summary>
        /// Gets or sets the unique identifier of the container
        /// </summary>
        public string Container {get; set;}
 

        /// <summary>
        /// Gets or sets a list unique identifiers of the contained <see cref="AbsorbedFactType"/> instances
        /// </summary>
        [Description("Gets or sets the List of AbsorbedFactTypes")]
        [Property(name: "AbsorbedFactTypes", aggregation: AggregationKind.Composite, multiplicity: "0..*", typeKind: TypeKind.Object, defaultValue: "", typeName: "AbsorbedFactType", allowOverride: false, isOverride: false, isDerived: false)]
        public List<string> AbsorbedFactTypes { get; set; }
 
        /// <summary>
        /// Gets or sets a list unique identifiers of the contained <see cref="AbsorbedObjectType"/> instances
        /// </summary>
        [Description("Gets or sets the List of AbsorbedObjectTypes")]
        [Property(name: "AbsorbedObjectTypes", aggregation: AggregationKind.Composite, multiplicity: "0..*", typeKind: TypeKind.Object, defaultValue: "", typeName: "AbsorbedObjectType", allowOverride: false, isOverride: false, isDerived: false)]
        public List<string> AbsorbedObjectTypes { get; set; }
 
        /// <summary>
        /// Gets or sets a DataValueName
        /// </summary>
        [Description("Gets or sets the DataValueName")]
        [Property(name: "DataValueName", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.String, defaultValue: "", typeName: "", allowOverride: false, isOverride: false, isDerived: false)]
        public string DataValueName { get; set; }
 
        /// <summary>
        /// Gets or sets a ReferenceTypeSuffix
        /// </summary>
        [Description("Gets or sets the ReferenceTypeSuffix")]
        [Property(name: "ReferenceTypeSuffix", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.String, defaultValue: "", typeName: "", allowOverride: false, isOverride: false, isDerived: false)]
        public string ReferenceTypeSuffix { get; set; }
 
        /// <summary>
        /// Gets or sets a RootElementName
        /// </summary>
        [Description("Gets or sets the RootElementName")]
        [Property(name: "RootElementName", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.String, defaultValue: "", typeName: "", allowOverride: false, isOverride: false, isDerived: false)]
        public string RootElementName { get; set; }
 
        /// <summary>
        /// Gets or sets a SchemaFileTag
        /// </summary>
        [Description("Gets or sets the SchemaFileTag")]
        [Property(name: "SchemaFileTag", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.String, defaultValue: "", typeName: "", allowOverride: false, isOverride: false, isDerived: false)]
        public string SchemaFileTag { get; set; }
 
        /// <summary>
        /// Gets or sets a XmlNamespace
        /// </summary>
        [Description("Gets or sets the XmlNamespace")]
        [Property(name: "XmlNamespace", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.String, defaultValue: "", typeName: "", allowOverride: false, isOverride: false, isDerived: false)]
        public string XmlNamespace { get; set; }
 
        /// <summary>
        /// Gets or sets a XmlPrefix
        /// </summary>
        [Description("Gets or sets the XmlPrefix")]
        [Property(name: "XmlPrefix", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.String, defaultValue: "", typeName: "", allowOverride: false, isOverride: false, isDerived: false)]
        public string XmlPrefix { get; set; }
 
    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
