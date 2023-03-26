// -------------------------------------------------------------------------------------------------
// <copyright file="ModelNoteExtensions.cs" company="RHEA System S.A.">
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
    /// A static class that provides extension methods for the <see cref="ModelNote"/> class
    /// </summary>
    public static class ModelNoteExtensions
    {
        /// <summary>
        /// Updates the value properties of the <see cref="ModelNote"/> by setting the value equal to that of the dto
        /// Removes deleted objects from the reference properties and returns the unique identifiers
        /// of the objects that have been removed from <see cref="AggregationKind.Composite"/> properties
        /// </summary>
        /// <param name="poco">
        /// The <see cref="ModelNote"/> that is to be updated
        /// </param>
        /// <param name="dto">
        /// The DTO that is used to update the <see cref="ModelNote"/> with
        /// </param>
        /// <returns>
        /// The unique identifiers of the objects that have been removed from <see cref="AggregationKind.Composite"/> properties
        /// </returns>
        /// <exception cref="ArgumentNullException">
        /// Thrown when the <paramref name="poco"/> or <paramref name="dto"/> is null
        /// </exception>
        public static IEnumerable<string> UpdateValueAndRemoveDeletedReferenceProperties(this Kalliope.Core.ModelNote poco, Kalliope.DTO.ModelNote dto)
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

            var elementsToDelete = poco.Elements.Select(x => x.Id).Except(dto.Elements);
            foreach (var identifier in elementsToDelete)
            {
                var ormModelElement = poco.Elements.Single(x => x.Id == identifier);
                poco.Elements.Remove(ormModelElement);
            }

            var extensionModelErrorsToDelete = poco.ExtensionModelErrors.Select(x => x.Id).Except(dto.ExtensionModelErrors);
            foreach (var identifier in extensionModelErrorsToDelete)
            {
                var modelError = poco.ExtensionModelErrors.Single(x => x.Id == identifier);
                poco.ExtensionModelErrors.Remove(modelError);
            }

            var extensionsToDelete = poco.Extensions.Select(x => x.Id).Except(dto.Extensions);
            identifiersOfObjectsToDelete.AddRange(extensionsToDelete);
            foreach (var identifier in extensionsToDelete)
            {
                var extension = poco.Extensions.Single(x => x.Id == identifier);
                poco.Extensions.Remove(extension);
            }

            var factTypesToDelete = poco.FactTypes.Select(x => x.Id).Except(dto.FactTypes);
            foreach (var identifier in factTypesToDelete)
            {
                var factType = poco.FactTypes.Single(x => x.Id == identifier);
                poco.FactTypes.Remove(factType);
            }

            var objectTypesToDelete = poco.ObjectTypes.Select(x => x.Id).Except(dto.ObjectTypes);
            foreach (var identifier in objectTypesToDelete)
            {
                var objectType = poco.ObjectTypes.Single(x => x.Id == identifier);
                poco.ObjectTypes.Remove(objectType);
            }

            var setComparisonConstraintsToDelete = poco.SetComparisonConstraints.Select(x => x.Id).Except(dto.SetComparisonConstraints);
            foreach (var identifier in setComparisonConstraintsToDelete)
            {
                var setComparisonConstraint = poco.SetComparisonConstraints.Single(x => x.Id == identifier);
                poco.SetComparisonConstraints.Remove(setComparisonConstraint);
            }

            var setConstraintsToDelete = poco.SetConstraints.Select(x => x.Id).Except(dto.SetConstraints);
            foreach (var identifier in setConstraintsToDelete)
            {
                var setConstraint = poco.SetConstraints.Single(x => x.Id == identifier);
                poco.SetConstraints.Remove(setConstraint);
            }

            poco.Text = dto.Text;

            return identifiersOfObjectsToDelete;
        }

        /// <summary>
        /// Updates the Reference properties of the <see cref="ModelNote"/> using the data (identifiers) encapsulated in the DTO
        /// and the provided cache to find the referenced object.
        /// </summary>
        /// <param name="poco">
        /// The <see cref="ModelNote"/> that is to be updated
        /// </param>
        /// <param name="dto">
        /// The DTO that is used to update the <see cref="ModelNote"/> with
        /// </param>
        /// <param name="cache">
        /// The <see cref="ConcurrentDictionary{String, Lazy{Kalliope.Core.ModelThing}}"/> that contains the
        /// <see cref="ModelThing"/>s that are know and cached.
        /// </param>
        /// <exception cref="ArgumentNullException"></exception>
        public static void UpdateReferenceProperties(this Kalliope.Core.ModelNote poco, Kalliope.DTO.ModelNote dto, ConcurrentDictionary<string, Lazy<Kalliope.Core.ModelThing>> cache)
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

            var elementsToAdd = dto.Elements.Except(poco.Elements.Select(x => x.Id));
            foreach (var identifier in elementsToAdd)
            {
                if (cache.TryGetValue(identifier, out lazyPoco))
                {
                    var ormModelElement = (OrmModelElement)lazyPoco.Value;
                    poco.Elements.Add(ormModelElement);
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

            var extensionsToAdd = dto.Extensions.Except(poco.Extensions.Select(x => x.Id));
            foreach (var identifier in extensionsToAdd)
            {
                if (cache.TryGetValue(identifier, out lazyPoco))
                {
                    var extension = (Extension)lazyPoco.Value;
                    poco.Extensions.Add(extension);
                }
            }

            var factTypesToAdd = dto.FactTypes.Except(poco.FactTypes.Select(x => x.Id));
            foreach (var identifier in factTypesToAdd)
            {
                if (cache.TryGetValue(identifier, out lazyPoco))
                {
                    var factType = (FactType)lazyPoco.Value;
                    poco.FactTypes.Add(factType);
                }
            }

            var objectTypesToAdd = dto.ObjectTypes.Except(poco.ObjectTypes.Select(x => x.Id));
            foreach (var identifier in objectTypesToAdd)
            {
                if (cache.TryGetValue(identifier, out lazyPoco))
                {
                    var objectType = (ObjectType)lazyPoco.Value;
                    poco.ObjectTypes.Add(objectType);
                }
            }

            var setComparisonConstraintsToAdd = dto.SetComparisonConstraints.Except(poco.SetComparisonConstraints.Select(x => x.Id));
            foreach (var identifier in setComparisonConstraintsToAdd)
            {
                if (cache.TryGetValue(identifier, out lazyPoco))
                {
                    var setComparisonConstraint = (SetComparisonConstraint)lazyPoco.Value;
                    poco.SetComparisonConstraints.Add(setComparisonConstraint);
                }
            }

            var setConstraintsToAdd = dto.SetConstraints.Except(poco.SetConstraints.Select(x => x.Id));
            foreach (var identifier in setConstraintsToAdd)
            {
                if (cache.TryGetValue(identifier, out lazyPoco))
                {
                    var setConstraint = (SetConstraint)lazyPoco.Value;
                    poco.SetConstraints.Add(setConstraint);
                }
            }
        }
    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
