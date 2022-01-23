// -------------------------------------------------------------------------------------------------
// <copyright file="LeadRolePath.cs" company="RHEA System S.A.">
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
    /// A role path starting from a root object type
    /// </summary>
    /// <remarks>
    /// (DSL) A top level role path starting at a root object type. Provides a context for subpaths, functions, and constraints specific to this path
    /// </remarks>
    public class LeadRolePath : RolePath
    {
        /// <summary>
        /// A note to associate with this path.
        /// To insert new lines, use Control-Enter in the dropdown editor, or open the 'ORM Notes Editor' tool window
        /// </summary>
        public string NoteText { get; set; }
    }
}
