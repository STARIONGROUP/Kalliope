// -------------------------------------------------------------------------------------------------
// <copyright file="ORMDiagram.cs" company="RHEA System S.A.">
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
    /// 
    /// </summary>
    public  partial class ORMDiagram
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ORMDiagram"/> class.
        /// </summary>
        public  ORMDiagram()
        {
            this.ExternalConstraintShapes = new List<Guid>();
            this.FactTypeShapes = new List<Guid>();
            this.FrequencyConstraintShapes = new List<Guid>();
            this.ModelNoteShapes = new List<Guid>();
            this.ObjectTypeShapes = new List<Guid>();
            this.RingConstraintShapes = new List<Guid>();
            this.ValueComparisonConstraintShapes = new List<Guid>();
        }
 
        /// <summary>
        /// Gets or sets a AutoPopulateShapes
        /// </summary>
        public bool AutoPopulateShapes { get; set; }
 
        /// <summary>
        /// Gets or sets a BaseFontName
        /// </summary>
        public string BaseFontName { get; set; }
 
        /// <summary>
        /// Gets or sets a BaseFontSize
        /// </summary>
        public double BaseFontSize { get; set; }
 
        /// <summary>
        /// Gets or sets a list unique identifiers of the contained <see cref="ExternalConstraintShape"/> instances
        /// </summary>
        public List<Guid> ExternalConstraintShapes { get; set; }
 
        /// <summary>
        /// Gets or sets a list unique identifiers of the contained <see cref="FactTypeShape"/> instances
        /// </summary>
        public List<Guid> FactTypeShapes { get; set; }
 
        /// <summary>
        /// Gets or sets a list unique identifiers of the contained <see cref="FrequencyConstraintShape"/> instances
        /// </summary>
        public List<Guid> FrequencyConstraintShapes { get; set; }
 
        /// <summary>
        /// Gets or sets a Id
        /// </summary>
        public string Id { get; set; }
 
        /// <summary>
        /// Gets or sets a IsCompleteView
        /// </summary>
        public bool IsCompleteView { get; set; }
 
        /// <summary>
        /// Gets or sets a list unique identifiers of the contained <see cref="ModelNoteShape"/> instances
        /// </summary>
        public List<Guid> ModelNoteShapes { get; set; }
 
        /// <summary>
        /// Gets or sets a Name
        /// </summary>
        public string Name { get; set; }
 
        /// <summary>
        /// Gets or sets a list unique identifiers of the contained <see cref="ObjectTypeShape"/> instances
        /// </summary>
        public List<Guid> ObjectTypeShapes { get; set; }
 
        /// <summary>
        /// Gets or sets a list unique identifiers of the contained <see cref="RingConstraintShape"/> instances
        /// </summary>
        public List<Guid> RingConstraintShapes { get; set; }
 
        /// <summary>
        /// Gets or sets the unique identifier of the referenced <see cref="ORMModel"/>
        /// </summary>
        public Guid Subject { get; set; }
 
        /// <summary>
        /// Gets or sets a list unique identifiers of the contained <see cref="ValueComparisonConstraintShape"/> instances
        /// </summary>
        public List<Guid> ValueComparisonConstraintShapes { get; set; }
 
    }
}
