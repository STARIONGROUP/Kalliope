// -------------------------------------------------------------------------------------------------
// <copyright file="DisplayState.cs" company="RHEA System S.A.">
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
    /// A Data Transfer Object that represents a DisplayState
    /// </summary>
    /// <remarks>
    /// Container for display options global to this file.
    /// </remarks>
    public partial class DisplayState : ModelThing
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DisplayState"/> class.
        /// </summary>
        public DisplayState()
        {
        }
 

        /// <summary>
        /// Gets or sets the unique identifier of the referenced <see cref="DisplaySetting"/>
        /// </summary>
        [Description("")]
        [Property(name: "DisplaySetting", aggregation: AggregationKind.None, multiplicity: "0..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "DisplaySetting", allowOverride: false, isOverride: false, isDerived: false)]
        public string DisplaySetting { get; set; }
 
        /// <summary>
        /// Gets or sets the unique identifier of the referenced <see cref="OrmModel"/>
        /// </summary>
        [Description("")]
        [Property(name: "Model", aggregation: AggregationKind.None, multiplicity: "0..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "OrmModel", allowOverride: false, isOverride: false, isDerived: false)]
        public string Model { get; set; }
 
    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
