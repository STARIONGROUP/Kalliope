// -------------------------------------------------------------------------------------------------
// <copyright file="InformalDerivationRule.cs" company="RHEA System S.A.">
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

namespace Kalliope.Core
{
    using System;
    using System.Xml;

    /// <summary>
    /// An informal description of the intent of a derivation rule
    /// </summary>
    public class InformalDerivationRule : ORMModelElement
    {
        /// <summary>
        /// Gets or sets the owned <see cref="DerivationNote"/>
        /// </summary>
        public DerivationNote DerivationNote { get; set; }

        /// <summary>
        /// Generates a <see cref="InformalDerivationRule"/> object from its XML representation.
        /// </summary>
        /// <param name="reader">
        /// an instance of <see cref="XmlReader"/> used to read the .orm file
        /// </param>
        internal override void ReadXml(XmlReader reader)
        {
            base.ReadXml(reader);

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
                                derivationNote.ReadXml(derivationNoteSubtree);

                                this.DerivationNote = derivationNote;
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
