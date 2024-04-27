// -------------------------------------------------------------------------------------------------
// <copyright file="FunctionParameter.cs" company="Starion Group S.A.">
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
    /// A function parameter, defines the type of function input
    /// </summary>
    /// <remarks>
    /// A formal function parameter describing expected input to a function
    /// </remarks>
    [Description("A formal function parameter describing expected input to a function")]
    [Domain(isAbstract: false, general: "OrmNamedElement")]
    [Container(typeName: "Function", propertyName: "Parameters")]
    public class FunctionParameter : OrmNamedElement
    {
        /// <summary>
        /// Set to true if this functions takes a bag input instead of a single value
        /// </summary>
        /// <remarks>
        /// (DSL) Set if a bag input is expected for this parameter, such as with an aggregation function
        /// </remarks>
        [Description("")]
        [Property(name: "BagInput", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Boolean, defaultValue: "false", typeName: "")]
        public bool BagInput { get; set; }
        
        /// <summary>
        /// The <see cref="Function"/> this parameter is defined for
        /// </summary>
        public Function Function { get; set; }
    }
}
