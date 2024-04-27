﻿// -------------------------------------------------------------------------------------------------
// <copyright file="CalculatedValue.cs" company="Starion Group S.A.">
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

    /// <summary>
    /// Specifies the function, scope, and inputs used for an algorithmic calculation
    /// </summary>
    [Description("Specifies the function, scope, and inputs used for an algorithmic calculation")]
    [Domain(isAbstract: false, general: "OrmModelElement")]
    public class CalculatedValue : OrmModelElement
    {
        /// <summary>
        /// Set to true if the AggregationContext is not provided and the function is an aggregate, meaning that a parameter is marked as a BagInput
        /// </summary>
        public bool UniversalAggregationContext { get; set; }
    }
}
