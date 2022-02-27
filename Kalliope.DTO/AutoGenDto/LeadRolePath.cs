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
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
 
namespace Kalliope.DTO
{
    using System;
    using System.Collections.Generic;
 
    using Kalliope.Common;
 
    /// <summary>
    /// A Data Transfer Object that represents a LeadRolePath
    /// </summary>
    /// <remarks>
    /// A top level role path starting at a root object type. Provides a context for subpaths, functions, and constraints specific to this path
    /// </remarks>
    public partial class LeadRolePath : RolePath
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LeadRolePath"/> class.
        /// </summary>
        public  LeadRolePath()
        {
            this.CalculatedValues = new List<Guid>();
            this.ObjectUnifiers = new List<Guid>();
            this.ProjectedPathComponents = new List<Guid>();
        }
 
        /// <summary>
        /// Gets or sets a list unique identifiers of the contained <see cref="CalculatedPathValue"/> instances
        /// </summary>
        public List<Guid> CalculatedValues { get; set; }
 
        /// <summary>
        /// Gets or sets the unique identifier of the contained <see cref="Note"/>
        /// </summary>
        public Guid Note { get; set; }
 
        /// <summary>
        /// Gets or sets a list unique identifiers of the contained <see cref="PathObjectUnifier"/> instances
        /// </summary>
        public List<Guid> ObjectUnifiers { get; set; }
 
        /// <summary>
        /// Gets or sets a list unique identifiers of the referenced <see cref="LeadRolePath"/> instances
        /// </summary>
        public List<Guid> ProjectedPathComponents { get; set; }
 
    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
