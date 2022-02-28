// -------------------------------------------------------------------------------------------------
// <copyright file="CardinalityConstraint.cs" company="RHEA System S.A.">
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
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
 
namespace Kalliope.DTO
{
    using System;
    using System.Collections.Generic;
 
    using Kalliope.Common;
 
    /// <summary>
    /// A Data Transfer Object that represents a CardinalityConstraint
    /// </summary>
    public abstract partial class CardinalityConstraint : ORMNamedElement
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CardinalityConstraint"/> class.
        /// </summary>
        protected CardinalityConstraint()
        {
            this.Modality = ConstraintModality.Alethic;
            this.Ranges = new List<string>();
        }
 

        /// <summary>
        /// Gets or sets the unique identifier of the contained <see cref="CardinalityRangeOverlapError"/>
        /// </summary>
        public string CardinalityRangeOverlapError { get; set; }
 
        /// <summary>
        /// Gets or sets the unique identifier of the contained <see cref="Definition"/>
        /// </summary>
        public string Definition { get; set; }
 
        /// <summary>
        /// Gets or sets the unique identifier of the referenced <see cref="ConstraintDuplicateNameError"/>
        /// </summary>
        public string DuplicateNameError { get; set; }
 
        /// <summary>
        /// Gets or sets a Modality
        /// </summary>
        public ConstraintModality Modality { get; set; }
 
        /// <summary>
        /// Gets or sets the unique identifier of the contained <see cref="Note"/>
        /// </summary>
        public string Note { get; set; }
 
        /// <summary>
        /// Gets or sets a list unique identifiers of the contained <see cref="CardinalityRange"/> instances
        /// </summary>
        public List<string> Ranges { get; set; }
 
        /// <summary>
        /// Gets or sets a Text
        /// </summary>
        public string Text { get; set; }
 
    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
