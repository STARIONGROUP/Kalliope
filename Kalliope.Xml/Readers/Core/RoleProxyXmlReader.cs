﻿// -------------------------------------------------------------------------------------------------
// <copyright file="RoleProxyXmlReader.cs" company="Starion Group S.A.">
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
    using System;
    using System.Collections.Generic;
    using System.Xml;

    using Kalliope.DTO;

    /// <summary>
    /// The purpose of the <see cref="RoleProxyXmlReader"/> is to deserialize a <see cref="RoleProxy"/>
    /// from an .orm XML file
    /// </summary>
    public class RoleProxyXmlReader : RoleBaseXmlReader
    {
        /// <summary>
        /// Reads the properties of the provided <see cref="RoleProxy"/> from the <see cref="XmlReader"/>
        /// </summary>
        /// <param name="roleProxy">
        /// The subject <see cref="RoleProxy"/> that is to be deserialized
        /// </param>
        /// <param name="reader">
        /// The <see cref="XmlReader"/> that contains the .orm XML
        /// </param>
        /// <param name="modelThings">
        /// a list of <see cref="ModelThing"/>s to which the deserialized items are added
        /// </param>
        public void ReadXml(RoleProxy roleProxy, XmlReader reader, List<ModelThing> modelThings)
        {
            base.ReadXml(roleProxy, reader, modelThings);

            var roleReference = reader.GetAttribute("ref");
            if (!string.IsNullOrEmpty(roleReference))
            {
                roleProxy.TargetRole = roleReference;
            }

            while (reader.Read())
            {
                if (reader.MoveToContent() == XmlNodeType.Element)
                {
                    var localName = reader.LocalName;

                    switch (localName)
                    {
                        case "Role":
                            using (var rolesSubtree = reader.ReadSubtree())
                            {
                                rolesSubtree.MoveToContent();
                                roleProxy.TargetRole = rolesSubtree.GetAttribute("ref");
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
