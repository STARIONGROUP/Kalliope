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

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------

namespace Kalliope.DTO
{
    using System;
    using System.Collections.Generic;

    using Kalliope.Common;

    /// <summary>
    /// A Data Transfer Object that represents a SetConstraint
    /// </summary>
    [Container(typeName: "OrmModel", propertyName: "SetConstraints")]
    public abstract partial class SetConstraint : Constraint
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SetConstraint"/> class.
        /// </summary>
        protected SetConstraint()
        {
            this.RoleSequences = new List<string>();
        }
 
        /// <summary>
        /// Gets or sets the unique identifier of the container
        /// </summary>
        public string Container {get; set;}
 

        /// <summary>
        /// Gets or sets the unique identifier of the contained <see cref="CompatibleRolePlayerTypeError"/>
        /// </summary>
        [Description("")]
        [Property(name: "CompatibleRolePlayerTypeError", aggregation: AggregationKind.Composite, multiplicity: "0..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "CompatibleRolePlayerTypeError", allowOverride: false, isOverride: false, isDerived: false)]
        public string CompatibleRolePlayerTypeError { get; set; }
 
        /// <summary>
        /// Gets or sets a list unique identifiers of the referenced <see cref="ConstraintRoleSequence"/> instances
        /// </summary>
        [Description("")]
        [Property(name: "RoleSequences", aggregation: AggregationKind.None, multiplicity: "0..*", typeKind: TypeKind.Object, defaultValue: "", typeName: "ConstraintRoleSequence", allowOverride: false, isOverride: false, isDerived: false)]
        public List<string> RoleSequences { get; set; }
 
        /// <summary>
        /// Gets or sets the unique identifier of the contained <see cref="TooFewRoleSequencesError"/>
        /// </summary>
        [Description("")]
        [Property(name: "TooFewRoleSequencesError", aggregation: AggregationKind.Composite, multiplicity: "0..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "TooFewRoleSequencesError", allowOverride: false, isOverride: false, isDerived: false)]
        public string TooFewRoleSequencesError { get; set; }
 
        /// <summary>
        /// Gets or sets the unique identifier of the contained <see cref="TooManyRoleSequencesError"/>
        /// </summary>
        [Description("")]
        [Property(name: "TooManyRoleSequencesError", aggregation: AggregationKind.Composite, multiplicity: "0..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "TooManyRoleSequencesError", allowOverride: false, isOverride: false, isDerived: false)]
        public string TooManyRoleSequencesError { get; set; }
 
    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
