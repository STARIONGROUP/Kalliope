// -------------------------------------------------------------------------------------------------
// <copyright file="OrmRoot.cs" company="RHEA System S.A.">
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
    /// A Data Transfer Object that represents a OrmRoot
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    public partial class OrmRoot
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrmRoot"/> class.
        /// </summary>
        public  OrmRoot()
        {
            this.Diagrams = new List<Guid>();
        }
 
        /// <summary>
        /// Gets or sets a list unique identifiers of the contained <see cref=""/> instances
        /// </summary>
        public List<Guid> Diagrams { get; set; }
 
        /// <summary>
        /// Gets or sets the unique identifier of the contained <see cref=""/>
        /// </summary>
        public Guid GenerationState { get; set; }
 
        /// <summary>
        /// Gets or sets the unique identifier of the contained <see cref="ORMModel"/>
        /// </summary>
        public Guid Model { get; set; }
 
        /// <summary>
        /// Gets or sets the unique identifier of the contained <see cref=""/>
        /// </summary>
        public Guid NameGenerator { get; set; }
 
    }
}