﻿// -------------------------------------------------------------------------------------------------
// <copyright file="ImpliedFactType.cs" company="Starion Group S.A.">
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

namespace Kalliope.Core
{
    using Kalliope.Common;

    [Description("")]
    [Domain(isAbstract: false, general: "FactType")]
    public class ImpliedFactType : FactType
    {
        /// <summary>
        /// Gets or sets the referenced <see cref="Objectification"/>
        /// </summary>
        /// <remarks>
        /// A reference to the objectification relationship that implies this fact type
        /// </remarks>
        [Description("A reference to the objectification relationship that implies this fact type")]
        [Property(name: "ImpliedByObjectification", aggregation: AggregationKind.None, multiplicity: "0..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "Objectification")]
        public Objectification ImpliedByObjectification { get; set; }
    }
}
