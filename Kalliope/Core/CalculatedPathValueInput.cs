﻿// -------------------------------------------------------------------------------------------------
// <copyright file="CalculatedPathValueInput.cs" company="RHEA System S.A.">
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
    /// <summary>
    /// An input value or bag passed to a function parameter calculate a value
    /// </summary>
    public class CalculatedPathValueInput : ORMModelElement
    {
        /// <summary>
        /// Should the bag be limited to distinct values, resulting in a set of values instead of a bag of values?
        /// </summary>
        public bool DistinctValues { get; set; }

        /// <summary>
        /// Gets or sets the owned <see cref="PathConstant"/>
        /// </summary>
        /// <remarks>
        /// The constant value bound to this function input
        /// </remarks>
        public PathConstant SourceConstant { get; set; }
    }
}
