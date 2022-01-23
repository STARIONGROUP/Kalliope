// -------------------------------------------------------------------------------------------------
// <copyright file="NameGeneratorSpacingFormat.cs" company="RHEA System S.A.">
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
    /// <summary>
    /// Specify how name spaces are treated during name generation. 
    /// If not specified, the default SpacingFormat is the value from the nearest refining parent with this attribute. The root default is Retain
    /// </summary>
    public enum NameGeneratorSpacingFormat
    {
        Uninitialized = -1,

        /// <summary>
        /// Keep any spaces specified in names used in the ORM model
        /// </summary>
        Retain = 0,

        /// <summary>
        /// Generate names using all upper case letters
        /// </summary>
        /// <remarks>
        /// (DSL) Indicates that spaces are Removed
        /// </remarks>
        Remove = 1,

        /// <summary>
        /// Replace one or more spaces in model names with the character specified in the SpacingReplacement attribute
        /// </summary>
        /// <remarks>
        /// (DSL) Indicates that spaces are ReplacedWith a different string
        /// </remarks>
        ReplaceWith = 2
    }
}
