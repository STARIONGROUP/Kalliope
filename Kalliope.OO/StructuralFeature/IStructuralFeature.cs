﻿// -------------------------------------------------------------------------------------------------
// <copyright file="IStructuralFeature.cs" company="Starion Group S.A.">
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
// -------------------------------------------------------------------------------------------------

namespace Kalliope.OO.StructuralFeature
{
    /// <summary>
    /// Defines the properties and methods of an <see cref="IStructuralFeature"/>
    /// </summary>
    public interface IStructuralFeature
    {
        /// <summary>
        /// Gets or sets the <see cref="Name"/>
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="Definition"/>
        /// </summary>
        string Definition { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="Note"/>
        /// </summary>
        string Note { get; set; }
    }
}
