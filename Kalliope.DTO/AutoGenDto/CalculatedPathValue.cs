// -------------------------------------------------------------------------------------------------
// <copyright file="CalculatedPathValue.cs" company="RHEA System S.A.">
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
    public partial class CalculatedPathValue : ORMModelElement
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
        public string AggregationContextRequiredError { get; set; }
 
        /// <summary>
        /// Gets or sets the unique identifier of the contained <see cref="CalculatedPathValueMustBeConsumedError"/>
        /// </summary>
        public string ConsumptionRequiredError { get; set; }
 
        /// <summary>
        /// Gets or sets the unique identifier of the referenced <see cref="Function"/>
        /// </summary>
        public string Function { get; set; }
 
        /// <summary>
        /// Gets or sets the unique identifier of the contained <see cref="CalculatedPathValueRequiresFunctionError"/>
        /// </summary>
        public string FunctionRequiredError { get; set; }
 
        /// <summary>
        /// Gets or sets a list unique identifiers of the contained <see cref="CalculatedPathValueInput"/> instances
        /// </summary>
        public List<string> Inputs { get; set; }
 
        /// <summary>
        /// Gets or sets a list unique identifiers of the contained <see cref="CalculatedPathValueParameterBindingError"/> instances
        /// </summary>
        public List<string> ParameterBindingErrors { get; set; }
 
        /// <summary>
        /// Gets or sets a UniversalAggregationContext
        /// </summary>
        public bool UniversalAggregationContext { get; set; }
 
    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
