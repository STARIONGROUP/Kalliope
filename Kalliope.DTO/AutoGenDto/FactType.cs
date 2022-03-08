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
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
 
namespace Kalliope.DTO
{
    using System;
    using System.Collections.Generic;
 
    using Kalliope.Common;
 
    /// <summary>
    /// A Data Transfer Object that represents a FactType
    /// </summary>
    [Container(typeName: "Objectification", propertyName: "ImpliedFactTypes")]
    [Container(typeName: "ORMModel", propertyName: "FactTypes")]
    public partial class FactType : ORMModelElement
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FactType"/> class.
        /// </summary>
        public FactType()
        {
            this.FactTypeInstances = new List<string>();
            this.ReadingOrders = new List<string>();
            this.Roles = new List<string>();
        }
 
        /// <summary>
        /// Gets or sets the unique identifier of the container
        /// </summary>
        public string Container {get; set;}
 

        /// <summary>
        /// Gets or sets the unique identifier of the contained <see cref="Definition"/>
        /// </summary>
        public string Definition { get; set; }
 
        /// <summary>
        /// Gets or sets the unique identifier of the contained <see cref="FactTypeDerivationExpression"/>
        /// </summary>
        public string DerivationExpression { get; set; }
 
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
        public List<string> FactTypeInstances { get; set; }
 
        /// <summary>
        /// Gets or sets the unique identifier of the contained <see cref="ImpliedInternalUniquenessConstraintError"/>
        /// </summary>
        public string ImpliedInternalUniquenessConstraintError { get; set; }
 
        /// <summary>
        /// Gets or sets the unique identifier of the contained <see cref="FactTypeRequiresInternalUniquenessConstraintError"/>
        /// </summary>
        public string InternalUniquenessConstraintRequiredError { get; set; }
 
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
        public string Note { get; set; }
 
        /// <summary>
        /// Gets or sets a list unique identifiers of the contained <see cref="ReadingOrder"/> instances
        /// </summary>
        public List<string> ReadingOrders { get; set; }
 
        /// <summary>
        /// Gets or sets the unique identifier of the contained <see cref="FactTypeRequiresReadingError"/>
        /// </summary>
        public string ReadingRequiredError { get; set; }
 
        /// <summary>
        /// Gets or sets a list unique identifiers of the contained <see cref="RoleBase"/> instances
        /// </summary>
        public List<string> Roles { get; set; }
 
    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
