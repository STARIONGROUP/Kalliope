// -------------------------------------------------------------------------------------------------
// <copyright file="ModelThingExtensions.cs" company="RHEA System S.A.">
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

    using Kalliope.Common;

    /// <summary>
    /// A static class that provides extension methods for the <see cref="ModelThingExtensions"/> class
    /// </summary>
    public static class ModelThingExtensionsExtensions
    {
        /// <summary>
        /// Updates the value properties of the <see cref="Kalliope.Core.ModelThing"/> by setting the value equal to that of the dto
        /// Removes deleted objects from the reference properties and returns the unique identifiers
        /// of the objects that have been removed from <see cref="AggregationKind.Composite"/> properties
        /// </summary>
        /// <param name="poco">
        /// The <see cref="Kalliope.Core.ModelThing"/> that is to be updated
        /// </param>
        /// <param name="dto">
        /// The DTO that is used to update the <see cref="Kalliope.Core.ModelThing"/> with
        /// </param>
        /// <returns>
        /// The unique identifiers of the objects that have been removed from <see cref="AggregationKind.Composite"/> properties
        /// </returns>
        /// <exception cref="ArgumentNullException">
        /// Thrown when the <paramref name="poco"/> or <paramref name="dto"/> is null
        /// </exception>
        public static IEnumerable<string> UpdateValueAndRemoveDeletedReferenceProperties(this Kalliope.Core.ModelThing poco, Kalliope.DTO.ModelThing dto)
        {
            if (poco == null)
            {
                throw new ArgumentNullException(nameof(poco), $"the {nameof(poco)} may not be null");
            }

            if (dto == null)
            {
                throw new ArgumentNullException(nameof(dto), $"the {nameof(dto)} may not be null");
            }

            var typeName = poco.GetType().Name;

            switch (typeName)
            {
                case "AutoCounterNumericDataType":
                    var autoCounterNumericDataType = poco as Kalliope.Core.AutoCounterNumericDataType;
                    return autoCounterNumericDataType.UpdateValueAndRemoveDeletedReferenceProperties((Kalliope.DTO.AutoCounterNumericDataType)dto);
                case "AutoTimestampTemporalDataType":
                    var autoTimestampTemporalDataType = poco as Kalliope.Core.AutoTimestampTemporalDataType;
                    return autoTimestampTemporalDataType.UpdateValueAndRemoveDeletedReferenceProperties((Kalliope.DTO.AutoTimestampTemporalDataType)dto);
                case "CalculatedPathValue":
                    var calculatedPathValue = poco as Kalliope.Core.CalculatedPathValue;
                    return calculatedPathValue.UpdateValueAndRemoveDeletedReferenceProperties((Kalliope.DTO.CalculatedPathValue)dto);
                case "CalculatedPathValueInput":
                    var calculatedPathValueInput = poco as Kalliope.Core.CalculatedPathValueInput;
                    return calculatedPathValueInput.UpdateValueAndRemoveDeletedReferenceProperties((Kalliope.DTO.CalculatedPathValueInput)dto);
                case "CalculatedPathValueMustBeConsumedError":
                    var calculatedPathValueMustBeConsumedError = poco as Kalliope.Core.CalculatedPathValueMustBeConsumedError;
                    return calculatedPathValueMustBeConsumedError.UpdateValueAndRemoveDeletedReferenceProperties((Kalliope.DTO.CalculatedPathValueMustBeConsumedError)dto);
                case "CalculatedPathValueParameterBindingError":
                    var calculatedPathValueParameterBindingError = poco as Kalliope.Core.CalculatedPathValueParameterBindingError;
                    return calculatedPathValueParameterBindingError.UpdateValueAndRemoveDeletedReferenceProperties((Kalliope.DTO.CalculatedPathValueParameterBindingError)dto);
                case "CalculatedPathValueRequiresAggregationContextError":
                    var calculatedPathValueRequiresAggregationContextError = poco as Kalliope.Core.CalculatedPathValueRequiresAggregationContextError;
                    return calculatedPathValueRequiresAggregationContextError.UpdateValueAndRemoveDeletedReferenceProperties((Kalliope.DTO.CalculatedPathValueRequiresAggregationContextError)dto);
                case "CalculatedPathValueRequiresFunctionError":
                    var calculatedPathValueRequiresFunctionError = poco as Kalliope.Core.CalculatedPathValueRequiresFunctionError;
                    return calculatedPathValueRequiresFunctionError.UpdateValueAndRemoveDeletedReferenceProperties((Kalliope.DTO.CalculatedPathValueRequiresFunctionError)dto);
                case "CardinalityConstraintShape":
                    var cardinalityConstraintShape = poco as Kalliope.Diagrams.CardinalityConstraintShape;
                    return cardinalityConstraintShape.UpdateValueAndRemoveDeletedReferenceProperties((Kalliope.DTO.CardinalityConstraintShape)dto);
                case "CardinalityRange":
                    var cardinalityRange = poco as Kalliope.Core.CardinalityRange;
                    return cardinalityRange.UpdateValueAndRemoveDeletedReferenceProperties((Kalliope.DTO.CardinalityRange)dto);
                case "CardinalityRangeOverlapError":
                    var cardinalityRangeOverlapError = poco as Kalliope.Core.CardinalityRangeOverlapError;
                    return cardinalityRangeOverlapError.UpdateValueAndRemoveDeletedReferenceProperties((Kalliope.DTO.CardinalityRangeOverlapError)dto);
                case "CompatibleRolePlayerTypeError":
                    var compatibleRolePlayerTypeError = poco as Kalliope.Core.CompatibleRolePlayerTypeError;
                    return compatibleRolePlayerTypeError.UpdateValueAndRemoveDeletedReferenceProperties((Kalliope.DTO.CompatibleRolePlayerTypeError)dto);
                case "CompatibleSupertypesError":
                    var compatibleSupertypesError = poco as Kalliope.Core.CompatibleSupertypesError;
                    return compatibleSupertypesError.UpdateValueAndRemoveDeletedReferenceProperties((Kalliope.DTO.CompatibleSupertypesError)dto);
                case "CompatibleValueTypeInstanceValueError":
                    var compatibleValueTypeInstanceValueError = poco as Kalliope.Core.CompatibleValueTypeInstanceValueError;
                    return compatibleValueTypeInstanceValueError.UpdateValueAndRemoveDeletedReferenceProperties((Kalliope.DTO.CompatibleValueTypeInstanceValueError)dto);
                case "ConstraintDuplicateNameError":
                    var constraintDuplicateNameError = poco as Kalliope.Core.ConstraintDuplicateNameError;
                    return constraintDuplicateNameError.UpdateValueAndRemoveDeletedReferenceProperties((Kalliope.DTO.ConstraintDuplicateNameError)dto);
                case "ConstraintRoleRequiresCompatibleJoinPathProjectionError":
                    var constraintRoleRequiresCompatibleJoinPathProjectionError = poco as Kalliope.Core.ConstraintRoleRequiresCompatibleJoinPathProjectionError;
                    return constraintRoleRequiresCompatibleJoinPathProjectionError.UpdateValueAndRemoveDeletedReferenceProperties((Kalliope.DTO.ConstraintRoleRequiresCompatibleJoinPathProjectionError)dto);
                case "ConstraintRoleSequenceJoinPath":
                    var constraintRoleSequenceJoinPath = poco as Kalliope.Core.ConstraintRoleSequenceJoinPath;
                    return constraintRoleSequenceJoinPath.UpdateValueAndRemoveDeletedReferenceProperties((Kalliope.DTO.ConstraintRoleSequenceJoinPath)dto);
                case "ConstraintRoleSequenceJoinPathRequiresProjectionError":
                    var constraintRoleSequenceJoinPathRequiresProjectionError = poco as Kalliope.Core.ConstraintRoleSequenceJoinPathRequiresProjectionError;
                    return constraintRoleSequenceJoinPathRequiresProjectionError.UpdateValueAndRemoveDeletedReferenceProperties((Kalliope.DTO.ConstraintRoleSequenceJoinPathRequiresProjectionError)dto);
                case "CustomProperty":
                    var customProperty = poco as Kalliope.CustomProperties.CustomProperty;
                    return customProperty.UpdateValueAndRemoveDeletedReferenceProperties((Kalliope.DTO.CustomProperty)dto);
                case "CustomPropertyDefinition":
                    var customPropertyDefinition = poco as Kalliope.CustomProperties.CustomPropertyDefinition;
                    return customPropertyDefinition.UpdateValueAndRemoveDeletedReferenceProperties((Kalliope.DTO.CustomPropertyDefinition)dto);
                case "CustomPropertyGroup":
                    var customPropertyGroup = poco as Kalliope.CustomProperties.CustomPropertyGroup;
                    return customPropertyGroup.UpdateValueAndRemoveDeletedReferenceProperties((Kalliope.DTO.CustomPropertyGroup)dto);
                case "CustomReferenceMode":
                    var customReferenceMode = poco as Kalliope.Core.CustomReferenceMode;
                    return customReferenceMode.UpdateValueAndRemoveDeletedReferenceProperties((Kalliope.DTO.CustomReferenceMode)dto);
                case "DataTypeNotSpecifiedError":
                    var dataTypeNotSpecifiedError = poco as Kalliope.Core.DataTypeNotSpecifiedError;
                    return dataTypeNotSpecifiedError.UpdateValueAndRemoveDeletedReferenceProperties((Kalliope.DTO.DataTypeNotSpecifiedError)dto);
                case "DataTypeRef":
                    var dataTypeRef = poco as Kalliope.Core.DataTypeRef;
                    return dataTypeRef.UpdateValueAndRemoveDeletedReferenceProperties((Kalliope.DTO.DataTypeRef)dto);
                case "DateAndTimeTemporalDataType":
                    var dateAndTimeTemporalDataType = poco as Kalliope.Core.DateAndTimeTemporalDataType;
                    return dateAndTimeTemporalDataType.UpdateValueAndRemoveDeletedReferenceProperties((Kalliope.DTO.DateAndTimeTemporalDataType)dto);
                case "DateTemporalDataType":
                    var dateTemporalDataType = poco as Kalliope.Core.DateTemporalDataType;
                    return dateTemporalDataType.UpdateValueAndRemoveDeletedReferenceProperties((Kalliope.DTO.DateTemporalDataType)dto);
                case "DecimalNumericDataType":
                    var decimalNumericDataType = poco as Kalliope.Core.DecimalNumericDataType;
                    return decimalNumericDataType.UpdateValueAndRemoveDeletedReferenceProperties((Kalliope.DTO.DecimalNumericDataType)dto);
                case "Definition":
                    var definition = poco as Kalliope.Core.Definition;
                    return definition.UpdateValueAndRemoveDeletedReferenceProperties((Kalliope.DTO.Definition)dto);
                case "DerivationNote":
                    var derivationNote = poco as Kalliope.Core.DerivationNote;
                    return derivationNote.UpdateValueAndRemoveDeletedReferenceProperties((Kalliope.DTO.DerivationNote)dto);
                case "DerivedRoleRequiresCompatibleProjectionError":
                    var derivedRoleRequiresCompatibleProjectionError = poco as Kalliope.Core.DerivedRoleRequiresCompatibleProjectionError;
                    return derivedRoleRequiresCompatibleProjectionError.UpdateValueAndRemoveDeletedReferenceProperties((Kalliope.DTO.DerivedRoleRequiresCompatibleProjectionError)dto);
                case "DoublePrecisionFloatingPointNumericDataType":
                    var doublePrecisionFloatingPointNumericDataType = poco as Kalliope.Core.DoublePrecisionFloatingPointNumericDataType;
                    return doublePrecisionFloatingPointNumericDataType.UpdateValueAndRemoveDeletedReferenceProperties((Kalliope.DTO.DoublePrecisionFloatingPointNumericDataType)dto);
                case "DuplicateReadingSignatureError":
                    var duplicateReadingSignatureError = poco as Kalliope.Core.DuplicateReadingSignatureError;
                    return duplicateReadingSignatureError.UpdateValueAndRemoveDeletedReferenceProperties((Kalliope.DTO.DuplicateReadingSignatureError)dto);
                case "ElementGrouping":
                    var elementGrouping = poco as Kalliope.Core.ElementGrouping;
                    return elementGrouping.UpdateValueAndRemoveDeletedReferenceProperties((Kalliope.DTO.ElementGrouping)dto);
                case "ElementGroupingMembershipContradictionError":
                    var elementGroupingMembershipContradictionError = poco as Kalliope.Core.ElementGroupingMembershipContradictionError;
                    return elementGroupingMembershipContradictionError.UpdateValueAndRemoveDeletedReferenceProperties((Kalliope.DTO.ElementGroupingMembershipContradictionError)dto);
                case "ElementGroupingSet":
                    var elementGroupingSet = poco as Kalliope.Core.ElementGroupingSet;
                    return elementGroupingSet.UpdateValueAndRemoveDeletedReferenceProperties((Kalliope.DTO.ElementGroupingSet)dto);
                case "EntityType":
                    var entityType = poco as Kalliope.Core.EntityType;
                    return entityType.UpdateValueAndRemoveDeletedReferenceProperties((Kalliope.DTO.EntityType)dto);
                case "EntityTypeInstance":
                    var entityTypeInstance = poco as Kalliope.Core.EntityTypeInstance;
                    return entityTypeInstance.UpdateValueAndRemoveDeletedReferenceProperties((Kalliope.DTO.EntityTypeInstance)dto);
                case "EntityTypeRequiresReferenceSchemeError":
                    var entityTypeRequiresReferenceSchemeError = poco as Kalliope.Core.EntityTypeRequiresReferenceSchemeError;
                    return entityTypeRequiresReferenceSchemeError.UpdateValueAndRemoveDeletedReferenceProperties((Kalliope.DTO.EntityTypeRequiresReferenceSchemeError)dto);
                case "EntityTypeSubtypeInstance":
                    var entityTypeSubtypeInstance = poco as Kalliope.Core.EntityTypeSubtypeInstance;
                    return entityTypeSubtypeInstance.UpdateValueAndRemoveDeletedReferenceProperties((Kalliope.DTO.EntityTypeSubtypeInstance)dto);
                case "EqualityConstraint":
                    var equalityConstraint = poco as Kalliope.Core.EqualityConstraint;
                    return equalityConstraint.UpdateValueAndRemoveDeletedReferenceProperties((Kalliope.DTO.EqualityConstraint)dto);
                case "EqualityOrSubsetImpliedByMandatoryError":
                    var equalityOrSubsetImpliedByMandatoryError = poco as Kalliope.Core.EqualityOrSubsetImpliedByMandatoryError;
                    return equalityOrSubsetImpliedByMandatoryError.UpdateValueAndRemoveDeletedReferenceProperties((Kalliope.DTO.EqualityOrSubsetImpliedByMandatoryError)dto);
                case "ExclusionConstraint":
                    var exclusionConstraint = poco as Kalliope.Core.ExclusionConstraint;
                    return exclusionConstraint.UpdateValueAndRemoveDeletedReferenceProperties((Kalliope.DTO.ExclusionConstraint)dto);
                case "ExclusionContradictsEqualityError":
                    var exclusionContradictsEqualityError = poco as Kalliope.Core.ExclusionContradictsEqualityError;
                    return exclusionContradictsEqualityError.UpdateValueAndRemoveDeletedReferenceProperties((Kalliope.DTO.ExclusionContradictsEqualityError)dto);
                case "ExclusionContradictsMandatoryError":
                    var exclusionContradictsMandatoryError = poco as Kalliope.Core.ExclusionContradictsMandatoryError;
                    return exclusionContradictsMandatoryError.UpdateValueAndRemoveDeletedReferenceProperties((Kalliope.DTO.ExclusionContradictsMandatoryError)dto);
                case "ExclusionContradictsSubsetError":
                    var exclusionContradictsSubsetError = poco as Kalliope.Core.ExclusionContradictsSubsetError;
                    return exclusionContradictsSubsetError.UpdateValueAndRemoveDeletedReferenceProperties((Kalliope.DTO.ExclusionContradictsSubsetError)dto);
                case "ExternalConstraintRoleSequenceArityMismatchError":
                    var externalConstraintRoleSequenceArityMismatchError = poco as Kalliope.Core.ExternalConstraintRoleSequenceArityMismatchError;
                    return externalConstraintRoleSequenceArityMismatchError.UpdateValueAndRemoveDeletedReferenceProperties((Kalliope.DTO.ExternalConstraintRoleSequenceArityMismatchError)dto);
                case "ExternalConstraintShape":
                    var externalConstraintShape = poco as Kalliope.Diagrams.ExternalConstraintShape;
                    return externalConstraintShape.UpdateValueAndRemoveDeletedReferenceProperties((Kalliope.DTO.ExternalConstraintShape)dto);
                case "FactType":
                    var factType = poco as Kalliope.Core.FactType;
                    return factType.UpdateValueAndRemoveDeletedReferenceProperties((Kalliope.DTO.FactType)dto);
                case "FactTypeDerivationExpression":
                    var factTypeDerivationExpression = poco as Kalliope.Core.FactTypeDerivationExpression;
                    return factTypeDerivationExpression.UpdateValueAndRemoveDeletedReferenceProperties((Kalliope.DTO.FactTypeDerivationExpression)dto);
                case "FactTypeDerivationPath":
                    var factTypeDerivationPath = poco as Kalliope.Core.FactTypeDerivationPath;
                    return factTypeDerivationPath.UpdateValueAndRemoveDeletedReferenceProperties((Kalliope.DTO.FactTypeDerivationPath)dto);
                case "FactTypeDerivationRule":
                    var factTypeDerivationRule = poco as Kalliope.Core.FactTypeDerivationRule;
                    return factTypeDerivationRule.UpdateValueAndRemoveDeletedReferenceProperties((Kalliope.DTO.FactTypeDerivationRule)dto);
                case "FactTypeInstance":
                    var factTypeInstance = poco as Kalliope.Core.FactTypeInstance;
                    return factTypeInstance.UpdateValueAndRemoveDeletedReferenceProperties((Kalliope.DTO.FactTypeInstance)dto);
                case "FactTypeLinkConnectorShape":
                    var factTypeLinkConnectorShape = poco as Kalliope.Diagrams.FactTypeLinkConnectorShape;
                    return factTypeLinkConnectorShape.UpdateValueAndRemoveDeletedReferenceProperties((Kalliope.DTO.FactTypeLinkConnectorShape)dto);
                case "FactTypeRequiresInternalUniquenessConstraintError":
                    var factTypeRequiresInternalUniquenessConstraintError = poco as Kalliope.Core.FactTypeRequiresInternalUniquenessConstraintError;
                    return factTypeRequiresInternalUniquenessConstraintError.UpdateValueAndRemoveDeletedReferenceProperties((Kalliope.DTO.FactTypeRequiresInternalUniquenessConstraintError)dto);
                case "FactTypeRequiresReadingError":
                    var factTypeRequiresReadingError = poco as Kalliope.Core.FactTypeRequiresReadingError;
                    return factTypeRequiresReadingError.UpdateValueAndRemoveDeletedReferenceProperties((Kalliope.DTO.FactTypeRequiresReadingError)dto);
                case "FactTypeShape":
                    var factTypeShape = poco as Kalliope.Diagrams.FactTypeShape;
                    return factTypeShape.UpdateValueAndRemoveDeletedReferenceProperties((Kalliope.DTO.FactTypeShape)dto);
                case "FixedLengthRawDataDataType":
                    var fixedLengthRawDataDataType = poco as Kalliope.Core.FixedLengthRawDataDataType;
                    return fixedLengthRawDataDataType.UpdateValueAndRemoveDeletedReferenceProperties((Kalliope.DTO.FixedLengthRawDataDataType)dto);
                case "FixedLengthTextDataType":
                    var fixedLengthTextDataType = poco as Kalliope.Core.FixedLengthTextDataType;
                    return fixedLengthTextDataType.UpdateValueAndRemoveDeletedReferenceProperties((Kalliope.DTO.FixedLengthTextDataType)dto);
                case "FloatingPointNumericDataType":
                    var floatingPointNumericDataType = poco as Kalliope.Core.FloatingPointNumericDataType;
                    return floatingPointNumericDataType.UpdateValueAndRemoveDeletedReferenceProperties((Kalliope.DTO.FloatingPointNumericDataType)dto);
                case "FrequencyConstraint":
                    var frequencyConstraint = poco as Kalliope.Core.FrequencyConstraint;
                    return frequencyConstraint.UpdateValueAndRemoveDeletedReferenceProperties((Kalliope.DTO.FrequencyConstraint)dto);
                case "FrequencyConstraintExactlyOneError":
                    var frequencyConstraintExactlyOneError = poco as Kalliope.Core.FrequencyConstraintExactlyOneError;
                    return frequencyConstraintExactlyOneError.UpdateValueAndRemoveDeletedReferenceProperties((Kalliope.DTO.FrequencyConstraintExactlyOneError)dto);
                case "FrequencyConstraintMinMaxError":
                    var frequencyConstraintMinMaxError = poco as Kalliope.Core.FrequencyConstraintMinMaxError;
                    return frequencyConstraintMinMaxError.UpdateValueAndRemoveDeletedReferenceProperties((Kalliope.DTO.FrequencyConstraintMinMaxError)dto);
                case "FrequencyConstraintNonRestrictiveRangeError":
                    var frequencyConstraintNonRestrictiveRangeError = poco as Kalliope.Core.FrequencyConstraintNonRestrictiveRangeError;
                    return frequencyConstraintNonRestrictiveRangeError.UpdateValueAndRemoveDeletedReferenceProperties((Kalliope.DTO.FrequencyConstraintNonRestrictiveRangeError)dto);
                case "FrequencyConstraintShape":
                    var frequencyConstraintShape = poco as Kalliope.Diagrams.FrequencyConstraintShape;
                    return frequencyConstraintShape.UpdateValueAndRemoveDeletedReferenceProperties((Kalliope.DTO.FrequencyConstraintShape)dto);
                case "FrequencyConstraintViolatedByUniquenessConstraintError":
                    var frequencyConstraintViolatedByUniquenessConstraintError = poco as Kalliope.Core.FrequencyConstraintViolatedByUniquenessConstraintError;
                    return frequencyConstraintViolatedByUniquenessConstraintError.UpdateValueAndRemoveDeletedReferenceProperties((Kalliope.DTO.FrequencyConstraintViolatedByUniquenessConstraintError)dto);
                case "Function":
                    var function = poco as Kalliope.Core.Function;
                    return function.UpdateValueAndRemoveDeletedReferenceProperties((Kalliope.DTO.Function)dto);
                case "FunctionDuplicateNameError":
                    var functionDuplicateNameError = poco as Kalliope.Core.FunctionDuplicateNameError;
                    return functionDuplicateNameError.UpdateValueAndRemoveDeletedReferenceProperties((Kalliope.DTO.FunctionDuplicateNameError)dto);
                case "FunctionParameter":
                    var functionParameter = poco as Kalliope.Core.FunctionParameter;
                    return functionParameter.UpdateValueAndRemoveDeletedReferenceProperties((Kalliope.DTO.FunctionParameter)dto);
                case "GenerationState":
                    var generationState = poco as Kalliope.Core.GenerationState;
                    return generationState.UpdateValueAndRemoveDeletedReferenceProperties((Kalliope.DTO.GenerationState)dto);
                case "Group":
                    var group = poco as Kalliope.Core.Group;
                    return group.UpdateValueAndRemoveDeletedReferenceProperties((Kalliope.DTO.Group)dto);
                case "ImplicationError":
                    var implicationError = poco as Kalliope.Core.ImplicationError;
                    return implicationError.UpdateValueAndRemoveDeletedReferenceProperties((Kalliope.DTO.ImplicationError)dto);
                case "ImpliedFactType":
                    var impliedFactType = poco as Kalliope.Core.ImpliedFactType;
                    return impliedFactType.UpdateValueAndRemoveDeletedReferenceProperties((Kalliope.DTO.ImpliedFactType)dto);
                case "ImpliedInternalUniquenessConstraintError":
                    var impliedInternalUniquenessConstraintError = poco as Kalliope.Core.ImpliedInternalUniquenessConstraintError;
                    return impliedInternalUniquenessConstraintError.UpdateValueAndRemoveDeletedReferenceProperties((Kalliope.DTO.ImpliedInternalUniquenessConstraintError)dto);
                case "InformalDerivationRule":
                    var informalDerivationRule = poco as Kalliope.Core.InformalDerivationRule;
                    return informalDerivationRule.UpdateValueAndRemoveDeletedReferenceProperties((Kalliope.DTO.InformalDerivationRule)dto);
                case "IntrinsicReferenceMode":
                    var intrinsicReferenceMode = poco as Kalliope.Core.IntrinsicReferenceMode;
                    return intrinsicReferenceMode.UpdateValueAndRemoveDeletedReferenceProperties((Kalliope.DTO.IntrinsicReferenceMode)dto);
                case "JoinedPathRoleRequiresCompatibleRolePlayerError":
                    var joinedPathRoleRequiresCompatibleRolePlayerError = poco as Kalliope.Core.JoinedPathRoleRequiresCompatibleRolePlayerError;
                    return joinedPathRoleRequiresCompatibleRolePlayerError.UpdateValueAndRemoveDeletedReferenceProperties((Kalliope.DTO.JoinedPathRoleRequiresCompatibleRolePlayerError)dto);
                case "JoinPathRequiredError":
                    var joinPathRequiredError = poco as Kalliope.Core.JoinPathRequiredError;
                    return joinPathRequiredError.UpdateValueAndRemoveDeletedReferenceProperties((Kalliope.DTO.JoinPathRequiredError)dto);
                case "LargeLengthRawDataDataType":
                    var largeLengthRawDataDataType = poco as Kalliope.Core.LargeLengthRawDataDataType;
                    return largeLengthRawDataDataType.UpdateValueAndRemoveDeletedReferenceProperties((Kalliope.DTO.LargeLengthRawDataDataType)dto);
                case "LargeLengthTextDataType":
                    var largeLengthTextDataType = poco as Kalliope.Core.LargeLengthTextDataType;
                    return largeLengthTextDataType.UpdateValueAndRemoveDeletedReferenceProperties((Kalliope.DTO.LargeLengthTextDataType)dto);
                case "LeadRolePath":
                    var leadRolePath = poco as Kalliope.Core.LeadRolePath;
                    return leadRolePath.UpdateValueAndRemoveDeletedReferenceProperties((Kalliope.DTO.LeadRolePath)dto);
                case "LinkConnectorShape":
                    var linkConnectorShape = poco as Kalliope.Diagrams.LinkConnectorShape;
                    return linkConnectorShape.UpdateValueAndRemoveDeletedReferenceProperties((Kalliope.DTO.LinkConnectorShape)dto);
                case "MandatoryConstraint":
                    var mandatoryConstraint = poco as Kalliope.Core.MandatoryConstraint;
                    return mandatoryConstraint.UpdateValueAndRemoveDeletedReferenceProperties((Kalliope.DTO.MandatoryConstraint)dto);
                case "MaxValueMismatchError":
                    var maxValueMismatchError = poco as Kalliope.Core.MaxValueMismatchError;
                    return maxValueMismatchError.UpdateValueAndRemoveDeletedReferenceProperties((Kalliope.DTO.MaxValueMismatchError)dto);
                case "MinValueMismatchError":
                    var minValueMismatchError = poco as Kalliope.Core.MinValueMismatchError;
                    return minValueMismatchError.UpdateValueAndRemoveDeletedReferenceProperties((Kalliope.DTO.MinValueMismatchError)dto);
                case "ModelNote":
                    var modelNote = poco as Kalliope.Core.ModelNote;
                    return modelNote.UpdateValueAndRemoveDeletedReferenceProperties((Kalliope.DTO.ModelNote)dto);
                case "ModelNoteShape":
                    var modelNoteShape = poco as Kalliope.Diagrams.ModelNoteShape;
                    return modelNoteShape.UpdateValueAndRemoveDeletedReferenceProperties((Kalliope.DTO.ModelNoteShape)dto);
                case "MoneyNumericDataType":
                    var moneyNumericDataType = poco as Kalliope.Core.MoneyNumericDataType;
                    return moneyNumericDataType.UpdateValueAndRemoveDeletedReferenceProperties((Kalliope.DTO.MoneyNumericDataType)dto);
                case "NameAlias":
                    var nameAlias = poco as Kalliope.Core.NameAlias;
                    return nameAlias.UpdateValueAndRemoveDeletedReferenceProperties((Kalliope.DTO.NameAlias)dto);
                case "NameConsumer":
                    var nameConsumer = poco as Kalliope.Core.NameConsumer;
                    return nameConsumer.UpdateValueAndRemoveDeletedReferenceProperties((Kalliope.DTO.NameConsumer)dto);
                case "NameGenerator":
                    var nameGenerator = poco as Kalliope.Core.NameGenerator;
                    return nameGenerator.UpdateValueAndRemoveDeletedReferenceProperties((Kalliope.DTO.NameGenerator)dto);
                case "NMinusOneError":
                    var nMinusOneError = poco as Kalliope.Core.NMinusOneError;
                    return nMinusOneError.UpdateValueAndRemoveDeletedReferenceProperties((Kalliope.DTO.NMinusOneError)dto);
                case "Note":
                    var note = poco as Kalliope.Core.Note;
                    return note.UpdateValueAndRemoveDeletedReferenceProperties((Kalliope.DTO.Note)dto);
                case "NotWellModeledSubsetAndMandatoryError":
                    var notWellModeledSubsetAndMandatoryError = poco as Kalliope.Core.NotWellModeledSubsetAndMandatoryError;
                    return notWellModeledSubsetAndMandatoryError.UpdateValueAndRemoveDeletedReferenceProperties((Kalliope.DTO.NotWellModeledSubsetAndMandatoryError)dto);
                case "ObjectIdOtherDataType":
                    var objectIdOtherDataType = poco as Kalliope.Core.ObjectIdOtherDataType;
                    return objectIdOtherDataType.UpdateValueAndRemoveDeletedReferenceProperties((Kalliope.DTO.ObjectIdOtherDataType)dto);
                case "Objectification":
                    var objectification = poco as Kalliope.Core.Objectification;
                    return objectification.UpdateValueAndRemoveDeletedReferenceProperties((Kalliope.DTO.Objectification)dto);
                case "ObjectifiedInstanceRequiredError":
                    var objectifiedInstanceRequiredError = poco as Kalliope.Core.ObjectifiedInstanceRequiredError;
                    return objectifiedInstanceRequiredError.UpdateValueAndRemoveDeletedReferenceProperties((Kalliope.DTO.ObjectifiedInstanceRequiredError)dto);
                case "ObjectifiedType":
                    var objectifiedType = poco as Kalliope.Core.ObjectifiedType;
                    return objectifiedType.UpdateValueAndRemoveDeletedReferenceProperties((Kalliope.DTO.ObjectifiedType)dto);
                case "ObjectifiedUnaryRole":
                    var objectifiedUnaryRole = poco as Kalliope.Core.ObjectifiedUnaryRole;
                    return objectifiedUnaryRole.UpdateValueAndRemoveDeletedReferenceProperties((Kalliope.DTO.ObjectifiedUnaryRole)dto);
                case "ObjectifyingInstanceRequiredError":
                    var objectifyingInstanceRequiredError = poco as Kalliope.Core.ObjectifyingInstanceRequiredError;
                    return objectifyingInstanceRequiredError.UpdateValueAndRemoveDeletedReferenceProperties((Kalliope.DTO.ObjectifyingInstanceRequiredError)dto);
                case "ObjectTypeCardinalityConstraint":
                    var objectTypeCardinalityConstraint = poco as Kalliope.Core.ObjectTypeCardinalityConstraint;
                    return objectTypeCardinalityConstraint.UpdateValueAndRemoveDeletedReferenceProperties((Kalliope.DTO.ObjectTypeCardinalityConstraint)dto);
                case "ObjectTypeDuplicateNameError":
                    var objectTypeDuplicateNameError = poco as Kalliope.Core.ObjectTypeDuplicateNameError;
                    return objectTypeDuplicateNameError.UpdateValueAndRemoveDeletedReferenceProperties((Kalliope.DTO.ObjectTypeDuplicateNameError)dto);
                case "ObjectTypeShape":
                    var objectTypeShape = poco as Kalliope.Diagrams.ObjectTypeShape;
                    return objectTypeShape.UpdateValueAndRemoveDeletedReferenceProperties((Kalliope.DTO.ObjectTypeShape)dto);
                case "OleObjectRawDataDataType":
                    var oleObjectRawDataDataType = poco as Kalliope.Core.OleObjectRawDataDataType;
                    return oleObjectRawDataDataType.UpdateValueAndRemoveDeletedReferenceProperties((Kalliope.DTO.OleObjectRawDataDataType)dto);
                case "OrmDiagram":
                    var ormDiagram = poco as Kalliope.Diagrams.OrmDiagram;
                    return ormDiagram.UpdateValueAndRemoveDeletedReferenceProperties((Kalliope.DTO.OrmDiagram)dto);
                case "OrmModel":
                    var ormModel = poco as Kalliope.Core.OrmModel;
                    return ormModel.UpdateValueAndRemoveDeletedReferenceProperties((Kalliope.DTO.OrmModel)dto);
                case "OrmRoot":
                    var ormRoot = poco as Kalliope.OrmRoot;
                    return ormRoot.UpdateValueAndRemoveDeletedReferenceProperties((Kalliope.DTO.OrmRoot)dto);
                case "PartialConstraintRoleSequenceJoinPathProjectionError":
                    var partialConstraintRoleSequenceJoinPathProjectionError = poco as Kalliope.Core.PartialConstraintRoleSequenceJoinPathProjectionError;
                    return partialConstraintRoleSequenceJoinPathProjectionError.UpdateValueAndRemoveDeletedReferenceProperties((Kalliope.DTO.PartialConstraintRoleSequenceJoinPathProjectionError)dto);
                case "PartialRoleSetDerivationProjectionError":
                    var partialRoleSetDerivationProjectionError = poco as Kalliope.Core.PartialRoleSetDerivationProjectionError;
                    return partialRoleSetDerivationProjectionError.UpdateValueAndRemoveDeletedReferenceProperties((Kalliope.DTO.PartialRoleSetDerivationProjectionError)dto);
                case "PathConditionRoleValueConstraint":
                    var pathConditionRoleValueConstraint = poco as Kalliope.Core.PathConditionRoleValueConstraint;
                    return pathConditionRoleValueConstraint.UpdateValueAndRemoveDeletedReferenceProperties((Kalliope.DTO.PathConditionRoleValueConstraint)dto);
                case "PathConditionRootValueConstraint":
                    var pathConditionRootValueConstraint = poco as Kalliope.Core.PathConditionRootValueConstraint;
                    return pathConditionRootValueConstraint.UpdateValueAndRemoveDeletedReferenceProperties((Kalliope.DTO.PathConditionRootValueConstraint)dto);
                case "PathConstant":
                    var pathConstant = poco as Kalliope.Core.PathConstant;
                    return pathConstant.UpdateValueAndRemoveDeletedReferenceProperties((Kalliope.DTO.PathConstant)dto);
                case "PathObjectUnifier":
                    var pathObjectUnifier = poco as Kalliope.Core.PathObjectUnifier;
                    return pathObjectUnifier.UpdateValueAndRemoveDeletedReferenceProperties((Kalliope.DTO.PathObjectUnifier)dto);
                case "PathObjectUnifierRequiresCompatibleObjectTypesError":
                    var pathObjectUnifierRequiresCompatibleObjectTypesError = poco as Kalliope.Core.PathObjectUnifierRequiresCompatibleObjectTypesError;
                    return pathObjectUnifierRequiresCompatibleObjectTypesError.UpdateValueAndRemoveDeletedReferenceProperties((Kalliope.DTO.PathObjectUnifierRequiresCompatibleObjectTypesError)dto);
                case "PathOuterJoinRequiresOptionalRoleError":
                    var pathOuterJoinRequiresOptionalRoleError = poco as Kalliope.Core.PathOuterJoinRequiresOptionalRoleError;
                    return pathOuterJoinRequiresOptionalRoleError.UpdateValueAndRemoveDeletedReferenceProperties((Kalliope.DTO.PathOuterJoinRequiresOptionalRoleError)dto);
                case "PathRequiresRootObjectTypeError":
                    var pathRequiresRootObjectTypeError = poco as Kalliope.Core.PathRequiresRootObjectTypeError;
                    return pathRequiresRootObjectTypeError.UpdateValueAndRemoveDeletedReferenceProperties((Kalliope.DTO.PathRequiresRootObjectTypeError)dto);
                case "PathSameFactTypeRoleFollowsJoinError":
                    var pathSameFactTypeRoleFollowsJoinError = poco as Kalliope.Core.PathSameFactTypeRoleFollowsJoinError;
                    return pathSameFactTypeRoleFollowsJoinError.UpdateValueAndRemoveDeletedReferenceProperties((Kalliope.DTO.PathSameFactTypeRoleFollowsJoinError)dto);
                case "PictureRawDataDataType":
                    var pictureRawDataDataType = poco as Kalliope.Core.PictureRawDataDataType;
                    return pictureRawDataDataType.UpdateValueAndRemoveDeletedReferenceProperties((Kalliope.DTO.PictureRawDataDataType)dto);
                case "PopulationMandatoryError":
                    var populationMandatoryError = poco as Kalliope.Core.PopulationMandatoryError;
                    return populationMandatoryError.UpdateValueAndRemoveDeletedReferenceProperties((Kalliope.DTO.PopulationMandatoryError)dto);
                case "PopulationUniquenessError":
                    var populationUniquenessError = poco as Kalliope.Core.PopulationUniquenessError;
                    return populationUniquenessError.UpdateValueAndRemoveDeletedReferenceProperties((Kalliope.DTO.PopulationUniquenessError)dto);
                case "PreferredIdentifierRequiresMandatoryError":
                    var preferredIdentifierRequiresMandatoryError = poco as Kalliope.Core.PreferredIdentifierRequiresMandatoryError;
                    return preferredIdentifierRequiresMandatoryError.UpdateValueAndRemoveDeletedReferenceProperties((Kalliope.DTO.PreferredIdentifierRequiresMandatoryError)dto);
                case "QueryDerivationRule":
                    var queryDerivationRule = poco as Kalliope.Core.QueryDerivationRule;
                    return queryDerivationRule.UpdateValueAndRemoveDeletedReferenceProperties((Kalliope.DTO.QueryDerivationRule)dto);
                case "QueryParameter":
                    var queryParameter = poco as Kalliope.Core.QueryParameter;
                    return queryParameter.UpdateValueAndRemoveDeletedReferenceProperties((Kalliope.DTO.QueryParameter)dto);
                case "Reading":
                    var reading = poco as Kalliope.Core.Reading;
                    return reading.UpdateValueAndRemoveDeletedReferenceProperties((Kalliope.DTO.Reading)dto);
                case "ReadingOrder":
                    var readingOrder = poco as Kalliope.Core.ReadingOrder;
                    return readingOrder.UpdateValueAndRemoveDeletedReferenceProperties((Kalliope.DTO.ReadingOrder)dto);
                case "ReadingRequiresUserModificationError":
                    var readingRequiresUserModificationError = poco as Kalliope.Core.ReadingRequiresUserModificationError;
                    return readingRequiresUserModificationError.UpdateValueAndRemoveDeletedReferenceProperties((Kalliope.DTO.ReadingRequiresUserModificationError)dto);
                case "ReadingShape":
                    var readingShape = poco as Kalliope.Diagrams.ReadingShape;
                    return readingShape.UpdateValueAndRemoveDeletedReferenceProperties((Kalliope.DTO.ReadingShape)dto);
                case "RecognizedPhrase":
                    var recognizedPhrase = poco as Kalliope.Core.RecognizedPhrase;
                    return recognizedPhrase.UpdateValueAndRemoveDeletedReferenceProperties((Kalliope.DTO.RecognizedPhrase)dto);
                case "RecognizedPhraseDuplicateNameError":
                    var recognizedPhraseDuplicateNameError = poco as Kalliope.Core.RecognizedPhraseDuplicateNameError;
                    return recognizedPhraseDuplicateNameError.UpdateValueAndRemoveDeletedReferenceProperties((Kalliope.DTO.RecognizedPhraseDuplicateNameError)dto);
                case "ReferenceModeKind":
                    var referenceModeKind = poco as Kalliope.Core.ReferenceModeKind;
                    return referenceModeKind.UpdateValueAndRemoveDeletedReferenceProperties((Kalliope.DTO.ReferenceModeKind)dto);
                case "RingConstraint":
                    var ringConstraint = poco as Kalliope.Core.RingConstraint;
                    return ringConstraint.UpdateValueAndRemoveDeletedReferenceProperties((Kalliope.DTO.RingConstraint)dto);
                case "RingConstraintShape":
                    var ringConstraintShape = poco as Kalliope.Diagrams.RingConstraintShape;
                    return ringConstraintShape.UpdateValueAndRemoveDeletedReferenceProperties((Kalliope.DTO.RingConstraintShape)dto);
                case "RingConstraintTypeNotSpecifiedError":
                    var ringConstraintTypeNotSpecifiedError = poco as Kalliope.Core.RingConstraintTypeNotSpecifiedError;
                    return ringConstraintTypeNotSpecifiedError.UpdateValueAndRemoveDeletedReferenceProperties((Kalliope.DTO.RingConstraintTypeNotSpecifiedError)dto);
                case "Role":
                    var role = poco as Kalliope.Core.Role;
                    return role.UpdateValueAndRemoveDeletedReferenceProperties((Kalliope.DTO.Role)dto);
                case "RoleNameShape":
                    var roleNameShape = poco as Kalliope.Diagrams.RoleNameShape;
                    return roleNameShape.UpdateValueAndRemoveDeletedReferenceProperties((Kalliope.DTO.RoleNameShape)dto);
                case "RolePlayerRequiredError":
                    var rolePlayerRequiredError = poco as Kalliope.Core.RolePlayerRequiredError;
                    return rolePlayerRequiredError.UpdateValueAndRemoveDeletedReferenceProperties((Kalliope.DTO.RolePlayerRequiredError)dto);
                case "RoleProjectedDerivationRequiresProjectionError":
                    var roleProjectedDerivationRequiresProjectionError = poco as Kalliope.Core.RoleProjectedDerivationRequiresProjectionError;
                    return roleProjectedDerivationRequiresProjectionError.UpdateValueAndRemoveDeletedReferenceProperties((Kalliope.DTO.RoleProjectedDerivationRequiresProjectionError)dto);
                case "RoleProxy":
                    var roleProxy = poco as Kalliope.Core.RoleProxy;
                    return roleProxy.UpdateValueAndRemoveDeletedReferenceProperties((Kalliope.DTO.RoleProxy)dto);
                case "RoleSubPath":
                    var roleSubPath = poco as Kalliope.Core.RoleSubPath;
                    return roleSubPath.UpdateValueAndRemoveDeletedReferenceProperties((Kalliope.DTO.RoleSubPath)dto);
                case "RoleText":
                    var roleText = poco as Kalliope.Core.RoleText;
                    return roleText.UpdateValueAndRemoveDeletedReferenceProperties((Kalliope.DTO.RoleText)dto);
                case "RoleValueConstraint":
                    var roleValueConstraint = poco as Kalliope.Core.RoleValueConstraint;
                    return roleValueConstraint.UpdateValueAndRemoveDeletedReferenceProperties((Kalliope.DTO.RoleValueConstraint)dto);
                case "RowIdOtherDataType":
                    var rowIdOtherDataType = poco as Kalliope.Core.RowIdOtherDataType;
                    return rowIdOtherDataType.UpdateValueAndRemoveDeletedReferenceProperties((Kalliope.DTO.RowIdOtherDataType)dto);
                case "SetComparisonConstraintRoleSequence":
                    var setComparisonConstraintRoleSequence = poco as Kalliope.Core.SetComparisonConstraintRoleSequence;
                    return setComparisonConstraintRoleSequence.UpdateValueAndRemoveDeletedReferenceProperties((Kalliope.DTO.SetComparisonConstraintRoleSequence)dto);
                case "SignedIntegerNumericDataType":
                    var signedIntegerNumericDataType = poco as Kalliope.Core.SignedIntegerNumericDataType;
                    return signedIntegerNumericDataType.UpdateValueAndRemoveDeletedReferenceProperties((Kalliope.DTO.SignedIntegerNumericDataType)dto);
                case "SignedLargeIntegerNumericDataType":
                    var signedLargeIntegerNumericDataType = poco as Kalliope.Core.SignedLargeIntegerNumericDataType;
                    return signedLargeIntegerNumericDataType.UpdateValueAndRemoveDeletedReferenceProperties((Kalliope.DTO.SignedLargeIntegerNumericDataType)dto);
                case "SignedSmallIntegerNumericDataType":
                    var signedSmallIntegerNumericDataType = poco as Kalliope.Core.SignedSmallIntegerNumericDataType;
                    return signedSmallIntegerNumericDataType.UpdateValueAndRemoveDeletedReferenceProperties((Kalliope.DTO.SignedSmallIntegerNumericDataType)dto);
                case "SinglePrecisionFloatingPointNumericDataType":
                    var singlePrecisionFloatingPointNumericDataType = poco as Kalliope.Core.SinglePrecisionFloatingPointNumericDataType;
                    return singlePrecisionFloatingPointNumericDataType.UpdateValueAndRemoveDeletedReferenceProperties((Kalliope.DTO.SinglePrecisionFloatingPointNumericDataType)dto);
                case "Subquery":
                    var subquery = poco as Kalliope.Core.Subquery;
                    return subquery.UpdateValueAndRemoveDeletedReferenceProperties((Kalliope.DTO.Subquery)dto);
                case "SubsetConstraint":
                    var subsetConstraint = poco as Kalliope.Core.SubsetConstraint;
                    return subsetConstraint.UpdateValueAndRemoveDeletedReferenceProperties((Kalliope.DTO.SubsetConstraint)dto);
                case "SubtypeDerivationExpression":
                    var subtypeDerivationExpression = poco as Kalliope.Core.SubtypeDerivationExpression;
                    return subtypeDerivationExpression.UpdateValueAndRemoveDeletedReferenceProperties((Kalliope.DTO.SubtypeDerivationExpression)dto);
                case "SubtypeDerivationPath":
                    var subtypeDerivationPath = poco as Kalliope.Core.SubtypeDerivationPath;
                    return subtypeDerivationPath.UpdateValueAndRemoveDeletedReferenceProperties((Kalliope.DTO.SubtypeDerivationPath)dto);
                case "SubtypeDerivationRule":
                    var subtypeDerivationRule = poco as Kalliope.Core.SubtypeDerivationRule;
                    return subtypeDerivationRule.UpdateValueAndRemoveDeletedReferenceProperties((Kalliope.DTO.SubtypeDerivationRule)dto);
                case "SubtypeFact":
                    var subtypeFact = poco as Kalliope.Core.SubtypeFact;
                    return subtypeFact.UpdateValueAndRemoveDeletedReferenceProperties((Kalliope.DTO.SubtypeFact)dto);
                case "SubtypeLink":
                    var subtypeLink = poco as Kalliope.Diagrams.SubtypeLink;
                    return subtypeLink.UpdateValueAndRemoveDeletedReferenceProperties((Kalliope.DTO.SubtypeLink)dto);
                case "SubtypeMetaRole":
                    var subtypeMetaRole = poco as Kalliope.Core.SubtypeMetaRole;
                    return subtypeMetaRole.UpdateValueAndRemoveDeletedReferenceProperties((Kalliope.DTO.SubtypeMetaRole)dto);
                case "SupersetRoleOfSubtypeSubsetConstraintNotSubtypeError":
                    var supersetRoleOfSubtypeSubsetConstraintNotSubtypeError = poco as Kalliope.Core.SupersetRoleOfSubtypeSubsetConstraintNotSubtypeError;
                    return supersetRoleOfSubtypeSubsetConstraintNotSubtypeError.UpdateValueAndRemoveDeletedReferenceProperties((Kalliope.DTO.SupersetRoleOfSubtypeSubsetConstraintNotSubtypeError)dto);
                case "SupertypeMetaRole":
                    var supertypeMetaRole = poco as Kalliope.Core.SupertypeMetaRole;
                    return supertypeMetaRole.UpdateValueAndRemoveDeletedReferenceProperties((Kalliope.DTO.SupertypeMetaRole)dto);
                case "TimeTemporalDataType":
                    var timeTemporalDataType = poco as Kalliope.Core.TimeTemporalDataType;
                    return timeTemporalDataType.UpdateValueAndRemoveDeletedReferenceProperties((Kalliope.DTO.TimeTemporalDataType)dto);
                case "TooFewEntityTypeRoleInstancesError":
                    var tooFewEntityTypeRoleInstancesError = poco as Kalliope.Core.TooFewEntityTypeRoleInstancesError;
                    return tooFewEntityTypeRoleInstancesError.UpdateValueAndRemoveDeletedReferenceProperties((Kalliope.DTO.TooFewEntityTypeRoleInstancesError)dto);
                case "TooFewFactTypeRoleInstancesError":
                    var tooFewFactTypeRoleInstancesError = poco as Kalliope.Core.TooFewFactTypeRoleInstancesError;
                    return tooFewFactTypeRoleInstancesError.UpdateValueAndRemoveDeletedReferenceProperties((Kalliope.DTO.TooFewFactTypeRoleInstancesError)dto);
                case "TooFewReadingRolesError":
                    var tooFewReadingRolesError = poco as Kalliope.Core.TooFewReadingRolesError;
                    return tooFewReadingRolesError.UpdateValueAndRemoveDeletedReferenceProperties((Kalliope.DTO.TooFewReadingRolesError)dto);
                case "TooFewRoleSequencesError":
                    var tooFewRoleSequencesError = poco as Kalliope.Core.TooFewRoleSequencesError;
                    return tooFewRoleSequencesError.UpdateValueAndRemoveDeletedReferenceProperties((Kalliope.DTO.TooFewRoleSequencesError)dto);
                case "TooManyReadingRolesError":
                    var tooManyReadingRolesError = poco as Kalliope.Core.TooManyReadingRolesError;
                    return tooManyReadingRolesError.UpdateValueAndRemoveDeletedReferenceProperties((Kalliope.DTO.TooManyReadingRolesError)dto);
                case "TooManyRoleSequencesError":
                    var tooManyRoleSequencesError = poco as Kalliope.Core.TooManyRoleSequencesError;
                    return tooManyRoleSequencesError.UpdateValueAndRemoveDeletedReferenceProperties((Kalliope.DTO.TooManyRoleSequencesError)dto);
                case "TrueOrFalseLogicalDataType":
                    var trueOrFalseLogicalDataType = poco as Kalliope.Core.TrueOrFalseLogicalDataType;
                    return trueOrFalseLogicalDataType.UpdateValueAndRemoveDeletedReferenceProperties((Kalliope.DTO.TrueOrFalseLogicalDataType)dto);
                case "UnaryRoleCardinalityConstraint":
                    var unaryRoleCardinalityConstraint = poco as Kalliope.Core.UnaryRoleCardinalityConstraint;
                    return unaryRoleCardinalityConstraint.UpdateValueAndRemoveDeletedReferenceProperties((Kalliope.DTO.UnaryRoleCardinalityConstraint)dto);
                case "UniquenessConstraint":
                    var uniquenessConstraint = poco as Kalliope.Core.UniquenessConstraint;
                    return uniquenessConstraint.UpdateValueAndRemoveDeletedReferenceProperties((Kalliope.DTO.UniquenessConstraint)dto);
                case "UnsignedIntegerNumericDataType":
                    var unsignedIntegerNumericDataType = poco as Kalliope.Core.UnsignedIntegerNumericDataType;
                    return unsignedIntegerNumericDataType.UpdateValueAndRemoveDeletedReferenceProperties((Kalliope.DTO.UnsignedIntegerNumericDataType)dto);
                case "UnsignedLargeIntegerNumericDataType":
                    var unsignedLargeIntegerNumericDataType = poco as Kalliope.Core.UnsignedLargeIntegerNumericDataType;
                    return unsignedLargeIntegerNumericDataType.UpdateValueAndRemoveDeletedReferenceProperties((Kalliope.DTO.UnsignedLargeIntegerNumericDataType)dto);
                case "UnsignedSmallIntegerNumericDataType":
                    var unsignedSmallIntegerNumericDataType = poco as Kalliope.Core.UnsignedSmallIntegerNumericDataType;
                    return unsignedSmallIntegerNumericDataType.UpdateValueAndRemoveDeletedReferenceProperties((Kalliope.DTO.UnsignedSmallIntegerNumericDataType)dto);
                case "UnsignedTinyIntegerNumericDataType":
                    var unsignedTinyIntegerNumericDataType = poco as Kalliope.Core.UnsignedTinyIntegerNumericDataType;
                    return unsignedTinyIntegerNumericDataType.UpdateValueAndRemoveDeletedReferenceProperties((Kalliope.DTO.UnsignedTinyIntegerNumericDataType)dto);
                case "UnspecifiedDataType":
                    var unspecifiedDataType = poco as Kalliope.Core.UnspecifiedDataType;
                    return unspecifiedDataType.UpdateValueAndRemoveDeletedReferenceProperties((Kalliope.DTO.UnspecifiedDataType)dto);
                case "ValueComparisonConstraint":
                    var valueComparisonConstraint = poco as Kalliope.Core.ValueComparisonConstraint;
                    return valueComparisonConstraint.UpdateValueAndRemoveDeletedReferenceProperties((Kalliope.DTO.ValueComparisonConstraint)dto);
                case "ValueComparisonConstraintOperatorNotSpecifiedError":
                    var valueComparisonConstraintOperatorNotSpecifiedError = poco as Kalliope.Core.ValueComparisonConstraintOperatorNotSpecifiedError;
                    return valueComparisonConstraintOperatorNotSpecifiedError.UpdateValueAndRemoveDeletedReferenceProperties((Kalliope.DTO.ValueComparisonConstraintOperatorNotSpecifiedError)dto);
                case "ValueComparisonConstraintShape":
                    var valueComparisonConstraintShape = poco as Kalliope.Diagrams.ValueComparisonConstraintShape;
                    return valueComparisonConstraintShape.UpdateValueAndRemoveDeletedReferenceProperties((Kalliope.DTO.ValueComparisonConstraintShape)dto);
                case "ValueComparisonRolesNotComparableError":
                    var valueComparisonRolesNotComparableError = poco as Kalliope.Core.ValueComparisonRolesNotComparableError;
                    return valueComparisonRolesNotComparableError.UpdateValueAndRemoveDeletedReferenceProperties((Kalliope.DTO.ValueComparisonRolesNotComparableError)dto);
                case "ValueConstraintShape":
                    var valueConstraintShape = poco as Kalliope.Diagrams.ValueConstraintShape;
                    return valueConstraintShape.UpdateValueAndRemoveDeletedReferenceProperties((Kalliope.DTO.ValueConstraintShape)dto);
                case "ValueConstraintValueTypeDetachedError":
                    var valueConstraintValueTypeDetachedError = poco as Kalliope.Core.ValueConstraintValueTypeDetachedError;
                    return valueConstraintValueTypeDetachedError.UpdateValueAndRemoveDeletedReferenceProperties((Kalliope.DTO.ValueConstraintValueTypeDetachedError)dto);
                case "ValueRange":
                    var valueRange = poco as Kalliope.Core.ValueRange;
                    return valueRange.UpdateValueAndRemoveDeletedReferenceProperties((Kalliope.DTO.ValueRange)dto);
                case "ValueRangeOverlapError":
                    var valueRangeOverlapError = poco as Kalliope.Core.ValueRangeOverlapError;
                    return valueRangeOverlapError.UpdateValueAndRemoveDeletedReferenceProperties((Kalliope.DTO.ValueRangeOverlapError)dto);
                case "ValueType":
                    var valueType = poco as Kalliope.Core.ValueType;
                    return valueType.UpdateValueAndRemoveDeletedReferenceProperties((Kalliope.DTO.ValueType)dto);
                case "ValueTypeInstance":
                    var valueTypeInstance = poco as Kalliope.Core.ValueTypeInstance;
                    return valueTypeInstance.UpdateValueAndRemoveDeletedReferenceProperties((Kalliope.DTO.ValueTypeInstance)dto);
                case "ValueTypeValueConstraint":
                    var valueTypeValueConstraint = poco as Kalliope.Core.ValueTypeValueConstraint;
                    return valueTypeValueConstraint.UpdateValueAndRemoveDeletedReferenceProperties((Kalliope.DTO.ValueTypeValueConstraint)dto);
                case "VariableLengthRawDataDataType":
                    var variableLengthRawDataDataType = poco as Kalliope.Core.VariableLengthRawDataDataType;
                    return variableLengthRawDataDataType.UpdateValueAndRemoveDeletedReferenceProperties((Kalliope.DTO.VariableLengthRawDataDataType)dto);
                case "VariableLengthTextDataType":
                    var variableLengthTextDataType = poco as Kalliope.Core.VariableLengthTextDataType;
                    return variableLengthTextDataType.UpdateValueAndRemoveDeletedReferenceProperties((Kalliope.DTO.VariableLengthTextDataType)dto);
                case "YesOrNoLogicalDataType":
                    var yesOrNoLogicalDataType = poco as Kalliope.Core.YesOrNoLogicalDataType;
                    return yesOrNoLogicalDataType.UpdateValueAndRemoveDeletedReferenceProperties((Kalliope.DTO.YesOrNoLogicalDataType)dto);
                default:
                    throw new System.NotSupportedException($"{poco.GetType().Name} not yet supported");
            }
        }

        /// <summary>
        /// Updates the Reference properties of the <see cref=""/> using the data (identifiers) encapsulated in the DTO
        /// and the provided cache to find the referenced object.
        /// </summary>
        /// <param name="poco">
        /// The <see cref=""/> that is to be updated
        /// </param>
        /// <param name="dto">
        /// The DTO that is used to update the <see cref=""/> with
        /// </param>
        /// <param name="cache">
        /// The <see cref="ConcurrentDictionary{String, Lazy{Kalliope.Core.ModelThing}}"/> that contains the
        /// <see cref="ModelThing"/>s that are know and cached.
        /// </param>
        /// <exception cref="ArgumentNullException"></exception>
        public static void UpdateReferenceProperties(this Kalliope.Core.ModelThing poco, Kalliope.DTO.ModelThing dto, ConcurrentDictionary<string, Lazy<Kalliope.Core.ModelThing>> cache)
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

            var typeName = poco.GetType().Name;

            switch (typeName)
            {
                case "AutoCounterNumericDataType":
                    var autoCounterNumericDataType = poco as Kalliope.Core.AutoCounterNumericDataType;
                    autoCounterNumericDataType.UpdateReferenceProperties((Kalliope.DTO.AutoCounterNumericDataType)dto, cache);
                    break;
                case "AutoTimestampTemporalDataType":
                    var autoTimestampTemporalDataType = poco as Kalliope.Core.AutoTimestampTemporalDataType;
                    autoTimestampTemporalDataType.UpdateReferenceProperties((Kalliope.DTO.AutoTimestampTemporalDataType)dto, cache);
                    break;
                case "CalculatedPathValue":
                    var calculatedPathValue = poco as Kalliope.Core.CalculatedPathValue;
                    calculatedPathValue.UpdateReferenceProperties((Kalliope.DTO.CalculatedPathValue)dto, cache);
                    break;
                case "CalculatedPathValueInput":
                    var calculatedPathValueInput = poco as Kalliope.Core.CalculatedPathValueInput;
                    calculatedPathValueInput.UpdateReferenceProperties((Kalliope.DTO.CalculatedPathValueInput)dto, cache);
                    break;
                case "CalculatedPathValueMustBeConsumedError":
                    var calculatedPathValueMustBeConsumedError = poco as Kalliope.Core.CalculatedPathValueMustBeConsumedError;
                    calculatedPathValueMustBeConsumedError.UpdateReferenceProperties((Kalliope.DTO.CalculatedPathValueMustBeConsumedError)dto, cache);
                    break;
                case "CalculatedPathValueParameterBindingError":
                    var calculatedPathValueParameterBindingError = poco as Kalliope.Core.CalculatedPathValueParameterBindingError;
                    calculatedPathValueParameterBindingError.UpdateReferenceProperties((Kalliope.DTO.CalculatedPathValueParameterBindingError)dto, cache);
                    break;
                case "CalculatedPathValueRequiresAggregationContextError":
                    var calculatedPathValueRequiresAggregationContextError = poco as Kalliope.Core.CalculatedPathValueRequiresAggregationContextError;
                    calculatedPathValueRequiresAggregationContextError.UpdateReferenceProperties((Kalliope.DTO.CalculatedPathValueRequiresAggregationContextError)dto, cache);
                    break;
                case "CalculatedPathValueRequiresFunctionError":
                    var calculatedPathValueRequiresFunctionError = poco as Kalliope.Core.CalculatedPathValueRequiresFunctionError;
                    calculatedPathValueRequiresFunctionError.UpdateReferenceProperties((Kalliope.DTO.CalculatedPathValueRequiresFunctionError)dto, cache);
                    break;
                case "CardinalityConstraintShape":
                    var cardinalityConstraintShape = poco as Kalliope.Diagrams.CardinalityConstraintShape;
                    cardinalityConstraintShape.UpdateReferenceProperties((Kalliope.DTO.CardinalityConstraintShape)dto, cache);
                    break;
                case "CardinalityRange":
                    var cardinalityRange = poco as Kalliope.Core.CardinalityRange;
                    cardinalityRange.UpdateReferenceProperties((Kalliope.DTO.CardinalityRange)dto, cache);
                    break;
                case "CardinalityRangeOverlapError":
                    var cardinalityRangeOverlapError = poco as Kalliope.Core.CardinalityRangeOverlapError;
                    cardinalityRangeOverlapError.UpdateReferenceProperties((Kalliope.DTO.CardinalityRangeOverlapError)dto, cache);
                    break;
                case "CompatibleRolePlayerTypeError":
                    var compatibleRolePlayerTypeError = poco as Kalliope.Core.CompatibleRolePlayerTypeError;
                    compatibleRolePlayerTypeError.UpdateReferenceProperties((Kalliope.DTO.CompatibleRolePlayerTypeError)dto, cache);
                    break;
                case "CompatibleSupertypesError":
                    var compatibleSupertypesError = poco as Kalliope.Core.CompatibleSupertypesError;
                    compatibleSupertypesError.UpdateReferenceProperties((Kalliope.DTO.CompatibleSupertypesError)dto, cache);
                    break;
                case "CompatibleValueTypeInstanceValueError":
                    var compatibleValueTypeInstanceValueError = poco as Kalliope.Core.CompatibleValueTypeInstanceValueError;
                    compatibleValueTypeInstanceValueError.UpdateReferenceProperties((Kalliope.DTO.CompatibleValueTypeInstanceValueError)dto, cache);
                    break;
                case "ConstraintDuplicateNameError":
                    var constraintDuplicateNameError = poco as Kalliope.Core.ConstraintDuplicateNameError;
                    constraintDuplicateNameError.UpdateReferenceProperties((Kalliope.DTO.ConstraintDuplicateNameError)dto, cache);
                    break;
                case "ConstraintRoleRequiresCompatibleJoinPathProjectionError":
                    var constraintRoleRequiresCompatibleJoinPathProjectionError = poco as Kalliope.Core.ConstraintRoleRequiresCompatibleJoinPathProjectionError;
                    constraintRoleRequiresCompatibleJoinPathProjectionError.UpdateReferenceProperties((Kalliope.DTO.ConstraintRoleRequiresCompatibleJoinPathProjectionError)dto, cache);
                    break;
                case "ConstraintRoleSequenceJoinPath":
                    var constraintRoleSequenceJoinPath = poco as Kalliope.Core.ConstraintRoleSequenceJoinPath;
                    constraintRoleSequenceJoinPath.UpdateReferenceProperties((Kalliope.DTO.ConstraintRoleSequenceJoinPath)dto, cache);
                    break;
                case "ConstraintRoleSequenceJoinPathRequiresProjectionError":
                    var constraintRoleSequenceJoinPathRequiresProjectionError = poco as Kalliope.Core.ConstraintRoleSequenceJoinPathRequiresProjectionError;
                    constraintRoleSequenceJoinPathRequiresProjectionError.UpdateReferenceProperties((Kalliope.DTO.ConstraintRoleSequenceJoinPathRequiresProjectionError)dto, cache);
                    break;
                case "CustomProperty":
                    var customProperty = poco as Kalliope.CustomProperties.CustomProperty;
                    customProperty.UpdateReferenceProperties((Kalliope.DTO.CustomProperty)dto, cache);
                    break;
                case "CustomPropertyDefinition":
                    var customPropertyDefinition = poco as Kalliope.CustomProperties.CustomPropertyDefinition;
                    customPropertyDefinition.UpdateReferenceProperties((Kalliope.DTO.CustomPropertyDefinition)dto, cache);
                    break;
                case "CustomPropertyGroup":
                    var customPropertyGroup = poco as Kalliope.CustomProperties.CustomPropertyGroup;
                    customPropertyGroup.UpdateReferenceProperties((Kalliope.DTO.CustomPropertyGroup)dto, cache);
                    break;
                case "CustomReferenceMode":
                    var customReferenceMode = poco as Kalliope.Core.CustomReferenceMode;
                    customReferenceMode.UpdateReferenceProperties((Kalliope.DTO.CustomReferenceMode)dto, cache);
                    break;
                case "DataTypeNotSpecifiedError":
                    var dataTypeNotSpecifiedError = poco as Kalliope.Core.DataTypeNotSpecifiedError;
                    dataTypeNotSpecifiedError.UpdateReferenceProperties((Kalliope.DTO.DataTypeNotSpecifiedError)dto, cache);
                    break;
                case "DataTypeRef":
                    var dataTypeRef = poco as Kalliope.Core.DataTypeRef;
                    dataTypeRef.UpdateReferenceProperties((Kalliope.DTO.DataTypeRef)dto, cache);
                    break;
                case "DateAndTimeTemporalDataType":
                    var dateAndTimeTemporalDataType = poco as Kalliope.Core.DateAndTimeTemporalDataType;
                    dateAndTimeTemporalDataType.UpdateReferenceProperties((Kalliope.DTO.DateAndTimeTemporalDataType)dto, cache);
                    break;
                case "DateTemporalDataType":
                    var dateTemporalDataType = poco as Kalliope.Core.DateTemporalDataType;
                    dateTemporalDataType.UpdateReferenceProperties((Kalliope.DTO.DateTemporalDataType)dto, cache);
                    break;
                case "DecimalNumericDataType":
                    var decimalNumericDataType = poco as Kalliope.Core.DecimalNumericDataType;
                    decimalNumericDataType.UpdateReferenceProperties((Kalliope.DTO.DecimalNumericDataType)dto, cache);
                    break;
                case "Definition":
                    var definition = poco as Kalliope.Core.Definition;
                    definition.UpdateReferenceProperties((Kalliope.DTO.Definition)dto, cache);
                    break;
                case "DerivationNote":
                    var derivationNote = poco as Kalliope.Core.DerivationNote;
                    derivationNote.UpdateReferenceProperties((Kalliope.DTO.DerivationNote)dto, cache);
                    break;
                case "DerivedRoleRequiresCompatibleProjectionError":
                    var derivedRoleRequiresCompatibleProjectionError = poco as Kalliope.Core.DerivedRoleRequiresCompatibleProjectionError;
                    derivedRoleRequiresCompatibleProjectionError.UpdateReferenceProperties((Kalliope.DTO.DerivedRoleRequiresCompatibleProjectionError)dto, cache);
                    break;
                case "DoublePrecisionFloatingPointNumericDataType":
                    var doublePrecisionFloatingPointNumericDataType = poco as Kalliope.Core.DoublePrecisionFloatingPointNumericDataType;
                    doublePrecisionFloatingPointNumericDataType.UpdateReferenceProperties((Kalliope.DTO.DoublePrecisionFloatingPointNumericDataType)dto, cache);
                    break;
                case "DuplicateReadingSignatureError":
                    var duplicateReadingSignatureError = poco as Kalliope.Core.DuplicateReadingSignatureError;
                    duplicateReadingSignatureError.UpdateReferenceProperties((Kalliope.DTO.DuplicateReadingSignatureError)dto, cache);
                    break;
                case "ElementGrouping":
                    var elementGrouping = poco as Kalliope.Core.ElementGrouping;
                    elementGrouping.UpdateReferenceProperties((Kalliope.DTO.ElementGrouping)dto, cache);
                    break;
                case "ElementGroupingMembershipContradictionError":
                    var elementGroupingMembershipContradictionError = poco as Kalliope.Core.ElementGroupingMembershipContradictionError;
                    elementGroupingMembershipContradictionError.UpdateReferenceProperties((Kalliope.DTO.ElementGroupingMembershipContradictionError)dto, cache);
                    break;
                case "ElementGroupingSet":
                    var elementGroupingSet = poco as Kalliope.Core.ElementGroupingSet;
                    elementGroupingSet.UpdateReferenceProperties((Kalliope.DTO.ElementGroupingSet)dto, cache);
                    break;
                case "EntityType":
                    var entityType = poco as Kalliope.Core.EntityType;
                    entityType.UpdateReferenceProperties((Kalliope.DTO.EntityType)dto, cache);
                    break;
                case "EntityTypeInstance":
                    var entityTypeInstance = poco as Kalliope.Core.EntityTypeInstance;
                    entityTypeInstance.UpdateReferenceProperties((Kalliope.DTO.EntityTypeInstance)dto, cache);
                    break;
                case "EntityTypeRequiresReferenceSchemeError":
                    var entityTypeRequiresReferenceSchemeError = poco as Kalliope.Core.EntityTypeRequiresReferenceSchemeError;
                    entityTypeRequiresReferenceSchemeError.UpdateReferenceProperties((Kalliope.DTO.EntityTypeRequiresReferenceSchemeError)dto, cache);
                    break;
                case "EntityTypeSubtypeInstance":
                    var entityTypeSubtypeInstance = poco as Kalliope.Core.EntityTypeSubtypeInstance;
                    entityTypeSubtypeInstance.UpdateReferenceProperties((Kalliope.DTO.EntityTypeSubtypeInstance)dto, cache);
                    break;
                case "EqualityConstraint":
                    var equalityConstraint = poco as Kalliope.Core.EqualityConstraint;
                    equalityConstraint.UpdateReferenceProperties((Kalliope.DTO.EqualityConstraint)dto, cache);
                    break;
                case "EqualityOrSubsetImpliedByMandatoryError":
                    var equalityOrSubsetImpliedByMandatoryError = poco as Kalliope.Core.EqualityOrSubsetImpliedByMandatoryError;
                    equalityOrSubsetImpliedByMandatoryError.UpdateReferenceProperties((Kalliope.DTO.EqualityOrSubsetImpliedByMandatoryError)dto, cache);
                    break;
                case "ExclusionConstraint":
                    var exclusionConstraint = poco as Kalliope.Core.ExclusionConstraint;
                    exclusionConstraint.UpdateReferenceProperties((Kalliope.DTO.ExclusionConstraint)dto, cache);
                    break;
                case "ExclusionContradictsEqualityError":
                    var exclusionContradictsEqualityError = poco as Kalliope.Core.ExclusionContradictsEqualityError;
                    exclusionContradictsEqualityError.UpdateReferenceProperties((Kalliope.DTO.ExclusionContradictsEqualityError)dto, cache);
                    break;
                case "ExclusionContradictsMandatoryError":
                    var exclusionContradictsMandatoryError = poco as Kalliope.Core.ExclusionContradictsMandatoryError;
                    exclusionContradictsMandatoryError.UpdateReferenceProperties((Kalliope.DTO.ExclusionContradictsMandatoryError)dto, cache);
                    break;
                case "ExclusionContradictsSubsetError":
                    var exclusionContradictsSubsetError = poco as Kalliope.Core.ExclusionContradictsSubsetError;
                    exclusionContradictsSubsetError.UpdateReferenceProperties((Kalliope.DTO.ExclusionContradictsSubsetError)dto, cache);
                    break;
                case "ExternalConstraintRoleSequenceArityMismatchError":
                    var externalConstraintRoleSequenceArityMismatchError = poco as Kalliope.Core.ExternalConstraintRoleSequenceArityMismatchError;
                    externalConstraintRoleSequenceArityMismatchError.UpdateReferenceProperties((Kalliope.DTO.ExternalConstraintRoleSequenceArityMismatchError)dto, cache);
                    break;
                case "ExternalConstraintShape":
                    var externalConstraintShape = poco as Kalliope.Diagrams.ExternalConstraintShape;
                    externalConstraintShape.UpdateReferenceProperties((Kalliope.DTO.ExternalConstraintShape)dto, cache);
                    break;
                case "FactType":
                    var factType = poco as Kalliope.Core.FactType;
                    factType.UpdateReferenceProperties((Kalliope.DTO.FactType)dto, cache);
                    break;
                case "FactTypeDerivationExpression":
                    var factTypeDerivationExpression = poco as Kalliope.Core.FactTypeDerivationExpression;
                    factTypeDerivationExpression.UpdateReferenceProperties((Kalliope.DTO.FactTypeDerivationExpression)dto, cache);
                    break;
                case "FactTypeDerivationPath":
                    var factTypeDerivationPath = poco as Kalliope.Core.FactTypeDerivationPath;
                    factTypeDerivationPath.UpdateReferenceProperties((Kalliope.DTO.FactTypeDerivationPath)dto, cache);
                    break;
                case "FactTypeDerivationRule":
                    var factTypeDerivationRule = poco as Kalliope.Core.FactTypeDerivationRule;
                    factTypeDerivationRule.UpdateReferenceProperties((Kalliope.DTO.FactTypeDerivationRule)dto, cache);
                    break;
                case "FactTypeInstance":
                    var factTypeInstance = poco as Kalliope.Core.FactTypeInstance;
                    factTypeInstance.UpdateReferenceProperties((Kalliope.DTO.FactTypeInstance)dto, cache);
                    break;
                case "FactTypeLinkConnectorShape":
                    var factTypeLinkConnectorShape = poco as Kalliope.Diagrams.FactTypeLinkConnectorShape;
                    factTypeLinkConnectorShape.UpdateReferenceProperties((Kalliope.DTO.FactTypeLinkConnectorShape)dto, cache);
                    break;
                case "FactTypeRequiresInternalUniquenessConstraintError":
                    var factTypeRequiresInternalUniquenessConstraintError = poco as Kalliope.Core.FactTypeRequiresInternalUniquenessConstraintError;
                    factTypeRequiresInternalUniquenessConstraintError.UpdateReferenceProperties((Kalliope.DTO.FactTypeRequiresInternalUniquenessConstraintError)dto, cache);
                    break;
                case "FactTypeRequiresReadingError":
                    var factTypeRequiresReadingError = poco as Kalliope.Core.FactTypeRequiresReadingError;
                    factTypeRequiresReadingError.UpdateReferenceProperties((Kalliope.DTO.FactTypeRequiresReadingError)dto, cache);
                    break;
                case "FactTypeShape":
                    var factTypeShape = poco as Kalliope.Diagrams.FactTypeShape;
                    factTypeShape.UpdateReferenceProperties((Kalliope.DTO.FactTypeShape)dto, cache);
                    break;
                case "FixedLengthRawDataDataType":
                    var fixedLengthRawDataDataType = poco as Kalliope.Core.FixedLengthRawDataDataType;
                    fixedLengthRawDataDataType.UpdateReferenceProperties((Kalliope.DTO.FixedLengthRawDataDataType)dto, cache);
                    break;
                case "FixedLengthTextDataType":
                    var fixedLengthTextDataType = poco as Kalliope.Core.FixedLengthTextDataType;
                    fixedLengthTextDataType.UpdateReferenceProperties((Kalliope.DTO.FixedLengthTextDataType)dto, cache);
                    break;
                case "FloatingPointNumericDataType":
                    var floatingPointNumericDataType = poco as Kalliope.Core.FloatingPointNumericDataType;
                    floatingPointNumericDataType.UpdateReferenceProperties((Kalliope.DTO.FloatingPointNumericDataType)dto, cache);
                    break;
                case "FrequencyConstraint":
                    var frequencyConstraint = poco as Kalliope.Core.FrequencyConstraint;
                    frequencyConstraint.UpdateReferenceProperties((Kalliope.DTO.FrequencyConstraint)dto, cache);
                    break;
                case "FrequencyConstraintExactlyOneError":
                    var frequencyConstraintExactlyOneError = poco as Kalliope.Core.FrequencyConstraintExactlyOneError;
                    frequencyConstraintExactlyOneError.UpdateReferenceProperties((Kalliope.DTO.FrequencyConstraintExactlyOneError)dto, cache);
                    break;
                case "FrequencyConstraintMinMaxError":
                    var frequencyConstraintMinMaxError = poco as Kalliope.Core.FrequencyConstraintMinMaxError;
                    frequencyConstraintMinMaxError.UpdateReferenceProperties((Kalliope.DTO.FrequencyConstraintMinMaxError)dto, cache);
                    break;
                case "FrequencyConstraintNonRestrictiveRangeError":
                    var frequencyConstraintNonRestrictiveRangeError = poco as Kalliope.Core.FrequencyConstraintNonRestrictiveRangeError;
                    frequencyConstraintNonRestrictiveRangeError.UpdateReferenceProperties((Kalliope.DTO.FrequencyConstraintNonRestrictiveRangeError)dto, cache);
                    break;
                case "FrequencyConstraintShape":
                    var frequencyConstraintShape = poco as Kalliope.Diagrams.FrequencyConstraintShape;
                    frequencyConstraintShape.UpdateReferenceProperties((Kalliope.DTO.FrequencyConstraintShape)dto, cache);
                    break;
                case "FrequencyConstraintViolatedByUniquenessConstraintError":
                    var frequencyConstraintViolatedByUniquenessConstraintError = poco as Kalliope.Core.FrequencyConstraintViolatedByUniquenessConstraintError;
                    frequencyConstraintViolatedByUniquenessConstraintError.UpdateReferenceProperties((Kalliope.DTO.FrequencyConstraintViolatedByUniquenessConstraintError)dto, cache);
                    break;
                case "Function":
                    var function = poco as Kalliope.Core.Function;
                    function.UpdateReferenceProperties((Kalliope.DTO.Function)dto, cache);
                    break;
                case "FunctionDuplicateNameError":
                    var functionDuplicateNameError = poco as Kalliope.Core.FunctionDuplicateNameError;
                    functionDuplicateNameError.UpdateReferenceProperties((Kalliope.DTO.FunctionDuplicateNameError)dto, cache);
                    break;
                case "FunctionParameter":
                    var functionParameter = poco as Kalliope.Core.FunctionParameter;
                    functionParameter.UpdateReferenceProperties((Kalliope.DTO.FunctionParameter)dto, cache);
                    break;
                case "GenerationState":
                    var generationState = poco as Kalliope.Core.GenerationState;
                    generationState.UpdateReferenceProperties((Kalliope.DTO.GenerationState)dto, cache);
                    break;
                case "Group":
                    var group = poco as Kalliope.Core.Group;
                    group.UpdateReferenceProperties((Kalliope.DTO.Group)dto, cache);
                    break;
                case "ImplicationError":
                    var implicationError = poco as Kalliope.Core.ImplicationError;
                    implicationError.UpdateReferenceProperties((Kalliope.DTO.ImplicationError)dto, cache);
                    break;
                case "ImpliedFactType":
                    var impliedFactType = poco as Kalliope.Core.ImpliedFactType;
                    impliedFactType.UpdateReferenceProperties((Kalliope.DTO.ImpliedFactType)dto, cache);
                    break;
                case "ImpliedInternalUniquenessConstraintError":
                    var impliedInternalUniquenessConstraintError = poco as Kalliope.Core.ImpliedInternalUniquenessConstraintError;
                    impliedInternalUniquenessConstraintError.UpdateReferenceProperties((Kalliope.DTO.ImpliedInternalUniquenessConstraintError)dto, cache);
                    break;
                case "InformalDerivationRule":
                    var informalDerivationRule = poco as Kalliope.Core.InformalDerivationRule;
                    informalDerivationRule.UpdateReferenceProperties((Kalliope.DTO.InformalDerivationRule)dto, cache);
                    break;
                case "IntrinsicReferenceMode":
                    var intrinsicReferenceMode = poco as Kalliope.Core.IntrinsicReferenceMode;
                    intrinsicReferenceMode.UpdateReferenceProperties((Kalliope.DTO.IntrinsicReferenceMode)dto, cache);
                    break;
                case "JoinedPathRoleRequiresCompatibleRolePlayerError":
                    var joinedPathRoleRequiresCompatibleRolePlayerError = poco as Kalliope.Core.JoinedPathRoleRequiresCompatibleRolePlayerError;
                    joinedPathRoleRequiresCompatibleRolePlayerError.UpdateReferenceProperties((Kalliope.DTO.JoinedPathRoleRequiresCompatibleRolePlayerError)dto, cache);
                    break;
                case "JoinPathRequiredError":
                    var joinPathRequiredError = poco as Kalliope.Core.JoinPathRequiredError;
                    joinPathRequiredError.UpdateReferenceProperties((Kalliope.DTO.JoinPathRequiredError)dto, cache);
                    break;
                case "LargeLengthRawDataDataType":
                    var largeLengthRawDataDataType = poco as Kalliope.Core.LargeLengthRawDataDataType;
                    largeLengthRawDataDataType.UpdateReferenceProperties((Kalliope.DTO.LargeLengthRawDataDataType)dto, cache);
                    break;
                case "LargeLengthTextDataType":
                    var largeLengthTextDataType = poco as Kalliope.Core.LargeLengthTextDataType;
                    largeLengthTextDataType.UpdateReferenceProperties((Kalliope.DTO.LargeLengthTextDataType)dto, cache);
                    break;
                case "LeadRolePath":
                    var leadRolePath = poco as Kalliope.Core.LeadRolePath;
                    leadRolePath.UpdateReferenceProperties((Kalliope.DTO.LeadRolePath)dto, cache);
                    break;
                case "LinkConnectorShape":
                    var linkConnectorShape = poco as Kalliope.Diagrams.LinkConnectorShape;
                    linkConnectorShape.UpdateReferenceProperties((Kalliope.DTO.LinkConnectorShape)dto, cache);
                    break;
                case "MandatoryConstraint":
                    var mandatoryConstraint = poco as Kalliope.Core.MandatoryConstraint;
                    mandatoryConstraint.UpdateReferenceProperties((Kalliope.DTO.MandatoryConstraint)dto, cache);
                    break;
                case "MaxValueMismatchError":
                    var maxValueMismatchError = poco as Kalliope.Core.MaxValueMismatchError;
                    maxValueMismatchError.UpdateReferenceProperties((Kalliope.DTO.MaxValueMismatchError)dto, cache);
                    break;
                case "MinValueMismatchError":
                    var minValueMismatchError = poco as Kalliope.Core.MinValueMismatchError;
                    minValueMismatchError.UpdateReferenceProperties((Kalliope.DTO.MinValueMismatchError)dto, cache);
                    break;
                case "ModelNote":
                    var modelNote = poco as Kalliope.Core.ModelNote;
                    modelNote.UpdateReferenceProperties((Kalliope.DTO.ModelNote)dto, cache);
                    break;
                case "ModelNoteShape":
                    var modelNoteShape = poco as Kalliope.Diagrams.ModelNoteShape;
                    modelNoteShape.UpdateReferenceProperties((Kalliope.DTO.ModelNoteShape)dto, cache);
                    break;
                case "MoneyNumericDataType":
                    var moneyNumericDataType = poco as Kalliope.Core.MoneyNumericDataType;
                    moneyNumericDataType.UpdateReferenceProperties((Kalliope.DTO.MoneyNumericDataType)dto, cache);
                    break;
                case "NameAlias":
                    var nameAlias = poco as Kalliope.Core.NameAlias;
                    nameAlias.UpdateReferenceProperties((Kalliope.DTO.NameAlias)dto, cache);
                    break;
                case "NameConsumer":
                    var nameConsumer = poco as Kalliope.Core.NameConsumer;
                    nameConsumer.UpdateReferenceProperties((Kalliope.DTO.NameConsumer)dto, cache);
                    break;
                case "NameGenerator":
                    var nameGenerator = poco as Kalliope.Core.NameGenerator;
                    nameGenerator.UpdateReferenceProperties((Kalliope.DTO.NameGenerator)dto, cache);
                    break;
                case "NMinusOneError":
                    var nMinusOneError = poco as Kalliope.Core.NMinusOneError;
                    nMinusOneError.UpdateReferenceProperties((Kalliope.DTO.NMinusOneError)dto, cache);
                    break;
                case "Note":
                    var note = poco as Kalliope.Core.Note;
                    note.UpdateReferenceProperties((Kalliope.DTO.Note)dto, cache);
                    break;
                case "NotWellModeledSubsetAndMandatoryError":
                    var notWellModeledSubsetAndMandatoryError = poco as Kalliope.Core.NotWellModeledSubsetAndMandatoryError;
                    notWellModeledSubsetAndMandatoryError.UpdateReferenceProperties((Kalliope.DTO.NotWellModeledSubsetAndMandatoryError)dto, cache);
                    break;
                case "ObjectIdOtherDataType":
                    var objectIdOtherDataType = poco as Kalliope.Core.ObjectIdOtherDataType;
                    objectIdOtherDataType.UpdateReferenceProperties((Kalliope.DTO.ObjectIdOtherDataType)dto, cache);
                    break;
                case "Objectification":
                    var objectification = poco as Kalliope.Core.Objectification;
                    objectification.UpdateReferenceProperties((Kalliope.DTO.Objectification)dto, cache);
                    break;
                case "ObjectifiedInstanceRequiredError":
                    var objectifiedInstanceRequiredError = poco as Kalliope.Core.ObjectifiedInstanceRequiredError;
                    objectifiedInstanceRequiredError.UpdateReferenceProperties((Kalliope.DTO.ObjectifiedInstanceRequiredError)dto, cache);
                    break;
                case "ObjectifiedType":
                    var objectifiedType = poco as Kalliope.Core.ObjectifiedType;
                    objectifiedType.UpdateReferenceProperties((Kalliope.DTO.ObjectifiedType)dto, cache);
                    break;
                case "ObjectifiedUnaryRole":
                    var objectifiedUnaryRole = poco as Kalliope.Core.ObjectifiedUnaryRole;
                    objectifiedUnaryRole.UpdateReferenceProperties((Kalliope.DTO.ObjectifiedUnaryRole)dto, cache);
                    break;
                case "ObjectifyingInstanceRequiredError":
                    var objectifyingInstanceRequiredError = poco as Kalliope.Core.ObjectifyingInstanceRequiredError;
                    objectifyingInstanceRequiredError.UpdateReferenceProperties((Kalliope.DTO.ObjectifyingInstanceRequiredError)dto, cache);
                    break;
                case "ObjectTypeCardinalityConstraint":
                    var objectTypeCardinalityConstraint = poco as Kalliope.Core.ObjectTypeCardinalityConstraint;
                    objectTypeCardinalityConstraint.UpdateReferenceProperties((Kalliope.DTO.ObjectTypeCardinalityConstraint)dto, cache);
                    break;
                case "ObjectTypeDuplicateNameError":
                    var objectTypeDuplicateNameError = poco as Kalliope.Core.ObjectTypeDuplicateNameError;
                    objectTypeDuplicateNameError.UpdateReferenceProperties((Kalliope.DTO.ObjectTypeDuplicateNameError)dto, cache);
                    break;
                case "ObjectTypeShape":
                    var objectTypeShape = poco as Kalliope.Diagrams.ObjectTypeShape;
                    objectTypeShape.UpdateReferenceProperties((Kalliope.DTO.ObjectTypeShape)dto, cache);
                    break;
                case "OleObjectRawDataDataType":
                    var oleObjectRawDataDataType = poco as Kalliope.Core.OleObjectRawDataDataType;
                    oleObjectRawDataDataType.UpdateReferenceProperties((Kalliope.DTO.OleObjectRawDataDataType)dto, cache);
                    break;
                case "OrmDiagram":
                    var ormDiagram = poco as Kalliope.Diagrams.OrmDiagram;
                    ormDiagram.UpdateReferenceProperties((Kalliope.DTO.OrmDiagram)dto, cache);
                    break;
                case "OrmModel":
                    var ormModel = poco as Kalliope.Core.OrmModel;
                    ormModel.UpdateReferenceProperties((Kalliope.DTO.OrmModel)dto, cache);
                    break;
                case "OrmRoot":
                    var ormRoot = poco as Kalliope.OrmRoot;
                    ormRoot.UpdateReferenceProperties((Kalliope.DTO.OrmRoot)dto, cache);
                    break;
                case "PartialConstraintRoleSequenceJoinPathProjectionError":
                    var partialConstraintRoleSequenceJoinPathProjectionError = poco as Kalliope.Core.PartialConstraintRoleSequenceJoinPathProjectionError;
                    partialConstraintRoleSequenceJoinPathProjectionError.UpdateReferenceProperties((Kalliope.DTO.PartialConstraintRoleSequenceJoinPathProjectionError)dto, cache);
                    break;
                case "PartialRoleSetDerivationProjectionError":
                    var partialRoleSetDerivationProjectionError = poco as Kalliope.Core.PartialRoleSetDerivationProjectionError;
                    partialRoleSetDerivationProjectionError.UpdateReferenceProperties((Kalliope.DTO.PartialRoleSetDerivationProjectionError)dto, cache);
                    break;
                case "PathConditionRoleValueConstraint":
                    var pathConditionRoleValueConstraint = poco as Kalliope.Core.PathConditionRoleValueConstraint;
                    pathConditionRoleValueConstraint.UpdateReferenceProperties((Kalliope.DTO.PathConditionRoleValueConstraint)dto, cache);
                    break;
                case "PathConditionRootValueConstraint":
                    var pathConditionRootValueConstraint = poco as Kalliope.Core.PathConditionRootValueConstraint;
                    pathConditionRootValueConstraint.UpdateReferenceProperties((Kalliope.DTO.PathConditionRootValueConstraint)dto, cache);
                    break;
                case "PathConstant":
                    var pathConstant = poco as Kalliope.Core.PathConstant;
                    pathConstant.UpdateReferenceProperties((Kalliope.DTO.PathConstant)dto, cache);
                    break;
                case "PathObjectUnifier":
                    var pathObjectUnifier = poco as Kalliope.Core.PathObjectUnifier;
                    pathObjectUnifier.UpdateReferenceProperties((Kalliope.DTO.PathObjectUnifier)dto, cache);
                    break;
                case "PathObjectUnifierRequiresCompatibleObjectTypesError":
                    var pathObjectUnifierRequiresCompatibleObjectTypesError = poco as Kalliope.Core.PathObjectUnifierRequiresCompatibleObjectTypesError;
                    pathObjectUnifierRequiresCompatibleObjectTypesError.UpdateReferenceProperties((Kalliope.DTO.PathObjectUnifierRequiresCompatibleObjectTypesError)dto, cache);
                    break;
                case "PathOuterJoinRequiresOptionalRoleError":
                    var pathOuterJoinRequiresOptionalRoleError = poco as Kalliope.Core.PathOuterJoinRequiresOptionalRoleError;
                    pathOuterJoinRequiresOptionalRoleError.UpdateReferenceProperties((Kalliope.DTO.PathOuterJoinRequiresOptionalRoleError)dto, cache);
                    break;
                case "PathRequiresRootObjectTypeError":
                    var pathRequiresRootObjectTypeError = poco as Kalliope.Core.PathRequiresRootObjectTypeError;
                    pathRequiresRootObjectTypeError.UpdateReferenceProperties((Kalliope.DTO.PathRequiresRootObjectTypeError)dto, cache);
                    break;
                case "PathSameFactTypeRoleFollowsJoinError":
                    var pathSameFactTypeRoleFollowsJoinError = poco as Kalliope.Core.PathSameFactTypeRoleFollowsJoinError;
                    pathSameFactTypeRoleFollowsJoinError.UpdateReferenceProperties((Kalliope.DTO.PathSameFactTypeRoleFollowsJoinError)dto, cache);
                    break;
                case "PictureRawDataDataType":
                    var pictureRawDataDataType = poco as Kalliope.Core.PictureRawDataDataType;
                    pictureRawDataDataType.UpdateReferenceProperties((Kalliope.DTO.PictureRawDataDataType)dto, cache);
                    break;
                case "PopulationMandatoryError":
                    var populationMandatoryError = poco as Kalliope.Core.PopulationMandatoryError;
                    populationMandatoryError.UpdateReferenceProperties((Kalliope.DTO.PopulationMandatoryError)dto, cache);
                    break;
                case "PopulationUniquenessError":
                    var populationUniquenessError = poco as Kalliope.Core.PopulationUniquenessError;
                    populationUniquenessError.UpdateReferenceProperties((Kalliope.DTO.PopulationUniquenessError)dto, cache);
                    break;
                case "PreferredIdentifierRequiresMandatoryError":
                    var preferredIdentifierRequiresMandatoryError = poco as Kalliope.Core.PreferredIdentifierRequiresMandatoryError;
                    preferredIdentifierRequiresMandatoryError.UpdateReferenceProperties((Kalliope.DTO.PreferredIdentifierRequiresMandatoryError)dto, cache);
                    break;
                case "QueryDerivationRule":
                    var queryDerivationRule = poco as Kalliope.Core.QueryDerivationRule;
                    queryDerivationRule.UpdateReferenceProperties((Kalliope.DTO.QueryDerivationRule)dto, cache);
                    break;
                case "QueryParameter":
                    var queryParameter = poco as Kalliope.Core.QueryParameter;
                    queryParameter.UpdateReferenceProperties((Kalliope.DTO.QueryParameter)dto, cache);
                    break;
                case "Reading":
                    var reading = poco as Kalliope.Core.Reading;
                    reading.UpdateReferenceProperties((Kalliope.DTO.Reading)dto, cache);
                    break;
                case "ReadingOrder":
                    var readingOrder = poco as Kalliope.Core.ReadingOrder;
                    readingOrder.UpdateReferenceProperties((Kalliope.DTO.ReadingOrder)dto, cache);
                    break;
                case "ReadingRequiresUserModificationError":
                    var readingRequiresUserModificationError = poco as Kalliope.Core.ReadingRequiresUserModificationError;
                    readingRequiresUserModificationError.UpdateReferenceProperties((Kalliope.DTO.ReadingRequiresUserModificationError)dto, cache);
                    break;
                case "ReadingShape":
                    var readingShape = poco as Kalliope.Diagrams.ReadingShape;
                    readingShape.UpdateReferenceProperties((Kalliope.DTO.ReadingShape)dto, cache);
                    break;
                case "RecognizedPhrase":
                    var recognizedPhrase = poco as Kalliope.Core.RecognizedPhrase;
                    recognizedPhrase.UpdateReferenceProperties((Kalliope.DTO.RecognizedPhrase)dto, cache);
                    break;
                case "RecognizedPhraseDuplicateNameError":
                    var recognizedPhraseDuplicateNameError = poco as Kalliope.Core.RecognizedPhraseDuplicateNameError;
                    recognizedPhraseDuplicateNameError.UpdateReferenceProperties((Kalliope.DTO.RecognizedPhraseDuplicateNameError)dto, cache);
                    break;
                case "ReferenceModeKind":
                    var referenceModeKind = poco as Kalliope.Core.ReferenceModeKind;
                    referenceModeKind.UpdateReferenceProperties((Kalliope.DTO.ReferenceModeKind)dto, cache);
                    break;
                case "RingConstraint":
                    var ringConstraint = poco as Kalliope.Core.RingConstraint;
                    ringConstraint.UpdateReferenceProperties((Kalliope.DTO.RingConstraint)dto, cache);
                    break;
                case "RingConstraintShape":
                    var ringConstraintShape = poco as Kalliope.Diagrams.RingConstraintShape;
                    ringConstraintShape.UpdateReferenceProperties((Kalliope.DTO.RingConstraintShape)dto, cache);
                    break;
                case "RingConstraintTypeNotSpecifiedError":
                    var ringConstraintTypeNotSpecifiedError = poco as Kalliope.Core.RingConstraintTypeNotSpecifiedError;
                    ringConstraintTypeNotSpecifiedError.UpdateReferenceProperties((Kalliope.DTO.RingConstraintTypeNotSpecifiedError)dto, cache);
                    break;
                case "Role":
                    var role = poco as Kalliope.Core.Role;
                    role.UpdateReferenceProperties((Kalliope.DTO.Role)dto, cache);
                    break;
                case "RoleNameShape":
                    var roleNameShape = poco as Kalliope.Diagrams.RoleNameShape;
                    roleNameShape.UpdateReferenceProperties((Kalliope.DTO.RoleNameShape)dto, cache);
                    break;
                case "RolePlayerRequiredError":
                    var rolePlayerRequiredError = poco as Kalliope.Core.RolePlayerRequiredError;
                    rolePlayerRequiredError.UpdateReferenceProperties((Kalliope.DTO.RolePlayerRequiredError)dto, cache);
                    break;
                case "RoleProjectedDerivationRequiresProjectionError":
                    var roleProjectedDerivationRequiresProjectionError = poco as Kalliope.Core.RoleProjectedDerivationRequiresProjectionError;
                    roleProjectedDerivationRequiresProjectionError.UpdateReferenceProperties((Kalliope.DTO.RoleProjectedDerivationRequiresProjectionError)dto, cache);
                    break;
                case "RoleProxy":
                    var roleProxy = poco as Kalliope.Core.RoleProxy;
                    roleProxy.UpdateReferenceProperties((Kalliope.DTO.RoleProxy)dto, cache);
                    break;
                case "RoleSubPath":
                    var roleSubPath = poco as Kalliope.Core.RoleSubPath;
                    roleSubPath.UpdateReferenceProperties((Kalliope.DTO.RoleSubPath)dto, cache);
                    break;
                case "RoleText":
                    var roleText = poco as Kalliope.Core.RoleText;
                    roleText.UpdateReferenceProperties((Kalliope.DTO.RoleText)dto, cache);
                    break;
                case "RoleValueConstraint":
                    var roleValueConstraint = poco as Kalliope.Core.RoleValueConstraint;
                    roleValueConstraint.UpdateReferenceProperties((Kalliope.DTO.RoleValueConstraint)dto, cache);
                    break;
                case "RowIdOtherDataType":
                    var rowIdOtherDataType = poco as Kalliope.Core.RowIdOtherDataType;
                    rowIdOtherDataType.UpdateReferenceProperties((Kalliope.DTO.RowIdOtherDataType)dto, cache);
                    break;
                case "SetComparisonConstraintRoleSequence":
                    var setComparisonConstraintRoleSequence = poco as Kalliope.Core.SetComparisonConstraintRoleSequence;
                    setComparisonConstraintRoleSequence.UpdateReferenceProperties((Kalliope.DTO.SetComparisonConstraintRoleSequence)dto, cache);
                    break;
                case "SignedIntegerNumericDataType":
                    var signedIntegerNumericDataType = poco as Kalliope.Core.SignedIntegerNumericDataType;
                    signedIntegerNumericDataType.UpdateReferenceProperties((Kalliope.DTO.SignedIntegerNumericDataType)dto, cache);
                    break;
                case "SignedLargeIntegerNumericDataType":
                    var signedLargeIntegerNumericDataType = poco as Kalliope.Core.SignedLargeIntegerNumericDataType;
                    signedLargeIntegerNumericDataType.UpdateReferenceProperties((Kalliope.DTO.SignedLargeIntegerNumericDataType)dto, cache);
                    break;
                case "SignedSmallIntegerNumericDataType":
                    var signedSmallIntegerNumericDataType = poco as Kalliope.Core.SignedSmallIntegerNumericDataType;
                    signedSmallIntegerNumericDataType.UpdateReferenceProperties((Kalliope.DTO.SignedSmallIntegerNumericDataType)dto, cache);
                    break;
                case "SinglePrecisionFloatingPointNumericDataType":
                    var singlePrecisionFloatingPointNumericDataType = poco as Kalliope.Core.SinglePrecisionFloatingPointNumericDataType;
                    singlePrecisionFloatingPointNumericDataType.UpdateReferenceProperties((Kalliope.DTO.SinglePrecisionFloatingPointNumericDataType)dto, cache);
                    break;
                case "Subquery":
                    var subquery = poco as Kalliope.Core.Subquery;
                    subquery.UpdateReferenceProperties((Kalliope.DTO.Subquery)dto, cache);
                    break;
                case "SubsetConstraint":
                    var subsetConstraint = poco as Kalliope.Core.SubsetConstraint;
                    subsetConstraint.UpdateReferenceProperties((Kalliope.DTO.SubsetConstraint)dto, cache);
                    break;
                case "SubtypeDerivationExpression":
                    var subtypeDerivationExpression = poco as Kalliope.Core.SubtypeDerivationExpression;
                    subtypeDerivationExpression.UpdateReferenceProperties((Kalliope.DTO.SubtypeDerivationExpression)dto, cache);
                    break;
                case "SubtypeDerivationPath":
                    var subtypeDerivationPath = poco as Kalliope.Core.SubtypeDerivationPath;
                    subtypeDerivationPath.UpdateReferenceProperties((Kalliope.DTO.SubtypeDerivationPath)dto, cache);
                    break;
                case "SubtypeDerivationRule":
                    var subtypeDerivationRule = poco as Kalliope.Core.SubtypeDerivationRule;
                    subtypeDerivationRule.UpdateReferenceProperties((Kalliope.DTO.SubtypeDerivationRule)dto, cache);
                    break;
                case "SubtypeFact":
                    var subtypeFact = poco as Kalliope.Core.SubtypeFact;
                    subtypeFact.UpdateReferenceProperties((Kalliope.DTO.SubtypeFact)dto, cache);
                    break;
                case "SubtypeLink":
                    var subtypeLink = poco as Kalliope.Diagrams.SubtypeLink;
                    subtypeLink.UpdateReferenceProperties((Kalliope.DTO.SubtypeLink)dto, cache);
                    break;
                case "SubtypeMetaRole":
                    var subtypeMetaRole = poco as Kalliope.Core.SubtypeMetaRole;
                    subtypeMetaRole.UpdateReferenceProperties((Kalliope.DTO.SubtypeMetaRole)dto, cache);
                    break;
                case "SupersetRoleOfSubtypeSubsetConstraintNotSubtypeError":
                    var supersetRoleOfSubtypeSubsetConstraintNotSubtypeError = poco as Kalliope.Core.SupersetRoleOfSubtypeSubsetConstraintNotSubtypeError;
                    supersetRoleOfSubtypeSubsetConstraintNotSubtypeError.UpdateReferenceProperties((Kalliope.DTO.SupersetRoleOfSubtypeSubsetConstraintNotSubtypeError)dto, cache);
                    break;
                case "SupertypeMetaRole":
                    var supertypeMetaRole = poco as Kalliope.Core.SupertypeMetaRole;
                    supertypeMetaRole.UpdateReferenceProperties((Kalliope.DTO.SupertypeMetaRole)dto, cache);
                    break;
                case "TimeTemporalDataType":
                    var timeTemporalDataType = poco as Kalliope.Core.TimeTemporalDataType;
                    timeTemporalDataType.UpdateReferenceProperties((Kalliope.DTO.TimeTemporalDataType)dto, cache);
                    break;
                case "TooFewEntityTypeRoleInstancesError":
                    var tooFewEntityTypeRoleInstancesError = poco as Kalliope.Core.TooFewEntityTypeRoleInstancesError;
                    tooFewEntityTypeRoleInstancesError.UpdateReferenceProperties((Kalliope.DTO.TooFewEntityTypeRoleInstancesError)dto, cache);
                    break;
                case "TooFewFactTypeRoleInstancesError":
                    var tooFewFactTypeRoleInstancesError = poco as Kalliope.Core.TooFewFactTypeRoleInstancesError;
                    tooFewFactTypeRoleInstancesError.UpdateReferenceProperties((Kalliope.DTO.TooFewFactTypeRoleInstancesError)dto, cache);
                    break;
                case "TooFewReadingRolesError":
                    var tooFewReadingRolesError = poco as Kalliope.Core.TooFewReadingRolesError;
                    tooFewReadingRolesError.UpdateReferenceProperties((Kalliope.DTO.TooFewReadingRolesError)dto, cache);
                    break;
                case "TooFewRoleSequencesError":
                    var tooFewRoleSequencesError = poco as Kalliope.Core.TooFewRoleSequencesError;
                    tooFewRoleSequencesError.UpdateReferenceProperties((Kalliope.DTO.TooFewRoleSequencesError)dto, cache);
                    break;
                case "TooManyReadingRolesError":
                    var tooManyReadingRolesError = poco as Kalliope.Core.TooManyReadingRolesError;
                    tooManyReadingRolesError.UpdateReferenceProperties((Kalliope.DTO.TooManyReadingRolesError)dto, cache);
                    break;
                case "TooManyRoleSequencesError":
                    var tooManyRoleSequencesError = poco as Kalliope.Core.TooManyRoleSequencesError;
                    tooManyRoleSequencesError.UpdateReferenceProperties((Kalliope.DTO.TooManyRoleSequencesError)dto, cache);
                    break;
                case "TrueOrFalseLogicalDataType":
                    var trueOrFalseLogicalDataType = poco as Kalliope.Core.TrueOrFalseLogicalDataType;
                    trueOrFalseLogicalDataType.UpdateReferenceProperties((Kalliope.DTO.TrueOrFalseLogicalDataType)dto, cache);
                    break;
                case "UnaryRoleCardinalityConstraint":
                    var unaryRoleCardinalityConstraint = poco as Kalliope.Core.UnaryRoleCardinalityConstraint;
                    unaryRoleCardinalityConstraint.UpdateReferenceProperties((Kalliope.DTO.UnaryRoleCardinalityConstraint)dto, cache);
                    break;
                case "UniquenessConstraint":
                    var uniquenessConstraint = poco as Kalliope.Core.UniquenessConstraint;
                    uniquenessConstraint.UpdateReferenceProperties((Kalliope.DTO.UniquenessConstraint)dto, cache);
                    break;
                case "UnsignedIntegerNumericDataType":
                    var unsignedIntegerNumericDataType = poco as Kalliope.Core.UnsignedIntegerNumericDataType;
                    unsignedIntegerNumericDataType.UpdateReferenceProperties((Kalliope.DTO.UnsignedIntegerNumericDataType)dto, cache);
                    break;
                case "UnsignedLargeIntegerNumericDataType":
                    var unsignedLargeIntegerNumericDataType = poco as Kalliope.Core.UnsignedLargeIntegerNumericDataType;
                    unsignedLargeIntegerNumericDataType.UpdateReferenceProperties((Kalliope.DTO.UnsignedLargeIntegerNumericDataType)dto, cache);
                    break;
                case "UnsignedSmallIntegerNumericDataType":
                    var unsignedSmallIntegerNumericDataType = poco as Kalliope.Core.UnsignedSmallIntegerNumericDataType;
                    unsignedSmallIntegerNumericDataType.UpdateReferenceProperties((Kalliope.DTO.UnsignedSmallIntegerNumericDataType)dto, cache);
                    break;
                case "UnsignedTinyIntegerNumericDataType":
                    var unsignedTinyIntegerNumericDataType = poco as Kalliope.Core.UnsignedTinyIntegerNumericDataType;
                    unsignedTinyIntegerNumericDataType.UpdateReferenceProperties((Kalliope.DTO.UnsignedTinyIntegerNumericDataType)dto, cache);
                    break;
                case "UnspecifiedDataType":
                    var unspecifiedDataType = poco as Kalliope.Core.UnspecifiedDataType;
                    unspecifiedDataType.UpdateReferenceProperties((Kalliope.DTO.UnspecifiedDataType)dto, cache);
                    break;
                case "ValueComparisonConstraint":
                    var valueComparisonConstraint = poco as Kalliope.Core.ValueComparisonConstraint;
                    valueComparisonConstraint.UpdateReferenceProperties((Kalliope.DTO.ValueComparisonConstraint)dto, cache);
                    break;
                case "ValueComparisonConstraintOperatorNotSpecifiedError":
                    var valueComparisonConstraintOperatorNotSpecifiedError = poco as Kalliope.Core.ValueComparisonConstraintOperatorNotSpecifiedError;
                    valueComparisonConstraintOperatorNotSpecifiedError.UpdateReferenceProperties((Kalliope.DTO.ValueComparisonConstraintOperatorNotSpecifiedError)dto, cache);
                    break;
                case "ValueComparisonConstraintShape":
                    var valueComparisonConstraintShape = poco as Kalliope.Diagrams.ValueComparisonConstraintShape;
                    valueComparisonConstraintShape.UpdateReferenceProperties((Kalliope.DTO.ValueComparisonConstraintShape)dto, cache);
                    break;
                case "ValueComparisonRolesNotComparableError":
                    var valueComparisonRolesNotComparableError = poco as Kalliope.Core.ValueComparisonRolesNotComparableError;
                    valueComparisonRolesNotComparableError.UpdateReferenceProperties((Kalliope.DTO.ValueComparisonRolesNotComparableError)dto, cache);
                    break;
                case "ValueConstraintShape":
                    var valueConstraintShape = poco as Kalliope.Diagrams.ValueConstraintShape;
                    valueConstraintShape.UpdateReferenceProperties((Kalliope.DTO.ValueConstraintShape)dto, cache);
                    break;
                case "ValueConstraintValueTypeDetachedError":
                    var valueConstraintValueTypeDetachedError = poco as Kalliope.Core.ValueConstraintValueTypeDetachedError;
                    valueConstraintValueTypeDetachedError.UpdateReferenceProperties((Kalliope.DTO.ValueConstraintValueTypeDetachedError)dto, cache);
                    break;
                case "ValueRange":
                    var valueRange = poco as Kalliope.Core.ValueRange;
                    valueRange.UpdateReferenceProperties((Kalliope.DTO.ValueRange)dto, cache);
                    break;
                case "ValueRangeOverlapError":
                    var valueRangeOverlapError = poco as Kalliope.Core.ValueRangeOverlapError;
                    valueRangeOverlapError.UpdateReferenceProperties((Kalliope.DTO.ValueRangeOverlapError)dto, cache);
                    break;
                case "ValueType":
                    var valueType = poco as Kalliope.Core.ValueType;
                    valueType.UpdateReferenceProperties((Kalliope.DTO.ValueType)dto, cache);
                    break;
                case "ValueTypeInstance":
                    var valueTypeInstance = poco as Kalliope.Core.ValueTypeInstance;
                    valueTypeInstance.UpdateReferenceProperties((Kalliope.DTO.ValueTypeInstance)dto, cache);
                    break;
                case "ValueTypeValueConstraint":
                    var valueTypeValueConstraint = poco as Kalliope.Core.ValueTypeValueConstraint;
                    valueTypeValueConstraint.UpdateReferenceProperties((Kalliope.DTO.ValueTypeValueConstraint)dto, cache);
                    break;
                case "VariableLengthRawDataDataType":
                    var variableLengthRawDataDataType = poco as Kalliope.Core.VariableLengthRawDataDataType;
                    variableLengthRawDataDataType.UpdateReferenceProperties((Kalliope.DTO.VariableLengthRawDataDataType)dto, cache);
                    break;
                case "VariableLengthTextDataType":
                    var variableLengthTextDataType = poco as Kalliope.Core.VariableLengthTextDataType;
                    variableLengthTextDataType.UpdateReferenceProperties((Kalliope.DTO.VariableLengthTextDataType)dto, cache);
                    break;
                case "YesOrNoLogicalDataType":
                    var yesOrNoLogicalDataType = poco as Kalliope.Core.YesOrNoLogicalDataType;
                    yesOrNoLogicalDataType.UpdateReferenceProperties((Kalliope.DTO.YesOrNoLogicalDataType)dto, cache);
                    break;
                default:
                    throw new System.NotSupportedException($"{poco.GetType().Name} not yet supported");
            }
        }
    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
