// -------------------------------------------------------------------------------------------------
// <copyright file="CustomPropertyGroupXmlReader.cs" company="Starion Group S.A.">
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
    using System.Collections.Generic;
    using System.Xml;

    using Kalliope.DTO;

    /// <summary>
    /// The purpose of the <see cref="CustomPropertyGroupXmlReader"/> is to deserialize a <see cref="CustomPropertyGroup"/>
    /// from an .orm XML file
    /// </summary>
    public class CustomPropertyGroupXmlReader : ModelThingXmlReader
    {
        /// <summary>
        /// Reads the properties of the provided <see cref="CustomPropertyGroup"/> from the <see cref="XmlReader"/>
        /// </summary>
        /// <param name="customPropertyGroup">
        /// The subject <see cref="CustomPropertyGroup"/> that is to be deserialized
        /// </param>
        /// <param name="reader">
        /// The <see cref="XmlReader"/> that contains the .orm XML
        /// </param>
        /// <param name="modelThings">
        /// a list of <see cref="ModelThing"/>s to which the deserialized items are added
        /// </param>
        public void ReadXml(CustomPropertyGroup customPropertyGroup, XmlReader reader, List<ModelThing> modelThings)
        {
            base.ReadXml(customPropertyGroup, reader, modelThings);
            
            customPropertyGroup.Id = reader.GetAttribute("id");
            customPropertyGroup.Name = reader.GetAttribute("name");
            customPropertyGroup.Description = reader.GetAttribute("description");

            var isDefault = reader.GetAttribute("isDefault");
            if (!string.IsNullOrEmpty(isDefault))
            {
                customPropertyGroup.IsDefault = XmlConvert.ToBoolean(isDefault);
            }
            
            while (reader.Read())
            {
                if (reader.MoveToContent() == XmlNodeType.Element)
                {
                    var localName = reader.LocalName;

                    switch (localName)
                    {
                        case "PropertyDefinitions":
                            using (var customPropertyDefinitionsSubtree = reader.ReadSubtree())
                            {
                                customPropertyDefinitionsSubtree.MoveToContent();
                                this.ReadCustomPropertyDefinitions(customPropertyGroup, customPropertyDefinitionsSubtree, modelThings);
                            }
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
        /// <param name="customPropertyGroup">
        /// The subject <see cref="CustomPropertyGroup"/> that is to be deserialized
        /// </param>
        /// <param name="reader">
        /// an instance of <see cref="XmlReader"/> used to read the .orm file
        /// </param>
        /// <param name="modelThings">
        /// a list of <see cref="ModelThing"/>s to which the deserialized items are added
        /// </param>
        private void ReadCustomPropertyDefinitions(CustomPropertyGroup customPropertyGroup, XmlReader reader, List<ModelThing> modelThings)
        {
            while (reader.Read())
            {
                if (reader.MoveToContent() == XmlNodeType.Element)
                {
                    var localName = reader.LocalName;

                    switch (localName)
                    {
                        case "Definition":
                            using (var customPropertyDefinitionSubtree = reader.ReadSubtree())
                            {
                                customPropertyDefinitionSubtree.MoveToContent();

                                var customPropertyDefinition = new CustomPropertyDefinition();
                                var customPropertyDefinitionXmlReader = new CustomPropertyDefinitionXmlReader();
                                customPropertyDefinitionXmlReader.ReadXml(customPropertyDefinition, customPropertyDefinitionSubtree, modelThings);
                                customPropertyDefinition.Container = customPropertyGroup.Id;
                                customPropertyGroup.PropertyDefinitions.Add(customPropertyDefinition.Id);
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
