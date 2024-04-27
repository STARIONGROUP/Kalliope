// -------------------------------------------------------------------------------------------------
// <copyright file="FrequencyConstraintViolatedByUniquenessConstraintErrorFactory.cs" company="Starion Group S.A.">
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

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------

namespace Kalliope.Dal
{
    using System;

    using Kalliope.Core;
    using Kalliope.Diagrams;

    /// <summary>
    /// The purpose of the <see cref="FrequencyConstraintViolatedByUniquenessConstraintErrorFactory"/> is to create a new instance of a
    /// <see cref="Kalliope.Core.FrequencyConstraintViolatedByUniquenessConstraintError"/> based on a <see cref="Kalliope.DTO.FrequencyConstraintViolatedByUniquenessConstraintError"/>
    /// </summary>
    public class FrequencyConstraintViolatedByUniquenessConstraintErrorFactory
    {
        /// <summary>
        /// Creates an instance of the <see cref="FrequencyConstraintViolatedByUniquenessConstraintError"/> and sets the value properties
        /// based on the DTO
        /// </summary>
        /// <param name="dto">
        /// The instance of the <see cref="Kalliope.DTO.FrequencyConstraintViolatedByUniquenessConstraintError"/>
        /// </param>
        /// <returns>
        /// an instance of <see cref="Kalliope.Core.FrequencyConstraintViolatedByUniquenessConstraintError"/>
        /// </returns>
        /// <exception cref="ArgumentNullException">
        /// thrown when <paramref name="dto"/> is null
        /// </exception>
        public Kalliope.Core.FrequencyConstraintViolatedByUniquenessConstraintError Create(Kalliope.DTO.FrequencyConstraintViolatedByUniquenessConstraintError dto)
        {
            if (dto == null)
            {
                throw new ArgumentNullException(nameof(dto), $"the {nameof(dto)} may not be null");
            }

            var frequencyConstraintViolatedByUniquenessConstraintError = new Kalliope.Core.FrequencyConstraintViolatedByUniquenessConstraintError()
            {
                ErrorState = dto.ErrorState,
                ErrorText = dto.ErrorText,
                Id = dto.Id,
            };

            return frequencyConstraintViolatedByUniquenessConstraintError;
        }
    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
