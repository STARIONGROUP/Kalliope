﻿// -------------------------------------------------------------------------------------------------
// <copyright file="ModelNoteShape.cs" company="RHEA System S.A.">
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
    /// Shape that represents a <see cref="ModelNote"/>
    /// </summary>
    [Description("Shape that represents a ModelNote")]
    [Domain(isAbstract: false, general: "FloatingTextShape")]
    [Container(typeName: "OrmDiagram", propertyName: "ModelNoteShapes")]
    public class ModelNoteShape : FloatingTextShape
    {
        /// <summary>
        /// Gets or sets the <see cref="ModelNote"/> that is represented by the shape
        /// </summary>
        [Description("The subject ModelNote that is represented by this shape")]
        [Property(name: "Subject", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "ModelNote")]
        public ModelNote Subject { get; set; }
    }
}
