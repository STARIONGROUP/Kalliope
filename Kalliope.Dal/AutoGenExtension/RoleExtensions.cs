// -------------------------------------------------------------------------------------------------
// <copyright file="RoleExtensions.cs" company="RHEA System S.A.">
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
    /// A static class that provides extension methods for the <see cref="Role"/> class
    /// </summary>
    public static class RoleExtensions
    {
        /// <summary>
        /// Updates the value properties of the <see cref="Role"/> by setting the value equal to that of the dto
        /// Removes deleted objects from the reference properties and returns the unique identifiers
        /// of the objects that have been removed from <see cref="AggregationKind.Composite"/> properties
        /// </summary>
        /// <param name="poco">
        /// The <see cref="Role"/> that is to be updated
        /// </param>
        /// <param name="dto">
        /// The DTO that is used to update the <see cref="Role"/> with
        /// </param>
        /// <returns>
        /// The unique identifiers of the objects that have been removed from <see cref="AggregationKind.Composite"/> properties
        /// </returns>
        /// <exception cref="ArgumentNullException">
        /// Thrown when the <paramref name="poco"/> or <paramref name="dto"/> is null
        /// </exception>
        public static IEnumerable<string> UpdateValueAndRemoveDeletedReferenceProperties(this Kalliope.Core.Role poco, Kalliope.DTO.Role dto)
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

            if (poco.Cardinality != null && poco.Cardinality.Id != dto.Cardinality)
            {
                identifiersOfObjectsToDelete.Add(poco.Cardinality.Id);
                poco.Cardinality = null;
            }

            if (poco.DerivedFromCalculatedValue != null && poco.DerivedFromCalculatedValue.Id != dto.DerivedFromCalculatedValue)
            {
                poco.DerivedFromCalculatedValue = null;
            }

            if (poco.DerivedFromConstant != null && poco.DerivedFromConstant.Id != dto.DerivedFromConstant)
            {
                poco.DerivedFromConstant = null;
            }

            var extensionModelErrorsToDelete = poco.ExtensionModelErrors.Select(x => x.Id).Except(dto.ExtensionModelErrors);
            foreach (var identifier in extensionModelErrorsToDelete)
            {
                var modelError = poco.ExtensionModelErrors.Single(x => x.Id == identifier);
                poco.ExtensionModelErrors.Remove(modelError);
            }

            poco.IsMandatory = dto.IsMandatory;

            poco.MandatoryConstraintModality = dto.MandatoryConstraintModality;

            poco.MandatoryConstraintName = dto.MandatoryConstraintName;

            poco.Multiplicity = dto.Multiplicity;

            poco.ObjectificationOppositeRoleName = dto.ObjectificationOppositeRoleName;

            var objectTypeInstancesToDelete = poco.ObjectTypeInstances.Select(x => x.Id).Except(dto.ObjectTypeInstances);
            foreach (var identifier in objectTypeInstancesToDelete)
            {
                var objectTypeInstance = poco.ObjectTypeInstances.Single(x => x.Id == identifier);
                poco.ObjectTypeInstances.Remove(objectTypeInstance);
            }

            if (poco.RolePlayer != null && poco.RolePlayer.Id != dto.RolePlayer)
            {
                poco.RolePlayer = null;
            }

            if (poco.RolePlayerRequiredError != null && poco.RolePlayerRequiredError.Id != dto.RolePlayerRequiredError)
            {
                identifiersOfObjectsToDelete.Add(poco.RolePlayerRequiredError.Id);
                poco.RolePlayerRequiredError = null;
            }

            if (poco.ValueConstraint != null && poco.ValueConstraint.Id != dto.ValueConstraint)
            {
                identifiersOfObjectsToDelete.Add(poco.ValueConstraint.Id);
                poco.ValueConstraint = null;
            }

            poco.ValueRangeText = dto.ValueRangeText;

            return identifiersOfObjectsToDelete;
        }

        /// <summary>
        /// Updates the Reference properties of the <see cref="Role"/> using the data (identifiers) encapsulated in the DTO
        /// and the provided cache to find the referenced object.
        /// </summary>
        /// <param name="poco">
        /// The <see cref="Role"/> that is to be updated
        /// </param>
        /// <param name="dto">
        /// The DTO that is used to update the <see cref="Role"/> with
        /// </param>
        /// <param name="cache">
        /// The <see cref="ConcurrentDictionary{String, Lazy{Kalliope.Core.ModelThing}}"/> that contains the
        /// <see cref="ModelThing"/>s that are know and cached.
        /// </param>
        /// <exception cref="ArgumentNullException"></exception>
        public static void UpdateReferenceProperties(this Kalliope.Core.Role poco, Kalliope.DTO.Role dto, ConcurrentDictionary<string, Lazy<Kalliope.Core.ModelThing>> cache)
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

            if (poco.Cardinality == null && !string.IsNullOrEmpty(dto.Cardinality) && cache.TryGetValue(dto.Cardinality, out lazyPoco))
            {
                poco.Cardinality = (UnaryRoleCardinalityConstraint)lazyPoco.Value;
            }

            if (poco.DerivedFromCalculatedValue == null && !string.IsNullOrEmpty(dto.DerivedFromCalculatedValue) && cache.TryGetValue(dto.DerivedFromCalculatedValue, out lazyPoco))
            {
                poco.DerivedFromCalculatedValue = (CalculatedPathValue)lazyPoco.Value;
            }

            if (poco.DerivedFromConstant == null && !string.IsNullOrEmpty(dto.DerivedFromConstant) && cache.TryGetValue(dto.DerivedFromConstant, out lazyPoco))
            {
                poco.DerivedFromConstant = (PathConstant)lazyPoco.Value;
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

            var objectTypeInstancesToAdd = dto.ObjectTypeInstances.Except(poco.ObjectTypeInstances.Select(x => x.Id));
            foreach (var identifier in objectTypeInstancesToAdd)
            {
                if (cache.TryGetValue(identifier, out lazyPoco))
                {
                    var objectTypeInstance = (ObjectTypeInstance)lazyPoco.Value;
                    poco.ObjectTypeInstances.Add(objectTypeInstance);
                }
            }

            if (poco.RolePlayer == null && !string.IsNullOrEmpty(dto.RolePlayer) && cache.TryGetValue(dto.RolePlayer, out lazyPoco))
            {
                poco.RolePlayer = (ObjectType)lazyPoco.Value;
            }

            if (poco.RolePlayerRequiredError == null && !string.IsNullOrEmpty(dto.RolePlayerRequiredError) && cache.TryGetValue(dto.RolePlayerRequiredError, out lazyPoco))
            {
                poco.RolePlayerRequiredError = (RolePlayerRequiredError)lazyPoco.Value;
            }

            if (poco.ValueConstraint == null && !string.IsNullOrEmpty(dto.ValueConstraint) && cache.TryGetValue(dto.ValueConstraint, out lazyPoco))
            {
                poco.ValueConstraint = (RoleValueConstraint)lazyPoco.Value;
            }
        }
    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
