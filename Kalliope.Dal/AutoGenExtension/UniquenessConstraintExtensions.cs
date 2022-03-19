// -------------------------------------------------------------------------------------------------
// <copyright file="UniquenessConstraintExtensions.cs" company="RHEA System S.A.">
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
    /// A static class that provides extension methods for the <see cref="UniquenessConstraint"/> class
    /// </summary>
    public static class UniquenessConstraintExtensions
    {
        /// <summary>
        /// Updates the value properties of the <see cref="UniquenessConstraint"/> by setting the value equal to that of the dto
        /// Removes deleted objects from the reference properties and returns the unique identifiers
        /// of the objects that have been removed from <see cref="AggregationKind.Composite"/> properties
        /// </summary>
        /// <param name="poco">
        /// The <see cref="UniquenessConstraint"/> that is to be updated
        /// </param>
        /// <param name="dto">
        /// The DTO that is used to update the <see cref="UniquenessConstraint"/> with
        /// </param>
        /// <returns>
        /// The unique identifiers of the objects that have been removed from <see cref="AggregationKind.Composite"/> properties
        /// </returns>
        /// <exception cref="ArgumentNullException">
        /// Thrown when the <paramref name="poco"/> or <paramref name="dto"/> is null
        /// </exception>
        public static IEnumerable<string> UpdateValueAndRemoveDeletedReferenceProperties(this Kalliope.Core.UniquenessConstraint poco, Kalliope.DTO.UniquenessConstraint dto)
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

            if (poco.CompatibleRolePlayerTypeError != null && poco.CompatibleRolePlayerTypeError.Id != dto.CompatibleRolePlayerTypeError)
            {
                identifiersOfObjectsToDelete.Add(poco.CompatibleRolePlayerTypeError.Id);
                poco.CompatibleRolePlayerTypeError = null;
            }

            if (poco.Definition != null && poco.Definition.Id != dto.Definition)
            {
                identifiersOfObjectsToDelete.Add(poco.Definition.Id);
                poco.Definition = null;
            }

            if (poco.DuplicateNameError != null && poco.DuplicateNameError.Id != dto.DuplicateNameError)
            {
                poco.DuplicateNameError = null;
            }

            var extensionModelErrorsToDelete = poco.ExtensionModelErrors.Select(x => x.Id).Except(dto.ExtensionModelErrors);
            foreach (var identifier in extensionModelErrorsToDelete)
            {
                var modelError = poco.ExtensionModelErrors.Single(x => x.Id == identifier);
                poco.ExtensionModelErrors.Remove(modelError);
            }

            var factTypesToDelete = poco.FactTypes.Select(x => x.Id).Except(dto.FactTypes);
            foreach (var identifier in factTypesToDelete)
            {
                var factType = poco.FactTypes.Single(x => x.Id == identifier);
                poco.FactTypes.Remove(factType);
            }

            if (poco.ImplicationError != null && poco.ImplicationError.Id != dto.ImplicationError)
            {
                identifiersOfObjectsToDelete.Add(poco.ImplicationError.Id);
                poco.ImplicationError = null;
            }

            poco.IsInternal = dto.IsInternal;

            poco.IsPreferred = dto.IsPreferred;

            if (poco.JoinPath != null && poco.JoinPath.Id != dto.JoinPath)
            {
                identifiersOfObjectsToDelete.Add(poco.JoinPath.Id);
                poco.JoinPath = null;
            }

            if (poco.JoinPathRequiredError != null && poco.JoinPathRequiredError.Id != dto.JoinPathRequiredError)
            {
                identifiersOfObjectsToDelete.Add(poco.JoinPathRequiredError.Id);
                poco.JoinPathRequiredError = null;
            }

            poco.Modality = dto.Modality;

            poco.Name = dto.Name;

            if (poco.NMinusOneError != null && poco.NMinusOneError.Id != dto.NMinusOneError)
            {
                identifiersOfObjectsToDelete.Add(poco.NMinusOneError.Id);
                poco.NMinusOneError = null;
            }

            if (poco.Note != null && poco.Note.Id != dto.Note)
            {
                identifiersOfObjectsToDelete.Add(poco.Note.Id);
                poco.Note = null;
            }

            var rolesToDelete = poco.Roles.Select(x => x.Id).Except(dto.Roles);
            foreach (var identifier in rolesToDelete)
            {
                var role = poco.Roles.Single(x => x.Id == identifier);
                poco.Roles.Remove(role);
            }

            if (poco.TooFewRoleSequencesError != null && poco.TooFewRoleSequencesError.Id != dto.TooFewRoleSequencesError)
            {
                identifiersOfObjectsToDelete.Add(poco.TooFewRoleSequencesError.Id);
                poco.TooFewRoleSequencesError = null;
            }

            if (poco.TooManyRoleSequencesError != null && poco.TooManyRoleSequencesError.Id != dto.TooManyRoleSequencesError)
            {
                identifiersOfObjectsToDelete.Add(poco.TooManyRoleSequencesError.Id);
                poco.TooManyRoleSequencesError = null;
            }

            return identifiersOfObjectsToDelete;
        }

        /// <summary>
        /// Updates the Reference properties of the <see cref="UniquenessConstraint"/> using the data (identifiers) encapsulated in the DTO
        /// and the provided cache to find the referenced object.
        /// </summary>
        /// <param name="poco">
        /// The <see cref="UniquenessConstraint"/> that is to be updated
        /// </param>
        /// <param name="dto">
        /// The DTO that is used to update the <see cref="UniquenessConstraint"/> with
        /// </param>
        /// <param name="cache">
        /// The <see cref="ConcurrentDictionary{String, Lazy{Kalliope.Core.ModelThing}}"/> that contains the
        /// <see cref="ModelThing"/>s that are know and cached.
        /// </param>
        /// <exception cref="ArgumentNullException"></exception>
        public static void UpdateReferenceProperties(this Kalliope.Core.UniquenessConstraint poco, Kalliope.DTO.UniquenessConstraint dto, ConcurrentDictionary<string, Lazy<Kalliope.Core.ModelThing>> cache)
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

            if (poco.CompatibleRolePlayerTypeError == null && !string.IsNullOrEmpty(dto.CompatibleRolePlayerTypeError))
            {
                if (cache.TryGetValue(dto.CompatibleRolePlayerTypeError, out lazyPoco))
                {
                    poco.CompatibleRolePlayerTypeError = (CompatibleRolePlayerTypeError)lazyPoco.Value;
                }
            }

            if (poco.Definition == null && !string.IsNullOrEmpty(dto.Definition))
            {
                if (cache.TryGetValue(dto.Definition, out lazyPoco))
                {
                    poco.Definition = (Definition)lazyPoco.Value;
                }
            }

            if (poco.DuplicateNameError == null && !string.IsNullOrEmpty(dto.DuplicateNameError))
            {
                if (cache.TryGetValue(dto.DuplicateNameError, out lazyPoco))
                {
                    poco.DuplicateNameError = (ConstraintDuplicateNameError)lazyPoco.Value;
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

            var factTypesToAdd = dto.FactTypes.Except(poco.FactTypes.Select(x => x.Id));
            foreach (var identifier in factTypesToAdd)
            {
                if (cache.TryGetValue(identifier, out lazyPoco))
                {
                    var factType = (FactType)lazyPoco.Value;
                    poco.FactTypes.Add(factType);
                }
            }

            if (poco.ImplicationError == null && !string.IsNullOrEmpty(dto.ImplicationError))
            {
                if (cache.TryGetValue(dto.ImplicationError, out lazyPoco))
                {
                    poco.ImplicationError = (ImplicationError)lazyPoco.Value;
                }
            }

            if (poco.JoinPath == null && !string.IsNullOrEmpty(dto.JoinPath))
            {
                if (cache.TryGetValue(dto.JoinPath, out lazyPoco))
                {
                    poco.JoinPath = (ConstraintRoleSequenceJoinPath)lazyPoco.Value;
                }
            }

            if (poco.JoinPathRequiredError == null && !string.IsNullOrEmpty(dto.JoinPathRequiredError))
            {
                if (cache.TryGetValue(dto.JoinPathRequiredError, out lazyPoco))
                {
                    poco.JoinPathRequiredError = (JoinPathRequiredError)lazyPoco.Value;
                }
            }

            if (poco.NMinusOneError == null && !string.IsNullOrEmpty(dto.NMinusOneError))
            {
                if (cache.TryGetValue(dto.NMinusOneError, out lazyPoco))
                {
                    poco.NMinusOneError = (NMinusOneError)lazyPoco.Value;
                }
            }

            if (poco.Note == null && !string.IsNullOrEmpty(dto.Note))
            {
                if (cache.TryGetValue(dto.Note, out lazyPoco))
                {
                    poco.Note = (Note)lazyPoco.Value;
                }
            }

            var rolesToAdd = dto.Roles.Except(poco.Roles.Select(x => x.Id));
            foreach (var identifier in rolesToAdd)
            {
                if (cache.TryGetValue(identifier, out lazyPoco))
                {
                    var role = (Role)lazyPoco.Value;
                    poco.Roles.Add(role);
                }
            }

            if (poco.TooFewRoleSequencesError == null && !string.IsNullOrEmpty(dto.TooFewRoleSequencesError))
            {
                if (cache.TryGetValue(dto.TooFewRoleSequencesError, out lazyPoco))
                {
                    poco.TooFewRoleSequencesError = (TooFewRoleSequencesError)lazyPoco.Value;
                }
            }

            if (poco.TooManyRoleSequencesError == null && !string.IsNullOrEmpty(dto.TooManyRoleSequencesError))
            {
                if (cache.TryGetValue(dto.TooManyRoleSequencesError, out lazyPoco))
                {
                    poco.TooManyRoleSequencesError = (TooManyRoleSequencesError)lazyPoco.Value;
                }
            }
        }
    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
