// -------------------------------------------------------------------------------------------------
// <copyright file="LeadRolePathXmlReader.cs" company="RHEA System S.A.">
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
    /// The purpose of the <see cref="LeadRolePathXmlReader"/> is to deserialize a <see cref="LeadRolePath"/>
    /// from an .orm XML file
    /// </summary>
    public class LeadRolePathXmlReader : RolePathXmlReader
    {
        /// <summary>
        /// Reads the properties of the provided <see cref="LeadRolePath"/> from the <see cref="XmlReader"/>
        /// </summary>
        /// <param name="leadRolePath">
        /// The subject <see cref="LeadRolePath"/> that is to be deserialized
        /// </param>
        /// <param name="reader">
        /// The <see cref="XmlReader"/> that contains the .orm XML
        /// </param>
        /// <param name="modelThings">
        /// a list of <see cref="ModelThing"/>s to which the deserialized items are added
        /// </param>
        public void ReadXml(LeadRolePath leadRolePath, XmlReader reader, List<ModelThing> modelThings)
        {
            var note = reader.GetAttribute("Note");
            if (note != null)
            {
                leadRolePath.Note = note;
            }

            base.ReadXml(leadRolePath, reader, modelThings);
        }

        /// <summary>
        /// reads the contained <see cref="PathObjectUnifier"/>s
        /// </summary>
        /// <param name="rolePath">
        /// The container <see cref="RolePath"/> of the <see cref="RolePath"/>
        /// </param>
        /// <param name="reader">
        /// an instance of <see cref="XmlReader"/> used to read the .orm file
        /// </param>
        /// <param name="modelThings">
        /// a list of <see cref="ModelThing"/>s to which the deserialized items are added
        /// </param>
        public override void ReadObjectUnifiers(RolePath rolePath, XmlReader reader, List<ModelThing> modelThings)
        {
            while (reader.Read())
            {
                if (reader.MoveToContent() == XmlNodeType.Element)
                {
                    var localName = reader.LocalName;

                    switch (localName)
                    {
                        case "ObjectUnifier":
                            using (var objectUnifierSubtree = reader.ReadSubtree())
                            {
                                objectUnifierSubtree.MoveToContent();
                                var objectUnifier = new PathObjectUnifier();
                                var pathObjectUnifierXmlReader = new PathObjectUnifierXmlReader();
                                pathObjectUnifierXmlReader.ReadXml(objectUnifier, objectUnifierSubtree, modelThings);
                                objectUnifier.Container = rolePath.Id;
                                ((LeadRolePath)rolePath).ObjectUnifiers.Add(objectUnifier.Id);
                            }

                            break;
                        default:
                            throw new NotSupportedException($"{localName} not yet supported");
                    }
                }
            }
        }

        /// <summary>
        /// reads the contained <see cref="CalculatedPathValue"/>s
        /// </summary>
        /// <param name="rolePath">
        /// The container <see cref="RolePath"/> of the <see cref="RolePath"/>
        /// </param>
        /// <param name="reader">
        /// an instance of <see cref="XmlReader"/> used to read the .orm file
        /// </param>
        /// <param name="modelThings">
        /// a list of <see cref="ModelThing"/>s to which the deserialized items are added
        /// </param>
        public override void ReadConditions(RolePath rolePath, XmlReader reader, List<ModelThing> modelThings)
        {
            while (reader.Read())
            {
                if (reader.MoveToContent() == XmlNodeType.Element)
                {
                    var localName = reader.LocalName;

                    switch (localName)
                    {
                        case "CalculatedCondition":
                            using (var calculatedConditionSubtree = reader.ReadSubtree())
                            {
                                calculatedConditionSubtree.MoveToContent();

                                var calculatedValueRef = reader.GetAttribute("ref");
                                if (calculatedValueRef != null)
                                {
                                    ((LeadRolePath)rolePath).CalculatedConditions.Add(calculatedValueRef);
                                }
                            }

                            break;
                        default:
                            throw new NotSupportedException($"{localName} not yet supported");
                    }
                }
            }
        }

        /// <summary>
        /// reads the contained <see cref="CalculatedValue"/>s
        /// </summary>
        /// <param name="rolePath">
        /// The container <see cref="RolePath"/> of the <see cref="RolePath"/>
        /// </param>
        /// <param name="reader">
        /// an instance of <see cref="XmlReader"/> used to read the .orm file
        /// </param>
        /// <param name="modelThings">
        /// a list of <see cref="ModelThing"/>s to which the deserialized items are added
        /// </param>
        public override void ReadCalculatedValuesSubtree(RolePath rolePath, XmlReader reader,
            List<ModelThing> modelThings)
        {
            while (reader.Read())
            {
                if (reader.MoveToContent() == XmlNodeType.Element)
                {
                    var localName = reader.LocalName;

                    switch (localName)
                    {
                        case "CalculatedValue":
                            using (var calculatedValueSubtree = reader.ReadSubtree())
                            {
                                calculatedValueSubtree.MoveToContent();
                                var calculatedValue = new CalculatedPathValue();
                                var calculatedValueXmlReader = new CalculatedPathValueXmlReader();
                                calculatedValueXmlReader.ReadXml(calculatedValue, calculatedValueSubtree, modelThings);
                                calculatedValue.Container = rolePath.Id;
                                ((LeadRolePath)rolePath).CalculatedValues.Add(calculatedValue.Id);
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