// -------------------------------------------------------------------------------------------------
// <copyright file="PathObjectUnifier.cs" company="Starion Group S.A.">
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
    /// A Data Transfer Object that represents a PathObjectUnifier
    /// </summary>
    /// <remarks>
    /// A unification indicating that pathed roles and path roots that are not naturally connected refer to the same object type
    /// </remarks>
    [Container(typeName: "LeadRolePath", propertyName: "ObjectUnifiers")]
    public partial class PathObjectUnifier : OrmModelElement
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PathObjectUnifier"/> class.
        /// </summary>
        public PathObjectUnifier()
        {
        }
 
        /// <summary>
        /// Gets or sets the unique identifier of the container
        /// </summary>
        public string Container {get; set;}
 

        /// <summary>
        /// Gets or sets the unique identifier of the contained <see cref="PathObjectUnifierRequiresCompatibleObjectTypesError"/>
        /// </summary>
        [Description("")]
        [Property(name: "CompatibilityError", aggregation: AggregationKind.Composite, multiplicity: "0..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "PathObjectUnifierRequiresCompatibleObjectTypesError", allowOverride: false, isOverride: false, isDerived: false)]
        public string CompatibilityError { get; set; }
 
    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
