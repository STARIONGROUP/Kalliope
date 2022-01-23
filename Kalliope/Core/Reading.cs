// -------------------------------------------------------------------------------------------------
// <copyright file="Reading.cs" company="RHEA System S.A.">
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
    /// Predicate text corresponding to a specific role traversal
    /// </summary>
    public class Reading : ORMModelElement
    {
        /// <summary>
        /// Reading text with numbered replacemented fields in the format {n}, where n is a zero-based index into the corresponding role traversal order. 
        /// n is also strictly increasing, so the first replacement field corresponds to the first role, etc. 
        /// Reading text also includes hyphen-binding specifications, where 'WORD- ' (or ' -WORD') binds WORD and all intermediate words to the nearest right (left) placeholder. 
        /// To enable hyphen binding with no space before the role player, 'WORD-- ROLEPLAYER' collapses the trailing space, resulting in 'WORD-ROLEPLAYER'. 
        /// 'WORD- ROLEPLAYER' can be achived with two hyphens and two spaces
        /// </summary>
        public string Data { get; set; }

        /// <summary>
        /// Text that occurs before the lead role, including prebound text associated with that role
        /// </summary>
        public string FrontText { get; set; }

        /// <summary>
        /// The text of this reading. Includes ordered replacement fields corresponding to the parent ReadingOrder
        /// </summary>
        public string Text { get; set; }

        public string Signature { get; set; }

        public bool IsPrimaryForReadingOrder { get; set; }

        public string Language { get; set; }

        public bool IsPrimaryForFactType { get; set; }
    }
}
