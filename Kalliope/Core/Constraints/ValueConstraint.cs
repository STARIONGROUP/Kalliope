// -------------------------------------------------------------------------------------------------
// <copyright file="ValueConstraint.cs" company="RHEA System S.A.">
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

    /// <summary>
    /// A constraint limiting the set of allowed values
    /// </summary>
    public class ValueConstraint : ORMNamedElement
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ValueConstraint"/> class
        /// </summary>
        public ValueConstraint()
        {
            this.ValueRanges = new List<ValueRange>();
        }

        /// <summary>
        /// An informal description of this constraint.
        /// To insert new lines, use Control-Enter in the dropdown editor, or open the 'ORM Informal Description Editor' tool window.
        /// </summary>
        public string DefinitionText { get; set; }

        /// <summary>
        /// A note to associate with this constraint.
        /// To insert new lines, use Control-Enter in the dropdown editor, or open the 'ORM Notes Editor' tool window
        /// </summary>
        public string NoteText { get; set; }

        /// <summary>
        /// The range of possible values.
        /// To specify a range, use '..' between the range endpoints, square brackets to specify a closed endpoint, and parentheses to specify an open endpoint. Commas are used to entered multiple ranges or discrete values.
        /// Example: {[10..20), 30} specifies all values between 10 and 20 (but not including 20) and the value 30
        /// </summary>
        public string Text { get; set; }

        public int TextChanged { get; set; }

        /// <summary>
        /// Gets or sets the contained <see cref="ValueRange"/>s
        /// </summary>
        public List<ValueRange> ValueRanges { get; set; }
    }
}
