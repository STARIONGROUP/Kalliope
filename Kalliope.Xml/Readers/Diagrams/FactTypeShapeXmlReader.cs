// -------------------------------------------------------------------------------------------------
// <copyright file="FactTypeShapeXmlReader.cs" company="RHEA System S.A.">
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

namespace Kalliope.Xml.Readers
{
    using System;
    using System.Collections.Generic;
    using System.Xml;

    using Kalliope.Common;
    using Kalliope.DTO;

    /// <summary>
    /// The purpose of the <see cref="FactTypeShapeXmlReader"/> is to deserialize a <see cref="FactTypeShape"/>
    /// from an .orm XML file
    /// </summary>
    public class FactTypeShapeXmlReader : ORMBaseShapeXmlReader
    {
        /// <summary>
        /// Reads the properties of the provided <see cref="FactTypeShape"/> from the <see cref="XmlReader"/>
        /// </summary>
        /// <param name="factTypeShape">
        /// The subject <see cref="FactTypeShape"/> that is to be deserialized
        /// </param>
        /// <param name="reader">
        /// The <see cref="XmlReader"/> that contains the .orm XML
        /// </param>
        /// <param name="modelThings">
        /// a list of <see cref="ModelThing"/>s to which the deserialized items are added
        /// </param>
        public void ReadXml(FactTypeShape factTypeShape, XmlReader reader, List<ModelThing> modelThings)
        {
            base.ReadXml(factTypeShape, reader, modelThings);

            var constraintDisplayPositionAttribute = reader.GetAttribute("ConstraintDisplayPosition");
            if (Enum.TryParse(constraintDisplayPositionAttribute, out ConstraintDisplayPosition constraintDisplayPosition))
            {
                factTypeShape.ConstraintDisplayPosition = constraintDisplayPosition;
            }

            var displayRoleNamesAttribute = reader.GetAttribute("DisplayRoleNames");
            if (Enum.TryParse(displayRoleNamesAttribute, out DisplayRoleNames displayRoleNames))
            {
                factTypeShape.DisplayRoleNames = displayRoleNames;
            }

            var displayOrientationAttribute = reader.GetAttribute("DisplayOrientation");
            if (Enum.TryParse(displayOrientationAttribute, out DisplayOrientation displayOrientation))
            {
                factTypeShape.DisplayOrientation = displayOrientation;
            }

            var displayRelatedTypesAttribute = reader.GetAttribute("DisplayRelatedTypes");
            if (Enum.TryParse(displayRelatedTypesAttribute, out RelatedTypesDisplay displayRelatedTypes))
            {
                factTypeShape.DisplayRelatedTypes = displayRelatedTypes;
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
                                this.ReadRelativeShapes(factTypeShape, relativeShapesSubtree, modelThings);
                            }
                            break;
                        case "RoleDisplayOrder":
                            using (var roleDisplayOrderSubtree = reader.ReadSubtree())
                            {
                                roleDisplayOrderSubtree.MoveToContent();
                                this.ReadRoleDisplayOrders(factTypeShape, roleDisplayOrderSubtree);
                            }
                            break;
                        case "Subject":
                            factTypeShape.Subject = reader.GetAttribute("ref");
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
        /// <param name="factTypeShape">
        /// The subject <see cref="FactTypeShape"/> that is to be deserialized
        /// </param>
        /// <param name="reader">
        /// an instance of <see cref="XmlReader"/> used to read the .orm file
        /// </param>
        /// <param name="modelThings">
        /// a list of <see cref="ModelThing"/>s to which the deserialized items are added
        /// </param>
        private void ReadRelativeShapes(FactTypeShape factTypeShape, XmlReader reader, List<ModelThing> modelThings)
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
                                var objectTypeShapeXmlReader = new ObjectTypeShapeXmlReader();
                                objectTypeShapeXmlReader.ReadXml(objectTypeShape, objectTypeShapeSubtree, modelThings);
                                objectTypeShape.Container = factTypeShape.Id;
                                factTypeShape.ObjectifiedFactTypeNameShapes.Add(objectTypeShape.Id);
                            }
                            break;
                        case "ReadingShape":
                            using (var readingShapeSubtree = reader.ReadSubtree())
                            {
                                readingShapeSubtree.MoveToContent();
                                var readingShape = new ReadingShape();
                                var readingShapeXmlReader = new ReadingShapeXmlReader();
                                readingShapeXmlReader.ReadXml(readingShape, readingShapeSubtree, modelThings);
                                readingShape.Container = factTypeShape.Id;
                                factTypeShape.ReadingShapes.Add(readingShape.Id);
                            }
                            break;
                        case "ValueConstraintShape":
                            using (var valueConstraintShapeSubtree = reader.ReadSubtree())
                            {
                                valueConstraintShapeSubtree.MoveToContent();
                                var valueConstraintShape = new ValueConstraintShape();
                                var valueConstraintShapecXmlReader = new ValueConstraintShapeXmlReader();
                                valueConstraintShapecXmlReader.ReadXml(valueConstraintShape, valueConstraintShapeSubtree, modelThings);
                                valueConstraintShape.Container = factTypeShape.Id;
                                factTypeShape.ValueConstraintShapes.Add(valueConstraintShape.Id);
                            }
                            break;
                        case "RoleNameShape":

                            using (var roleNameShapeSubtree = reader.ReadSubtree())
                            {
                                roleNameShapeSubtree.MoveToContent();
                                var roleNameShape = new RoleNameShape();
                                var roleNameShapeXmlReader = new RoleNameShapeXmlReader();
                                roleNameShapeXmlReader.ReadXml(roleNameShape, roleNameShapeSubtree, modelThings);
                                roleNameShape.Container = factTypeShape.Id;
                                factTypeShape.RoleNameShapes.Add(roleNameShape.Id);
                            }
                            break;
                        case "CardinalityConstraintShape":
                            using (var cardinalityConstraintShapeSubtree = reader.ReadSubtree())
                            {
                                cardinalityConstraintShapeSubtree.MoveToContent();
                                var cardinalityConstraintShape = new CardinalityConstraintShape();
                                var cardinalityConstraintShapeXmlReader = new CardinalityConstraintShapeXmlReader();
                                cardinalityConstraintShapeXmlReader.ReadXml(cardinalityConstraintShape, cardinalityConstraintShapeSubtree, modelThings);
                                cardinalityConstraintShape.Container = factTypeShape.Id;
                                factTypeShape.CardinalityConstraintShapes.Add(cardinalityConstraintShape.Id);
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
        /// <param name="factTypeShape">
        /// The subject <see cref="FactTypeShape"/> that is to be deserialized
        /// </param>
        /// <param name="reader">
        /// an instance of <see cref="XmlReader"/> used to read the .orm file
        /// </param>
        private void ReadRoleDisplayOrders(FactTypeShape factTypeShape, XmlReader reader)
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
                                factTypeShape.RoleDisplayOrder.Add(roleReference);
                            }
                            break;
                        default:
                            throw new NotSupportedException($"{localName} not yet supported");
                    }
                }
            }
        }
    }
}
