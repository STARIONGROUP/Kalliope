// -------------------------------------------------------------------------------------------------
// <copyright file="PathedRoleXmlReader.cs" company="RHEA System S.A.">
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

using System.Linq;
using Kalliope.Common;

namespace Kalliope.Xml.Readers
{
    using System;
    using System.Collections.Generic;
    using System.Xml;

    using Kalliope.DTO;

    /// <summary>
    /// The purpose of the <see cref="PathedRoleXmlReader"/> is to deserialize a <see cref="PathedRole"/>
    /// from an .orm XML file
    /// </summary>
    public class PathedRoleXmlReader : ModelThingXmlReader
    {
        /// <summary>
        /// Reads the properties of the provided <see cref="PathedRole"/> from the <see cref="XmlReader"/>
        /// </summary>
        /// <param name="pathedRole">
        /// The subject <see cref="PathedRole"/> that is to be deserialized
        /// </param>
        /// <param name="reader">
        /// The <see cref="XmlReader"/> that contains the .orm XML
        /// </param>
        /// <param name="modelThings">
        /// a list of <see cref="ModelThing"/>s to which the deserialized items are added
        /// </param>
        public void ReadXml(PathedRole pathedRole, XmlReader reader, List<ModelThing> modelThings)
        {
            base.ReadXml(pathedRole, reader, modelThings);

            pathedRole.Id = reader.GetAttribute("id");

            var roleBase = reader.GetAttribute("ref");
            if (roleBase != null)
            {
                pathedRole.Role = roleBase;
            }

            var purposeString = reader.GetAttribute("Purpose");
            if (purposeString != null)
            {
                if (Enum.TryParse(purposeString, out PathedRolePurpose purpose))
                {
                    pathedRole.Purpose = purpose;
                }
            }

            var isNegatedString = reader.GetAttribute("IsNegated");
            if (isNegatedString != null)
            {
                pathedRole.IsNegated = XmlConvert.ToBoolean(isNegatedString);
            }

            while (reader.Read())
            {
                if (reader.MoveToContent() == XmlNodeType.Element)
                {
                    var localName = reader.LocalName;

                    switch (localName)
                    {
                        case "ValueRestriction":
                            using (var valueRestrictionSubtree = reader.ReadSubtree())
                            {
                                valueRestrictionSubtree.MoveToContent();
                                this.ReadValueRestriction(pathedRole, valueRestrictionSubtree, modelThings);
                            }
                            break;
                        default:
                            throw new NotSupportedException($"{localName} not yet supported");
                    }
                }
            }
        }

        /// <summary>
        /// reads the <see cref="PathConditionRoleValueRestriction"/>
        /// </summary>
        /// <param name="pathedRole">
        /// The <see cref="pathedRole"/> that contains the <see cref="PathConditionRoleValueRestriction"/>
        /// </param>
        /// <param name="reader">
        /// an instance of <see cref="XmlReader"/> used to read the .orm file
        /// </param>
        /// <param name="modelThings">
        /// a list of <see cref="ModelThing"/>s to which the deserialized items are added
        /// </param>
        private void ReadValueRestriction(PathedRole pathedRole, XmlReader reader, List<ModelThing> modelThings)
        {
            while (reader.Read())
            {
                if (reader.MoveToContent() == XmlNodeType.Element)
                {
                    var localName = reader.LocalName;

                    switch (localName)
                    {
                        case "ValueConstraint":

                            var valueTypeValueConstraint = new ValueTypeValueConstraint();
                            var ValueTypeValueConstraintXmlReader = new ValueTypeValueConstraintXmlReader();
                            ValueTypeValueConstraintXmlReader.ReadXml(valueTypeValueConstraint, reader, modelThings);
                            valueTypeValueConstraint.Container = pathedRole.Id;
                            pathedRole.ValueRestriction = valueTypeValueConstraint.Id;
                            break;

                        case "PathedRoleConditionValueConstraint":

                            var pathConditionRoleValueConstraint = new PathConditionRoleValueConstraint();
                            var pathConditionRoleValueConstraintXmlReader =
                                new PathConditionRoleValueConstraintXmlReader();
                            pathConditionRoleValueConstraintXmlReader.ReadXml(pathConditionRoleValueConstraint,
                                reader, modelThings);
                            pathConditionRoleValueConstraint.Container = pathedRole.Id;
                            pathedRole.ValueRestriction = pathConditionRoleValueConstraint.Id;
                            break;

                        default:
                            throw new NotSupportedException($"{localName} not yet supported");
                    }
                }
            }
        }
    }
}
