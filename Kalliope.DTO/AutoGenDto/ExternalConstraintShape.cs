// -------------------------------------------------------------------------------------------------
// <copyright file="ExternalConstraintShape.cs" company="Starion Group S.A.">
//
//   Copyright 2022-2024 Starion Group S.A.
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

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------

namespace Kalliope.DTO
{
    using System;
    using System.Collections.Generic;

    using Kalliope.Common;

    /// <summary>
    /// A Data Transfer Object that represents a ExternalConstraintShape
    /// </summary>
    /// <remarks>
    /// Shape that represents a SetComparisonConstraint or a SetConstraint
    /// </remarks>
    [Container(typeName: "OrmDiagram", propertyName: "ExternalConstraintShapes")]
    public partial class ExternalConstraintShape : OrmBaseShape
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExternalConstraintShape"/> class.
        /// </summary>
        public ExternalConstraintShape()
        {
        }
 
        /// <summary>
        /// Gets or sets the unique identifier of the container
        /// </summary>
        public string Container {get; set;}
 

        /// <summary>
        /// Gets or sets the unique identifier of the referenced <see cref="OrmNamedElement"/>
        /// </summary>
        [Description("The subject SetComparisonConstraint or SetConstraint that is represented by this shape")]
        [Property(name: "Subject", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "OrmNamedElement", allowOverride: false, isOverride: false, isDerived: false)]
        public string Subject { get; set; }
 
    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
