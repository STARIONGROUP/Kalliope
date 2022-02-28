// -------------------------------------------------------------------------------------------------
// <copyright file="ORMModel.cs" company="RHEA System S.A.">
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
    /// A Data Transfer Object that represents a ORMModel
    /// </summary>
    /// <remarks>
    /// Definition of elements used in the primary definition of an ORM model
    /// </remarks>
    public partial class ORMModel : ORMNamedElement
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ORMModel"/> class.
        /// </summary>
        public ORMModel()
        {
            this.DataTypes = new List<string>();
            this.Errors = new List<string>();
            this.FactTypes = new List<string>();
            this.Functions = new List<string>();
            this.Notes = new List<string>();
            this.ObjectTypes = new List<string>();
            this.RecognizedPhrases = new List<string>();
            this.ReferenceModeKinds = new List<string>();
            this.ReferenceModes = new List<string>();
            this.SetComparisonConstraints = new List<string>();
            this.SetConstraints = new List<string>();
        }
 

        /// <summary>
        /// Gets or sets a list unique identifiers of the contained <see cref="DataType"/> instances
        /// </summary>
        public List<string> DataTypes { get; set; }
 
        /// <summary>
        /// Gets or sets the unique identifier of the contained <see cref="Definition"/>
        /// </summary>
        public string Definition { get; set; }
 
        /// <summary>
        /// Gets or sets a list unique identifiers of the contained <see cref="ModelError"/> instances
        /// </summary>
        public List<string> Errors { get; set; }
 
        /// <summary>
        /// Gets or sets a list unique identifiers of the contained <see cref="FactType"/> instances
        /// </summary>
        public List<string> FactTypes { get; set; }
 
        /// <summary>
        /// Gets or sets a list unique identifiers of the contained <see cref="Function"/> instances
        /// </summary>
        public List<string> Functions { get; set; }
 
        /// <summary>
        /// Gets or sets the unique identifier of the contained <see cref="ModelErrorDisplayFilter"/>
        /// </summary>
        public string ModelErrorDisplayFilter { get; set; }
 
        /// <summary>
        /// Gets or sets the unique identifier of the contained <see cref="Note"/>
        /// </summary>
        public string Note { get; set; }
 
        /// <summary>
        /// Gets or sets a list unique identifiers of the contained <see cref="ModelNote"/> instances
        /// </summary>
        public List<string> Notes { get; set; }
 
        /// <summary>
        /// Gets or sets a list unique identifiers of the contained <see cref="ObjectType"/> instances
        /// </summary>
        public List<string> ObjectTypes { get; set; }
 
        /// <summary>
        /// Gets or sets a list unique identifiers of the contained <see cref="RecognizedPhrase"/> instances
        /// </summary>
        public List<string> RecognizedPhrases { get; set; }
 
        /// <summary>
        /// Gets or sets a list unique identifiers of the contained <see cref="ReferenceModeKind"/> instances
        /// </summary>
        public List<string> ReferenceModeKinds { get; set; }
 
        /// <summary>
        /// Gets or sets a list unique identifiers of the contained <see cref="ReferenceMode"/> instances
        /// </summary>
        public List<string> ReferenceModes { get; set; }
 
        /// <summary>
        /// Gets or sets a list unique identifiers of the contained <see cref="SetComparisonConstraint"/> instances
        /// </summary>
        public List<string> SetComparisonConstraints { get; set; }
 
        /// <summary>
        /// Gets or sets a list unique identifiers of the contained <see cref="SetConstraint"/> instances
        /// </summary>
        public List<string> SetConstraints { get; set; }
 
    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
