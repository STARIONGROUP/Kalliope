// -------------------------------------------------------------------------------------------------
// <copyright file="ObjectifiedType.cs" company="Starion Group S.A.">
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
    /// An entity type that objectifies a fact type
    /// </summary>
    [Description("An entity type that objectifies a fact type")]
    [Domain(isAbstract: false, general: "ObjectType")]
    public class ObjectifiedType : ObjectType
    {
        /// <summary>
        /// Gets or sets a reference to the uniqueness constraint that provides the preferred identification scheme for this entity type
        /// </summary>
        [Description("A reference to the uniqueness constraint that provides the preferred identification scheme for this entity type")]
        [Property(name: "PreferredIdentifier", aggregation: AggregationKind.None, multiplicity: "0..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "UniquenessConstraint")]
        public UniquenessConstraint PreferredIdentifier { get; set; }

        /// <summary>
        /// Gets or sets a referenced to teh <see cref="Objectification"/>
        /// </summary>
        [Description("")]
        [Property(name: "NestedPredicate", aggregation: AggregationKind.Composite, multiplicity: "1..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "Objectification")]
        public Objectification NestedPredicate { get; set; }

        /// <summary>
        /// Gets or sets the referenced <see cref="ObjectTypeInstance"/>
        /// </summary>
        public List<ObjectTypeInstance> Instances { get; set; }
    }
}
