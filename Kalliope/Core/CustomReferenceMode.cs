// -------------------------------------------------------------------------------------------------
// <copyright file="CustomReferenceMode.cs" company="RHEA System S.A.">
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
    /// Definition of a custom reference mode pattern
    /// </summary>
    [Description("")]
    [Domain(isAbstract: false, general: "")]
    public class CustomReferenceMode : ReferenceMode
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReferenceMode"/> class
        /// </summary>
        /// <param name="model">
        /// The <see cref="ORMModel"/> that contains the current <see cref="ReferenceMode"/>
        /// </param>
        public CustomReferenceMode(ORMModel model)
        {
            this.Model = model;
            model.CustomReferenceModes.Add(this);
        }

        /// <summary>
        /// Gets or sets the container <see cref="ORMModel"/>
        /// </summary>
        public ORMModel Model { get; set; }

        /// <summary>
        /// A string with replacement fields representing a custom format for a value type name based on the entity type name
        /// (replacement field {0}) and reference mode name (replacement field {1}). If not specified, defaults to the ReferenceModeKind FormatString attribute
        /// </summary>
        [Description("Custom format string for this reference mode pattern. Replacement field {0}=EntityTypeName, {1}=ReferenceModeName")]
        [Property(name: "CustomFormatString", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.String, defaultValue: "", typeName: "")]
        public string CustomFormatString { get; set; }
        
        /// <summary>
        /// Generates a <see cref="ORMModel"/> object from its XML representation.
        /// </summary>
        /// <param name="reader">
        /// an instance of <see cref="XmlReader"/> used to read the .orm file
        /// </param>
        internal override void ReadXml(XmlReader reader)
        {
            base.ReadXml(reader);

            this.CustomFormatString = reader.GetAttribute("FormatString");
        }
    }
}
