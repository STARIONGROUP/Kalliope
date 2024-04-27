// -------------------------------------------------------------------------------------------------
// <copyright file="FactTypeDerivationRuleFactory.cs" company="Starion Group S.A.">
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
    /// The purpose of the <see cref="FactTypeDerivationRuleFactory"/> is to create a new instance of a
    /// <see cref="Kalliope.Core.FactTypeDerivationRule"/> based on a <see cref="Kalliope.DTO.FactTypeDerivationRule"/>
    /// </summary>
    public class FactTypeDerivationRuleFactory
    {
        /// <summary>
        /// Creates an instance of the <see cref="FactTypeDerivationRule"/> and sets the value properties
        /// based on the DTO
        /// </summary>
        /// <param name="dto">
        /// The instance of the <see cref="Kalliope.DTO.FactTypeDerivationRule"/>
        /// </param>
        /// <returns>
        /// an instance of <see cref="Kalliope.Core.FactTypeDerivationRule"/>
        /// </returns>
        /// <exception cref="ArgumentNullException">
        /// thrown when <paramref name="dto"/> is null
        /// </exception>
        public Kalliope.Core.FactTypeDerivationRule Create(Kalliope.DTO.FactTypeDerivationRule dto)
        {
            if (dto == null)
            {
                throw new ArgumentNullException(nameof(dto), $"the {nameof(dto)} may not be null");
            }

            var factTypeDerivationRule = new Kalliope.Core.FactTypeDerivationRule()
            {
                Id = dto.Id,
            };

            return factTypeDerivationRule;
        }
    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
