// -------------------------------------------------------------------------------------------------
// <copyright file="SubtypeFact.cs" company="RHEA System S.A.">
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
    /// A fact type representing the subtype meta relationship between a subtype and a supertype
    /// </summary>
    public class SubtypeFact : FactType
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubtypeFact"/> class
        /// </summary>
        /// <param name="model">
        /// The <see cref="ORMModel"/> that contains the current <see cref="SubtypeFact"/>
        /// </param>
        public SubtypeFact(ORMModel model)
        {
            this.Model = model;
            model.FactTypes.Add(this);
        }
        
        /// <summary>
        /// Deprecated property, use PreferredIdentificationPath instead
        /// </summary>
        [Obsolete("use PreferredIdentificationPath instead")]
        public bool IsPrimary { get; set; }

        /// <summary>
        /// The subtype fact is a possible path through the subtype graph for retrieving the identifying supertype for the subtype.
        /// The identifying supertype can be a direct or indirect supertype
        /// </summary>
        public bool PreferredIdentificationPath { get; set; }

        /// <summary>
        /// The preferred identification scheme for the subtype is provided by a supertype reached through this path
        /// </summary>
        public bool ProvidesPreferredIdentifier { get; set; }

        /// <summary>
        /// Generates a <see cref="SubtypeFact"/> object from its XML representation.
        /// </summary>
        /// <param name="reader">
        /// an instance of <see cref="XmlReader"/> used to read the .orm file
        /// </param>
        internal override void ReadXml(XmlReader reader)
        {
            var isPrimary = reader.GetAttribute("IsPrimary");
            if (!string.IsNullOrEmpty(isPrimary))
            {
                this.IsPrimary = XmlConvert.ToBoolean(isPrimary);
            }

            var preferredIdentificationPath = reader.GetAttribute("PreferredIdentificationPath");
            if (!string.IsNullOrEmpty(preferredIdentificationPath))
            {
                this.PreferredIdentificationPath = XmlConvert.ToBoolean(preferredIdentificationPath);
            }

            var providesPreferredIdentifier = reader.GetAttribute("ProvidesPreferredIdentifier");
            if (!string.IsNullOrEmpty(providesPreferredIdentifier))
            {
                this.ProvidesPreferredIdentifier = XmlConvert.ToBoolean(providesPreferredIdentifier);
            }

            base.ReadXml(reader);
        }

        /// <summary>
        /// Reads <see cref="SubtypeMetaRole"/>s and <see cref="SupertypeMetaRole"/> from the .orm file
        /// </summary>
        /// <param name="reader">
        /// an instance of <see cref="XmlReader"/> used to read the .orm file
        /// </param>
        internal override void ReadFactRoles(XmlReader reader)
        {
            while (reader.Read())
            {
                if (reader.MoveToContent() == XmlNodeType.Element)
                {
                    var localName = reader.LocalName;

                    switch (localName)
                    {
                        case "SubtypeMetaRole":
                            using (var subtypeMetaRoleSubtree = reader.ReadSubtree())
                            {
                                subtypeMetaRoleSubtree.MoveToContent();
                                var subtypeMetaRole = new SubtypeMetaRole();
                                subtypeMetaRole.ReadXml(subtypeMetaRoleSubtree);
                                this.Roles.Add(subtypeMetaRole);
                            }
                            break;
                        case "SupertypeMetaRole":
                            using (var supertypeMetaRoleSubtree = reader.ReadSubtree())
                            {
                                supertypeMetaRoleSubtree.MoveToContent();
                                var supertypeMetaRole = new SupertypeMetaRole();
                                supertypeMetaRole.ReadXml(supertypeMetaRoleSubtree);
                                this.Roles.Add(supertypeMetaRole);
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
