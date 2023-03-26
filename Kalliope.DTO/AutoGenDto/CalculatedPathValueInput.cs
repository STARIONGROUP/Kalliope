// -------------------------------------------------------------------------------------------------
// <copyright file="CalculatedPathValueInput.cs" company="RHEA System S.A.">
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
    /// A Data Transfer Object that represents a CalculatedPathValueInput
    /// </summary>
    /// <remarks>
    /// An input value or bag passed to a function parameter calculate a value
    /// </remarks>
    [Container(typeName: "CalculatedPathValue", propertyName: "Inputs")]
    public partial class CalculatedPathValueInput : OrmModelElement
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CalculatedPathValueInput"/> class.
        /// </summary>
        public CalculatedPathValueInput()
        {
        }
 
        /// <summary>
        /// Gets or sets the unique identifier of the container
        /// </summary>
        public string Container {get; set;}
 

        /// <summary>
        /// Gets or sets a DistinctValues
        /// </summary>
        [Description("")]
        [Property(name: "DistinctValues", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Boolean, defaultValue: "false", typeName: "", allowOverride: false, isOverride: false, isDerived: false)]
        public bool DistinctValues { get; set; }
 
        /// <summary>
        /// Gets or sets the unique identifier of the referenced <see cref="FunctionParameter"/>
        /// </summary>
        [Description("The function parameter associated with this input value")]
        [Property(name: "Parameter", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "FunctionParameter", allowOverride: false, isOverride: false, isDerived: false)]
        public string Parameter { get; set; }
 
        /// <summary>
        /// Gets or sets the unique identifier of the referenced <see cref="CalculatedPathValue"/>
        /// </summary>
        [Description("The pathed value bound to this function input")]
        [Property(name: "SourceCalculatedValue", aggregation: AggregationKind.None, multiplicity: "0..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "CalculatedPathValue", allowOverride: false, isOverride: false, isDerived: false)]
        public string SourceCalculatedValue { get; set; }
 
        /// <summary>
        /// Gets or sets the unique identifier of the contained <see cref="PathConstant"/>
        /// </summary>
        [Description("The constant value bound to this function input")]
        [Property(name: "SourceConstant", aggregation: AggregationKind.Composite, multiplicity: "0..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "PathConstant", allowOverride: false, isOverride: false, isDerived: false)]
        public string SourceConstant { get; set; }
 
    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
