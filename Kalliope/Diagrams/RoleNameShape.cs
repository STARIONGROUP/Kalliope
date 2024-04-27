﻿// -------------------------------------------------------------------------------------------------
// <copyright file="RoleNameShape.cs" company="Starion Group S.A.">
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

namespace Kalliope.Diagrams
{
    using Kalliope.Common;
    using Kalliope.Core;

    /// <summary>
    /// Shape that represents a <see cref="Role"/>
    /// </summary>
    [Description("Shape that represents a Role")]
    [Domain(isAbstract: false, general: "FloatingTextShape")]
    [Container(typeName: "FactTypeShape", propertyName: "RoleNameShapes")]
    public class RoleNameShape : FloatingTextShape
    {
        /// <summary>
        /// Gets or sets the <see cref="Role"/> that is represented by the shape
        /// </summary>
        [Description("The subject Role that is represented by this shape")]
        [Property(name: "Subject", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "Role")]
        public Role Subject { get; set; }
    }
}
