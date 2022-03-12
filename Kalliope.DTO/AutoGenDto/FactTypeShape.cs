// -------------------------------------------------------------------------------------------------
// <copyright file="FactTypeShape.cs" company="RHEA System S.A.">
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
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
 
namespace Kalliope.DTO
{
    using System;
    using System.Collections.Generic;
 
    using Kalliope.Common;
 
    /// <summary>
    /// A Data Transfer Object that represents a FactTypeShape
    /// </summary>
    /// <remarks>
    /// Shape that represents a FactType
    /// </remarks>
    [Container(typeName: "ORMDiagram", propertyName: "FactTypeShapes")]
    public partial class FactTypeShape : ORMBaseShape
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FactTypeShape"/> class.
        /// </summary>
        public FactTypeShape()
        {
            this.CardinalityConstraintShapes = new List<string>();
            this.ConstraintDisplayPosition = ConstraintDisplayPosition.Top;
            this.DisplayOrientation = DisplayOrientation.Horizontal;
            this.DisplayRelatedTypes = RelatedTypesDisplay.AttachAllTypes;
            this.DisplayRoleNames = DisplayRoleNames.UserDefault;
            this.ObjectifiedFactTypeNameShapes = new List<string>();
            this.ReadingShapes = new List<string>();
            this.RoleDisplayOrder = new List<string>();
            this.RoleNameShapes = new List<string>();
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
        [Property(name: "CardinalityConstraintShapes", aggregation: AggregationKind.Composite, multiplicity: "0..*", typeKind: TypeKind.Object, defaultValue: "", typeName: "CardinalityConstraintShape")]
        public List<string> CardinalityConstraintShapes { get; set; }
 
        /// <summary>
        /// Gets or sets a ConstraintDisplayPosition
        /// </summary>
        [Description("Determines where internal constraints are drawn on this FactTypeShape")]
        [Property(name: "ConstraintDisplayPosition", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Enumeration, defaultValue: "Top", typeName: "ConstraintDisplayPosition")]
        public ConstraintDisplayPosition ConstraintDisplayPosition { get; set; }
 
        /// <summary>
        /// Gets or sets a DisplayAsObjectType
        /// </summary>
        [Description("Should this shape be shown as an object type without readings or attached role players")]
        [Property(name: "DisplayAsObjectType", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Boolean, defaultValue: "false", typeName: "")]
        public bool DisplayAsObjectType { get; set; }
 
        /// <summary>
        /// Gets or sets a DisplayOrientation
        /// </summary>
        [Description("Determines if the fact type is shown horizontally or vertically")]
        [Property(name: "DisplayOrientation", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Enumeration, defaultValue: "Horizontal", typeName: "DisplayOrientation")]
        public DisplayOrientation DisplayOrientation { get; set; }
 
        /// <summary>
        /// Gets or sets a DisplayRelatedTypes
        /// </summary>
        [Description("Should links to subtypes and supertypes be attached to this shape")]
        [Property(name: "DisplayRelatedTypes", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Enumeration, defaultValue: "AttachAllTypes", typeName: "RelatedTypesDisplay")]
        public RelatedTypesDisplay DisplayRelatedTypes { get; set; }
 
        /// <summary>
        /// Gets or sets a DisplayRoleNames
        /// </summary>
        [Description("Determines whether RoleNameShapes will be drawn for the Roles in the FactType represented by this FactTypeShape, overriding the global setting")]
        [Property(name: "DisplayRoleNames", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Enumeration, defaultValue: "UserDefault", typeName: "DisplayRoleNames")]
        public DisplayRoleNames DisplayRoleNames { get; set; }
 
        /// <summary>
        /// Gets or sets a ExpandRefMode
        /// </summary>
        [Description("Should shapes for the FactType and ValueType corresponding to this ReferenceMode pattern be displayed on the diagram")]
        [Property(name: "ExpandRefMode", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Boolean, defaultValue: "false", typeName: "")]
        public bool ExpandRefMode { get; set; }
 
        /// <summary>
        /// Gets or sets a list unique identifiers of the contained <see cref="ObjectTypeShape"/> instances
        /// </summary>
        [Description("")]
        [Property(name: "ObjectifiedFactTypeNameShapes", aggregation: AggregationKind.Composite, multiplicity: "0..*", typeKind: TypeKind.Object, defaultValue: "", typeName: "ObjectTypeShape")]
        public List<string> ObjectifiedFactTypeNameShapes { get; set; }
 
        /// <summary>
        /// Gets or sets a list unique identifiers of the contained <see cref="ReadingShape"/> instances
        /// </summary>
        [Description("")]
        [Property(name: "ReadingShapes", aggregation: AggregationKind.Composite, multiplicity: "0..*", typeKind: TypeKind.Object, defaultValue: "", typeName: "ReadingShape")]
        public List<string> ReadingShapes { get; set; }
 
        /// <summary>
        /// Gets or sets a list unique identifiers of the referenced <see cref="RoleBase"/> instances
        /// </summary>
        [Description("")]
        [Property(name: "RoleDisplayOrder", aggregation: AggregationKind.None, multiplicity: "0..*", typeKind: TypeKind.Object, defaultValue: "", typeName: "RoleBase")]
        public List<string> RoleDisplayOrder { get; set; }
 
        /// <summary>
        /// Gets or sets a list unique identifiers of the contained <see cref="RoleNameShape"/> instances
        /// </summary>
        [Description("")]
        [Property(name: "RoleNameShapes", aggregation: AggregationKind.Composite, multiplicity: "0..*", typeKind: TypeKind.Object, defaultValue: "", typeName: "RoleNameShape")]
        public List<string> RoleNameShapes { get; set; }
 
        /// <summary>
        /// Gets or sets the unique identifier of the referenced <see cref="FactType"/>
        /// </summary>
        [Description("The subject FactType that is represented by this shape")]
        [Property(name: "Subject", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "FactType")]
        public string Subject { get; set; }
 
        /// <summary>
        /// Gets or sets a list unique identifiers of the contained <see cref="ValueConstraintShape"/> instances
        /// </summary>
        [Description("")]
        [Property(name: "ValueConstraintShapes", aggregation: AggregationKind.Composite, multiplicity: "0..*", typeKind: TypeKind.Object, defaultValue: "", typeName: "ValueConstraintShape")]
        public List<string> ValueConstraintShapes { get; set; }
 
    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
