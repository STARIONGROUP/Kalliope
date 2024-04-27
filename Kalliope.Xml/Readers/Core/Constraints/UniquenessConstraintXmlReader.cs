// -------------------------------------------------------------------------------------------------
// <copyright file="UniquenessConstraintXmlReader.cs" company="Starion Group S.A.">
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
    /// The purpose of the <see cref="UniquenessConstraintXmlReader"/> is to deserialize a <see cref="UniquenessConstraint"/>
    /// from an .orm XML file
    /// </summary>
    public class UniquenessConstraintXmlReader : SetConstraintXmlReader
    {
        /// <summary>
        /// Reads the properties of the provided <see cref="UniquenessConstraint"/> from the <see cref="XmlReader"/>
        /// </summary>
        /// <param name="uniquenessConstraint">
        /// The subject <see cref="UniquenessConstraint"/> that is to be deserialized
        /// </param>
        /// <param name="reader">
        /// The <see cref="XmlReader"/> that contains the .orm XML
        /// </param>
        /// <param name="modelThings">
        /// a list of <see cref="ModelThing"/>s to which the deserialized items are added
        /// </param>
        public void ReadXml(UniquenessConstraint uniquenessConstraint, XmlReader reader, List<ModelThing> modelThings)
        {
            base.ReadXml(uniquenessConstraint, reader, modelThings);

            var isPreferred = reader.GetAttribute("IsPreferred");
            if (isPreferred != null)
            {
                uniquenessConstraint.IsPreferred = XmlConvert.ToBoolean(isPreferred);
            }

            var isInternal = reader.GetAttribute("IsInternal");
            if (isInternal != null)
            {
                uniquenessConstraint.IsInternal = XmlConvert.ToBoolean(isInternal);
            }

            using (var constraintSubtree = reader.ReadSubtree())
            {
                constraintSubtree.MoveToContent();

                while (constraintSubtree.Read())
                {
                    if (constraintSubtree.MoveToContent() == XmlNodeType.Element)
                    {
                        var localName = reader.LocalName;

                        switch (localName)
                        {
                            case "RoleSequence":
                                using (var roleSequenceSubtree = constraintSubtree.ReadSubtree())
                                {
                                    roleSequenceSubtree.MoveToContent();
                                    this.ReadRoleSequences(uniquenessConstraint, roleSequenceSubtree, modelThings);
                                }
                                break;
                            case "PreferredIdentifierFor":
                                var preferredIdentifierFor = reader.GetAttribute("ref");
                                if (!string.IsNullOrEmpty(preferredIdentifierFor))
                                {
                                    uniquenessConstraint.PreferredIdentifierFor = preferredIdentifierFor;
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
}
