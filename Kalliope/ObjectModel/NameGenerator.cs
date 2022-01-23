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

namespace Kalliope.ObjectModel
{
    /// <summary>
    /// Name generation settings
    /// </summary>
    public class NameGenerator
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NameGenerator"/> class.
        /// </summary>
        public NameGenerator()
        {
            this.CasingOption = CasingOption.None;
            this.SpacingFormat = SpacingFormat.Retain;
            this.SpacingReplacement = string.Empty;
            this.AutomaticallyShortenNames = true;
            this.UserDefinedMaximum = 128;
            this.UseTargetDefaultMaximum = true;
        }

        /// <summary>
        /// A unique identifier for this element
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Specify casing modifications for name parts and combinations.
        /// If not specified, the default CasingOption is the value from the nearest refining parent with this attribute. The root default is None
        /// </summary>
        public CasingOption CasingOption { get; set; }

        /// <summary>
        /// Specify how name spaces are treated during name generation.
        /// If not specified, the default SpacingFormat is the value from the nearest refining parent with this attribute. The root default is Retain
        /// </summary>
        public SpacingFormat SpacingFormat { get; set; }

        /// <summary>
        /// The string used in place of spaces when the SpacingFormat attribute is ReplaceWith.
        /// If not specified, the default SpacingReplacement is the value from the nearest refining parent with this attribute. The root default is an empty string
        /// </summary>
        public string SpacingReplacement { get; set; }

        /// <summary>
        /// The usage associated with this Name Generator
        /// </summary>
        public string NameUsage { get; set; }

        /// <summary>
        /// Whether the name generation system should automatically shorten names if they exceed the max length.
        /// If not specified, the default AutomaticallyShortenNames is the value from the nearest refining parent with this attribute. The root default is true
        /// </summary>
        public bool AutomaticallyShortenNames { get; set; }

        /// <summary>
        /// The maximum name length set by user if UseTargetDefaultMaximum is false.
        /// If not specified, the default UserDefinedMaximum is the value from the nearest refining parent with this attribute. The root default is 128
        /// </summary>
        public int UserDefinedMaximum { get; set; }

        /// <summary>
        /// The maximum name length set by user if AutomaticallyShortenNames is set.
        /// If not specified, the default UseTargetDefaultMaximum is the value from the nearest refining parent with this attribute. The root default is true
        /// </summary>
        public bool UseTargetDefaultMaximum { get; set; }
    }
}
