// -------------------------------------------------------------------------------------------------
// <copyright file="AbsorbedRoleFactory.cs" company="Starion Group S.A.">
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
    /// The purpose of the <see cref="AbsorbedRoleFactory"/> is to create a new instance of a
    /// <see cref="Kalliope.Absorption.AbsorbedRole"/> based on a <see cref="Kalliope.DTO.AbsorbedRole"/>
    /// </summary>
    public class AbsorbedRoleFactory
    {
        /// <summary>
        /// Creates an instance of the <see cref="AbsorbedRole"/> and sets the value properties
        /// based on the DTO
        /// </summary>
        /// <param name="dto">
        /// The instance of the <see cref="Kalliope.DTO.AbsorbedRole"/>
        /// </param>
        /// <returns>
        /// an instance of <see cref="Kalliope.Absorption.AbsorbedRole"/>
        /// </returns>
        /// <exception cref="ArgumentNullException">
        /// thrown when <paramref name="dto"/> is null
        /// </exception>
        public Kalliope.Absorption.AbsorbedRole Create(Kalliope.DTO.AbsorbedRole dto)
        {
            if (dto == null)
            {
                throw new ArgumentNullException(nameof(dto), $"the {nameof(dto)} may not be null");
            }

            var absorbedRole = new Kalliope.Absorption.AbsorbedRole()
            {
                Id = dto.Id,
                Identifier = dto.Identifier,
                ObjectifiedRole = dto.ObjectifiedRole,
                XmlName = dto.XmlName,
                XmlReferenceName = dto.XmlReferenceName,
                XmlReferenceSimpleValueForm = dto.XmlReferenceSimpleValueForm,
                XmlSimpleValueForm = dto.XmlSimpleValueForm,
            };

            return absorbedRole;
        }
    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
