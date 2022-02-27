// -------------------------------------------------------------------------------------------------
// <copyright file="ValueTypeInstance.cs" company="RHEA System S.A.">
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
    /// A Data Transfer Object that represents a ValueTypeInstance
    /// </summary>
    public partial class ValueTypeInstance : ObjectTypeInstance
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ValueTypeInstance"/> class.
        /// </summary>
        public  ValueTypeInstance()
        {
        }
 
        /// <summary>
        /// Gets or sets the unique identifier of the contained <see cref="CompatibleValueTypeInstanceValueError"/>
        /// </summary>
        public Guid CompatibleValueTypeInstanceValueError { get; set; }
 
        /// <summary>
        /// Gets or sets a InvariantValue
        /// </summary>
        public string InvariantValue { get; set; }
 
        /// <summary>
        /// Gets or sets a Value
        /// </summary>
        public string Value { get; set; }
 
    }
}
