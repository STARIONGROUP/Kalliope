// -------------------------------------------------------------------------------------------------
// <copyright file="SubqueryExtensions.cs" company="RHEA System S.A.">
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
    /// A static class that provides extension methods for the <see cref="Subquery"/> class
    /// </summary>
    public static class SubqueryExtensions
    {
        /// <summary>
        /// Updates the value properties of the <see cref="Subquery"/> by setting the value equal to that of the dto
        /// Removes deleted objects from the reference properties and returns the unique identifiers
        /// of the objects that have been removed from <see cref="AggregationKind.Composite"/> properties
        /// </summary>
        /// <param name="poco">
        /// The <see cref="Subquery"/> that is to be updated
        /// </param>
        /// <param name="dto">
        /// The DTO that is used to update the <see cref="Subquery"/> with
        /// </param>
        /// <returns>
        /// The unique identifiers of the objects that have been removed from <see cref="AggregationKind.Composite"/> properties
        /// </returns>
        /// <exception cref="ArgumentNullException">
        /// Thrown when the <paramref name="poco"/> or <paramref name="dto"/> is null
        /// </exception>
        public static IEnumerable<string> UpdateValueAndRemoveDeletedReferenceProperties(this Kalliope.Core.Subquery poco, Kalliope.DTO.Subquery dto)
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
 
            if (poco.DerivationExpression != null && poco.DerivationExpression.Id != dto.DerivationExpression)
            {
                identifiersOfObjectsToDelete.Add(poco.DerivationExpression.Id);
                poco.DerivationExpression = null;
            }
 
            poco.DerivationNoteDisplay = dto.DerivationNoteDisplay;
 
            if (poco.DerivationRule != null && poco.DerivationRule.Id != dto.DerivationRule)
            {
                identifiersOfObjectsToDelete.Add(poco.DerivationRule.Id);
                poco.DerivationRule = null;
            }
 
            poco.DerivationStorageDisplay = dto.DerivationStorageDisplay;
 
            var extensionModelErrorsToDelete = poco.ExtensionModelErrors.Select(x => x.Id).Except(dto.ExtensionModelErrors);
            foreach (var identifier in extensionModelErrorsToDelete)
            {
                var modelError = poco.ExtensionModelErrors.Single(x => x.Id == identifier);
                poco.ExtensionModelErrors.Remove(modelError);
            }
 
            var factTypeInstancesToDelete = poco.FactTypeInstances.Select(x => x.Id).Except(dto.FactTypeInstances);
            identifiersOfObjectsToDelete.AddRange(factTypeInstancesToDelete);
            foreach (var identifier in factTypeInstancesToDelete)
            {
                var factTypeInstance = poco.FactTypeInstances.Single(x => x.Id == identifier);
                poco.FactTypeInstances.Remove(factTypeInstance);
            }
 
            if (poco.ImpliedInternalUniquenessConstraintError != null && poco.ImpliedInternalUniquenessConstraintError.Id != dto.ImpliedInternalUniquenessConstraintError)
            {
                identifiersOfObjectsToDelete.Add(poco.ImpliedInternalUniquenessConstraintError.Id);
                poco.ImpliedInternalUniquenessConstraintError = null;
            }
 
            var internalConstraintsToDelete = poco.InternalConstraints.Select(x => x.Id).Except(dto.InternalConstraints);
            foreach (var identifier in internalConstraintsToDelete)
            {
                var setConstraint = poco.InternalConstraints.Single(x => x.Id == identifier);
                poco.InternalConstraints.Remove(setConstraint);
            }
 
            if (poco.InternalUniquenessConstraintRequiredError != null && poco.InternalUniquenessConstraintRequiredError.Id != dto.InternalUniquenessConstraintRequiredError)
            {
                identifiersOfObjectsToDelete.Add(poco.InternalUniquenessConstraintRequiredError.Id);
                poco.InternalUniquenessConstraintRequiredError = null;
            }
 
            poco.IsExternal = dto.IsExternal;
 
            poco.Name = dto.Name;
 
            if (poco.Note != null && poco.Note.Id != dto.Note)
            {
                identifiersOfObjectsToDelete.Add(poco.Note.Id);
                poco.Note = null;
            }
 
            var parametersToDelete = poco.Parameters.Select(x => x.Id).Except(dto.Parameters);
            identifiersOfObjectsToDelete.AddRange(parametersToDelete);
            foreach (var identifier in parametersToDelete)
            {
                var queryParameter = poco.Parameters.Single(x => x.Id == identifier);
                poco.Parameters.Remove(queryParameter);
            }
 
            var readingOrdersToDelete = poco.ReadingOrders.Select(x => x.Id).Except(dto.ReadingOrders);
            identifiersOfObjectsToDelete.AddRange(readingOrdersToDelete);
            foreach (var identifier in readingOrdersToDelete)
            {
                var readingOrder = poco.ReadingOrders.Single(x => x.Id == identifier);
                poco.ReadingOrders.Remove(readingOrder);
            }
 
            if (poco.ReadingRequiredError != null && poco.ReadingRequiredError.Id != dto.ReadingRequiredError)
            {
                identifiersOfObjectsToDelete.Add(poco.ReadingRequiredError.Id);
                poco.ReadingRequiredError = null;
            }
 
            var rolesToDelete = poco.Roles.Select(x => x.Id).Except(dto.Roles);
            identifiersOfObjectsToDelete.AddRange(rolesToDelete);
            foreach (var identifier in rolesToDelete)
            {
                var roleBase = poco.Roles.Single(x => x.Id == identifier);
                poco.Roles.Remove(roleBase);
            }
 

            return identifiersOfObjectsToDelete;
        }
    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
