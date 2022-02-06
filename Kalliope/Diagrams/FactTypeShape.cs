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
    using System;
    using System.Collections.Generic;
    using System.Xml;

    using Kalliope.Core;

    /// <summary>
    /// Shape that represents an <see cref="FactType"/>
    /// </summary>
    public class FactTypeShape : ORMBaseShape
    {
        private string subjectReference = string.Empty;

        private readonly List<string> roleDisplayOrderReferences = new List<string>();

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
        public FactType Subject { get; set; }

        /// <summary>
        /// Determines where internal constraints are drawn on this <see cref="FactTypeShape"/>
        /// </summary>
        public ConstraintDisplayPosition ConstraintDisplayPosition { get; set; }

        /// <summary>
        /// Determines whether RoleNameShapes will be drawn for the Roles in the FactType represented by this FactTypeShape, overriding the global setting
        /// </summary>
        public DisplayRoleNames DisplayRoleNames { get; set; }

        /// <summary>
        /// Determines if the <see cref="FactType"/> is shown horizontally or vertically
        /// </summary>
        public DisplayOrientation DisplayOrientation { get; set; }

        /// <summary>
        /// gets or sets whether links to subtypes and supertypes should be attached to this shape
        /// </summary>
        public RelatedTypesDisplay DisplayRelatedTypes { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this shape should be shown as an <see cref="ObjectType"/> without readings or attached role players
        /// </summary>
        public bool DisplayAsObjectType { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether shapes for the <see cref="FactType"/> and <see cref="ValueType"/> corresponding to this
        /// ReferenceMode pattern should be displayed on the <see cref="ORMDiagram"/>
        /// </summary>
        public bool ExpandRefMode { get; set; }

        /// <summary>
        /// Gets or sets the referenced <see cref="RoleBase"/> instances.
        /// </summary>
        public List<RoleBase> RoleDisplayOrder { get; set; }

        /// <summary>
        /// Gets or sets the relative <see cref="ObjectTypeShape"/>s
        /// </summary>
        public List<ObjectTypeShape> ObjectifiedFactTypeNameShapes { get; set; }
        
        /// <summary>
        /// Gets or sets the relative <see cref="ReadingShape"/>s
        /// </summary>
        public List<ReadingShape> ReadingShapes { get; set; }

        /// <summary>
        /// Gets or sets the relative <see cref="ValueConstraintShape"/>s
        /// </summary>
        public List<ValueConstraintShape> ValueConstraintShapes { get; set; }

        /// <summary>
        /// Gets or sets the relative <see cref="RoleNameShape"/>s
        /// </summary>
        public List<RoleNameShape> RoleNameShapes { get; set; }

        /// <summary>
        /// Gets or sets the relative <see cref="CardinalityConstraintShape"/>s
        /// </summary>
        public List<CardinalityConstraintShape> CardinalityConstraintShapes { get; set; }

        /// <summary>
        /// Generates a <see cref="FactTypeShape"/> object from its XML representation.
        /// </summary>
        /// <param name="reader">
        /// an instance of <see cref="XmlReader"/> used to read the .orm file
        /// </param>
        internal override void ReadXml(XmlReader reader)
        {
            base.ReadXml(reader);
            
            var constraintDisplayPositionAttribute = reader.GetAttribute("ConstraintDisplayPosition");
            if (Enum.TryParse(constraintDisplayPositionAttribute, out ConstraintDisplayPosition constraintDisplayPosition))
            {
                this.ConstraintDisplayPosition = constraintDisplayPosition;
            }

            var displayRoleNamesAttribute = reader.GetAttribute("DisplayRoleNames");
            if (Enum.TryParse(displayRoleNamesAttribute, out DisplayRoleNames displayRoleNames))
            {
                this.DisplayRoleNames = displayRoleNames;
            }

            var displayOrientationAttribute = reader.GetAttribute("DisplayOrientation");
            if (Enum.TryParse(displayOrientationAttribute, out DisplayOrientation displayOrientation))
            {
                this.DisplayOrientation = displayOrientation;
            }

            var displayRelatedTypesAttribute = reader.GetAttribute("DisplayRelatedTypes");
            if (Enum.TryParse(displayRelatedTypesAttribute, out RelatedTypesDisplay displayRelatedTypes))
            {
                this.DisplayRelatedTypes = displayRelatedTypes;
            }

            while (reader.Read())
            {
                if (reader.MoveToContent() == XmlNodeType.Element)
                {
                    var localName = reader.LocalName;

                    switch (localName)
                    {
                        case "RelativeShapes":
                            using (var relativeShapesSubtree = reader.ReadSubtree())
                            {
                                relativeShapesSubtree.MoveToContent();
                                this.ReadRelativeShapes(relativeShapesSubtree);
                            }
                            break;
                        case "RoleDisplayOrder":

                            using (var roleDisplayOrderSubtree = reader.ReadSubtree())
                            {
                                roleDisplayOrderSubtree.MoveToContent();
                                this.ReadRoleDisplayOrders(roleDisplayOrderSubtree);
                            }

                            break;
                        case "Subject":
                            this.subjectReference = reader.GetAttribute("ref");
                            break;
                        default:
                            throw new System.NotSupportedException($"{localName} not yet supported");
                    }
                }
            }
        }

        /// <summary>
        /// Reads the relative shapes
        /// </summary>
        /// <param name="reader">
        /// an instance of <see cref="XmlReader"/> used to read the .orm file
        /// </param>
        private void ReadRelativeShapes(XmlReader reader)
        {
            while (reader.Read())
            {
                if (reader.MoveToContent() == XmlNodeType.Element)
                {
                    var localName = reader.LocalName;

                    switch (localName)
                    {
                        case "ObjectifiedFactTypeNameShape":
                            using (var objectTypeShapeSubtree = reader.ReadSubtree())
                            {
                                objectTypeShapeSubtree.MoveToContent();
                                var objectTypeShape = new ObjectTypeShape();
                                objectTypeShape.ReadXml(objectTypeShapeSubtree);
                                this.ObjectifiedFactTypeNameShapes.Add(objectTypeShape);
                            }
                            break;
                        case "ReadingShape":
                            using (var readingShapeSubtree = reader.ReadSubtree())
                            {
                                readingShapeSubtree.MoveToContent();
                                var readingShape = new ReadingShape();
                                readingShape.ReadXml(readingShapeSubtree);
                                this.ReadingShapes.Add(readingShape);
                            }
                            break;
                        case "ValueConstraintShape":
                            using (var valueConstraintShapeSubtree = reader.ReadSubtree())
                            {
                                valueConstraintShapeSubtree.MoveToContent();
                                var valueConstraintShape = new ValueConstraintShape();
                                valueConstraintShape.ReadXml(valueConstraintShapeSubtree);
                                this.ValueConstraintShapes.Add(valueConstraintShape);
                            }
                            break;
                        case "RoleNameShape":

                            using (var roleNameShapeSubtree = reader.ReadSubtree())
                            {
                                roleNameShapeSubtree.MoveToContent();
                                var roleNameShape = new RoleNameShape();
                                roleNameShape.ReadXml(roleNameShapeSubtree);
                                this.RoleNameShapes.Add(roleNameShape);
                            }
                            break;
                        case "CardinalityConstraintShape":
                            using (var cardinalityConstraintShapeSubtree = reader.ReadSubtree())
                            {
                                cardinalityConstraintShapeSubtree.MoveToContent();
                                var cardinalityConstraintShape = new CardinalityConstraintShape();
                                cardinalityConstraintShape.ReadXml(cardinalityConstraintShapeSubtree);
                                this.CardinalityConstraintShapes.Add(cardinalityConstraintShape);
                            }
                            break;
                        default:
                            throw new System.NotSupportedException($"{localName} not yet supported");
                    }
                }
            }
        }

        /// <summary>
        /// Reads the RoleDisplayOrders
        /// </summary>
        /// <param name="reader">
        /// an instance of <see cref="XmlReader"/> used to read the .orm file
        /// </param>
        private void ReadRoleDisplayOrders(XmlReader reader)
        {
            while (reader.Read())
            {
                if (reader.MoveToContent() == XmlNodeType.Element)
                {
                    var localName = reader.LocalName;

                    switch (localName)
                    {
                        case "Role":

                            var roleReference = reader.GetAttribute("ref");
                            if (!string.IsNullOrEmpty(roleReference))
                            {
                                this.roleDisplayOrderReferences.Add(roleReference);
                            }
                            break;
                        
                        default:
                            throw new System.NotSupportedException($"{localName} not yet supported");
                    }
                }
            }
        }
    }
}
