// -------------------------------------------------------------------------------------------------
// <copyright file="SetConstraint.cs" company="RHEA System S.A.">
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

namespace Kalliope.Core
{
    using System.Collections.Generic;

    using Kalliope.Common;

    [Description("")]
    [Domain(isAbstract: true, general: "Constraint")]
    [Container(typeName: "OrmModel", propertyName: "SetConstraints")]
    public abstract class SetConstraint : Constraint
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SetConstraint"/> class.
        /// </summary>
        protected SetConstraint() 
        {
            this.RoleSequences = new List<ConstraintRoleSequence>();
        }

        /// <summary>
        /// Gets or sets the referenced <see cref="FactType"/>s
        /// </summary>
        [Description("")]
        [Property(name: "RoleSequences", aggregation: AggregationKind.None, multiplicity: "0..*", typeKind: TypeKind.Object, defaultValue: "", typeName: "ConstraintRoleSequence")]
        public List<ConstraintRoleSequence> RoleSequences { get; set; }

        /// <summary>
        /// Gets or sets the owned <see cref="CompatibleRolePlayerTypeError"/>
        /// </summary>
        [Description("")]
        [Property(name: "CompatibleRolePlayerTypeError", aggregation: AggregationKind.Composite, multiplicity: "0..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "CompatibleRolePlayerTypeError")]
        public CompatibleRolePlayerTypeError CompatibleRolePlayerTypeError { get; set; }

        /// <summary>
        /// Gets or sets the owned <see cref="TooFewRoleSequencesError"/>
        /// </summary>
        [Description("")]
        [Property(name: "TooFewRoleSequencesError", aggregation: AggregationKind.Composite, multiplicity: "0..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "TooFewRoleSequencesError")]
        public TooFewRoleSequencesError TooFewRoleSequencesError { get; set; }

        /// <summary>
        /// Gets or sets the owned <see cref="TooManyRoleSequencesError"/>
        /// </summary>
        [Description("")]
        [Property(name: "TooManyRoleSequencesError", aggregation: AggregationKind.Composite, multiplicity: "0..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "TooManyRoleSequencesError")]
        public TooManyRoleSequencesError TooManyRoleSequencesError { get; set; }
    }
}
