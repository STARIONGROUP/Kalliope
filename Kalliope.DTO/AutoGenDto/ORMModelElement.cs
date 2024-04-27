// -------------------------------------------------------------------------------------------------
// <copyright file="OrmModelElement.cs" company="Starion Group S.A.">
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
    /// A Data Transfer Object that represents a OrmModelElement
    /// </summary>
    public abstract partial class OrmModelElement : ModelThing
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrmModelElement"/> class.
        /// </summary>
        protected OrmModelElement()
        {
            this.AssociatedModelErrors = new List<string>();
            this.ExtensionModelErrors = new List<string>();
            this.Extensions = new List<string>();
        }
 

        /// <summary>
        /// Gets or sets a list unique identifiers of the referenced <see cref="ModelError"/> instances
        /// </summary>
        [Description("")]
        [Property(name: "AssociatedModelErrors", aggregation: AggregationKind.None, multiplicity: "0..*", typeKind: TypeKind.Object, defaultValue: "", typeName: "ModelError", allowOverride: false, isOverride: false, isDerived: false)]
        public List<string> AssociatedModelErrors { get; set; }
 
        /// <summary>
        /// Gets or sets a list unique identifiers of the referenced <see cref="ModelError"/> instances
        /// </summary>
        [Description("")]
        [Property(name: "ExtensionModelErrors", aggregation: AggregationKind.None, multiplicity: "0..*", typeKind: TypeKind.Object, defaultValue: "", typeName: "ModelError", allowOverride: false, isOverride: false, isDerived: false)]
        public List<string> ExtensionModelErrors { get; set; }
 
        /// <summary>
        /// Gets or sets a list unique identifiers of the contained <see cref="Extension"/> instances
        /// </summary>
        [Description("extension data related to the containing element")]
        [Property(name: "Extensions", aggregation: AggregationKind.Composite, multiplicity: "0..*", typeKind: TypeKind.Object, defaultValue: "", typeName: "Extension", allowOverride: false, isOverride: false, isDerived: false)]
        public List<string> Extensions { get; set; }
 
    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
