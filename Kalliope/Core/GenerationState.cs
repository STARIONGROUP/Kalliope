// -------------------------------------------------------------------------------------------------
// <copyright file="GenerationState.cs" company="RHEA System S.A.">
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

    /// <summary>
    /// State information relating to automatic mapping algorithms
    /// </summary>
    public class GenerationState
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GenerationState"/> class.
        /// </summary>
        public GenerationState()
        {
            this.GenerationSettings = new List<GenerationSetting>();
        }

        /// <summary>
        /// A unique identifier for this element
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the contained <see cref="GenerationSetting"/>s
        /// </summary>
        public List<GenerationSetting> GenerationSettings { get; set; }

        /// <summary>
        /// Generates a <see cref="NameGenerator"/> object from its XML representation.
        /// </summary>
        /// <param name="reader">
        /// an instance of <see cref="XmlReader"/> used to read the .orm file
        /// </param>
        internal void ReadXml(XmlReader reader)
        {
            this.Id = reader.GetAttribute("id");
        }
    }
}
