// -------------------------------------------------------------------------------------------------
// <copyright file="ConstraintRoleSequenceJoinPath.cs" company="RHEA System S.A.">
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

namespace Kalliope.DTO
{
    using System;
    using System.Collections.Generic;
 
    using Kalliope.Common;
 
    /// <summary>
    /// A role path defining cross fact type relationships within a constraint role sequence
    /// </summary>
    public  partial class ConstraintRoleSequenceJoinPath : RolePathOwner
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConstraintRoleSequenceJoinPath"/> class.
        /// </summary>
        public  ConstraintRoleSequenceJoinPath()
        {
            this.ProjectedPathComponents = new List<Guid>();
        }
 
        /// <summary>
        /// Gets or sets a IsAutomatic
        /// </summary>
        public bool IsAutomatic { get; set; }
 
        /// <summary>
        /// Gets or sets a list unique identifiers of the contained <see cref="LeadRolePath"/> instances
        /// </summary>
        public List<Guid> ProjectedPathComponents { get; set; }
 
        /// <summary>
        /// Gets or sets the unique identifier of the contained <see cref="ConstraintRoleSequenceJoinPathRequiresProjectionError"/>
        /// </summary>
        public Guid ProjectionRequiredError { get; set; }
 
    }
}
