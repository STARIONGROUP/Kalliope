﻿// -------------------------------------------------------------------------------------------------
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

namespace Kalliope.Core
{
    using System.Collections.Generic;

    using Kalliope.Common;

    [Description("")]
    [Domain(isAbstract: true, general: "OrmModelElement")]
    [Container(typeName: "ObjectType", propertyName: "ObjectTypeInstances")]
    public abstract class ObjectTypeInstance : OrmModelElement
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectTypeInstance"/> class
        /// </summary>
        protected ObjectTypeInstance()
        {
            this.PopulationMandatoryErrors = new List<PopulationMandatoryError>();
        }

        /// <summary>
        /// An ordered tuple of values for this instance, ignores objectification of the associated <see cref="ObjectType"/>
        /// </summary>
        [Description("An ordered tuple of values for this instance, ignores objectification of the associated ObjectType")]
        [Property(name: "IdentifierName", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.String, defaultValue: "", typeName: "")]
        public string IdentifierName { get; set; }

        /// <summary>
        /// Gets or sets the owned <see cref="ObjectifiedInstanceRequiredError"/>
        /// </summary>
        [Description("")]
        [Property(name: "ObjectifiedInstanceRequiredError", aggregation: AggregationKind.Composite, multiplicity: "0..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "ObjectifiedInstanceRequiredError")]
        public ObjectifiedInstanceRequiredError ObjectifiedInstanceRequiredError { get; set; }

        /// <summary>
        /// Gets or sets the contained <see cref="PopulationMandatoryError"/>s
        /// </summary>
        [Description("")]
        [Property(name: "PopulationMandatoryErrors", aggregation: AggregationKind.Composite, multiplicity: "0..*", typeKind: TypeKind.Object, defaultValue: "", typeName: "PopulationMandatoryError")]
        public List<PopulationMandatoryError> PopulationMandatoryErrors { get; set; }
    }
}
