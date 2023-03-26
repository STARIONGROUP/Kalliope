// -------------------------------------------------------------------------------------------------
// <copyright file="PathSameFactTypeRoleFollowsJoinError.cs" company="RHEA System S.A.">
//
//   Copyright 2022-2023 RHEA System S.A.
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
    /// A PathedRole with a purpose of SameFactType must follow an entry into the fact type with a join or start role. 
    /// A role within a single fact type cannot be reused in a path without first joining to another instance of the same fact type
    /// </summary>
    [Description("A role in a fact type was used without a join role entering that fact type, or a role from a single fact type was used multiple times without an intermediate join")]
    [Domain(isAbstract: false, general: "ModelError")]
    public class PathSameFactTypeRoleFollowsJoinError : ModelError
    {
    }
}
