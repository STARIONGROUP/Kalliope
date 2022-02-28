// -------------------------------------------------------------------------------------------------
// <copyright file="ReadingShape.cs" company="RHEA System S.A.">
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
    using Kalliope.Common;
    using Kalliope.Core;

    /// <summary>
    /// Shape that represents a <see cref="ReadingOrder"/>
    /// </summary>
    [Description("Shape that represents a ReadingOrder")]
    [Domain(isAbstract: false, general: "FloatingTextShape")]
    [Container(typeName: "FactTypeShape", propertyName: "ReadingShapes")]
    public class ReadingShape : FloatingTextShape
    {
        /// <summary>
        /// Gets or sets the <see cref="ReadingOrder"/> that is represented by this shape
        /// </summary>
        [Description("The subject ReadingOrder that is represented by this shape")]
        [Property(name: "Subject", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "ReadingOrder")]
        public ReadingOrder Subject { get; set; }
    }
}
