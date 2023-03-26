// -------------------------------------------------------------------------------------------------
// <copyright file="AbsorbedFactTypeFactory.cs" company="RHEA System S.A.">
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
    /// The purpose of the <see cref="AbsorbedFactTypeFactory"/> is to create a new instance of a
    /// <see cref="Kalliope.Absorption.AbsorbedFactType"/> based on a <see cref="Kalliope.DTO.AbsorbedFactType"/>
    /// </summary>
    public class AbsorbedFactTypeFactory
    {
        /// <summary>
        /// Creates an instance of the <see cref="AbsorbedFactType"/> and sets the value properties
        /// based on the DTO
        /// </summary>
        /// <param name="dto">
        /// The instance of the <see cref="Kalliope.DTO.AbsorbedFactType"/>
        /// </param>
        /// <returns>
        /// an instance of <see cref="Kalliope.Absorption.AbsorbedFactType"/>
        /// </returns>
        /// <exception cref="ArgumentNullException">
        /// thrown when <paramref name="dto"/> is null
        /// </exception>
        public Kalliope.Absorption.AbsorbedFactType Create(Kalliope.DTO.AbsorbedFactType dto)
        {
            if (dto == null)
            {
                throw new ArgumentNullException(nameof(dto), $"the {nameof(dto)} may not be null");
            }

            var absorbedFactType = new Kalliope.Absorption.AbsorbedFactType()
            {
                Absorbed = dto.Absorbed,
                AbsorbedUnary = dto.AbsorbedUnary,
                Functional = dto.Functional,
                Id = dto.Id,
                Nested = dto.Nested,
                TopLevel = dto.TopLevel,
                XmlName = dto.XmlName,
            };

            return absorbedFactType;
        }
    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
