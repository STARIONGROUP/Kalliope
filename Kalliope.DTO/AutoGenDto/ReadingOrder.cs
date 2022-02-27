// -------------------------------------------------------------------------------------------------
// <copyright file="ReadingOrder.cs" company="RHEA System S.A.">
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
    /// A Data Transfer Object that represents a ReadingOrder
    /// </summary>
    public partial class ReadingOrder : ORMModelElement
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReadingOrder"/> class.
        /// </summary>
        public  ReadingOrder()
        {
            this.Readings = new List<Guid>();
            this.Roles = new List<Guid>();
        }
 
        /// <summary>
        /// Gets or sets a list unique identifiers of the contained <see cref="Reading"/> instances
        /// </summary>
        public List<Guid> Readings { get; set; }
 
        /// <summary>
        /// Gets or sets a ReadingText
        /// </summary>
        public string ReadingText { get; set; }
 
        /// <summary>
        /// Gets or sets a list unique identifiers of the referenced <see cref="RoleBase"/> instances
        /// </summary>
        public List<Guid> Roles { get; set; }
 
    }
}
