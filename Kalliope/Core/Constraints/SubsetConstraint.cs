// -------------------------------------------------------------------------------------------------
// <copyright file="SubsetConstraint.cs" company="RHEA System S.A.">
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
    using Kalliope.Attributes;

    /// <summary>
    /// A constraint specifying that the population of one set must be included in the population of another set
    /// </summary>
    [Description("")]
    [Domain(isAbstract: false, general: "SetComparisonConstraint")]
    public class SubsetConstraint : SetComparisonConstraint
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubsetConstraint"/> class.
        /// </summary>
        /// <param name="model">
        /// The <see cref="ORMModel"/> that contains the current <see cref="SubsetConstraint"/>
        /// </param>
        public SubsetConstraint(ORMModel model) :
            base(model)
        {
        }

        /// <summary>
        /// Gets or sets the owned <see cref="NotWellModeledSubsetAndMandatoryError"/>
        /// </summary>
        [Description("")]
        [Property(name: "NotWellModeledSubsetAndMandatoryError", aggregation: AggregationKind.None, multiplicity: "0..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "NotWellModeledSubsetAndMandatoryError")]
        public NotWellModeledSubsetAndMandatoryError NotWellModeledSubsetAndMandatoryError { get; set; }

        /// <summary>
        /// Gets or sets the owned <see cref="SupersetRoleOfSubtypeSubsetConstraintNotSubtypeError"/>
        /// </summary>
        [Description("")]
        [Property(name: "SupersetRoleOfSubtypeSubsetConstraintNotSubtypeError", aggregation: AggregationKind.None, multiplicity: "0..1", typeKind: TypeKind.String, defaultValue: "", typeName: "SupersetRoleOfSubtypeSubsetConstraintNotSubtypeError")]
        public SupersetRoleOfSubtypeSubsetConstraintNotSubtypeError SupersetRoleOfSubtypeSubsetConstraintNotSubtypeError { get; set; }
    }
}
