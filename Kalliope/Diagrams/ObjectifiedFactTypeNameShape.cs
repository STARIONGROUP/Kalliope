// -------------------------------------------------------------------------------------------------
// <copyright file="ObjectifiedFactTypeNameShape.cs" company="RHEA System S.A.">
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

namespace Kalliope.Diagrams
{
    using Kalliope.Attributes;
    using Kalliope.Core;

    /// <summary>
    /// Shape that represents a <see cref="ObjectType"/>
    /// </summary>
    [Description("Shape that represents a ObjectType")]
    [Domain(isAbstract: true, general: "FloatingTextShape")]
    public class ObjectifiedFactTypeNameShape : FloatingTextShape
    {
        /// <summary>
        /// Gets or sets a value indicating whether shapes for the <see cref="FactType"/> and <see cref="ValueType"/> corresponding to this
        /// ReferenceMode pattern be displayed on the <see cref="ORMDiagram"/>
        /// </summary>
        [Description("Should shapes for the FactType and ValueType corresponding to this ReferenceMode pattern be displayed on the diagram")]
        [Property(name: "ExpandRefMode", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Boolean, defaultValue: "false", typeName: "")]
        public bool ExpandRefMode { get; set; }
    }
}
