// -------------------------------------------------------------------------------------------------
// <copyright file="ConstraintRoleSequence.cs" company="RHEA System S.A.">
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

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------

namespace Kalliope.DTO
{
    using System;
    using System.Collections.Generic;

    using Kalliope.Common;

    /// <summary>
    /// A Data Transfer Object that represents a ConstraintRoleSequence
    /// </summary>
    public abstract partial class ConstraintRoleSequence : OrmNamedElement
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConstraintRoleSequence"/> class.
        /// </summary>
        protected ConstraintRoleSequence()
        {
            this.Roles = new List<string>();
        }
 

        /// <summary>
        /// Gets or sets the unique identifier of the contained <see cref="ConstraintRoleSequenceJoinPath"/>
        /// </summary>
        [Description("")]
        [Property(name: "JoinPath", aggregation: AggregationKind.Composite, multiplicity: "0..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "ConstraintRoleSequenceJoinPath", allowOverride: false, isOverride: false, isDerived: false)]
        public string JoinPath { get; set; }
 
        /// <summary>
        /// Gets or sets the unique identifier of the contained <see cref="JoinPathRequiredError"/>
        /// </summary>
        [Description("")]
        [Property(name: "JoinPathRequiredError", aggregation: AggregationKind.Composite, multiplicity: "0..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "JoinPathRequiredError", allowOverride: false, isOverride: false, isDerived: false)]
        public string JoinPathRequiredError { get; set; }
 
        /// <summary>
        /// Gets or sets a list unique identifiers of the referenced <see cref="Role"/> instances
        /// </summary>
        [Description("")]
        [Property(name: "Roles", aggregation: AggregationKind.None, multiplicity: "0..*", typeKind: TypeKind.Object, defaultValue: "", typeName: "Role", allowOverride: false, isOverride: false, isDerived: false)]
        public List<string> Roles { get; set; }
 
    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
