// -------------------------------------------------------------------------------------------------
// <copyright file="FactTypeDerivationPath.cs" company="RHEA System S.A.">
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
    using Kalliope.Common;

    /// <summary>
    /// A role path with projected nodes used to define the population of a derived fact type
    /// </summary>
    [Description("A role path with projected nodes used to define the population of a derived fact type")]
    [Domain(isAbstract: false, general: "RolePathOwner")]
    public class FactTypeDerivationPath : RolePathOwner
    {
        /// <summary>
        /// The derivation rule results in a set of distinct facts instead of a bag that might contain duplicates
        /// </summary>
        [Description("The derivation rule results in a set of distinct facts instead of a bag that might contain duplicates")]
        [Property(name: "SetProjection", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Boolean, defaultValue: "false", typeName: "")]
        public bool SetProjection { get; set; }

        /// <summary>
        /// The name of a fully derived fact type
        /// </summary>
        [Description("The name of a fully derived fact type")]
        [Property(name: "Name", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.String, defaultValue: "", typeName: "")]
        public string Name { get; set; }

        /// <summary>
        /// An empty derivation rule is externally defined
        /// </summary>
        [Description("An empty derivation rule is externally defined")]
        [Property(name: "ExternalDerivation", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Boolean, defaultValue: "false", typeName: "")]
        public bool ExternalDerivation { get; set; }
    }
}
