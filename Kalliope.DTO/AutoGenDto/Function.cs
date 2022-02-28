// -------------------------------------------------------------------------------------------------
// <copyright file="Function.cs" company="RHEA System S.A.">
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
    /// A Data Transfer Object that represents a Function
    /// </summary>
    /// <remarks>
    /// A function or operator used to represented a calculation algorithm.
    /// </remarks>
    public partial class Function : ORMNamedElement
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
        public string DuplicateNameError { get; set; }
 
        /// <summary>
        /// Gets or sets a IsAggregate
        /// </summary>
        public bool IsAggregate { get; set; }
 
        /// <summary>
        /// Gets or sets a IsBoolean
        /// </summary>
        public bool IsBoolean { get; set; }
 
        /// <summary>
        /// Gets or sets a OperatorSymbol
        /// </summary>
        public string OperatorSymbol { get; set; }
 
        /// <summary>
        /// Gets or sets a list unique identifiers of the contained <see cref="FunctionParameter"/> instances
        /// </summary>
        public List<string> Parameters { get; set; }
 
    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
