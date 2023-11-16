// -------------------------------------------------------------------------------------------------
// <copyright file="RootObjectType.cs" company="RHEA System S.A.">
//
//   Copyright 2022-2023 RHEA System S.A.
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
    /// A Data Transfer Object that represents a RootObjectType
    /// </summary>
    /// <remarks>
    /// A reference to the object type that establishes the start point object type for a role path.
    /// </remarks>
    [Container(typeName: "RolePath", propertyName: "RootObjectType")]
    public partial class RootObjectType : ModelThing
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RootObjectType"/> class.
        /// </summary>
        public RootObjectType()
        {
        }
 
        /// <summary>
        /// Gets or sets the unique identifier of the container
        /// </summary>
        public string Container {get; set;}
 

        /// <summary>
        /// Gets or sets the unique identifier of the referenced <see cref="ObjectType"/>
        /// </summary>
        [Description("")]
        [Property(name: "ObjectType", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "ObjectType", allowOverride: false, isOverride: false, isDerived: false)]
        public string ObjectType { get; set; }
 
    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
