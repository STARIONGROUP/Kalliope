// -------------------------------------------------------------------------------------------------
// <copyright file="DiagramDynamicColor.cs" company="Starion Group S.A.">
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
    /// A Data Transfer Object that represents a DiagramDynamicColor
    /// </summary>
    [Container(typeName: "HierarchyColorScheme", propertyName: "TopLevel")]
    [Container(typeName: "HierarchyColorScheme", propertyName: "Absorbed")]
    [Container(typeName: "HierarchyColorScheme", propertyName: "NotIncluded")]
    [Container(typeName: "HierarchyColorScheme", propertyName: "AbsorptionAttachPoint")]
    [Container(typeName: "HierarchyColorScheme", propertyName: "PrimaryLocation")]
    [Container(typeName: "HierarchyColorScheme", propertyName: "ReferenceLocation")]
    public partial class DiagramDynamicColor : DynamicColor
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DiagramDynamicColor"/> class.
        /// </summary>
        public DiagramDynamicColor()
        {
        }
 
        /// <summary>
        /// Gets or sets the unique identifier of the container
        /// </summary>
        public string Container {get; set;}
 
    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
