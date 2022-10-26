// -------------------------------------------------------------------------------------------------
// <copyright file="DynamicColor.cs" company="RHEA System S.A.">
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
    /// Dynamic color information used by extension models with shape representations
    /// </summary>
    [Description("Dynamic color information used by extension models with shape representations")]
    [Domain(isAbstract: true, general: "ModelThing")]
    public abstract class DynamicColor : ModelThing
    {
        [Property(name: "ColorRole", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.String, defaultValue: "", typeName: "")]
        public string ColorRole { get; set; }
        
        [Property(name: "ColorValue", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.String, defaultValue: "", typeName: "")]
        public string ColorValue { get; set; }
    }
}
