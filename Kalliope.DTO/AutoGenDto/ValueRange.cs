// -------------------------------------------------------------------------------------------------
// <copyright file="ValueRange.cs" company="RHEA System S.A.">
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
    /// A Data Transfer Object that represents a ValueRange
    /// </summary>
    public partial class ValueRange : ORMModelElement
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ValueRange"/> class.
        /// </summary>
        public ValueRange()
        {
            this.MaxInclusion = RangeInclusion.NotSet;
            this.MinInclusion = RangeInclusion.NotSet;
        }
 
        /// <summary>
        /// Gets or sets the unique identifier of the container
        /// </summary>
        public string Container {get; set;}
 

        /// <summary>
        /// Gets or sets a InvariantMaxValue
        /// </summary>
        public string InvariantMaxValue { get; set; }
 
        /// <summary>
        /// Gets or sets a InvariantMinValue
        /// </summary>
        public string InvariantMinValue { get; set; }
 
        /// <summary>
        /// Gets or sets a MaxInclusion
        /// </summary>
        public RangeInclusion MaxInclusion { get; set; }
 
        /// <summary>
        /// Gets or sets a MaxValue
        /// </summary>
        public string MaxValue { get; set; }
 
        /// <summary>
        /// Gets or sets the unique identifier of the contained <see cref="MaxValueMismatchError"/>
        /// </summary>
        public string MaxValueMismatchError { get; set; }
 
        /// <summary>
        /// Gets or sets a MinInclusion
        /// </summary>
        public RangeInclusion MinInclusion { get; set; }
 
        /// <summary>
        /// Gets or sets a MinValue
        /// </summary>
        public string MinValue { get; set; }
 
        /// <summary>
        /// Gets or sets the unique identifier of the contained <see cref="MinValueMismatchError"/>
        /// </summary>
        public string MinValueMismatchError { get; set; }
 
    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
