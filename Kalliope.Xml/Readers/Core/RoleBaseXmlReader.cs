﻿// -------------------------------------------------------------------------------------------------
// <copyright file="RoleBaseXmlReader.cs" company="Starion Group S.A.">
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
    /// The purpose of the <see cref="RoleBaseXmlReader"/> is to deserialize a <see cref="RoleBase"/>
    /// from an .orm XML file
    /// </summary>
    public abstract class RoleBaseXmlReader : OrmModelElementXmlReader
    {
        /// <summary>
        /// Reads the properties of the provided <see cref="RoleBase"/> from the <see cref="XmlReader"/>
        /// </summary>
        /// <param name="roleBase">
        /// The subject <see cref="RoleBase"/> that is to be deserialized
        /// </param>
        /// <param name="reader">
        /// The <see cref="XmlReader"/> that contains the .orm XML
        /// </param>
        /// <param name="modelThings">
        /// a list of <see cref="ModelThing"/>s to which the deserialized items are added
        /// </param>
        public void ReadXml(RoleBase roleBase, XmlReader reader, List<ModelThing> modelThings)
        {
            roleBase.Name = reader.GetAttribute("Name");

            base.ReadXml(roleBase, reader, modelThings);
        }
    }
}
