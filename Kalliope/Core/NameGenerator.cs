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

namespace Kalliope.Core
{
    using System.Collections.Generic;

    using Kalliope.Common;

    /// <summary>
    /// Name generation settings
    /// </summary>
    [Description("Name generation settings")]
    [Domain(isAbstract: false, general: "NameConsumer")]
    [Container("NameGenerator", "RefinedByGenerators")]
    public class NameGenerator : NameConsumer
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NameGenerator"/> class.
        /// </summary>
        public NameGenerator()
        {
            this.CasingOption = NameGeneratorCasingOption.Uninitialized;
            this.SpacingFormat = NameGeneratorSpacingFormat.Retain;
            this.SpacingReplacement = string.Empty;
            this.AutomaticallyShortenNames = true;
            this.UserDefinedMaximum = 128;
            this.UseTargetDefaultMaximum = true;

            this.RefinedByGenerators = new List<NameGenerator>();
        }

        /// <summary>
        /// Specify casing modifications for name parts and combinations.
        /// If not specified, the default CasingOption is the value from the nearest refining parent with this attribute. The root default is None
        /// </summary>
        /// <remarks>
        /// (DSL) Specify upper/lower case settings of names generated for this context
        /// </remarks>
        [Description("Specify upper/lower case settings of names generated for this context")]
        [Property(name: "CasingOption", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Enumeration, defaultValue: "Uninitialized", typeName: "NameGeneratorCasingOption")]
        public NameGeneratorCasingOption CasingOption { get; set; }

        /// <summary>
        /// Specify how name spaces are treated during name generation.
        /// If not specified, the default SpacingFormat is the value from the nearest refining parent with this attribute. The root default is Retain
        /// </summary>
        /// <remarks>
        /// (DSL) Specify if whitespace is preserved, removed, or replaced in names generated for this context
        /// </remarks>
        [Description("Specify if whitespace is preserved, removed, or replaced in names generated for this context")]
        [Property(name: "SpacingFormat", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Enumeration, defaultValue: "Retain", typeName: "NameGeneratorSpacingFormat")]
        public NameGeneratorSpacingFormat SpacingFormat { get; set; }

        /// <summary>
        /// The string used in place of spaces when the SpacingFormat attribute is ReplaceWith.
        /// If not specified, the default SpacingReplacement is the value from the nearest refining parent with this attribute. The root default is an empty string
        /// </summary>
        /// <remarks>
        /// (DSL) Specify the characters used instead of spaces in names generated for this context
        /// </remarks>
        [Description("Specify the characters used instead of spaces in names generated for this context")]
        [Property(name: "SpacingReplacement", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.String, defaultValue: "")]
        public string SpacingReplacement { get; set; }

        /// <summary>
        /// The usage associated with this Name Generator
        /// </summary>
        [Description("")]
        [Property(name: "NameUsage", AggregationKind.None, multiplicity: "1..1", typeKind:TypeKind.String)]
        public string NameUsage { get; set; }

        /// <summary>
        /// Whether the name generation system should automatically shorten names if they exceed the max length.
        /// If not specified, the default AutomaticallyShortenNames is the value from the nearest refining parent with this attribute. The root default is true
        /// </summary>
        /// <remarks>
        /// (DSL) Specify if names generated for this context should be automatically shortened if they are too long for the generation target
        /// </remarks>
        [Description("Specify if names generated for this context should be automatically shortened if they are too long for the generation target")]
        [Property(name: "AutomaticallyShortenNames", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Boolean, defaultValue: "false")]
        public bool AutomaticallyShortenNames { get; set; }

        /// <summary>
        /// The maximum name length set by user if <see cref="UseTargetDefaultMaximum"/> is false.
        /// If not specified, the default UserDefinedMaximum is the value from the nearest refining parent with this attribute. The root default is 128
        /// </summary>
        /// <remarks>
        /// (DSL) Specify a custom maximum name length for this name generation context
        /// </remarks>
        [Description("Specify a custom maximum name length for this name generation context")]
        [Property(name: "UserDefinedMaximum", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Int32, defaultValue: "")]
        public int UserDefinedMaximum { get; set; }

        /// <summary>
        /// The maximum name length set by user if AutomaticallyShortenNames is set.
        /// If not specified, the default UseTargetDefaultMaximum is the value from the nearest refining parent with this attribute. The root default is true
        /// </summary>
        /// <remarks>
        /// (DSL) Specify if the default maximum name length for this name generation context should be used when shortening names
        /// </remarks>
        [Description("Specify if the default maximum name length for this name generation context should be used when shortening names")]
        [Property(name: "UseTargetDefaultMaximum", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Boolean, defaultValue: "false")]
        public bool UseTargetDefaultMaximum { get; set; }

        /// <summary>
        /// Gets or sets the contained <see cref="NameGenerator"/>s that are refined by the current <see cref="NameGenerator"/>
        /// </summary>
        [Description("")]
        [Property(name: "RefinedByGenerators", aggregation: AggregationKind.Composite, multiplicity: "0..*", typeKind: TypeKind.Object, defaultValue: "NameGenerator")]
        public List<NameGenerator> RefinedByGenerators { get; set; }

        /// <summary>
        /// Gets or sets the referenced <see cref="ORMModelElement"/>
        /// </summary>
        [Description("")]
        [Property(name: "RefinedInstance", aggregation: AggregationKind.None, multiplicity: "0..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "ORMModelElement")]
        public ORMModelElement RefinedInstance { get; set; }
    }
}
