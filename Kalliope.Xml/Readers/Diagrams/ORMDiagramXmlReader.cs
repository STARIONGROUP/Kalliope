// -------------------------------------------------------------------------------------------------
// <copyright file="OrmDiagramXmlReader.cs" company="RHEA System S.A.">
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

namespace Kalliope.Xml.Readers
{
    using System.Collections.Generic;
    using System.Xml;

    using Kalliope.DTO;

    /// <summary>
    /// The purpose of the <see cref="OrmDiagramXmlReader"/> is to deserialize a <see cref="OrmDiagram"/>
    /// from an .orm XML file
    /// </summary>
    public class OrmDiagramXmlReader : ModelThingXmlReader
    {
        /// <summary>
        /// Reads the properties of the provided <see cref="OrmDiagram"/> from the <see cref="XmlReader"/>
        /// </summary>
        /// <param name="ormDiagram">
        /// The subject <see cref="OrmDiagram"/> that is to be deserialized
        /// </param>
        /// <param name="reader">
        /// The <see cref="XmlReader"/> that contains the .orm XML
        /// </param>
        /// <param name="modelThings">
        /// a list of <see cref="ModelThing"/>s to which the deserialized items are added
        /// </param>
        public void ReadXml(OrmDiagram ormDiagram, XmlReader reader, List<ModelThing> modelThings)
        {
            base.ReadXml(ormDiagram, reader, modelThings);

            ormDiagram.Id = reader.GetAttribute("id");
            ormDiagram.Name = reader.GetAttribute("Name");
            ormDiagram.BaseFontName = reader.GetAttribute("BaseFontName");

            var baseFontSize = reader.GetAttribute("BaseFontSize");
            if (!string.IsNullOrEmpty(baseFontSize))
            {
                ormDiagram.BaseFontSize = XmlConvert.ToDouble(baseFontSize);
            }

            var isCompleteView = reader.GetAttribute("IsCompleteView");
            if (!string.IsNullOrEmpty(isCompleteView))
            {
                ormDiagram.IsCompleteView = XmlConvert.ToBoolean(isCompleteView);
            }

            while (reader.Read())
            {
                if (reader.MoveToContent() == XmlNodeType.Element)
                {
                    var localName = reader.LocalName;

                    switch (localName)
                    {
                        case "Shapes":
                            using (var objectsSubtree = reader.ReadSubtree())
                            {
                                objectsSubtree.MoveToContent();
                                this.ReadShapes(ormDiagram, objectsSubtree, modelThings);
                            }
                            break;
                        case "Subject":
                            ormDiagram.Subject = reader.GetAttribute("ref");
                            break;
                        default:
                            throw new System.NotSupportedException($"{localName} not yet supported");
                    }
                }
            }
        }

        /// <summary>
        /// Reads <see cref="OrmBaseShape"/>s from the .orm file
        /// </summary>
        /// <param name="ormDiagram">
        /// The subject <see cref="OrmDiagram"/> that is to be deserialized
        /// </param>
        /// <param name="reader">
        /// an instance of <see cref="XmlReader"/> used to read the .orm file
        /// </param>
        /// <param name="modelThings">
        /// a list of <see cref="ModelThing"/>s to which the deserialized items are added
        /// </param>
        private void ReadShapes(OrmDiagram ormDiagram, XmlReader reader, List<ModelThing> modelThings)
        {
            while (reader.Read())
            {
                if (reader.MoveToContent() == XmlNodeType.Element)
                {
                    var localName = reader.LocalName;

                    switch (localName)
                    {
                        case "ObjectTypeShape":
                            using (var objectTypeShapeSubtree = reader.ReadSubtree())
                            {
                                objectTypeShapeSubtree.MoveToContent();
                                var objectTypeShape = new ObjectTypeShape();
                                var objectTypeShapeXmlReader = new ObjectTypeShapeXmlReader();
                                objectTypeShapeXmlReader.ReadXml(objectTypeShape, objectTypeShapeSubtree, modelThings);
                                objectTypeShape.Container = ormDiagram.Id;
                                ormDiagram.ObjectTypeShapes.Add(objectTypeShape.Id);
                            }
                            break;
                        case "FactTypeShape":

                            using (var factTypeShapeSubtree = reader.ReadSubtree())
                            {
                                factTypeShapeSubtree.MoveToContent();
                                var factTypeShape = new FactTypeShape();
                                var factTypeShapeXmlReader = new FactTypeShapeXmlReader();
                                factTypeShapeXmlReader.ReadXml(factTypeShape, factTypeShapeSubtree, modelThings);
                                factTypeShape.Container = ormDiagram.Id;
                                ormDiagram.FactTypeShapes.Add(factTypeShape.Id);
                            }
                            break;

                        case "ExternalConstraintShape":
                            using (var externalConstraintShapeSubtree = reader.ReadSubtree())
                            {
                                externalConstraintShapeSubtree.MoveToContent();
                                var externalConstraintShape = new ExternalConstraintShape();
                                var externalConstraintShapeXmlReader = new ExternalConstraintShapeXmlReader();
                                externalConstraintShapeXmlReader.ReadXml(externalConstraintShape, externalConstraintShapeSubtree, modelThings);
                                externalConstraintShape.Container = ormDiagram.Id;
                                ormDiagram.ExternalConstraintShapes.Add(externalConstraintShape.Id);
                            }
                            break;
                        case "FrequencyConstraintShape":
                            using (var frequencyConstraintShapeSubtree = reader.ReadSubtree())
                            {
                                frequencyConstraintShapeSubtree.MoveToContent();
                                var frequencyConstraintShape = new FrequencyConstraintShape();
                                var frequencyConstraintShapeXmlReader = new FrequencyConstraintShapeXmlReader();
                                frequencyConstraintShapeXmlReader.ReadXml(frequencyConstraintShape, frequencyConstraintShapeSubtree, modelThings);
                                frequencyConstraintShape.Container = ormDiagram.Id;
                                ormDiagram.FrequencyConstraintShapes.Add(frequencyConstraintShape.Id);
                            }
                            break;
                        case "RingConstraintShape":
                            using (var ringConstraintShapeSubtree = reader.ReadSubtree())
                            {
                                ringConstraintShapeSubtree.MoveToContent();
                                var ringConstraintShape = new RingConstraintShape();
                                var ringConstraintShapeXmlReader = new RingConstraintShapeXmlReader();
                                ringConstraintShapeXmlReader.ReadXml(ringConstraintShape, ringConstraintShapeSubtree, modelThings);
                                ringConstraintShape.Container = ormDiagram.Id;
                                ormDiagram.RingConstraintShapes.Add(ringConstraintShape.Id);
                            }
                            break;
                        case "ValueComparisonConstraintShape":
                            using (var valueComparisonConstraintShapeSubtree = reader.ReadSubtree())
                            {
                                valueComparisonConstraintShapeSubtree.MoveToContent();
                                var valueComparisonConstraintShape = new ValueComparisonConstraintShape();
                                var valueComparisonConstraintShapeXmlReader = new ValueComparisonConstraintShapeXmlReader();
                                valueComparisonConstraintShapeXmlReader.ReadXml(valueComparisonConstraintShape, valueComparisonConstraintShapeSubtree, modelThings);
                                valueComparisonConstraintShape.Container = ormDiagram.Id;
                                ormDiagram.ValueComparisonConstraintShapes.Add(valueComparisonConstraintShape.Id);
                            }
                            break;
                        case "ModelNoteShape":
                            using (var modelNoteShapeSubtree = reader.ReadSubtree())
                            {
                                modelNoteShapeSubtree.MoveToContent();
                                var modelNoteShape = new ModelNoteShape();
                                var modelNoteShapeXmlReader = new ModelNoteShapeXmlReader();
                                modelNoteShapeXmlReader.ReadXml(modelNoteShape, modelNoteShapeSubtree, modelThings);
                                modelNoteShape.Container = ormDiagram.Id;
                                ormDiagram.ModelNoteShapes.Add(modelNoteShape.Id);
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
