// -------------------------------------------------------------------------------------------------
// <copyright file="ConstraintRoleSequenceJoinPath.cs" company="RHEA System S.A.">
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
    using System.Collections.Generic;

    using Kalliope.Common;

    /// <summary>
    /// A role path used to define the path between roles in different fact types in the same join path
    /// </summary>
    [Description("A role path defining cross fact type relationships within a constraint role sequence")]
    [Domain(isAbstract: false, general: "RolePathOwner")]
    [Container(typeName: "ConstraintRoleSequence", propertyName: "JoinPath")]
    public class ConstraintRoleSequenceJoinPath : RolePathOwner
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConstraintRoleSequenceJoinPath"/> class
        /// </summary>
        public ConstraintRoleSequenceJoinPath()
        {
            this.ProjectedPathComponents = new List<LeadRolePath>();
        }

        /// <summary>
        /// The join path is automatically created from the constraint sequence
        /// </summary>
        [Description("")]
        [Property(name: "IsAutomatic", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Boolean, defaultValue: "false", typeName: "")]
        public bool IsAutomatic { get; set; }

        /// <summary>
        /// Gets or sets the referenced list of <see cref="LeadRolePath"/>s
        /// </summary>
        [Description("")]
        [Property(name: "ProjectedPathComponents", aggregation: AggregationKind.Composite, multiplicity: "0..*", typeKind: TypeKind.Object, defaultValue: "", typeName: "LeadRolePath")]
        public List<LeadRolePath> ProjectedPathComponents { get; set; }

        /// <summary>
        /// Gets or sets the owned <see cref="ConstraintRoleSequenceJoinPathRequiresProjectionError"/>
        /// </summary>
        [Description("")]
        [Property(name: "ProjectionRequiredError", aggregation: AggregationKind.Composite, multiplicity: "0..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "ConstraintRoleSequenceJoinPathRequiresProjectionError")]
        public ConstraintRoleSequenceJoinPathRequiresProjectionError ProjectionRequiredError { get; set; }
    }
}
