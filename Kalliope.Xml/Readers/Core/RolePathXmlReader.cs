// -------------------------------------------------------------------------------------------------
// <copyright file="RolePathXmlReader.cs" company="RHEA System S.A.">
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
    using System;
    using System.Collections.Generic;
    using System.Xml;

    using Kalliope.Common;
    using Kalliope.DTO;

    /// <summary>
    /// The purpose of the <see cref="RolePathXmlReader"/> is to deserialize a <see cref="RolePath"/>
    /// from an .orm XML file
    /// </summary>
    public abstract class RolePathXmlReader : OrmModelElementXmlReader
    {
        /// <summary>
        /// Reads the properties of the provided <see cref="RolePath"/> from the <see cref="XmlReader"/>
        /// </summary>
        /// <param name="rolePath">
        /// The subject <see cref="RolePath"/> that is to be deserialized
        /// </param>
        /// <param name="reader">
        /// The <see cref="XmlReader"/> that contains the .orm XML
        /// </param>
        /// <param name="modelThings">
        /// a list of <see cref="ModelThing"/>s to which the deserialized items are added
        /// </param>
        public void ReadXml(RolePath rolePath, XmlReader reader, List<ModelThing> modelThings)
        {
            base.ReadXml(rolePath, reader, modelThings);

            var splitIsNegated = reader.GetAttribute("SplitIsNegated");
            if (splitIsNegated != null)
            {
                rolePath.SplitIsNegated = XmlConvert.ToBoolean(splitIsNegated);
            }

            var logicalCombinationOperatorString = reader.GetAttribute("SplitCombinationOperator");
            if (logicalCombinationOperatorString != null)
            {
                if (Enum.TryParse(logicalCombinationOperatorString, out LogicalCombinationOperator logicalCombinationOperator))
                {
                    rolePath.SplitCombinationOperator = logicalCombinationOperator;
                }
            }

            while (reader.Read())
            {
                if (reader.MoveToContent() == XmlNodeType.Element)
                {
                    var localName = reader.LocalName;

                    switch (localName)
                    {
                        case "RootObjectType":
                            using (var rootObjectTypeSubtree = reader.ReadSubtree())
                            {
                                rootObjectTypeSubtree.MoveToContent();
                                var rootObjectType = new RootObjectType();
                                var rootObjectTypeXmlReader = new RootObjectTypeXmlReader();
                                rootObjectTypeXmlReader.ReadXml(rootObjectType, rootObjectTypeSubtree, modelThings);
                                rootObjectType.Container = rolePath.Id;
                                rolePath.RootObjectType = rootObjectType.Id;
                            }
                            break;
                        case "SubPaths":
                            using (var subPathsSubtree = reader.ReadSubtree())
                            {
                                subPathsSubtree.MoveToContent();
                                this.ReadSubPathsSubtree(rolePath, subPathsSubtree, modelThings);
                            }
                            break;
                        case "PathedRoles":
                            using (var rolesSubtree = reader.ReadSubtree())
                            {
                                rolesSubtree.MoveToContent();
                                this.ReadPathedRoles(rolePath, rolesSubtree, modelThings);
                            }
                            break;

                        case "CalculatedValues":
                            using (var calculatedValuesSubtree = reader.ReadSubtree())
                            {
                                calculatedValuesSubtree.MoveToContent();
                                this.ReadCalculatedValuesSubtree(rolePath, calculatedValuesSubtree, modelThings);
                            }
                            break;
                        
                        case "ObjectUnifiers":
                            using (var objectUnifiersSubtree = reader.ReadSubtree())
                            {
                                objectUnifiersSubtree.MoveToContent();
                                this.ReadObjectUnifiers(rolePath, objectUnifiersSubtree, modelThings);
                            }
                            break;

                        case "Conditions":
                            using (var conditionsSubtree = reader.ReadSubtree())
                            {
                                conditionsSubtree.MoveToContent();
                                this.ReadConditions(rolePath, conditionsSubtree, modelThings);
                            }
                            break;


                        default:
                            throw new NotSupportedException($"{localName} not yet supported");
                    }
                }
            }
        }

        /// <summary>
        /// reads the contained <see cref="PathedRole"/>s
        /// </summary>
        /// <param name="rolePath">
        /// The container <see cref="RolePath"/> of the <see cref="RolePath"/>
        /// </param>
        /// <param name="reader">
        /// an instance of <see cref="XmlReader"/> used to read the .orm file
        /// </param>
        /// <param name="modelThings">
        /// a list of <see cref="ModelThing"/>s to which the deserialized items are added
        /// </param>
        private void ReadPathedRoles(RolePath rolePath, XmlReader reader, List<ModelThing> modelThings)
        {
            while (reader.Read())
            {
                if (reader.MoveToContent() == XmlNodeType.Element)
                {
                    var localName = reader.LocalName;

                    switch (localName)
                    {
                        case "PathedRole":
                            using (var pathedRoleSubtree = reader.ReadSubtree())
                            {
                                pathedRoleSubtree.MoveToContent();
                                var pathedRole = new PathedRole();
                                var pathedRoleXmlReader = new PathedRoleXmlReader();
                                pathedRoleXmlReader.ReadXml(pathedRole, pathedRoleSubtree, modelThings);
                                pathedRole.Container = rolePath.Id;
                                rolePath.PathedRoles.Add(pathedRole.Id);
                            }
                            break;
                        default:
                            throw new NotSupportedException($"{localName} not yet supported");
                    }
                }
            }
        }

        /// <summary>
        /// reads the contained <see cref="CalculatedPathValue"/>s
        /// </summary>
        /// <param name="rolePath">
        /// The container <see cref="RolePath"/> of the <see cref="RolePath"/>
        /// </param>
        /// <param name="reader">
        /// an instance of <see cref="XmlReader"/> used to read the .orm file
        /// </param>
        /// <param name="modelThings">
        /// a list of <see cref="ModelThing"/>s to which the deserialized items are added
        /// </param>
        public virtual void ReadConditions(RolePath rolePath, XmlReader reader, List<ModelThing> modelThings)
        {
            throw new InvalidOperationException("only supported by LeadRolePath");
        }

        /// <summary>
        /// reads the contained <see cref="LeadRolePath"/>s
        /// </summary>
        /// <param name="rolePath">
        /// The container <see cref="LeadRolePath"/> of the <see cref="RolePath"/>
        /// </param>
        /// <param name="reader">
        /// an instance of <see cref="XmlReader"/> used to read the .orm file
        /// </param>
        /// <param name="modelThings">
        /// a list of <see cref="ModelThing"/>s to which the deserialized items are added
        /// </param>
        private void ReadSubPathsSubtree(RolePath rolePath, XmlReader reader, List<ModelThing> modelThings)
        {
            while (reader.Read())
            {
                if (reader.MoveToContent() == XmlNodeType.Element)
                {
                    var localName = reader.LocalName;

                    switch (localName)
                    {
                        case "SubPath":
                            using (var subPathSubtree = reader.ReadSubtree())
                            {
                                subPathSubtree.MoveToContent();
                                var subPath = new RoleSubPath();
                                var subPathXmlReader = new RoleSubPathXmlReader();
                                subPathXmlReader.ReadXml(subPath, subPathSubtree, modelThings);
                                subPath.Container = rolePath.Id;
                                rolePath.SubPaths.Add(subPath.Id);
                            }
                            break;
                        default:
                            throw new NotSupportedException($"{localName} not yet supported");
                    }
                }
            }
        }


        /// <summary>
        /// reads the contained <see cref="RolePath"/>s
        /// </summary>
        /// <param name="rolePath">
        /// The container <see cref="RolePath"/> of the <see cref="RolePath"/>
        /// </param>
        /// <param name="reader">
        /// an instance of <see cref="XmlReader"/> used to read the .orm file
        /// </param>
        /// <param name="modelThings">
        /// a list of <see cref="ModelThing"/>s to which the deserialized items are added
        /// </param>
        public virtual void ReadProjectedPathComponents(RolePath rolePath, XmlReader reader, List<ModelThing> modelThings)
        {
            throw new InvalidOperationException("only supported by LeadRolePath");
        }

        /// <summary>
        /// reads the contained <see cref="PathObjectUnifier"/>s
        /// </summary>
        /// <param name="rolePath">
        /// The container <see cref="RolePath"/> of the <see cref="RolePath"/>
        /// </param>
        /// <param name="reader">
        /// an instance of <see cref="XmlReader"/> used to read the .orm file
        /// </param>
        /// <param name="modelThings">
        /// a list of <see cref="ModelThing"/>s to which the deserialized items are added
        /// </param>
        public virtual void ReadObjectUnifiers(RolePath rolePath, XmlReader reader, List<ModelThing> modelThings)
        {
            throw new InvalidOperationException("only supported by LeadRolePath");
        }

        /// <summary>
        /// reads the contained <see cref="CalculatedValue"/>s
        /// </summary>
        /// <param name="rolePath">
        /// The container <see cref="RolePath"/> of the <see cref="RolePath"/>
        /// </param>
        /// <param name="reader">
        /// an instance of <see cref="XmlReader"/> used to read the .orm file
        /// </param>
        /// <param name="modelThings">
        /// a list of <see cref="ModelThing"/>s to which the deserialized items are added
        /// </param>
        public virtual void ReadCalculatedValuesSubtree(RolePath rolePath, XmlReader reader, List<ModelThing> modelThings)
        {
            throw new InvalidOperationException("only supported by LeadRolePath");
        }
    }
}
