// -------------------------------------------------------------------------------------------------
// <copyright file="Reading.cs" company="RHEA System S.A.">
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
    using System.Collections.Generic;
    using System.Xml;

    using Kalliope.Common;

    /// <summary>
    /// Predicate text corresponding to a specific role traversal
    /// </summary>
    [Description("")]
    [Domain(isAbstract: false, general: "ORMModelElement")]
    [Container(typeName: "ReadingOrder", propertyName: "Readings")]
    public class Reading : ORMModelElement
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Reading"/> class.
        /// </summary>
        public Reading()
        {
            this.ExpandedData = new List<RoleText>();
        }

        /// <summary>
        /// Reading text with numbered replacemented fields in the format {n}, where n is a zero-based index into the corresponding role traversal order. 
        /// n is also strictly increasing, so the first replacement field corresponds to the first role, etc. 
        /// Reading text also includes hyphen-binding specifications, where 'WORD- ' (or ' -WORD') binds WORD and all intermediate words to the nearest right (left) placeholder. 
        /// To enable hyphen binding with no space before the role player, 'WORD-- ROLEPLAYER' collapses the trailing space, resulting in 'WORD-ROLEPLAYER'. 
        /// 'WORD- ROLEPLAYER' can be achived with two hyphens and two spaces
        /// </summary>
        public string Data { get; set; }

        /// <summary>
        /// An expanded form of the Data element with text decoration broken down on a per-role basis.
        /// Hyphen binding constructs are fully resolved with hyphens removed
        /// </summary>
        public List<RoleText> ExpandedData { get; set; }

        /// <summary>
        /// Text that occurs before the lead role, including prebound text associated with that role
        /// </summary>
        public string FrontText { get; set; }

        /// <summary>
        /// The text of this reading. Includes ordered replacement fields corresponding to the parent ReadingOrder
        /// </summary>
        [Description("The text of this reading. Includes ordered replacement fields corresponding to the parent ReadingOrder")]
        [Property(name: "Text", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.String, defaultValue: "", typeName: "")]
        public string Text { get; set; }

        [Description("")]
        [Property(name: "Signature", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.String, defaultValue: "", typeName: "")]
        public string Signature { get; set; }

        [Description("")]
        [Property(name: "IsPrimaryForReadingOrder", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Boolean, defaultValue: "false", typeName: "")]
        public bool IsPrimaryForReadingOrder { get; set; }

        [Description("")]
        [Property(name: "Language", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.String, defaultValue: "", typeName: "")]
        public string Language { get; set; }

        [Description("")]
        [Property(name: "IsPrimaryForFactType", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Boolean, defaultValue: "false", typeName: "")]
        public bool IsPrimaryForFactType { get; set; }

        /// <summary>
        /// Gets or sets the container <see cref="ReadingOrder"/>
        /// </summary>
        public ReadingOrder ReadingOrder { get; set; }

        /// <summary>
        /// Gets or sets the owned <see cref="TooManyReadingRolesError"/>
        /// </summary>
        [Description("")]
        [Property(name: "TooManyRolesError", aggregation: AggregationKind.Composite, multiplicity: "0..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "TooManyReadingRolesError")]
        public TooManyReadingRolesError TooManyRolesError { get; set; }

        /// <summary>
        /// Gets or sets the owned <see cref="TooManyReadingRolesError"/>
        /// </summary>
        [Description("")]
        [Property(name: "TooFewRolesError", aggregation: AggregationKind.Composite, multiplicity: "0..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "TooFewReadingRolesError")]
        public TooFewReadingRolesError TooFewRolesError { get; set; }

        /// <summary>
        /// Gets or sets the owned <see cref="ReadingRequiresUserModificationError"/>
        /// </summary>
        [Description("")]
        [Property(name: "RequiresUserModificationError", aggregation: AggregationKind.Composite, multiplicity: "0..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "ReadingRequiresUserModificationError")]
        public ReadingRequiresUserModificationError RequiresUserModificationError { get; set; }

        /// <summary>
        /// Gets or sets the referenced <see cref="DuplicateReadingSignatureError"/>
        /// </summary>
        [Description("")]
        [Property(name: "DuplicateSignatureError", aggregation: AggregationKind.None, multiplicity: "0..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "DuplicateReadingSignatureError")]
        public DuplicateReadingSignatureError DuplicateSignatureError { get; set; }
        
        /// <summary>
        /// Generates a <see cref="Reading"/> object from its XML representation.
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
                        case "Data":
                            this.Data = reader.ReadElementContentAsString();
                            break;
                        case "ExpandedData":
                            using (var expandedDataSubtree = reader.ReadSubtree())
                            {
                                expandedDataSubtree.MoveToContent();
                                this.ReadExpandedData(expandedDataSubtree);
                            }
                            break;
                        default:
                            throw new NotSupportedException($"{localName} not yet supported");
                    }
                }
            }
        }

        /// <summary>
        /// Reads <see cref="RoleText"/>s from the .orm file
        /// </summary>
        /// <param name="reader">
        /// an instance of <see cref="XmlReader"/> used to read the .orm file
        /// </param>
        private void ReadExpandedData(XmlReader reader)
        {
            while (reader.Read())
            {
                if (reader.MoveToContent() == XmlNodeType.Element)
                {
                    var localName = reader.LocalName;

                    switch (localName)
                    {
                        case "RoleText":

                            var roleText = new RoleText();
                            roleText.ReadXml(reader);
                            this.ExpandedData.Add(roleText);

                            break;
                        default:
                            throw new NotSupportedException($"{localName} not yet supported");
                    }
                }
            }
        }
    }
}
