// -------------------------------------------------------------------------------------------------
// <copyright file="ValueConstraintXmlReader.cs" company="RHEA System S.A.">
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
// -------------------------------------------------------------------------------------------------

namespace Kalliope.Xml.Readers
{
    using System;
    using System.Collections.Generic;
    using System.Xml;

    using Kalliope.DTO;

    /// <summary>
    /// The purpose of the <see cref="ValueConstraintXmlReader"/> is to deserialize a <see cref="ValueConstraint"/>
    /// from an .orm XML file
    /// </summary>
    public abstract class ValueConstraintXmlReader : OrmNamedElementXmlReader
    {
        /// <summary>
        /// Reads the properties of the provided <see cref="ValueConstraint"/> from the <see cref="XmlReader"/>
        /// </summary>
        /// <param name="valueConstraint">
        /// The subject <see cref="ValueConstraint"/> that is to be deserialized
        /// </param>
        /// <param name="reader">
        /// The <see cref="XmlReader"/> that contains the .orm XML
        /// </param>
        /// <param name="modelThings">
        /// a list of <see cref="ModelThing"/>s to which the deserialized items are added
        /// </param>
        public void ReadXml(ValueConstraint valueConstraint, XmlReader reader, List<ModelThing> modelThings)
        {
            base.ReadXml(valueConstraint, reader, modelThings);

            while (reader.Read())
            {
                if (reader.MoveToContent() == XmlNodeType.Element)
                {
                    var localName = reader.LocalName;

                    switch (localName)
                    {
                        case "Definitions":
                            using (var definitionSubtree = reader.ReadSubtree())
                            {
                                definitionSubtree.MoveToContent();
                                this.ReadDefinitions(valueConstraint, definitionSubtree, modelThings);
                            }
                            break;

                        case "ValueRanges":
                            using (var valueRangesSubtree = reader.ReadSubtree())
                            {
                                valueRangesSubtree.MoveToContent();
                                this.ReadValueRanges(valueConstraint, valueRangesSubtree, modelThings);
                            }
                            break;
                        default:
                            throw new NotSupportedException($"{localName} not yet supported");
                    }
                }
            }
        }

        /// <summary>
        /// reads the contained <see cref="Definition"/>s
        /// </summary>
        /// <param name="valueConstraint">
        /// The container <see cref="ValueConstraint"/> of the <see cref="Definition"/>
        /// </param>
        /// <param name="reader">
        /// an instance of <see cref="XmlReader"/> used to read the .orm file
        /// </param>
        /// <param name="modelThings">
        /// a list of <see cref="ModelThing"/>s to which the deserialized items are added
        /// </param>
        private void ReadDefinitions(ValueConstraint valueConstraint, XmlReader reader, List<ModelThing> modelThings)
        {
            while (reader.Read())
            {
                if (reader.MoveToContent() == XmlNodeType.Element)
                {
                    var localName = reader.LocalName;

                    switch (localName)
                    {
                        case "Definition":
                            using (var definitionSubtree = reader.ReadSubtree())
                            {
                                definitionSubtree.MoveToContent();
                                var definition = new Definition();
                                var definitionXmlReader = new DefinitionXmlReader();
                                definitionXmlReader.ReadXml(definition, definitionSubtree, modelThings);
                                definition.Container = valueConstraint.Id;
                                valueConstraint.Definition = definition.Id;
                            }
                            break;
                        default:
                            throw new NotSupportedException($"{localName} not yet supported");
                    }
                }
            }
        }

        /// <summary>
        /// Reads the <see cref="ValueRange"/> object from its XML representation.
        /// </summary>
        /// <param name="valueConstraint">
        /// The subject <see cref="ValueConstraint"/> that is to be deserialized
        /// </param>
        /// <param name="reader">
        /// an instance of <see cref="XmlReader"/> used to read the .orm file
        /// </param>
        /// <param name="modelThings">
        /// a list of <see cref="ModelThing"/>s to which the deserialized items are added
        /// </param>
        private void ReadValueRanges(ValueConstraint valueConstraint, XmlReader reader, List<ModelThing> modelThings)
        {
            while (reader.Read())
            {
                if (reader.MoveToContent() == XmlNodeType.Element)
                {
                    var localName = reader.LocalName;

                    switch (localName)
                    {
                        case "ValueRange":
                            using (var valueRangeSubtree = reader.ReadSubtree())
                            {
                                valueRangeSubtree.MoveToContent();
                                var valueRange = new ValueRange();
                                var valueRangeXmlReader = new ValueRangeXmlReader();
                                valueRangeXmlReader.ReadXml(valueRange, valueRangeSubtree, modelThings);
                                valueRange.Container = valueConstraint.Id;
                                valueConstraint.ValueRanges.Add(valueRange.Id);
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
