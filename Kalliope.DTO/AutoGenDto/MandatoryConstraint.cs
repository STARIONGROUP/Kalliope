// -------------------------------------------------------------------------------------------------
// <copyright file="MandatoryConstraint.cs" company="RHEA System S.A.">
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
    /// A Data Transfer Object that represents a MandatoryConstraint
    /// </summary>
    public partial class MandatoryConstraint : SetConstraint
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MandatoryConstraint"/> class.
        /// </summary>
        public  MandatoryConstraint()
        {
            this.PopulationMandatoryErrors = new List<Guid>();
        }
 
        /// <summary>
        /// Gets or sets the unique identifier of the referenced <see cref="ExclusionContradictsMandatoryError"/>
        /// </summary>
        public Guid ExclusionContradictsMandatoryError { get; set; }
 
        /// <summary>
        /// Gets or sets the unique identifier of the referenced <see cref="ExclusionConstraint"/>
        /// </summary>
        public Guid ExclusiveOrExclusionConstraint { get; set; }
 
        /// <summary>
        /// Gets or sets a IsImplied
        /// </summary>
        public bool IsImplied { get; set; }
 
        /// <summary>
        /// Gets or sets a IsSimple
        /// </summary>
        public bool IsSimple { get; set; }
 
        /// <summary>
        /// Gets or sets the unique identifier of the contained <see cref="NotWellModeledSubsetAndMandatoryError"/>
        /// </summary>
        public Guid NotWellModeledSubsetAndMandatoryError { get; set; }
 
        /// <summary>
        /// Gets or sets a list unique identifiers of the contained <see cref="PopulationMandatoryError"/> instances
        /// </summary>
        public List<Guid> PopulationMandatoryErrors { get; set; }
 
    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
