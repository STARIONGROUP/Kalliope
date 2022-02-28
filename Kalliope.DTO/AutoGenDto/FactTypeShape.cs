// -------------------------------------------------------------------------------------------------
// <copyright file="FactTypeShape.cs" company="RHEA System S.A.">
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
    /// A Data Transfer Object that represents a FactTypeShape
    /// </summary>
    /// <remarks>
    /// Shape that represents a FactType
    /// </remarks>
    public partial class FactTypeShape : ORMBaseShape
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FactTypeShape"/> class.
        /// </summary>
        public FactTypeShape()
        {
            this.CardinalityConstraintShapes = new List<string>();
            this.ConstraintDisplayPosition = ConstraintDisplayPosition.Top;
            this.DisplayOrientation = DisplayOrientation.Horizontal;
            this.DisplayRelatedTypes = RelatedTypesDisplay.AttachAllTypes;
            this.DisplayRoleNames = DisplayRoleNames.UserDefault;
            this.ObjectifiedFactTypeNameShapes = new List<string>();
            this.ReadingShapes = new List<string>();
            this.RoleDisplayOrder = new List<string>();
            this.RoleNameShapes = new List<string>();
            this.ValueConstraintShapes = new List<string>();
        }
 
        /// <summary>
        /// Gets or sets the unique identifier of the container
        /// </summary>
        public string Container {get; set;}
 

        /// <summary>
        /// Gets or sets a list unique identifiers of the contained <see cref="CardinalityConstraintShape"/> instances
        /// </summary>
        public List<string> CardinalityConstraintShapes { get; set; }
 
        /// <summary>
        /// Gets or sets a ConstraintDisplayPosition
        /// </summary>
        public ConstraintDisplayPosition ConstraintDisplayPosition { get; set; }
 
        /// <summary>
        /// Gets or sets a DisplayAsObjectType
        /// </summary>
        public bool DisplayAsObjectType { get; set; }
 
        /// <summary>
        /// Gets or sets a DisplayOrientation
        /// </summary>
        public DisplayOrientation DisplayOrientation { get; set; }
 
        /// <summary>
        /// Gets or sets a DisplayRelatedTypes
        /// </summary>
        public RelatedTypesDisplay DisplayRelatedTypes { get; set; }
 
        /// <summary>
        /// Gets or sets a DisplayRoleNames
        /// </summary>
        public DisplayRoleNames DisplayRoleNames { get; set; }
 
        /// <summary>
        /// Gets or sets a ExpandRefMode
        /// </summary>
        public bool ExpandRefMode { get; set; }
 
        /// <summary>
        /// Gets or sets a list unique identifiers of the contained <see cref="ObjectTypeShape"/> instances
        /// </summary>
        public List<string> ObjectifiedFactTypeNameShapes { get; set; }
 
        /// <summary>
        /// Gets or sets a list unique identifiers of the contained <see cref="ReadingShape"/> instances
        /// </summary>
        public List<string> ReadingShapes { get; set; }
 
        /// <summary>
        /// Gets or sets a list unique identifiers of the referenced <see cref="RoleBase"/> instances
        /// </summary>
        public List<string> RoleDisplayOrder { get; set; }
 
        /// <summary>
        /// Gets or sets a list unique identifiers of the contained <see cref="RoleNameShape"/> instances
        /// </summary>
        public List<string> RoleNameShapes { get; set; }
 
        /// <summary>
        /// Gets or sets the unique identifier of the referenced <see cref="FactType"/>
        /// </summary>
        public string Subject { get; set; }
 
        /// <summary>
        /// Gets or sets a list unique identifiers of the contained <see cref="ValueConstraintShape"/> instances
        /// </summary>
        public List<string> ValueConstraintShapes { get; set; }
 
    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
