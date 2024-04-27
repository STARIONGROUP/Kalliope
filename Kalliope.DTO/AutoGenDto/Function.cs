// -------------------------------------------------------------------------------------------------
// <copyright file="Function.cs" company="Starion Group S.A.">
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
    /// A Data Transfer Object that represents a Function
    /// </summary>
    /// <remarks>
    /// A function or operator used to represented a calculation algorithm.
    /// </remarks>
    [Container(typeName: "OrmModel", propertyName: "Functions")]
    public partial class Function : OrmNamedElement
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Function"/> class.
        /// </summary>
        public Function()
        {
            this.Parameters = new List<string>();
        }
 
        /// <summary>
        /// Gets or sets the unique identifier of the container
        /// </summary>
        public string Container {get; set;}
 

        /// <summary>
        /// Gets or sets the unique identifier of the referenced <see cref="FunctionDuplicateNameError"/>
        /// </summary>
        [Description("")]
        [Property(name: "DuplicateNameError", aggregation: AggregationKind.None, multiplicity: "0..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "FunctionDuplicateNameError", allowOverride: false, isOverride: false, isDerived: false)]
        public string DuplicateNameError { get; set; }
 
        /// <summary>
        /// Gets or sets a IsAggregate
        /// </summary>
        [Description("Set if this function defines a bag input parameter")]
        [Property(name: "IsAggregate", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Boolean, defaultValue: "false", typeName: "", allowOverride: false, isOverride: false, isDerived: false)]
        public bool IsAggregate { get; set; }
 
        /// <summary>
        /// Gets or sets a IsBoolean
        /// </summary>
        [Description("Set if this function returns a boolean value that can be evaluated directly as a condition")]
        [Property(name: "IsBoolean", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Boolean, defaultValue: "false", typeName: "", allowOverride: false, isOverride: false, isDerived: false)]
        public bool IsBoolean { get; set; }
 
        /// <summary>
        /// Gets or sets a OperatorSymbol
        /// </summary>
        [Description("A string indicating this function should be displayed as an operator instead of using functional notation. Represents infix notation for a binary operator and prefix notation for a unary")]
        [Property(name: "OperatorSymbol", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.String, defaultValue: "", typeName: "", allowOverride: false, isOverride: false, isDerived: false)]
        public string OperatorSymbol { get; set; }
 
        /// <summary>
        /// Gets or sets a list unique identifiers of the contained <see cref="FunctionParameter"/> instances
        /// </summary>
        [Description("Parameters defined by this function")]
        [Property(name: "Parameters", aggregation: AggregationKind.Composite, multiplicity: "0..*", typeKind: TypeKind.Object, defaultValue: "", typeName: "FunctionParameter", allowOverride: false, isOverride: false, isDerived: false)]
        public List<string> Parameters { get; set; }
 
    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
