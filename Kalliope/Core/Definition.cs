﻿// -------------------------------------------------------------------------------------------------
// <copyright file="Definition.cs" company="Starion Group S.A.">
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
    /// An informal description for the containing element
    /// </summary>
    [Description("An informal description for the containing element")]
    [Domain(isAbstract: false, general: "OrmModelElement")]
    [Container(typeName: "CardinalityConstraint", propertyName: "Definition")]
    [Container(typeName: "ElementGrouping", propertyName: "Definition")]
    [Container(typeName: "FactType", propertyName: "Definition")]
    [Container(typeName: "ObjectType", propertyName: "Definition")]
    [Container(typeName: "OrmModel", propertyName: "Definition")]
    [Container(typeName: "SetComparisonConstraint", propertyName: "Definition")]
    [Container(typeName: "SetConstraint", propertyName: "Definition")]
    [Container(typeName: "ValueConstraint", propertyName: "Definition")]
    public class Definition : OrmModelElement
    {
        /// <summary>
        /// Gets or sets the container <see cref="OrmModelElement"/>
        /// </summary>
        public OrmModelElement Container { get; set; }

        /// <summary>
        /// Plain text description
        /// </summary>
        [Description("The description contents.")]
        [Property(name: "Text", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.String, defaultValue: "", typeName: "")]
        public string Text { get; set; }
    }
}
