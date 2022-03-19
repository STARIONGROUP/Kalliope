// -------------------------------------------------------------------------------------------------
// <copyright file="OrmDiagramExtensions.cs" company="RHEA System S.A.">
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
    /// A static class that provides extension methods for the <see cref="OrmDiagram"/> class
    /// </summary>
    public static class OrmDiagramExtensions
    {
        /// <summary>
        /// Updates the value properties of the <see cref="OrmDiagram"/> by setting the value equal to that of the dto
        /// Removes deleted objects from the reference properties and returns the unique identifiers
        /// of the objects that have been removed from <see cref="AggregationKind.Composite"/> properties
        /// </summary>
        /// <param name="poco">
        /// The <see cref="OrmDiagram"/> that is to be updated
        /// </param>
        /// <param name="dto">
        /// The DTO that is used to update the <see cref="OrmDiagram"/> with
        /// </param>
        /// <returns>
        /// The unique identifiers of the objects that have been removed from <see cref="AggregationKind.Composite"/> properties
        /// </returns>
        /// <exception cref="ArgumentNullException">
        /// Thrown when the <paramref name="poco"/> or <paramref name="dto"/> is null
        /// </exception>
        public static IEnumerable<string> UpdateValueAndRemoveDeletedReferenceProperties(this Kalliope.Diagrams.OrmDiagram poco, Kalliope.DTO.OrmDiagram dto)
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

            poco.AutoPopulateShapes = dto.AutoPopulateShapes;

            poco.BaseFontName = dto.BaseFontName;

            poco.BaseFontSize = dto.BaseFontSize;

            var externalConstraintShapesToDelete = poco.ExternalConstraintShapes.Select(x => x.Id).Except(dto.ExternalConstraintShapes);
            identifiersOfObjectsToDelete.AddRange(externalConstraintShapesToDelete);
            foreach (var identifier in externalConstraintShapesToDelete)
            {
                var externalConstraintShape = poco.ExternalConstraintShapes.Single(x => x.Id == identifier);
                poco.ExternalConstraintShapes.Remove(externalConstraintShape);
            }

            var factTypeShapesToDelete = poco.FactTypeShapes.Select(x => x.Id).Except(dto.FactTypeShapes);
            identifiersOfObjectsToDelete.AddRange(factTypeShapesToDelete);
            foreach (var identifier in factTypeShapesToDelete)
            {
                var factTypeShape = poco.FactTypeShapes.Single(x => x.Id == identifier);
                poco.FactTypeShapes.Remove(factTypeShape);
            }

            var frequencyConstraintShapesToDelete = poco.FrequencyConstraintShapes.Select(x => x.Id).Except(dto.FrequencyConstraintShapes);
            identifiersOfObjectsToDelete.AddRange(frequencyConstraintShapesToDelete);
            foreach (var identifier in frequencyConstraintShapesToDelete)
            {
                var frequencyConstraintShape = poco.FrequencyConstraintShapes.Single(x => x.Id == identifier);
                poco.FrequencyConstraintShapes.Remove(frequencyConstraintShape);
            }

            poco.IsCompleteView = dto.IsCompleteView;

            var modelNoteShapesToDelete = poco.ModelNoteShapes.Select(x => x.Id).Except(dto.ModelNoteShapes);
            identifiersOfObjectsToDelete.AddRange(modelNoteShapesToDelete);
            foreach (var identifier in modelNoteShapesToDelete)
            {
                var modelNoteShape = poco.ModelNoteShapes.Single(x => x.Id == identifier);
                poco.ModelNoteShapes.Remove(modelNoteShape);
            }

            poco.Name = dto.Name;

            var objectTypeShapesToDelete = poco.ObjectTypeShapes.Select(x => x.Id).Except(dto.ObjectTypeShapes);
            identifiersOfObjectsToDelete.AddRange(objectTypeShapesToDelete);
            foreach (var identifier in objectTypeShapesToDelete)
            {
                var objectTypeShape = poco.ObjectTypeShapes.Single(x => x.Id == identifier);
                poco.ObjectTypeShapes.Remove(objectTypeShape);
            }

            var ringConstraintShapesToDelete = poco.RingConstraintShapes.Select(x => x.Id).Except(dto.RingConstraintShapes);
            identifiersOfObjectsToDelete.AddRange(ringConstraintShapesToDelete);
            foreach (var identifier in ringConstraintShapesToDelete)
            {
                var ringConstraintShape = poco.RingConstraintShapes.Single(x => x.Id == identifier);
                poco.RingConstraintShapes.Remove(ringConstraintShape);
            }

            if (poco.Subject != null && poco.Subject.Id != dto.Subject)
            {
                poco.Subject = null;
            }

            var valueComparisonConstraintShapesToDelete = poco.ValueComparisonConstraintShapes.Select(x => x.Id).Except(dto.ValueComparisonConstraintShapes);
            identifiersOfObjectsToDelete.AddRange(valueComparisonConstraintShapesToDelete);
            foreach (var identifier in valueComparisonConstraintShapesToDelete)
            {
                var valueComparisonConstraintShape = poco.ValueComparisonConstraintShapes.Single(x => x.Id == identifier);
                poco.ValueComparisonConstraintShapes.Remove(valueComparisonConstraintShape);
            }

            return identifiersOfObjectsToDelete;
        }

        /// <summary>
        /// Updates the Reference properties of the <see cref="OrmDiagram"/> using the data (identifiers) encapsulated in the DTO
        /// and the provided cache to find the referenced object.
        /// </summary>
        /// <param name="poco">
        /// The <see cref="OrmDiagram"/> that is to be updated
        /// </param>
        /// <param name="dto">
        /// The DTO that is used to update the <see cref="OrmDiagram"/> with
        /// </param>
        /// <param name="cache">
        /// The <see cref="ConcurrentDictionary{String, Lazy{Kalliope.Core.ModelThing}}"/> that contains the
        /// <see cref="ModelThing"/>s that are know and cached.
        /// </param>
        /// <exception cref="ArgumentNullException"></exception>
        public static void UpdateReferenceProperties(this Kalliope.Diagrams.OrmDiagram poco, Kalliope.DTO.OrmDiagram dto, ConcurrentDictionary<string, Lazy<Kalliope.Core.ModelThing>> cache)
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

            var externalConstraintShapesToAdd = dto.ExternalConstraintShapes.Except(poco.ExternalConstraintShapes.Select(x => x.Id));
            foreach (var identifier in externalConstraintShapesToAdd)
            {
                if (cache.TryGetValue(identifier, out lazyPoco))
                {
                    var externalConstraintShape = (ExternalConstraintShape)lazyPoco.Value;
                    poco.ExternalConstraintShapes.Add(externalConstraintShape);
                }
            }

            var factTypeShapesToAdd = dto.FactTypeShapes.Except(poco.FactTypeShapes.Select(x => x.Id));
            foreach (var identifier in factTypeShapesToAdd)
            {
                if (cache.TryGetValue(identifier, out lazyPoco))
                {
                    var factTypeShape = (FactTypeShape)lazyPoco.Value;
                    poco.FactTypeShapes.Add(factTypeShape);
                }
            }

            var frequencyConstraintShapesToAdd = dto.FrequencyConstraintShapes.Except(poco.FrequencyConstraintShapes.Select(x => x.Id));
            foreach (var identifier in frequencyConstraintShapesToAdd)
            {
                if (cache.TryGetValue(identifier, out lazyPoco))
                {
                    var frequencyConstraintShape = (FrequencyConstraintShape)lazyPoco.Value;
                    poco.FrequencyConstraintShapes.Add(frequencyConstraintShape);
                }
            }

            var modelNoteShapesToAdd = dto.ModelNoteShapes.Except(poco.ModelNoteShapes.Select(x => x.Id));
            foreach (var identifier in modelNoteShapesToAdd)
            {
                if (cache.TryGetValue(identifier, out lazyPoco))
                {
                    var modelNoteShape = (ModelNoteShape)lazyPoco.Value;
                    poco.ModelNoteShapes.Add(modelNoteShape);
                }
            }

            var objectTypeShapesToAdd = dto.ObjectTypeShapes.Except(poco.ObjectTypeShapes.Select(x => x.Id));
            foreach (var identifier in objectTypeShapesToAdd)
            {
                if (cache.TryGetValue(identifier, out lazyPoco))
                {
                    var objectTypeShape = (ObjectTypeShape)lazyPoco.Value;
                    poco.ObjectTypeShapes.Add(objectTypeShape);
                }
            }

            var ringConstraintShapesToAdd = dto.RingConstraintShapes.Except(poco.RingConstraintShapes.Select(x => x.Id));
            foreach (var identifier in ringConstraintShapesToAdd)
            {
                if (cache.TryGetValue(identifier, out lazyPoco))
                {
                    var ringConstraintShape = (RingConstraintShape)lazyPoco.Value;
                    poco.RingConstraintShapes.Add(ringConstraintShape);
                }
            }

            if (poco.Subject == null && !string.IsNullOrEmpty(dto.Subject) && cache.TryGetValue(dto.Subject, out lazyPoco))
            {
                poco.Subject = (OrmModel)lazyPoco.Value;
            }

            var valueComparisonConstraintShapesToAdd = dto.ValueComparisonConstraintShapes.Except(poco.ValueComparisonConstraintShapes.Select(x => x.Id));
            foreach (var identifier in valueComparisonConstraintShapesToAdd)
            {
                if (cache.TryGetValue(identifier, out lazyPoco))
                {
                    var valueComparisonConstraintShape = (ValueComparisonConstraintShape)lazyPoco.Value;
                    poco.ValueComparisonConstraintShapes.Add(valueComparisonConstraintShape);
                }
            }
        }
    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
