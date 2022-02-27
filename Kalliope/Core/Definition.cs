// -------------------------------------------------------------------------------------------------
// <copyright file="Definition.cs" company="RHEA System S.A.">
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
    using System.Xml;

    using Kalliope.Common;

    /// <summary>
    /// An informal description for the containing element
    /// </summary>
    [Description("")]
    [Domain(isAbstract: false, general: "ORMModelElement")]
    [Container(typeName: "CardinalityConstraint", propertyName: "Definition")]
    [Container(typeName: "ElementGrouping", propertyName: "Definition")]
    [Container(typeName: "FactType", propertyName: "Definition")]
    [Container(typeName: "ObjectType", propertyName: "Definition")]
    [Container(typeName: "ORMModel", propertyName: "Definition")]
    [Container(typeName: "SetComparisonConstraint", propertyName: "Definition")]
    [Container(typeName: "SetConstraint", propertyName: "Definition")]
    [Container(typeName: "ValueConstraint", propertyName: "Definition")]
    public class Definition : ORMModelElement
    {
        /// <summary>
        /// Gets or sets the container <see cref="ORMModelElement"/>
        /// </summary>
        public ORMModelElement Container { get; set; }

        /// <summary>
        /// Plain text description
        /// </summary>
        [Description("The description contents.")]
        [Property(name: "Text", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.String, defaultValue: "", typeName: "")]
        public string Text { get; set; }

        /// <summary>
        /// Generates a <see cref="Definition"/> object from its XML representation.
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
                    switch (reader.LocalName)
                    {
                        case "Text":
                            this.Text = reader.ReadElementContentAsString();
                            break;
                    }
                }
            }
        }
    }
}
