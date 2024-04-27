// -------------------------------------------------------------------------------------------------
// <copyright file="CustomPropertyGroupExtensions.cs" company="Starion Group S.A.">
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
    using System.Collections.Concurrent;
    using System.Collections.Generic;
    using System.Linq;

    using Kalliope.Absorption;
    using Kalliope.Common;
    using Kalliope.Core;
    using Kalliope.CustomProperties;
    using Kalliope.Diagrams;

    /// <summary>
    /// A static class that provides extension methods for the <see cref="CustomPropertyGroup"/> class
    /// </summary>
    public static class CustomPropertyGroupExtensions
    {
        /// <summary>
        /// Updates the value properties of the <see cref="CustomPropertyGroup"/> by setting the value equal to that of the dto
        /// Removes deleted objects from the reference properties and returns the unique identifiers
        /// of the objects that have been removed from <see cref="AggregationKind.Composite"/> properties
        /// </summary>
        /// <param name="poco">
        /// The <see cref="CustomPropertyGroup"/> that is to be updated
        /// </param>
        /// <param name="dto">
        /// The DTO that is used to update the <see cref="CustomPropertyGroup"/> with
        /// </param>
        /// <returns>
        /// The unique identifiers of the objects that have been removed from <see cref="AggregationKind.Composite"/> properties
        /// </returns>
        /// <exception cref="ArgumentNullException">
        /// Thrown when the <paramref name="poco"/> or <paramref name="dto"/> is null
        /// </exception>
        public static IEnumerable<string> UpdateValueAndRemoveDeletedReferenceProperties(this Kalliope.CustomProperties.CustomPropertyGroup poco, Kalliope.DTO.CustomPropertyGroup dto)
        {
            if (poco == null)
            {
                throw new ArgumentNullException(nameof(poco), $"the {nameof(poco)} may not be null");
            }

            if (dto == null)
            {
                throw new ArgumentNullException(nameof(dto), $"the {nameof(dto)} may not be null");
            }

            var identifiersOfObjectsToDelete = new List<string>();

            poco.Description = dto.Description;

            poco.IsDefault = dto.IsDefault;

            poco.Name = dto.Name;

            var propertyDefinitionsToDelete = poco.PropertyDefinitions.Select(x => x.Id).Except(dto.PropertyDefinitions);
            identifiersOfObjectsToDelete.AddRange(propertyDefinitionsToDelete);
            foreach (var identifier in propertyDefinitionsToDelete)
            {
                var customPropertyDefinition = poco.PropertyDefinitions.Single(x => x.Id == identifier);
                poco.PropertyDefinitions.Remove(customPropertyDefinition);
            }

            return identifiersOfObjectsToDelete;
        }

        /// <summary>
        /// Updates the Reference properties of the <see cref="CustomPropertyGroup"/> using the data (identifiers) encapsulated in the DTO
        /// and the provided cache to find the referenced object.
        /// </summary>
        /// <param name="poco">
        /// The <see cref="CustomPropertyGroup"/> that is to be updated
        /// </param>
        /// <param name="dto">
        /// The DTO that is used to update the <see cref="CustomPropertyGroup"/> with
        /// </param>
        /// <param name="cache">
        /// The <see cref="ConcurrentDictionary{String, Lazy{Kalliope.Core.ModelThing}}"/> that contains the
        /// <see cref="ModelThing"/>s that are know and cached.
        /// </param>
        /// <exception cref="ArgumentNullException"></exception>
        public static void UpdateReferenceProperties(this Kalliope.CustomProperties.CustomPropertyGroup poco, Kalliope.DTO.CustomPropertyGroup dto, ConcurrentDictionary<string, Lazy<Kalliope.Core.ModelThing>> cache)
        {
            if (poco == null)
            {
                throw new ArgumentNullException(nameof(poco), $"the {nameof(poco)} may not be null");
            }

            if (dto == null)
            {
                throw new ArgumentNullException(nameof(dto), $"the {nameof(dto)} may not be null");
            }

            if (cache == null)
            {
                throw new ArgumentNullException(nameof(cache), $"the {nameof(cache)} may not be null");
            }

            Lazy<Kalliope.Core.ModelThing> lazyPoco;

            var propertyDefinitionsToAdd = dto.PropertyDefinitions.Except(poco.PropertyDefinitions.Select(x => x.Id));
            foreach (var identifier in propertyDefinitionsToAdd)
            {
                if (cache.TryGetValue(identifier, out lazyPoco))
                {
                    var customPropertyDefinition = (CustomPropertyDefinition)lazyPoco.Value;
                    poco.PropertyDefinitions.Add(customPropertyDefinition);
                }
            }
        }
    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
