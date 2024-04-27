// -------------------------------------------------------------------------------------------------
// <copyright file="ObjectTypeShape.cs" company="Starion Group S.A.">
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
    /// A Data Transfer Object that represents a ObjectTypeShape
    /// </summary>
    /// <remarks>
    /// Shape that represents an ObjectType
    /// </remarks>
    [Container(typeName: "FactTypeShape", propertyName: "ObjectifiedFactTypeNameShapes")]
    public partial class ObjectTypeShape : OrmBaseShape
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectTypeShape"/> class.
        /// </summary>
        public ObjectTypeShape()
        {
            this.CardinalityConstraintShapes = new List<string>();
            this.ValueConstraintShapes = new List<string>();
        }
 
        /// <summary>
        /// Gets or sets the unique identifier of the container
        /// </summary>
        public string Container {get; set;}
 

        /// <summary>
        /// Gets or sets a list unique identifiers of the contained <see cref="CardinalityConstraintShape"/> instances
        /// </summary>
        [Description("")]
        [Property(name: "CardinalityConstraintShapes", aggregation: AggregationKind.Composite, multiplicity: "0..*", typeKind: TypeKind.Object, defaultValue: "", typeName: "CardinalityConstraintShape", allowOverride: false, isOverride: false, isDerived: false)]
        public List<string> CardinalityConstraintShapes { get; set; }
 
        /// <summary>
        /// Gets or sets a DisplayRelatedTypes
        /// </summary>
        [Description("hould links to subtypes and supertypes be attached to this shape")]
        [Property(name: "DisplayRelatedTypes", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Enumeration, defaultValue: "", typeName: "RelatedTypesDisplay", allowOverride: false, isOverride: false, isDerived: false)]
        public RelatedTypesDisplay DisplayRelatedTypes { get; set; }
 
        /// <summary>
        /// Gets or sets a ExpandRefMode
        /// </summary>
        [Description("Should shapes for the FactType and ValueType corresponding to this ReferenceMode pattern be displayed on the diagram")]
        [Property(name: "ExpandRefMode", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Boolean, defaultValue: "false", typeName: "", allowOverride: false, isOverride: false, isDerived: false)]
        public bool ExpandRefMode { get; set; }
 
        /// <summary>
        /// Gets or sets the unique identifier of the referenced <see cref="ObjectType"/>
        /// </summary>
        [Description("The subject ObjectType that is represented by this shape")]
        [Property(name: "Subject", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "ObjectType", allowOverride: false, isOverride: false, isDerived: false)]
        public string Subject { get; set; }
 
        /// <summary>
        /// Gets or sets a list unique identifiers of the contained <see cref="ValueConstraintShape"/> instances
        /// </summary>
        [Description("")]
        [Property(name: "ValueConstraintShapes", aggregation: AggregationKind.Composite, multiplicity: "0..*", typeKind: TypeKind.Object, defaultValue: "", typeName: "ValueConstraintShape", allowOverride: false, isOverride: false, isDerived: false)]
        public List<string> ValueConstraintShapes { get; set; }
 
    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
