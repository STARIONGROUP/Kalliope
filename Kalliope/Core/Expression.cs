// -------------------------------------------------------------------------------------------------
// <copyright file="Expression.cs" company="RHEA System S.A.">
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

    public abstract class Expression : ORMModelElement
    {
        /// <summary>
        /// Gets or sets the Body text of the <see cref="Expression"/>
        /// </summary>
        public string Body { get; set; }

        /// <summary>
        /// Gets or sets the Language of the <see cref="Expression"/>
        /// </summary>
        public string Language { get; set; }

        /// <summary>
        /// Generates a <see cref="Expression"/> object from its XML representation.
        /// </summary>
        /// <param name="reader">
        /// an instance of <see cref="XmlReader"/> used to read the .orm file
        /// </param>
        internal override void ReadXml(XmlReader reader)
        {
            base.ReadXml(reader);

            using (var bodySubtree = reader.ReadSubtree())
            {
                while (bodySubtree.Read())
                {
                    if (bodySubtree.MoveToContent() == XmlNodeType.Element)
                    {
                        var localName = bodySubtree.LocalName;

                        switch (localName)
                        {
                            case "DerivationExpression":
                                
                                // still at the expression node, do nothing
                                break;

                            case "Body":

                                this.Body = bodySubtree.ReadElementContentAsString();
                                
                                break;

                            default:
                                Console.WriteLine($"Expression.ReadXml did not process the {localName} XML element");
                                break;
                        }
                    }
                }
            }
        }
    }
}
