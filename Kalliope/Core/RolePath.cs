// -------------------------------------------------------------------------------------------------
// <copyright file="RolePath.cs" company="RHEA System S.A.">
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
    /// An ordered sequence of roles through ORM space with a tail split branching into other subpaths
    /// </summary>
    [Description("Indicates if the tail split in its entirety should be treated as a negation")]
    [Domain(isAbstract: true, general: "OrmModelElement")]
    public abstract class RolePath : OrmModelElement
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RolePath"/> class
        /// </summary>
        protected RolePath()
        {
            this.SplitCombinationOperator = LogicalCombinationOperator.And;
            this.SubPaths = new List<RoleSubPath>();
            this.Roles = new List<Role>();
        }

        /// <summary>
        /// Should a negation be applied to the split combination operator?
        /// </summary>
        /// <remarks>
        /// (DSL) Indicates if the tail split in its entirety should be treated as a negation
        /// </remarks>
        [Description("Indicates if the tail split in its entirety should be treated as a negation")]
        [Property(name: "SplitIsNegated", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Boolean, defaultValue: "false", typeName: "")]
        public bool SplitIsNegated { get; set; }

        /// <summary>
        /// Determines the logical operator used to combine split paths
        /// </summary>

        [Description("")]
        [Property(name: "SplitCombinationOperator", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Enumeration, defaultValue: "And", typeName: "LogicalCombinationOperator")]
        public LogicalCombinationOperator SplitCombinationOperator { get; set; }

        /// <summary>
        /// Gets or sets the Sub paths branched from the end of the current path
        /// </summary>
        [Description("Sub paths branched from the end of the current path.")]
        [Property(name: "SubPaths", aggregation: AggregationKind.Composite, multiplicity: "0..*", typeKind: TypeKind.Object, defaultValue: "", typeName: "RoleSubPath")]
        public List<RoleSubPath> SubPaths { get; set; }

        /// <summary>
        /// Gets or sets the owned <see cref="PathRequiresRootObjectTypeError"/>
        /// </summary>
        [Description("")]
        [Property(name: "RootObjectTypeRequiredError", aggregation: AggregationKind.Composite, multiplicity: "0..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "PathRequiresRootObjectTypeError")]
        public PathRequiresRootObjectTypeError RootObjectTypeRequiredError { get; set; }

        [Description("RootObjectType")]
        [Property(name: "RootObjectType", aggregation: AggregationKind.None, multiplicity: "0..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "ObjectType")]
        public ObjectType RootObjectType { get; set; }

        /// <summary>
        /// The roles included in this path
        /// </summary>
        [Description("The roles included in this path")]
        [Property(name: "Roles", aggregation: AggregationKind.None, multiplicity: "0..*", typeKind: TypeKind.Object, defaultValue: "", typeName: "Role")]
        public List<Role> Roles { get; set; }
    }
}
