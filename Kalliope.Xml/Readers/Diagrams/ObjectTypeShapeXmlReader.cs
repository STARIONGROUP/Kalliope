// -------------------------------------------------------------------------------------------------
// <copyright file="ObjectTypeShapeXmlReader.cs" company="RHEA System S.A.">
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
    using System.Collections.Generic;
    using System.Xml;

    using Kalliope.DTO;

    /// <summary>
    /// The purpose of the <see cref="ObjectTypeShapeXmlReader"/> is to deserialize a <see cref="ObjectTypeShape"/>
    /// from an .orm XML file
    /// </summary>
    public class ObjectTypeShapeXmlReader : OrmBaseShapeXmlReader
    {
        /// <summary>
        /// Reads the properties of the provided <see cref="ObjectTypeShape"/> from the <see cref="XmlReader"/>
        /// </summary>
        /// <param name="objectTypeShape">
        /// The subject <see cref="ObjectTypeShape"/> that is to be deserialized
        /// </param>
        /// <param name="reader">
        /// The <see cref="XmlReader"/> that contains the .orm XML
        /// </param>
        /// <param name="modelThings">
        /// a list of <see cref="ModelThing"/>s to which the deserialized items are added
        /// </param>
        public void ReadXml(ObjectTypeShape objectTypeShape, XmlReader reader, List<ModelThing> modelThings)
        {
            base.ReadXml(objectTypeShape, reader, modelThings);

            var expandRefMode = reader.GetAttribute("ExpandRefMode");
            if (!string.IsNullOrEmpty(expandRefMode))
            {
                objectTypeShape.ExpandRefMode = XmlConvert.ToBoolean(expandRefMode);
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
                                this.ReadRelativeShapes(objectTypeShape, relativeShapesSubtree, modelThings);
                            }
                            break;
                        case "Subject":
                            objectTypeShape.Subject = reader.GetAttribute("ref");
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
        /// <param name="objectTypeShape">
        /// The subject <see cref="ObjectTypeShape"/> that is to be deserialized
        /// </param>
        /// <param name="reader">
        /// an instance of <see cref="XmlReader"/> used to read the .orm file
        /// </param>
        /// <param name="modelThings">
        /// a list of <see cref="ModelThing"/>s to which the deserialized items are added
        /// </param>
        private void ReadRelativeShapes(ObjectTypeShape objectTypeShape, XmlReader reader, List<ModelThing> modelThings)
        {
            while (reader.Read())
            {
                if (reader.MoveToContent() == XmlNodeType.Element)
                {
                    var localName = reader.LocalName;

                    switch (localName)
                    {
                        case "ValueConstraintShape":
                            using (var valueConstraintShapeSubtree = reader.ReadSubtree())
                            {
                                valueConstraintShapeSubtree.MoveToContent();
                                var valueConstraintShape = new ValueConstraintShape();
                                var valueConstraintShapeXmlReader = new ValueConstraintShapeXmlReader();
                                valueConstraintShapeXmlReader.ReadXml(valueConstraintShape, valueConstraintShapeSubtree, modelThings);
                                valueConstraintShape.Container = objectTypeShape.Id;
                                objectTypeShape.ValueConstraintShapes.Add(valueConstraintShape.Id);
                            }
                            break;
                        case "CardinalityConstraintShape":
                            using (var cardinalityConstraintShapeSubtree = reader.ReadSubtree())
                            {
                                cardinalityConstraintShapeSubtree.MoveToContent();
                                var cardinalityConstraintShape = new CardinalityConstraintShape();
                                var cardinalityConstraintShapeXmlReader = new CardinalityConstraintShapeXmlReader();
                                cardinalityConstraintShapeXmlReader.ReadXml(cardinalityConstraintShape, cardinalityConstraintShapeSubtree, modelThings);
                                cardinalityConstraintShape.Container = objectTypeShape.Id;
                                objectTypeShape.CardinalityConstraintShapes.Add(cardinalityConstraintShape.Id);
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
