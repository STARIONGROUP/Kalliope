// -------------------------------------------------------------------------------------------------
// <copyright file="RoleMultiplicity.cs" company="RHEA System S.A.">
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

namespace Kalliope.Common
{
    /// <summary>
    /// Defines the multiplicity for the roles.
    /// The role multiplicity is currently displayed only on roles associated with binary fact types and is calculated
    /// based on the existing mandatory and internal uniqueness constraints associated with the fact
    /// </summary>
    [Description("Defines the multiplicity for the roles. The role multiplicity is currently displayed only on roles associated with binary fact types and is calculated based on the existing mandatory and internal uniqueness constraints associated with the fact")]
    public enum RoleMultiplicity
    {
        /// <summary>
        /// Insufficient constraints are present to determine the user intention
        /// </summary>
        [Description("Insufficient constraints are present to determine the user intention")]
        Unspecified = 0,

        /// <summary>
        /// Too many constraints are present to determine the user intention
        /// </summary>
        [Description("Too many constraints are present to determine the user intention")]
        Indeterminate = 1,

        /// <summary>
        /// 0..1
        /// </summary>
        [Description("0..1")]
        ZeroToOne = 2,

        /// <summary>
        /// 0..*
        /// </summary>
        [Description("1..*")]
        ZeroToMany = 3,

        /// <summary>
        /// 1
        /// </summary>
        [Description("1")]
        ExactlyOne = 4,

        /// <summary>
        /// 1..*
        /// </summary>
        [Description("1..*")]
        OneToMany = 5 
    }
}
