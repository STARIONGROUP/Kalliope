﻿// -------------------------------------------------------------------------------------------------
// <copyright file="EntityTypeFactory.cs" company="Starion Group S.A.">
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
    /// The purpose of the <see cref="EntityTypeFactory"/> is to create a new instance of a
    /// <see cref="Kalliope.Core.EntityType"/> based on a <see cref="Kalliope.DTO.EntityType"/>
    /// </summary>
    public class EntityTypeFactory
    {
        /// <summary>
        /// Creates an instance of the <see cref="EntityType"/> and sets the value properties
        /// based on the DTO
        /// </summary>
        /// <param name="dto">
        /// The instance of the <see cref="Kalliope.DTO.EntityType"/>
        /// </param>
        /// <returns>
        /// an instance of <see cref="Kalliope.Core.EntityType"/>
        /// </returns>
        /// <exception cref="ArgumentNullException">
        /// thrown when <paramref name="dto"/> is null
        /// </exception>
        public Kalliope.Core.EntityType Create(Kalliope.DTO.EntityType dto)
        {
            if (dto == null)
            {
                throw new ArgumentNullException(nameof(dto), $"the {nameof(dto)} may not be null");
            }

            var entityType = new Kalliope.Core.EntityType()
            {
                DataTypeAutoGenerated = dto.DataTypeAutoGenerated,
                DataTypeLength = dto.DataTypeLength,
                DataTypeScale = dto.DataTypeScale,
                DerivationNoteDisplay = dto.DerivationNoteDisplay,
                DerivationStorageDisplay = dto.DerivationStorageDisplay,
                Id = dto.Id,
                IsExternal = dto.IsExternal,
                IsImplicitBooleanValue = dto.IsImplicitBooleanValue,
                IsIndependent = dto.IsIndependent,
                IsPersonal = dto.IsPersonal,
                IsSupertypePersonal = dto.IsSupertypePersonal,
                Name = dto.Name,
                ReferenceMode = dto.ReferenceMode,
                ReferenceModeDecoratedString = dto.ReferenceModeDecoratedString,
                TreatAsPersonal = dto.TreatAsPersonal,
                ValueRangeText = dto.ValueRangeText,
                ValueTypeValueRangeText = dto.ValueTypeValueRangeText,
            };

            return entityType;
        }
    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
