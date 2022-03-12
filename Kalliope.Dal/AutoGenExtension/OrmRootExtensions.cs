// -------------------------------------------------------------------------------------------------
// <copyright file="OrmRootExtensions.cs" company="RHEA System S.A.">
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
    /// A static class that provides extension methods for the <see cref="OrmRoot"/> class
    /// </summary>
    public static class OrmRootExtensions
    {
        /// <summary>
        /// Updates the value properties of the <see cref="OrmRoot"/> by setting the value equal to that of the dto
        /// Removes deleted objects from the reference properties and returns the unique identifiers
        /// of the objects that have been removed from <see cref="AggregationKind.Composite"/> properties
        /// </summary>
        /// <param name="poco">
        /// The <see cref="OrmRoot"/> that is to be updated
        /// </param>
        /// <param name="dto">
        /// The DTO that is used to update the <see cref="OrmRoot"/> with
        /// </param>
        /// <returns>
        /// The unique identifiers of the objects that have been removed from <see cref="AggregationKind.Composite"/> properties
        /// </returns>
        /// <exception cref="ArgumentNullException">
        /// Thrown when the <paramref name="poco"/> or <paramref name="dto"/> is null
        /// </exception>
        public static IEnumerable<string> UpdateValueAndRemoveDeletedReferenceProperties(this Kalliope.OrmRoot poco, Kalliope.DTO.OrmRoot dto)
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
 
            var diagramsToDelete = poco.Diagrams.Select(x => x.Id).Except(dto.Diagrams);
            identifiersOfObjectsToDelete.AddRange(diagramsToDelete);
            foreach (var identifier in diagramsToDelete)
            {
                var oRMDiagram = poco.Diagrams.Single(x => x.Id == identifier);
                poco.Diagrams.Remove(oRMDiagram);
            }
 
            if (poco.GenerationState != null && poco.GenerationState.Id != dto.GenerationState)
            {
                identifiersOfObjectsToDelete.Add(poco.GenerationState.Id);
                poco.GenerationState = null;
            }
 
            if (poco.Model != null && poco.Model.Id != dto.Model)
            {
                identifiersOfObjectsToDelete.Add(poco.Model.Id);
                poco.Model = null;
            }
 
            if (poco.NameGenerator != null && poco.NameGenerator.Id != dto.NameGenerator)
            {
                identifiersOfObjectsToDelete.Add(poco.NameGenerator.Id);
                poco.NameGenerator = null;
            }
 

            return identifiersOfObjectsToDelete;
        }
    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
