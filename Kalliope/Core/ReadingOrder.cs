// -------------------------------------------------------------------------------------------------
// <copyright file="ReadingOrder.cs" company="RHEA System S.A.">
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
    using System.Collections.Generic;
    using System.Xml;

    using Kalliope.Attributes;

    /// <summary>
    /// A sequence of roles from a single fact type representing representing a complete role traversal. Also called a predicate
    /// </summary>
    [Description("")]
    [Domain(isAbstract: false, general: "ORMModelElement")]
    [Container(typeName: "FactType", propertyName: "ReadingOrders")]
    public class ReadingOrder : ORMModelElement
    {
        private readonly List<string> roleSequences = new List<string>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReadingOrder"/> class
        /// </summary>
        public ReadingOrder()
        {
            this.Readings = new List<Reading>();
            this.Roles = new List<RoleBase>();
        }

        /// <summary>
        /// The text for the default Reading of this ReadingOrder. Includes ordered replacement fields corresponding to this ReadingOrder
        /// </summary>
        [Description("The text for the default Reading of this ReadingOrder. Includes ordered replacement fields corresponding to this ReadingOrder")]
        [Property(name: "ReadingText", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.String, defaultValue: "", typeName: "")]
        public string ReadingText { get; set; }


        /// <summary>
        /// Gets or sets the owned <see cref="Reading"/>s
        /// </summary>

        [Description("")]
        [Property(name: "Readings", aggregation: AggregationKind.Composite, multiplicity: "1..*", typeKind: TypeKind.Object, defaultValue: "", typeName: "Reading")]
        public List<Reading> Readings { get; set; }

        [Description("")]
        [Property(name: "Roles", aggregation: AggregationKind.None, multiplicity: "1..*", typeKind: TypeKind.Object, defaultValue: "", typeName: "RoleBase")]
        public List<RoleBase> Roles { get; set; }

        /// <summary>
        /// Generates a <see cref="ReadingOrder"/> object from its XML representation.
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
                        case "Readings":

                            using (var readingsSubtree = reader.ReadSubtree())
                            {
                                readingsSubtree.MoveToContent();
                                this.ReadReadings(readingsSubtree);
                            }

                            break;

                        case "RoleSequence":

                            using (var roleSequenceSubtree = reader.ReadSubtree())
                            {
                                roleSequenceSubtree.MoveToContent();
                                this.ReadRoleSequences(roleSequenceSubtree);
                            }

                            break;

                        default:
                            throw new System.NotSupportedException($"{localName} not yet supported");
                    }
                }
            }
        }

        /// <summary>
        /// Reads <see cref="Reading"/>s from the .orm file
        /// </summary>
        /// <param name="reader">
        /// an instance of <see cref="XmlReader"/> used to read the .orm file
        /// </param>
        private void ReadReadings(XmlReader reader)
        {
            while (reader.Read())
            {
                if (reader.MoveToContent() == XmlNodeType.Element)
                {
                    var localName = reader.LocalName;

                    switch (localName)
                    {
                        case "Reading":

                            using (var readingSubtree = reader.ReadSubtree())
                            {
                                readingSubtree.MoveToContent();
                                var reading = new Reading();
                                reading.ReadXml(readingSubtree);
                            }

                            break;
                            
                        default:
                            throw new System.NotSupportedException($"{localName} not yet supported");
                    }

                }
            }
        }

        /// <summary>
        /// Reads <see cref="Role"/> sequences from the .orm file
        /// </summary>
        /// <param name="reader">
        /// an instance of <see cref="XmlReader"/> used to read the .orm file
        /// </param>
        private void ReadRoleSequences(XmlReader reader)
        {
            while (reader.Read())
            {
                if (reader.MoveToContent() == XmlNodeType.Element)
                {
                    var localName = reader.LocalName;

                    switch (localName)
                    {
                        case "Role":

                            var roleReference = reader.GetAttribute("ref");
                            if (!string.IsNullOrEmpty(roleReference))
                            {
                                this.roleSequences.Add(roleReference);
                            }

                            break;

                        default:
                            throw new System.NotSupportedException($"{localName} not yet supported");
                    }

                }
            }
        }
    }
}
