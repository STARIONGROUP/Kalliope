// -------------------------------------------------------------------------------------------------
// <copyright file="ReadingOrder.cs" company="Starion Group S.A.">
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
    /// A sequence of roles from a single fact type representing representing a complete role traversal. Also called a predicate
    /// </summary>
    [Description("A sequence of roles from a single fact type representing representing a complete role traversal. Also called a predicate")]
    [Domain(isAbstract: false, general: "OrmModelElement")]
    [Container(typeName: "FactType", propertyName: "ReadingOrders")]
    public class ReadingOrder : OrmModelElement
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReadingOrder"/> class
        /// </summary>
        public ReadingOrder()
        {
            this.Readings = new List<Reading>();
            this.Roles = new List<RoleBase>();
        }

        /// <summary>
        /// The text for the default Reading of this ReadingOrder. Includes ordered replacement fields corresponding to this ReadingOrder
        /// </summary>
        [Description("The text for the default Reading of this ReadingOrder. Includes ordered replacement fields corresponding to this ReadingOrder")]
        [Property(name: "ReadingText", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.String, defaultValue: "", typeName: "")]
        public string ReadingText { get; set; }
        
        /// <summary>
        /// Gets or sets the owned <see cref="Reading"/>s
        /// </summary>
        [Description("")]
        [Property(name: "Readings", aggregation: AggregationKind.Composite, multiplicity: "1..*", typeKind: TypeKind.Object, defaultValue: "", typeName: "Reading")]
        public List<Reading> Readings { get; set; }

        /// <summary>
        /// Gets or sets the referenced <see cref="RoleBase"/> instances
        /// </summary>
        [Description("")]
        [Property(name: "Roles", aggregation: AggregationKind.None, multiplicity: "1..*", typeKind: TypeKind.Object, defaultValue: "", typeName: "RoleBase")]
        public List<RoleBase> Roles { get; set; }
    }
}
