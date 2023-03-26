// -------------------------------------------------------------------------------------------------
// <copyright file="AbsorbedObjectType.cs" company="RHEA System S.A.">
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
    /// A Data Transfer Object that represents a AbsorbedObjectType
    /// </summary>
    [Container(typeName: "Hierarchy", propertyName: "AbsorbedObjectTypes")]
    public partial class AbsorbedObjectType : ModelThing
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AbsorbedObjectType"/> class.
        /// </summary>
        public AbsorbedObjectType()
        {
            this.AbsorbedRoles = new List<string>();
            this.HierarchyChildren = new List<string>();
            this.PossibleChildRoles = new List<string>();
        }
 
        /// <summary>
        /// Gets or sets the unique identifier of the container
        /// </summary>
        public string Container {get; set;}
 

        /// <summary>
        /// Gets or sets a list unique identifiers of the contained <see cref="AbsorbedRole"/> instances
        /// </summary>
        [Description("")]
        [Property(name: "AbsorbedRoles", aggregation: AggregationKind.Composite, multiplicity: "0..*", typeKind: TypeKind.Object, defaultValue: "", typeName: "AbsorbedRole", allowOverride: false, isOverride: false, isDerived: false)]
        public List<string> AbsorbedRoles { get; set; }
 
        /// <summary>
        /// Gets or sets a AbsorptionPattern
        /// </summary>
        [Description("")]
        [Property(name: "AbsorptionPattern", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.String, defaultValue: "", typeName: "", allowOverride: false, isOverride: false, isDerived: false)]
        public string AbsorptionPattern { get; set; }
 
        /// <summary>
        /// Gets or sets a ForceTopLevel
        /// </summary>
        [Description("")]
        [Property(name: "ForceTopLevel", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Boolean, defaultValue: "", typeName: "false", allowOverride: false, isOverride: false, isDerived: false)]
        public bool ForceTopLevel { get; set; }
 
        /// <summary>
        /// Gets or sets a list unique identifiers of the contained <see cref="HierarchyChild"/> instances
        /// </summary>
        [Description("")]
        [Property(name: "HierarchyChildren", aggregation: AggregationKind.Composite, multiplicity: "0..*", typeKind: TypeKind.Object, defaultValue: "", typeName: "HierarchyChild", allowOverride: false, isOverride: false, isDerived: false)]
        public List<string> HierarchyChildren { get; set; }
 
        /// <summary>
        /// Gets or sets a Nested
        /// </summary>
        [Description("")]
        [Property(name: "Nested", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Boolean, defaultValue: "", typeName: "false", allowOverride: false, isOverride: false, isDerived: false)]
        public bool Nested { get; set; }
 
        /// <summary>
        /// Gets or sets the unique identifier of the referenced <see cref="ObjectType"/>
        /// </summary>
        [Description("")]
        [Property(name: "ObjectType", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "ObjectType", allowOverride: false, isOverride: false, isDerived: false)]
        public string ObjectType { get; set; }
 
        /// <summary>
        /// Gets or sets a list unique identifiers of the contained <see cref="ChildRole"/> instances
        /// </summary>
        [Description("")]
        [Property(name: "PossibleChildRoles", aggregation: AggregationKind.Composite, multiplicity: "0..*", typeKind: TypeKind.Object, defaultValue: "", typeName: "ChildRole", allowOverride: false, isOverride: false, isDerived: false)]
        public List<string> PossibleChildRoles { get; set; }
 
        /// <summary>
        /// Gets or sets a TopLevel
        /// </summary>
        [Description("")]
        [Property(name: "TopLevel", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Boolean, defaultValue: "", typeName: "false", allowOverride: false, isOverride: false, isDerived: false)]
        public bool TopLevel { get; set; }
 
        /// <summary>
        /// Gets or sets a WithSupertype
        /// </summary>
        [Description("")]
        [Property(name: "WithSupertype", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Boolean, defaultValue: "", typeName: "false", allowOverride: false, isOverride: false, isDerived: false)]
        public bool WithSupertype { get; set; }
 
        /// <summary>
        /// Gets or sets a XmlName
        /// </summary>
        [Description("")]
        [Property(name: "XmlName", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.String, defaultValue: "", typeName: "", allowOverride: false, isOverride: false, isDerived: false)]
        public string XmlName { get; set; }
 
        /// <summary>
        /// Gets or sets a XmlSimpleIdentifierReferenceForm
        /// </summary>
        [Description("")]
        [Property(name: "XmlSimpleIdentifierReferenceForm", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.String, defaultValue: "", typeName: "", allowOverride: false, isOverride: false, isDerived: false)]
        public string XmlSimpleIdentifierReferenceForm { get; set; }
 
    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
