// -------------------------------------------------------------------------------------------------
// <copyright file="EntityTypeXmlReader.cs" company="Starion Group S.A.">
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
    using System.Xml;

    using Kalliope.DTO;

    /// <summary>
    /// The purpose of the <see cref="EntityTypeXmlReader"/> is to deserialize a <see cref="EntityType"/>
    /// from an .orm XML file
    /// </summary>
    public class EntityTypeXmlReader : ObjectTypeXmlReader
    {
        /// <summary>
        /// Reads the preferred identifier
        /// </summary>
        /// <param name="reader">
        /// an instance of <see cref="XmlReader"/> used to read the .orm file
        /// </param>
        /// <param name="objectType">
        /// The <see cref="EntityType"/> for which the PreferredIdentifier is to be read
        /// </param>
        public override void ReadPreferredIdentifier(XmlReader reader, ObjectType objectType)
        {
            using (var preferredIdentifierSubtree = reader.ReadSubtree())
            {
                if (preferredIdentifierSubtree.MoveToContent() == XmlNodeType.Element)
                {
                    if (preferredIdentifierSubtree.LocalName == "PreferredIdentifier")
                    {
                        var reference = preferredIdentifierSubtree.GetAttribute("ref");
                        if (!string.IsNullOrEmpty(reference))
                        {
                            ((EntityType)objectType).PreferredIdentifier = reference;
                        }
                    }
                }
            }
        }
    }
}
