// -------------------------------------------------------------------------------------------------
// <copyright file="Constraint.cs" company="RHEA System S.A.">
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
    /// A Data Transfer Object that represents a Constraint
    /// </summary>
    public abstract partial class Constraint : OrmNamedElement
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Constraint"/> class.
        /// </summary>
        protected Constraint()
        {
            this.Modality = ConstraintModality.Alethic;
        }
 

        /// <summary>
        /// Gets or sets the unique identifier of the contained <see cref="Definition"/>
        /// </summary>
        [Description("")]
        [Property(name: "Definition", aggregation: AggregationKind.Composite, multiplicity: "0..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "Definition", allowOverride: false, isOverride: false, isDerived: false)]
        public string Definition { get; set; }
 
        /// <summary>
        /// Gets or sets the unique identifier of the referenced <see cref="ConstraintDuplicateNameError"/>
        /// </summary>
        [Description("")]
        [Property(name: "DuplicateNameError", aggregation: AggregationKind.None, multiplicity: "0..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "ConstraintDuplicateNameError", allowOverride: false, isOverride: false, isDerived: false)]
        public string DuplicateNameError { get; set; }
 
        /// <summary>
        /// Gets or sets the unique identifier of the contained <see cref="ImplicationError"/>
        /// </summary>
        [Description("")]
        [Property(name: "ImplicationError", aggregation: AggregationKind.Composite, multiplicity: "0..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "ImplicationError", allowOverride: false, isOverride: false, isDerived: false)]
        public string ImplicationError { get; set; }
 
        /// <summary>
        /// Gets or sets a Modality
        /// </summary>
        [Description("The constraint Modality. Alethic modality means the constraint is structurally enforced and data violating the constraint cannot be entered in the system. Deontic modality means that data violating the constraint can be recorded.")]
        [Property(name: "Modality", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Enumeration, defaultValue: "Alethic", typeName: "ConstraintModality", allowOverride: false, isOverride: false, isDerived: false)]
        public ConstraintModality Modality { get; set; }
 
        /// <summary>
        /// Gets or sets the unique identifier of the contained <see cref="Note"/>
        /// </summary>
        [Description("")]
        [Property(name: "Note", aggregation: AggregationKind.Composite, multiplicity: "0..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "Note", allowOverride: false, isOverride: false, isDerived: false)]
        public string Note { get; set; }
 
    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
