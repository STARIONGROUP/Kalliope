// -------------------------------------------------------------------------------------------------
// <copyright file="ElementGroupingExtensions.cs" company="RHEA System S.A.">
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
    /// A static class that provides extension methods for the <see cref="ElementGrouping"/> class
    /// </summary>
    public static class ElementGroupingExtensions
    {
        /// <summary>
        /// Updates the value properties of the <see cref="ElementGrouping"/> by setting the value equal to that of the dto
        /// Removes deleted objects from the reference properties and returns the unique identifiers
        /// of the objects that have been removed from <see cref="AggregationKind.Composite"/> properties
        /// </summary>
        /// <param name="poco">
        /// The <see cref="ElementGrouping"/> that is to be updated
        /// </param>
        /// <param name="dto">
        /// The DTO that is used to update the <see cref="ElementGrouping"/> with
        /// </param>
        /// <returns>
        /// The unique identifiers of the objects that have been removed from <see cref="AggregationKind.Composite"/> properties
        /// </returns>
        /// <exception cref="ArgumentNullException">
        /// Thrown when the <paramref name="poco"/> or <paramref name="dto"/> is null
        /// </exception>
        public static IEnumerable<string> UpdateValueAndRemoveDeletedReferenceProperties(this Kalliope.Core.ElementGrouping poco, Kalliope.DTO.ElementGrouping dto)
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
 
            var childGroupingsToDelete = poco.ChildGroupings.Select(x => x.Id).Except(dto.ChildGroupings);
            foreach (var identifier in childGroupingsToDelete)
            {
                var elementGrouping = poco.ChildGroupings.Single(x => x.Id == identifier);
                poco.ChildGroupings.Remove(elementGrouping);
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
 
            var excludedChildGroupingsToDelete = poco.ExcludedChildGroupings.Select(x => x.Id).Except(dto.ExcludedChildGroupings);
            foreach (var identifier in excludedChildGroupingsToDelete)
            {
                var elementGrouping = poco.ExcludedChildGroupings.Single(x => x.Id == identifier);
                poco.ExcludedChildGroupings.Remove(elementGrouping);
            }
 
            var excludedElementsToDelete = poco.ExcludedElements.Select(x => x.Id).Except(dto.ExcludedElements);
            foreach (var identifier in excludedElementsToDelete)
            {
                var oRMModelElement = poco.ExcludedElements.Single(x => x.Id == identifier);
                poco.ExcludedElements.Remove(oRMModelElement);
            }
 
            var extensionModelErrorsToDelete = poco.ExtensionModelErrors.Select(x => x.Id).Except(dto.ExtensionModelErrors);
            foreach (var identifier in extensionModelErrorsToDelete)
            {
                var modelError = poco.ExtensionModelErrors.Single(x => x.Id == identifier);
                poco.ExtensionModelErrors.Remove(modelError);
            }
 
            var includedChildGroupingsToDelete = poco.IncludedChildGroupings.Select(x => x.Id).Except(dto.IncludedChildGroupings);
            foreach (var identifier in includedChildGroupingsToDelete)
            {
                var elementGrouping = poco.IncludedChildGroupings.Single(x => x.Id == identifier);
                poco.IncludedChildGroupings.Remove(elementGrouping);
            }
 
            var includedElementsToDelete = poco.IncludedElements.Select(x => x.Id).Except(dto.IncludedElements);
            foreach (var identifier in includedElementsToDelete)
            {
                var oRMModelElement = poco.IncludedElements.Single(x => x.Id == identifier);
                poco.IncludedElements.Remove(oRMModelElement);
            }
 
            var membershipContradictionErrorsToDelete = poco.MembershipContradictionErrors.Select(x => x.Id).Except(dto.MembershipContradictionErrors);
            identifiersOfObjectsToDelete.AddRange(membershipContradictionErrorsToDelete);
            foreach (var identifier in membershipContradictionErrorsToDelete)
            {
                var elementGroupingMembershipContradictionError = poco.MembershipContradictionErrors.Single(x => x.Id == identifier);
                poco.MembershipContradictionErrors.Remove(elementGroupingMembershipContradictionError);
            }
 
            poco.Name = dto.Name;
 
            if (poco.Note != null && poco.Note.Id != dto.Note)
            {
                identifiersOfObjectsToDelete.Add(poco.Note.Id);
                poco.Note = null;
            }
 
            poco.Priority = dto.Priority;
 
            poco.TypeCompliance = dto.TypeCompliance;
 

            return identifiersOfObjectsToDelete;
        }
    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
