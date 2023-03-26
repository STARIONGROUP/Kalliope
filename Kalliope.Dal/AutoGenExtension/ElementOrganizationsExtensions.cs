// -------------------------------------------------------------------------------------------------
// <copyright file="ElementOrganizationsExtensions.cs" company="RHEA System S.A.">
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
    using System.Collections.Concurrent;
    using System.Collections.Generic;
    using System.Linq;

    using Kalliope.Absorption;
    using Kalliope.Common;
    using Kalliope.Core;
    using Kalliope.CustomProperties;
    using Kalliope.Diagrams;

    /// <summary>
    /// A static class that provides extension methods for the <see cref="ElementOrganizations"/> class
    /// </summary>
    public static class ElementOrganizationsExtensions
    {
        /// <summary>
        /// Updates the value properties of the <see cref="ElementOrganizations"/> by setting the value equal to that of the dto
        /// Removes deleted objects from the reference properties and returns the unique identifiers
        /// of the objects that have been removed from <see cref="AggregationKind.Composite"/> properties
        /// </summary>
        /// <param name="poco">
        /// The <see cref="ElementOrganizations"/> that is to be updated
        /// </param>
        /// <param name="dto">
        /// The DTO that is used to update the <see cref="ElementOrganizations"/> with
        /// </param>
        /// <returns>
        /// The unique identifiers of the objects that have been removed from <see cref="AggregationKind.Composite"/> properties
        /// </returns>
        /// <exception cref="ArgumentNullException">
        /// Thrown when the <paramref name="poco"/> or <paramref name="dto"/> is null
        /// </exception>
        public static IEnumerable<string> UpdateValueAndRemoveDeletedReferenceProperties(this Kalliope.Absorption.ElementOrganizations poco, Kalliope.DTO.ElementOrganizations dto)
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

            if (poco.ActiveOrganization != null && poco.ActiveOrganization.Id != dto.ActiveOrganization)
            {
                poco.ActiveOrganization = null;
            }

            var hierarchiesToDelete = poco.Hierarchies.Select(x => x.Id).Except(dto.Hierarchies);
            identifiersOfObjectsToDelete.AddRange(hierarchiesToDelete);
            foreach (var identifier in hierarchiesToDelete)
            {
                var hierarchy = poco.Hierarchies.Single(x => x.Id == identifier);
                poco.Hierarchies.Remove(hierarchy);
            }

            var hierarchyColorSchemesToDelete = poco.HierarchyColorSchemes.Select(x => x.Id).Except(dto.HierarchyColorSchemes);
            identifiersOfObjectsToDelete.AddRange(hierarchyColorSchemesToDelete);
            foreach (var identifier in hierarchyColorSchemesToDelete)
            {
                var hierarchyColorScheme = poco.HierarchyColorSchemes.Single(x => x.Id == identifier);
                poco.HierarchyColorSchemes.Remove(hierarchyColorScheme);
            }

            if (poco.Model != null && poco.Model.Id != dto.Model)
            {
                identifiersOfObjectsToDelete.Add(poco.Model.Id);
                poco.Model = null;
            }

            return identifiersOfObjectsToDelete;
        }

        /// <summary>
        /// Updates the Reference properties of the <see cref="ElementOrganizations"/> using the data (identifiers) encapsulated in the DTO
        /// and the provided cache to find the referenced object.
        /// </summary>
        /// <param name="poco">
        /// The <see cref="ElementOrganizations"/> that is to be updated
        /// </param>
        /// <param name="dto">
        /// The DTO that is used to update the <see cref="ElementOrganizations"/> with
        /// </param>
        /// <param name="cache">
        /// The <see cref="ConcurrentDictionary{String, Lazy{Kalliope.Core.ModelThing}}"/> that contains the
        /// <see cref="ModelThing"/>s that are know and cached.
        /// </param>
        /// <exception cref="ArgumentNullException"></exception>
        public static void UpdateReferenceProperties(this Kalliope.Absorption.ElementOrganizations poco, Kalliope.DTO.ElementOrganizations dto, ConcurrentDictionary<string, Lazy<Kalliope.Core.ModelThing>> cache)
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

            if (poco.ActiveOrganization == null && !string.IsNullOrEmpty(dto.ActiveOrganization) && cache.TryGetValue(dto.ActiveOrganization, out lazyPoco))
            {
                poco.ActiveOrganization = (Hierarchy)lazyPoco.Value;
            }

            var hierarchiesToAdd = dto.Hierarchies.Except(poco.Hierarchies.Select(x => x.Id));
            foreach (var identifier in hierarchiesToAdd)
            {
                if (cache.TryGetValue(identifier, out lazyPoco))
                {
                    var hierarchy = (Hierarchy)lazyPoco.Value;
                    poco.Hierarchies.Add(hierarchy);
                }
            }

            var hierarchyColorSchemesToAdd = dto.HierarchyColorSchemes.Except(poco.HierarchyColorSchemes.Select(x => x.Id));
            foreach (var identifier in hierarchyColorSchemesToAdd)
            {
                if (cache.TryGetValue(identifier, out lazyPoco))
                {
                    var hierarchyColorScheme = (HierarchyColorScheme)lazyPoco.Value;
                    poco.HierarchyColorSchemes.Add(hierarchyColorScheme);
                }
            }

            if (poco.Model == null && !string.IsNullOrEmpty(dto.Model) && cache.TryGetValue(dto.Model, out lazyPoco))
            {
                poco.Model = (OrmModel)lazyPoco.Value;
            }
        }
    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
