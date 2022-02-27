// -------------------------------------------------------------------------------------------------
// <copyright file="RecognizedPhrase.cs" company="RHEA System S.A.">
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

    using Kalliope.Common;

    /// <summary>
    /// A phrase with one or more words that can be abbreviated during name generation
    /// </summary>
    [Description("A phrase with one or more words that can be abbreviated during name generation")]
    [Domain(isAbstract: false, general: "ORMNamedElement")]
    [Container(typeName: "ORMModel", propertyName: "RecognizedPhrases")]
    public class RecognizedPhrase : ORMNamedElement
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RecognizedPhrase"/> class
        /// </summary>
        public RecognizedPhrase()
        {
            this.Abbreviations = new List<NameAlias>();
        }

        /// <summary>
        /// Gets or sets the contained <see cref="NameAlias"/>
        /// </summary>
        [Description("")]
        [Property(name: "Abbreviations", aggregation: AggregationKind.Composite, multiplicity: "0..*", typeKind: TypeKind.Object, defaultValue: "", typeName: "NameAlias")]
        public List<NameAlias> Abbreviations { get; set; }

        /// <summary>
        /// Gets or sets the referenced <see cref="RecognizedPhraseDuplicateNameError"/>
        /// </summary>
        [Description("")]
        [Property(name: "DuplicateNameError", aggregation: AggregationKind.None, multiplicity: "0..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "RecognizedPhraseDuplicateNameError")]
        public RecognizedPhraseDuplicateNameError DuplicateNameError { get; set; }
    }
}
