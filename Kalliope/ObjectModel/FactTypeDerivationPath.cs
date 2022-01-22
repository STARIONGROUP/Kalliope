// -------------------------------------------------------------------------------------------------
// <copyright file="FactTypeDerivationPath.cs" company="RHEA System S.A.">
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
    /// A role path with projected nodes used to define the population of a derived fact type
    /// </summary>
    public class FactTypeDerivationPath : RolePathOwner
    {
        /// <summary>
        /// The derivation rule results in a set of distinct facts instead of a bag that might contain duplicates
        /// </summary>
        public bool SetProjection { get; set; }

        /// <summary>
        /// The name of a fully derived fact type
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// An empty derivation rule is externally defined
        /// </summary>
        public bool ExternalDerivation { get; set; }
    }
}
