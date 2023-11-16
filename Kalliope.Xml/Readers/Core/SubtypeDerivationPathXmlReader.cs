// -------------------------------------------------------------------------------------------------
// <copyright file="SubtypeDerivationPathXmlReader.cs" company="RHEA System S.A.">
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

    using Kalliope.DTO;
    using Kalliope.Xml.Extensions;

    /// <summary>
    /// The purpose of the <see cref="SubtypeDerivationPathXmlReader"/> is to deserialize a <see cref="SubtypeDerivationPath"/>
    /// from an .orm XML file
    /// </summary>
    public class SubtypeDerivationPathXmlReader : RolePathOwnerXmlReader
    {
        /// <summary>
        /// Reads the properties of the provided <see cref="SubtypeDerivationPath"/> from the <see cref="XmlReader"/>
        /// </summary>
        /// <param name="subtypeDerivationPath">
        /// The subject <see cref="SubtypeDerivationPath"/> that is to be deserialized
        /// </param>
        /// <param name="reader">
        /// The <see cref="XmlReader"/> that contains the .orm XML
        /// </param>
        /// <param name="modelThings">
        /// a list of <see cref="ModelThing"/>s to which the deserialized items are added
        /// </param>
        public void ReadXml(SubtypeDerivationPath subtypeDerivationPath, XmlReader reader, List<ModelThing> modelThings)
        {
            base.ReadXml(subtypeDerivationPath, reader, modelThings);

            var externalDerivation = reader.GetAttribute("ExternalDerivation");
            if (externalDerivation != null)
            {
                subtypeDerivationPath.ExternalDerivation = XmlConvert.ToBoolean(externalDerivation);
            }

            while (reader.Read())
            {
                if (reader.MoveToContent() == XmlNodeType.Element)
                {
                    var localName = reader.LocalName;

                    switch (localName)
                    {
                        case "InformalRule":
                            using (var informalRuleSubtree = reader.ReadSubtree())
                            {
                                informalRuleSubtree.MoveToContent();
                                var informalDerivationRule = new InformalDerivationRule();
                                var informalDerivationRuleXmlReader = new InformalDerivationRuleXmlReader();
                                informalDerivationRuleXmlReader.ReadXml(informalDerivationRule, informalRuleSubtree, modelThings);
                                informalDerivationRule.Container = subtypeDerivationPath.Id;
                                subtypeDerivationPath.InformalRule = informalDerivationRule.Id;
                            }
                            break;
                        case "PathComponents":
                            using (var pathComponentsSubtree = reader.ReadSubtree())
                            {
                                pathComponentsSubtree.MoveToContent();
                                this.ReadPathComponents(subtypeDerivationPath, pathComponentsSubtree, modelThings);
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
        /// <param name="subtypeDerivationPath">
        /// The container <see cref="SubtypeDerivationPath"/> of the <see cref="RolePath"/>
        /// </param>
        /// <param name="reader">
        /// an instance of <see cref="XmlReader"/> used to read the .orm file
        /// </param>
        /// <param name="modelThings">
        /// a list of <see cref="ModelThing"/>s to which the deserialized items are added
        /// </param>
        private void ReadPathComponents(SubtypeDerivationPath subtypeDerivationPath, XmlReader reader, List<ModelThing> modelThings)
        {
            while (reader.Read())
            {
                if (reader.MoveToContent() == XmlNodeType.Element)
                {
                    var localName = reader.LocalName;

                    switch (localName)
                    {
                        case "RolePath":
                            using (var rolePathSubtree = reader.ReadSubtree())
                            {
                                rolePathSubtree.MoveToContent();
                                var rolePath = new LeadRolePath();
                                var leadRolePathXmlReader = new LeadRolePathXmlReader();
                                leadRolePathXmlReader.ReadXml(rolePath, rolePathSubtree, modelThings);
                                rolePath.Container = subtypeDerivationPath.Id;
                                subtypeDerivationPath.LeadRolePaths.Add(rolePath.Id);
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
