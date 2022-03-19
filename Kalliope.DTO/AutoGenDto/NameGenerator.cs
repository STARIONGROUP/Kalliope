// -------------------------------------------------------------------------------------------------
// <copyright file="NameGenerator.cs" company="RHEA System S.A.">
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

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------

namespace Kalliope.DTO
{
    using System;
    using System.Collections.Generic;

    using Kalliope.Common;

    /// <summary>
    /// A Data Transfer Object that represents a NameGenerator
    /// </summary>
    /// <remarks>
    /// Name generation settings
    /// </remarks>
    [Container(typeName: "NameGenerator", propertyName: "RefinedByGenerators")]
    public partial class NameGenerator : NameConsumer
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NameGenerator"/> class.
        /// </summary>
        public NameGenerator()
        {
            this.CasingOption = NameGeneratorCasingOption.Uninitialized;
            this.RefinedByGenerators = new List<string>();
            this.SpacingFormat = NameGeneratorSpacingFormat.Retain;
        }
 
        /// <summary>
        /// Gets or sets the unique identifier of the container
        /// </summary>
        public string Container {get; set;}
 

        /// <summary>
        /// Gets or sets a AutomaticallyShortenNames
        /// </summary>
        [Description("Specify if names generated for this context should be automatically shortened if they are too long for the generation target")]
        [Property(name: "AutomaticallyShortenNames", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Boolean, defaultValue: "false", typeName: "", allowOverride: false, isOverride: false, isDerived: false)]
        public bool AutomaticallyShortenNames { get; set; }
 
        /// <summary>
        /// Gets or sets a CasingOption
        /// </summary>
        [Description("Specify upper/lower case settings of names generated for this context")]
        [Property(name: "CasingOption", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Enumeration, defaultValue: "Uninitialized", typeName: "NameGeneratorCasingOption", allowOverride: false, isOverride: false, isDerived: false)]
        public NameGeneratorCasingOption CasingOption { get; set; }
 
        /// <summary>
        /// Gets or sets a NameUsage
        /// </summary>
        [Description("")]
        [Property(name: "NameUsage", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.String, defaultValue: "", typeName: "", allowOverride: false, isOverride: false, isDerived: false)]
        public string NameUsage { get; set; }
 
        /// <summary>
        /// Gets or sets a list unique identifiers of the contained <see cref="NameGenerator"/> instances
        /// </summary>
        [Description("")]
        [Property(name: "RefinedByGenerators", aggregation: AggregationKind.Composite, multiplicity: "0..*", typeKind: TypeKind.Object, defaultValue: "", typeName: "NameGenerator", allowOverride: false, isOverride: false, isDerived: false)]
        public List<string> RefinedByGenerators { get; set; }
 
        /// <summary>
        /// Gets or sets the unique identifier of the referenced <see cref="ORMModelElement"/>
        /// </summary>
        [Description("")]
        [Property(name: "RefinedInstance", aggregation: AggregationKind.None, multiplicity: "0..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "ORMModelElement", allowOverride: false, isOverride: false, isDerived: false)]
        public string RefinedInstance { get; set; }
 
        /// <summary>
        /// Gets or sets a SpacingFormat
        /// </summary>
        [Description("Specify if whitespace is preserved, removed, or replaced in names generated for this context")]
        [Property(name: "SpacingFormat", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Enumeration, defaultValue: "Retain", typeName: "NameGeneratorSpacingFormat", allowOverride: false, isOverride: false, isDerived: false)]
        public NameGeneratorSpacingFormat SpacingFormat { get; set; }
 
        /// <summary>
        /// Gets or sets a SpacingReplacement
        /// </summary>
        [Description("Specify the characters used instead of spaces in names generated for this context")]
        [Property(name: "SpacingReplacement", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.String, defaultValue: "", typeName: "", allowOverride: false, isOverride: false, isDerived: false)]
        public string SpacingReplacement { get; set; }
 
        /// <summary>
        /// Gets or sets a UserDefinedMaximum
        /// </summary>
        [Description("Specify a custom maximum name length for this name generation context")]
        [Property(name: "UserDefinedMaximum", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Int32, defaultValue: "", typeName: "", allowOverride: false, isOverride: false, isDerived: false)]
        public int UserDefinedMaximum { get; set; }
 
        /// <summary>
        /// Gets or sets a UseTargetDefaultMaximum
        /// </summary>
        [Description("Specify if the default maximum name length for this name generation context should be used when shortening names")]
        [Property(name: "UseTargetDefaultMaximum", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Boolean, defaultValue: "false", typeName: "", allowOverride: false, isOverride: false, isDerived: false)]
        public bool UseTargetDefaultMaximum { get; set; }
 
    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
