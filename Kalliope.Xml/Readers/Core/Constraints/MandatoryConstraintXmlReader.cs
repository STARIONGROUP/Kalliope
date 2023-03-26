// -------------------------------------------------------------------------------------------------
// <copyright file="MandatoryConstraintXmlReader.cs" company="RHEA System S.A.">
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
    /// The purpose of the <see cref="MandatoryConstraintXmlReader"/> is to deserialize a <see cref="MandatoryConstraint"/>
    /// from an .orm XML file
    /// </summary>
    public class MandatoryConstraintXmlReader : SetConstraintXmlReader
    {
        /// <summary>
        /// Reads the properties of the provided <see cref="MandatoryConstraint"/> from the <see cref="XmlReader"/>
        /// </summary>
        /// <param name="mandatoryConstraint">
        /// The subject <see cref="MandatoryConstraint"/> that is to be deserialized
        /// </param>
        /// <param name="reader">
        /// The <see cref="XmlReader"/> that contains the .orm XML
        /// </param>
        /// <param name="modelThings">
        /// a list of <see cref="ModelThing"/>s to which the deserialized items are added
        /// </param>
        public void ReadXml(MandatoryConstraint mandatoryConstraint, XmlReader reader, List<ModelThing> modelThings)
        {
            base.ReadXml(mandatoryConstraint, reader, modelThings);

            var isSimple = reader.GetAttribute("IsSimple");
            if (isSimple != null)
            {
                mandatoryConstraint.IsSimple = XmlConvert.ToBoolean(isSimple);
            }

            var isImplied = reader.GetAttribute("IsImplied");
            if (isImplied != null)
            {
                mandatoryConstraint.IsImplied = XmlConvert.ToBoolean(isImplied);
            }

            using (var constraintSubtree = reader.ReadSubtree())
            {
                while (constraintSubtree.Read())
                {
                    if (constraintSubtree.MoveToContent() == XmlNodeType.Element)
                    {
                        var localName = reader.LocalName;

                        switch (localName)
                        {
                            case "MandatoryConstraint":
                                break;
                            case "RoleSequence":
                                using (var roleSequenceSubtree = constraintSubtree.ReadSubtree())
                                {
                                    roleSequenceSubtree.MoveToContent();
                                    this.ReadRoleSequences(mandatoryConstraint, roleSequenceSubtree, modelThings);
                                }
                                break;
                            case "ImpliedByObjectType":
                                var impliedByObjectType = reader.GetAttribute("ref");
                                if (!string.IsNullOrEmpty(impliedByObjectType) )
                                {
                                    mandatoryConstraint.ImpliedByObjectType = impliedByObjectType;
                                }
                                break;
                            case "InherentForObjectType":
                                var inherentForObjectType = reader.GetAttribute("ref");
                                if (!string.IsNullOrEmpty(inherentForObjectType))
                                {
                                    mandatoryConstraint.InherentForObjectType = inherentForObjectType;
                                }
                                break;
                            case "ExclusiveOrExclusionConstraint":
                                var exclusiveOrExclusionConstraint = reader.GetAttribute("ref");
                                if (!string.IsNullOrEmpty(exclusiveOrExclusionConstraint))
                                {
                                    mandatoryConstraint.ExclusiveOrExclusionConstraint = exclusiveOrExclusionConstraint;
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
