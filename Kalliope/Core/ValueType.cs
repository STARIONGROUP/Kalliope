// -------------------------------------------------------------------------------------------------
// <copyright file="ValueType.cs" company="RHEA System S.A.">
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

namespace Kalliope.Core
{
    using Kalliope.Common;
    
    /// <summary>
    /// An object type representing a self-identifying value
    /// </summary>
    [Description("An ObjectType representing a self-identifying value")]
    [Domain(isAbstract: false, general: "ObjectType")]
    public class ValueType : ObjectType
    {
        /// <summary>
        /// Gets or sets the owned <see cref="DataTypeNotSpecifiedError"/>
        /// </summary>
        public DataTypeNotSpecifiedError DataTypeNotSpecifiedError { get; set; }
    }
}
