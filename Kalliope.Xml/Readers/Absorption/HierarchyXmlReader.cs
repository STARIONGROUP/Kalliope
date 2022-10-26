// -------------------------------------------------------------------------------------------------
// <copyright file="HierarchyXmlReader.cs" company="RHEA System S.A.">
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
    /// The purpose of the <see cref="HierarchyXmlReader"/> is to deserialize a <see cref="Hierarchy"/>
    /// from an .orm XML file
    /// </summary>
    public class HierarchyXmlReader : OrmNamedElementXmlReader
    {
        /// <summary>
        /// Reads the properties of the provided <see cref="Hierarchy"/> from the <see cref="XmlReader"/>
        /// </summary>
        /// <param name="hierarchy">
        /// The subject <see cref="Hierarchy"/> that is to be deserialized
        /// </param>
        /// <param name="reader">
        /// The <see cref="XmlReader"/> that contains the .orm XML
        /// </param>
        /// <param name="modelThings">
        /// a list of <see cref="ModelThing"/>s to which the deserialized items are added
        /// </param>
        public void ReadXml(Hierarchy hierarchy, XmlReader reader, List<ModelThing> modelThings)
        {
            base.ReadXml(hierarchy, reader, modelThings);

            hierarchy.DataValueName = reader.GetAttribute("DataValueName");

            hierarchy.ReferenceTypeSuffix = reader.GetAttribute("ReferenceTypeSuffix");

            hierarchy.RootElementName = reader.GetAttribute("RootElementName");

            hierarchy.SchemaFileTag = reader.GetAttribute("SchemaFileTag");

            hierarchy.XmlNamespace = reader.GetAttribute("XmlNamespace");

            hierarchy.XmlPrefix = reader.GetAttribute("XmlPrefix");

            while (reader.Read())
            {
                if (reader.MoveToContent() == XmlNodeType.Element)
                {
                    var localName = reader.LocalName;

                    switch (localName)
                    {
                        case "ObjectTypes":
                            using (var objectTypesSubtree = reader.ReadSubtree())
                            {
                                objectTypesSubtree.MoveToContent();
                                this.ReadAbsorbedObjectTypes(hierarchy, objectTypesSubtree, modelThings);
                            }
                            break;
                        case "FactTypes":
                            using (var factTypesSubtree = reader.ReadSubtree())
                            {
                                factTypesSubtree.MoveToContent();
                                this.ReadAbsorbedFactTypes(hierarchy, factTypesSubtree, modelThings);
                            }
                            break;
                        default:
                            throw new System.NotSupportedException($"{localName} not yet supported");
                    }
                }
            }
        }

        /// <summary>
        /// Reads <see cref="AbsorbedObjectType"/>s from the .orm file
        /// </summary>
        /// <param name="hierarchy">
        /// The subject <see cref="Hierarchy"/> that is to be deserialized
        /// </param>
        /// <param name="reader">
        /// an instance of <see cref="XmlReader"/> used to read the .orm file
        /// </param>
        /// <param name="modelThings">
        /// a list of <see cref="ModelThing"/>s to which the deserialized items are added
        /// </param>
        private void ReadAbsorbedObjectTypes(Hierarchy hierarchy, XmlReader reader, List<ModelThing> modelThings)
        {
            while (reader.Read())
            {
                if (reader.MoveToContent() == XmlNodeType.Element)
                {
                    var localName = reader.LocalName;

                    switch (localName)
                    {
                        case "ObjectType":
                            using (var objectTypeSubtree = reader.ReadSubtree())
                            {
                                objectTypeSubtree.MoveToContent();
                                var absorbedObjectType = new AbsorbedObjectType();
                                var absorbedObjectTypeXmlReader = new AbsorbedObjectTypeXmlReader();
                                absorbedObjectTypeXmlReader.ReadXml(absorbedObjectType, objectTypeSubtree, modelThings);
                                absorbedObjectType.Container = hierarchy.Id;
                                hierarchy.AbsorbedObjectTypes.Add(absorbedObjectType.Id);
                            }
                            break;
                        default:
                            throw new System.NotSupportedException($"{localName} not yet supported");
                    }
                }
            }
        }

        /// <summary>
        /// Reads <see cref="AbsorbedFactType"/>s from the .orm file
        /// </summary>
        /// <param name="hierarchy">
        /// The subject <see cref="Hierarchy"/> that is to be deserialized
        /// </param>
        /// <param name="reader">
        /// an instance of <see cref="XmlReader"/> used to read the .orm file
        /// </param>
        /// <param name="modelThings">
        /// a list of <see cref="ModelThing"/>s to which the deserialized items are added
        /// </param>
        private void ReadAbsorbedFactTypes(Hierarchy hierarchy, XmlReader reader, List<ModelThing> modelThings)
        {
            while (reader.Read())
            {
                if (reader.MoveToContent() == XmlNodeType.Element)
                {
                    var localName = reader.LocalName;

                    switch (localName)
                    {
                        case "FactType":
                            using (var factTypeSubtree = reader.ReadSubtree())
                            {
                                factTypeSubtree.MoveToContent();
                                var absorbedFactType = new AbsorbedFactType();
                                var absorbedFactTypeXmlReader = new AbsorbedFactTypeXmlReader();
                                absorbedFactTypeXmlReader.ReadXml(absorbedFactType, factTypeSubtree, modelThings);
                                absorbedFactType.Container = hierarchy.Id;
                                hierarchy.AbsorbedFactTypes.Add(absorbedFactType.Id);
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
