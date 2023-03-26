// -------------------------------------------------------------------------------------------------
// <copyright file="ElementOrganizationsXmlReader.cs" company="RHEA System S.A.">
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
    /// The purpose of the <see cref="ElementOrganizationsXmlReader"/> is to deserialize a <see cref="ElementOrganizations"/>
    /// from an .orm XML file
    /// </summary>
    public class ElementOrganizationsXmlReader : ModelThingXmlReader
    {
        /// <summary>
        /// Reads the properties of the provided <see cref="ElementOrganizations"/> from the <see cref="XmlReader"/>
        /// </summary>
        /// <param name="elementOrganizations">
        /// The subject <see cref="ElementOrganizations"/> that is to be deserialized
        /// </param>
        /// <param name="reader">
        /// The <see cref="XmlReader"/> that contains the .orm XML
        /// </param>
        /// <param name="modelThings">
        /// a list of <see cref="ModelThing"/>s to which the deserialized items are added
        /// </param>
        public void ReadXml(ElementOrganizations elementOrganizations, XmlReader reader, List<ModelThing> modelThings)
        {
            base.ReadXml(elementOrganizations, reader, modelThings);

            elementOrganizations.Id = reader.GetAttribute("id");

            while (reader.Read())
            {
                if (reader.MoveToContent() == XmlNodeType.Element)
                {
                    var localName = reader.LocalName;

                    switch (localName)
                    {
                        case "ORMModel":
                            elementOrganizations.Model = reader.GetAttribute("ref");
                            break;
                        case "Hierarchies":
                            using (var hierarchiesSubtree = reader.ReadSubtree())
                            {
                                hierarchiesSubtree.MoveToContent();
                                this.ReadHierarchies(elementOrganizations, hierarchiesSubtree, modelThings);
                            }
                            break;
                        case "HierarchyColorSchemes":
                            using (var hierarchyColorSchemesSubtree = reader.ReadSubtree())
                            {
                                hierarchyColorSchemesSubtree.MoveToContent();
                                this.ReadHierarchyColorSchemes(elementOrganizations, hierarchyColorSchemesSubtree, modelThings);
                            }
                            break;
                        case "ActiveOrganization":
                            elementOrganizations.ActiveOrganization = reader.GetAttribute("ref");
                            break;
                        default:
                            throw new System.NotSupportedException($"{localName} not yet supported");
                    }
                }
            }
        }

        /// <summary>
        /// Reads <see cref="Hierarchy"/>s from the .orm file
        /// </summary>
        /// <param name="elementOrganizations">
        /// The subject <see cref="ElementOrganizations"/> that is to be deserialized
        /// </param>
        /// <param name="reader">
        /// an instance of <see cref="XmlReader"/> used to read the .orm file
        /// </param>
        /// <param name="modelThings">
        /// a list of <see cref="ModelThing"/>s to which the deserialized items are added
        /// </param>
        private void ReadHierarchies(ElementOrganizations elementOrganizations, XmlReader reader, List<ModelThing> modelThings)
        {
            while (reader.Read())
            {
                if (reader.MoveToContent() == XmlNodeType.Element)
                {
                    var localName = reader.LocalName;

                    switch (localName)
                    {
                        case "Hierarchy":
                            using (var hierarchySubtree = reader.ReadSubtree())
                            {
                                hierarchySubtree.MoveToContent();
                                var hierarchy= new Hierarchy();
                                var hierarchyXmlReader = new HierarchyXmlReader();
                                hierarchyXmlReader.ReadXml(hierarchy, hierarchySubtree, modelThings);
                                hierarchy.Container = elementOrganizations.Id;
                                elementOrganizations.Hierarchies.Add(hierarchy.Id);
                            }
                            break;
                        default:
                            throw new System.NotSupportedException($"{localName} not yet supported");
                    }
                }
            }
        }

        /// <summary>
        /// Reads <see cref="HierarchyColorScheme"/>s from the .orm file
        /// </summary>
        /// <param name="elementOrganizations">
        /// The subject <see cref="ElementOrganizations"/> that is to be deserialized
        /// </param>
        /// <param name="reader">
        /// an instance of <see cref="XmlReader"/> used to read the .orm file
        /// </param>
        /// <param name="modelThings">
        /// a list of <see cref="ModelThing"/>s to which the deserialized items are added
        /// </param>
        private void ReadHierarchyColorSchemes(ElementOrganizations elementOrganizations, XmlReader reader, List<ModelThing> modelThings)
        {
            while (reader.Read())
            {
                if (reader.MoveToContent() == XmlNodeType.Element)
                {
                    var localName = reader.LocalName;

                    switch (localName)
                    {
                        case "HierarchyColorScheme":
                            using (var hierarchyColorSchemeSubtree = reader.ReadSubtree())
                            {
                                hierarchyColorSchemeSubtree.MoveToContent();
                                var hierarchyColorScheme = new HierarchyColorScheme();
                                var hierarchyColorSchemeXmlReader = new HierarchyColorSchemeXmlReader();
                                hierarchyColorSchemeXmlReader.ReadXml(hierarchyColorScheme, hierarchyColorSchemeSubtree, modelThings);
                                hierarchyColorScheme.Container = elementOrganizations.Id;
                                elementOrganizations.HierarchyColorSchemes.Add(hierarchyColorScheme.Id);
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
