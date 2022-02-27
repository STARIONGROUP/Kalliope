// -------------------------------------------------------------------------------------------------
// <copyright file="FactType.cs" company="RHEA System S.A.">
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
    /// A Data Transfer Object that represents a FactType
    /// </summary>
    public partial class FactType : ORMModelElement
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FactType"/> class.
        /// </summary>
        public  FactType()
        {
            this.FactTypeInstances = new List<Guid>();
            this.ReadingOrders = new List<Guid>();
            this.Roles = new List<Guid>();
        }
 
        /// <summary>
        /// Gets or sets the unique identifier of the contained <see cref="Definition"/>
        /// </summary>
        public Guid Definition { get; set; }
 
        /// <summary>
        /// Gets or sets the unique identifier of the contained <see cref="FactTypeDerivationExpression"/>
        /// </summary>
        public Guid DerivationExpression { get; set; }
 
        /// <summary>
        /// Gets or sets a DerivationNoteDisplay
        /// </summary>
        public string DerivationNoteDisplay { get; set; }
 
        /// <summary>
        /// Gets or sets a DerivationRule
        /// </summary>
        public string DerivationRule { get; set; }
 
        /// <summary>
        /// Gets or sets a DerivationStorageDisplay
        /// </summary>
        public DerivationExpressionStorageType DerivationStorageDisplay { get; set; }
 
        /// <summary>
        /// Gets or sets a list unique identifiers of the contained <see cref="FactTypeInstance"/> instances
        /// </summary>
        public List<Guid> FactTypeInstances { get; set; }
 
        /// <summary>
        /// Gets or sets the unique identifier of the contained <see cref="ImpliedInternalUniquenessConstraintError"/>
        /// </summary>
        public Guid ImpliedInternalUniquenessConstraintError { get; set; }
 
        /// <summary>
        /// Gets or sets the unique identifier of the contained <see cref="FactTypeRequiresInternalUniquenessConstraintError"/>
        /// </summary>
        public Guid InternalUniquenessConstraintRequiredError { get; set; }
 
        /// <summary>
        /// Gets or sets a IsExternal
        /// </summary>
        public bool IsExternal { get; set; }
 
        /// <summary>
        /// Gets or sets a Name
        /// </summary>
        public string Name { get; set; }
 
        /// <summary>
        /// Gets or sets the unique identifier of the contained <see cref="Note"/>
        /// </summary>
        public Guid Note { get; set; }
 
        /// <summary>
        /// Gets or sets a list unique identifiers of the contained <see cref="ReadingOrder"/> instances
        /// </summary>
        public List<Guid> ReadingOrders { get; set; }
 
        /// <summary>
        /// Gets or sets the unique identifier of the contained <see cref="FactTypeRequiresReadingError"/>
        /// </summary>
        public Guid ReadingRequiredError { get; set; }
 
        /// <summary>
        /// Gets or sets a list unique identifiers of the contained <see cref="RoleBase"/> instances
        /// </summary>
        public List<Guid> Roles { get; set; }
 
    }
}
