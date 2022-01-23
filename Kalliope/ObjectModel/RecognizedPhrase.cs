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

namespace Kalliope.ObjectModel
{
    /// <summary>
    /// A phrase with one or more words that can be abbreviated during name generation
    /// </summary>
    public class RecognizedPhrase
    {
        /// <summary>
        /// A unique identifier for this element
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// A recognized word or phrase to map to a different text value during name generation.
        /// Generally a common word such as 'has' or 'the'. Allows mapping to an empty alias value
        /// </summary>
        public string Name { get; set; }
    }
}
