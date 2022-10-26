// -------------------------------------------------------------------------------------------------
// <copyright file="OrmRootXmlReader.cs" company="RHEA System S.A.">
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
    /// The purpose of the <see cref="OrmRootXmlReader"/> is to read the contents of the
    /// <see cref="OrmRoot"/> XML element
    /// </summary>
    public class OrmRootXmlReader
    {
        /// <summary>
        /// Generates a <see cref="OrmRoot"/> object from its XML representation.
        /// </summary>
        /// <param name="ormRoot">
        /// The subject <see cref="OrmRoot"/> that is to be deserialized
        /// </param>
        /// <param name="reader">
        /// an instance of <see cref="XmlReader"/>
        /// </param>
        /// <param name="modelThings">
        /// The <see cref="List{ModelThing}"/> to which the read <see cref="ModelThing"/> are added
        /// </param>
        public void ReadXml(OrmRoot ormRoot, XmlReader reader, List<ModelThing> modelThings)
        {
            if (modelThings == null)
            {
                throw new ArgumentNullException(nameof(modelThings), $"The {nameof(modelThings)} may not be null");
            }

            while (reader.Read())
            {
                if (reader.MoveToContent() == XmlNodeType.Element)
                {
                    var localName = reader.LocalName;

                    switch (localName)
                    {
                        case "ORMModel":
                            using (var ormModelSubtree = reader.ReadSubtree())
                            {
                                ormModelSubtree.MoveToContent();
                                var ormModel = new OrmModel();
                                var ormModelReader = new OrmModelXmlReader();
                                ormModelReader.ReadXml(ormModel, ormModelSubtree, modelThings);
                                ormRoot.Model = ormModel.Id;
                            }
                            break;
                        case "NameGenerator":
                            using (var nameGeneratorSubtree = reader.ReadSubtree())
                            {
                                nameGeneratorSubtree.MoveToContent();
                                var nameGenerator = new NameGenerator();
                                var nameGeneratorXmlReader = new NameGeneratorXmlReader();
                                nameGeneratorXmlReader.ReadXml(nameGenerator, nameGeneratorSubtree, modelThings);
                                ormRoot.NameGenerator = nameGenerator.Id;
                            }
                            break;
                        case "GenerationState":
                            using (var generationStateSubTree = reader.ReadSubtree())
                            {
                                generationStateSubTree.MoveToContent();
                                var generationState = new GenerationState();
                                var generationStateXmlReader = new GenerationStateXmlReader();
                                generationStateXmlReader.ReadXml(generationState, generationStateSubTree, modelThings);
                                ormRoot.GenerationState = generationState.Id;
                            }
                            break;
                        case "ORMDiagram":
                            using (var diagramSubtree = reader.ReadSubtree())
                            {
                                diagramSubtree.MoveToContent();
                                var ormDiagram = new OrmDiagram();
                                var ormDiagramXmlReader = new OrmDiagramXmlReader();
                                ormDiagramXmlReader.ReadXml(ormDiagram, diagramSubtree, modelThings);
                                ormRoot.Diagrams.Add(ormDiagram.Id);
                            }
                            break;
                        case "CustomPropertyGroup":
                            using (var customPropertyGroupSubtree = reader.ReadSubtree())
                            {
                                customPropertyGroupSubtree.MoveToContent();
                                var customPropertyGroup = new CustomPropertyGroup();
                                var customPropertyGroupXmlReader = new CustomPropertyGroupXmlReader();
                                customPropertyGroupXmlReader.ReadXml(customPropertyGroup, customPropertyGroupSubtree, modelThings);
                                ormRoot.CustomPropertyGroups.Add(customPropertyGroup.Id);
                            }
                            break;
                        case "Grouping":
                            using (var groupingSubtree = reader.ReadSubtree())
                            {
                                groupingSubtree.MoveToContent();
                                // TODO: parse grouping subtree
                                //var customPropertyGroup = new CustomPropertyGroup();
                                //var customPropertyGroupXmlReader = new CustomPropertyGroupXmlReader();
                                //customPropertyGroupXmlReader.ReadXml(customPropertyGroup, customPropertyGroupSubtree, modelThings);
                                //ormRoot.CustomPropertyGroups.Add(customPropertyGroup.Id);
                            }
                            break;
                        case "ElementOrganizations":
                            using (var elementOrganizationsSubtree = reader.ReadSubtree())
                            {
                                elementOrganizationsSubtree.MoveToContent();
                                var elementOrganizations = new ElementOrganizations();
                                var elementOrganizationsXmlReader = new ElementOrganizationsXmlReader();
                                elementOrganizationsXmlReader.ReadXml(elementOrganizations, elementOrganizationsSubtree, modelThings);
                                ormRoot.CustomPropertyGroups.Add(elementOrganizations.Id);
                            }
                            break;
                    }
                }
            }
        }
    }
}
