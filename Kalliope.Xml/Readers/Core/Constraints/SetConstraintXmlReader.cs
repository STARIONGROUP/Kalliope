// -------------------------------------------------------------------------------------------------
// <copyright file="SetConstraintXmlReader.cs" company="RHEA System S.A.">
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
    /// The purpose of the <see cref="SetConstraintXmlReader"/> is to deserialize a <see cref="SetConstraint"/>
    /// from an .orm XML file
    /// </summary>
    public abstract class SetConstraintXmlReader : ConstraintRoleSequenceXmlReader
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
        /// <param name="setConstraint">
        /// The <see cref="SetConstraint"/> that contains the <see cref="Role"/>s
        /// </param>
        /// <param name="reader">
        /// an instance of <see cref="XmlReader"/> used to read the .orm file
        /// </param>
        protected void ReadRoleSequences(SetConstraint setConstraint, XmlReader reader, List<ModelThing> modelThings)
        {
            while (reader.Read())
            {
                if (reader.MoveToContent() == XmlNodeType.Element)
                {
                    var localName = reader.LocalName;

                    switch (localName)
                    {
                        case "Role":
                            using (var roleProxySubTree = reader.ReadSubtree())
                            {
                                roleProxySubTree.MoveToContent();
                                var roleProxy = new RoleProxy();
                                var roleProxyXmlReader = new RoleProxyXmlReader();
                                roleProxyXmlReader.ReadXml(roleProxy, roleProxySubTree, modelThings);
                                roleProxy.Container = setConstraint.Id;
                                setConstraint.Roles.Add(roleProxy.Id);
                            }
                            break;
                        case "JoinRule":
                            using (var joinRuleSubtree = reader.ReadSubtree())
                            {
                                joinRuleSubtree.MoveToContent();
                                this.ReadJoinRules(setConstraint, joinRuleSubtree, modelThings);
                            }
                            break;
                        default:
                            throw new NotSupportedException($"{localName} not yet supported");
                    }

                }
            }
        }

        private void ReadJoinRules(SetConstraint setConstraint, XmlReader reader, List<ModelThing> modelThings)
        {
            while (reader.Read())
            {
                if (reader.MoveToContent() == XmlNodeType.Element)
                {
                    var localName = reader.LocalName;

                    switch (localName)
                    {
                        case "JoinPath":
                            using (var joinPathSubTree = reader.ReadSubtree())
                            {
                                joinPathSubTree.MoveToContent();
                                var constraintRoleSequenceJoinPath = new ConstraintRoleSequenceJoinPath();
                                var constraintRoleSequenceJoinPathXmlReader = new ConstraintRoleSequenceJoinPathXmlReader();
                                constraintRoleSequenceJoinPathXmlReader.ReadXml(constraintRoleSequenceJoinPath, joinPathSubTree, modelThings);
                                constraintRoleSequenceJoinPath.Container = setConstraint.Id;
                                setConstraint.JoinPath = constraintRoleSequenceJoinPath.Id;
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
