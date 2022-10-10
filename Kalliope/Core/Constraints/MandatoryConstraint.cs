// -------------------------------------------------------------------------------------------------
// <copyright file="MandatoryConstraint.cs" company="RHEA System S.A.">
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
    /// A constraint specifying that a set must be populated
    /// </summary>
    [Description("A constraint specifying that a set must be populated")]
    [Domain(isAbstract: false, general: "SetConstraint")]
    [Container(typeName: "ObjectType", propertyName: "ImpliedMandatoryConstraint")]
    public class MandatoryConstraint : SetConstraint
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MandatoryConstraint"/> class.
        /// </summary>
        public MandatoryConstraint()
        {
            this.PopulationMandatoryErrors = new List<PopulationMandatoryError>();
        }
        
        /// <summary>
        /// True if this is an internal constraint associated with a single role
        /// </summary>
        [Description("")]
        [Property(name: "IsSimple", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Boolean, defaultValue: "false", typeName: "")]
        public bool IsSimple { get; set; }

        /// <summary>
        /// True if this constraint is implied by a lack of a mandatory role on any non-existential role on the non-independent role player.
        /// An implied mandatory constraint may have a single role or multiple roles, but IsSimple is never true for an implied mandatory constraint
        /// </summary>
        [Description("")]
        [Property(name: "IsImplied", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Boolean, defaultValue: "false", typeName: "")]
        public bool IsImplied { get; set; }


        /// <summary>
        /// The object type with an explicit mandatory constraint pattern that implies this constraint
        /// </summary>
        [Description("The object type with an explicit mandatory constraint pattern that implies this constraint")]
        [Property(name: "ImpliedByObjectType", aggregation: AggregationKind.None, multiplicity: "0..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "ObjectType")]
        public ObjectType ImpliedByObjectType { get; set; }

        /// <summary>
        /// The object type that would implicitly recreate this constraint if it were not explicit in the model
        /// </summary>
        [Description("The object type that would implicitly recreate this constraint if it were not explicit in the model")]
        [Property(name: "InherentForObjectType", aggregation: AggregationKind.None, multiplicity: "0..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "ObjectType")]
        public ObjectType InherentForObjectType { get; set; }
        
        /// <summary>
        /// Gets or sets the contained <see cref="PopulationMandatoryError"/>s
        /// </summary>
        [Description("")]
        [Property(name: "PopulationMandatoryErrors", aggregation: AggregationKind.Composite, multiplicity: "0..*", typeKind: TypeKind.Object, defaultValue: "", typeName: "PopulationMandatoryError")]
        public List<PopulationMandatoryError> PopulationMandatoryErrors { get; set; }

        /// <summary>
        /// Gets or sets the owned <see cref="NotWellModeledSubsetAndMandatoryError"/>
        /// </summary>
        [Description("")]
        [Property(name: "NotWellModeledSubsetAndMandatoryError", aggregation: AggregationKind.Composite, multiplicity: "0..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "NotWellModeledSubsetAndMandatoryError")]
        public NotWellModeledSubsetAndMandatoryError NotWellModeledSubsetAndMandatoryError { get; set; }

        /// <summary>
        /// Gets or sets the referenced <see cref="ExclusionConstraint"/>
        /// </summary>
        [Description("")]
        [Property(name: "ExclusiveOrExclusionConstraint", aggregation: AggregationKind.None, multiplicity: "0..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "ExclusionConstraint")]
        public ExclusionConstraint ExclusiveOrExclusionConstraint { get; set; }

        /// <summary>
        /// Gets or sets the referenced <see cref="ExclusionContradictsMandatoryError"/>
        /// </summary>
        [Description("")]
        [Property(name: "ExclusionContradictsMandatoryError", aggregation: AggregationKind.None, multiplicity: "0..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "ExclusionContradictsMandatoryError")]
        public ExclusionContradictsMandatoryError ExclusionContradictsMandatoryError { get; set; }
    }
}
