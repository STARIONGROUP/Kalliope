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
    /// <summary>
    /// Name generation settings
    /// </summary>
    public class NameGenerator : NameConsumer
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NameGenerator"/> class.
        /// </summary>
        public NameGenerator()
        {
            this.CasingOption = NameGeneratorCasingOption.None;
            this.SpacingFormat = NameGeneratorSpacingFormat.Retain;
            this.SpacingReplacement = string.Empty;
            this.AutomaticallyShortenNames = true;
            this.UserDefinedMaximum = 128;
            this.UseTargetDefaultMaximum = true;
        }

        /// <summary>
        /// Specify casing modifications for name parts and combinations.
        /// If not specified, the default CasingOption is the value from the nearest refining parent with this attribute. The root default is None
        /// </summary>
        /// <remarks>
        /// (DSL) Specify upper/lower case settings of names generated for this context
        /// </remarks>
        public NameGeneratorCasingOption CasingOption { get; set; }

        /// <summary>
        /// Specify how name spaces are treated during name generation.
        /// If not specified, the default SpacingFormat is the value from the nearest refining parent with this attribute. The root default is Retain
        /// </summary>
        /// <remarks>
        /// (DSL) Specify if whitespace is preserved, removed, or replaced in names generated for this context
        /// </remarks>
        public NameGeneratorSpacingFormat SpacingFormat { get; set; }

        /// <summary>
        /// The string used in place of spaces when the SpacingFormat attribute is ReplaceWith.
        /// If not specified, the default SpacingReplacement is the value from the nearest refining parent with this attribute. The root default is an empty string
        /// </summary>
        /// <remarks>
        /// (DSL) Specify the characters used instead of spaces in names generated for this context
        /// </remarks>
        public string SpacingReplacement { get; set; }

        /// <summary>
        /// The usage associated with this Name Generator
        /// </summary>
        public string NameUsage { get; set; }

        /// <summary>
        /// Whether the name generation system should automatically shorten names if they exceed the max length.
        /// If not specified, the default AutomaticallyShortenNames is the value from the nearest refining parent with this attribute. The root default is true
        /// </summary>
        /// <remarks>
        /// (DSL) Specify if names generated for this context should be automatically shortened if they are too long for the generation target
        /// </remarks>
        public bool AutomaticallyShortenNames { get; set; }

        /// <summary>
        /// The maximum name length set by user if <see cref="UseTargetDefaultMaximum"/> is false.
        /// If not specified, the default UserDefinedMaximum is the value from the nearest refining parent with this attribute. The root default is 128
        /// </summary>
        /// <remarks>
        /// (DSL) Specify a custom maximum name length for this name generation context
        /// </remarks>
        public int UserDefinedMaximum { get; set; }

        /// <summary>
        /// The maximum name length set by user if AutomaticallyShortenNames is set.
        /// If not specified, the default UseTargetDefaultMaximum is the value from the nearest refining parent with this attribute. The root default is true
        /// </summary>
        /// <remarks>
        /// (DSL) Specify if the default maximum name length for this name generation context should be used when shortening names
        /// </remarks>
        public bool UseTargetDefaultMaximum { get; set; }
    }
}
