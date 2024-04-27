// -------------------------------------------------------------------------------------------------
// <copyright file="MandatoryConstraint.cs" company="Starion Group S.A.">
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

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------

namespace Kalliope.DTO
{
    using System;
    using System.Collections.Generic;

    using Kalliope.Common;

    /// <summary>
    /// A Data Transfer Object that represents a MandatoryConstraint
    /// </summary>
    /// <remarks>
    /// A constraint specifying that a set must be populated
    /// </remarks>
    [Container(typeName: "ObjectType", propertyName: "ImpliedMandatoryConstraint")]
    public partial class MandatoryConstraint : SetConstraint
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MandatoryConstraint"/> class.
        /// </summary>
        public MandatoryConstraint()
        {
            this.PopulationMandatoryErrors = new List<string>();
        }
 

        /// <summary>
        /// Gets or sets the unique identifier of the referenced <see cref="ExclusionContradictsMandatoryError"/>
        /// </summary>
        [Description("")]
        [Property(name: "ExclusionContradictsMandatoryError", aggregation: AggregationKind.None, multiplicity: "0..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "ExclusionContradictsMandatoryError", allowOverride: false, isOverride: false, isDerived: false)]
        public string ExclusionContradictsMandatoryError { get; set; }
 
        /// <summary>
        /// Gets or sets the unique identifier of the referenced <see cref="ExclusionConstraint"/>
        /// </summary>
        [Description("")]
        [Property(name: "ExclusiveOrExclusionConstraint", aggregation: AggregationKind.None, multiplicity: "0..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "ExclusionConstraint", allowOverride: false, isOverride: false, isDerived: false)]
        public string ExclusiveOrExclusionConstraint { get; set; }
 
        /// <summary>
        /// Gets or sets the unique identifier of the referenced <see cref="ObjectType"/>
        /// </summary>
        [Description("The object type with an explicit mandatory constraint pattern that implies this constraint")]
        [Property(name: "ImpliedByObjectType", aggregation: AggregationKind.None, multiplicity: "0..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "ObjectType", allowOverride: false, isOverride: false, isDerived: false)]
        public string ImpliedByObjectType { get; set; }
 
        /// <summary>
        /// Gets or sets the unique identifier of the referenced <see cref="ObjectType"/>
        /// </summary>
        [Description("The object type that would implicitly recreate this constraint if it were not explicit in the model")]
        [Property(name: "InherentForObjectType", aggregation: AggregationKind.None, multiplicity: "0..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "ObjectType", allowOverride: false, isOverride: false, isDerived: false)]
        public string InherentForObjectType { get; set; }
 
        /// <summary>
        /// Gets or sets a IsImplied
        /// </summary>
        [Description("")]
        [Property(name: "IsImplied", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Boolean, defaultValue: "false", typeName: "", allowOverride: false, isOverride: false, isDerived: false)]
        public bool IsImplied { get; set; }
 
        /// <summary>
        /// Gets or sets a IsSimple
        /// </summary>
        [Description("")]
        [Property(name: "IsSimple", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Boolean, defaultValue: "false", typeName: "", allowOverride: false, isOverride: false, isDerived: false)]
        public bool IsSimple { get; set; }
 
        /// <summary>
        /// Gets or sets the unique identifier of the contained <see cref="NotWellModeledSubsetAndMandatoryError"/>
        /// </summary>
        [Description("")]
        [Property(name: "NotWellModeledSubsetAndMandatoryError", aggregation: AggregationKind.Composite, multiplicity: "0..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "NotWellModeledSubsetAndMandatoryError", allowOverride: false, isOverride: false, isDerived: false)]
        public string NotWellModeledSubsetAndMandatoryError { get; set; }
 
        /// <summary>
        /// Gets or sets a list unique identifiers of the contained <see cref="PopulationMandatoryError"/> instances
        /// </summary>
        [Description("")]
        [Property(name: "PopulationMandatoryErrors", aggregation: AggregationKind.Composite, multiplicity: "0..*", typeKind: TypeKind.Object, defaultValue: "", typeName: "PopulationMandatoryError", allowOverride: false, isOverride: false, isDerived: false)]
        public List<string> PopulationMandatoryErrors { get; set; }
 
    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
