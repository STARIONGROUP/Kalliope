// -------------------------------------------------------------------------------------------------
// <copyright file="FrequencyConstraintFactory.cs" company="RHEA System S.A.">
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

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------

namespace Kalliope.Dal
{
    using System;

    using Kalliope.Core;
    using Kalliope.Diagrams;

    /// <summary>
    /// The purpose of the <see cref="FrequencyConstraintFactory"/> is to create a new instance of a
    /// <see cref="Kalliope.Core.FrequencyConstraint"/> based on a <see cref="Kalliope.DTO.FrequencyConstraint"/>
    /// </summary>
    public class FrequencyConstraintFactory
    {
        /// <summary>
        /// Creates an instance of the <see cref="FrequencyConstraint"/> and sets the value properties
        /// based on the DTO
        /// </summary>
        /// <param name="dto">
        /// The instance of the <see cref="Kalliope.DTO.FrequencyConstraint"/>
        /// </param>
        /// <returns>
        /// an instance of <see cref="Kalliope.Core.FrequencyConstraint"/>
        /// </returns>
        /// <exception cref="ArgumentNullException">
        /// thrown when <paramref name="dto"/> is null
        /// </exception>
        public Kalliope.Core.FrequencyConstraint Create(Kalliope.DTO.FrequencyConstraint dto)
        {
            if (dto == null)
            {
                throw new ArgumentNullException(nameof(dto), $"the {nameof(dto)} may not be null");
            }

            var frequencyConstraint = new Kalliope.Core.FrequencyConstraint()
            {
                Id = dto.Id,
                MaxFrequency = dto.MaxFrequency,
                MinFrequency = dto.MinFrequency,
                Modality = dto.Modality,
                Name = dto.Name,
            };

            return frequencyConstraint;
        }
    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
