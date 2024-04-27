// -------------------------------------------------------------------------------------------------
// <copyright file="RoleSubPathExtensions.cs" company="Starion Group S.A.">
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
    /// A static class that provides extension methods for the <see cref="RoleSubPath"/> class
    /// </summary>
    public static class RoleSubPathExtensions
    {
        /// <summary>
        /// Updates the value properties of the <see cref="RoleSubPath"/> by setting the value equal to that of the dto
        /// Removes deleted objects from the reference properties and returns the unique identifiers
        /// of the objects that have been removed from <see cref="AggregationKind.Composite"/> properties
        /// </summary>
        /// <param name="poco">
        /// The <see cref="RoleSubPath"/> that is to be updated
        /// </param>
        /// <param name="dto">
        /// The DTO that is used to update the <see cref="RoleSubPath"/> with
        /// </param>
        /// <returns>
        /// The unique identifiers of the objects that have been removed from <see cref="AggregationKind.Composite"/> properties
        /// </returns>
        /// <exception cref="ArgumentNullException">
        /// Thrown when the <paramref name="poco"/> or <paramref name="dto"/> is null
        /// </exception>
        public static IEnumerable<string> UpdateValueAndRemoveDeletedReferenceProperties(this Kalliope.Core.RoleSubPath poco, Kalliope.DTO.RoleSubPath dto)
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

            var rolesToDelete = poco.Roles.Select(x => x.Id).Except(dto.Roles);
            foreach (var identifier in rolesToDelete)
            {
                var role = poco.Roles.Single(x => x.Id == identifier);
                poco.Roles.Remove(role);
            }

            if (poco.RootObjectType != null && poco.RootObjectType.Id != dto.RootObjectType)
            {
                poco.RootObjectType = null;
            }

            if (poco.RootObjectTypeRequiredError != null && poco.RootObjectTypeRequiredError.Id != dto.RootObjectTypeRequiredError)
            {
                identifiersOfObjectsToDelete.Add(poco.RootObjectTypeRequiredError.Id);
                poco.RootObjectTypeRequiredError = null;
            }

            poco.SplitCombinationOperator = dto.SplitCombinationOperator;

            poco.SplitIsNegated = dto.SplitIsNegated;

            var subPathsToDelete = poco.SubPaths.Select(x => x.Id).Except(dto.SubPaths);
            identifiersOfObjectsToDelete.AddRange(subPathsToDelete);
            foreach (var identifier in subPathsToDelete)
            {
                var roleSubPath = poco.SubPaths.Single(x => x.Id == identifier);
                poco.SubPaths.Remove(roleSubPath);
            }

            return identifiersOfObjectsToDelete;
        }

        /// <summary>
        /// Updates the Reference properties of the <see cref="RoleSubPath"/> using the data (identifiers) encapsulated in the DTO
        /// and the provided cache to find the referenced object.
        /// </summary>
        /// <param name="poco">
        /// The <see cref="RoleSubPath"/> that is to be updated
        /// </param>
        /// <param name="dto">
        /// The DTO that is used to update the <see cref="RoleSubPath"/> with
        /// </param>
        /// <param name="cache">
        /// The <see cref="ConcurrentDictionary{String, Lazy{Kalliope.Core.ModelThing}}"/> that contains the
        /// <see cref="ModelThing"/>s that are know and cached.
        /// </param>
        /// <exception cref="ArgumentNullException"></exception>
        public static void UpdateReferenceProperties(this Kalliope.Core.RoleSubPath poco, Kalliope.DTO.RoleSubPath dto, ConcurrentDictionary<string, Lazy<Kalliope.Core.ModelThing>> cache)
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

            var rolesToAdd = dto.Roles.Except(poco.Roles.Select(x => x.Id));
            foreach (var identifier in rolesToAdd)
            {
                if (cache.TryGetValue(identifier, out lazyPoco))
                {
                    var role = (Role)lazyPoco.Value;
                    poco.Roles.Add(role);
                }
            }

            if (poco.RootObjectType == null && !string.IsNullOrEmpty(dto.RootObjectType) && cache.TryGetValue(dto.RootObjectType, out lazyPoco))
            {
                poco.RootObjectType = (ObjectType)lazyPoco.Value;
            }

            if (poco.RootObjectTypeRequiredError == null && !string.IsNullOrEmpty(dto.RootObjectTypeRequiredError) && cache.TryGetValue(dto.RootObjectTypeRequiredError, out lazyPoco))
            {
                poco.RootObjectTypeRequiredError = (PathRequiresRootObjectTypeError)lazyPoco.Value;
            }

            var subPathsToAdd = dto.SubPaths.Except(poco.SubPaths.Select(x => x.Id));
            foreach (var identifier in subPathsToAdd)
            {
                if (cache.TryGetValue(identifier, out lazyPoco))
                {
                    var roleSubPath = (RoleSubPath)lazyPoco.Value;
                    poco.SubPaths.Add(roleSubPath);
                }
            }
        }
    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
