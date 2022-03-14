// -------------------------------------------------------------------------------------------------
// <copyright file="ElementGroupingSetExtensions.cs" company="RHEA System S.A.">
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
    /// A static class that provides extension methods for the <see cref="ElementGroupingSet"/> class
    /// </summary>
    public static class ElementGroupingSetExtensions
    {
        /// <summary>
        /// Updates the value properties of the <see cref="ElementGroupingSet"/> by setting the value equal to that of the dto
        /// Removes deleted objects from the reference properties and returns the unique identifiers
        /// of the objects that have been removed from <see cref="AggregationKind.Composite"/> properties
        /// </summary>
        /// <param name="poco">
        /// The <see cref="ElementGroupingSet"/> that is to be updated
        /// </param>
        /// <param name="dto">
        /// The DTO that is used to update the <see cref="ElementGroupingSet"/> with
        /// </param>
        /// <returns>
        /// The unique identifiers of the objects that have been removed from <see cref="AggregationKind.Composite"/> properties
        /// </returns>
        /// <exception cref="ArgumentNullException">
        /// Thrown when the <paramref name="poco"/> or <paramref name="dto"/> is null
        /// </exception>
        public static IEnumerable<string> UpdateValueAndRemoveDeletedReferenceProperties(this Kalliope.Core.ElementGroupingSet poco, Kalliope.DTO.ElementGroupingSet dto)
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

            var elementsToDelete = poco.Elements.Select(x => x.Id).Except(dto.Elements);
            foreach (var identifier in elementsToDelete)
            {
                var oRMModelElement = poco.Elements.Single(x => x.Id == identifier);
                poco.Elements.Remove(oRMModelElement);
            }

            var groupingsToDelete = poco.Groupings.Select(x => x.Id).Except(dto.Groupings);
            identifiersOfObjectsToDelete.AddRange(groupingsToDelete);
            foreach (var identifier in groupingsToDelete)
            {
                var elementGrouping = poco.Groupings.Single(x => x.Id == identifier);
                poco.Groupings.Remove(elementGrouping);
            }

            if (poco.Model != null && poco.Model.Id != dto.Model)
            {
                poco.Model = null;
            }

            return identifiersOfObjectsToDelete;
        }

        /// <summary>
        /// Updates the Reference properties of the <see cref="ElementGroupingSet"/> using the data (identifiers) encapsulated in the DTO
        /// and the provided cache to find the referenced object.
        /// </summary>
        /// <param name="poco">
        /// The <see cref="ElementGroupingSet"/> that is to be updated
        /// </param>
        /// <param name="dto">
        /// The DTO that is used to update the <see cref="ElementGroupingSet"/> with
        /// </param>
        /// <param name="cache">
        /// The <see cref="ConcurrentDictionary{String, Lazy{Kalliope.Core.ModelThing}}"/> that contains the
        /// <see cref="ModelThing"/>s that are know and cached.
        /// </param>
        /// <exception cref="ArgumentNullException"></exception>
        public static void UpdateReferenceProperties(this Kalliope.Core.ElementGroupingSet poco, Kalliope.DTO.ElementGroupingSet dto, ConcurrentDictionary<string, Lazy<Kalliope.Core.ModelThing>> cache)
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

            var elementsToAdd = dto.Elements.Except(poco.Elements.Select(x => x.Id));
            foreach (var identifier in elementsToAdd)
            {
                if (cache.TryGetValue(identifier, out lazyPoco))
                {
                    var oRMModelElement = (ORMModelElement)lazyPoco.Value;
                    poco.Elements.Add(oRMModelElement);
                }
            }

            var groupingsToAdd = dto.Groupings.Except(poco.Groupings.Select(x => x.Id));
            foreach (var identifier in groupingsToAdd)
            {
                if (cache.TryGetValue(identifier, out lazyPoco))
                {
                    var elementGrouping = (ElementGrouping)lazyPoco.Value;
                    poco.Groupings.Add(elementGrouping);
                }
            }

            if (poco.Model == null)
            {
                if (cache.TryGetValue(dto.Model, out lazyPoco))
                {
                    poco.Model = (ORMModel)lazyPoco.Value;
                }
            }
        }
    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
