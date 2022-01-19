﻿// -------------------------------------------------------------------------------------------------
// <copyright file="SubtypeFactType.cs" company="RHEA System S.A.">
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
    using System;

    /// <summary>
    /// A fact type representing the subtype meta relationship between a subtype and a supertype
    /// </summary>
    public class SubtypeFactType
    {
        /// <summary>
        /// A unique identifier for this element
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// This fact type is externally defined (not used)
        /// </summary>
        public bool IsExternal { get; set; }

        /// <summary>
        /// Deprecated property, use PreferredIdentificationPath instead
        /// </summary>
        [Obsolete("use PreferredIdentificationPath instead")]
        public bool IsPrimary { get; set; }

        /// <summary>
        /// The subtype fact is a possible path through the subtype graph for retrieving the identifying supertype for the subtype.
        /// The identifying supertype can be a direct or indirect supertype
        /// </summary>
        public bool PreferredIdentificationPath { get; set; }
    }
}
