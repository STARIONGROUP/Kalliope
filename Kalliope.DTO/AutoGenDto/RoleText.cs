// -------------------------------------------------------------------------------------------------
// <copyright file="RoleText.cs" company="Starion Group S.A.">
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
    /// A Data Transfer Object that represents a RoleText
    /// </summary>
    /// <remarks>
    /// Text bound to or occurring after a given role. Roles with no text are not represented
    /// </remarks>
    [Container(typeName: "Reading", propertyName: "ExpandedData")]
    public partial class RoleText : ModelThing
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RoleText"/> class.
        /// </summary>
        public RoleText()
        {
        }
 
        /// <summary>
        /// Gets or sets the unique identifier of the container
        /// </summary>
        public string Container {get; set;}
 

        /// <summary>
        /// Gets or sets a FollowingText
        /// </summary>
        [Description("Text following a role replacement field and associated bound text")]
        [Property(name: "FollowingText", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.String, defaultValue: "", typeName: "", allowOverride: false, isOverride: false, isDerived: false)]
        public string FollowingText { get; set; }
 
        /// <summary>
        /// Gets the derived Id
        /// </summary>
        [Description("A unique identifier for this element")]
        [Property(name: "Id", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.String, defaultValue: "", typeName: "", allowOverride: false, isOverride: true, isDerived: true)]
        public override string Id => this.ComputeId();
 
        /// <summary>
        /// Gets or sets a PostBoundText
        /// </summary>
        [Description("Text that is bound to the role as trailing text through hyphen binding semantics in the full reading text")]
        [Property(name: "PostBoundText", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.String, defaultValue: "", typeName: "", allowOverride: false, isOverride: false, isDerived: false)]
        public string PostBoundText { get; set; }
 
        /// <summary>
        /// Gets or sets a PreBoundText
        /// </summary>
        [Description("Text that is bound to the role as leading text through hyphen binding semantics in the full reading text")]
        [Property(name: "PreBoundText", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.String, defaultValue: "", typeName: "", allowOverride: false, isOverride: false, isDerived: false)]
        public string PreBoundText { get; set; }
 
        /// <summary>
        /// Gets or sets a RoleIndex
        /// </summary>
        [Description("The zero-based index of the role")]
        [Property(name: "RoleIndex", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Int32, defaultValue: "", typeName: "", allowOverride: false, isOverride: false, isDerived: false)]
        public int RoleIndex { get; set; }
 
    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
