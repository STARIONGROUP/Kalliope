// -------------------------------------------------------------------------------------------------
// <copyright file="ReferenceModeKind.cs" company="RHEA System S.A.">
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
    /// A Data Transfer Object that represents a ReferenceModeKind
    /// </summary>
    /// <remarks>
    /// Setting for a specific kind of reference mode pattern
    /// </remarks>
    [Container(typeName: "OrmModel", propertyName: "ReferenceModeKinds")]
    public partial class ReferenceModeKind : OrmModelElement
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReferenceModeKind"/> class.
        /// </summary>
        public ReferenceModeKind()
        {
            this.ReferenceModeType = ReferenceModeType.General;
        }
 
        /// <summary>
        /// Gets or sets the unique identifier of the container
        /// </summary>
        public string Container {get; set;}
 

        /// <summary>
        /// Gets or sets a FormatString
        /// </summary>
        [Description("Default format string for reference mode patterns with this ReferenceModeKind. Replacement field {0}=EntityTypeName, {1}=ReferenceModeName")]
        [Property(name: "FormatString", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.String, defaultValue: "", typeName: "", allowOverride: false, isOverride: false, isDerived: false)]
        public string FormatString { get; set; }
 
        /// <summary>
        /// Gets or sets a ReferenceModeType
        /// </summary>
        [Description("One of Popular, UnitBased, or General")]
        [Property(name: "ReferenceModeType", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Enumeration, defaultValue: "General", typeName: "ReferenceModeType", allowOverride: false, isOverride: false, isDerived: false)]
        public ReferenceModeType ReferenceModeType { get; set; }
 
    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
