// -------------------------------------------------------------------------------------------------
// <copyright file="MandatoryConstraintExtensions.cs" company="Starion Group S.A.">
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
    /// A static class that provides extension methods for the <see cref="MandatoryConstraint"/> class
    /// </summary>
    public static class MandatoryConstraintExtensions
    {
        /// <summary>
        /// Updates the value properties of the <see cref="MandatoryConstraint"/> by setting the value equal to that of the dto
        /// Removes deleted objects from the reference properties and returns the unique identifiers
        /// of the objects that have been removed from <see cref="AggregationKind.Composite"/> properties
        /// </summary>
        /// <param name="poco">
        /// The <see cref="MandatoryConstraint"/> that is to be updated
        /// </param>
        /// <param name="dto">
        /// The DTO that is used to update the <see cref="MandatoryConstraint"/> with
        /// </param>
        /// <returns>
        /// The unique identifiers of the objects that have been removed from <see cref="AggregationKind.Composite"/> properties
        /// </returns>
        /// <exception cref="ArgumentNullException">
        /// Thrown when the <paramref name="poco"/> or <paramref name="dto"/> is null
        /// </exception>
        public static IEnumerable<string> UpdateValueAndRemoveDeletedReferenceProperties(this Kalliope.Core.MandatoryConstraint poco, Kalliope.DTO.MandatoryConstraint dto)
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

            if (poco.ExclusionContradictsMandatoryError != null && poco.ExclusionContradictsMandatoryError.Id != dto.ExclusionContradictsMandatoryError)
            {
                poco.ExclusionContradictsMandatoryError = null;
            }

            if (poco.ExclusiveOrExclusionConstraint != null && poco.ExclusiveOrExclusionConstraint.Id != dto.ExclusiveOrExclusionConstraint)
            {
                poco.ExclusiveOrExclusionConstraint = null;
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

            if (poco.ImplicationError != null && poco.ImplicationError.Id != dto.ImplicationError)
            {
                identifiersOfObjectsToDelete.Add(poco.ImplicationError.Id);
                poco.ImplicationError = null;
            }

            if (poco.ImpliedByObjectType != null && poco.ImpliedByObjectType.Id != dto.ImpliedByObjectType)
            {
                poco.ImpliedByObjectType = null;
            }

            if (poco.InherentForObjectType != null && poco.InherentForObjectType.Id != dto.InherentForObjectType)
            {
                poco.InherentForObjectType = null;
            }

            poco.IsImplied = dto.IsImplied;

            poco.IsSimple = dto.IsSimple;

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

            if (poco.Note != null && poco.Note.Id != dto.Note)
            {
                identifiersOfObjectsToDelete.Add(poco.Note.Id);
                poco.Note = null;
            }

            if (poco.NotWellModeledSubsetAndMandatoryError != null && poco.NotWellModeledSubsetAndMandatoryError.Id != dto.NotWellModeledSubsetAndMandatoryError)
            {
                identifiersOfObjectsToDelete.Add(poco.NotWellModeledSubsetAndMandatoryError.Id);
                poco.NotWellModeledSubsetAndMandatoryError = null;
            }

            var populationMandatoryErrorsToDelete = poco.PopulationMandatoryErrors.Select(x => x.Id).Except(dto.PopulationMandatoryErrors);
            identifiersOfObjectsToDelete.AddRange(populationMandatoryErrorsToDelete);
            foreach (var identifier in populationMandatoryErrorsToDelete)
            {
                var populationMandatoryError = poco.PopulationMandatoryErrors.Single(x => x.Id == identifier);
                poco.PopulationMandatoryErrors.Remove(populationMandatoryError);
            }

            var rolesToDelete = poco.Roles.Select(x => x.Id).Except(dto.Roles);
            identifiersOfObjectsToDelete.AddRange(rolesToDelete);
            foreach (var identifier in rolesToDelete)
            {
                var roleBase = poco.Roles.Single(x => x.Id == identifier);
                poco.Roles.Remove(roleBase);
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
        /// Updates the Reference properties of the <see cref="MandatoryConstraint"/> using the data (identifiers) encapsulated in the DTO
        /// and the provided cache to find the referenced object.
        /// </summary>
        /// <param name="poco">
        /// The <see cref="MandatoryConstraint"/> that is to be updated
        /// </param>
        /// <param name="dto">
        /// The DTO that is used to update the <see cref="MandatoryConstraint"/> with
        /// </param>
        /// <param name="cache">
        /// The <see cref="ConcurrentDictionary{String, Lazy{Kalliope.Core.ModelThing}}"/> that contains the
        /// <see cref="ModelThing"/>s that are know and cached.
        /// </param>
        /// <exception cref="ArgumentNullException"></exception>
        public static void UpdateReferenceProperties(this Kalliope.Core.MandatoryConstraint poco, Kalliope.DTO.MandatoryConstraint dto, ConcurrentDictionary<string, Lazy<Kalliope.Core.ModelThing>> cache)
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

            if (poco.CompatibleRolePlayerTypeError == null && !string.IsNullOrEmpty(dto.CompatibleRolePlayerTypeError) && cache.TryGetValue(dto.CompatibleRolePlayerTypeError, out lazyPoco))
            {
                poco.CompatibleRolePlayerTypeError = (CompatibleRolePlayerTypeError)lazyPoco.Value;
            }

            if (poco.Definition == null && !string.IsNullOrEmpty(dto.Definition) && cache.TryGetValue(dto.Definition, out lazyPoco))
            {
                poco.Definition = (Definition)lazyPoco.Value;
            }

            if (poco.DuplicateNameError == null && !string.IsNullOrEmpty(dto.DuplicateNameError) && cache.TryGetValue(dto.DuplicateNameError, out lazyPoco))
            {
                poco.DuplicateNameError = (ConstraintDuplicateNameError)lazyPoco.Value;
            }

            if (poco.ExclusionContradictsMandatoryError == null && !string.IsNullOrEmpty(dto.ExclusionContradictsMandatoryError) && cache.TryGetValue(dto.ExclusionContradictsMandatoryError, out lazyPoco))
            {
                poco.ExclusionContradictsMandatoryError = (ExclusionContradictsMandatoryError)lazyPoco.Value;
            }

            if (poco.ExclusiveOrExclusionConstraint == null && !string.IsNullOrEmpty(dto.ExclusiveOrExclusionConstraint) && cache.TryGetValue(dto.ExclusiveOrExclusionConstraint, out lazyPoco))
            {
                poco.ExclusiveOrExclusionConstraint = (ExclusionConstraint)lazyPoco.Value;
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

            if (poco.ImplicationError == null && !string.IsNullOrEmpty(dto.ImplicationError) && cache.TryGetValue(dto.ImplicationError, out lazyPoco))
            {
                poco.ImplicationError = (ImplicationError)lazyPoco.Value;
            }

            if (poco.ImpliedByObjectType == null && !string.IsNullOrEmpty(dto.ImpliedByObjectType) && cache.TryGetValue(dto.ImpliedByObjectType, out lazyPoco))
            {
                poco.ImpliedByObjectType = (ObjectType)lazyPoco.Value;
            }

            if (poco.InherentForObjectType == null && !string.IsNullOrEmpty(dto.InherentForObjectType) && cache.TryGetValue(dto.InherentForObjectType, out lazyPoco))
            {
                poco.InherentForObjectType = (ObjectType)lazyPoco.Value;
            }

            if (poco.JoinPath == null && !string.IsNullOrEmpty(dto.JoinPath) && cache.TryGetValue(dto.JoinPath, out lazyPoco))
            {
                poco.JoinPath = (ConstraintRoleSequenceJoinPath)lazyPoco.Value;
            }

            if (poco.JoinPathRequiredError == null && !string.IsNullOrEmpty(dto.JoinPathRequiredError) && cache.TryGetValue(dto.JoinPathRequiredError, out lazyPoco))
            {
                poco.JoinPathRequiredError = (JoinPathRequiredError)lazyPoco.Value;
            }

            if (poco.Note == null && !string.IsNullOrEmpty(dto.Note) && cache.TryGetValue(dto.Note, out lazyPoco))
            {
                poco.Note = (Note)lazyPoco.Value;
            }

            if (poco.NotWellModeledSubsetAndMandatoryError == null && !string.IsNullOrEmpty(dto.NotWellModeledSubsetAndMandatoryError) && cache.TryGetValue(dto.NotWellModeledSubsetAndMandatoryError, out lazyPoco))
            {
                poco.NotWellModeledSubsetAndMandatoryError = (NotWellModeledSubsetAndMandatoryError)lazyPoco.Value;
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

            var rolesToAdd = dto.Roles.Except(poco.Roles.Select(x => x.Id));
            foreach (var identifier in rolesToAdd)
            {
                if (cache.TryGetValue(identifier, out lazyPoco))
                {
                    var roleBase = (RoleBase)lazyPoco.Value;
                    poco.Roles.Add(roleBase);
                }
            }

            if (poco.TooFewRoleSequencesError == null && !string.IsNullOrEmpty(dto.TooFewRoleSequencesError) && cache.TryGetValue(dto.TooFewRoleSequencesError, out lazyPoco))
            {
                poco.TooFewRoleSequencesError = (TooFewRoleSequencesError)lazyPoco.Value;
            }

            if (poco.TooManyRoleSequencesError == null && !string.IsNullOrEmpty(dto.TooManyRoleSequencesError) && cache.TryGetValue(dto.TooManyRoleSequencesError, out lazyPoco))
            {
                poco.TooManyRoleSequencesError = (TooManyRoleSequencesError)lazyPoco.Value;
            }
        }
    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
