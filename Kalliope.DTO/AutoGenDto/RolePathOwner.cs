// -------------------------------------------------------------------------------------------------
// <copyright file="RolePathOwner.cs" company="RHEA System S.A.">
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
    /// A Data Transfer Object that represents a RolePathOwner
    /// </summary>
    /// <remarks>
    /// An abstract owner for one or more path objects
    /// </remarks>
    public abstract partial class RolePathOwner : ORMModelElement
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RolePathOwner"/> class.
        /// </summary>
        protected  RolePathOwner()
        {
            this.CalculatedConditions = new List<Guid>();
            this.LeadRolePaths = new List<Guid>();
            this.OwnedLeadRolePaths = new List<Guid>();
            this.OwnedSubqueries = new List<Guid>();
            this.SharedLeadRolePaths = new List<Guid>();
            this.SharedSubqueries = new List<Guid>();
            this.Subqueries = new List<Guid>();
        }
 
        /// <summary>
        /// Gets or sets a list unique identifiers of the referenced <see cref="CalculatedPathValue"/> instances
        /// </summary>
        public List<Guid> CalculatedConditions { get; set; }
 
        /// <summary>
        /// Gets or sets a list unique identifiers of the contained <see cref="LeadRolePath"/> instances
        /// </summary>
        public List<Guid> LeadRolePaths { get; set; }
 
        /// <summary>
        /// Gets or sets a list unique identifiers of the referenced <see cref="LeadRolePath"/> instances
        /// </summary>
        public List<Guid> OwnedLeadRolePaths { get; set; }
 
        /// <summary>
        /// Gets or sets a list unique identifiers of the referenced <see cref="Subquery"/> instances
        /// </summary>
        public List<Guid> OwnedSubqueries { get; set; }
 
        /// <summary>
        /// Gets or sets the unique identifier of the referenced <see cref="LeadRolePath"/>
        /// </summary>
        public Guid PathComponent { get; set; }
 
        /// <summary>
        /// Gets or sets a list unique identifiers of the referenced <see cref="LeadRolePath"/> instances
        /// </summary>
        public List<Guid> SharedLeadRolePaths { get; set; }
 
        /// <summary>
        /// Gets or sets a list unique identifiers of the referenced <see cref="Subquery"/> instances
        /// </summary>
        public List<Guid> SharedSubqueries { get; set; }
 
        /// <summary>
        /// Gets or sets the unique identifier of the referenced <see cref="LeadRolePath"/>
        /// </summary>
        public Guid SingleLeadRolePath { get; set; }
 
        /// <summary>
        /// Gets or sets the unique identifier of the referenced <see cref="LeadRolePath"/>
        /// </summary>
        public Guid SingleOwnedLeadRolePath { get; set; }
 
        /// <summary>
        /// Gets or sets a list unique identifiers of the contained <see cref="Subquery"/> instances
        /// </summary>
        public List<Guid> Subqueries { get; set; }
 
    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
