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

namespace Kalliope.Core
{
    using System.Collections.Generic;

    using Kalliope.Common;

    /// <summary>
    /// An instance of an EntityType Subtype that uses the preferred identification scheme of a parent
    /// </summary>
    /// <remarks>
    /// An instance of a subtype instance defined as a relationship to an instance of the identifying supertype
    /// </remarks>
    [Description("An instance of an EntityType Subtype that uses the preferred identification scheme of a parent")]
    [Domain(isAbstract: false, general: "ObjectTypeInstance")]
    [Container(typeName: "ObjectType", propertyName: "EntityTypeSubtypeInstances")]
    public class EntityTypeSubtypeInstance : ObjectTypeInstance
    {
        /// <summary>
        /// Gets or sets the referenced <see cref="EntityTypeInstance"/>
        /// </summary>
        [Description("")]
        [Property(name: "SupertypeInstance", aggregation: AggregationKind.None, multiplicity: "0..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "EntityTypeInstance")]
        public EntityTypeInstance SupertypeInstance { get; set; }

        /// <summary>
        /// Gets or sets a reference to the fact instance associated with this subtype instance
        /// </summary>
        [Description("A reference to the fact instance associated with this subtype instance")]
        [Property(name: "ObjectifiedInstance", aggregation: AggregationKind.None, multiplicity: "0..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "FactTypeInstance")]
        public FactTypeInstance ObjectifiedInstance { get; set; }
    }
}
