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
    using System.Collections.Concurrent;
    using System.Collections.Generic;
    using System.Linq;

    using Kalliope.Common;
    using Kalliope.Core;
    using Kalliope.Diagrams;

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
                var ormModelElement = poco.ExcludedElements.Single(x => x.Id == identifier);
                poco.ExcludedElements.Remove(ormModelElement);
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
                var ormModelElement = poco.IncludedElements.Single(x => x.Id == identifier);
                poco.IncludedElements.Remove(ormModelElement);
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

        /// <summary>
        /// Updates the Reference properties of the <see cref="ElementGrouping"/> using the data (identifiers) encapsulated in the DTO
        /// and the provided cache to find the referenced object.
        /// </summary>
        /// <param name="poco">
        /// The <see cref="ElementGrouping"/> that is to be updated
        /// </param>
        /// <param name="dto">
        /// The DTO that is used to update the <see cref="ElementGrouping"/> with
        /// </param>
        /// <param name="cache">
        /// The <see cref="ConcurrentDictionary{String, Lazy{Kalliope.Core.ModelThing}}"/> that contains the
        /// <see cref="ModelThing"/>s that are know and cached.
        /// </param>
        /// <exception cref="ArgumentNullException"></exception>
        public static void UpdateReferenceProperties(this Kalliope.Core.ElementGrouping poco, Kalliope.DTO.ElementGrouping dto, ConcurrentDictionary<string, Lazy<Kalliope.Core.ModelThing>> cache)
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

            var childGroupingsToAdd = dto.ChildGroupings.Except(poco.ChildGroupings.Select(x => x.Id));
            foreach (var identifier in childGroupingsToAdd)
            {
                if (cache.TryGetValue(identifier, out lazyPoco))
                {
                    var elementGrouping = (ElementGrouping)lazyPoco.Value;
                    poco.ChildGroupings.Add(elementGrouping);
                }
            }

            if (poco.Definition == null && !string.IsNullOrEmpty(dto.Definition) && cache.TryGetValue(dto.Definition, out lazyPoco))
            {
                poco.Definition = (Definition)lazyPoco.Value;
            }

            if (poco.DuplicateNameError == null && !string.IsNullOrEmpty(dto.DuplicateNameError) && cache.TryGetValue(dto.DuplicateNameError, out lazyPoco))
            {
                poco.DuplicateNameError = (ElementGroupingDuplicateNameError)lazyPoco.Value;
            }

            var excludedChildGroupingsToAdd = dto.ExcludedChildGroupings.Except(poco.ExcludedChildGroupings.Select(x => x.Id));
            foreach (var identifier in excludedChildGroupingsToAdd)
            {
                if (cache.TryGetValue(identifier, out lazyPoco))
                {
                    var elementGrouping = (ElementGrouping)lazyPoco.Value;
                    poco.ExcludedChildGroupings.Add(elementGrouping);
                }
            }

            var excludedElementsToAdd = dto.ExcludedElements.Except(poco.ExcludedElements.Select(x => x.Id));
            foreach (var identifier in excludedElementsToAdd)
            {
                if (cache.TryGetValue(identifier, out lazyPoco))
                {
                    var ormModelElement = (OrmModelElement)lazyPoco.Value;
                    poco.ExcludedElements.Add(ormModelElement);
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

            var includedChildGroupingsToAdd = dto.IncludedChildGroupings.Except(poco.IncludedChildGroupings.Select(x => x.Id));
            foreach (var identifier in includedChildGroupingsToAdd)
            {
                if (cache.TryGetValue(identifier, out lazyPoco))
                {
                    var elementGrouping = (ElementGrouping)lazyPoco.Value;
                    poco.IncludedChildGroupings.Add(elementGrouping);
                }
            }

            var includedElementsToAdd = dto.IncludedElements.Except(poco.IncludedElements.Select(x => x.Id));
            foreach (var identifier in includedElementsToAdd)
            {
                if (cache.TryGetValue(identifier, out lazyPoco))
                {
                    var ormModelElement = (OrmModelElement)lazyPoco.Value;
                    poco.IncludedElements.Add(ormModelElement);
                }
            }

            var membershipContradictionErrorsToAdd = dto.MembershipContradictionErrors.Except(poco.MembershipContradictionErrors.Select(x => x.Id));
            foreach (var identifier in membershipContradictionErrorsToAdd)
            {
                if (cache.TryGetValue(identifier, out lazyPoco))
                {
                    var elementGroupingMembershipContradictionError = (ElementGroupingMembershipContradictionError)lazyPoco.Value;
                    poco.MembershipContradictionErrors.Add(elementGroupingMembershipContradictionError);
                }
            }

            if (poco.Note == null && !string.IsNullOrEmpty(dto.Note) && cache.TryGetValue(dto.Note, out lazyPoco))
            {
                poco.Note = (Note)lazyPoco.Value;
            }
        }
    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
