// -------------------------------------------------------------------------------------------------
// <copyright file="HierarchyColorSchemeExtensions.cs" company="Starion Group S.A.">
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
    /// A static class that provides extension methods for the <see cref="HierarchyColorScheme"/> class
    /// </summary>
    public static class HierarchyColorSchemeExtensions
    {
        /// <summary>
        /// Updates the value properties of the <see cref="HierarchyColorScheme"/> by setting the value equal to that of the dto
        /// Removes deleted objects from the reference properties and returns the unique identifiers
        /// of the objects that have been removed from <see cref="AggregationKind.Composite"/> properties
        /// </summary>
        /// <param name="poco">
        /// The <see cref="HierarchyColorScheme"/> that is to be updated
        /// </param>
        /// <param name="dto">
        /// The DTO that is used to update the <see cref="HierarchyColorScheme"/> with
        /// </param>
        /// <returns>
        /// The unique identifiers of the objects that have been removed from <see cref="AggregationKind.Composite"/> properties
        /// </returns>
        /// <exception cref="ArgumentNullException">
        /// Thrown when the <paramref name="poco"/> or <paramref name="dto"/> is null
        /// </exception>
        public static IEnumerable<string> UpdateValueAndRemoveDeletedReferenceProperties(this Kalliope.Absorption.HierarchyColorScheme poco, Kalliope.DTO.HierarchyColorScheme dto)
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

            var absorbedToDelete = poco.Absorbed.Select(x => x.Id).Except(dto.Absorbed);
            identifiersOfObjectsToDelete.AddRange(absorbedToDelete);
            foreach (var identifier in absorbedToDelete)
            {
                var diagramDynamicColor = poco.Absorbed.Single(x => x.Id == identifier);
                poco.Absorbed.Remove(diagramDynamicColor);
            }

            var absorptionAttachPointToDelete = poco.AbsorptionAttachPoint.Select(x => x.Id).Except(dto.AbsorptionAttachPoint);
            identifiersOfObjectsToDelete.AddRange(absorptionAttachPointToDelete);
            foreach (var identifier in absorptionAttachPointToDelete)
            {
                var diagramDynamicColor = poco.AbsorptionAttachPoint.Single(x => x.Id == identifier);
                poco.AbsorptionAttachPoint.Remove(diagramDynamicColor);
            }

            var displayedHierarchiesToDelete = poco.DisplayedHierarchies.Select(x => x.Id).Except(dto.DisplayedHierarchies);
            identifiersOfObjectsToDelete.AddRange(displayedHierarchiesToDelete);
            foreach (var identifier in displayedHierarchiesToDelete)
            {
                var hierarchy = poco.DisplayedHierarchies.Single(x => x.Id == identifier);
                poco.DisplayedHierarchies.Remove(hierarchy);
            }

            var notIncludedToDelete = poco.NotIncluded.Select(x => x.Id).Except(dto.NotIncluded);
            identifiersOfObjectsToDelete.AddRange(notIncludedToDelete);
            foreach (var identifier in notIncludedToDelete)
            {
                var diagramDynamicColor = poco.NotIncluded.Single(x => x.Id == identifier);
                poco.NotIncluded.Remove(diagramDynamicColor);
            }

            var primaryLocationToDelete = poco.PrimaryLocation.Select(x => x.Id).Except(dto.PrimaryLocation);
            identifiersOfObjectsToDelete.AddRange(primaryLocationToDelete);
            foreach (var identifier in primaryLocationToDelete)
            {
                var diagramDynamicColor = poco.PrimaryLocation.Single(x => x.Id == identifier);
                poco.PrimaryLocation.Remove(diagramDynamicColor);
            }

            var referenceLocationToDelete = poco.ReferenceLocation.Select(x => x.Id).Except(dto.ReferenceLocation);
            identifiersOfObjectsToDelete.AddRange(referenceLocationToDelete);
            foreach (var identifier in referenceLocationToDelete)
            {
                var diagramDynamicColor = poco.ReferenceLocation.Single(x => x.Id == identifier);
                poco.ReferenceLocation.Remove(diagramDynamicColor);
            }

            var topLevelToDelete = poco.TopLevel.Select(x => x.Id).Except(dto.TopLevel);
            identifiersOfObjectsToDelete.AddRange(topLevelToDelete);
            foreach (var identifier in topLevelToDelete)
            {
                var diagramDynamicColor = poco.TopLevel.Single(x => x.Id == identifier);
                poco.TopLevel.Remove(diagramDynamicColor);
            }

            return identifiersOfObjectsToDelete;
        }

        /// <summary>
        /// Updates the Reference properties of the <see cref="HierarchyColorScheme"/> using the data (identifiers) encapsulated in the DTO
        /// and the provided cache to find the referenced object.
        /// </summary>
        /// <param name="poco">
        /// The <see cref="HierarchyColorScheme"/> that is to be updated
        /// </param>
        /// <param name="dto">
        /// The DTO that is used to update the <see cref="HierarchyColorScheme"/> with
        /// </param>
        /// <param name="cache">
        /// The <see cref="ConcurrentDictionary{String, Lazy{Kalliope.Core.ModelThing}}"/> that contains the
        /// <see cref="ModelThing"/>s that are know and cached.
        /// </param>
        /// <exception cref="ArgumentNullException"></exception>
        public static void UpdateReferenceProperties(this Kalliope.Absorption.HierarchyColorScheme poco, Kalliope.DTO.HierarchyColorScheme dto, ConcurrentDictionary<string, Lazy<Kalliope.Core.ModelThing>> cache)
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

            var absorbedToAdd = dto.Absorbed.Except(poco.Absorbed.Select(x => x.Id));
            foreach (var identifier in absorbedToAdd)
            {
                if (cache.TryGetValue(identifier, out lazyPoco))
                {
                    var diagramDynamicColor = (DiagramDynamicColor)lazyPoco.Value;
                    poco.Absorbed.Add(diagramDynamicColor);
                }
            }

            var absorptionAttachPointToAdd = dto.AbsorptionAttachPoint.Except(poco.AbsorptionAttachPoint.Select(x => x.Id));
            foreach (var identifier in absorptionAttachPointToAdd)
            {
                if (cache.TryGetValue(identifier, out lazyPoco))
                {
                    var diagramDynamicColor = (DiagramDynamicColor)lazyPoco.Value;
                    poco.AbsorptionAttachPoint.Add(diagramDynamicColor);
                }
            }

            var displayedHierarchiesToAdd = dto.DisplayedHierarchies.Except(poco.DisplayedHierarchies.Select(x => x.Id));
            foreach (var identifier in displayedHierarchiesToAdd)
            {
                if (cache.TryGetValue(identifier, out lazyPoco))
                {
                    var hierarchy = (Hierarchy)lazyPoco.Value;
                    poco.DisplayedHierarchies.Add(hierarchy);
                }
            }

            var notIncludedToAdd = dto.NotIncluded.Except(poco.NotIncluded.Select(x => x.Id));
            foreach (var identifier in notIncludedToAdd)
            {
                if (cache.TryGetValue(identifier, out lazyPoco))
                {
                    var diagramDynamicColor = (DiagramDynamicColor)lazyPoco.Value;
                    poco.NotIncluded.Add(diagramDynamicColor);
                }
            }

            var primaryLocationToAdd = dto.PrimaryLocation.Except(poco.PrimaryLocation.Select(x => x.Id));
            foreach (var identifier in primaryLocationToAdd)
            {
                if (cache.TryGetValue(identifier, out lazyPoco))
                {
                    var diagramDynamicColor = (DiagramDynamicColor)lazyPoco.Value;
                    poco.PrimaryLocation.Add(diagramDynamicColor);
                }
            }

            var referenceLocationToAdd = dto.ReferenceLocation.Except(poco.ReferenceLocation.Select(x => x.Id));
            foreach (var identifier in referenceLocationToAdd)
            {
                if (cache.TryGetValue(identifier, out lazyPoco))
                {
                    var diagramDynamicColor = (DiagramDynamicColor)lazyPoco.Value;
                    poco.ReferenceLocation.Add(diagramDynamicColor);
                }
            }

            var topLevelToAdd = dto.TopLevel.Except(poco.TopLevel.Select(x => x.Id));
            foreach (var identifier in topLevelToAdd)
            {
                if (cache.TryGetValue(identifier, out lazyPoco))
                {
                    var diagramDynamicColor = (DiagramDynamicColor)lazyPoco.Value;
                    poco.TopLevel.Add(diagramDynamicColor);
                }
            }
        }
    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
