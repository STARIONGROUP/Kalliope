// -------------------------------------------------------------------------------------------------
// <copyright file="ObjectTypeShape.cs" company="RHEA System S.A.">
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
    /// A Data Transfer Object that represents a ObjectTypeShape
    /// </summary>
    /// <remarks>
    /// Shape that represents an ObjectType
    /// </remarks>
    public partial class ObjectTypeShape : ORMBaseShape
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectTypeShape"/> class.
        /// </summary>
        public  ObjectTypeShape()
        {
            this.CardinalityConstraintShapes = new List<Guid>();
            this.ValueConstraintShapes = new List<Guid>();
        }
 
        /// <summary>
        /// Gets or sets a list unique identifiers of the contained <see cref="CardinalityConstraintShape"/> instances
        /// </summary>
        public List<Guid> CardinalityConstraintShapes { get; set; }
 
        /// <summary>
        /// Gets or sets a DisplayRelatedTypes
        /// </summary>
        public RelatedTypesDisplay DisplayRelatedTypes { get; set; }
 
        /// <summary>
        /// Gets or sets a ExpandRefMode
        /// </summary>
        public bool ExpandRefMode { get; set; }
 
        /// <summary>
        /// Gets or sets the unique identifier of the referenced <see cref="ObjectType"/>
        /// </summary>
        public Guid Subject { get; set; }
 
        /// <summary>
        /// Gets or sets a list unique identifiers of the contained <see cref="ValueConstraintShape"/> instances
        /// </summary>
        public List<Guid> ValueConstraintShapes { get; set; }
 
    }
}