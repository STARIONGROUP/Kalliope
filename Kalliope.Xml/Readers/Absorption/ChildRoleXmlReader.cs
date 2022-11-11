// -------------------------------------------------------------------------------------------------
// <copyright file="ChildRoleXmlReader.cs" company="RHEA System S.A.">
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
    /// The purpose of the <see cref="ChildRoleXmlReader"/> is to deserialize a <see cref="ChildRole"/>
    /// from an .orm XML file
    /// </summary>
    public class ChildRoleXmlReader : ModelThingXmlReader
    {
        /// <summary>
        /// Reads the properties of the provided <see cref="ChildRole"/> from the <see cref="XmlReader"/>
        /// </summary>
        /// <param name="childRole">
        /// The subject <see cref="ChildRole"/> that is to be deserialized
        /// </param>
        /// <param name="reader">
        /// The <see cref="XmlReader"/> that contains the .orm XML
        /// </param>
        /// <param name="modelThings">
        /// a list of <see cref="ModelThing"/>s to which the deserialized items are added
        /// </param>
        public void ReadXml(ChildRole childRole, XmlReader reader, List<ModelThing> modelThings)
        {
            base.ReadXml(childRole, reader, modelThings);

            childRole.Id = reader.GetAttribute("id");

            var canBePrimary = reader.GetAttribute("CanBePrimary");
            if (!string.IsNullOrEmpty(canBePrimary))
            {
                childRole.CanBePrimary = XmlConvert.ToBoolean(canBePrimary);
            }

            var identifier = reader.GetAttribute("Identifier");
            if (!string.IsNullOrEmpty(identifier))
            {
                childRole.Identifier = XmlConvert.ToBoolean(identifier);
            }

            var ignored = reader.GetAttribute("Ignored");
            if (!string.IsNullOrEmpty(ignored))
            {
                childRole.Ignored = XmlConvert.ToBoolean(ignored);
            }

            var isPrimary = reader.GetAttribute("IsPrimary");
            if (!string.IsNullOrEmpty(isPrimary))
            {
                childRole.IsPrimary = XmlConvert.ToBoolean(isPrimary);
            }

            var objectifiedRole = reader.GetAttribute("ObjectifiedRole");
            if (!string.IsNullOrEmpty(objectifiedRole))
            {
                childRole.ObjectifiedRole = XmlConvert.ToBoolean(objectifiedRole);
            }

            childRole.ReferenceLocation = reader.GetAttribute("ReferenceLocation");

            childRole.XmlName = reader.GetAttribute("XmlName");

            childRole.XmlReferenceName = reader.GetAttribute("XmlReferenceName");

            childRole.XmlReferenceSimpleValueForm = reader.GetAttribute("XmlReferenceSimpleValueForm");

            childRole.XmlSimpleValueForm = reader.GetAttribute("XmlSimpleValueForm");
        }
    }
}
