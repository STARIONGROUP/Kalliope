// -------------------------------------------------------------------------------------------------
// <copyright file="EntityTypeSubtypeInstance.cs" company="Starion Group S.A.">
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
    /// A Data Transfer Object that represents a EntityTypeSubtypeInstance
    /// </summary>
    /// <remarks>
    /// An instance of an EntityType Subtype that uses the preferred identification scheme of a parent
    /// </remarks>
    [Container(typeName: "ObjectType", propertyName: "EntityTypeSubtypeInstances")]
    public partial class EntityTypeSubtypeInstance : ObjectTypeInstance
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EntityTypeSubtypeInstance"/> class.
        /// </summary>
        public EntityTypeSubtypeInstance()
        {
        }
 

        /// <summary>
        /// Gets or sets the unique identifier of the referenced <see cref="FactTypeInstance"/>
        /// </summary>
        [Description("A reference to the fact instance associated with this subtype instance")]
        [Property(name: "ObjectifiedInstance", aggregation: AggregationKind.None, multiplicity: "0..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "FactTypeInstance", allowOverride: false, isOverride: false, isDerived: false)]
        public string ObjectifiedInstance { get; set; }
 
        /// <summary>
        /// Gets or sets the unique identifier of the referenced <see cref="EntityTypeInstance"/>
        /// </summary>
        [Description("")]
        [Property(name: "SupertypeInstance", aggregation: AggregationKind.None, multiplicity: "0..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "EntityTypeInstance", allowOverride: false, isOverride: false, isDerived: false)]
        public string SupertypeInstance { get; set; }
 
    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
