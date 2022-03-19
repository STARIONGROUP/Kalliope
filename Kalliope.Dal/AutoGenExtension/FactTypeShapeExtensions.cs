// -------------------------------------------------------------------------------------------------
// <copyright file="FactTypeShapeExtensions.cs" company="RHEA System S.A.">
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
    /// A static class that provides extension methods for the <see cref="FactTypeShape"/> class
    /// </summary>
    public static class FactTypeShapeExtensions
    {
        /// <summary>
        /// Updates the value properties of the <see cref="FactTypeShape"/> by setting the value equal to that of the dto
        /// Removes deleted objects from the reference properties and returns the unique identifiers
        /// of the objects that have been removed from <see cref="AggregationKind.Composite"/> properties
        /// </summary>
        /// <param name="poco">
        /// The <see cref="FactTypeShape"/> that is to be updated
        /// </param>
        /// <param name="dto">
        /// The DTO that is used to update the <see cref="FactTypeShape"/> with
        /// </param>
        /// <returns>
        /// The unique identifiers of the objects that have been removed from <see cref="AggregationKind.Composite"/> properties
        /// </returns>
        /// <exception cref="ArgumentNullException">
        /// Thrown when the <paramref name="poco"/> or <paramref name="dto"/> is null
        /// </exception>
        public static IEnumerable<string> UpdateValueAndRemoveDeletedReferenceProperties(this Kalliope.Diagrams.FactTypeShape poco, Kalliope.DTO.FactTypeShape dto)
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

            poco.AbsoluteBounds = dto.AbsoluteBounds;

            var cardinalityConstraintShapesToDelete = poco.CardinalityConstraintShapes.Select(x => x.Id).Except(dto.CardinalityConstraintShapes);
            identifiersOfObjectsToDelete.AddRange(cardinalityConstraintShapesToDelete);
            foreach (var identifier in cardinalityConstraintShapesToDelete)
            {
                var cardinalityConstraintShape = poco.CardinalityConstraintShapes.Single(x => x.Id == identifier);
                poco.CardinalityConstraintShapes.Remove(cardinalityConstraintShape);
            }

            poco.ConstraintDisplayPosition = dto.ConstraintDisplayPosition;

            poco.DisplayAsObjectType = dto.DisplayAsObjectType;

            poco.DisplayOrientation = dto.DisplayOrientation;

            poco.DisplayRelatedTypes = dto.DisplayRelatedTypes;

            poco.DisplayRoleNames = dto.DisplayRoleNames;

            poco.ExpandRefMode = dto.ExpandRefMode;

            poco.IsExpanded = dto.IsExpanded;

            var objectifiedFactTypeNameShapesToDelete = poco.ObjectifiedFactTypeNameShapes.Select(x => x.Id).Except(dto.ObjectifiedFactTypeNameShapes);
            identifiersOfObjectsToDelete.AddRange(objectifiedFactTypeNameShapesToDelete);
            foreach (var identifier in objectifiedFactTypeNameShapesToDelete)
            {
                var objectTypeShape = poco.ObjectifiedFactTypeNameShapes.Single(x => x.Id == identifier);
                poco.ObjectifiedFactTypeNameShapes.Remove(objectTypeShape);
            }

            var readingShapesToDelete = poco.ReadingShapes.Select(x => x.Id).Except(dto.ReadingShapes);
            identifiersOfObjectsToDelete.AddRange(readingShapesToDelete);
            foreach (var identifier in readingShapesToDelete)
            {
                var readingShape = poco.ReadingShapes.Single(x => x.Id == identifier);
                poco.ReadingShapes.Remove(readingShape);
            }

            var roleDisplayOrderToDelete = poco.RoleDisplayOrder.Select(x => x.Id).Except(dto.RoleDisplayOrder);
            foreach (var identifier in roleDisplayOrderToDelete)
            {
                var roleBase = poco.RoleDisplayOrder.Single(x => x.Id == identifier);
                poco.RoleDisplayOrder.Remove(roleBase);
            }

            var roleNameShapesToDelete = poco.RoleNameShapes.Select(x => x.Id).Except(dto.RoleNameShapes);
            identifiersOfObjectsToDelete.AddRange(roleNameShapesToDelete);
            foreach (var identifier in roleNameShapesToDelete)
            {
                var roleNameShape = poco.RoleNameShapes.Single(x => x.Id == identifier);
                poco.RoleNameShapes.Remove(roleNameShape);
            }

            if (poco.Subject != null && poco.Subject.Id != dto.Subject)
            {
                poco.Subject = null;
            }

            var valueConstraintShapesToDelete = poco.ValueConstraintShapes.Select(x => x.Id).Except(dto.ValueConstraintShapes);
            identifiersOfObjectsToDelete.AddRange(valueConstraintShapesToDelete);
            foreach (var identifier in valueConstraintShapesToDelete)
            {
                var valueConstraintShape = poco.ValueConstraintShapes.Single(x => x.Id == identifier);
                poco.ValueConstraintShapes.Remove(valueConstraintShape);
            }

            return identifiersOfObjectsToDelete;
        }

        /// <summary>
        /// Updates the Reference properties of the <see cref="FactTypeShape"/> using the data (identifiers) encapsulated in the DTO
        /// and the provided cache to find the referenced object.
        /// </summary>
        /// <param name="poco">
        /// The <see cref="FactTypeShape"/> that is to be updated
        /// </param>
        /// <param name="dto">
        /// The DTO that is used to update the <see cref="FactTypeShape"/> with
        /// </param>
        /// <param name="cache">
        /// The <see cref="ConcurrentDictionary{String, Lazy{Kalliope.Core.ModelThing}}"/> that contains the
        /// <see cref="ModelThing"/>s that are know and cached.
        /// </param>
        /// <exception cref="ArgumentNullException"></exception>
        public static void UpdateReferenceProperties(this Kalliope.Diagrams.FactTypeShape poco, Kalliope.DTO.FactTypeShape dto, ConcurrentDictionary<string, Lazy<Kalliope.Core.ModelThing>> cache)
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

            var cardinalityConstraintShapesToAdd = dto.CardinalityConstraintShapes.Except(poco.CardinalityConstraintShapes.Select(x => x.Id));
            foreach (var identifier in cardinalityConstraintShapesToAdd)
            {
                if (cache.TryGetValue(identifier, out lazyPoco))
                {
                    var cardinalityConstraintShape = (CardinalityConstraintShape)lazyPoco.Value;
                    poco.CardinalityConstraintShapes.Add(cardinalityConstraintShape);
                }
            }

            var objectifiedFactTypeNameShapesToAdd = dto.ObjectifiedFactTypeNameShapes.Except(poco.ObjectifiedFactTypeNameShapes.Select(x => x.Id));
            foreach (var identifier in objectifiedFactTypeNameShapesToAdd)
            {
                if (cache.TryGetValue(identifier, out lazyPoco))
                {
                    var objectTypeShape = (ObjectTypeShape)lazyPoco.Value;
                    poco.ObjectifiedFactTypeNameShapes.Add(objectTypeShape);
                }
            }

            var readingShapesToAdd = dto.ReadingShapes.Except(poco.ReadingShapes.Select(x => x.Id));
            foreach (var identifier in readingShapesToAdd)
            {
                if (cache.TryGetValue(identifier, out lazyPoco))
                {
                    var readingShape = (ReadingShape)lazyPoco.Value;
                    poco.ReadingShapes.Add(readingShape);
                }
            }

            var roleDisplayOrderToAdd = dto.RoleDisplayOrder.Except(poco.RoleDisplayOrder.Select(x => x.Id));
            foreach (var identifier in roleDisplayOrderToAdd)
            {
                if (cache.TryGetValue(identifier, out lazyPoco))
                {
                    var roleBase = (RoleBase)lazyPoco.Value;
                    poco.RoleDisplayOrder.Add(roleBase);
                }
            }

            var roleNameShapesToAdd = dto.RoleNameShapes.Except(poco.RoleNameShapes.Select(x => x.Id));
            foreach (var identifier in roleNameShapesToAdd)
            {
                if (cache.TryGetValue(identifier, out lazyPoco))
                {
                    var roleNameShape = (RoleNameShape)lazyPoco.Value;
                    poco.RoleNameShapes.Add(roleNameShape);
                }
            }

            if (poco.Subject == null && !string.IsNullOrEmpty(dto.Subject))
            {
                if (cache.TryGetValue(dto.Subject, out lazyPoco))
                {
                    poco.Subject = (FactType)lazyPoco.Value;
                }
            }

            var valueConstraintShapesToAdd = dto.ValueConstraintShapes.Except(poco.ValueConstraintShapes.Select(x => x.Id));
            foreach (var identifier in valueConstraintShapesToAdd)
            {
                if (cache.TryGetValue(identifier, out lazyPoco))
                {
                    var valueConstraintShape = (ValueConstraintShape)lazyPoco.Value;
                    poco.ValueConstraintShapes.Add(valueConstraintShape);
                }
            }
        }
    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
