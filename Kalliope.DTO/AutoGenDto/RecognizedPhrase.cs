// -------------------------------------------------------------------------------------------------
// <copyright file="RecognizedPhrase.cs" company="Starion Group S.A.">
//
//   Copyright 2022-2024 Starion Group S.A.
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

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------

namespace Kalliope.DTO
{
    using System;
    using System.Collections.Generic;

    using Kalliope.Common;

    /// <summary>
    /// A Data Transfer Object that represents a RecognizedPhrase
    /// </summary>
    /// <remarks>
    /// A phrase with one or more words that can be abbreviated during name generation
    /// </remarks>
    [Container(typeName: "OrmModel", propertyName: "RecognizedPhrases")]
    public partial class RecognizedPhrase : OrmNamedElement
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RecognizedPhrase"/> class.
        /// </summary>
        public RecognizedPhrase()
        {
            this.Abbreviations = new List<string>();
        }
 
        /// <summary>
        /// Gets or sets the unique identifier of the container
        /// </summary>
        public string Container {get; set;}
 

        /// <summary>
        /// Gets or sets a list unique identifiers of the contained <see cref="NameAlias"/> instances
        /// </summary>
        [Description("")]
        [Property(name: "Abbreviations", aggregation: AggregationKind.Composite, multiplicity: "0..*", typeKind: TypeKind.Object, defaultValue: "", typeName: "NameAlias", allowOverride: false, isOverride: false, isDerived: false)]
        public List<string> Abbreviations { get; set; }
 
        /// <summary>
        /// Gets or sets the unique identifier of the referenced <see cref="RecognizedPhraseDuplicateNameError"/>
        /// </summary>
        [Description("")]
        [Property(name: "DuplicateNameError", aggregation: AggregationKind.None, multiplicity: "0..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "RecognizedPhraseDuplicateNameError", allowOverride: false, isOverride: false, isDerived: false)]
        public string DuplicateNameError { get; set; }
 
    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
