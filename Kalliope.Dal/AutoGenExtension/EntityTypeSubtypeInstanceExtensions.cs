// -------------------------------------------------------------------------------------------------
// <copyright file="EntityTypeSubtypeInstanceExtensions.cs" company="RHEA System S.A.">
//
//   Copyright 2022 RHEA System S.A.
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

    using Kalliope.Common;
    using Kalliope.Core;
    using Kalliope.Diagrams;

    /// <summary>
    /// A static class that provides extension methods for the <see cref="EntityTypeSubtypeInstance"/> class
    /// </summary>
    public static class EntityTypeSubtypeInstanceExtensions
    {
        /// <summary>
        /// Updates the value properties of the <see cref="EntityTypeSubtypeInstance"/> by setting the value equal to that of the dto
        /// Removes deleted objects from the reference properties and returns the unique identifiers
        /// of the objects that have been removed from <see cref="AggregationKind.Composite"/> properties
        /// </summary>
        /// <param name="poco">
        /// The <see cref="EntityTypeSubtypeInstance"/> that is to be updated
        /// </param>
        /// <param name="dto">
        /// The DTO that is used to update the <see cref="EntityTypeSubtypeInstance"/> with
        /// </param>
        /// <returns>
        /// The unique identifiers of the objects that have been removed from <see cref="AggregationKind.Composite"/> properties
        /// </returns>
        /// <exception cref="ArgumentNullException">
        /// Thrown when the <paramref name="poco"/> or <paramref name="dto"/> is null
        /// </exception>
        public static IEnumerable<string> UpdateValueAndRemoveDeletedReferenceProperties(this Kalliope.Core.EntityTypeSubtypeInstance poco, Kalliope.DTO.EntityTypeSubtypeInstance dto)
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

            var associatedModelErrorsToDelete = poco.AssociatedModelErrors.Select(x => x.Id).Except(dto.AssociatedModelErrors);
            foreach (var identifier in associatedModelErrorsToDelete)
            {
                var modelError = poco.AssociatedModelErrors.Single(x => x.Id == identifier);
                poco.AssociatedModelErrors.Remove(modelError);
            }

            var extensionModelErrorsToDelete = poco.ExtensionModelErrors.Select(x => x.Id).Except(dto.ExtensionModelErrors);
            foreach (var identifier in extensionModelErrorsToDelete)
            {
                var modelError = poco.ExtensionModelErrors.Single(x => x.Id == identifier);
                poco.ExtensionModelErrors.Remove(modelError);
            }

            poco.IdentifierName = dto.IdentifierName;

            if (poco.ObjectifiedInstanceRequiredError != null && poco.ObjectifiedInstanceRequiredError.Id != dto.ObjectifiedInstanceRequiredError)
            {
                identifiersOfObjectsToDelete.Add(poco.ObjectifiedInstanceRequiredError.Id);
                poco.ObjectifiedInstanceRequiredError = null;
            }

            var populationMandatoryErrorsToDelete = poco.PopulationMandatoryErrors.Select(x => x.Id).Except(dto.PopulationMandatoryErrors);
            identifiersOfObjectsToDelete.AddRange(populationMandatoryErrorsToDelete);
            foreach (var identifier in populationMandatoryErrorsToDelete)
            {
                var populationMandatoryError = poco.PopulationMandatoryErrors.Single(x => x.Id == identifier);
                poco.PopulationMandatoryErrors.Remove(populationMandatoryError);
            }

            if (poco.SupertypeInstance != null && poco.SupertypeInstance.Id != dto.SupertypeInstance)
            {
                poco.SupertypeInstance = null;
            }

            return identifiersOfObjectsToDelete;
        }

        /// <summary>
        /// Updates the Reference properties of the <see cref="EntityTypeSubtypeInstance"/> using the data (identifiers) encapsulated in the DTO
        /// and the provided cache to find the referenced object.
        /// </summary>
        /// <param name="poco">
        /// The <see cref="EntityTypeSubtypeInstance"/> that is to be updated
        /// </param>
        /// <param name="dto">
        /// The DTO that is used to update the <see cref="EntityTypeSubtypeInstance"/> with
        /// </param>
        /// <param name="cache">
        /// The <see cref="ConcurrentDictionary{String, Lazy{Kalliope.Core.ModelThing}}"/> that contains the
        /// <see cref="ModelThing"/>s that are know and cached.
        /// </param>
        /// <exception cref="ArgumentNullException"></exception>
        public static void UpdateReferenceProperties(this Kalliope.Core.EntityTypeSubtypeInstance poco, Kalliope.DTO.EntityTypeSubtypeInstance dto, ConcurrentDictionary<string, Lazy<Kalliope.Core.ModelThing>> cache)
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

            var associatedModelErrorsToAdd = dto.AssociatedModelErrors.Except(poco.AssociatedModelErrors.Select(x => x.Id));
            foreach (var identifier in associatedModelErrorsToAdd)
            {
                if (cache.TryGetValue(identifier, out lazyPoco))
                {
                    var modelError = (ModelError)lazyPoco.Value;
                    poco.AssociatedModelErrors.Add(modelError);
                }
            }

            var extensionModelErrorsToAdd = dto.ExtensionModelErrors.Except(poco.ExtensionModelErrors.Select(x => x.Id));
            foreach (var identifier in extensionModelErrorsToAdd)
            {
                if (cache.TryGetValue(identifier, out lazyPoco))
                {
                    var modelError = (ModelError)lazyPoco.Value;
                    poco.ExtensionModelErrors.Add(modelError);
                }
            }

            if (poco.ObjectifiedInstanceRequiredError == null && !string.IsNullOrEmpty(dto.ObjectifiedInstanceRequiredError))
            {
                if (cache.TryGetValue(dto.ObjectifiedInstanceRequiredError, out lazyPoco))
                {
                    poco.ObjectifiedInstanceRequiredError = (ObjectifiedInstanceRequiredError)lazyPoco.Value;
                }
            }

            var populationMandatoryErrorsToAdd = dto.PopulationMandatoryErrors.Except(poco.PopulationMandatoryErrors.Select(x => x.Id));
            foreach (var identifier in populationMandatoryErrorsToAdd)
            {
                if (cache.TryGetValue(identifier, out lazyPoco))
                {
                    var populationMandatoryError = (PopulationMandatoryError)lazyPoco.Value;
                    poco.PopulationMandatoryErrors.Add(populationMandatoryError);
                }
            }

            if (poco.SupertypeInstance == null && !string.IsNullOrEmpty(dto.SupertypeInstance))
            {
                if (cache.TryGetValue(dto.SupertypeInstance, out lazyPoco))
                {
                    poco.SupertypeInstance = (EntityTypeInstance)lazyPoco.Value;
                }
            }
        }
    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
