// -------------------------------------------------------------------------------------------------
// <copyright file="NameAlias.cs" company="RHEA System S.A.">
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
    /// An alternative name for the containing named element
    /// </summary>
    public class NameAlias : ORMNamedElement
    {
        /// <summary>
        /// The type of consumer for this form of the name. NameConsumer types are provided by extension models
        /// </summary>
        public string NameConsumer { get; set; }

        /// <summary>
        /// Additional extension-provided categorization type for how a name should be used
        /// </summary>
        public string NameUsage { get; set; }
    }
}
