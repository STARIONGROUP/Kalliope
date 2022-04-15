// -------------------------------------------------------------------------------------------------
// <copyright file="ObjectifiedTypeXmlReader.cs" company="RHEA System S.A.">
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
    /// The purpose of the <see cref="ObjectifiedTypeXmlReader"/> is to deserialize a <see cref="ObjectifiedType"/>
    /// from an .orm XML file
    /// </summary>
    public class ObjectifiedTypeXmlReader : ObjectTypeXmlReader
    {
        /// <summary>
        /// Reads the preferred identifier
        /// </summary>
        /// <param name="reader">
        /// an instance of <see cref="XmlReader"/> used to read the .orm file
        /// </param>
        /// <param name="objectType">
        /// The <see cref="ObjectifiedType"/> for which the PreferredIdentifier is to be read
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
                            ((ObjectifiedType)objectType).PreferredIdentifier = reference;
                        }
                    }
                }
            }
        }

        /// <summary>
        /// reads the <see cref="Objectification"/>
        /// </summary>
        /// <param name="objectType">
        /// The <see cref="ObjectType"/> that references the played roles
        /// </param>
        /// <param name="reader">
        /// an instance of <see cref="XmlReader"/> used to read the .orm file
        /// </param>
        /// <param name="modelThings">
        /// a list of <see cref="ModelThing"/>s to which the deserialized items are added
        /// </param>
        public override void ReadNestedPredicate(ObjectType objectType, XmlReader reader, List<ModelThing> modelThings)
        {
            var objectification = new Objectification();
            var objectificationXmlReader = new ObjectificationXmlReader();
            objectificationXmlReader.ReadXml(objectification, reader, modelThings);
            objectification.Container = objectType.Id;
            objectification.NestingType = objectType.Id;
            ((ObjectifiedType)objectType).NestedPredicate = objectification.Id;
        }
    }
}
