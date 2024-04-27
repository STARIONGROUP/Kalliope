// -------------------------------------------------------------------------------------------------
// <copyright file="ReadingShapeFactory.cs" company="Starion Group S.A.">
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
    /// The purpose of the <see cref="ReadingShapeFactory"/> is to create a new instance of a
    /// <see cref="Kalliope.Diagrams.ReadingShape"/> based on a <see cref="Kalliope.DTO.ReadingShape"/>
    /// </summary>
    public class ReadingShapeFactory
    {
        /// <summary>
        /// Creates an instance of the <see cref="ReadingShape"/> and sets the value properties
        /// based on the DTO
        /// </summary>
        /// <param name="dto">
        /// The instance of the <see cref="Kalliope.DTO.ReadingShape"/>
        /// </param>
        /// <returns>
        /// an instance of <see cref="Kalliope.Diagrams.ReadingShape"/>
        /// </returns>
        /// <exception cref="ArgumentNullException">
        /// thrown when <paramref name="dto"/> is null
        /// </exception>
        public Kalliope.Diagrams.ReadingShape Create(Kalliope.DTO.ReadingShape dto)
        {
            if (dto == null)
            {
                throw new ArgumentNullException(nameof(dto), $"the {nameof(dto)} may not be null");
            }

            var readingShape = new Kalliope.Diagrams.ReadingShape()
            {
                AbsoluteBounds = dto.AbsoluteBounds,
                Id = dto.Id,
                IsExpanded = dto.IsExpanded,
            };

            return readingShape;
        }
    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
