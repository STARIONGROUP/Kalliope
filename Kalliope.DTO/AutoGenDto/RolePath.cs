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
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
 
namespace Kalliope.DTO
{
    using System;
    using System.Collections.Generic;
 
    using Kalliope.Common;
 
    /// <summary>
    /// A Data Transfer Object that represents a RolePath
    /// </summary>
    /// <remarks>
    /// Indicates if the tail split in its entirety should be treated as a negation
    /// </remarks>
    public abstract partial class RolePath : ORMModelElement
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RolePath"/> class.
        /// </summary>
        protected RolePath()
        {
            this.Roles = new List<string>();
            this.SplitCombinationOperator = LogicalCombinationOperator.And;
            this.SubPaths = new List<string>();
        }
 

        /// <summary>
        /// Gets or sets a list unique identifiers of the referenced <see cref="Role"/> instances
        /// </summary>
        [Description("The roles included in this path")]
        [Property(name: "Roles", aggregation: AggregationKind.None, multiplicity: "0..*", typeKind: TypeKind.Object, defaultValue: "", typeName: "Role")]
        public List<string> Roles { get; set; }
 
        /// <summary>
        /// Gets or sets the unique identifier of the referenced <see cref="ObjectType"/>
        /// </summary>
        [Description("RootObjectType")]
        [Property(name: "RootObjectType", aggregation: AggregationKind.None, multiplicity: "0..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "ObjectType")]
        public string RootObjectType { get; set; }
 
        /// <summary>
        /// Gets or sets the unique identifier of the contained <see cref="PathRequiresRootObjectTypeError"/>
        /// </summary>
        [Description("")]
        [Property(name: "RootObjectTypeRequiredError", aggregation: AggregationKind.Composite, multiplicity: "0..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "PathRequiresRootObjectTypeError")]
        public string RootObjectTypeRequiredError { get; set; }
 
        /// <summary>
        /// Gets or sets a SplitCombinationOperator
        /// </summary>
        [Description("")]
        [Property(name: "SplitCombinationOperator", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Enumeration, defaultValue: "And", typeName: "LogicalCombinationOperator")]
        public LogicalCombinationOperator SplitCombinationOperator { get; set; }
 
        /// <summary>
        /// Gets or sets a SplitIsNegated
        /// </summary>
        [Description("Indicates if the tail split in its entirety should be treated as a negation")]
        [Property(name: "SplitIsNegated", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Boolean, defaultValue: "false", typeName: "")]
        public bool SplitIsNegated { get; set; }
 
        /// <summary>
        /// Gets or sets a list unique identifiers of the contained <see cref="RoleSubPath"/> instances
        /// </summary>
        [Description("Sub paths branched from the end of the current path.")]
        [Property(name: "SubPaths", aggregation: AggregationKind.Composite, multiplicity: "0..*", typeKind: TypeKind.Object, defaultValue: "", typeName: "RoleSubPath")]
        public List<string> SubPaths { get; set; }
 
    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
