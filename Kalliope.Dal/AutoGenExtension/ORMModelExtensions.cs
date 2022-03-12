// -------------------------------------------------------------------------------------------------
// <copyright file="ORMModelExtensions.cs" company="RHEA System S.A.">
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
    /// A static class that provides extension methods for the <see cref="ORMModel"/> class
    /// </summary>
    public static class ORMModelExtensions
    {
        /// <summary>
        /// Updates the value properties of the <see cref="ORMModel"/> by setting the value equal to that of the dto
        /// Removes deleted objects from the reference properties and returns the unique identifiers
        /// of the objects that have been removed from <see cref="AggregationKind.Composite"/> properties
        /// </summary>
        /// <param name="poco">
        /// The <see cref="ORMModel"/> that is to be updated
        /// </param>
        /// <param name="dto">
        /// The DTO that is used to update the <see cref="ORMModel"/> with
        /// </param>
        /// <returns>
        /// The unique identifiers of the objects that have been removed from <see cref="AggregationKind.Composite"/> properties
        /// </returns>
        /// <exception cref="ArgumentNullException">
        /// Thrown when the <paramref name="poco"/> or <paramref name="dto"/> is null
        /// </exception>
        public static IEnumerable<string> UpdateValueAndRemoveDeletedReferenceProperties(this Kalliope.Core.ORMModel poco, Kalliope.DTO.ORMModel dto)
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
 
            var dataTypesToDelete = poco.DataTypes.Select(x => x.Id).Except(dto.DataTypes);
            identifiersOfObjectsToDelete.AddRange(dataTypesToDelete);
            foreach (var identifier in dataTypesToDelete)
            {
                var dataType = poco.DataTypes.Single(x => x.Id == identifier);
                poco.DataTypes.Remove(dataType);
            }
 
            if (poco.Definition != null && poco.Definition.Id != dto.Definition)
            {
                identifiersOfObjectsToDelete.Add(poco.Definition.Id);
                poco.Definition = null;
            }
 
            var errorsToDelete = poco.Errors.Select(x => x.Id).Except(dto.Errors);
            identifiersOfObjectsToDelete.AddRange(errorsToDelete);
            foreach (var identifier in errorsToDelete)
            {
                var modelError = poco.Errors.Single(x => x.Id == identifier);
                poco.Errors.Remove(modelError);
            }
 
            var extensionModelErrorsToDelete = poco.ExtensionModelErrors.Select(x => x.Id).Except(dto.ExtensionModelErrors);
            foreach (var identifier in extensionModelErrorsToDelete)
            {
                var modelError = poco.ExtensionModelErrors.Single(x => x.Id == identifier);
                poco.ExtensionModelErrors.Remove(modelError);
            }
 
            var factTypesToDelete = poco.FactTypes.Select(x => x.Id).Except(dto.FactTypes);
            identifiersOfObjectsToDelete.AddRange(factTypesToDelete);
            foreach (var identifier in factTypesToDelete)
            {
                var factType = poco.FactTypes.Single(x => x.Id == identifier);
                poco.FactTypes.Remove(factType);
            }
 
            var functionsToDelete = poco.Functions.Select(x => x.Id).Except(dto.Functions);
            identifiersOfObjectsToDelete.AddRange(functionsToDelete);
            foreach (var identifier in functionsToDelete)
            {
                var function = poco.Functions.Single(x => x.Id == identifier);
                poco.Functions.Remove(function);
            }
 
            poco.Name = dto.Name;
 
            if (poco.Note != null && poco.Note.Id != dto.Note)
            {
                identifiersOfObjectsToDelete.Add(poco.Note.Id);
                poco.Note = null;
            }
 
            var notesToDelete = poco.Notes.Select(x => x.Id).Except(dto.Notes);
            identifiersOfObjectsToDelete.AddRange(notesToDelete);
            foreach (var identifier in notesToDelete)
            {
                var modelNote = poco.Notes.Single(x => x.Id == identifier);
                poco.Notes.Remove(modelNote);
            }
 
            var objectTypesToDelete = poco.ObjectTypes.Select(x => x.Id).Except(dto.ObjectTypes);
            identifiersOfObjectsToDelete.AddRange(objectTypesToDelete);
            foreach (var identifier in objectTypesToDelete)
            {
                var objectType = poco.ObjectTypes.Single(x => x.Id == identifier);
                poco.ObjectTypes.Remove(objectType);
            }
 
            var recognizedPhrasesToDelete = poco.RecognizedPhrases.Select(x => x.Id).Except(dto.RecognizedPhrases);
            identifiersOfObjectsToDelete.AddRange(recognizedPhrasesToDelete);
            foreach (var identifier in recognizedPhrasesToDelete)
            {
                var recognizedPhrase = poco.RecognizedPhrases.Single(x => x.Id == identifier);
                poco.RecognizedPhrases.Remove(recognizedPhrase);
            }
 
            var referenceModeKindsToDelete = poco.ReferenceModeKinds.Select(x => x.Id).Except(dto.ReferenceModeKinds);
            identifiersOfObjectsToDelete.AddRange(referenceModeKindsToDelete);
            foreach (var identifier in referenceModeKindsToDelete)
            {
                var referenceModeKind = poco.ReferenceModeKinds.Single(x => x.Id == identifier);
                poco.ReferenceModeKinds.Remove(referenceModeKind);
            }
 
            var referenceModesToDelete = poco.ReferenceModes.Select(x => x.Id).Except(dto.ReferenceModes);
            identifiersOfObjectsToDelete.AddRange(referenceModesToDelete);
            foreach (var identifier in referenceModesToDelete)
            {
                var referenceMode = poco.ReferenceModes.Single(x => x.Id == identifier);
                poco.ReferenceModes.Remove(referenceMode);
            }
 
            var setComparisonConstraintsToDelete = poco.SetComparisonConstraints.Select(x => x.Id).Except(dto.SetComparisonConstraints);
            identifiersOfObjectsToDelete.AddRange(setComparisonConstraintsToDelete);
            foreach (var identifier in setComparisonConstraintsToDelete)
            {
                var setComparisonConstraint = poco.SetComparisonConstraints.Single(x => x.Id == identifier);
                poco.SetComparisonConstraints.Remove(setComparisonConstraint);
            }
 
            var setConstraintsToDelete = poco.SetConstraints.Select(x => x.Id).Except(dto.SetConstraints);
            identifiersOfObjectsToDelete.AddRange(setConstraintsToDelete);
            foreach (var identifier in setConstraintsToDelete)
            {
                var setConstraint = poco.SetConstraints.Single(x => x.Id == identifier);
                poco.SetConstraints.Remove(setConstraint);
            }
 

            return identifiersOfObjectsToDelete;
        }
    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
