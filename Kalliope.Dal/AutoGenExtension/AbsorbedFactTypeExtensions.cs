// -------------------------------------------------------------------------------------------------
// <copyright file="AbsorbedFactTypeExtensions.cs" company="Starion Group S.A.">
//
//   Copyright 2022-2024 Starion Group S.A.
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
    /// A static class that provides extension methods for the <see cref="AbsorbedFactType"/> class
    /// </summary>
    public static class AbsorbedFactTypeExtensions
    {
        /// <summary>
        /// Updates the value properties of the <see cref="AbsorbedFactType"/> by setting the value equal to that of the dto
        /// Removes deleted objects from the reference properties and returns the unique identifiers
        /// of the objects that have been removed from <see cref="AggregationKind.Composite"/> properties
        /// </summary>
        /// <param name="poco">
        /// The <see cref="AbsorbedFactType"/> that is to be updated
        /// </param>
        /// <param name="dto">
        /// The DTO that is used to update the <see cref="AbsorbedFactType"/> with
        /// </param>
        /// <returns>
        /// The unique identifiers of the objects that have been removed from <see cref="AggregationKind.Composite"/> properties
        /// </returns>
        /// <exception cref="ArgumentNullException">
        /// Thrown when the <paramref name="poco"/> or <paramref name="dto"/> is null
        /// </exception>
        public static IEnumerable<string> UpdateValueAndRemoveDeletedReferenceProperties(this Kalliope.Absorption.AbsorbedFactType poco, Kalliope.DTO.AbsorbedFactType dto)
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

            poco.Absorbed = dto.Absorbed;

            var absorbedRolesToDelete = poco.AbsorbedRoles.Select(x => x.Id).Except(dto.AbsorbedRoles);
            identifiersOfObjectsToDelete.AddRange(absorbedRolesToDelete);
            foreach (var identifier in absorbedRolesToDelete)
            {
                var absorbedRole = poco.AbsorbedRoles.Single(x => x.Id == identifier);
                poco.AbsorbedRoles.Remove(absorbedRole);
            }

            poco.AbsorbedUnary = dto.AbsorbedUnary;

            poco.Functional = dto.Functional;

            poco.Nested = dto.Nested;

            var possibleChildRolesToDelete = poco.PossibleChildRoles.Select(x => x.Id).Except(dto.PossibleChildRoles);
            identifiersOfObjectsToDelete.AddRange(possibleChildRolesToDelete);
            foreach (var identifier in possibleChildRolesToDelete)
            {
                var childRole = poco.PossibleChildRoles.Single(x => x.Id == identifier);
                poco.PossibleChildRoles.Remove(childRole);
            }

            poco.TopLevel = dto.TopLevel;

            poco.XmlName = dto.XmlName;

            return identifiersOfObjectsToDelete;
        }

        /// <summary>
        /// Updates the Reference properties of the <see cref="AbsorbedFactType"/> using the data (identifiers) encapsulated in the DTO
        /// and the provided cache to find the referenced object.
        /// </summary>
        /// <param name="poco">
        /// The <see cref="AbsorbedFactType"/> that is to be updated
        /// </param>
        /// <param name="dto">
        /// The DTO that is used to update the <see cref="AbsorbedFactType"/> with
        /// </param>
        /// <param name="cache">
        /// The <see cref="ConcurrentDictionary{String, Lazy{Kalliope.Core.ModelThing}}"/> that contains the
        /// <see cref="ModelThing"/>s that are know and cached.
        /// </param>
        /// <exception cref="ArgumentNullException"></exception>
        public static void UpdateReferenceProperties(this Kalliope.Absorption.AbsorbedFactType poco, Kalliope.DTO.AbsorbedFactType dto, ConcurrentDictionary<string, Lazy<Kalliope.Core.ModelThing>> cache)
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

            var absorbedRolesToAdd = dto.AbsorbedRoles.Except(poco.AbsorbedRoles.Select(x => x.Id));
            foreach (var identifier in absorbedRolesToAdd)
            {
                if (cache.TryGetValue(identifier, out lazyPoco))
                {
                    var absorbedRole = (AbsorbedRole)lazyPoco.Value;
                    poco.AbsorbedRoles.Add(absorbedRole);
                }
            }

            var possibleChildRolesToAdd = dto.PossibleChildRoles.Except(poco.PossibleChildRoles.Select(x => x.Id));
            foreach (var identifier in possibleChildRolesToAdd)
            {
                if (cache.TryGetValue(identifier, out lazyPoco))
                {
                    var childRole = (ChildRole)lazyPoco.Value;
                    poco.PossibleChildRoles.Add(childRole);
                }
            }
        }
    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
