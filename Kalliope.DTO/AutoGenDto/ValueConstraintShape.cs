// -------------------------------------------------------------------------------------------------
// <copyright file="ValueConstraintShape.cs" company="RHEA System S.A.">
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
    /// A Data Transfer Object that represents a ValueConstraintShape
    /// </summary>
    /// <remarks>
    /// Shape that represents a RoleValueConstraint or a ValueTypeValueConstraint
    /// </remarks>
    [Container(typeName: "ObjectTypeShape", propertyName: "ValueConstraintShapes")]
    public partial class ValueConstraintShape : FloatingTextShape
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ValueConstraintShape"/> class.
        /// </summary>
        public ValueConstraintShape()
        {
        }
 
        /// <summary>
        /// Gets or sets the unique identifier of the container
        /// </summary>
        public string Container {get; set;}
 

        /// <summary>
        /// Gets or sets a MaximumDisplayedColumns
        /// </summary>
        public int MaximumDisplayedColumns { get; set; }
 
        /// <summary>
        /// Gets or sets a MaximumDisplayedValues
        /// </summary>
        public int MaximumDisplayedValues { get; set; }
 
        /// <summary>
        /// Gets or sets the unique identifier of the referenced <see cref="ValueConstraint"/>
        /// </summary>
        public string Subject { get; set; }
 
    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
