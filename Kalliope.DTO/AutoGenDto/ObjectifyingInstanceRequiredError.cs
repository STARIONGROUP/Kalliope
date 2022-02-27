// -------------------------------------------------------------------------------------------------
// <copyright file="ObjectifyingInstanceRequiredError.cs" company="RHEA System S.A.">
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
    /// A Data Transfer Object that represents a ObjectifyingInstanceRequiredError
    /// </summary>
    /// <remarks>
    /// Missing Objectifying EntityType Instance
    /// </remarks>
    public partial class ObjectifyingInstanceRequiredError : ModelError
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectifyingInstanceRequiredError"/> class.
        /// </summary>
        public  ObjectifyingInstanceRequiredError()
        {
        }
 
    }
}
