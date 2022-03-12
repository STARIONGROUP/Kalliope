// -------------------------------------------------------------------------------------------------
// <copyright file="ModelNoteExtensions.cs" company="RHEA System S.A.">
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
                var oRMModelElement = poco.Elements.Single(x => x.Id == identifier);
                poco.Elements.Remove(oRMModelElement);
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
    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
