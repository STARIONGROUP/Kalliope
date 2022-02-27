// -------------------------------------------------------------------------------------------------
// <copyright file="RolePath.cs" company="RHEA System S.A.">
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
    /// Indicates if the tail split in its entirety should be treated as a negation
    /// </summary>
    public  abstract partial class RolePath : ORMModelElement
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RolePath"/> class.
        /// </summary>
        protected  RolePath()
        {
            this.Roles = new List<Guid>();
            this.SplitCombinationOperator = LogicalCombinationOperator.And;
            this.SubPaths = new List<Guid>();
        }
 
        /// <summary>
        /// Gets or sets a list unique identifiers of the referenced <see cref="Role"/> instances
        /// </summary>
        public List<Guid> Roles { get; set; }
 
        /// <summary>
        /// Gets or sets the unique identifier of the referenced <see cref="ObjectType"/>
        /// </summary>
        public Guid RootObjectType { get; set; }
 
        /// <summary>
        /// Gets or sets the unique identifier of the contained <see cref="PathRequiresRootObjectTypeError"/>
        /// </summary>
        public Guid RootObjectTypeRequiredError { get; set; }
 
        /// <summary>
        /// Gets or sets a SplitCombinationOperator
        /// </summary>
        public LogicalCombinationOperator SplitCombinationOperator { get; set; }
 
        /// <summary>
        /// Gets or sets a SplitIsNegated
        /// </summary>
        public bool SplitIsNegated { get; set; }
 
        /// <summary>
        /// Gets or sets a list unique identifiers of the contained <see cref="RoleSubPath"/> instances
        /// </summary>
        public List<Guid> SubPaths { get; set; }
 
    }
}
