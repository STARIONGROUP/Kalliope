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

namespace Kalliope.Diagrams
{
    using System.Collections.Generic;

    using Kalliope.Common;
    using Kalliope.Core;

    /// <summary>
    /// Shape that represents a <see cref="FactType"/>
    /// </summary>
    [Description("Shape that represents a FactType")]
    [Domain(isAbstract: false, general: "ORMBaseShape")]
    [Container(typeName: "ORMDiagram", propertyName: "FactTypeShapes")]
    public class FactTypeShape : ORMBaseShape
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FactTypeShape"/>
        /// </summary>
        public FactTypeShape()
        {
            this.ConstraintDisplayPosition = ConstraintDisplayPosition.Top;
            this.DisplayRoleNames = DisplayRoleNames.UserDefault;
            this.DisplayOrientation = DisplayOrientation.Horizontal;
            this.DisplayRelatedTypes = RelatedTypesDisplay.AttachAllTypes;

            this.RoleDisplayOrder = new List<RoleBase>();
            this.ObjectifiedFactTypeNameShapes = new List<ObjectTypeShape>();
            this.ReadingShapes = new List<ReadingShape>();
            this.ValueConstraintShapes = new List<ValueConstraintShape>();
            this.RoleNameShapes = new List<RoleNameShape>();
            this.CardinalityConstraintShapes = new List<CardinalityConstraintShape>();
        }

        /// <summary>
        /// Gets or sets the subject <see cref="FactType"/> that is represented by this shape
        /// </summary>
        [Description("The subject FactType that is represented by this shape")]
        [Property(name: "Subject", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "FactType")]
        public FactType Subject { get; set; }

        /// <summary>
        /// Determines where internal constraints are drawn on this <see cref="FactTypeShape"/>
        /// </summary>
        [Description("Determines where internal constraints are drawn on this FactTypeShape")]
        [Property(name: "ConstraintDisplayPosition", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Enumeration, defaultValue: "Top", typeName: "ConstraintDisplayPosition")]
        public ConstraintDisplayPosition ConstraintDisplayPosition { get; set; }

        /// <summary>
        /// Determines whether RoleNameShapes will be drawn for the Roles in the FactType represented by this FactTypeShape, overriding the global setting
        /// </summary>
        [Description("Determines whether RoleNameShapes will be drawn for the Roles in the FactType represented by this FactTypeShape, overriding the global setting")]
        [Property(name: "DisplayRoleNames", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Enumeration, defaultValue: "UserDefault", typeName: "DisplayRoleNames")]
        public DisplayRoleNames DisplayRoleNames { get; set; }

        /// <summary>
        /// Determines if the <see cref="FactType"/> is shown horizontally or vertically
        /// </summary>
        [Description("Determines if the fact type is shown horizontally or vertically")]
        [Property(name: "DisplayOrientation", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Enumeration, defaultValue: "Horizontal", typeName: "DisplayOrientation")]
        public DisplayOrientation DisplayOrientation { get; set; }

        /// <summary>
        /// gets or sets whether links to subtypes and supertypes should be attached to this shape
        /// </summary>
        [Description("Should links to subtypes and supertypes be attached to this shape")]
        [Property(name: "DisplayRelatedTypes", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Enumeration, defaultValue: "AttachAllTypes", typeName: "RelatedTypesDisplay")]
        public RelatedTypesDisplay DisplayRelatedTypes { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this shape should be shown as an <see cref="ObjectType"/> without readings or attached role players
        /// </summary>
        [Description("Should this shape be shown as an object type without readings or attached role players")]
        [Property(name: "DisplayAsObjectType", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Boolean, defaultValue: "false", typeName: "")]
        public bool DisplayAsObjectType { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether shapes for the <see cref="FactType"/> and <see cref="ValueType"/> corresponding to this
        /// ReferenceMode pattern should be displayed on the <see cref="ORMDiagram"/>
        /// </summary>
        [Description("Should shapes for the FactType and ValueType corresponding to this ReferenceMode pattern be displayed on the diagram")]
        [Property(name: "ExpandRefMode", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Boolean, defaultValue: "false", typeName: "")]
        public bool ExpandRefMode { get; set; }

        /// <summary>
        /// Gets or sets the referenced <see cref="RoleBase"/> instances.
        /// </summary>
        [Description("")]
        [Property(name: "RoleDisplayOrder", aggregation: AggregationKind.None, multiplicity: "0..*", typeKind: TypeKind.Object, defaultValue: "", typeName: "RoleBase")]
        public List<RoleBase> RoleDisplayOrder { get; set; }

        /// <summary>
        /// Gets or sets the relative <see cref="ObjectTypeShape"/>s
        /// </summary>
        [Description("")]
        [Property(name: "ObjectifiedFactTypeNameShapes", aggregation: AggregationKind.Composite, multiplicity: "0..*", typeKind: TypeKind.Object, defaultValue: "", typeName: "ObjectTypeShape")]
        public List<ObjectTypeShape> ObjectifiedFactTypeNameShapes { get; set; }

        /// <summary>
        /// Gets or sets the relative <see cref="ReadingShape"/>s
        /// </summary>
        [Description("")]
        [Property(name: "ReadingShapes", aggregation: AggregationKind.Composite, multiplicity: "0..*", typeKind: TypeKind.Object, defaultValue: "", typeName: "ReadingShape")]
        public List<ReadingShape> ReadingShapes { get; set; }

        /// <summary>
        /// Gets or sets the relative <see cref="ValueConstraintShape"/>s
        /// </summary>
        [Description("")]
        [Property(name: "ValueConstraintShapes", aggregation: AggregationKind.Composite, multiplicity: "0..*", typeKind: TypeKind.Object, defaultValue: "", typeName: "ValueConstraintShape")]
        public List<ValueConstraintShape> ValueConstraintShapes { get; set; }

        /// <summary>
        /// Gets or sets the relative <see cref="RoleNameShape"/>s
        /// </summary>
        [Description("")]
        [Property(name: "RoleNameShapes", aggregation: AggregationKind.Composite, multiplicity: "0..*", typeKind: TypeKind.Object, defaultValue: "", typeName: "RoleNameShape")]
        public List<RoleNameShape> RoleNameShapes { get; set; }

        /// <summary>
        /// Gets or sets the relative <see cref="CardinalityConstraintShape"/>s
        /// </summary>
        [Description("")]
        [Property(name: "CardinalityConstraintShapes", aggregation: AggregationKind.Composite, multiplicity: "0..*", typeKind: TypeKind.Object, defaultValue: "", typeName: "CardinalityConstraintShape")]
        public List<CardinalityConstraintShape> CardinalityConstraintShapes { get; set; }
    }
}
