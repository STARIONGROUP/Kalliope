// -------------------------------------------------------------------------------------------------
// <copyright file="ObjectTypeShape.cs" company="RHEA System S.A.">
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

namespace Kalliope.Diagrams
{
    using System.Collections.Generic;
    
    using Kalliope.Common;
    using Kalliope.Core;

    /// <summary>
    /// Shape that represents an <see cref="ObjectType"/>
    /// </summary>
    [Description("Shape that represents an ObjectType")]
    [Domain(isAbstract: false, general: "OrmBaseShape")]
    [Container(typeName: "FactTypeShape", propertyName: "ObjectifiedFactTypeNameShapes")]
    public class ObjectTypeShape : OrmBaseShape
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectTypeShape"/>
        /// </summary>
        public ObjectTypeShape()
        {
            this.DisplayRelatedTypes = RelatedTypesDisplay.AttachAllTypes;

            this.ValueConstraintShapes = new List<ValueConstraintShape>();
            this.CardinalityConstraintShapes = new List<CardinalityConstraintShape>();
        }

        /// <summary>
        /// Gets or sets the subject <see cref="ObjectType"/> that is represented by this shape
        /// </summary>
        [Description("The subject ObjectType that is represented by this shape")]
        [Property(name: "Subject", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "ObjectType")]
        public ObjectType Subject { get; set; }

        /// <summary>
        /// Gets or sets a value to determine whether shapes for the FactType and ValueType
        /// corresponding to this ReferenceMode pattern should be displayed on the diagram
        /// </summary>
        [Description("Should shapes for the FactType and ValueType corresponding to this ReferenceMode pattern be displayed on the diagram")]
        [Property(name: "ExpandRefMode", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Boolean, defaultValue: "false", typeName: "")]
        public bool ExpandRefMode { get; set; }

        /// <summary>
        /// Get or sets whether links to subtypes and supertypes should be attached to this shape
        /// </summary>
        [Description("hould links to subtypes and supertypes be attached to this shape")]
        [Property(name: "DisplayRelatedTypes", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Enumeration, defaultValue: "", typeName: "RelatedTypesDisplay")]
        public RelatedTypesDisplay DisplayRelatedTypes { get; set; }

        /// <summary>
        /// Gets or sets the relative <see cref="ValueConstraintShape"/>s
        /// </summary>
        [Description("")]
        [Property(name: "ValueConstraintShapes", aggregation: AggregationKind.Composite, multiplicity: "0..*", typeKind: TypeKind.Object, defaultValue: "", typeName: "ValueConstraintShape")]
        public List<ValueConstraintShape> ValueConstraintShapes { get; set; }

        /// <summary>
        /// Gets or sets the relative <see cref="CardinalityConstraintShape"/>s
        /// </summary>
        [Description("")]
        [Property(name: "CardinalityConstraintShapes", aggregation: AggregationKind.Composite, multiplicity: "0..*", typeKind: TypeKind.Object, defaultValue: "", typeName: "CardinalityConstraintShape")]
        public List<CardinalityConstraintShape> CardinalityConstraintShapes { get; set; }
    }
}
