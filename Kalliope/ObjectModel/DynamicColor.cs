﻿// -------------------------------------------------------------------------------------------------
// <copyright file="DynamicColor.cs" company="RHEA System S.A.">
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
    /// Dynamic color information used by extension models with shape representations
    /// </summary>
    public abstract class DynamicColor
    {
        /// <summary>
        /// The name of a role indicating use of the color. Correspond to an item in a color set enum
        /// </summary>
        public string ColorRole { get; set; }

        /// <summary>
        /// The name of the color played by this role
        /// </summary>
        public string ColorValue { get; set; }
    }
}
