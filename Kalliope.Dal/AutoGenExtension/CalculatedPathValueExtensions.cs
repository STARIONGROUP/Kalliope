// -------------------------------------------------------------------------------------------------
// <copyright file="CalculatedPathValueExtensions.cs" company="RHEA System S.A.">
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
    /// A static class that provides extension methods for the <see cref="CalculatedPathValue"/> class
    /// </summary>
    public static class CalculatedPathValueExtensions
    {
        /// <summary>
        /// Updates the value properties of the <see cref="CalculatedPathValue"/> by setting the value equal to that of the dto
        /// Removes deleted objects from the reference properties and returns the unique identifiers
        /// of the objects that have been removed from <see cref="AggregationKind.Composite"/> properties
        /// </summary>
        /// <param name="poco">
        /// The <see cref="CalculatedPathValue"/> that is to be updated
        /// </param>
        /// <param name="dto">
        /// The DTO that is used to update the <see cref="CalculatedPathValue"/> with
        /// </param>
        /// <returns>
        /// The unique identifiers of the objects that have been removed from <see cref="AggregationKind.Composite"/> properties
        /// </returns>
        /// <exception cref="ArgumentNullException">
        /// Thrown when the <paramref name="poco"/> or <paramref name="dto"/> is null
        /// </exception>
        public static IEnumerable<string> UpdateValueAndRemoveDeletedReferenceProperties(this Kalliope.Core.CalculatedPathValue poco, Kalliope.DTO.CalculatedPathValue dto)
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
 
            if (poco.AggregationContextRequiredError != null && poco.AggregationContextRequiredError.Id != dto.AggregationContextRequiredError)
            {
                identifiersOfObjectsToDelete.Add(poco.AggregationContextRequiredError.Id);
                poco.AggregationContextRequiredError = null;
            }
 
            var associatedModelErrorsToDelete = poco.AssociatedModelErrors.Select(x => x.Id).Except(dto.AssociatedModelErrors);
            foreach (var identifier in associatedModelErrorsToDelete)
            {
                var modelError = poco.AssociatedModelErrors.Single(x => x.Id == identifier);
                poco.AssociatedModelErrors.Remove(modelError);
            }
 
            if (poco.ConsumptionRequiredError != null && poco.ConsumptionRequiredError.Id != dto.ConsumptionRequiredError)
            {
                identifiersOfObjectsToDelete.Add(poco.ConsumptionRequiredError.Id);
                poco.ConsumptionRequiredError = null;
            }
 
            var extensionModelErrorsToDelete = poco.ExtensionModelErrors.Select(x => x.Id).Except(dto.ExtensionModelErrors);
            foreach (var identifier in extensionModelErrorsToDelete)
            {
                var modelError = poco.ExtensionModelErrors.Single(x => x.Id == identifier);
                poco.ExtensionModelErrors.Remove(modelError);
            }
 
            if (poco.Function != null && poco.Function.Id != dto.Function)
            {
                poco.Function = null;
            }
 
            if (poco.FunctionRequiredError != null && poco.FunctionRequiredError.Id != dto.FunctionRequiredError)
            {
                identifiersOfObjectsToDelete.Add(poco.FunctionRequiredError.Id);
                poco.FunctionRequiredError = null;
            }
 
            var inputsToDelete = poco.Inputs.Select(x => x.Id).Except(dto.Inputs);
            identifiersOfObjectsToDelete.AddRange(inputsToDelete);
            foreach (var identifier in inputsToDelete)
            {
                var calculatedPathValueInput = poco.Inputs.Single(x => x.Id == identifier);
                poco.Inputs.Remove(calculatedPathValueInput);
            }
 
            var parameterBindingErrorsToDelete = poco.ParameterBindingErrors.Select(x => x.Id).Except(dto.ParameterBindingErrors);
            identifiersOfObjectsToDelete.AddRange(parameterBindingErrorsToDelete);
            foreach (var identifier in parameterBindingErrorsToDelete)
            {
                var calculatedPathValueParameterBindingError = poco.ParameterBindingErrors.Single(x => x.Id == identifier);
                poco.ParameterBindingErrors.Remove(calculatedPathValueParameterBindingError);
            }
 
            poco.UniversalAggregationContext = dto.UniversalAggregationContext;
 

            return identifiersOfObjectsToDelete;
        }
    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
