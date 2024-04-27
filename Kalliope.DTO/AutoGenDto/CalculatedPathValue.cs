// -------------------------------------------------------------------------------------------------
// <copyright file="CalculatedPathValue.cs" company="Starion Group S.A.">
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
    /// A Data Transfer Object that represents a CalculatedPathValue
    /// </summary>
    /// <remarks>
    /// A calculated value used in a role path
    /// </remarks>
    [Container(typeName: "LeadRolePath", propertyName: "CalculatedValues")]
    public partial class CalculatedPathValue : OrmModelElement
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CalculatedPathValue"/> class.
        /// </summary>
        public CalculatedPathValue()
        {
            this.Inputs = new List<string>();
            this.ParameterBindingErrors = new List<string>();
        }
 
        /// <summary>
        /// Gets or sets the unique identifier of the container
        /// </summary>
        public string Container {get; set;}
 

        /// <summary>
        /// Gets or sets the unique identifier of the contained <see cref="CalculatedPathValueRequiresAggregationContextError"/>
        /// </summary>
        [Description("")]
        [Property(name: "AggregationContextRequiredError", aggregation: AggregationKind.Composite, multiplicity: "0..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "CalculatedPathValueRequiresAggregationContextError", allowOverride: false, isOverride: false, isDerived: false)]
        public string AggregationContextRequiredError { get; set; }
 
        /// <summary>
        /// Gets or sets the unique identifier of the contained <see cref="CalculatedPathValueMustBeConsumedError"/>
        /// </summary>
        [Description("")]
        [Property(name: "ConsumptionRequiredError", aggregation: AggregationKind.Composite, multiplicity: "0..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "CalculatedPathValueMustBeConsumedError", allowOverride: false, isOverride: false, isDerived: false)]
        public string ConsumptionRequiredError { get; set; }
 
        /// <summary>
        /// Gets or sets the unique identifier of the referenced <see cref="Function"/>
        /// </summary>
        [Description("The Function used to calculate this value")]
        [Property(name: "Function", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "Function", allowOverride: false, isOverride: false, isDerived: false)]
        public string Function { get; set; }
 
        /// <summary>
        /// Gets or sets the unique identifier of the contained <see cref="CalculatedPathValueRequiresFunctionError"/>
        /// </summary>
        [Description("")]
        [Property(name: "FunctionRequiredError", aggregation: AggregationKind.Composite, multiplicity: "0..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "CalculatedPathValueRequiresFunctionError", allowOverride: false, isOverride: false, isDerived: false)]
        public string FunctionRequiredError { get; set; }
 
        /// <summary>
        /// Gets or sets a list unique identifiers of the contained <see cref="CalculatedPathValueInput"/> instances
        /// </summary>
        [Description("Inputs used to calculate this value")]
        [Property(name: "Inputs", aggregation: AggregationKind.Composite, multiplicity: "0..*", typeKind: TypeKind.Object, defaultValue: "", typeName: "CalculatedPathValueInput", allowOverride: false, isOverride: false, isDerived: false)]
        public List<string> Inputs { get; set; }
 
        /// <summary>
        /// Gets or sets a list unique identifiers of the contained <see cref="CalculatedPathValueParameterBindingError"/> instances
        /// </summary>
        [Description("")]
        [Property(name: "ParameterBindingErrors", aggregation: AggregationKind.Composite, multiplicity: "0..*", typeKind: TypeKind.Object, defaultValue: "", typeName: "CalculatedPathValueParameterBindingError", allowOverride: false, isOverride: false, isDerived: false)]
        public List<string> ParameterBindingErrors { get; set; }
 
        /// <summary>
        /// Gets or sets a UniversalAggregationContext
        /// </summary>
        [Description("Set for a calculation with an aggregate function to use universal context (meaning all elements of the given type in the universal of discourse) instead of a context at one or more specific path nodes")]
        [Property(name: "UniversalAggregationContext", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Boolean, defaultValue: "", typeName: "false", allowOverride: false, isOverride: false, isDerived: false)]
        public bool UniversalAggregationContext { get; set; }
 
    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
