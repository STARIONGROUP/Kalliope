// -------------------------------------------------------------------------------------------------
// <copyright file="HierarchyChild.cs" company="Starion Group S.A.">
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
    /// A Data Transfer Object that represents a HierarchyChild
    /// </summary>
    [Container(typeName: "AbsorbedObjectType", propertyName: "HierarchyChildren")]
    public partial class HierarchyChild : ModelThing
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HierarchyChild"/> class.
        /// </summary>
        public HierarchyChild()
        {
        }
 
        /// <summary>
        /// Gets or sets the unique identifier of the container
        /// </summary>
        public string Container {get; set;}
 

        /// <summary>
        /// Gets or sets the unique identifier of the referenced <see cref="AbsorbedObjectType"/>
        /// </summary>
        [Description("")]
        [Property(name: "AbsorbedObjectType", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "AbsorbedObjectType", allowOverride: false, isOverride: false, isDerived: false)]
        public string AbsorbedObjectType { get; set; }
 
        /// <summary>
        /// Gets or sets a ContainmentReason
        /// </summary>
        [Description("")]
        [Property(name: "ContainmentReason", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.String, defaultValue: "", typeName: "", allowOverride: false, isOverride: false, isDerived: false)]
        public string ContainmentReason { get; set; }
 
        /// <summary>
        /// Gets or sets a XmlName
        /// </summary>
        [Description("")]
        [Property(name: "XmlName", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.String, defaultValue: "", typeName: "", allowOverride: false, isOverride: false, isDerived: false)]
        public string XmlName { get; set; }
 
        /// <summary>
        /// Gets or sets a XmlReferenceName
        /// </summary>
        [Description("")]
        [Property(name: "XmlReferenceName", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.String, defaultValue: "", typeName: "", allowOverride: false, isOverride: false, isDerived: false)]
        public string XmlReferenceName { get; set; }
 
        /// <summary>
        /// Gets or sets a XmlReferenceSimpleValueForm
        /// </summary>
        [Description("")]
        [Property(name: "XmlReferenceSimpleValueForm", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.String, defaultValue: "", typeName: "", allowOverride: false, isOverride: false, isDerived: false)]
        public string XmlReferenceSimpleValueForm { get; set; }
 
        /// <summary>
        /// Gets or sets a XmlSimpleValueForm
        /// </summary>
        [Description("")]
        [Property(name: "XmlSimpleValueForm", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.String, defaultValue: "", typeName: "", allowOverride: false, isOverride: false, isDerived: false)]
        public string XmlSimpleValueForm { get; set; }
 
    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
