// -------------------------------------------------------------------------------------------------
// <copyright file="SubtypeDerivationRuleExtensions.cs" company="RHEA System S.A.">
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
    /// A static class that provides extension methods for the <see cref="SubtypeDerivationRule"/> class
    /// </summary>
    public static class SubtypeDerivationRuleExtensions
    {
        /// <summary>
        /// Updates the value properties of the <see cref="SubtypeDerivationRule"/> by setting the value equal to that of the dto
        /// Removes deleted objects from the reference properties and returns the unique identifiers
        /// of the objects that have been removed from <see cref="AggregationKind.Composite"/> properties
        /// </summary>
        /// <param name="poco">
        /// The <see cref="SubtypeDerivationRule"/> that is to be updated
        /// </param>
        /// <param name="dto">
        /// The DTO that is used to update the <see cref="SubtypeDerivationRule"/> with
        /// </param>
        /// <returns>
        /// The unique identifiers of the objects that have been removed from <see cref="AggregationKind.Composite"/> properties
        /// </returns>
        /// <exception cref="ArgumentNullException">
        /// Thrown when the <paramref name="poco"/> or <paramref name="dto"/> is null
        /// </exception>
        public static IEnumerable<string> UpdateValueAndRemoveDeletedReferenceProperties(this Kalliope.Core.SubtypeDerivationRule poco, Kalliope.DTO.SubtypeDerivationRule dto)
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
 
            poco.DerivationCompleteness = dto.DerivationCompleteness;
 
            if (poco.DerivationNote != null && poco.DerivationNote.Id != dto.DerivationNote)
            {
                identifiersOfObjectsToDelete.Add(poco.DerivationNote.Id);
                poco.DerivationNote = null;
            }
 
            poco.DerivationStorage = dto.DerivationStorage;
 
            var extensionModelErrorsToDelete = poco.ExtensionModelErrors.Select(x => x.Id).Except(dto.ExtensionModelErrors);
            foreach (var identifier in extensionModelErrorsToDelete)
            {
                var modelError = poco.ExtensionModelErrors.Single(x => x.Id == identifier);
                poco.ExtensionModelErrors.Remove(modelError);
            }
 
            poco.ExternalDerivation = dto.ExternalDerivation;
 
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
    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
