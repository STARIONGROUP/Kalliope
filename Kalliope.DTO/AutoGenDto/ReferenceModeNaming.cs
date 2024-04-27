// -------------------------------------------------------------------------------------------------
// <copyright file="ReferenceModeNaming.cs" company="Starion Group S.A.">
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
    /// A Data Transfer Object that represents a ReferenceModeNaming
    /// </summary>
    /// <remarks>
    /// Reference mode naming options for a specific object type. Used by extension models, which must add their own reference to the modified object type
    /// </remarks>
    public abstract partial class ReferenceModeNaming : ModelThing
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReferenceModeNaming"/> class.
        /// </summary>
        protected ReferenceModeNaming()
        {
            this.NamingChoice = ReferenceModeNamingChoice.ModelDefault;
            this.PrimaryIdentifierNamingChoice = ReferenceModeNamingChoice.ModelDefault;
        }
 

        /// <summary>
        /// Gets or sets a CustomFormat
        /// </summary>
        [Description("The custom naming format used for references to this EntityType")]
        [Property(name: "CustomFormat", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.String, defaultValue: "", typeName: "", allowOverride: false, isOverride: false, isDerived: false)]
        public string CustomFormat { get; set; }
 
        /// <summary>
        /// Gets or sets a NamingChoice
        /// </summary>
        [Description("The naming pattern used for references to this EntityType")]
        [Property(name: "NamingChoice", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Enumeration, defaultValue: "ModelDefault", typeName: "ReferenceModeNamingChoice", allowOverride: false, isOverride: false, isDerived: false)]
        public ReferenceModeNamingChoice NamingChoice { get; set; }
 
        /// <summary>
        /// Gets or sets a PrimaryIdentifierCustomFormat
        /// </summary>
        [Description("The custom naming format used for simple primary identification of this EntityType")]
        [Property(name: "PrimaryIdentifierCustomFormat", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.String, defaultValue: "", typeName: "", allowOverride: false, isOverride: false, isDerived: false)]
        public string PrimaryIdentifierCustomFormat { get; set; }
 
        /// <summary>
        /// Gets or sets a PrimaryIdentifierNamingChoice
        /// </summary>
        [Description("The naming pattern used for simple primary identification of this EntityType")]
        [Property(name: "PrimaryIdentifierNamingChoice", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Enumeration, defaultValue: "ModelDefault", typeName: "ReferenceModeNamingChoice", allowOverride: false, isOverride: false, isDerived: false)]
        public ReferenceModeNamingChoice PrimaryIdentifierNamingChoice { get; set; }
 
    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
