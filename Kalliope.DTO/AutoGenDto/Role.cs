// -------------------------------------------------------------------------------------------------
// <copyright file="Role.cs" company="RHEA System S.A.">
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
    /// A Data Transfer Object that represents a Role
    /// </summary>
    public partial class Role : RoleBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Role"/> class.
        /// </summary>
        public Role()
        {
            this.Multiplicity = Multiplicity.Unspecified;
            this.ObjectTypeInstances = new List<string>();
        }
 
        /// <summary>
        /// Gets or sets the unique identifier of the container
        /// </summary>
        public string Container {get; set;}
 

        /// <summary>
        /// Gets or sets the unique identifier of the contained <see cref="UnaryRoleCardinalityConstraint"/>
        /// </summary>
        public string Cardinality { get; set; }
 
        /// <summary>
        /// Gets or sets the unique identifier of the referenced <see cref="CalculatedPathValue"/>
        /// </summary>
        public string DerivedFromCalculatedValue { get; set; }
 
        /// <summary>
        /// Gets or sets the unique identifier of the referenced <see cref="PathConstant"/>
        /// </summary>
        public string DerivedFromConstant { get; set; }
 
        /// <summary>
        /// Gets or sets a IsMandatory
        /// </summary>
        public bool IsMandatory { get; set; }
 
        /// <summary>
        /// Gets or sets a MandatoryConstraintModality
        /// </summary>
        public ConstraintModality MandatoryConstraintModality { get; set; }
 
        /// <summary>
        /// Gets or sets a MandatoryConstraintName
        /// </summary>
        public string MandatoryConstraintName { get; set; }
 
        /// <summary>
        /// Gets or sets a Multiplicity
        /// </summary>
        public Multiplicity Multiplicity { get; set; }
 
        /// <summary>
        /// Gets or sets a ObjectificationOppositeRoleName
        /// </summary>
        public string ObjectificationOppositeRoleName { get; set; }
 
        /// <summary>
        /// Gets or sets a list unique identifiers of the referenced <see cref="ObjectTypeInstance"/> instances
        /// </summary>
        public List<string> ObjectTypeInstances { get; set; }
 
        /// <summary>
        /// Gets or sets the unique identifier of the referenced <see cref="ObjectType"/>
        /// </summary>
        public string RolePlayer { get; set; }
 
        /// <summary>
        /// Gets or sets the unique identifier of the contained <see cref="RolePlayerRequiredError"/>
        /// </summary>
        public string RolePlayerRequiredError { get; set; }
 
        /// <summary>
        /// Gets or sets the unique identifier of the contained <see cref="RoleValueConstraint"/>
        /// </summary>
        public string ValueConstraint { get; set; }
 
        /// <summary>
        /// Gets or sets a ValueRangeText
        /// </summary>
        public string ValueRangeText { get; set; }
 
    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
