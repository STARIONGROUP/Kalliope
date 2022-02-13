// -------------------------------------------------------------------------------------------------
// <copyright file="SubtypeDerivationRule.cs" company="RHEA System S.A.">
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
    /// A role path defining subtype population
    /// </summary>
    /// <remarks>
    /// The formal derivation rule defining a subtype
    /// </remarks>
    public class SubtypeDerivationRule : RolePathOwner
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubtypeDerivationRule"/> class
        /// </summary>
        public SubtypeDerivationRule()
        {
            this.DerivationCompleteness = DerivationCompleteness.FullyDerived;
            this.DerivationStorage = DerivationStorage.NotStored;
        }

        /// <summary>
        /// Specify if a subtype can be explicitly populated without satisfying the derivation path
        /// </summary>
        public DerivationCompleteness DerivationCompleteness { get; set; }

        /// <summary>
        /// Specify if the derivation results are determined on demand or stored when derivation path components are changed
        /// </summary>
        public DerivationStorage DerivationStorage { get; set; }
        
        /// <summary>
        /// Gets or sets the owned <see cref="DerivationNote"/>
        /// </summary>
        public DerivationNote DerivationNote { get; set; }

        /// <summary>
        /// Gets or sets the owned <see cref="SubtypeDerivationPath"/>
        /// </summary>
        public SubtypeDerivationPath SubtypeDerivationPath { get; set; }

        /// <summary>
        /// Generates a <see cref="SubtypeDerivationRule"/> object from its XML representation.
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
                        case "SubtypeDerivationPath":

                            using (var subtypeDerivationPathSubtree = reader.ReadSubtree())
                            {
                                subtypeDerivationPathSubtree.MoveToContent();
                                var subtypeDerivationPath = new SubtypeDerivationPath();
                                subtypeDerivationPath.ReadXml(subtypeDerivationPathSubtree);
                                this.SubtypeDerivationPath = subtypeDerivationPath;
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
