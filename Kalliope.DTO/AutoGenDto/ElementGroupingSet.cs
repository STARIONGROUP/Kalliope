// -------------------------------------------------------------------------------------------------
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

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------

namespace Kalliope.DTO
{
    using System;
    using System.Collections.Generic;

    using Kalliope.Common;

    /// <summary>
    /// A Data Transfer Object that represents a ElementGroupingSet
    /// </summary>
    /// <remarks>
    /// A Group owner, allows group containment, order, and naming enforcement
    /// </remarks>
    public partial class ElementGroupingSet : ModelThing
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ElementGroupingSet"/> class.
        /// </summary>
        public ElementGroupingSet()
        {
            this.Elements = new List<string>();
            this.Groupings = new List<string>();
        }
 

        /// <summary>
        /// Gets or sets a list unique identifiers of the referenced <see cref="OrmModelElement"/> instances
        /// </summary>
        [Description("")]
        [Property(name: "Elements", aggregation: AggregationKind.None, multiplicity: "0..*", typeKind: TypeKind.Object, defaultValue: "", typeName: "OrmModelElement", allowOverride: false, isOverride: false, isDerived: false)]
        public List<string> Elements { get; set; }
 
        /// <summary>
        /// Gets or sets a list unique identifiers of the contained <see cref="ElementGrouping"/> instances
        /// </summary>
        [Description("")]
        [Property(name: "Groupings", aggregation: AggregationKind.Composite, multiplicity: "1..*", typeKind: TypeKind.Object, defaultValue: "", typeName: "ElementGrouping", allowOverride: false, isOverride: false, isDerived: false)]
        public List<string> Groupings { get; set; }
 
        /// <summary>
        /// Gets or sets the unique identifier of the referenced <see cref="OrmModel"/>
        /// </summary>
        [Description("")]
        [Property(name: "Model", aggregation: AggregationKind.None, multiplicity: "0..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "OrmModel", allowOverride: false, isOverride: false, isDerived: false)]
        public string Model { get; set; }
 
    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
