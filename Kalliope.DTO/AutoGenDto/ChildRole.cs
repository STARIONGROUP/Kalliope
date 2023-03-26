// -------------------------------------------------------------------------------------------------
// <copyright file="ChildRole.cs" company="RHEA System S.A.">
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
    /// A Data Transfer Object that represents a ChildRole
    /// </summary>
    [Container(typeName: "AbsorbedFactType", propertyName: "PossibleChildRoles")]
    [Container(typeName: "AbsorbedObjectType", propertyName: "PossibleChildRoles")]
    public partial class ChildRole : ModelThing
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChildRole"/> class.
        /// </summary>
        public ChildRole()
        {
        }
 
        /// <summary>
        /// Gets or sets the unique identifier of the container
        /// </summary>
        public string Container {get; set;}
 

        /// <summary>
        /// Gets or sets a CanBePrimary
        /// </summary>
        [Description("")]
        [Property(name: "CanBePrimary", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Boolean, defaultValue: "", typeName: "false", allowOverride: false, isOverride: false, isDerived: false)]
        public bool CanBePrimary { get; set; }
 
        /// <summary>
        /// Gets or sets a ChosenAsPrimary
        /// </summary>
        [Description("")]
        [Property(name: "ChosenAsPrimary", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Boolean, defaultValue: "", typeName: "false", allowOverride: false, isOverride: false, isDerived: false)]
        public bool ChosenAsPrimary { get; set; }
 
        /// <summary>
        /// Gets or sets a Identifier
        /// </summary>
        [Description("")]
        [Property(name: "Identifier", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Boolean, defaultValue: "", typeName: "false", allowOverride: false, isOverride: false, isDerived: false)]
        public bool Identifier { get; set; }
 
        /// <summary>
        /// Gets or sets a Ignored
        /// </summary>
        [Description("")]
        [Property(name: "Ignored", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Boolean, defaultValue: "", typeName: "false", allowOverride: false, isOverride: false, isDerived: false)]
        public bool Ignored { get; set; }
 
        /// <summary>
        /// Gets or sets a IsPrimary
        /// </summary>
        [Description("")]
        [Property(name: "IsPrimary", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Boolean, defaultValue: "", typeName: "false", allowOverride: false, isOverride: false, isDerived: false)]
        public bool IsPrimary { get; set; }
 
        /// <summary>
        /// Gets or sets the unique identifier of the referenced <see cref="ModelThing"/>
        /// </summary>
        [Description("")]
        [Property(name: "ModelThing", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "ModelThing", allowOverride: false, isOverride: false, isDerived: false)]
        public string ModelThing { get; set; }
 
        /// <summary>
        /// Gets or sets a ObjectifiedRole
        /// </summary>
        [Description("")]
        [Property(name: "ObjectifiedRole", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Boolean, defaultValue: "", typeName: "false", allowOverride: false, isOverride: false, isDerived: false)]
        public bool ObjectifiedRole { get; set; }
 
        /// <summary>
        /// Gets or sets a ReferenceLocation
        /// </summary>
        [Description("")]
        [Property(name: "ReferenceLocation", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.String, defaultValue: "", typeName: "", allowOverride: false, isOverride: false, isDerived: false)]
        public string ReferenceLocation { get; set; }
 
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
