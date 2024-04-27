// -------------------------------------------------------------------------------------------------
// <copyright file="ObjectTypeInstance.cs" company="Starion Group S.A.">
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
    /// A Data Transfer Object that represents a ObjectTypeInstance
    /// </summary>
    [Container(typeName: "ObjectType", propertyName: "ObjectTypeInstances")]
    public abstract partial class ObjectTypeInstance : OrmModelElement
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectTypeInstance"/> class.
        /// </summary>
        protected ObjectTypeInstance()
        {
            this.PopulationMandatoryErrors = new List<string>();
        }
 
        /// <summary>
        /// Gets or sets the unique identifier of the container
        /// </summary>
        public string Container {get; set;}
 

        /// <summary>
        /// Gets or sets a IdentifierName
        /// </summary>
        [Description("An ordered tuple of values for this instance, ignores objectification of the associated ObjectType")]
        [Property(name: "IdentifierName", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.String, defaultValue: "", typeName: "", allowOverride: false, isOverride: false, isDerived: false)]
        public string IdentifierName { get; set; }
 
        /// <summary>
        /// Gets or sets the unique identifier of the contained <see cref="ObjectifiedInstanceRequiredError"/>
        /// </summary>
        [Description("")]
        [Property(name: "ObjectifiedInstanceRequiredError", aggregation: AggregationKind.Composite, multiplicity: "0..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "ObjectifiedInstanceRequiredError", allowOverride: false, isOverride: false, isDerived: false)]
        public string ObjectifiedInstanceRequiredError { get; set; }
 
        /// <summary>
        /// Gets or sets a list unique identifiers of the contained <see cref="PopulationMandatoryError"/> instances
        /// </summary>
        [Description("")]
        [Property(name: "PopulationMandatoryErrors", aggregation: AggregationKind.Composite, multiplicity: "0..*", typeKind: TypeKind.Object, defaultValue: "", typeName: "PopulationMandatoryError", allowOverride: false, isOverride: false, isDerived: false)]
        public List<string> PopulationMandatoryErrors { get; set; }
 
    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
