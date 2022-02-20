// -------------------------------------------------------------------------------------------------
// <copyright file="CompatibleRolePlayerTypeError.cs" company="RHEA System S.A.">
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
    /// The roles in a <see cref="SetConstraint"/> or a column of a <see cref="SetComparisonConstraint"/> have incompatible role players
    /// </summary>
    [Description("Incompatible Constrained Role Players")]
    [Domain(isAbstract: false, general: "ModelError")]
    [Container(typeName: "SetComparisonConstraint", propertyName: "CompatibleRolePlayerTypeErrors")]
    [Container(typeName: "SetConstraint", propertyName: "CompatibleRolePlayerTypeError")]
    public class CompatibleRolePlayerTypeError : ModelError
    {
        /// <summary>
        /// The zero-based column with incompatible types (specified with a <see cref="SetComparisonConstraint"/>)
        /// </summary>
        [Description("")]
        [Property(name: "Column", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Int32, defaultValue: "0", typeName: "")]
        public int Column { get; set; }
    }
}
