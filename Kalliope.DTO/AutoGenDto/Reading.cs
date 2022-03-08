// -------------------------------------------------------------------------------------------------
// <copyright file="Reading.cs" company="RHEA System S.A.">
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
    /// A Data Transfer Object that represents a Reading
    /// </summary>
    [Container(typeName: "ReadingOrder", propertyName: "Readings")]
    public partial class Reading : ORMModelElement
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Reading"/> class.
        /// </summary>
        public Reading()
        {
            this.ExpandedData = new List<string>();
        }
 
        /// <summary>
        /// Gets or sets the unique identifier of the container
        /// </summary>
        public string Container {get; set;}
 

        /// <summary>
        /// Gets or sets a Data
        /// </summary>
        public string Data { get; set; }
 
        /// <summary>
        /// Gets or sets the unique identifier of the referenced <see cref="DuplicateReadingSignatureError"/>
        /// </summary>
        public string DuplicateSignatureError { get; set; }
 
        /// <summary>
        /// Gets or sets a list unique identifiers of the contained <see cref="RoleText"/> instances
        /// </summary>
        public List<string> ExpandedData { get; set; }
 
        /// <summary>
        /// Gets or sets a IsPrimaryForFactType
        /// </summary>
        public bool IsPrimaryForFactType { get; set; }
 
        /// <summary>
        /// Gets or sets a IsPrimaryForReadingOrder
        /// </summary>
        public bool IsPrimaryForReadingOrder { get; set; }
 
        /// <summary>
        /// Gets or sets a Language
        /// </summary>
        public string Language { get; set; }
 
        /// <summary>
        /// Gets or sets the unique identifier of the contained <see cref="ReadingRequiresUserModificationError"/>
        /// </summary>
        public string RequiresUserModificationError { get; set; }
 
        /// <summary>
        /// Gets or sets a Signature
        /// </summary>
        public string Signature { get; set; }
 
        /// <summary>
        /// Gets or sets a Text
        /// </summary>
        public string Text { get; set; }
 
        /// <summary>
        /// Gets or sets the unique identifier of the contained <see cref="TooFewReadingRolesError"/>
        /// </summary>
        public string TooFewRolesError { get; set; }
 
        /// <summary>
        /// Gets or sets the unique identifier of the contained <see cref="TooManyReadingRolesError"/>
        /// </summary>
        public string TooManyRolesError { get; set; }
 
    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
