// -------------------------------------------------------------------------------------------------
// <copyright file="LeadRolePath.cs" company="Starion Group S.A.">
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
    /// A Data Transfer Object that represents a LeadRolePath
    /// </summary>
    /// <remarks>
    /// A top level role path starting at a root object type. Provides a context for subpaths, functions, and constraints specific to this path
    /// </remarks>
    [Container(typeName: "ConstraintRoleSequenceJoinPath", propertyName: "ProjectedPathComponents")]
    [Container(typeName: "RolePathOwner", propertyName: "LeadRolePaths")]
    public partial class LeadRolePath : RolePath
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LeadRolePath"/> class.
        /// </summary>
        public LeadRolePath()
        {
            this.CalculatedValues = new List<string>();
            this.ObjectUnifiers = new List<string>();
            this.ProjectedPathComponents = new List<string>();
        }
 
        /// <summary>
        /// Gets or sets the unique identifier of the container
        /// </summary>
        public string Container {get; set;}
 

        /// <summary>
        /// Gets or sets a list unique identifiers of the contained <see cref="CalculatedPathValue"/> instances
        /// </summary>
        [Description("The values calculated using roles in this component")]
        [Property(name: "CalculatedValues", aggregation: AggregationKind.Composite, multiplicity: "0..*", typeKind: TypeKind.Object, defaultValue: "", typeName: "CalculatedPathValue", allowOverride: false, isOverride: false, isDerived: false)]
        public List<string> CalculatedValues { get; set; }
 
        /// <summary>
        /// Gets or sets the unique identifier of the contained <see cref="Note"/>
        /// </summary>
        [Description("")]
        [Property(name: "Note", aggregation: AggregationKind.Composite, multiplicity: "0..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "Note", allowOverride: false, isOverride: false, isDerived: false)]
        public string Note { get; set; }
 
        /// <summary>
        /// Gets or sets a list unique identifiers of the contained <see cref="PathObjectUnifier"/> instances
        /// </summary>
        [Description("The object unifier that uses pathed roles and path roots in this role path")]
        [Property(name: "ObjectUnifiers", aggregation: AggregationKind.Composite, multiplicity: "0..*", typeKind: TypeKind.Object, defaultValue: "", typeName: "PathObjectUnifier", allowOverride: false, isOverride: false, isDerived: false)]
        public List<string> ObjectUnifiers { get; set; }
 
        /// <summary>
        /// Gets or sets a list unique identifiers of the referenced <see cref="LeadRolePath"/> instances
        /// </summary>
        [Description("")]
        [Property(name: "ProjectedPathComponents", aggregation: AggregationKind.None, multiplicity: "0..*", typeKind: TypeKind.Object, defaultValue: "", typeName: "LeadRolePath", allowOverride: false, isOverride: false, isDerived: false)]
        public List<string> ProjectedPathComponents { get; set; }
 
    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
