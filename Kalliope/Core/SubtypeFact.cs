// -------------------------------------------------------------------------------------------------
// <copyright file="SubtypeFact.cs" company="RHEA System S.A.">
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

namespace Kalliope.Core
{
    using System;

    using Kalliope.Common;

    /// <summary>
    /// A fact type representing the subtype meta relationship between a subtype and a supertype
    /// </summary>
    [Description("A fact type representing the subtype meta relationship between a subtype and a supertype")]
    [Domain(isAbstract: false, general: "FactType")]
    public class SubtypeFact : FactType
    {   
        /// <summary>
        /// Deprecated property, use PreferredIdentificationPath instead
        /// </summary>
        [Obsolete("use PreferredIdentificationPath instead")]
        [Description("")]
        [Property(name: "IsPrimary", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Boolean, defaultValue: "false")]
        public bool IsPrimary { get; set; }

        /// <summary>
        /// The subtype fact is a possible path through the subtype graph for retrieving the identifying supertype for the subtype.
        /// The identifying supertype can be a direct or indirect supertype
        /// </summary>
        [Obsolete("use PreferredIdentificationPath instead")]
        [Description("The subtype fact is a possible path through the subtype graph for retrieving the identifying supertype for the subtype.")]
        [Property(name: "PreferredIdentificationPath", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Boolean, defaultValue: "false")]
        public bool PreferredIdentificationPath { get; set; }

        /// <summary>
        /// The preferred identification scheme for the subtype is provided by a supertype reached through this path
        /// </summary>
        [Description("The preferred identification scheme for the subtype is provided by a supertype reached through this path")]
        [Property(name: "ProvidesPreferredIdentifier", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Boolean, defaultValue: "false")]
        public bool ProvidesPreferredIdentifier { get; set; }
    }
}
