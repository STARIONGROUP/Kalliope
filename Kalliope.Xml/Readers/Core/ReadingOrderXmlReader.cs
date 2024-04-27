// -------------------------------------------------------------------------------------------------
// <copyright file="ReadingOrderXmlReader.cs" company="Starion Group S.A.">
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

namespace Kalliope.Xml.Readers
{
    using System;
    using System.Collections.Generic;
    using System.Xml;

    using Kalliope.DTO;

    /// <summary>
    /// The purpose of the <see cref="ReadingOrderXmlReader"/> is to deserialize a <see cref="ReadingOrder"/>
    /// from an .orm XML file
    /// </summary>
    public class ReadingOrderXmlReader : OrmModelElementXmlReader
    {
        /// <summary>
        /// Reads the properties of the provided <see cref="ReadingOrder"/> from the <see cref="XmlReader"/>
        /// </summary>
        /// <param name="readingOrder">
        /// The subject <see cref="ReadingOrder"/> that is to be deserialized
        /// </param>
        /// <param name="reader">
        /// The <see cref="XmlReader"/> that contains the .orm XML
        /// </param>
        /// <param name="modelThings">
        /// a list of <see cref="ModelThing"/>s to which the deserialized items are added
        /// </param>
        public void ReadXml(ReadingOrder readingOrder, XmlReader reader, List<ModelThing> modelThings)
        {
            base.ReadXml(readingOrder, reader, modelThings);

            while (reader.Read())
            {
                if (reader.MoveToContent() == XmlNodeType.Element)
                {
                    var localName = reader.LocalName;

                    switch (localName)
                    {
                        case "Readings":
                            using (var readingsSubtree = reader.ReadSubtree())
                            {
                                readingsSubtree.MoveToContent();
                                this.ReadReadings(readingOrder, readingsSubtree, modelThings);
                            }
                            break;
                        case "RoleSequence":
                            using (var roleSequenceSubtree = reader.ReadSubtree())
                            {
                                roleSequenceSubtree.MoveToContent();
                                this.ReadRoleSequences(readingOrder, roleSequenceSubtree);
                            }
                            break;
                        default:
                            throw new NotSupportedException($"{localName} not yet supported");
                    }
                }
            }
        }

        /// <summary>
        /// Reads <see cref="Reading"/>s from the .orm file
        /// </summary>
        /// <param name="readingOrder">
        /// The subject <see cref="ReadingOrder"/> that is to be deserialized
        /// </param>
        /// <param name="reader">
        /// an instance of <see cref="XmlReader"/> used to read the .orm file
        /// </param>
        /// <param name="modelThings">
        /// a list of <see cref="ModelThing"/>s to which the deserialized items are added
        /// </param>
        private void ReadReadings(ReadingOrder readingOrder, XmlReader reader, List<ModelThing> modelThings)
        {
            while (reader.Read())
            {
                if (reader.MoveToContent() == XmlNodeType.Element)
                {
                    var localName = reader.LocalName;

                    switch (localName)
                    {
                        case "Reading":
                            using (var readingSubtree = reader.ReadSubtree())
                            {
                                readingSubtree.MoveToContent();
                                var reading = new Reading();
                                var readingXmlReader = new ReadingXmlReader();
                                readingXmlReader.ReadXml(reading, readingSubtree, modelThings);
                                reading.Container = readingOrder.Id;
                                readingOrder.Readings.Add(reading.Id);
                            }
                            break;
                        default:
                            throw new NotSupportedException($"{localName} not yet supported");
                    }

                }
            }
        }

        /// <summary>
        /// Reads <see cref="Role"/> sequences from the .orm file
        /// </summary>
        /// <param name="reader">
        /// an instance of <see cref="XmlReader"/> used to read the .orm file
        /// </param>
        private void ReadRoleSequences(ReadingOrder readingOrder, XmlReader reader)
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
                                readingOrder.Roles.Add(roleReference);
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
