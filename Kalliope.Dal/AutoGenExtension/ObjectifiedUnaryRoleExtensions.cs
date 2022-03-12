// -------------------------------------------------------------------------------------------------
// <copyright file="ObjectifiedUnaryRoleExtensions.cs" company="RHEA System S.A.">
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
    /// A static class that provides extension methods for the <see cref="ObjectifiedUnaryRole"/> class
    /// </summary>
    public static class ObjectifiedUnaryRoleExtensions
    {
        /// <summary>
        /// Updates the value properties of the <see cref="ObjectifiedUnaryRole"/> by setting the value equal to that of the dto
        /// Removes deleted objects from the reference properties and returns the unique identifiers
        /// of the objects that have been removed from <see cref="AggregationKind.Composite"/> properties
        /// </summary>
        /// <param name="poco">
        /// The <see cref="ObjectifiedUnaryRole"/> that is to be updated
        /// </param>
        /// <param name="dto">
        /// The DTO that is used to update the <see cref="ObjectifiedUnaryRole"/> with
        /// </param>
        /// <returns>
        /// The unique identifiers of the objects that have been removed from <see cref="AggregationKind.Composite"/> properties
        /// </returns>
        /// <exception cref="ArgumentNullException">
        /// Thrown when the <paramref name="poco"/> or <paramref name="dto"/> is null
        /// </exception>
        public static IEnumerable<string> UpdateValueAndRemoveDeletedReferenceProperties(this Kalliope.Core.ObjectifiedUnaryRole poco, Kalliope.DTO.ObjectifiedUnaryRole dto)
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
 
            if (poco.TargetRole != null && poco.TargetRole.Id != dto.TargetRole)
            {
                poco.TargetRole = null;
            }
 
            if (poco.ValueConstraint != null && poco.ValueConstraint.Id != dto.ValueConstraint)
            {
                identifiersOfObjectsToDelete.Add(poco.ValueConstraint.Id);
                poco.ValueConstraint = null;
            }
 
            poco.ValueRangeText = dto.ValueRangeText;
 

            return identifiersOfObjectsToDelete;
        }
    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
