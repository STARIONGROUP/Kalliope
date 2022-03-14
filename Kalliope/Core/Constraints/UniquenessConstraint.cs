// -------------------------------------------------------------------------------------------------
// <copyright file="UniquenessConstraint.cs" company="RHEA System S.A.">
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

namespace Kalliope.Core
{
    using Kalliope.Common;

    /// <summary>
    /// A constraint specifying that the population of a set must be unique
    /// </summary>
    [Description("")]
    [Domain(isAbstract: false, general: "SetConstraint")]
    public class UniquenessConstraint : SetConstraint
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UniquenessConstraint"/> class.
        /// </summary>
        public UniquenessConstraint()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UniquenessConstraint"/> class.
        /// </summary>
        /// <param name="model">
        /// The <see cref="ORMModel"/> that contains the current <see cref="UniquenessConstraint"/>
        /// </param>
        public UniquenessConstraint(ORMModel model) :
            base(model)
        {
        }

        /// <summary>
        /// Is this the preferred identifier for the EntityType role player of the opposite role(s)?
        /// The opposite role player of an internal constraint on an objectified FactType is the objectifying EntityType.
        /// Binary FactTypes with a spanning internal uniqueness constraint and ternary (or higher arity) FactTypes are automatically objectified
        /// </summary>
        [Description("Is this the preferred identifier for the EntityType role player of the opposite role(s)? The opposite role player of an internal constraint on an objectified FactType is the objectifying EntityType. Binary FactTypes with a spanning internal uniqueness constraint and ternary (or higher arity) FactTypes are automatically objectified")]
        [Property(name: "IsPreferred", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Boolean, defaultValue: "false", typeName: "")]
        public bool IsPreferred { get; set; }

        /// <summary>
        /// If true, this uniqueness constraint is internal to a single fact type
        /// </summary>
        [Description("")]
        [Property(name: "IsInternal", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Boolean, defaultValue: "false", typeName: "")]
        public bool IsInternal { get; set; }

        /// <summary>
        /// Gets or sets the owned <see cref="NMinusOneError"/>
        /// </summary>
        [Description("")]
        [Property(name: "NMinusOneError", aggregation: AggregationKind.Composite, multiplicity: "0..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "NMinusOneError")]
        public NMinusOneError NMinusOneError { get; set; }
    }
}
