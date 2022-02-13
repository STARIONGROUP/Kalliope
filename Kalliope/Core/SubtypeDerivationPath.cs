// -------------------------------------------------------------------------------------------------
// <copyright file="SubtypeDerivationPath.cs" company="RHEA System S.A.">
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
    /// A role path used to define the population of a derived subtype
    /// </summary>
    public class SubtypeDerivationPath : RolePathOwner
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubtypeDerivationPath"/>
        /// </summary>
        public SubtypeDerivationPath()
        {
            this.DerivationCompleteness = DerivationCompleteness.FullyDerived;
            this.DerivationStorage = DerivationStorage.NotStored;
        }

        /// <summary>
        /// An empty derivation rule is externally defined
        /// </summary>
        public bool ExternalDerivation { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="DerivationCompleteness"/>
        /// </summary>
        public DerivationCompleteness DerivationCompleteness { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="DerivationStorage"/>
        /// </summary>
        public DerivationStorage DerivationStorage { get; set; }

        /// <summary>
        /// Gets or sets the contained <see cref="InformalDerivationRule"/>
        /// </summary>
        public InformalDerivationRule InformalRule { get; set; }

        /// <summary>
        /// Generates a <see cref="SubtypeDerivationPath"/> object from its XML representation.
        /// </summary>
        /// <param name="reader">
        /// an instance of <see cref="XmlReader"/> used to read the .orm file
        /// </param>
        internal override void ReadXml(XmlReader reader)
        {
            base.ReadXml(reader);

            var externalDerivation = reader.GetAttribute("ExternalDerivation");
            if (externalDerivation != null)
            {
                this.ExternalDerivation = XmlConvert.ToBoolean(externalDerivation);
            }

            while (reader.Read())
            {
                if (reader.MoveToContent() == XmlNodeType.Element)
                {
                    var localName = reader.LocalName;

                    switch (localName)
                    {
                        case "InformalRule":
                            using (var informalRuleSubtree = reader.ReadSubtree())
                            {
                                informalRuleSubtree.MoveToContent();
                                var informalDerivationRule = new InformalDerivationRule();
                                informalDerivationRule.ReadXml(informalRuleSubtree);
                                
                                this.InformalRule = informalDerivationRule;
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
