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
    using System.Collections.Generic;
    using System.Linq;

    using Kalliope.Common;
    using Kalliope.Core;

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
 
            if (poco.NestedPredicate != null && poco.NestedPredicate.Id != dto.NestedPredicate)
            {
                identifiersOfObjectsToDelete.Add(poco.NestedPredicate.Id);
                poco.NestedPredicate = null;
            }
 
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
    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
