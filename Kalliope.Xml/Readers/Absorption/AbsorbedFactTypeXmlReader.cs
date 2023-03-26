// -------------------------------------------------------------------------------------------------
// <copyright file="AbsorbedFactTypeXmlReader.cs" company="RHEA System S.A.">
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
    using System.Collections.Generic;
    using System.Xml;

    using Kalliope.DTO;

    /// <summary>
    /// The purpose of the <see cref="AbsorbedFactTypeXmlReader"/> is to deserialize a <see cref="AbsorbedFactType"/>
    /// from an .orm XML file
    /// </summary>
    public class AbsorbedFactTypeXmlReader : ModelThingXmlReader
    {
        /// <summary>
        /// Reads the properties of the provided <see cref="AbsorbedObjectType"/> from the <see cref="XmlReader"/>
        /// </summary>
        /// <param name="absorbedFactType">
        /// The subject <see cref="AbsorbedFactType"/> that is to be deserialized
        /// </param>
        /// <param name="reader">
        /// The <see cref="XmlReader"/> that contains the .orm XML
        /// </param>
        /// <param name="modelThings">
        /// a list of <see cref="ModelThing"/>s to which the deserialized items are added
        /// </param>
        public void ReadXml(AbsorbedFactType absorbedFactType, XmlReader reader, List<ModelThing> modelThings)
        {
            base.ReadXml(absorbedFactType, reader, modelThings);

            absorbedFactType.Id = reader.GetAttribute("id");

            var absorbed = reader.GetAttribute("Absorbed");
            if (!string.IsNullOrEmpty(absorbed))
            {
                absorbedFactType.Absorbed = XmlConvert.ToBoolean(absorbed);
            }

            var absorbedUnary = reader.GetAttribute("AbsorbedUnary");
            if (!string.IsNullOrEmpty(absorbedUnary))
            {
                absorbedFactType.AbsorbedUnary = XmlConvert.ToBoolean(absorbedUnary);
            }

            var functional = reader.GetAttribute("Functional");
            if (!string.IsNullOrEmpty(functional))
            {
                absorbedFactType.Functional = XmlConvert.ToBoolean(functional);
            }

            var nested = reader.GetAttribute("Nested");
            if (!string.IsNullOrEmpty(nested))
            {
                absorbedFactType.Nested = XmlConvert.ToBoolean(nested);
            }

            var topLevel = reader.GetAttribute("TopLevel");
            if (!string.IsNullOrEmpty(topLevel))
            {
                absorbedFactType.TopLevel = XmlConvert.ToBoolean(topLevel);
            }

            absorbedFactType.XmlName = reader.GetAttribute("XmlName");

            while (reader.Read())
            {
                if (reader.MoveToContent() == XmlNodeType.Element)
                {
                    var localName = reader.LocalName;

                    switch (localName)
                    {
                        case "PossibleChildRoles":
                            using (var possibleChildRolesSubtree = reader.ReadSubtree())
                            {
                                possibleChildRolesSubtree.MoveToContent();
                                this.ReadPossibleChildRoles(absorbedFactType, possibleChildRolesSubtree, modelThings);
                            }
                            break;
                        case "AbsorbedRoles":
                            using (var absorbedRolesSubtree = reader.ReadSubtree())
                            {
                                absorbedRolesSubtree.MoveToContent();
                                this.ReadAbsorbedRoles(absorbedFactType, absorbedRolesSubtree, modelThings);
                            }
                            break;
                        default:
                            throw new System.NotSupportedException($"{localName} not yet supported");
                    }
                }
            }
        }

        /// <summary>
        /// Reads <see cref="ChildRole"/>s from the .orm file
        /// </summary>
        /// <param name="absorbedFactType">
        /// The subject <see cref="AbsorbedFactType"/> that is to be deserialized
        /// </param>
        /// <param name="reader">
        /// an instance of <see cref="XmlReader"/> used to read the .orm file
        /// </param>
        /// <param name="modelThings">
        /// a list of <see cref="ModelThing"/>s to which the deserialized items are added
        /// </param>
        private void ReadPossibleChildRoles(AbsorbedFactType absorbedFactType, XmlReader reader, List<ModelThing> modelThings)
        {
            while (reader.Read())
            {
                if (reader.MoveToContent() == XmlNodeType.Element)
                {
                    var localName = reader.LocalName;

                    switch (localName)
                    {
                        case "ChildRole":
                            using (var childRoleSubtree = reader.ReadSubtree())
                            {
                                childRoleSubtree.MoveToContent();
                                var childRole = new ChildRole();
                                var childRoleXmlReader = new ChildRoleXmlReader();
                                childRoleXmlReader.ReadXml(childRole, childRoleSubtree, modelThings);
                                childRole.Container = absorbedFactType.Id;
                                absorbedFactType.PossibleChildRoles.Add(childRole.Id);
                            }
                            break;
                        default:
                            throw new System.NotSupportedException($"{localName} not yet supported");
                    }
                }
            }
        }

        /// <summary>
        /// Reads <see cref="ChildRole"/>s from the .orm file
        /// </summary>
        /// <param name="absorbedFactType">
        /// The subject <see cref="AbsorbedFactType"/> that is to be deserialized
        /// </param>
        /// <param name="reader">
        /// an instance of <see cref="XmlReader"/> used to read the .orm file
        /// </param>
        /// <param name="modelThings">
        /// a list of <see cref="ModelThing"/>s to which the deserialized items are added
        /// </param>
        private void ReadAbsorbedRoles(AbsorbedFactType absorbedFactType, XmlReader reader, List<ModelThing> modelThings)
        {
            while (reader.Read())
            {
                if (reader.MoveToContent() == XmlNodeType.Element)
                {
                    var localName = reader.LocalName;

                    switch (localName)
                    {
                        case "AbsorbedRole":
                            using (var absorbedRoleSubtree = reader.ReadSubtree())
                            {
                                absorbedRoleSubtree.MoveToContent();
                                var absorbedRole = new AbsorbedRole();
                                var absorbedRoleXmlReader = new AbsorbedRoleXmlReader();
                                absorbedRoleXmlReader.ReadXml(absorbedRole, absorbedRoleSubtree, modelThings);
                                absorbedRole.Container = absorbedFactType.Id;
                                absorbedFactType.AbsorbedRoles.Add(absorbedRole.Id);
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
