// -------------------------------------------------------------------------------------------------
// <copyright file="CalculatedPathValueInputFactory.cs" company="RHEA System S.A.">
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

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------

namespace Kalliope.Dal
{
    using System;

    using Kalliope.Core;
    using Kalliope.Diagrams;

    /// <summary>
    /// The purpose of the <see cref="CalculatedPathValueInputFactory"/> is to create a new instance of a
    /// <see cref="Kalliope.Core.CalculatedPathValueInput"/> based on a <see cref="Kalliope.DTO.CalculatedPathValueInput"/>
    /// </summary>
    public class CalculatedPathValueInputFactory
    {
        /// <summary>
        /// Creates an instance of the <see cref="CalculatedPathValueInput"/> and sets the value properties
        /// based on the DTO
        /// </summary>
        /// <param name="dto">
        /// The instance of the <see cref="Kalliope.DTO.CalculatedPathValueInput"/>
        /// </param>
        /// <returns>
        /// an instance of <see cref="Kalliope.Core.CalculatedPathValueInput"/>
        /// </returns>
        /// <exception cref="ArgumentNullException">
        /// thrown when <paramref name="dto"/> is null
        /// </exception>
        public Kalliope.Core.CalculatedPathValueInput Create(Kalliope.DTO.CalculatedPathValueInput dto)
        {
            if (dto == null)
            {
                throw new ArgumentNullException(nameof(dto), $"the {nameof(dto)} may not be null");
            }

            var calculatedPathValueInput = new Kalliope.Core.CalculatedPathValueInput()
            {
                DistinctValues = dto.DistinctValues,
                Id = dto.Id,
            };

            return calculatedPathValueInput;
        }
    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
