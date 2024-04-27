﻿// -------------------------------------------------------------------------------------------------
// <copyright file="ElementGroupingSet.cs" company="Starion Group S.A.">
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
    using System.Collections.Generic;

    using Kalliope.Common;

    /// <summary>
    /// A Group owner, allows group containment, order, and naming enforcement
    /// </summary>
    [Description("A Group owner, allows group containment, order, and naming enforcement")]
    [Domain(isAbstract: false, general: "ModelThing")]
    public class ElementGroupingSet : ModelThing
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ElementGroupingSet"/> class
        /// </summary>
        public ElementGroupingSet()
        {
            this.Groupings = new List<ElementGrouping>();
            this.Elements = new List<OrmModelElement>();
        }

        [Description("")]
        [Property(name: "Groupings", aggregation: AggregationKind.Composite, multiplicity: "1..*", typeKind: TypeKind.Object, defaultValue: "", typeName: "ElementGrouping")]
        public List<ElementGrouping> Groupings { get; set; }

        [Description("")]
        [Property(name: "Model", aggregation: AggregationKind.None, multiplicity: "0..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "OrmModel")]
        public OrmModel Model { get; set; }

        [Description("")]
        [Property(name: "Elements", aggregation: AggregationKind.None, multiplicity: "0..*", typeKind: TypeKind.Object, defaultValue: "", typeName: "OrmModelElement")]
        public List<OrmModelElement> Elements { get; set; }
    }
}
