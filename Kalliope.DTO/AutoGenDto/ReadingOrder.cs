// -------------------------------------------------------------------------------------------------
// <copyright file="ReadingOrder.cs" company="RHEA System S.A.">
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
    /// A Data Transfer Object that represents a ReadingOrder
    /// </summary>
    /// <remarks>
    /// A sequence of roles from a single fact type representing representing a complete role traversal. Also called a predicate
    /// </remarks>
    [Container(typeName: "FactType", propertyName: "ReadingOrders")]
    public partial class ReadingOrder : OrmModelElement
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReadingOrder"/> class.
        /// </summary>
        public ReadingOrder()
        {
            this.Readings = new List<string>();
            this.Roles = new List<string>();
        }
 
        /// <summary>
        /// Gets or sets the unique identifier of the container
        /// </summary>
        public string Container {get; set;}
 

        /// <summary>
        /// Gets or sets a list unique identifiers of the contained <see cref="Reading"/> instances
        /// </summary>
        [Description("")]
        [Property(name: "Readings", aggregation: AggregationKind.Composite, multiplicity: "1..*", typeKind: TypeKind.Object, defaultValue: "", typeName: "Reading", allowOverride: false, isOverride: false, isDerived: false)]
        public List<string> Readings { get; set; }
 
        /// <summary>
        /// Gets or sets a ReadingText
        /// </summary>
        [Description("The text for the default Reading of this ReadingOrder. Includes ordered replacement fields corresponding to this ReadingOrder")]
        [Property(name: "ReadingText", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.String, defaultValue: "", typeName: "", allowOverride: false, isOverride: false, isDerived: false)]
        public string ReadingText { get; set; }
 
        /// <summary>
        /// Gets or sets a list unique identifiers of the referenced <see cref="RoleBase"/> instances
        /// </summary>
        [Description("")]
        [Property(name: "Roles", aggregation: AggregationKind.None, multiplicity: "1..*", typeKind: TypeKind.Object, defaultValue: "", typeName: "RoleBase", allowOverride: false, isOverride: false, isDerived: false)]
        public List<string> Roles { get; set; }
 
    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
