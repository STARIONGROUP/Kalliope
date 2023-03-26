// -------------------------------------------------------------------------------------------------
// <copyright file="DisplayRoleNames.cs" company="RHEA System S.A.">
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

namespace Kalliope.Common
{
    /// <summary>
    /// Determines whether RoleNameShapes will be drawn for the Roles in the <see cref="FactType"/> represented by the
    /// <see cref="FactTypeShape"/> using this enumeration, overriding the global setting
    /// </summary>
    [Description("Determines whether RoleNameShapes will be drawn for the Roles in the FactType represented by the FactTypeShape using this enumeration, overriding the global setting")]
    public enum DisplayRoleNames
    {
        /// <summary>
        /// Use the global setting
        /// </summary>
        [Description("Use the global setting")]
        UserDefault = 0,

        /// <summary>
        /// Always draw the RoleNameShapes
        /// </summary>
        [Description("Always draw the RoleNameShapes")]
        On = 1,

        /// <summary>
        /// Never draw the RoleNameShapes
        /// </summary>
        [Description("Never draw the RoleNameShapes")]
        Off = 2
    }
}
