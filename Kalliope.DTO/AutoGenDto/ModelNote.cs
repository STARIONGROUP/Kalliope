// -------------------------------------------------------------------------------------------------
// <copyright file="ModelNote.cs" company="RHEA System S.A.">
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

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------

namespace Kalliope.DTO
{
    using System;
    using System.Collections.Generic;

    using Kalliope.Common;

    /// <summary>
    /// A Data Transfer Object that represents a ModelNote
    /// </summary>
    [Container(typeName: "ORMModel", propertyName: "Notes")]
    public partial class ModelNote : Note
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ModelNote"/> class.
        /// </summary>
        public ModelNote()
        {
            this.Elements = new List<string>();
            this.FactTypes = new List<string>();
            this.ObjectTypes = new List<string>();
            this.SetComparisonConstraints = new List<string>();
            this.SetConstraints = new List<string>();
        }
 
        /// <summary>
        /// Gets or sets the unique identifier of the container
        /// </summary>
        public string Container {get; set;}
 

        /// <summary>
        /// Gets or sets a list unique identifiers of the referenced <see cref="ORMModelElement"/> instances
        /// </summary>
        [Description("")]
        [Property(name: "Elements", aggregation: AggregationKind.None, multiplicity: "0..*", typeKind: TypeKind.Object, defaultValue: "", typeName: "ORMModelElement", allowOverride: false, isOverride: false, isDerived: false)]
        public List<string> Elements { get; set; }
 
        /// <summary>
        /// Gets or sets a list unique identifiers of the referenced <see cref="FactType"/> instances
        /// </summary>
        [Description("")]
        [Property(name: "FactTypes", aggregation: AggregationKind.None, multiplicity: "0..*", typeKind: TypeKind.Object, defaultValue: "", typeName: "FactType", allowOverride: false, isOverride: false, isDerived: false)]
        public List<string> FactTypes { get; set; }
 
        /// <summary>
        /// Gets or sets a list unique identifiers of the referenced <see cref="ObjectType"/> instances
        /// </summary>
        [Description("")]
        [Property(name: "ObjectTypes", aggregation: AggregationKind.None, multiplicity: "0..*", typeKind: TypeKind.Object, defaultValue: "", typeName: "ObjectType", allowOverride: false, isOverride: false, isDerived: false)]
        public List<string> ObjectTypes { get; set; }
 
        /// <summary>
        /// Gets or sets a list unique identifiers of the referenced <see cref="SetComparisonConstraint"/> instances
        /// </summary>
        [Description("")]
        [Property(name: "SetComparisonConstraints", aggregation: AggregationKind.None, multiplicity: "0..*", typeKind: TypeKind.Object, defaultValue: "", typeName: "SetComparisonConstraint", allowOverride: false, isOverride: false, isDerived: false)]
        public List<string> SetComparisonConstraints { get; set; }
 
        /// <summary>
        /// Gets or sets a list unique identifiers of the referenced <see cref="SetConstraint"/> instances
        /// </summary>
        [Description("")]
        [Property(name: "SetConstraints", aggregation: AggregationKind.None, multiplicity: "0..*", typeKind: TypeKind.Object, defaultValue: "", typeName: "SetConstraint", allowOverride: false, isOverride: false, isDerived: false)]
        public List<string> SetConstraints { get; set; }
 
    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
