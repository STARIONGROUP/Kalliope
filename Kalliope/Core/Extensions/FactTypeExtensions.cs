// -------------------------------------------------------------------------------------------------
// <copyright file="RoleBaseExtensions.cs" company="Starion Group S.A.">
//
//   Copyright 2022-2024 Starion Group S.A.
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
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A static class that provides extension methods for the <see cref="FactType"/> class
    /// </summary>
    public static class RoleBaseExtensions
    {
        /// <summary>
        /// Checks if a specific role is present in a collection of Roles
        /// </summary>
        /// <param name="roles">
        /// The collection of <see cref="RoleBase"/>s that needs to be searched
        /// </param>
        /// <param name="role">
        /// The <see cref="RoleBase"/>s to search for 
        /// </param>
        /// <returns>
        /// true if the <paramref name="role"/> is found, otherwise false
        /// </returns>
        public static bool ContainsRole(this IEnumerable<RoleBase> roles, RoleBase role)
        {
            return roles.Contains(role) || roles.OfType<RoleProxy>().Any(x => x.TargetRole == role);
        }
    }
}
