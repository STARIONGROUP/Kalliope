// -------------------------------------------------------------------------------------------------
// <copyright file="SubtypeFactXmlReader.cs" company="RHEA System S.A.">
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
    /// The purpose of the <see cref="SubtypeFactXmlReader"/> is to deserialize a <see cref="SubtypeFact"/>
    /// from an .orm XML file
    /// </summary>
    public class SubtypeFactXmlReader : FactTypeXmlReader
    {
        /// <summary>
        /// Reads the properties of the provided <see cref="SubtypeFact"/> from the <see cref="XmlReader"/>
        /// </summary>
        /// <param name="subtypeFact">
        /// The subject <see cref="SubtypeFact"/> that is to be deserialized
        /// </param>
        /// <param name="reader">
        /// The <see cref="XmlReader"/> that contains the .orm XML
        /// </param>
        /// <param name="modelThings">
        /// a list of <see cref="ModelThing"/>s to which the deserialized items are added
        /// </param>
        public void ReadXml(SubtypeFact subtypeFact, XmlReader reader, List<ModelThing> modelThings)
        {
            var isPrimary = reader.GetAttribute("IsPrimary");
            if (!string.IsNullOrEmpty(isPrimary))
            {
                subtypeFact.IsPrimary = XmlConvert.ToBoolean(isPrimary);
            }

            var preferredIdentificationPath = reader.GetAttribute("PreferredIdentificationPath");
            if (!string.IsNullOrEmpty(preferredIdentificationPath))
            {
                subtypeFact.PreferredIdentificationPath = XmlConvert.ToBoolean(preferredIdentificationPath);
            }

            var providesPreferredIdentifier = reader.GetAttribute("ProvidesPreferredIdentifier");
            if (!string.IsNullOrEmpty(providesPreferredIdentifier))
            {
                subtypeFact.ProvidesPreferredIdentifier = XmlConvert.ToBoolean(providesPreferredIdentifier);
            }

            base.ReadXml(subtypeFact, reader, modelThings);
        }

        /// <summary>
        /// Reads <see cref="SubtypeMetaRole"/>s and <see cref="SupertypeMetaRole"/> from the .orm file
        /// </summary>
        /// <param name="reader">
        /// an instance of <see cref="XmlReader"/> used to read the .orm file
        /// </param>
        public override void ReadFactRoles(FactType factType, XmlReader reader, List<ModelThing> modelThings)
        {
            while (reader.Read())
            {
                if (reader.MoveToContent() == XmlNodeType.Element)
                {
                    var localName = reader.LocalName;

                    switch (localName)
                    {
                        case "SubtypeMetaRole":
                            using (var subtypeMetaRoleSubtree = reader.ReadSubtree())
                            {
                                subtypeMetaRoleSubtree.MoveToContent();
                                var subtypeMetaRole = new SubtypeMetaRole();
                                var subtypeMetaRoleXmlReader = new SubtypeMetaRoleXmlReader();
                                subtypeMetaRoleXmlReader.ReadXml(subtypeMetaRole, subtypeMetaRoleSubtree, modelThings);
                                subtypeMetaRole.Container = factType.Id;
                                factType.Roles.Add(subtypeMetaRole.Id);
                            }
                            break;
                        case "SupertypeMetaRole":
                            using (var supertypeMetaRoleSubtree = reader.ReadSubtree())
                            {
                                supertypeMetaRoleSubtree.MoveToContent();
                                var supertypeMetaRole = new SupertypeMetaRole();
                                var supertypeMetaRoleXmlReader = new SupertypeMetaRoleXmlReader();
                                supertypeMetaRoleXmlReader.ReadXml(supertypeMetaRole, supertypeMetaRoleSubtree, modelThings);
                                supertypeMetaRole.Container = factType.Id;
                                factType.Roles.Add(supertypeMetaRole.Id);
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
