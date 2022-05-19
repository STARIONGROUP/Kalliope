// -------------------------------------------------------------------------------------------------
// <copyright file="EntityTypeExtensions.cs" company="RHEA System S.A.">
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
    /// A static class that provides extension methods for the <see cref="EntityType"/> class
    /// </summary>
    public static class EntityTypeExtensions
    {
        /// <summary>
        /// Updates the value properties of the <see cref="EntityType"/> by setting the value equal to that of the dto
        /// Removes deleted objects from the reference properties and returns the unique identifiers
        /// of the objects that have been removed from <see cref="AggregationKind.Composite"/> properties
        /// </summary>
        /// <param name="poco">
        /// The <see cref="EntityType"/> that is to be updated
        /// </param>
        /// <param name="dto">
        /// The DTO that is used to update the <see cref="EntityType"/> with
        /// </param>
        /// <returns>
        /// The unique identifiers of the objects that have been removed from <see cref="AggregationKind.Composite"/> properties
        /// </returns>
        /// <exception cref="ArgumentNullException">
        /// Thrown when the <paramref name="poco"/> or <paramref name="dto"/> is null
        /// </exception>
        public static IEnumerable<string> UpdateValueAndRemoveDeletedReferenceProperties(this Kalliope.Core.EntityType poco, Kalliope.DTO.EntityType dto)
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

            var abbreviationsToDelete = poco.Abbreviations.Select(x => x.Id).Except(dto.Abbreviations);
            identifiersOfObjectsToDelete.AddRange(abbreviationsToDelete);
            foreach (var identifier in abbreviationsToDelete)
            {
                var nameAlias = poco.Abbreviations.Single(x => x.Id == identifier);
                poco.Abbreviations.Remove(nameAlias);
            }

            var associatedModelErrorsToDelete = poco.AssociatedModelErrors.Select(x => x.Id).Except(dto.AssociatedModelErrors);
            foreach (var identifier in associatedModelErrorsToDelete)
            {
                var modelError = poco.AssociatedModelErrors.Single(x => x.Id == identifier);
                poco.AssociatedModelErrors.Remove(modelError);
            }

            if (poco.Cardinality != null && poco.Cardinality.Id != dto.Cardinality)
            {
                identifiersOfObjectsToDelete.Add(poco.Cardinality.Id);
                poco.Cardinality = null;
            }

            if (poco.CompatibleSupertypesError != null && poco.CompatibleSupertypesError.Id != dto.CompatibleSupertypesError)
            {
                identifiersOfObjectsToDelete.Add(poco.CompatibleSupertypesError.Id);
                poco.CompatibleSupertypesError = null;
            }

            if (poco.ConceptualDataType != null && poco.ConceptualDataType.Id != dto.ConceptualDataType)
            {
                identifiersOfObjectsToDelete.Add(poco.ConceptualDataType.Id);
                poco.ConceptualDataType = null;
            }

            if (poco.DataType != null && poco.DataType.Id != dto.DataType)
            {
                poco.DataType = null;
            }

            poco.DataTypeLength = dto.DataTypeLength;

            poco.DataTypeScale = dto.DataTypeScale;

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

            if (poco.DuplicateNameError != null && poco.DuplicateNameError.Id != dto.DuplicateNameError)
            {
                poco.DuplicateNameError = null;
            }

            var entityTypeInstancesToDelete = poco.EntityTypeInstances.Select(x => x.Id).Except(dto.EntityTypeInstances);
            identifiersOfObjectsToDelete.AddRange(entityTypeInstancesToDelete);
            foreach (var identifier in entityTypeInstancesToDelete)
            {
                var entityTypeInstance = poco.EntityTypeInstances.Single(x => x.Id == identifier);
                poco.EntityTypeInstances.Remove(entityTypeInstance);
            }

            var entityTypeSubtypeInstancesToDelete = poco.EntityTypeSubtypeInstances.Select(x => x.Id).Except(dto.EntityTypeSubtypeInstances);
            identifiersOfObjectsToDelete.AddRange(entityTypeSubtypeInstancesToDelete);
            foreach (var identifier in entityTypeSubtypeInstancesToDelete)
            {
                var entityTypeSubtypeInstance = poco.EntityTypeSubtypeInstances.Single(x => x.Id == identifier);
                poco.EntityTypeSubtypeInstances.Remove(entityTypeSubtypeInstance);
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

            if (poco.FactType != null && poco.FactType.Id != dto.FactType)
            {
                poco.FactType = null;
            }

            if (poco.ImpliedMandatoryConstraint != null && poco.ImpliedMandatoryConstraint.Id != dto.ImpliedMandatoryConstraint)
            {
                identifiersOfObjectsToDelete.Add(poco.ImpliedMandatoryConstraint.Id);
                poco.ImpliedMandatoryConstraint = null;
            }

            if (poco.InherentMandatoryConstraint != null && poco.InherentMandatoryConstraint.Id != dto.InherentMandatoryConstraint)
            {
                poco.InherentMandatoryConstraint = null;
            }

            poco.IsExternal = dto.IsExternal;

            poco.IsImplicitBooleanValue = dto.IsImplicitBooleanValue;

            poco.IsIndependent = dto.IsIndependent;

            poco.IsPersonal = dto.IsPersonal;

            poco.IsSupertypePersonal = dto.IsSupertypePersonal;

            poco.IsValueType = dto.IsValueType;

            poco.Name = dto.Name;

            if (poco.Note != null && poco.Note.Id != dto.Note)
            {
                identifiersOfObjectsToDelete.Add(poco.Note.Id);
                poco.Note = null;
            }

            var objectTypeInstancesToDelete = poco.ObjectTypeInstances.Select(x => x.Id).Except(dto.ObjectTypeInstances);
            identifiersOfObjectsToDelete.AddRange(objectTypeInstancesToDelete);
            foreach (var identifier in objectTypeInstancesToDelete)
            {
                var objectTypeInstance = poco.ObjectTypeInstances.Single(x => x.Id == identifier);
                poco.ObjectTypeInstances.Remove(objectTypeInstance);
            }

            var playedRolesToDelete = poco.PlayedRoles.Select(x => x.Id).Except(dto.PlayedRoles);
            foreach (var identifier in playedRolesToDelete)
            {
                var role = poco.PlayedRoles.Single(x => x.Id == identifier);
                poco.PlayedRoles.Remove(role);
            }

            if (poco.PreferredIdentifier != null && poco.PreferredIdentifier.Id != dto.PreferredIdentifier)
            {
                poco.PreferredIdentifier = null;
            }

            if (poco.PreferredIdentifierRequiresMandatoryError != null && poco.PreferredIdentifierRequiresMandatoryError.Id != dto.PreferredIdentifierRequiresMandatoryError)
            {
                identifiersOfObjectsToDelete.Add(poco.PreferredIdentifierRequiresMandatoryError.Id);
                poco.PreferredIdentifierRequiresMandatoryError = null;
            }

            poco.ReferenceMode = dto.ReferenceMode;

            poco.ReferenceModeDecoratedString = dto.ReferenceModeDecoratedString;

            if (poco.ReferenceSchemeError != null && poco.ReferenceSchemeError.Id != dto.ReferenceSchemeError)
            {
                identifiersOfObjectsToDelete.Add(poco.ReferenceSchemeError.Id);
                poco.ReferenceSchemeError = null;
            }

            poco.TreatAsPersonal = dto.TreatAsPersonal;

            if (poco.ValueConstraint != null && poco.ValueConstraint.Id != dto.ValueConstraint)
            {
                identifiersOfObjectsToDelete.Add(poco.ValueConstraint.Id);
                poco.ValueConstraint = null;
            }

            poco.ValueRangeText = dto.ValueRangeText;

            var valueTypeInstancesToDelete = poco.ValueTypeInstances.Select(x => x.Id).Except(dto.ValueTypeInstances);
            identifiersOfObjectsToDelete.AddRange(valueTypeInstancesToDelete);
            foreach (var identifier in valueTypeInstancesToDelete)
            {
                var valueTypeInstance = poco.ValueTypeInstances.Single(x => x.Id == identifier);
                poco.ValueTypeInstances.Remove(valueTypeInstance);
            }

            poco.ValueTypeValueRangeText = dto.ValueTypeValueRangeText;

            return identifiersOfObjectsToDelete;
        }

        /// <summary>
        /// Updates the Reference properties of the <see cref="EntityType"/> using the data (identifiers) encapsulated in the DTO
        /// and the provided cache to find the referenced object.
        /// </summary>
        /// <param name="poco">
        /// The <see cref="EntityType"/> that is to be updated
        /// </param>
        /// <param name="dto">
        /// The DTO that is used to update the <see cref="EntityType"/> with
        /// </param>
        /// <param name="cache">
        /// The <see cref="ConcurrentDictionary{String, Lazy{Kalliope.Core.ModelThing}}"/> that contains the
        /// <see cref="ModelThing"/>s that are know and cached.
        /// </param>
        /// <exception cref="ArgumentNullException"></exception>
        public static void UpdateReferenceProperties(this Kalliope.Core.EntityType poco, Kalliope.DTO.EntityType dto, ConcurrentDictionary<string, Lazy<Kalliope.Core.ModelThing>> cache)
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

            var abbreviationsToAdd = dto.Abbreviations.Except(poco.Abbreviations.Select(x => x.Id));
            foreach (var identifier in abbreviationsToAdd)
            {
                if (cache.TryGetValue(identifier, out lazyPoco))
                {
                    var nameAlias = (NameAlias)lazyPoco.Value;
                    poco.Abbreviations.Add(nameAlias);
                }
            }

            var associatedModelErrorsToAdd = dto.AssociatedModelErrors.Except(poco.AssociatedModelErrors.Select(x => x.Id));
            foreach (var identifier in associatedModelErrorsToAdd)
            {
                if (cache.TryGetValue(identifier, out lazyPoco))
                {
                    var modelError = (ModelError)lazyPoco.Value;
                    poco.AssociatedModelErrors.Add(modelError);
                }
            }

            if (poco.Cardinality == null && !string.IsNullOrEmpty(dto.Cardinality) && cache.TryGetValue(dto.Cardinality, out lazyPoco))
            {
                poco.Cardinality = (ObjectTypeCardinalityConstraint)lazyPoco.Value;
            }

            if (poco.CompatibleSupertypesError == null && !string.IsNullOrEmpty(dto.CompatibleSupertypesError) && cache.TryGetValue(dto.CompatibleSupertypesError, out lazyPoco))
            {
                poco.CompatibleSupertypesError = (CompatibleSupertypesError)lazyPoco.Value;
            }

            if (poco.ConceptualDataType == null && !string.IsNullOrEmpty(dto.ConceptualDataType) && cache.TryGetValue(dto.ConceptualDataType, out lazyPoco))
            {
                poco.ConceptualDataType = (DataTypeRef)lazyPoco.Value;
            }

            if (poco.DataType == null && !string.IsNullOrEmpty(dto.DataType) && cache.TryGetValue(dto.DataType, out lazyPoco))
            {
                poco.DataType = (DataType)lazyPoco.Value;
            }

            if (poco.Definition == null && !string.IsNullOrEmpty(dto.Definition) && cache.TryGetValue(dto.Definition, out lazyPoco))
            {
                poco.Definition = (Definition)lazyPoco.Value;
            }

            if (poco.DerivationExpression == null && !string.IsNullOrEmpty(dto.DerivationExpression) && cache.TryGetValue(dto.DerivationExpression, out lazyPoco))
            {
                poco.DerivationExpression = (SubtypeDerivationExpression)lazyPoco.Value;
            }

            if (poco.DerivationRule == null && !string.IsNullOrEmpty(dto.DerivationRule) && cache.TryGetValue(dto.DerivationRule, out lazyPoco))
            {
                poco.DerivationRule = (SubtypeDerivationRule)lazyPoco.Value;
            }

            if (poco.DuplicateNameError == null && !string.IsNullOrEmpty(dto.DuplicateNameError) && cache.TryGetValue(dto.DuplicateNameError, out lazyPoco))
            {
                poco.DuplicateNameError = (ObjectTypeDuplicateNameError)lazyPoco.Value;
            }

            var entityTypeInstancesToAdd = dto.EntityTypeInstances.Except(poco.EntityTypeInstances.Select(x => x.Id));
            foreach (var identifier in entityTypeInstancesToAdd)
            {
                if (cache.TryGetValue(identifier, out lazyPoco))
                {
                    var entityTypeInstance = (EntityTypeInstance)lazyPoco.Value;
                    poco.EntityTypeInstances.Add(entityTypeInstance);
                }
            }

            var entityTypeSubtypeInstancesToAdd = dto.EntityTypeSubtypeInstances.Except(poco.EntityTypeSubtypeInstances.Select(x => x.Id));
            foreach (var identifier in entityTypeSubtypeInstancesToAdd)
            {
                if (cache.TryGetValue(identifier, out lazyPoco))
                {
                    var entityTypeSubtypeInstance = (EntityTypeSubtypeInstance)lazyPoco.Value;
                    poco.EntityTypeSubtypeInstances.Add(entityTypeSubtypeInstance);
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

            if (poco.FactType == null && !string.IsNullOrEmpty(dto.FactType) && cache.TryGetValue(dto.FactType, out lazyPoco))
            {
                poco.FactType = (FactType)lazyPoco.Value;
            }

            if (poco.ImpliedMandatoryConstraint == null && !string.IsNullOrEmpty(dto.ImpliedMandatoryConstraint) && cache.TryGetValue(dto.ImpliedMandatoryConstraint, out lazyPoco))
            {
                poco.ImpliedMandatoryConstraint = (MandatoryConstraint)lazyPoco.Value;
            }

            if (poco.InherentMandatoryConstraint == null && !string.IsNullOrEmpty(dto.InherentMandatoryConstraint) && cache.TryGetValue(dto.InherentMandatoryConstraint, out lazyPoco))
            {
                poco.InherentMandatoryConstraint = (MandatoryConstraint)lazyPoco.Value;
            }

            if (poco.Note == null && !string.IsNullOrEmpty(dto.Note) && cache.TryGetValue(dto.Note, out lazyPoco))
            {
                poco.Note = (Note)lazyPoco.Value;
            }

            var objectTypeInstancesToAdd = dto.ObjectTypeInstances.Except(poco.ObjectTypeInstances.Select(x => x.Id));
            foreach (var identifier in objectTypeInstancesToAdd)
            {
                if (cache.TryGetValue(identifier, out lazyPoco))
                {
                    var objectTypeInstance = (ObjectTypeInstance)lazyPoco.Value;
                    poco.ObjectTypeInstances.Add(objectTypeInstance);
                }
            }

            var playedRolesToAdd = dto.PlayedRoles.Except(poco.PlayedRoles.Select(x => x.Id));
            foreach (var identifier in playedRolesToAdd)
            {
                if (cache.TryGetValue(identifier, out lazyPoco))
                {
                    var role = (Role)lazyPoco.Value;
                    poco.PlayedRoles.Add(role);
                }
            }

            if (poco.PreferredIdentifier == null && !string.IsNullOrEmpty(dto.PreferredIdentifier) && cache.TryGetValue(dto.PreferredIdentifier, out lazyPoco))
            {
                poco.PreferredIdentifier = (UniquenessConstraint)lazyPoco.Value;
            }

            if (poco.PreferredIdentifierRequiresMandatoryError == null && !string.IsNullOrEmpty(dto.PreferredIdentifierRequiresMandatoryError) && cache.TryGetValue(dto.PreferredIdentifierRequiresMandatoryError, out lazyPoco))
            {
                poco.PreferredIdentifierRequiresMandatoryError = (PreferredIdentifierRequiresMandatoryError)lazyPoco.Value;
            }

            if (poco.ReferenceSchemeError == null && !string.IsNullOrEmpty(dto.ReferenceSchemeError) && cache.TryGetValue(dto.ReferenceSchemeError, out lazyPoco))
            {
                poco.ReferenceSchemeError = (EntityTypeRequiresReferenceSchemeError)lazyPoco.Value;
            }

            if (poco.ValueConstraint == null && !string.IsNullOrEmpty(dto.ValueConstraint) && cache.TryGetValue(dto.ValueConstraint, out lazyPoco))
            {
                poco.ValueConstraint = (ValueTypeValueConstraint)lazyPoco.Value;
            }

            var valueTypeInstancesToAdd = dto.ValueTypeInstances.Except(poco.ValueTypeInstances.Select(x => x.Id));
            foreach (var identifier in valueTypeInstancesToAdd)
            {
                if (cache.TryGetValue(identifier, out lazyPoco))
                {
                    var valueTypeInstance = (ValueTypeInstance)lazyPoco.Value;
                    poco.ValueTypeInstances.Add(valueTypeInstance);
                }
            }
        }
    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
