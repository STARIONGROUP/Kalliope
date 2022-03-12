// -------------------------------------------------------------------------------------------------
// <copyright file="Note.cs" company="RHEA System S.A.">
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
    /// A Data Transfer Object that represents a Note
    /// </summary>
    [Container(typeName: "CardinalityConstraint", propertyName: "Note")]
    [Container(typeName: "ElementGrouping", propertyName: "Note")]
    [Container(typeName: "FactType", propertyName: "Note")]
    [Container(typeName: "LeadRolePath", propertyName: "Note")]
    [Container(typeName: "ObjectType", propertyName: "Note")]
    [Container(typeName: "ORMModel", propertyName: "Note")]
    [Container(typeName: "SetComparisonConstraint", propertyName: "Note")]
    [Container(typeName: "SetConstraint", propertyName: "Note")]
    [Container(typeName: "ValueConstraint", propertyName: "Note")]
    public partial class Note : ORMModelElement
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Note"/> class.
        /// </summary>
        public Note()
        {
        }
 
        /// <summary>
        /// Gets or sets the unique identifier of the container
        /// </summary>
        public string Container {get; set;}
 

        /// <summary>
        /// Gets or sets a Text
        /// </summary>
        [Description("The note contents")]
        [Property(name: "Text", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.String, defaultValue: "", typeName: "")]
        public string Text { get; set; }
 
    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
