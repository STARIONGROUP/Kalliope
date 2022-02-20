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

namespace Kalliope.Core
{
    using System;

    using Kalliope.Attributes;

    /// <summary>
    /// Specify how a role in a path is used to step within and between fact types
    /// </summary>
    [Description("Specify how a role in a path is used to step within and between fact types")]
    public enum PathedRolePurpose
    {
        /// <summary>
        /// The role is the same fact type as the previous join or start role
        /// </summary>
        /// <remarks>
        /// (DSL) The role is the same fact type as the previous join or start role
        /// </remarks>
        [Description("The role is the same fact type as the previous join or start role")]
        SameFactType = 0,

        /// <summary>
        /// The role represents an inner over a role player shared with the previous role in the path
        /// </summary>
        /// <remarks>
        /// (DSL) The role represents an inner over a role player shared with the previous role in the path
        /// </remarks>
        [Description("The role represents an inner over a role player shared with the previous role in the path")]
        PostInnerJoin = 1,

        /// <summary>
        /// The role represents an outer join over a role player shared with the previous role in the path
        /// </summary>
        /// <remarks>
        /// (DSL) The role represents an outer join over a role player shared with the previous role in the path
        /// </remarks>
        [Description("The role represents an outer join over a role player shared with the previous role in the path")]
        PostOuterJoin = 2,

        /// <summary>
        /// The role is the beginning of a path and directly attached to the root object type
        /// </summary>
        /// <remarks>
        /// (DSL) The role is the beginning of a path and directly attached to the root object type
        /// </remarks>
        [Obsolete("Replaced by root projection and function input support and the PostInnerJoin value")]
        [Description("The role is the beginning of a path and directly attached to the root object type")]
        StartRole = -2,
    }
}
