// -------------------------------------------------------------------------------------------------
// <copyright file="SubsetConstraintExtensions.cs" company="RHEA System S.A.">
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
    /// A static class that provides extension methods for the <see cref="SubsetConstraint"/> class
    /// </summary>
    public static class SubsetConstraintExtensions
    {
        /// <summary>
        /// Updates the value properties of the <see cref="SubsetConstraint"/> by setting the value equal to that of the dto
        /// Removes deleted objects from the reference properties and returns the unique identifiers
        /// of the objects that have been removed from <see cref="AggregationKind.Composite"/> properties
        /// </summary>
        /// <param name="poco">
        /// The <see cref="SubsetConstraint"/> that is to be updated
        /// </param>
        /// <param name="dto">
        /// The DTO that is used to update the <see cref="SubsetConstraint"/> with
        /// </param>
        /// <returns>
        /// The unique identifiers of the objects that have been removed from <see cref="AggregationKind.Composite"/> properties
        /// </returns>
        /// <exception cref="ArgumentNullException">
        /// Thrown when the <paramref name="poco"/> or <paramref name="dto"/> is null
        /// </exception>
        public static IEnumerable<string> UpdateValueAndRemoveDeletedReferenceProperties(this Kalliope.Core.SubsetConstraint poco, Kalliope.DTO.SubsetConstraint dto)
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

            if (poco.ArityMismatchError != null && poco.ArityMismatchError.Id != dto.ArityMismatchError)
            {
                identifiersOfObjectsToDelete.Add(poco.ArityMismatchError.Id);
                poco.ArityMismatchError = null;
            }

            var associatedModelErrorsToDelete = poco.AssociatedModelErrors.Select(x => x.Id).Except(dto.AssociatedModelErrors);
            foreach (var identifier in associatedModelErrorsToDelete)
            {
                var modelError = poco.AssociatedModelErrors.Single(x => x.Id == identifier);
                poco.AssociatedModelErrors.Remove(modelError);
            }

            var compatibleRolePlayerTypeErrorsToDelete = poco.CompatibleRolePlayerTypeErrors.Select(x => x.Id).Except(dto.CompatibleRolePlayerTypeErrors);
            identifiersOfObjectsToDelete.AddRange(compatibleRolePlayerTypeErrorsToDelete);
            foreach (var identifier in compatibleRolePlayerTypeErrorsToDelete)
            {
                var compatibleRolePlayerTypeError = poco.CompatibleRolePlayerTypeErrors.Single(x => x.Id == identifier);
                poco.CompatibleRolePlayerTypeErrors.Remove(compatibleRolePlayerTypeError);
            }

            var contradictionErrorToDelete = poco.ContradictionError.Select(x => x.Id).Except(dto.ContradictionError);
            foreach (var identifier in contradictionErrorToDelete)
            {
                var contradictionError = poco.ContradictionError.Single(x => x.Id == identifier);
                poco.ContradictionError.Remove(contradictionError);
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

            if (poco.EqualityOrSubsetImpliedByMandatoryError != null && poco.EqualityOrSubsetImpliedByMandatoryError.Id != dto.EqualityOrSubsetImpliedByMandatoryError)
            {
                identifiersOfObjectsToDelete.Add(poco.EqualityOrSubsetImpliedByMandatoryError.Id);
                poco.EqualityOrSubsetImpliedByMandatoryError = null;
            }

            if (poco.ExclusionContradictsEqualityError != null && poco.ExclusionContradictsEqualityError.Id != dto.ExclusionContradictsEqualityError)
            {
                poco.ExclusionContradictsEqualityError = null;
            }

            if (poco.ExclusionContradictsSubsetError != null && poco.ExclusionContradictsSubsetError.Id != dto.ExclusionContradictsSubsetError)
            {
                poco.ExclusionContradictsSubsetError = null;
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
                poco.ImplicationError = null;
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
                poco.NotWellModeledSubsetAndMandatoryError = null;
            }

            var roleSequencesToDelete = poco.RoleSequences.Select(x => x.Id).Except(dto.RoleSequences);
            identifiersOfObjectsToDelete.AddRange(roleSequencesToDelete);
            foreach (var identifier in roleSequencesToDelete)
            {
                var setComparisonConstraintRoleSequence = poco.RoleSequences.Single(x => x.Id == identifier);
                poco.RoleSequences.Remove(setComparisonConstraintRoleSequence);
            }

            if (poco.SupersetRoleOfSubtypeSubsetConstraintNotSubtypeError != null && poco.SupersetRoleOfSubtypeSubsetConstraintNotSubtypeError.Id != dto.SupersetRoleOfSubtypeSubsetConstraintNotSubtypeError)
            {
                poco.SupersetRoleOfSubtypeSubsetConstraintNotSubtypeError = null;
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
        /// Updates the Reference properties of the <see cref="SubsetConstraint"/> using the data (identifiers) encapsulated in the DTO
        /// and the provided cache to find the referenced object.
        /// </summary>
        /// <param name="poco">
        /// The <see cref="SubsetConstraint"/> that is to be updated
        /// </param>
        /// <param name="dto">
        /// The DTO that is used to update the <see cref="SubsetConstraint"/> with
        /// </param>
        /// <param name="cache">
        /// The <see cref="ConcurrentDictionary{String, Lazy{Kalliope.Core.ModelThing}}"/> that contains the
        /// <see cref="ModelThing"/>s that are know and cached.
        /// </param>
        /// <exception cref="ArgumentNullException"></exception>
        public static void UpdateReferenceProperties(this Kalliope.Core.SubsetConstraint poco, Kalliope.DTO.SubsetConstraint dto, ConcurrentDictionary<string, Lazy<Kalliope.Core.ModelThing>> cache)
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

            if (poco.ArityMismatchError == null && !string.IsNullOrEmpty(dto.ArityMismatchError) && cache.TryGetValue(dto.ArityMismatchError, out lazyPoco))
            {
                poco.ArityMismatchError = (ExternalConstraintRoleSequenceArityMismatchError)lazyPoco.Value;
            }

            var associatedModelErrorsToAdd = dto.AssociatedModelErrors.Except(poco.AssociatedModelErrors.Select(x => x.Id));
            foreach (var identifier in associatedModelErrorsToAdd)
            {
                if (cache.TryGetValue(identifier, out lazyPoco))
                {
                    var modelError = (ModelError)lazyPoco.Value;
                    poco.AssociatedModelErrors.Add(modelError);
                }
            }

            var compatibleRolePlayerTypeErrorsToAdd = dto.CompatibleRolePlayerTypeErrors.Except(poco.CompatibleRolePlayerTypeErrors.Select(x => x.Id));
            foreach (var identifier in compatibleRolePlayerTypeErrorsToAdd)
            {
                if (cache.TryGetValue(identifier, out lazyPoco))
                {
                    var compatibleRolePlayerTypeError = (CompatibleRolePlayerTypeError)lazyPoco.Value;
                    poco.CompatibleRolePlayerTypeErrors.Add(compatibleRolePlayerTypeError);
                }
            }

            var contradictionErrorToAdd = dto.ContradictionError.Except(poco.ContradictionError.Select(x => x.Id));
            foreach (var identifier in contradictionErrorToAdd)
            {
                if (cache.TryGetValue(identifier, out lazyPoco))
                {
                    var contradictionError = (ContradictionError)lazyPoco.Value;
                    poco.ContradictionError.Add(contradictionError);
                }
            }

            if (poco.Definition == null && !string.IsNullOrEmpty(dto.Definition) && cache.TryGetValue(dto.Definition, out lazyPoco))
            {
                poco.Definition = (Definition)lazyPoco.Value;
            }

            if (poco.DuplicateNameError == null && !string.IsNullOrEmpty(dto.DuplicateNameError) && cache.TryGetValue(dto.DuplicateNameError, out lazyPoco))
            {
                poco.DuplicateNameError = (ConstraintDuplicateNameError)lazyPoco.Value;
            }

            if (poco.EqualityOrSubsetImpliedByMandatoryError == null && !string.IsNullOrEmpty(dto.EqualityOrSubsetImpliedByMandatoryError) && cache.TryGetValue(dto.EqualityOrSubsetImpliedByMandatoryError, out lazyPoco))
            {
                poco.EqualityOrSubsetImpliedByMandatoryError = (EqualityOrSubsetImpliedByMandatoryError)lazyPoco.Value;
            }

            if (poco.ExclusionContradictsEqualityError == null && !string.IsNullOrEmpty(dto.ExclusionContradictsEqualityError) && cache.TryGetValue(dto.ExclusionContradictsEqualityError, out lazyPoco))
            {
                poco.ExclusionContradictsEqualityError = (ExclusionContradictsEqualityError)lazyPoco.Value;
            }

            if (poco.ExclusionContradictsSubsetError == null && !string.IsNullOrEmpty(dto.ExclusionContradictsSubsetError) && cache.TryGetValue(dto.ExclusionContradictsSubsetError, out lazyPoco))
            {
                poco.ExclusionContradictsSubsetError = (ExclusionContradictsSubsetError)lazyPoco.Value;
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

            if (poco.ImplicationError == null && !string.IsNullOrEmpty(dto.ImplicationError) && cache.TryGetValue(dto.ImplicationError, out lazyPoco))
            {
                poco.ImplicationError = (ImplicationError)lazyPoco.Value;
            }

            if (poco.Note == null && !string.IsNullOrEmpty(dto.Note) && cache.TryGetValue(dto.Note, out lazyPoco))
            {
                poco.Note = (Note)lazyPoco.Value;
            }

            if (poco.NotWellModeledSubsetAndMandatoryError == null && !string.IsNullOrEmpty(dto.NotWellModeledSubsetAndMandatoryError) && cache.TryGetValue(dto.NotWellModeledSubsetAndMandatoryError, out lazyPoco))
            {
                poco.NotWellModeledSubsetAndMandatoryError = (NotWellModeledSubsetAndMandatoryError)lazyPoco.Value;
            }

            var roleSequencesToAdd = dto.RoleSequences.Except(poco.RoleSequences.Select(x => x.Id));
            foreach (var identifier in roleSequencesToAdd)
            {
                if (cache.TryGetValue(identifier, out lazyPoco))
                {
                    var setComparisonConstraintRoleSequence = (SetComparisonConstraintRoleSequence)lazyPoco.Value;
                    poco.RoleSequences.Add(setComparisonConstraintRoleSequence);
                }
            }

            if (poco.SupersetRoleOfSubtypeSubsetConstraintNotSubtypeError == null && !string.IsNullOrEmpty(dto.SupersetRoleOfSubtypeSubsetConstraintNotSubtypeError) && cache.TryGetValue(dto.SupersetRoleOfSubtypeSubsetConstraintNotSubtypeError, out lazyPoco))
            {
                poco.SupersetRoleOfSubtypeSubsetConstraintNotSubtypeError = (SupersetRoleOfSubtypeSubsetConstraintNotSubtypeError)lazyPoco.Value;
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
