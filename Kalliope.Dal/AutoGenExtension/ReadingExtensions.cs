// -------------------------------------------------------------------------------------------------
// <copyright file="ReadingExtensions.cs" company="RHEA System S.A.">
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
    using Kalliope.CustomProperties;
    using Kalliope.Diagrams;

    /// <summary>
    /// A static class that provides extension methods for the <see cref="Reading"/> class
    /// </summary>
    public static class ReadingExtensions
    {
        /// <summary>
        /// Updates the value properties of the <see cref="Reading"/> by setting the value equal to that of the dto
        /// Removes deleted objects from the reference properties and returns the unique identifiers
        /// of the objects that have been removed from <see cref="AggregationKind.Composite"/> properties
        /// </summary>
        /// <param name="poco">
        /// The <see cref="Reading"/> that is to be updated
        /// </param>
        /// <param name="dto">
        /// The DTO that is used to update the <see cref="Reading"/> with
        /// </param>
        /// <returns>
        /// The unique identifiers of the objects that have been removed from <see cref="AggregationKind.Composite"/> properties
        /// </returns>
        /// <exception cref="ArgumentNullException">
        /// Thrown when the <paramref name="poco"/> or <paramref name="dto"/> is null
        /// </exception>
        public static IEnumerable<string> UpdateValueAndRemoveDeletedReferenceProperties(this Kalliope.Core.Reading poco, Kalliope.DTO.Reading dto)
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

            poco.Data = dto.Data;

            if (poco.DuplicateSignatureError != null && poco.DuplicateSignatureError.Id != dto.DuplicateSignatureError)
            {
                poco.DuplicateSignatureError = null;
            }

            var expandedDataToDelete = poco.ExpandedData.Select(x => x.Id).Except(dto.ExpandedData);
            identifiersOfObjectsToDelete.AddRange(expandedDataToDelete);
            foreach (var identifier in expandedDataToDelete)
            {
                var roleText = poco.ExpandedData.Single(x => x.Id == identifier);
                poco.ExpandedData.Remove(roleText);
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

            poco.IsPrimaryForFactType = dto.IsPrimaryForFactType;

            poco.IsPrimaryForReadingOrder = dto.IsPrimaryForReadingOrder;

            poco.Language = dto.Language;

            if (poco.RequiresUserModificationError != null && poco.RequiresUserModificationError.Id != dto.RequiresUserModificationError)
            {
                identifiersOfObjectsToDelete.Add(poco.RequiresUserModificationError.Id);
                poco.RequiresUserModificationError = null;
            }

            poco.Signature = dto.Signature;

            poco.Text = dto.Text;

            if (poco.TooFewRolesError != null && poco.TooFewRolesError.Id != dto.TooFewRolesError)
            {
                identifiersOfObjectsToDelete.Add(poco.TooFewRolesError.Id);
                poco.TooFewRolesError = null;
            }

            if (poco.TooManyRolesError != null && poco.TooManyRolesError.Id != dto.TooManyRolesError)
            {
                identifiersOfObjectsToDelete.Add(poco.TooManyRolesError.Id);
                poco.TooManyRolesError = null;
            }

            return identifiersOfObjectsToDelete;
        }

        /// <summary>
        /// Updates the Reference properties of the <see cref="Reading"/> using the data (identifiers) encapsulated in the DTO
        /// and the provided cache to find the referenced object.
        /// </summary>
        /// <param name="poco">
        /// The <see cref="Reading"/> that is to be updated
        /// </param>
        /// <param name="dto">
        /// The DTO that is used to update the <see cref="Reading"/> with
        /// </param>
        /// <param name="cache">
        /// The <see cref="ConcurrentDictionary{String, Lazy{Kalliope.Core.ModelThing}}"/> that contains the
        /// <see cref="ModelThing"/>s that are know and cached.
        /// </param>
        /// <exception cref="ArgumentNullException"></exception>
        public static void UpdateReferenceProperties(this Kalliope.Core.Reading poco, Kalliope.DTO.Reading dto, ConcurrentDictionary<string, Lazy<Kalliope.Core.ModelThing>> cache)
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

            if (poco.DuplicateSignatureError == null && !string.IsNullOrEmpty(dto.DuplicateSignatureError) && cache.TryGetValue(dto.DuplicateSignatureError, out lazyPoco))
            {
                poco.DuplicateSignatureError = (DuplicateReadingSignatureError)lazyPoco.Value;
            }

            var expandedDataToAdd = dto.ExpandedData.Except(poco.ExpandedData.Select(x => x.Id));
            foreach (var identifier in expandedDataToAdd)
            {
                if (cache.TryGetValue(identifier, out lazyPoco))
                {
                    var roleText = (RoleText)lazyPoco.Value;
                    poco.ExpandedData.Add(roleText);
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

            if (poco.RequiresUserModificationError == null && !string.IsNullOrEmpty(dto.RequiresUserModificationError) && cache.TryGetValue(dto.RequiresUserModificationError, out lazyPoco))
            {
                poco.RequiresUserModificationError = (ReadingRequiresUserModificationError)lazyPoco.Value;
            }

            if (poco.TooFewRolesError == null && !string.IsNullOrEmpty(dto.TooFewRolesError) && cache.TryGetValue(dto.TooFewRolesError, out lazyPoco))
            {
                poco.TooFewRolesError = (TooFewReadingRolesError)lazyPoco.Value;
            }

            if (poco.TooManyRolesError == null && !string.IsNullOrEmpty(dto.TooManyRolesError) && cache.TryGetValue(dto.TooManyRolesError, out lazyPoco))
            {
                poco.TooManyRolesError = (TooManyReadingRolesError)lazyPoco.Value;
            }
        }
    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
