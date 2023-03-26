// -------------------------------------------------------------------------------------------------
// <copyright file="DisplayState.cs" company="RHEA System S.A.">
//
//   Copyright 2023 RHEA System S.A.
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
    /// Container for display options global to this file.
    /// </summary>
    [Description("Container for display options global to this file.")]
    [Domain(isAbstract: false, general: "ModelThing")]
    public class DisplayState : ModelThing
    {
        /// <summary>
        /// Gets or sets the referenced Model
        /// </summary>
        [Description("")]
        [Property(name: "Model", aggregation: AggregationKind.None, multiplicity: "0..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "OrmModel")]
        public OrmModel Model { get; set; }

        /// <summary>
        /// Gets or sets the referenced DisplaySetting
        /// </summary>
        [Description("")]
        [Property(name: "DisplaySetting", aggregation: AggregationKind.None, multiplicity: "0..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "DisplaySetting")]
        public DisplaySetting DisplaySetting { get; set; }
    }
}
