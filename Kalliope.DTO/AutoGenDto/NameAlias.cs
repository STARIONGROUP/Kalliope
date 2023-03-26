// -------------------------------------------------------------------------------------------------
// <copyright file="NameAlias.cs" company="RHEA System S.A.">
//
//   Copyright 2022-2023 RHEA System S.A.
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
    /// A Data Transfer Object that represents a NameAlias
    /// </summary>
    /// <remarks>
    /// An alternative name for the containing named element
    /// </remarks>
    [Container(typeName: "ObjectType", propertyName: "Abbreviations")]
    [Container(typeName: "RecognizedPhrase", propertyName: "Abbreviations")]
    public partial class NameAlias : OrmNamedElement
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NameAlias"/> class.
        /// </summary>
        public NameAlias()
        {
        }
 
        /// <summary>
        /// Gets or sets the unique identifier of the container
        /// </summary>
        public string Container {get; set;}
 

        /// <summary>
        /// Gets or sets a NameConsumer
        /// </summary>
        [Description("")]
        [Property(name: "NameConsumer", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.String, defaultValue: "", typeName: "", allowOverride: false, isOverride: false, isDerived: false)]
        public string NameConsumer { get; set; }
 
        /// <summary>
        /// Gets or sets a NameUsage
        /// </summary>
        [Description("")]
        [Property(name: "NameUsage", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.String, defaultValue: "", typeName: "", allowOverride: false, isOverride: false, isDerived: false)]
        public string NameUsage { get; set; }
 
        /// <summary>
        /// Gets or sets the unique identifier of the referenced <see cref="ModelThing"/>
        /// </summary>
        [Description("Bind an Alias or NameGenerator to a specific generated instance")]
        [Property(name: "RefinedInstance", aggregation: AggregationKind.None, multiplicity: "0..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "ModelThing", allowOverride: false, isOverride: false, isDerived: false)]
        public string RefinedInstance { get; set; }
 
    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
