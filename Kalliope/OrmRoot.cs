﻿// -------------------------------------------------------------------------------------------------
// <copyright file="OrmRoot.cs" company="RHEA System S.A.">
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

namespace Kalliope
{
    using System.Collections.Generic;

    using Kalliope.Common;
    using Kalliope.Core;
    using Kalliope.Diagrams;

    /// <summary>
    /// The <see cref="OrmRoot"/> represents the root node of an .orm file
    /// </summary>
    [Domain(isAbstract:false, general: "ModelThing")]
    public class OrmRoot : ModelThing
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrmRoot"/> class
        /// </summary>
        public OrmRoot()
        {
            this.Diagrams = new List<OrmDiagram>();
        }
        
        /// <summary>
        /// Gets the unique identifier of the <see cref="RoleText"/>
        /// </summary>
        [Description("A unique identifier for this element")]
        [Property(name: "Id", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.String, defaultValue: "", typeName: "", allowOverride: false, isOverride: true, isDerived: true)]
        public override string Id { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="OrmModel"/> contained by .orm file
        /// </summary>
        [Property(name: "Model", aggregation: AggregationKind.Composite, multiplicity: "1..1", typeKind: TypeKind.Object, defaultValue:"", typeName: "OrmModel")]
        public OrmModel Model { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="NameGenerator"/> contained by .orm file
        /// </summary>
        [Property(name: "NameGenerator", aggregation: AggregationKind.Composite, multiplicity: "1..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "NameGenerator")]
        public NameGenerator NameGenerator { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="GenerationState"/> contained by .orm file
        /// </summary>
        [Property(name: "GenerationState", aggregation: AggregationKind.Composite, multiplicity: "1..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "GenerationState")]
        public GenerationState GenerationState { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="OrmDiagram"/>s contained by the .orm file
        /// </summary>
        [Property(name: "Diagrams", aggregation: AggregationKind.Composite, multiplicity: "0..*", typeKind: TypeKind.Object, defaultValue:"", typeName: "OrmDiagram")]
        public List<OrmDiagram> Diagrams { get; set; }  
    }
}
