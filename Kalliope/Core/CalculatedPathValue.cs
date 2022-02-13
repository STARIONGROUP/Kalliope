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

namespace Kalliope.Core
{
    using System.Collections.Generic;

    /// <summary>
    /// A calculated value used in a role path
    /// </summary>
    public class CalculatedPathValue : ORMModelElement
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CalculatedPathValue"/> class
        /// </summary>
        public CalculatedPathValue()
        {
            this.Inputs = new List<CalculatedPathValueInput>();
            this.ParameterBindingErrors = new List<CalculatedPathValueParameterBindingError>();
        }

        /// <summary>
        /// Set for a calculation with an aggregate function to use universal context (meaning all elements of the given type in the universal of discourse)
        /// instead of a context at one or more specific path nodes
        /// </summary>
        public bool UniversalAggregationContext { get; set; }

        /// <summary>
        /// Gets or sets the Inputs used to calculate this value
        /// </summary>
        public List<CalculatedPathValueInput> Inputs { get; set; }

        /// <summary>
        /// Gets or sets the owned <see cref="CalculatedPathValueRequiresFunctionError"/>
        /// </summary>
        public CalculatedPathValueRequiresFunctionError FunctionRequiredError { get; set; }

        /// <summary>
        /// Gets or sets the owned list of <see cref="CalculatedPathValueParameterBindingError"/>
        /// </summary>
        public List<CalculatedPathValueParameterBindingError> ParameterBindingErrors { get; set; }

        /// <summary>
        /// Gets or sets the owned <see cref="CalculatedPathValueMustBeConsumedError"/>
        /// </summary>
        public CalculatedPathValueMustBeConsumedError ConsumptionRequiredError { get; set; }

        /// <summary>
        /// Gets or sets the owned <see cref="CalculatedPathValueRequiresAggregationContextError"/>
        /// </summary>
        public CalculatedPathValueRequiresAggregationContextError AggregationContextRequiredError { get; set; }
    }
}
