// -------------------------------------------------------------------------------------------------
// <copyright file="LeadRolePath.cs" company="RHEA System S.A.">
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
    /// A role path starting from a root object type
    /// </summary>
    /// <remarks>
    /// (DSL) A top level role path starting at a root object type. Provides a context for subpaths, functions, and constraints specific to this path
    /// </remarks>
    [Description("A top level role path starting at a root object type. Provides a context for subpaths, functions, and constraints specific to this path")]
    [Domain(isAbstract: false, general: "RolePath")]
    [Container(typeName: "ConstraintRoleSequenceJoinPath", propertyName: "ProjectedPathComponents")]
    [Container(typeName: "RolePathOwner", propertyName: "LeadRolePaths")]
    public class LeadRolePath : RolePath
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LeadRolePath"/> class
        /// </summary>
        public LeadRolePath()
        {
            this.ObjectUnifiers = new List<PathObjectUnifier>();
            this.CalculatedValues = new List<CalculatedPathValue>();
            this.ProjectedPathComponents = new List<LeadRolePath>();
        }

        /// <summary>
        /// Gets or sets the owned <see cref="Note"/>
        /// </summary>
        [Description("")]
        [Property(name: "Note", aggregation: AggregationKind.Composite, multiplicity: "0..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "Note")]
        public Note Note { get; set; }

        /// <summary>
        /// Gets or sets the object unifier that uses pathed roles and path roots in this role path
        /// </summary>
        [Description("The object unifier that uses pathed roles and path roots in this role path")]
        [Property(name: "ObjectUnifiers", aggregation: AggregationKind.Composite, multiplicity: "0..*", typeKind: TypeKind.Object, defaultValue: "", typeName: "PathObjectUnifier")]
        public List<PathObjectUnifier> ObjectUnifiers { get; set; }

        /// <summary>
        /// Gets or sets the values calculated using roles in this component
        /// </summary>
        [Description("The values calculated using roles in this component")]
        [Property(name: "CalculatedValues", aggregation: AggregationKind.Composite, multiplicity: "0..*", typeKind: TypeKind.Object, defaultValue: "", typeName: "CalculatedPathValue")]
        public List<CalculatedPathValue> CalculatedValues { get; set; }

        [Description("")]
        [Property(name: "ProjectedPathComponents", aggregation: AggregationKind.None, multiplicity: "0..*", typeKind: TypeKind.Object, defaultValue: "", typeName: "LeadRolePath")]
        public List<LeadRolePath> ProjectedPathComponents { get; set; }
    }
}
