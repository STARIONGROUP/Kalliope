// -------------------------------------------------------------------------------------------------
// <copyright file="ModelNote.cs" company="RHEA System S.A.">
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
    public  partial class ModelNote : Note
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ModelNote"/> class.
        /// </summary>
        public  ModelNote()
        {
            this.Elements = new List<Guid>();
            this.FactTypes = new List<Guid>();
            this.ObjectTypes = new List<Guid>();
            this.SetComparisonConstraints = new List<string>();
            this.SetConstraints = new List<Guid>();
        }
 
        /// <summary>
        /// Gets or sets a list unique identifiers of the referenced <see cref="ORMModelElement"/> instances
        /// </summary>
        public List<Guid> Elements { get; set; }
 
        /// <summary>
        /// Gets or sets a list unique identifiers of the referenced <see cref="FactType"/> instances
        /// </summary>
        public List<Guid> FactTypes { get; set; }
 
        /// <summary>
        /// Gets or sets a list unique identifiers of the referenced <see cref="ObjectType"/> instances
        /// </summary>
        public List<Guid> ObjectTypes { get; set; }
 
        /// <summary>
        /// Gets or sets a list of SetComparisonConstraints
        /// </summary>
        public List<string> SetComparisonConstraints { get; set; }
 
        /// <summary>
        /// Gets or sets a list unique identifiers of the referenced <see cref="SetConstraint"/> instances
        /// </summary>
        public List<Guid> SetConstraints { get; set; }
 
    }
}
