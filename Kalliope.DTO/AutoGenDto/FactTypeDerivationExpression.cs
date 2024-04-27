// -------------------------------------------------------------------------------------------------
// <copyright file="FactTypeDerivationExpression.cs" company="Starion Group S.A.">
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
    /// A Data Transfer Object that represents a FactTypeDerivationExpression
    /// </summary>
    /// <remarks>
    /// A derivation expression
    /// </remarks>
    [Container(typeName: "FactType", propertyName: "DerivationExpression")]
    public partial class FactTypeDerivationExpression : Expression
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FactTypeDerivationExpression"/> class.
        /// </summary>
        public FactTypeDerivationExpression()
        {
            this.DerivationStorage = DerivationExpressionStorageType.Derived;
        }
 
        /// <summary>
        /// Gets or sets the unique identifier of the container
        /// </summary>
        public string Container {get; set;}
 

        /// <summary>
        /// Gets or sets a DerivationStorage
        /// </summary>
        [Description("")]
        [Property(name: "DerivationStorage", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Enumeration, defaultValue: "Derived", typeName: "DerivationExpressionStorageType", allowOverride: false, isOverride: false, isDerived: false)]
        public DerivationExpressionStorageType DerivationStorage { get; set; }
 
    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
