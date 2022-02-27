// -------------------------------------------------------------------------------------------------
// <copyright file="RelatedTypesDisplay.cs" company="RHEA System S.A.">
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
    /// Determines whether an <see cref="ObjectTypeShape"/> or objectified <see cref="FactTypeShape"/> is attached to its supertypes or subtypes
    /// </summary>
    [Description("Determines whether an ObjectTypeShape or objectified FactTypeShape is attached to its supertypes or subtypes")]
    public enum RelatedTypesDisplay
    {
        /// <summary>
        /// The shape attaches to both its supertypes and its subtypes
        /// </summary>
        [Description("The shape attaches to both its supertypes and its subtypes")]
        AttachAllTypes = 0,

        /// <summary>
        /// The shape attaches to its subtypes, but not its supertypes
        /// </summary>
        [Description("The shape attaches to its subtypes, but not its supertypes")]
        AttachSubtypes = 1,

        /// <summary>
        /// The shape attaches to its supertypes, but not its subtypes
        /// </summary>
        [Description("The shape attaches to its supertypes, but not its subtypes")]
        AttachSupertypes = 2,

        /// <summary>
        /// The shape attaches to neither its subtypes nor its supertypes
        /// </summary>
        [Description("The shape attaches to neither its subtypes nor its supertypes")]
        AttachNoTypes = 3,
    }
}
