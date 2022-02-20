// -------------------------------------------------------------------------------------------------
// <copyright file="PathConstant.cs" company="RHEA System S.A.">
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
    /// A constant value used in a role path
    /// </summary>
    [Description("A constant value used directly in a path")]
    [Domain(isAbstract: false, general: "ORMModelElement")]
    [Container(typeName: "CalculatedPathValueInput", propertyName: "SourceConstant")]
    public class PathConstant : ORMModelElement
    {
        /// <summary>
        /// The lexical constant value. The value is interpreted based on context
        /// </summary>
        [Description("A lexical constant value interpreted based on context")]
        [Property(name: "LexicalValue", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.String, defaultValue: "", typeName: "")]
        public string LexicalValue { get; set; }
    }
}
