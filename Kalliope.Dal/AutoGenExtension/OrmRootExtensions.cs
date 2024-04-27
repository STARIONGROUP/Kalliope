// -------------------------------------------------------------------------------------------------
// <copyright file="OrmRootExtensions.cs" company="Starion Group S.A.">
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
    /// A static class that provides extension methods for the <see cref="OrmRoot"/> class
    /// </summary>
    public static class OrmRootExtensions
    {
        /// <summary>
        /// Updates the value properties of the <see cref="OrmRoot"/> by setting the value equal to that of the dto
        /// Removes deleted objects from the reference properties and returns the unique identifiers
        /// of the objects that have been removed from <see cref="AggregationKind.Composite"/> properties
        /// </summary>
        /// <param name="poco">
        /// The <see cref="OrmRoot"/> that is to be updated
        /// </param>
        /// <param name="dto">
        /// The DTO that is used to update the <see cref="OrmRoot"/> with
        /// </param>
        /// <returns>
        /// The unique identifiers of the objects that have been removed from <see cref="AggregationKind.Composite"/> properties
        /// </returns>
        /// <exception cref="ArgumentNullException">
        /// Thrown when the <paramref name="poco"/> or <paramref name="dto"/> is null
        /// </exception>
        public static IEnumerable<string> UpdateValueAndRemoveDeletedReferenceProperties(this Kalliope.OrmRoot poco, Kalliope.DTO.OrmRoot dto)
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

            var customPropertyGroupsToDelete = poco.CustomPropertyGroups.Select(x => x.Id).Except(dto.CustomPropertyGroups);
            identifiersOfObjectsToDelete.AddRange(customPropertyGroupsToDelete);
            foreach (var identifier in customPropertyGroupsToDelete)
            {
                var customPropertyGroup = poco.CustomPropertyGroups.Single(x => x.Id == identifier);
                poco.CustomPropertyGroups.Remove(customPropertyGroup);
            }

            var diagramsToDelete = poco.Diagrams.Select(x => x.Id).Except(dto.Diagrams);
            identifiersOfObjectsToDelete.AddRange(diagramsToDelete);
            foreach (var identifier in diagramsToDelete)
            {
                var ormDiagram = poco.Diagrams.Single(x => x.Id == identifier);
                poco.Diagrams.Remove(ormDiagram);
            }

            if (poco.DisplayState != null && poco.DisplayState.Id != dto.DisplayState)
            {
                identifiersOfObjectsToDelete.Add(poco.DisplayState.Id);
                poco.DisplayState = null;
            }

            if (poco.ElementOrganizations != null && poco.ElementOrganizations.Id != dto.ElementOrganizations)
            {
                identifiersOfObjectsToDelete.Add(poco.ElementOrganizations.Id);
                poco.ElementOrganizations = null;
            }

            if (poco.GenerationState != null && poco.GenerationState.Id != dto.GenerationState)
            {
                identifiersOfObjectsToDelete.Add(poco.GenerationState.Id);
                poco.GenerationState = null;
            }

            if (poco.Model != null && poco.Model.Id != dto.Model)
            {
                identifiersOfObjectsToDelete.Add(poco.Model.Id);
                poco.Model = null;
            }

            if (poco.NameGenerator != null && poco.NameGenerator.Id != dto.NameGenerator)
            {
                identifiersOfObjectsToDelete.Add(poco.NameGenerator.Id);
                poco.NameGenerator = null;
            }

            return identifiersOfObjectsToDelete;
        }

        /// <summary>
        /// Updates the Reference properties of the <see cref="OrmRoot"/> using the data (identifiers) encapsulated in the DTO
        /// and the provided cache to find the referenced object.
        /// </summary>
        /// <param name="poco">
        /// The <see cref="OrmRoot"/> that is to be updated
        /// </param>
        /// <param name="dto">
        /// The DTO that is used to update the <see cref="OrmRoot"/> with
        /// </param>
        /// <param name="cache">
        /// The <see cref="ConcurrentDictionary{String, Lazy{Kalliope.Core.ModelThing}}"/> that contains the
        /// <see cref="ModelThing"/>s that are know and cached.
        /// </param>
        /// <exception cref="ArgumentNullException"></exception>
        public static void UpdateReferenceProperties(this Kalliope.OrmRoot poco, Kalliope.DTO.OrmRoot dto, ConcurrentDictionary<string, Lazy<Kalliope.Core.ModelThing>> cache)
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

            var customPropertyGroupsToAdd = dto.CustomPropertyGroups.Except(poco.CustomPropertyGroups.Select(x => x.Id));
            foreach (var identifier in customPropertyGroupsToAdd)
            {
                if (cache.TryGetValue(identifier, out lazyPoco))
                {
                    var customPropertyGroup = (CustomPropertyGroup)lazyPoco.Value;
                    poco.CustomPropertyGroups.Add(customPropertyGroup);
                }
            }

            var diagramsToAdd = dto.Diagrams.Except(poco.Diagrams.Select(x => x.Id));
            foreach (var identifier in diagramsToAdd)
            {
                if (cache.TryGetValue(identifier, out lazyPoco))
                {
                    var ormDiagram = (OrmDiagram)lazyPoco.Value;
                    poco.Diagrams.Add(ormDiagram);
                }
            }

            if (poco.DisplayState == null && !string.IsNullOrEmpty(dto.DisplayState) && cache.TryGetValue(dto.DisplayState, out lazyPoco))
            {
                poco.DisplayState = (DisplayState)lazyPoco.Value;
            }

            if (poco.ElementOrganizations == null && !string.IsNullOrEmpty(dto.ElementOrganizations) && cache.TryGetValue(dto.ElementOrganizations, out lazyPoco))
            {
                poco.ElementOrganizations = (ElementOrganizations)lazyPoco.Value;
            }

            if (poco.GenerationState == null && !string.IsNullOrEmpty(dto.GenerationState) && cache.TryGetValue(dto.GenerationState, out lazyPoco))
            {
                poco.GenerationState = (GenerationState)lazyPoco.Value;
            }

            if (poco.Model == null && !string.IsNullOrEmpty(dto.Model) && cache.TryGetValue(dto.Model, out lazyPoco))
            {
                poco.Model = (OrmModel)lazyPoco.Value;
            }

            if (poco.NameGenerator == null && !string.IsNullOrEmpty(dto.NameGenerator) && cache.TryGetValue(dto.NameGenerator, out lazyPoco))
            {
                poco.NameGenerator = (NameGenerator)lazyPoco.Value;
            }
        }
    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
