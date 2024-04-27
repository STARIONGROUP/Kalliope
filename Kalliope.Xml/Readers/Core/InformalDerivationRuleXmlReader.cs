// -------------------------------------------------------------------------------------------------
// <copyright file="InformalDerivationRuleXmlReader.cs" company="Starion Group S.A.">
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
    /// The purpose of the <see cref="InformalDerivationRuleXmlReader"/> is to deserialize a <see cref="InformalDerivationRule"/>
    /// from an .orm XML file
    /// </summary>
    internal class InformalDerivationRuleXmlReader : OrmModelElementXmlReader
    {
        /// <summary>
        /// Reads the properties of the provided <see cref="InformalDerivationRule"/> from the <see cref="XmlReader"/>
        /// </summary>
        /// <param name="informalDerivationRule">
        /// The subject <see cref="InformalDerivationRule"/> that is to be deserialized
        /// </param>
        /// <param name="reader">
        /// The <see cref="XmlReader"/> that contains the .orm XML
        /// </param>
        /// <param name="modelThings">
        /// a list of <see cref="ModelThing"/>s to which the deserialized items are added
        /// </param>
        public void ReadXml(InformalDerivationRule informalDerivationRule, XmlReader reader, List<ModelThing> modelThings)
        {
            base.ReadXml(informalDerivationRule, reader, modelThings);

            while (reader.Read())
            {
                if (reader.MoveToContent() == XmlNodeType.Element)
                {
                    var localName = reader.LocalName;

                    switch (localName)
                    {
                        case "DerivationNote":
                            using (var derivationNoteSubtree = reader.ReadSubtree())
                            {
                                derivationNoteSubtree.MoveToContent();
                                var derivationNote = new DerivationNote();
                                var derivationNoteXmlReader = new DerivationNoteXmlReader();
                                derivationNoteXmlReader.ReadXml(derivationNote, derivationNoteSubtree, modelThings);
                                derivationNote.Container = informalDerivationRule.Id;
                                informalDerivationRule.DerivationNote = derivationNote.Id;
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
