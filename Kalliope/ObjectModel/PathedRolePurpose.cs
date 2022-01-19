// -------------------------------------------------------------------------------------------------
// <copyright file="PathedRolePurpose.cs" company="RHEA System S.A.">
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

namespace Kalliope.ObjectModel
{
    /// <summary>
    /// Specify how a role in a path is used to step within and between fact types
    /// </summary>
    public enum PathedRolePurpose
    {
        /// <summary>
        /// The role is the beginning of a path and directly attached to the root object type
        /// </summary>
        StartRole,

        /// <summary>
        /// The role is the same fact type as the previous join or start role
        /// </summary>
        SameFactType,

        /// <summary>
        /// The role represents an inner over a role player shared with the previous role in the path
        /// </summary>
        PostInnerJoin,

        /// <summary>
        /// The role represents an outer join over a role player shared with the previous role in the path
        /// </summary>
        PostOuterJoin
    }
}
