﻿// -------------------------------------------------------------------------------------------------
// <copyright file="ReferenceModeNaming.cs" company="RHEA System S.A.">
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
    /// Reference mode naming options for a specific object type. Used by extension models, which must add their own reference to the modified object type
    /// </summary>
    public abstract class ReferenceModeNaming
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReferenceModeNaming"/> class.
        /// </summary>
        public ReferenceModeNaming()
        {
            this.NamingChoice = NamingChoice.ModelDefault;
            this.PrimaryIdentifierNamingChoice = NamingChoice.ModelDefault;
        }

        /// <summary>
        /// A unique identifier for this element
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Specify how a reference to a reference-mode identified instance is to be represented
        /// </summary>
        public NamingChoice NamingChoice { get; set; }

        /// <summary>
        /// Specify how the primary identifier of a reference-mode identified instance is to be represented
        /// </summary>
        public NamingChoice PrimaryIdentifierNamingChoice { get; set; }

        /// <summary>
        /// May be set if NamingChoice is CustomFormat.
        /// The replacement field {0} is the ValueTypeName, {1} is the EntityTypeName, and {2} is the ReferenceModeName
        /// </summary>
        public string CustomFormat { get; set; }

        /// <summary>
        /// May be set if PrimaryIdentifierNamingChoice is CustomFormat.
        /// The replacement field {0} is the ValueTypeName, {1} is the EntityTypeName, and {2} is the ReferenceModeName
        /// </summary>
        public string PrimaryIdentifierCustomFormat { get; set; }
    }
}
