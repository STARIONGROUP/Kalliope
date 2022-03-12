// -------------------------------------------------------------------------------------------------
// <copyright file="FactTypeInstance.cs" company="RHEA System S.A.">
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
    /// A Data Transfer Object that represents a FactTypeInstance
    /// </summary>
    [Container(typeName: "FactType", propertyName: "FactTypeInstances")]
    public partial class FactTypeInstance : ORMModelElement
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FactTypeInstance"/> class.
        /// </summary>
        public FactTypeInstance()
        {
        }
 
        /// <summary>
        /// Gets or sets the unique identifier of the container
        /// </summary>
        public string Container {get; set;}
 

        /// <summary>
        /// Gets or sets a Name
        /// </summary>
        [Description("")]
        [Property(name: "Name", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.String, defaultValue: "", typeName: "")]
        public string Name { get; set; }
 
        /// <summary>
        /// Gets or sets the unique identifier of the referenced <see cref="ObjectTypeInstance"/>
        /// </summary>
        [Description("")]
        [Property(name: "ObjectifiedInstance", aggregation: AggregationKind.None, multiplicity: "0..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "ObjectTypeInstance")]
        public string ObjectifiedInstance { get; set; }
 
        /// <summary>
        /// Gets or sets the unique identifier of the contained <see cref="ObjectifyingInstanceRequiredError"/>
        /// </summary>
        [Description("")]
        [Property(name: "ObjectifyingInstanceRequiredError", aggregation: AggregationKind.Composite, multiplicity: "0..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "ObjectifyingInstanceRequiredError")]
        public string ObjectifyingInstanceRequiredError { get; set; }
 
        /// <summary>
        /// Gets or sets the unique identifier of the contained <see cref="TooFewFactTypeRoleInstancesError"/>
        /// </summary>
        [Description("")]
        [Property(name: "TooFewFactTypeRoleInstancesError", aggregation: AggregationKind.Composite, multiplicity: "0..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "TooFewFactTypeRoleInstancesError")]
        public string TooFewFactTypeRoleInstancesError { get; set; }
 
    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
