// -------------------------------------------------------------------------------------------------
// <copyright file="QueryDerivationPathExtensions.cs" company="RHEA System S.A.">
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

    using Kalliope.Absorption;
    using Kalliope.Common;
    using Kalliope.Core;
    using Kalliope.CustomProperties;
    using Kalliope.Diagrams;

    /// <summary>
    /// A static class that provides extension methods for the <see cref="QueryDerivationPath"/> class
    /// </summary>
    public static class QueryDerivationPathExtensions
    {
        /// <summary>
        /// Updates the value properties of the <see cref="QueryDerivationPath"/> by setting the value equal to that of the dto
        /// Removes deleted objects from the reference properties and returns the unique identifiers
        /// of the objects that have been removed from <see cref="AggregationKind.Composite"/> properties
        /// </summary>
        /// <param name="poco">
        /// The <see cref="QueryDerivationPath"/> that is to be updated
        /// </param>
        /// <param name="dto">
        /// The DTO that is used to update the <see cref="QueryDerivationPath"/> with
        /// </param>
        /// <returns>
        /// The unique identifiers of the objects that have been removed from <see cref="AggregationKind.Composite"/> properties
        /// </returns>
        /// <exception cref="ArgumentNullException">
        /// Thrown when the <paramref name="poco"/> or <paramref name="dto"/> is null
        /// </exception>
        public static IEnumerable<string> UpdateValueAndRemoveDeletedReferenceProperties(this Kalliope.Core.QueryDerivationPath poco, Kalliope.DTO.QueryDerivationPath dto)
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

            var calculatedConditionsToDelete = poco.CalculatedConditions.Select(x => x.Id).Except(dto.CalculatedConditions);
            foreach (var identifier in calculatedConditionsToDelete)
            {
                var calculatedPathValue = poco.CalculatedConditions.Single(x => x.Id == identifier);
                poco.CalculatedConditions.Remove(calculatedPathValue);
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

            var leadRolePathsToDelete = poco.LeadRolePaths.Select(x => x.Id).Except(dto.LeadRolePaths);
            identifiersOfObjectsToDelete.AddRange(leadRolePathsToDelete);
            foreach (var identifier in leadRolePathsToDelete)
            {
                var leadRolePath = poco.LeadRolePaths.Single(x => x.Id == identifier);
                poco.LeadRolePaths.Remove(leadRolePath);
            }

            var ownedLeadRolePathsToDelete = poco.OwnedLeadRolePaths.Select(x => x.Id).Except(dto.OwnedLeadRolePaths);
            foreach (var identifier in ownedLeadRolePathsToDelete)
            {
                var leadRolePath = poco.OwnedLeadRolePaths.Single(x => x.Id == identifier);
                poco.OwnedLeadRolePaths.Remove(leadRolePath);
            }

            var ownedSubqueriesToDelete = poco.OwnedSubqueries.Select(x => x.Id).Except(dto.OwnedSubqueries);
            foreach (var identifier in ownedSubqueriesToDelete)
            {
                var subquery = poco.OwnedSubqueries.Single(x => x.Id == identifier);
                poco.OwnedSubqueries.Remove(subquery);
            }

            if (poco.PathComponent != null && poco.PathComponent.Id != dto.PathComponent)
            {
                poco.PathComponent = null;
            }

            var sharedLeadRolePathsToDelete = poco.SharedLeadRolePaths.Select(x => x.Id).Except(dto.SharedLeadRolePaths);
            foreach (var identifier in sharedLeadRolePathsToDelete)
            {
                var leadRolePath = poco.SharedLeadRolePaths.Single(x => x.Id == identifier);
                poco.SharedLeadRolePaths.Remove(leadRolePath);
            }

            var sharedSubqueriesToDelete = poco.SharedSubqueries.Select(x => x.Id).Except(dto.SharedSubqueries);
            foreach (var identifier in sharedSubqueriesToDelete)
            {
                var subquery = poco.SharedSubqueries.Single(x => x.Id == identifier);
                poco.SharedSubqueries.Remove(subquery);
            }

            if (poco.SingleLeadRolePath != null && poco.SingleLeadRolePath.Id != dto.SingleLeadRolePath)
            {
                poco.SingleLeadRolePath = null;
            }

            if (poco.SingleOwnedLeadRolePath != null && poco.SingleOwnedLeadRolePath.Id != dto.SingleOwnedLeadRolePath)
            {
                poco.SingleOwnedLeadRolePath = null;
            }

            var subqueriesToDelete = poco.Subqueries.Select(x => x.Id).Except(dto.Subqueries);
            identifiersOfObjectsToDelete.AddRange(subqueriesToDelete);
            foreach (var identifier in subqueriesToDelete)
            {
                var subquery = poco.Subqueries.Single(x => x.Id == identifier);
                poco.Subqueries.Remove(subquery);
            }

            return identifiersOfObjectsToDelete;
        }

        /// <summary>
        /// Updates the Reference properties of the <see cref="QueryDerivationPath"/> using the data (identifiers) encapsulated in the DTO
        /// and the provided cache to find the referenced object.
        /// </summary>
        /// <param name="poco">
        /// The <see cref="QueryDerivationPath"/> that is to be updated
        /// </param>
        /// <param name="dto">
        /// The DTO that is used to update the <see cref="QueryDerivationPath"/> with
        /// </param>
        /// <param name="cache">
        /// The <see cref="ConcurrentDictionary{String, Lazy{Kalliope.Core.ModelThing}}"/> that contains the
        /// <see cref="ModelThing"/>s that are know and cached.
        /// </param>
        /// <exception cref="ArgumentNullException"></exception>
        public static void UpdateReferenceProperties(this Kalliope.Core.QueryDerivationPath poco, Kalliope.DTO.QueryDerivationPath dto, ConcurrentDictionary<string, Lazy<Kalliope.Core.ModelThing>> cache)
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

            var calculatedConditionsToAdd = dto.CalculatedConditions.Except(poco.CalculatedConditions.Select(x => x.Id));
            foreach (var identifier in calculatedConditionsToAdd)
            {
                if (cache.TryGetValue(identifier, out lazyPoco))
                {
                    var calculatedPathValue = (CalculatedPathValue)lazyPoco.Value;
                    poco.CalculatedConditions.Add(calculatedPathValue);
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

            var leadRolePathsToAdd = dto.LeadRolePaths.Except(poco.LeadRolePaths.Select(x => x.Id));
            foreach (var identifier in leadRolePathsToAdd)
            {
                if (cache.TryGetValue(identifier, out lazyPoco))
                {
                    var leadRolePath = (LeadRolePath)lazyPoco.Value;
                    poco.LeadRolePaths.Add(leadRolePath);
                }
            }

            var ownedLeadRolePathsToAdd = dto.OwnedLeadRolePaths.Except(poco.OwnedLeadRolePaths.Select(x => x.Id));
            foreach (var identifier in ownedLeadRolePathsToAdd)
            {
                if (cache.TryGetValue(identifier, out lazyPoco))
                {
                    var leadRolePath = (LeadRolePath)lazyPoco.Value;
                    poco.OwnedLeadRolePaths.Add(leadRolePath);
                }
            }

            var ownedSubqueriesToAdd = dto.OwnedSubqueries.Except(poco.OwnedSubqueries.Select(x => x.Id));
            foreach (var identifier in ownedSubqueriesToAdd)
            {
                if (cache.TryGetValue(identifier, out lazyPoco))
                {
                    var subquery = (Subquery)lazyPoco.Value;
                    poco.OwnedSubqueries.Add(subquery);
                }
            }

            if (poco.PathComponent == null && !string.IsNullOrEmpty(dto.PathComponent) && cache.TryGetValue(dto.PathComponent, out lazyPoco))
            {
                poco.PathComponent = (LeadRolePath)lazyPoco.Value;
            }

            var sharedLeadRolePathsToAdd = dto.SharedLeadRolePaths.Except(poco.SharedLeadRolePaths.Select(x => x.Id));
            foreach (var identifier in sharedLeadRolePathsToAdd)
            {
                if (cache.TryGetValue(identifier, out lazyPoco))
                {
                    var leadRolePath = (LeadRolePath)lazyPoco.Value;
                    poco.SharedLeadRolePaths.Add(leadRolePath);
                }
            }

            var sharedSubqueriesToAdd = dto.SharedSubqueries.Except(poco.SharedSubqueries.Select(x => x.Id));
            foreach (var identifier in sharedSubqueriesToAdd)
            {
                if (cache.TryGetValue(identifier, out lazyPoco))
                {
                    var subquery = (Subquery)lazyPoco.Value;
                    poco.SharedSubqueries.Add(subquery);
                }
            }

            if (poco.SingleLeadRolePath == null && !string.IsNullOrEmpty(dto.SingleLeadRolePath) && cache.TryGetValue(dto.SingleLeadRolePath, out lazyPoco))
            {
                poco.SingleLeadRolePath = (LeadRolePath)lazyPoco.Value;
            }

            if (poco.SingleOwnedLeadRolePath == null && !string.IsNullOrEmpty(dto.SingleOwnedLeadRolePath) && cache.TryGetValue(dto.SingleOwnedLeadRolePath, out lazyPoco))
            {
                poco.SingleOwnedLeadRolePath = (LeadRolePath)lazyPoco.Value;
            }

            var subqueriesToAdd = dto.Subqueries.Except(poco.Subqueries.Select(x => x.Id));
            foreach (var identifier in subqueriesToAdd)
            {
                if (cache.TryGetValue(identifier, out lazyPoco))
                {
                    var subquery = (Subquery)lazyPoco.Value;
                    poco.Subqueries.Add(subquery);
                }
            }
        }
    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
