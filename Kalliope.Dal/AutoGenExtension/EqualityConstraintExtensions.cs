// -------------------------------------------------------------------------------------------------
// <copyright file="EqualityConstraintExtensions.cs" company="RHEA System S.A.">
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
    using System.Collections.Generic;
    using System.Linq;

    using Kalliope.Common;
    using Kalliope.Core;

    /// <summary>
    /// A static class that provides extension methods for the <see cref="EqualityConstraint"/> class
    /// </summary>
    public static class EqualityConstraintExtensions
    {
        /// <summary>
        /// Updates the value properties of the <see cref="EqualityConstraint"/> by setting the value equal to that of the dto
        /// Removes deleted objects from the reference properties and returns the unique identifiers
        /// of the objects that have been removed from <see cref="AggregationKind.Composite"/> properties
        /// </summary>
        /// <param name="poco">
        /// The <see cref="EqualityConstraint"/> that is to be updated
        /// </param>
        /// <param name="dto">
        /// The DTO that is used to update the <see cref="EqualityConstraint"/> with
        /// </param>
        /// <returns>
        /// The unique identifiers of the objects that have been removed from <see cref="AggregationKind.Composite"/> properties
        /// </returns>
        /// <exception cref="ArgumentNullException">
        /// Thrown when the <paramref name="poco"/> or <paramref name="dto"/> is null
        /// </exception>
        public static IEnumerable<string> UpdateValueAndRemoveDeletedReferenceProperties(this Kalliope.Core.EqualityConstraint poco, Kalliope.DTO.EqualityConstraint dto)
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
 
            var roleSequencesToDelete = poco.RoleSequences.Select(x => x.Id).Except(dto.RoleSequences);
            identifiersOfObjectsToDelete.AddRange(roleSequencesToDelete);
            foreach (var identifier in roleSequencesToDelete)
            {
                var setComparisonConstraintRoleSequence = poco.RoleSequences.Single(x => x.Id == identifier);
                poco.RoleSequences.Remove(setComparisonConstraintRoleSequence);
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
    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
