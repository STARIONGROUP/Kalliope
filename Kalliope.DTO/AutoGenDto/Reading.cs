// -------------------------------------------------------------------------------------------------
// <copyright file="Reading.cs" company="Starion Group S.A.">
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
    /// A Data Transfer Object that represents a Reading
    /// </summary>
    /// <remarks>
    /// Predicate text corresponding to a specific role traversal
    /// </remarks>
    [Container(typeName: "ReadingOrder", propertyName: "Readings")]
    public partial class Reading : OrmModelElement
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Reading"/> class.
        /// </summary>
        public Reading()
        {
            this.ExpandedData = new List<string>();
        }
 
        /// <summary>
        /// Gets or sets the unique identifier of the container
        /// </summary>
        public string Container {get; set;}
 

        /// <summary>
        /// Gets or sets a Data
        /// </summary>
        [Description("Reading text with numbered replacemented fields in the format {n}, where n is a zero-based index into the corresponding role traversal order. ")]
        [Property(name: "Data", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.String, defaultValue: "", typeName: "", allowOverride: false, isOverride: false, isDerived: false)]
        public string Data { get; set; }
 
        /// <summary>
        /// Gets or sets the unique identifier of the referenced <see cref="DuplicateReadingSignatureError"/>
        /// </summary>
        [Description("")]
        [Property(name: "DuplicateSignatureError", aggregation: AggregationKind.None, multiplicity: "0..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "DuplicateReadingSignatureError", allowOverride: false, isOverride: false, isDerived: false)]
        public string DuplicateSignatureError { get; set; }
 
        /// <summary>
        /// Gets or sets a list unique identifiers of the contained <see cref="RoleText"/> instances
        /// </summary>
        [Description("An expanded form of the Data element with text decoration broken down on a per-role basis. Hyphen binding constructs are fully resolved with hyphens removed")]
        [Property(name: "ExpandedData", aggregation: AggregationKind.Composite, multiplicity: "0..*", typeKind: TypeKind.Object, defaultValue: "", typeName: "RoleText", allowOverride: false, isOverride: false, isDerived: false)]
        public List<string> ExpandedData { get; set; }
 
        /// <summary>
        /// Gets or sets a IsPrimaryForFactType
        /// </summary>
        [Description("")]
        [Property(name: "IsPrimaryForFactType", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Boolean, defaultValue: "false", typeName: "", allowOverride: false, isOverride: false, isDerived: false)]
        public bool IsPrimaryForFactType { get; set; }
 
        /// <summary>
        /// Gets or sets a IsPrimaryForReadingOrder
        /// </summary>
        [Description("")]
        [Property(name: "IsPrimaryForReadingOrder", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Boolean, defaultValue: "false", typeName: "", allowOverride: false, isOverride: false, isDerived: false)]
        public bool IsPrimaryForReadingOrder { get; set; }
 
        /// <summary>
        /// Gets or sets a Language
        /// </summary>
        [Description("")]
        [Property(name: "Language", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.String, defaultValue: "", typeName: "", allowOverride: false, isOverride: false, isDerived: false)]
        public string Language { get; set; }
 
        /// <summary>
        /// Gets or sets the unique identifier of the contained <see cref="ReadingRequiresUserModificationError"/>
        /// </summary>
        [Description("")]
        [Property(name: "RequiresUserModificationError", aggregation: AggregationKind.Composite, multiplicity: "0..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "ReadingRequiresUserModificationError", allowOverride: false, isOverride: false, isDerived: false)]
        public string RequiresUserModificationError { get; set; }
 
        /// <summary>
        /// Gets or sets a Signature
        /// </summary>
        [Description("")]
        [Property(name: "Signature", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.String, defaultValue: "", typeName: "", allowOverride: false, isOverride: false, isDerived: false)]
        public string Signature { get; set; }
 
        /// <summary>
        /// Gets or sets a Text
        /// </summary>
        [Description("The text of this reading. Includes ordered replacement fields corresponding to the parent ReadingOrder")]
        [Property(name: "Text", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.String, defaultValue: "", typeName: "", allowOverride: false, isOverride: false, isDerived: false)]
        public string Text { get; set; }
 
        /// <summary>
        /// Gets or sets the unique identifier of the contained <see cref="TooFewReadingRolesError"/>
        /// </summary>
        [Description("")]
        [Property(name: "TooFewRolesError", aggregation: AggregationKind.Composite, multiplicity: "0..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "TooFewReadingRolesError", allowOverride: false, isOverride: false, isDerived: false)]
        public string TooFewRolesError { get; set; }
 
        /// <summary>
        /// Gets or sets the unique identifier of the contained <see cref="TooManyReadingRolesError"/>
        /// </summary>
        [Description("")]
        [Property(name: "TooManyRolesError", aggregation: AggregationKind.Composite, multiplicity: "0..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "TooManyReadingRolesError", allowOverride: false, isOverride: false, isDerived: false)]
        public string TooManyRolesError { get; set; }
 
    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
