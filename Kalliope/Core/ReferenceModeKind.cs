// -------------------------------------------------------------------------------------------------
// <copyright file="ReferenceModeKind.cs" company="RHEA System S.A.">
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
    /// Setting for a specific kind of reference mode pattern
    /// </summary>
    public class ReferenceModeKind : ORMModelElement
    {
        /// <summary>
        /// A string with replacement fields representing a custom format for a value type name based on the entity type name (replacement field {0}) 
        /// and reference mode name (replacement field {1}). Given an entity type name and a value type name, reference mode FormatStrings are used to 
        /// determine the associated reference mode and reference mode kind
        /// </summary>
        public string FormatString { get; set; }
    }
}
