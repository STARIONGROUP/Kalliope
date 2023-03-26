// -------------------------------------------------------------------------------------------------
// <copyright file="SubqueryExtensions.cs" company="RHEA System S.A.">
//
//   Copyright 2022-2023 RHEA System S.A.
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

            var extensionsToDelete = poco.Extensions.Select(x => x.Id).Except(dto.Extensions);
            identifiersOfObjectsToDelete.AddRange(extensionsToDelete);
            foreach (var identifier in extensionsToDelete)
            {
                var extension = poco.Extensions.Single(x => x.Id == identifier);
                poco.Extensions.Remove(extension);
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

        /// <summary>
        /// Updates the Reference properties of the <see cref="Subquery"/> using the data (identifiers) encapsulated in the DTO
        /// and the provided cache to find the referenced object.
        /// </summary>
        /// <param name="poco">
        /// The <see cref="Subquery"/> that is to be updated
        /// </param>
        /// <param name="dto">
        /// The DTO that is used to update the <see cref="Subquery"/> with
        /// </param>
        /// <param name="cache">
        /// The <see cref="ConcurrentDictionary{String, Lazy{Kalliope.Core.ModelThing}}"/> that contains the
        /// <see cref="ModelThing"/>s that are know and cached.
        /// </param>
        /// <exception cref="ArgumentNullException"></exception>
        public static void UpdateReferenceProperties(this Kalliope.Core.Subquery poco, Kalliope.DTO.Subquery dto, ConcurrentDictionary<string, Lazy<Kalliope.Core.ModelThing>> cache)
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

            if (poco.Definition == null && !string.IsNullOrEmpty(dto.Definition) && cache.TryGetValue(dto.Definition, out lazyPoco))
            {
                poco.Definition = (Definition)lazyPoco.Value;
            }

            if (poco.DerivationExpression == null && !string.IsNullOrEmpty(dto.DerivationExpression) && cache.TryGetValue(dto.DerivationExpression, out lazyPoco))
            {
                poco.DerivationExpression = (FactTypeDerivationExpression)lazyPoco.Value;
            }

            if (poco.DerivationRule == null && !string.IsNullOrEmpty(dto.DerivationRule) && cache.TryGetValue(dto.DerivationRule, out lazyPoco))
            {
                poco.DerivationRule = (RoleProjectedDerivationRule)lazyPoco.Value;
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

            var factTypeInstancesToAdd = dto.FactTypeInstances.Except(poco.FactTypeInstances.Select(x => x.Id));
            foreach (var identifier in factTypeInstancesToAdd)
            {
                if (cache.TryGetValue(identifier, out lazyPoco))
                {
                    var factTypeInstance = (FactTypeInstance)lazyPoco.Value;
                    poco.FactTypeInstances.Add(factTypeInstance);
                }
            }

            if (poco.ImpliedInternalUniquenessConstraintError == null && !string.IsNullOrEmpty(dto.ImpliedInternalUniquenessConstraintError) && cache.TryGetValue(dto.ImpliedInternalUniquenessConstraintError, out lazyPoco))
            {
                poco.ImpliedInternalUniquenessConstraintError = (ImpliedInternalUniquenessConstraintError)lazyPoco.Value;
            }

            var internalConstraintsToAdd = dto.InternalConstraints.Except(poco.InternalConstraints.Select(x => x.Id));
            foreach (var identifier in internalConstraintsToAdd)
            {
                if (cache.TryGetValue(identifier, out lazyPoco))
                {
                    var setConstraint = (SetConstraint)lazyPoco.Value;
                    poco.InternalConstraints.Add(setConstraint);
                }
            }

            if (poco.InternalUniquenessConstraintRequiredError == null && !string.IsNullOrEmpty(dto.InternalUniquenessConstraintRequiredError) && cache.TryGetValue(dto.InternalUniquenessConstraintRequiredError, out lazyPoco))
            {
                poco.InternalUniquenessConstraintRequiredError = (FactTypeRequiresInternalUniquenessConstraintError)lazyPoco.Value;
            }

            if (poco.Note == null && !string.IsNullOrEmpty(dto.Note) && cache.TryGetValue(dto.Note, out lazyPoco))
            {
                poco.Note = (Note)lazyPoco.Value;
            }

            var parametersToAdd = dto.Parameters.Except(poco.Parameters.Select(x => x.Id));
            foreach (var identifier in parametersToAdd)
            {
                if (cache.TryGetValue(identifier, out lazyPoco))
                {
                    var queryParameter = (QueryParameter)lazyPoco.Value;
                    poco.Parameters.Add(queryParameter);
                }
            }

            var readingOrdersToAdd = dto.ReadingOrders.Except(poco.ReadingOrders.Select(x => x.Id));
            foreach (var identifier in readingOrdersToAdd)
            {
                if (cache.TryGetValue(identifier, out lazyPoco))
                {
                    var readingOrder = (ReadingOrder)lazyPoco.Value;
                    poco.ReadingOrders.Add(readingOrder);
                }
            }

            if (poco.ReadingRequiredError == null && !string.IsNullOrEmpty(dto.ReadingRequiredError) && cache.TryGetValue(dto.ReadingRequiredError, out lazyPoco))
            {
                poco.ReadingRequiredError = (FactTypeRequiresReadingError)lazyPoco.Value;
            }

            var rolesToAdd = dto.Roles.Except(poco.Roles.Select(x => x.Id));
            foreach (var identifier in rolesToAdd)
            {
                if (cache.TryGetValue(identifier, out lazyPoco))
                {
                    var roleBase = (RoleBase)lazyPoco.Value;
                    poco.Roles.Add(roleBase);
                }
            }
        }
    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
