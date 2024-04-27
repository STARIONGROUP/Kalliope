// -------------------------------------------------------------------------------------------------
// <copyright file="OleObjectRawDataDataTypeFactory.cs" company="Starion Group S.A.">
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
    /// The purpose of the <see cref="OleObjectRawDataDataTypeFactory"/> is to create a new instance of a
    /// <see cref="Kalliope.Core.OleObjectRawDataDataType"/> based on a <see cref="Kalliope.DTO.OleObjectRawDataDataType"/>
    /// </summary>
    public class OleObjectRawDataDataTypeFactory
    {
        /// <summary>
        /// Creates an instance of the <see cref="OleObjectRawDataDataType"/> and sets the value properties
        /// based on the DTO
        /// </summary>
        /// <param name="dto">
        /// The instance of the <see cref="Kalliope.DTO.OleObjectRawDataDataType"/>
        /// </param>
        /// <returns>
        /// an instance of <see cref="Kalliope.Core.OleObjectRawDataDataType"/>
        /// </returns>
        /// <exception cref="ArgumentNullException">
        /// thrown when <paramref name="dto"/> is null
        /// </exception>
        public Kalliope.Core.OleObjectRawDataDataType Create(Kalliope.DTO.OleObjectRawDataDataType dto)
        {
            if (dto == null)
            {
                throw new ArgumentNullException(nameof(dto), $"the {nameof(dto)} may not be null");
            }

            var oleObjectRawDataDataType = new Kalliope.Core.OleObjectRawDataDataType()
            {
                Id = dto.Id,
            };

            return oleObjectRawDataDataType;
        }
    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
