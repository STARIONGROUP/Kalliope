// -------------------------------------------------------------------------------------------------
// <copyright file="RoleXmlReader.cs" company="RHEA System S.A.">
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
    /// The purpose of the <see cref="RoleXmlReader"/> is to deserialize a <see cref="Role"/>
    /// from an .orm XML file
    /// </summary>
    public class RoleXmlReader : RoleBaseXmlReader
    {
        /// <summary>
        /// Reads the properties of the provided <see cref="Role"/> from the <see cref="XmlReader"/>
        /// </summary>
        /// <param name="role">
        /// The subject <see cref="Role"/> that is to be deserialized
        /// </param>
        /// <param name="reader">
        /// The <see cref="XmlReader"/> that contains the .orm XML
        /// </param>
        /// <param name="modelThings">
        /// a list of <see cref="ModelThing"/>s to which the deserialized items are added
        /// </param>
        public void ReadXml(Role role, XmlReader reader, List<ModelThing> modelThings)
        {
            base.ReadXml(role, reader, modelThings);

            var isMandatory = reader.GetAttribute("_IsMandatory");
            if (!string.IsNullOrEmpty(isMandatory))
            {
                role.IsMandatory = XmlConvert.ToBoolean(isMandatory);
            }

            var multiplicityAttribute = reader.GetAttribute("_Multiplicity");
            if (Enum.TryParse(multiplicityAttribute, out Multiplicity multiplicity))
            {
                role.Multiplicity = multiplicity;
            }

            using (var roleSubtree = reader.ReadSubtree())
            {
                roleSubtree.MoveToContent();

                while (roleSubtree.Read())
                {
                    if (roleSubtree.MoveToContent() == XmlNodeType.Element)
                    {
                        var localName = roleSubtree.LocalName;

                        switch (localName)
                        {
                            case "RolePlayer":
                                var rolePlayerReference = reader.GetAttribute("ref");

                                if (!string.IsNullOrEmpty(rolePlayerReference))
                                {
                                    role.RolePlayer = rolePlayerReference;
                                }

                                break;
                            case "ValueRestriction":
                                using (var valueRestrictionSubTree = reader.ReadSubtree())
                                {
                                    valueRestrictionSubTree.MoveToContent();
                                    this.ReadValueRestriction(role, valueRestrictionSubTree, modelThings);
                                }

                                break;

                            case "Extensions":
                                using (var extensionsSubtree = reader.ReadSubtree())
                                {
                                    extensionsSubtree.MoveToContent();
                                    this.ReadExtensions(role, extensionsSubtree, modelThings);
                                }
                                break;

                            default:
                                Console.WriteLine($"Role.ReadXml did not process the {localName} XML element");
                                break;
                        }
                    }
                }
            }
        }

        /// <summary>
        /// reads the <see cref="Extension"/>s
        /// </summary>
        /// <param name="role">
        /// The <see cref="Role"/> that contains the <see cref="Extension"/>s
        /// </param>
        /// <param name="reader">
        /// an instance of <see cref="XmlReader"/> used to read the .orm file
        /// </param>
        /// <param name="modelThings">
        /// a list of <see cref="ModelThing"/>s to which the deserialized items are added
        /// </param>
        private void ReadExtensions(Role role, XmlReader reader, List<ModelThing> modelThings)
        {
            while (reader.Read())
            {
                if (reader.MoveToContent() == XmlNodeType.Element)
                {
                    var localName = reader.LocalName;

                    switch (localName)
                    {
                        case "CustomProperty":

                            using (var customPropertySubtree = reader.ReadSubtree())
                            {
                                customPropertySubtree.MoveToContent();
                                var customProperty = new CustomProperty();
                                var customPropertyXmlReader = new CustomPropertyXmlReader();
                                customPropertyXmlReader.ReadXml(customProperty, customPropertySubtree, modelThings);
                                customProperty.Container = role.Id;
                                role.Extensions.Add(customProperty.Id);
                            }

                            break;

                        default:
                            throw new NotSupportedException($"{localName} not yet supported");
                    }
                }
            }
        }

        /// <summary>
        /// deserializes the contained <see cref="RoleValueConstraint"/>
        /// </summary>
        /// <param name="role">
        /// The subject <see cref="Role"/> that is to be deserialized
        /// </param>
        /// <param name="reader">
        /// The <see cref="XmlReader"/> that contains the .orm XML
        /// </param>
        /// <param name="modelThings">
        /// a list of <see cref="ModelThing"/>s to which the deserialized items are added
        /// </param>
        private void ReadValueRestriction(Role role, XmlReader reader, List<ModelThing> modelThings)
        {
            while (reader.Read())
            {
                if (reader.MoveToContent() == XmlNodeType.Element)
                {
                    var localName = reader.LocalName;

                    switch (localName)
                    {
                        case "RoleValueConstraint":
                            using (var valueRestrictionSubTree = reader.ReadSubtree())
                            {
                                valueRestrictionSubTree.MoveToContent();

                                var roleValueConstraint = new RoleValueConstraint();
                                var roleValueConstraintXmlReader = new RoleValueConstraintXmlReader();
                                roleValueConstraintXmlReader.ReadXml(roleValueConstraint, valueRestrictionSubTree, modelThings);
                                roleValueConstraint.Container = role.Id;
                                role.ValueConstraint = roleValueConstraint.Id;
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
