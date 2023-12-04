// -------------------------------------------------------------------------------------------------
// <copyright file="SetConstraintXmlReader.cs" company="RHEA System S.A.">
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

    /// <summary>
    /// The purpose of the <see cref="SetConstraintXmlReader"/> is to deserialize a <see cref="SetConstraint"/>
    /// from an .orm XML file
    /// </summary>
    public abstract class SetConstraintXmlReader : ConstraintXmlReader
    {
        /// <summary>
        /// Reads the properties of the provided <see cref="SetConstraint"/> from the <see cref="XmlReader"/>
        /// </summary>
        /// <param name="setConstraint">
        /// The subject <see cref="SetConstraint"/> that is to be deserialized
        /// </param>
        /// <param name="reader">
        /// The <see cref="XmlReader"/> that contains the .orm XML
        /// </param>
        /// <param name="modelThings">
        /// a list of <see cref="ModelThing"/>s to which the deserialized items are added
        /// </param>
        public void ReadXml(SetConstraint setConstraint, XmlReader reader, List<ModelThing> modelThings)
        {
            base.ReadXml(setConstraint, reader, modelThings);
        }

        /// <summary>
        /// Reads <see cref="Role"/> sequences from the .orm file
        /// </summary>
        /// <param name="constraint">
        /// The <see cref="Constraint"/> that contains the <see cref="Role"/>s
        /// </param>
        /// <param name="reader">
        /// an instance of <see cref="XmlReader"/> used to read the .orm file
        /// </param>
        /// <param name="modelThings">
        /// a list of <see cref="ModelThing"/>s to which the deserialized items are added
        /// </param>
        protected override void ReadRoleSequence(Constraint constraint, XmlReader reader, List<ModelThing> modelThings)
        {
            while (reader.Read())
            {
                if (reader.MoveToContent() == XmlNodeType.Element)
                {
                    var localName = reader.LocalName;

                    switch (localName)
                    {
                        case "Role":
                            using (var roleSequenceSubTree = reader.ReadSubtree())
                            {
                                roleSequenceSubTree.MoveToContent();
                                var roleRef = reader.GetAttribute("ref");
                                ((SetConstraint)constraint).RoleSequences.Add(roleRef);
                            }

                            break;

                        case "JoinRule":
                            //ToDo: Implement JoinRuleXmlReader

                            using (var joinRuleSubTree = reader.ReadSubtree())
                            {
                                joinRuleSubTree.MoveToContent();
                                //var roleRef = reader.GetAttribute("ref");
                                //((SetConstraint)constraint).RoleSequences.Add(roleRef);
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
