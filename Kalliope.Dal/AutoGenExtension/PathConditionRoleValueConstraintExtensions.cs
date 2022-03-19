// -------------------------------------------------------------------------------------------------
// <copyright file="PathConditionRoleValueConstraintExtensions.cs" company="RHEA System S.A.">
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
    /// A static class that provides extension methods for the <see cref="PathConditionRoleValueConstraint"/> class
    /// </summary>
    public static class PathConditionRoleValueConstraintExtensions
    {
        /// <summary>
        /// Updates the value properties of the <see cref="PathConditionRoleValueConstraint"/> by setting the value equal to that of the dto
        /// Removes deleted objects from the reference properties and returns the unique identifiers
        /// of the objects that have been removed from <see cref="AggregationKind.Composite"/> properties
        /// </summary>
        /// <param name="poco">
        /// The <see cref="PathConditionRoleValueConstraint"/> that is to be updated
        /// </param>
        /// <param name="dto">
        /// The DTO that is used to update the <see cref="PathConditionRoleValueConstraint"/> with
        /// </param>
        /// <returns>
        /// The unique identifiers of the objects that have been removed from <see cref="AggregationKind.Composite"/> properties
        /// </returns>
        /// <exception cref="ArgumentNullException">
        /// Thrown when the <paramref name="poco"/> or <paramref name="dto"/> is null
        /// </exception>
        public static IEnumerable<string> UpdateValueAndRemoveDeletedReferenceProperties(this Kalliope.Core.PathConditionRoleValueConstraint poco, Kalliope.DTO.PathConditionRoleValueConstraint dto)
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

            poco.Name = dto.Name;

            if (poco.Note != null && poco.Note.Id != dto.Note)
            {
                identifiersOfObjectsToDelete.Add(poco.Note.Id);
                poco.Note = null;
            }

            poco.Text = dto.Text;

            if (poco.ValueRangeOverlapError != null && poco.ValueRangeOverlapError.Id != dto.ValueRangeOverlapError)
            {
                identifiersOfObjectsToDelete.Add(poco.ValueRangeOverlapError.Id);
                poco.ValueRangeOverlapError = null;
            }

            var valueRangesToDelete = poco.ValueRanges.Select(x => x.Id).Except(dto.ValueRanges);
            identifiersOfObjectsToDelete.AddRange(valueRangesToDelete);
            foreach (var identifier in valueRangesToDelete)
            {
                var valueRange = poco.ValueRanges.Single(x => x.Id == identifier);
                poco.ValueRanges.Remove(valueRange);
            }

            if (poco.ValueTypeDetachedError != null && poco.ValueTypeDetachedError.Id != dto.ValueTypeDetachedError)
            {
                identifiersOfObjectsToDelete.Add(poco.ValueTypeDetachedError.Id);
                poco.ValueTypeDetachedError = null;
            }

            return identifiersOfObjectsToDelete;
        }

        /// <summary>
        /// Updates the Reference properties of the <see cref="PathConditionRoleValueConstraint"/> using the data (identifiers) encapsulated in the DTO
        /// and the provided cache to find the referenced object.
        /// </summary>
        /// <param name="poco">
        /// The <see cref="PathConditionRoleValueConstraint"/> that is to be updated
        /// </param>
        /// <param name="dto">
        /// The DTO that is used to update the <see cref="PathConditionRoleValueConstraint"/> with
        /// </param>
        /// <param name="cache">
        /// The <see cref="ConcurrentDictionary{String, Lazy{Kalliope.Core.ModelThing}}"/> that contains the
        /// <see cref="ModelThing"/>s that are know and cached.
        /// </param>
        /// <exception cref="ArgumentNullException"></exception>
        public static void UpdateReferenceProperties(this Kalliope.Core.PathConditionRoleValueConstraint poco, Kalliope.DTO.PathConditionRoleValueConstraint dto, ConcurrentDictionary<string, Lazy<Kalliope.Core.ModelThing>> cache)
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

            if (poco.Note == null && !string.IsNullOrEmpty(dto.Note))
            {
                if (cache.TryGetValue(dto.Note, out lazyPoco))
                {
                    poco.Note = (Note)lazyPoco.Value;
                }
            }

            if (poco.ValueRangeOverlapError == null && !string.IsNullOrEmpty(dto.ValueRangeOverlapError))
            {
                if (cache.TryGetValue(dto.ValueRangeOverlapError, out lazyPoco))
                {
                    poco.ValueRangeOverlapError = (ValueRangeOverlapError)lazyPoco.Value;
                }
            }

            var valueRangesToAdd = dto.ValueRanges.Except(poco.ValueRanges.Select(x => x.Id));
            foreach (var identifier in valueRangesToAdd)
            {
                if (cache.TryGetValue(identifier, out lazyPoco))
                {
                    var valueRange = (ValueRange)lazyPoco.Value;
                    poco.ValueRanges.Add(valueRange);
                }
            }

            if (poco.ValueTypeDetachedError == null && !string.IsNullOrEmpty(dto.ValueTypeDetachedError))
            {
                if (cache.TryGetValue(dto.ValueTypeDetachedError, out lazyPoco))
                {
                    poco.ValueTypeDetachedError = (ValueConstraintValueTypeDetachedError)lazyPoco.Value;
                }
            }
        }
    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------