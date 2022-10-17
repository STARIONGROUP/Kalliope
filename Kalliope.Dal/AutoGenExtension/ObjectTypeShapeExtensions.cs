// -------------------------------------------------------------------------------------------------
// <copyright file="ObjectTypeShapeExtensions.cs" company="RHEA System S.A.">
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
    /// A static class that provides extension methods for the <see cref="ObjectTypeShape"/> class
    /// </summary>
    public static class ObjectTypeShapeExtensions
    {
        /// <summary>
        /// Updates the value properties of the <see cref="ObjectTypeShape"/> by setting the value equal to that of the dto
        /// Removes deleted objects from the reference properties and returns the unique identifiers
        /// of the objects that have been removed from <see cref="AggregationKind.Composite"/> properties
        /// </summary>
        /// <param name="poco">
        /// The <see cref="ObjectTypeShape"/> that is to be updated
        /// </param>
        /// <param name="dto">
        /// The DTO that is used to update the <see cref="ObjectTypeShape"/> with
        /// </param>
        /// <returns>
        /// The unique identifiers of the objects that have been removed from <see cref="AggregationKind.Composite"/> properties
        /// </returns>
        /// <exception cref="ArgumentNullException">
        /// Thrown when the <paramref name="poco"/> or <paramref name="dto"/> is null
        /// </exception>
        public static IEnumerable<string> UpdateValueAndRemoveDeletedReferenceProperties(this Kalliope.Diagrams.ObjectTypeShape poco, Kalliope.DTO.ObjectTypeShape dto)
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

            poco.DisplayRelatedTypes = dto.DisplayRelatedTypes;

            poco.ExpandRefMode = dto.ExpandRefMode;

            poco.IsExpanded = dto.IsExpanded;

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
        /// Updates the Reference properties of the <see cref="ObjectTypeShape"/> using the data (identifiers) encapsulated in the DTO
        /// and the provided cache to find the referenced object.
        /// </summary>
        /// <param name="poco">
        /// The <see cref="ObjectTypeShape"/> that is to be updated
        /// </param>
        /// <param name="dto">
        /// The DTO that is used to update the <see cref="ObjectTypeShape"/> with
        /// </param>
        /// <param name="cache">
        /// The <see cref="ConcurrentDictionary{String, Lazy{Kalliope.Core.ModelThing}}"/> that contains the
        /// <see cref="ModelThing"/>s that are know and cached.
        /// </param>
        /// <exception cref="ArgumentNullException"></exception>
        public static void UpdateReferenceProperties(this Kalliope.Diagrams.ObjectTypeShape poco, Kalliope.DTO.ObjectTypeShape dto, ConcurrentDictionary<string, Lazy<Kalliope.Core.ModelThing>> cache)
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

            if (poco.Subject == null && !string.IsNullOrEmpty(dto.Subject) && cache.TryGetValue(dto.Subject, out lazyPoco))
            {
                poco.Subject = (ObjectType)lazyPoco.Value;
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
