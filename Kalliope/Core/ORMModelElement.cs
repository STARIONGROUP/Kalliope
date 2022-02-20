// -------------------------------------------------------------------------------------------------
// <copyright file="ORMModelElement.cs" company="RHEA System S.A.">
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

    [Description("")]
    [Domain(isAbstract: true, general: "")]
    public abstract class ORMModelElement
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ORMModelElement"/> class
        /// </summary>
        protected ORMModelElement()
        {
            this.ExtensionModelErrors = new List<ModelError>();
        }

        /// <summary>
        /// A unique identifier for this element
        /// </summary>
        [Description("A unique identifier for this element")]
        [Property(name: "Id", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.String, defaultValue: "")]
        public string Id { get; set; }

        [Description("")]
        [Property(name: "ExtensionModelErrors", aggregation: AggregationKind.None, multiplicity: "0..9", typeKind: TypeKind.Object, defaultValue: "", typeName: "ModelError")]
        public List<ModelError> ExtensionModelErrors { get; set; }

        [Description("")]
        [Property(name: "AssociatedModelErrors", aggregation: AggregationKind.None, multiplicity: "0..*", typeKind: TypeKind.Object, defaultValue: "", typeName: "ModelError")]
        public List<ModelError> AssociatedModelErrors { get; set; }

        /// <summary>
        /// Generates a <see cref="ORMModelElement"/> object from its XML representation.
        /// </summary>
        /// <param name="reader">
        /// an instance of <see cref="XmlReader"/> used to read the .orm file
        /// </param>
        internal virtual void ReadXml(XmlReader reader)
        {
            this.Id = reader.GetAttribute("id");
        }
    }
}
