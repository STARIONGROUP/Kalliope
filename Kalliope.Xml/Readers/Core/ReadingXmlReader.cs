// -------------------------------------------------------------------------------------------------
// <copyright file="ReadingXmlReader.cs" company="RHEA System S.A.">
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

    using Kalliope.DTO;

    /// <summary>
    /// The purpose of the <see cref="ReadingXmlReader"/> is to deserialize a <see cref="Reading"/>
    /// from an .orm XML file
    /// </summary>
    public class ReadingXmlReader : ORMModelElementXmlReader
    {
        /// <summary>
        /// Reads the properties of the provided <see cref="Reading"/> from the <see cref="XmlReader"/>
        /// </summary>
        /// <param name="reading">
        /// The subject <see cref="Reading"/> that is to be deserialized
        /// </param>
        /// <param name="reader">
        /// The <see cref="XmlReader"/> that contains the .orm XML
        /// </param>
        /// <param name="modelThings">
        /// a list of <see cref="ModelThing"/>s to which the deserialized items are added
        /// </param>
        public void ReadXml(Reading reading, XmlReader reader, List<ModelThing> modelThings)
        {
            base.ReadXml(reading, reader, modelThings);

            while (reader.Read())
            {
                if (reader.MoveToContent() == XmlNodeType.Element)
                {
                    var localName = reader.LocalName;

                    switch (localName)
                    {
                        case "Data":
                            reading.Data = reader.ReadElementContentAsString();
                            break;
                        case "ExpandedData":
                            using (var expandedDataSubtree = reader.ReadSubtree())
                            {
                                expandedDataSubtree.MoveToContent();
                                this.ReadExpandedData(reading, expandedDataSubtree, modelThings);
                            }
                            break;
                        default:
                            throw new NotSupportedException($"{localName} not yet supported");
                    }
                }
            }
        }

        /// <summary>
        /// Reads <see cref="RoleText"/>s from the .orm file
        /// </summary>
        /// <param name="reading">
        /// The subject <see cref="Reading"/> that is to be deserialized
        /// </param>
        /// <param name="reader">
        /// an instance of <see cref="XmlReader"/> used to read the .orm file
        /// </param>
        /// <param name="modelThings">
        /// a list of <see cref="ModelThing"/>s to which the deserialized items are added
        /// </param>
        private void ReadExpandedData(Reading reading, XmlReader reader, List<ModelThing> modelThings)
        {
            while (reader.Read())
            {
                if (reader.MoveToContent() == XmlNodeType.Element)
                {
                    var localName = reader.LocalName;

                    switch (localName)
                    {
                        case "RoleText":
                            var roleText = new RoleText();
                            var roleTextXmlReader = new RoleTextXmlReader();
                            roleTextXmlReader.ReadXml(roleText, reader, modelThings);
                            roleText.Container = reading.Id;
                            reading.ExpandedData.Add(roleText.RoleIndex.ToString());
                            break;
                        default:
                            throw new NotSupportedException($"{localName} not yet supported");
                    }
                }
            }
        }
    }
}
