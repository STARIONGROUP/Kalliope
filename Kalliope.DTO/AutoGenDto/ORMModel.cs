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
        public  ORMModel()
        {
            this.DataTypes = new List<Guid>();
            this.Errors = new List<Guid>();
            this.FactTypes = new List<Guid>();
            this.Functions = new List<Guid>();
            this.Notes = new List<Guid>();
            this.ObjectTypes = new List<Guid>();
            this.RecognizedPhrases = new List<Guid>();
            this.ReferenceModeKinds = new List<Guid>();
            this.ReferenceModes = new List<Guid>();
            this.SetComparisonConstraints = new List<Guid>();
            this.SetConstraints = new List<Guid>();
        }
 
        /// <summary>
        /// Gets or sets a list unique identifiers of the contained <see cref="DataType"/> instances
        /// </summary>
        public List<Guid> DataTypes { get; set; }
 
        /// <summary>
        /// Gets or sets the unique identifier of the contained <see cref="Definition"/>
        /// </summary>
        public Guid Definition { get; set; }
 
        /// <summary>
        /// Gets or sets a list unique identifiers of the contained <see cref="ModelError"/> instances
        /// </summary>
        public List<Guid> Errors { get; set; }
 
        /// <summary>
        /// Gets or sets a list unique identifiers of the contained <see cref="FactType"/> instances
        /// </summary>
        public List<Guid> FactTypes { get; set; }
 
        /// <summary>
        /// Gets or sets a list unique identifiers of the contained <see cref="Function"/> instances
        /// </summary>
        public List<Guid> Functions { get; set; }
 
        /// <summary>
        /// Gets or sets the unique identifier of the contained <see cref="ModelErrorDisplayFilter"/>
        /// </summary>
        public Guid ModelErrorDisplayFilter { get; set; }
 
        /// <summary>
        /// Gets or sets the unique identifier of the contained <see cref="Note"/>
        /// </summary>
        public Guid Note { get; set; }
 
        /// <summary>
        /// Gets or sets a list unique identifiers of the contained <see cref="ModelNote"/> instances
        /// </summary>
        public List<Guid> Notes { get; set; }
 
        /// <summary>
        /// Gets or sets a list unique identifiers of the contained <see cref="ObjectType"/> instances
        /// </summary>
        public List<Guid> ObjectTypes { get; set; }
 
        /// <summary>
        /// Gets or sets a list unique identifiers of the contained <see cref="RecognizedPhrase"/> instances
        /// </summary>
        public List<Guid> RecognizedPhrases { get; set; }
 
        /// <summary>
        /// Gets or sets a list unique identifiers of the contained <see cref="ReferenceModeKind"/> instances
        /// </summary>
        public List<Guid> ReferenceModeKinds { get; set; }
 
        /// <summary>
        /// Gets or sets a list unique identifiers of the contained <see cref="ReferenceMode"/> instances
        /// </summary>
        public List<Guid> ReferenceModes { get; set; }
 
        /// <summary>
        /// Gets or sets a list unique identifiers of the contained <see cref="SetComparisonConstraint"/> instances
        /// </summary>
        public List<Guid> SetComparisonConstraints { get; set; }
 
        /// <summary>
        /// Gets or sets a list unique identifiers of the contained <see cref="SetConstraint"/> instances
        /// </summary>
        public List<Guid> SetConstraints { get; set; }
 
    }
}
