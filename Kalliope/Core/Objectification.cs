// -------------------------------------------------------------------------------------------------
// <copyright file="Objectification.cs" company="RHEA System S.A.">
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

    /// <summary>
    /// represents the relationship between the entity type and the referenced fact type
    /// </summary>
    public class Objectification : ORMModelElement
    {
        private string nestedFactTypeReference = string.Empty;

        /// <summary>
        /// Gets or sets a value indicating whether the <see cref="Objectification"/> is implied or not
        /// </summary>
        /// <remarks>
        /// True if the objectification relationship is implied by a spanning uniqueness constraint on a binary fact type
        /// or an n-ary fact type where n&gt;2. The objectifying entity type for an implied fact type is always independent
        /// </remarks>
        public bool IsImplied { get; set; }

        public ObjectType NestingType { get; set; }

        public FactType NestedFactType { get; set; }

        /// <summary>
        /// Generates a <see cref="Objectification"/> object from its XML representation.
        /// </summary>
        /// <param name="reader">
        /// an instance of <see cref="XmlReader"/> used to read the .orm file
        /// </param>
        internal override void ReadXml(XmlReader reader)
        {
            base.ReadXml(reader);

            var isImpliedAttribute = reader.GetAttribute("IsImplied");
            if (isImpliedAttribute != null)
            {
                this.IsImplied = XmlConvert.ToBoolean(isImpliedAttribute);
            }

            var nestedFactTypeReferenceAttribute = reader.GetAttribute("ref");
            if (nestedFactTypeReferenceAttribute != null)
            {
                this.nestedFactTypeReference = nestedFactTypeReferenceAttribute;
            }
        }
    }
}
