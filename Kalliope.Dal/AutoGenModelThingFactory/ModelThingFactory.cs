// -------------------------------------------------------------------------------------------------
// <copyright file="ModelThingFactory.cs" company="RHEA System S.A.">
//
//   Copyright 2022-2023 RHEA System S.A.
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

    /// <summary>
    /// The purpose of the <see cref="ModelThingFactory"/> is to create a <see cref="Kalliope.Core.ModelThing"/> POCO
    /// based on a <see cref="Kalliope.DTO.ModelThing"/> DTO
    /// </summary>
    public class ModelThingFactory : IModelThingFactory
    {
        /// <summary>
        /// Creates a <see cref="Kalliope.Core.ModelThing"/> POCO
        /// </summary>
        /// <param name="dto">
        /// the source <see cref="Kalliope.DTO.ModelThing"/> DTO
        /// </param>
        /// <returns>
        /// a <see cref="Kalliope.Core.ModelThing"/> POCO
        /// </returns>
        /// <exception cref="ArgumentNullException">
        /// thrown when <paramref name="dto"/> is null
        /// </exception>
        public Kalliope.Core.ModelThing Create(Kalliope.DTO.ModelThing dto)
        {
            if (dto == null)
            {
                throw new ArgumentNullException(nameof(dto), $"the {nameof(dto)} may not be null");
            }

            var typeName = dto.GetType().Name;

            switch (typeName)
            {
                case "AbsorbedFactType":
                    var absorbedFactType = dto as Kalliope.DTO.AbsorbedFactType;
                    var absorbedFactTypeFactory = new AbsorbedFactTypeFactory();
                    return absorbedFactTypeFactory.Create(absorbedFactType);
                case "AbsorbedObjectType":
                    var absorbedObjectType = dto as Kalliope.DTO.AbsorbedObjectType;
                    var absorbedObjectTypeFactory = new AbsorbedObjectTypeFactory();
                    return absorbedObjectTypeFactory.Create(absorbedObjectType);
                case "AbsorbedRole":
                    var absorbedRole = dto as Kalliope.DTO.AbsorbedRole;
                    var absorbedRoleFactory = new AbsorbedRoleFactory();
                    return absorbedRoleFactory.Create(absorbedRole);
                case "AutoCounterNumericDataType":
                    var autoCounterNumericDataType = dto as Kalliope.DTO.AutoCounterNumericDataType;
                    var autoCounterNumericDataTypeFactory = new AutoCounterNumericDataTypeFactory();
                    return autoCounterNumericDataTypeFactory.Create(autoCounterNumericDataType);
                case "AutoTimestampTemporalDataType":
                    var autoTimestampTemporalDataType = dto as Kalliope.DTO.AutoTimestampTemporalDataType;
                    var autoTimestampTemporalDataTypeFactory = new AutoTimestampTemporalDataTypeFactory();
                    return autoTimestampTemporalDataTypeFactory.Create(autoTimestampTemporalDataType);
                case "CalculatedPathValue":
                    var calculatedPathValue = dto as Kalliope.DTO.CalculatedPathValue;
                    var calculatedPathValueFactory = new CalculatedPathValueFactory();
                    return calculatedPathValueFactory.Create(calculatedPathValue);
                case "CalculatedPathValueInput":
                    var calculatedPathValueInput = dto as Kalliope.DTO.CalculatedPathValueInput;
                    var calculatedPathValueInputFactory = new CalculatedPathValueInputFactory();
                    return calculatedPathValueInputFactory.Create(calculatedPathValueInput);
                case "CalculatedPathValueMustBeConsumedError":
                    var calculatedPathValueMustBeConsumedError = dto as Kalliope.DTO.CalculatedPathValueMustBeConsumedError;
                    var calculatedPathValueMustBeConsumedErrorFactory = new CalculatedPathValueMustBeConsumedErrorFactory();
                    return calculatedPathValueMustBeConsumedErrorFactory.Create(calculatedPathValueMustBeConsumedError);
                case "CalculatedPathValueParameterBindingError":
                    var calculatedPathValueParameterBindingError = dto as Kalliope.DTO.CalculatedPathValueParameterBindingError;
                    var calculatedPathValueParameterBindingErrorFactory = new CalculatedPathValueParameterBindingErrorFactory();
                    return calculatedPathValueParameterBindingErrorFactory.Create(calculatedPathValueParameterBindingError);
                case "CalculatedPathValueRequiresAggregationContextError":
                    var calculatedPathValueRequiresAggregationContextError = dto as Kalliope.DTO.CalculatedPathValueRequiresAggregationContextError;
                    var calculatedPathValueRequiresAggregationContextErrorFactory = new CalculatedPathValueRequiresAggregationContextErrorFactory();
                    return calculatedPathValueRequiresAggregationContextErrorFactory.Create(calculatedPathValueRequiresAggregationContextError);
                case "CalculatedPathValueRequiresFunctionError":
                    var calculatedPathValueRequiresFunctionError = dto as Kalliope.DTO.CalculatedPathValueRequiresFunctionError;
                    var calculatedPathValueRequiresFunctionErrorFactory = new CalculatedPathValueRequiresFunctionErrorFactory();
                    return calculatedPathValueRequiresFunctionErrorFactory.Create(calculatedPathValueRequiresFunctionError);
                case "CalculatedValue":
                    var calculatedValue = dto as Kalliope.DTO.CalculatedValue;
                    var calculatedValueFactory = new CalculatedValueFactory();
                    return calculatedValueFactory.Create(calculatedValue);
                case "CardinalityConstraintShape":
                    var cardinalityConstraintShape = dto as Kalliope.DTO.CardinalityConstraintShape;
                    var cardinalityConstraintShapeFactory = new CardinalityConstraintShapeFactory();
                    return cardinalityConstraintShapeFactory.Create(cardinalityConstraintShape);
                case "CardinalityRange":
                    var cardinalityRange = dto as Kalliope.DTO.CardinalityRange;
                    var cardinalityRangeFactory = new CardinalityRangeFactory();
                    return cardinalityRangeFactory.Create(cardinalityRange);
                case "CardinalityRangeOverlapError":
                    var cardinalityRangeOverlapError = dto as Kalliope.DTO.CardinalityRangeOverlapError;
                    var cardinalityRangeOverlapErrorFactory = new CardinalityRangeOverlapErrorFactory();
                    return cardinalityRangeOverlapErrorFactory.Create(cardinalityRangeOverlapError);
                case "ChildRole":
                    var childRole = dto as Kalliope.DTO.ChildRole;
                    var childRoleFactory = new ChildRoleFactory();
                    return childRoleFactory.Create(childRole);
                case "CompatibleRolePlayerTypeError":
                    var compatibleRolePlayerTypeError = dto as Kalliope.DTO.CompatibleRolePlayerTypeError;
                    var compatibleRolePlayerTypeErrorFactory = new CompatibleRolePlayerTypeErrorFactory();
                    return compatibleRolePlayerTypeErrorFactory.Create(compatibleRolePlayerTypeError);
                case "CompatibleSupertypesError":
                    var compatibleSupertypesError = dto as Kalliope.DTO.CompatibleSupertypesError;
                    var compatibleSupertypesErrorFactory = new CompatibleSupertypesErrorFactory();
                    return compatibleSupertypesErrorFactory.Create(compatibleSupertypesError);
                case "CompatibleValueTypeInstanceValueError":
                    var compatibleValueTypeInstanceValueError = dto as Kalliope.DTO.CompatibleValueTypeInstanceValueError;
                    var compatibleValueTypeInstanceValueErrorFactory = new CompatibleValueTypeInstanceValueErrorFactory();
                    return compatibleValueTypeInstanceValueErrorFactory.Create(compatibleValueTypeInstanceValueError);
                case "ConstraintDuplicateNameError":
                    var constraintDuplicateNameError = dto as Kalliope.DTO.ConstraintDuplicateNameError;
                    var constraintDuplicateNameErrorFactory = new ConstraintDuplicateNameErrorFactory();
                    return constraintDuplicateNameErrorFactory.Create(constraintDuplicateNameError);
                case "ConstraintRoleRequiresCompatibleJoinPathProjectionError":
                    var constraintRoleRequiresCompatibleJoinPathProjectionError = dto as Kalliope.DTO.ConstraintRoleRequiresCompatibleJoinPathProjectionError;
                    var constraintRoleRequiresCompatibleJoinPathProjectionErrorFactory = new ConstraintRoleRequiresCompatibleJoinPathProjectionErrorFactory();
                    return constraintRoleRequiresCompatibleJoinPathProjectionErrorFactory.Create(constraintRoleRequiresCompatibleJoinPathProjectionError);
                case "ConstraintRoleSequenceJoinPath":
                    var constraintRoleSequenceJoinPath = dto as Kalliope.DTO.ConstraintRoleSequenceJoinPath;
                    var constraintRoleSequenceJoinPathFactory = new ConstraintRoleSequenceJoinPathFactory();
                    return constraintRoleSequenceJoinPathFactory.Create(constraintRoleSequenceJoinPath);
                case "ConstraintRoleSequenceJoinPathRequiresProjectionError":
                    var constraintRoleSequenceJoinPathRequiresProjectionError = dto as Kalliope.DTO.ConstraintRoleSequenceJoinPathRequiresProjectionError;
                    var constraintRoleSequenceJoinPathRequiresProjectionErrorFactory = new ConstraintRoleSequenceJoinPathRequiresProjectionErrorFactory();
                    return constraintRoleSequenceJoinPathRequiresProjectionErrorFactory.Create(constraintRoleSequenceJoinPathRequiresProjectionError);
                case "CorrelatedPathRoleRequiresCompatibleRolePlayerError":
                    var correlatedPathRoleRequiresCompatibleRolePlayerError = dto as Kalliope.DTO.CorrelatedPathRoleRequiresCompatibleRolePlayerError;
                    var correlatedPathRoleRequiresCompatibleRolePlayerErrorFactory = new CorrelatedPathRoleRequiresCompatibleRolePlayerErrorFactory();
                    return correlatedPathRoleRequiresCompatibleRolePlayerErrorFactory.Create(correlatedPathRoleRequiresCompatibleRolePlayerError);
                case "CustomProperty":
                    var customProperty = dto as Kalliope.DTO.CustomProperty;
                    var customPropertyFactory = new CustomPropertyFactory();
                    return customPropertyFactory.Create(customProperty);
                case "CustomPropertyDefinition":
                    var customPropertyDefinition = dto as Kalliope.DTO.CustomPropertyDefinition;
                    var customPropertyDefinitionFactory = new CustomPropertyDefinitionFactory();
                    return customPropertyDefinitionFactory.Create(customPropertyDefinition);
                case "CustomPropertyGroup":
                    var customPropertyGroup = dto as Kalliope.DTO.CustomPropertyGroup;
                    var customPropertyGroupFactory = new CustomPropertyGroupFactory();
                    return customPropertyGroupFactory.Create(customPropertyGroup);
                case "CustomReferenceMode":
                    var customReferenceMode = dto as Kalliope.DTO.CustomReferenceMode;
                    var customReferenceModeFactory = new CustomReferenceModeFactory();
                    return customReferenceModeFactory.Create(customReferenceMode);
                case "DataTypeNotSpecifiedError":
                    var dataTypeNotSpecifiedError = dto as Kalliope.DTO.DataTypeNotSpecifiedError;
                    var dataTypeNotSpecifiedErrorFactory = new DataTypeNotSpecifiedErrorFactory();
                    return dataTypeNotSpecifiedErrorFactory.Create(dataTypeNotSpecifiedError);
                case "DataTypeUse":
                    var dataTypeUse = dto as Kalliope.DTO.DataTypeUse;
                    var dataTypeUseFactory = new DataTypeUseFactory();
                    return dataTypeUseFactory.Create(dataTypeUse);
                case "DateAndTimeTemporalDataType":
                    var dateAndTimeTemporalDataType = dto as Kalliope.DTO.DateAndTimeTemporalDataType;
                    var dateAndTimeTemporalDataTypeFactory = new DateAndTimeTemporalDataTypeFactory();
                    return dateAndTimeTemporalDataTypeFactory.Create(dateAndTimeTemporalDataType);
                case "DateTemporalDataType":
                    var dateTemporalDataType = dto as Kalliope.DTO.DateTemporalDataType;
                    var dateTemporalDataTypeFactory = new DateTemporalDataTypeFactory();
                    return dateTemporalDataTypeFactory.Create(dateTemporalDataType);
                case "DecimalNumericDataType":
                    var decimalNumericDataType = dto as Kalliope.DTO.DecimalNumericDataType;
                    var decimalNumericDataTypeFactory = new DecimalNumericDataTypeFactory();
                    return decimalNumericDataTypeFactory.Create(decimalNumericDataType);
                case "Definition":
                    var definition = dto as Kalliope.DTO.Definition;
                    var definitionFactory = new DefinitionFactory();
                    return definitionFactory.Create(definition);
                case "DerivationNote":
                    var derivationNote = dto as Kalliope.DTO.DerivationNote;
                    var derivationNoteFactory = new DerivationNoteFactory();
                    return derivationNoteFactory.Create(derivationNote);
                case "DerivedFactTypeRoleProjectionCompatibilityError":
                    var derivedFactTypeRoleProjectionCompatibilityError = dto as Kalliope.DTO.DerivedFactTypeRoleProjectionCompatibilityError;
                    var derivedFactTypeRoleProjectionCompatibilityErrorFactory = new DerivedFactTypeRoleProjectionCompatibilityErrorFactory();
                    return derivedFactTypeRoleProjectionCompatibilityErrorFactory.Create(derivedFactTypeRoleProjectionCompatibilityError);
                case "DerivedRoleRequiresCompatibleProjectionError":
                    var derivedRoleRequiresCompatibleProjectionError = dto as Kalliope.DTO.DerivedRoleRequiresCompatibleProjectionError;
                    var derivedRoleRequiresCompatibleProjectionErrorFactory = new DerivedRoleRequiresCompatibleProjectionErrorFactory();
                    return derivedRoleRequiresCompatibleProjectionErrorFactory.Create(derivedRoleRequiresCompatibleProjectionError);
                case "DiagramDynamicColor":
                    var diagramDynamicColor = dto as Kalliope.DTO.DiagramDynamicColor;
                    var diagramDynamicColorFactory = new DiagramDynamicColorFactory();
                    return diagramDynamicColorFactory.Create(diagramDynamicColor);
                case "DisplaySettingPlaceholder":
                    var displaySettingPlaceholder = dto as Kalliope.DTO.DisplaySettingPlaceholder;
                    var displaySettingPlaceholderFactory = new DisplaySettingPlaceholderFactory();
                    return displaySettingPlaceholderFactory.Create(displaySettingPlaceholder);
                case "DisplayState":
                    var displayState = dto as Kalliope.DTO.DisplayState;
                    var displayStateFactory = new DisplayStateFactory();
                    return displayStateFactory.Create(displayState);
                case "DoublePrecisionFloatingPointNumericDataType":
                    var doublePrecisionFloatingPointNumericDataType = dto as Kalliope.DTO.DoublePrecisionFloatingPointNumericDataType;
                    var doublePrecisionFloatingPointNumericDataTypeFactory = new DoublePrecisionFloatingPointNumericDataTypeFactory();
                    return doublePrecisionFloatingPointNumericDataTypeFactory.Create(doublePrecisionFloatingPointNumericDataType);
                case "DuplicateReadingSignatureError":
                    var duplicateReadingSignatureError = dto as Kalliope.DTO.DuplicateReadingSignatureError;
                    var duplicateReadingSignatureErrorFactory = new DuplicateReadingSignatureErrorFactory();
                    return duplicateReadingSignatureErrorFactory.Create(duplicateReadingSignatureError);
                case "ElementGrouping":
                    var elementGrouping = dto as Kalliope.DTO.ElementGrouping;
                    var elementGroupingFactory = new ElementGroupingFactory();
                    return elementGroupingFactory.Create(elementGrouping);
                case "ElementGroupingMembershipContradictionError":
                    var elementGroupingMembershipContradictionError = dto as Kalliope.DTO.ElementGroupingMembershipContradictionError;
                    var elementGroupingMembershipContradictionErrorFactory = new ElementGroupingMembershipContradictionErrorFactory();
                    return elementGroupingMembershipContradictionErrorFactory.Create(elementGroupingMembershipContradictionError);
                case "ElementGroupingSet":
                    var elementGroupingSet = dto as Kalliope.DTO.ElementGroupingSet;
                    var elementGroupingSetFactory = new ElementGroupingSetFactory();
                    return elementGroupingSetFactory.Create(elementGroupingSet);
                case "ElementOrganizations":
                    var elementOrganizations = dto as Kalliope.DTO.ElementOrganizations;
                    var elementOrganizationsFactory = new ElementOrganizationsFactory();
                    return elementOrganizationsFactory.Create(elementOrganizations);
                case "ElementsNotOnDiagramError":
                    var elementsNotOnDiagramError = dto as Kalliope.DTO.ElementsNotOnDiagramError;
                    var elementsNotOnDiagramErrorFactory = new ElementsNotOnDiagramErrorFactory();
                    return elementsNotOnDiagramErrorFactory.Create(elementsNotOnDiagramError);
                case "EntityType":
                    var entityType = dto as Kalliope.DTO.EntityType;
                    var entityTypeFactory = new EntityTypeFactory();
                    return entityTypeFactory.Create(entityType);
                case "EntityTypeInstance":
                    var entityTypeInstance = dto as Kalliope.DTO.EntityTypeInstance;
                    var entityTypeInstanceFactory = new EntityTypeInstanceFactory();
                    return entityTypeInstanceFactory.Create(entityTypeInstance);
                case "EntityTypeRequiresReferenceSchemeError":
                    var entityTypeRequiresReferenceSchemeError = dto as Kalliope.DTO.EntityTypeRequiresReferenceSchemeError;
                    var entityTypeRequiresReferenceSchemeErrorFactory = new EntityTypeRequiresReferenceSchemeErrorFactory();
                    return entityTypeRequiresReferenceSchemeErrorFactory.Create(entityTypeRequiresReferenceSchemeError);
                case "EntityTypeSubtypeInstance":
                    var entityTypeSubtypeInstance = dto as Kalliope.DTO.EntityTypeSubtypeInstance;
                    var entityTypeSubtypeInstanceFactory = new EntityTypeSubtypeInstanceFactory();
                    return entityTypeSubtypeInstanceFactory.Create(entityTypeSubtypeInstance);
                case "EqualityConstraint":
                    var equalityConstraint = dto as Kalliope.DTO.EqualityConstraint;
                    var equalityConstraintFactory = new EqualityConstraintFactory();
                    return equalityConstraintFactory.Create(equalityConstraint);
                case "EqualityConstraintImpliedByMandatoryConstraintsError":
                    var equalityConstraintImpliedByMandatoryConstraintsError = dto as Kalliope.DTO.EqualityConstraintImpliedByMandatoryConstraintsError;
                    var equalityConstraintImpliedByMandatoryConstraintsErrorFactory = new EqualityConstraintImpliedByMandatoryConstraintsErrorFactory();
                    return equalityConstraintImpliedByMandatoryConstraintsErrorFactory.Create(equalityConstraintImpliedByMandatoryConstraintsError);
                case "EqualityImpliedByMandatoryError":
                    var equalityImpliedByMandatoryError = dto as Kalliope.DTO.EqualityImpliedByMandatoryError;
                    var equalityImpliedByMandatoryErrorFactory = new EqualityImpliedByMandatoryErrorFactory();
                    return equalityImpliedByMandatoryErrorFactory.Create(equalityImpliedByMandatoryError);
                case "EqualityOrSubsetImpliedByMandatoryError":
                    var equalityOrSubsetImpliedByMandatoryError = dto as Kalliope.DTO.EqualityOrSubsetImpliedByMandatoryError;
                    var equalityOrSubsetImpliedByMandatoryErrorFactory = new EqualityOrSubsetImpliedByMandatoryErrorFactory();
                    return equalityOrSubsetImpliedByMandatoryErrorFactory.Create(equalityOrSubsetImpliedByMandatoryError);
                case "ExclusionConstraint":
                    var exclusionConstraint = dto as Kalliope.DTO.ExclusionConstraint;
                    var exclusionConstraintFactory = new ExclusionConstraintFactory();
                    return exclusionConstraintFactory.Create(exclusionConstraint);
                case "ExclusionContradictsEqualityError":
                    var exclusionContradictsEqualityError = dto as Kalliope.DTO.ExclusionContradictsEqualityError;
                    var exclusionContradictsEqualityErrorFactory = new ExclusionContradictsEqualityErrorFactory();
                    return exclusionContradictsEqualityErrorFactory.Create(exclusionContradictsEqualityError);
                case "ExclusionContradictsMandatoryError":
                    var exclusionContradictsMandatoryError = dto as Kalliope.DTO.ExclusionContradictsMandatoryError;
                    var exclusionContradictsMandatoryErrorFactory = new ExclusionContradictsMandatoryErrorFactory();
                    return exclusionContradictsMandatoryErrorFactory.Create(exclusionContradictsMandatoryError);
                case "ExclusionContradictsSubsetError":
                    var exclusionContradictsSubsetError = dto as Kalliope.DTO.ExclusionContradictsSubsetError;
                    var exclusionContradictsSubsetErrorFactory = new ExclusionContradictsSubsetErrorFactory();
                    return exclusionContradictsSubsetErrorFactory.Create(exclusionContradictsSubsetError);
                case "ExtensionModelError":
                    var extensionModelError = dto as Kalliope.DTO.ExtensionModelError;
                    var extensionModelErrorFactory = new ExtensionModelErrorFactory();
                    return extensionModelErrorFactory.Create(extensionModelError);
                case "ExternalConstraintRoleSequenceArityMismatchError":
                    var externalConstraintRoleSequenceArityMismatchError = dto as Kalliope.DTO.ExternalConstraintRoleSequenceArityMismatchError;
                    var externalConstraintRoleSequenceArityMismatchErrorFactory = new ExternalConstraintRoleSequenceArityMismatchErrorFactory();
                    return externalConstraintRoleSequenceArityMismatchErrorFactory.Create(externalConstraintRoleSequenceArityMismatchError);
                case "ExternalConstraintShape":
                    var externalConstraintShape = dto as Kalliope.DTO.ExternalConstraintShape;
                    var externalConstraintShapeFactory = new ExternalConstraintShapeFactory();
                    return externalConstraintShapeFactory.Create(externalConstraintShape);
                case "FactType":
                    var factType = dto as Kalliope.DTO.FactType;
                    var factTypeFactory = new FactTypeFactory();
                    return factTypeFactory.Create(factType);
                case "FactTypeDerivationExpression":
                    var factTypeDerivationExpression = dto as Kalliope.DTO.FactTypeDerivationExpression;
                    var factTypeDerivationExpressionFactory = new FactTypeDerivationExpressionFactory();
                    return factTypeDerivationExpressionFactory.Create(factTypeDerivationExpression);
                case "FactTypeDerivationPath":
                    var factTypeDerivationPath = dto as Kalliope.DTO.FactTypeDerivationPath;
                    var factTypeDerivationPathFactory = new FactTypeDerivationPathFactory();
                    return factTypeDerivationPathFactory.Create(factTypeDerivationPath);
                case "FactTypeDerivationRequiresProjectionError":
                    var factTypeDerivationRequiresProjectionError = dto as Kalliope.DTO.FactTypeDerivationRequiresProjectionError;
                    var factTypeDerivationRequiresProjectionErrorFactory = new FactTypeDerivationRequiresProjectionErrorFactory();
                    return factTypeDerivationRequiresProjectionErrorFactory.Create(factTypeDerivationRequiresProjectionError);
                case "FactTypeDerivationRule":
                    var factTypeDerivationRule = dto as Kalliope.DTO.FactTypeDerivationRule;
                    var factTypeDerivationRuleFactory = new FactTypeDerivationRuleFactory();
                    return factTypeDerivationRuleFactory.Create(factTypeDerivationRule);
                case "FactTypeInstance":
                    var factTypeInstance = dto as Kalliope.DTO.FactTypeInstance;
                    var factTypeInstanceFactory = new FactTypeInstanceFactory();
                    return factTypeInstanceFactory.Create(factTypeInstance);
                case "FactTypeLinkConnectorShape":
                    var factTypeLinkConnectorShape = dto as Kalliope.DTO.FactTypeLinkConnectorShape;
                    var factTypeLinkConnectorShapeFactory = new FactTypeLinkConnectorShapeFactory();
                    return factTypeLinkConnectorShapeFactory.Create(factTypeLinkConnectorShape);
                case "FactTypeRequiresInternalUniquenessConstraintError":
                    var factTypeRequiresInternalUniquenessConstraintError = dto as Kalliope.DTO.FactTypeRequiresInternalUniquenessConstraintError;
                    var factTypeRequiresInternalUniquenessConstraintErrorFactory = new FactTypeRequiresInternalUniquenessConstraintErrorFactory();
                    return factTypeRequiresInternalUniquenessConstraintErrorFactory.Create(factTypeRequiresInternalUniquenessConstraintError);
                case "FactTypeRequiresReadingError":
                    var factTypeRequiresReadingError = dto as Kalliope.DTO.FactTypeRequiresReadingError;
                    var factTypeRequiresReadingErrorFactory = new FactTypeRequiresReadingErrorFactory();
                    return factTypeRequiresReadingErrorFactory.Create(factTypeRequiresReadingError);
                case "FactTypeShape":
                    var factTypeShape = dto as Kalliope.DTO.FactTypeShape;
                    var factTypeShapeFactory = new FactTypeShapeFactory();
                    return factTypeShapeFactory.Create(factTypeShape);
                case "FixedLengthRawDataDataType":
                    var fixedLengthRawDataDataType = dto as Kalliope.DTO.FixedLengthRawDataDataType;
                    var fixedLengthRawDataDataTypeFactory = new FixedLengthRawDataDataTypeFactory();
                    return fixedLengthRawDataDataTypeFactory.Create(fixedLengthRawDataDataType);
                case "FixedLengthTextDataType":
                    var fixedLengthTextDataType = dto as Kalliope.DTO.FixedLengthTextDataType;
                    var fixedLengthTextDataTypeFactory = new FixedLengthTextDataTypeFactory();
                    return fixedLengthTextDataTypeFactory.Create(fixedLengthTextDataType);
                case "FloatingPointNumericDataType":
                    var floatingPointNumericDataType = dto as Kalliope.DTO.FloatingPointNumericDataType;
                    var floatingPointNumericDataTypeFactory = new FloatingPointNumericDataTypeFactory();
                    return floatingPointNumericDataTypeFactory.Create(floatingPointNumericDataType);
                case "FrequencyConstraint":
                    var frequencyConstraint = dto as Kalliope.DTO.FrequencyConstraint;
                    var frequencyConstraintFactory = new FrequencyConstraintFactory();
                    return frequencyConstraintFactory.Create(frequencyConstraint);
                case "FrequencyConstraintContradictsInternalUniquenessConstraintError":
                    var frequencyConstraintContradictsInternalUniquenessConstraintError = dto as Kalliope.DTO.FrequencyConstraintContradictsInternalUniquenessConstraintError;
                    var frequencyConstraintContradictsInternalUniquenessConstraintErrorFactory = new FrequencyConstraintContradictsInternalUniquenessConstraintErrorFactory();
                    return frequencyConstraintContradictsInternalUniquenessConstraintErrorFactory.Create(frequencyConstraintContradictsInternalUniquenessConstraintError);
                case "FrequencyConstraintExactlyOneError":
                    var frequencyConstraintExactlyOneError = dto as Kalliope.DTO.FrequencyConstraintExactlyOneError;
                    var frequencyConstraintExactlyOneErrorFactory = new FrequencyConstraintExactlyOneErrorFactory();
                    return frequencyConstraintExactlyOneErrorFactory.Create(frequencyConstraintExactlyOneError);
                case "FrequencyConstraintMinMaxError":
                    var frequencyConstraintMinMaxError = dto as Kalliope.DTO.FrequencyConstraintMinMaxError;
                    var frequencyConstraintMinMaxErrorFactory = new FrequencyConstraintMinMaxErrorFactory();
                    return frequencyConstraintMinMaxErrorFactory.Create(frequencyConstraintMinMaxError);
                case "FrequencyConstraintNonRestrictiveRangeError":
                    var frequencyConstraintNonRestrictiveRangeError = dto as Kalliope.DTO.FrequencyConstraintNonRestrictiveRangeError;
                    var frequencyConstraintNonRestrictiveRangeErrorFactory = new FrequencyConstraintNonRestrictiveRangeErrorFactory();
                    return frequencyConstraintNonRestrictiveRangeErrorFactory.Create(frequencyConstraintNonRestrictiveRangeError);
                case "FrequencyConstraintShape":
                    var frequencyConstraintShape = dto as Kalliope.DTO.FrequencyConstraintShape;
                    var frequencyConstraintShapeFactory = new FrequencyConstraintShapeFactory();
                    return frequencyConstraintShapeFactory.Create(frequencyConstraintShape);
                case "FrequencyConstraintViolatedByUniquenessConstraintError":
                    var frequencyConstraintViolatedByUniquenessConstraintError = dto as Kalliope.DTO.FrequencyConstraintViolatedByUniquenessConstraintError;
                    var frequencyConstraintViolatedByUniquenessConstraintErrorFactory = new FrequencyConstraintViolatedByUniquenessConstraintErrorFactory();
                    return frequencyConstraintViolatedByUniquenessConstraintErrorFactory.Create(frequencyConstraintViolatedByUniquenessConstraintError);
                case "Function":
                    var function = dto as Kalliope.DTO.Function;
                    var functionFactory = new FunctionFactory();
                    return functionFactory.Create(function);
                case "FunctionDuplicateNameError":
                    var functionDuplicateNameError = dto as Kalliope.DTO.FunctionDuplicateNameError;
                    var functionDuplicateNameErrorFactory = new FunctionDuplicateNameErrorFactory();
                    return functionDuplicateNameErrorFactory.Create(functionDuplicateNameError);
                case "FunctionParameter":
                    var functionParameter = dto as Kalliope.DTO.FunctionParameter;
                    var functionParameterFactory = new FunctionParameterFactory();
                    return functionParameterFactory.Create(functionParameter);
                case "GenerationState":
                    var generationState = dto as Kalliope.DTO.GenerationState;
                    var generationStateFactory = new GenerationStateFactory();
                    return generationStateFactory.Create(generationState);
                case "Group":
                    var group = dto as Kalliope.DTO.Group;
                    var groupFactory = new GroupFactory();
                    return groupFactory.Create(group);
                case "GroupDuplicateNameError":
                    var groupDuplicateNameError = dto as Kalliope.DTO.GroupDuplicateNameError;
                    var groupDuplicateNameErrorFactory = new GroupDuplicateNameErrorFactory();
                    return groupDuplicateNameErrorFactory.Create(groupDuplicateNameError);
                case "GroupMembershipContradictionError":
                    var groupMembershipContradictionError = dto as Kalliope.DTO.GroupMembershipContradictionError;
                    var groupMembershipContradictionErrorFactory = new GroupMembershipContradictionErrorFactory();
                    return groupMembershipContradictionErrorFactory.Create(groupMembershipContradictionError);
                case "Hierarchy":
                    var hierarchy = dto as Kalliope.DTO.Hierarchy;
                    var hierarchyFactory = new HierarchyFactory();
                    return hierarchyFactory.Create(hierarchy);
                case "HierarchyChild":
                    var hierarchyChild = dto as Kalliope.DTO.HierarchyChild;
                    var hierarchyChildFactory = new HierarchyChildFactory();
                    return hierarchyChildFactory.Create(hierarchyChild);
                case "HierarchyColorScheme":
                    var hierarchyColorScheme = dto as Kalliope.DTO.HierarchyColorScheme;
                    var hierarchyColorSchemeFactory = new HierarchyColorSchemeFactory();
                    return hierarchyColorSchemeFactory.Create(hierarchyColorScheme);
                case "ImplicationError":
                    var implicationError = dto as Kalliope.DTO.ImplicationError;
                    var implicationErrorFactory = new ImplicationErrorFactory();
                    return implicationErrorFactory.Create(implicationError);
                case "ImpliedFactType":
                    var impliedFactType = dto as Kalliope.DTO.ImpliedFactType;
                    var impliedFactTypeFactory = new ImpliedFactTypeFactory();
                    return impliedFactTypeFactory.Create(impliedFactType);
                case "ImpliedInternalUniquenessConstraintError":
                    var impliedInternalUniquenessConstraintError = dto as Kalliope.DTO.ImpliedInternalUniquenessConstraintError;
                    var impliedInternalUniquenessConstraintErrorFactory = new ImpliedInternalUniquenessConstraintErrorFactory();
                    return impliedInternalUniquenessConstraintErrorFactory.Create(impliedInternalUniquenessConstraintError);
                case "InformalDerivationRule":
                    var informalDerivationRule = dto as Kalliope.DTO.InformalDerivationRule;
                    var informalDerivationRuleFactory = new InformalDerivationRuleFactory();
                    return informalDerivationRuleFactory.Create(informalDerivationRule);
                case "IntrinsicReferenceMode":
                    var intrinsicReferenceMode = dto as Kalliope.DTO.IntrinsicReferenceMode;
                    var intrinsicReferenceModeFactory = new IntrinsicReferenceModeFactory();
                    return intrinsicReferenceModeFactory.Create(intrinsicReferenceMode);
                case "JoinedConstraintRoleProjectionCompatibilityError":
                    var joinedConstraintRoleProjectionCompatibilityError = dto as Kalliope.DTO.JoinedConstraintRoleProjectionCompatibilityError;
                    var joinedConstraintRoleProjectionCompatibilityErrorFactory = new JoinedConstraintRoleProjectionCompatibilityErrorFactory();
                    return joinedConstraintRoleProjectionCompatibilityErrorFactory.Create(joinedConstraintRoleProjectionCompatibilityError);
                case "JoinedPathRoleRequiresCompatibleRolePlayerError":
                    var joinedPathRoleRequiresCompatibleRolePlayerError = dto as Kalliope.DTO.JoinedPathRoleRequiresCompatibleRolePlayerError;
                    var joinedPathRoleRequiresCompatibleRolePlayerErrorFactory = new JoinedPathRoleRequiresCompatibleRolePlayerErrorFactory();
                    return joinedPathRoleRequiresCompatibleRolePlayerErrorFactory.Create(joinedPathRoleRequiresCompatibleRolePlayerError);
                case "JoinPathRequiredError":
                    var joinPathRequiredError = dto as Kalliope.DTO.JoinPathRequiredError;
                    var joinPathRequiredErrorFactory = new JoinPathRequiredErrorFactory();
                    return joinPathRequiredErrorFactory.Create(joinPathRequiredError);
                case "JoinPathRequiresProjectionError":
                    var joinPathRequiresProjectionError = dto as Kalliope.DTO.JoinPathRequiresProjectionError;
                    var joinPathRequiresProjectionErrorFactory = new JoinPathRequiresProjectionErrorFactory();
                    return joinPathRequiresProjectionErrorFactory.Create(joinPathRequiresProjectionError);
                case "LargeLengthRawDataDataType":
                    var largeLengthRawDataDataType = dto as Kalliope.DTO.LargeLengthRawDataDataType;
                    var largeLengthRawDataDataTypeFactory = new LargeLengthRawDataDataTypeFactory();
                    return largeLengthRawDataDataTypeFactory.Create(largeLengthRawDataDataType);
                case "LargeLengthTextDataType":
                    var largeLengthTextDataType = dto as Kalliope.DTO.LargeLengthTextDataType;
                    var largeLengthTextDataTypeFactory = new LargeLengthTextDataTypeFactory();
                    return largeLengthTextDataTypeFactory.Create(largeLengthTextDataType);
                case "LeadRolePath":
                    var leadRolePath = dto as Kalliope.DTO.LeadRolePath;
                    var leadRolePathFactory = new LeadRolePathFactory();
                    return leadRolePathFactory.Create(leadRolePath);
                case "LinkConnectorShape":
                    var linkConnectorShape = dto as Kalliope.DTO.LinkConnectorShape;
                    var linkConnectorShapeFactory = new LinkConnectorShapeFactory();
                    return linkConnectorShapeFactory.Create(linkConnectorShape);
                case "MandatoryConstraint":
                    var mandatoryConstraint = dto as Kalliope.DTO.MandatoryConstraint;
                    var mandatoryConstraintFactory = new MandatoryConstraintFactory();
                    return mandatoryConstraintFactory.Create(mandatoryConstraint);
                case "MaxValueMismatchError":
                    var maxValueMismatchError = dto as Kalliope.DTO.MaxValueMismatchError;
                    var maxValueMismatchErrorFactory = new MaxValueMismatchErrorFactory();
                    return maxValueMismatchErrorFactory.Create(maxValueMismatchError);
                case "MinValueMismatchError":
                    var minValueMismatchError = dto as Kalliope.DTO.MinValueMismatchError;
                    var minValueMismatchErrorFactory = new MinValueMismatchErrorFactory();
                    return minValueMismatchErrorFactory.Create(minValueMismatchError);
                case "ModelBrowserColorGroupType":
                    var modelBrowserColorGroupType = dto as Kalliope.DTO.ModelBrowserColorGroupType;
                    var modelBrowserColorGroupTypeFactory = new ModelBrowserColorGroupTypeFactory();
                    return modelBrowserColorGroupTypeFactory.Create(modelBrowserColorGroupType);
                case "ModelNote":
                    var modelNote = dto as Kalliope.DTO.ModelNote;
                    var modelNoteFactory = new ModelNoteFactory();
                    return modelNoteFactory.Create(modelNote);
                case "ModelNoteShape":
                    var modelNoteShape = dto as Kalliope.DTO.ModelNoteShape;
                    var modelNoteShapeFactory = new ModelNoteShapeFactory();
                    return modelNoteShapeFactory.Create(modelNoteShape);
                case "MoneyNumericDataType":
                    var moneyNumericDataType = dto as Kalliope.DTO.MoneyNumericDataType;
                    var moneyNumericDataTypeFactory = new MoneyNumericDataTypeFactory();
                    return moneyNumericDataTypeFactory.Create(moneyNumericDataType);
                case "NameAlias":
                    var nameAlias = dto as Kalliope.DTO.NameAlias;
                    var nameAliasFactory = new NameAliasFactory();
                    return nameAliasFactory.Create(nameAlias);
                case "NameConsumer":
                    var nameConsumer = dto as Kalliope.DTO.NameConsumer;
                    var nameConsumerFactory = new NameConsumerFactory();
                    return nameConsumerFactory.Create(nameConsumer);
                case "NameGenerator":
                    var nameGenerator = dto as Kalliope.DTO.NameGenerator;
                    var nameGeneratorFactory = new NameGeneratorFactory();
                    return nameGeneratorFactory.Create(nameGenerator);
                case "NMinusOneError":
                    var nMinusOneError = dto as Kalliope.DTO.NMinusOneError;
                    var nMinusOneErrorFactory = new NMinusOneErrorFactory();
                    return nMinusOneErrorFactory.Create(nMinusOneError);
                case "Note":
                    var note = dto as Kalliope.DTO.Note;
                    var noteFactory = new NoteFactory();
                    return noteFactory.Create(note);
                case "NotWellModeledSubsetAndMandatoryError":
                    var notWellModeledSubsetAndMandatoryError = dto as Kalliope.DTO.NotWellModeledSubsetAndMandatoryError;
                    var notWellModeledSubsetAndMandatoryErrorFactory = new NotWellModeledSubsetAndMandatoryErrorFactory();
                    return notWellModeledSubsetAndMandatoryErrorFactory.Create(notWellModeledSubsetAndMandatoryError);
                case "ObjectIdOtherDataType":
                    var objectIdOtherDataType = dto as Kalliope.DTO.ObjectIdOtherDataType;
                    var objectIdOtherDataTypeFactory = new ObjectIdOtherDataTypeFactory();
                    return objectIdOtherDataTypeFactory.Create(objectIdOtherDataType);
                case "Objectification":
                    var objectification = dto as Kalliope.DTO.Objectification;
                    var objectificationFactory = new ObjectificationFactory();
                    return objectificationFactory.Create(objectification);
                case "ObjectifiedInstanceRequiredError":
                    var objectifiedInstanceRequiredError = dto as Kalliope.DTO.ObjectifiedInstanceRequiredError;
                    var objectifiedInstanceRequiredErrorFactory = new ObjectifiedInstanceRequiredErrorFactory();
                    return objectifiedInstanceRequiredErrorFactory.Create(objectifiedInstanceRequiredError);
                case "ObjectifiedType":
                    var objectifiedType = dto as Kalliope.DTO.ObjectifiedType;
                    var objectifiedTypeFactory = new ObjectifiedTypeFactory();
                    return objectifiedTypeFactory.Create(objectifiedType);
                case "ObjectifiedUnaryRole":
                    var objectifiedUnaryRole = dto as Kalliope.DTO.ObjectifiedUnaryRole;
                    var objectifiedUnaryRoleFactory = new ObjectifiedUnaryRoleFactory();
                    return objectifiedUnaryRoleFactory.Create(objectifiedUnaryRole);
                case "ObjectifyingInstanceRequiredError":
                    var objectifyingInstanceRequiredError = dto as Kalliope.DTO.ObjectifyingInstanceRequiredError;
                    var objectifyingInstanceRequiredErrorFactory = new ObjectifyingInstanceRequiredErrorFactory();
                    return objectifyingInstanceRequiredErrorFactory.Create(objectifyingInstanceRequiredError);
                case "ObjectTypeCardinalityConstraint":
                    var objectTypeCardinalityConstraint = dto as Kalliope.DTO.ObjectTypeCardinalityConstraint;
                    var objectTypeCardinalityConstraintFactory = new ObjectTypeCardinalityConstraintFactory();
                    return objectTypeCardinalityConstraintFactory.Create(objectTypeCardinalityConstraint);
                case "ObjectTypeCardinalityRestriction":
                    var objectTypeCardinalityRestriction = dto as Kalliope.DTO.ObjectTypeCardinalityRestriction;
                    var objectTypeCardinalityRestrictionFactory = new ObjectTypeCardinalityRestrictionFactory();
                    return objectTypeCardinalityRestrictionFactory.Create(objectTypeCardinalityRestriction);
                case "ObjectTypeDuplicateNameError":
                    var objectTypeDuplicateNameError = dto as Kalliope.DTO.ObjectTypeDuplicateNameError;
                    var objectTypeDuplicateNameErrorFactory = new ObjectTypeDuplicateNameErrorFactory();
                    return objectTypeDuplicateNameErrorFactory.Create(objectTypeDuplicateNameError);
                case "ObjectTypeRequiresPrimarySupertypeError":
                    var objectTypeRequiresPrimarySupertypeError = dto as Kalliope.DTO.ObjectTypeRequiresPrimarySupertypeError;
                    var objectTypeRequiresPrimarySupertypeErrorFactory = new ObjectTypeRequiresPrimarySupertypeErrorFactory();
                    return objectTypeRequiresPrimarySupertypeErrorFactory.Create(objectTypeRequiresPrimarySupertypeError);
                case "ObjectTypeShape":
                    var objectTypeShape = dto as Kalliope.DTO.ObjectTypeShape;
                    var objectTypeShapeFactory = new ObjectTypeShapeFactory();
                    return objectTypeShapeFactory.Create(objectTypeShape);
                case "ObjectUnifierRequiresCompatibleObjectTypesError":
                    var objectUnifierRequiresCompatibleObjectTypesError = dto as Kalliope.DTO.ObjectUnifierRequiresCompatibleObjectTypesError;
                    var objectUnifierRequiresCompatibleObjectTypesErrorFactory = new ObjectUnifierRequiresCompatibleObjectTypesErrorFactory();
                    return objectUnifierRequiresCompatibleObjectTypesErrorFactory.Create(objectUnifierRequiresCompatibleObjectTypesError);
                case "OleObjectRawDataDataType":
                    var oleObjectRawDataDataType = dto as Kalliope.DTO.OleObjectRawDataDataType;
                    var oleObjectRawDataDataTypeFactory = new OleObjectRawDataDataTypeFactory();
                    return oleObjectRawDataDataTypeFactory.Create(oleObjectRawDataDataType);
                case "OrmDiagram":
                    var ormDiagram = dto as Kalliope.DTO.OrmDiagram;
                    var ormDiagramFactory = new OrmDiagramFactory();
                    return ormDiagramFactory.Create(ormDiagram);
                case "OrmModel":
                    var ormModel = dto as Kalliope.DTO.OrmModel;
                    var ormModelFactory = new OrmModelFactory();
                    return ormModelFactory.Create(ormModel);
                case "OrmRoot":
                    var ormRoot = dto as Kalliope.DTO.OrmRoot;
                    var ormRootFactory = new OrmRootFactory();
                    return ormRootFactory.Create(ormRoot);
                case "PartialConstraintRoleSequenceJoinPathProjectionError":
                    var partialConstraintRoleSequenceJoinPathProjectionError = dto as Kalliope.DTO.PartialConstraintRoleSequenceJoinPathProjectionError;
                    var partialConstraintRoleSequenceJoinPathProjectionErrorFactory = new PartialConstraintRoleSequenceJoinPathProjectionErrorFactory();
                    return partialConstraintRoleSequenceJoinPathProjectionErrorFactory.Create(partialConstraintRoleSequenceJoinPathProjectionError);
                case "PartialFactTypeDerivationProjectionError":
                    var partialFactTypeDerivationProjectionError = dto as Kalliope.DTO.PartialFactTypeDerivationProjectionError;
                    var partialFactTypeDerivationProjectionErrorFactory = new PartialFactTypeDerivationProjectionErrorFactory();
                    return partialFactTypeDerivationProjectionErrorFactory.Create(partialFactTypeDerivationProjectionError);
                case "PartialJoinPathProjectionError":
                    var partialJoinPathProjectionError = dto as Kalliope.DTO.PartialJoinPathProjectionError;
                    var partialJoinPathProjectionErrorFactory = new PartialJoinPathProjectionErrorFactory();
                    return partialJoinPathProjectionErrorFactory.Create(partialJoinPathProjectionError);
                case "PartialQueryDerivationProjectionError":
                    var partialQueryDerivationProjectionError = dto as Kalliope.DTO.PartialQueryDerivationProjectionError;
                    var partialQueryDerivationProjectionErrorFactory = new PartialQueryDerivationProjectionErrorFactory();
                    return partialQueryDerivationProjectionErrorFactory.Create(partialQueryDerivationProjectionError);
                case "PartialRoleSetDerivationProjectionError":
                    var partialRoleSetDerivationProjectionError = dto as Kalliope.DTO.PartialRoleSetDerivationProjectionError;
                    var partialRoleSetDerivationProjectionErrorFactory = new PartialRoleSetDerivationProjectionErrorFactory();
                    return partialRoleSetDerivationProjectionErrorFactory.Create(partialRoleSetDerivationProjectionError);
                case "PathConditionRoleValueConstraint":
                    var pathConditionRoleValueConstraint = dto as Kalliope.DTO.PathConditionRoleValueConstraint;
                    var pathConditionRoleValueConstraintFactory = new PathConditionRoleValueConstraintFactory();
                    return pathConditionRoleValueConstraintFactory.Create(pathConditionRoleValueConstraint);
                case "PathConditionRoleValueRestriction":
                    var pathConditionRoleValueRestriction = dto as Kalliope.DTO.PathConditionRoleValueRestriction;
                    var pathConditionRoleValueRestrictionFactory = new PathConditionRoleValueRestrictionFactory();
                    return pathConditionRoleValueRestrictionFactory.Create(pathConditionRoleValueRestriction);
                case "PathConditionRootValueConstraint":
                    var pathConditionRootValueConstraint = dto as Kalliope.DTO.PathConditionRootValueConstraint;
                    var pathConditionRootValueConstraintFactory = new PathConditionRootValueConstraintFactory();
                    return pathConditionRootValueConstraintFactory.Create(pathConditionRootValueConstraint);
                case "PathConstant":
                    var pathConstant = dto as Kalliope.DTO.PathConstant;
                    var pathConstantFactory = new PathConstantFactory();
                    return pathConstantFactory.Create(pathConstant);
                case "PathedRole":
                    var pathedRole = dto as Kalliope.DTO.PathedRole;
                    var pathedRoleFactory = new PathedRoleFactory();
                    return pathedRoleFactory.Create(pathedRole);
                case "PathObjectUnifier":
                    var pathObjectUnifier = dto as Kalliope.DTO.PathObjectUnifier;
                    var pathObjectUnifierFactory = new PathObjectUnifierFactory();
                    return pathObjectUnifierFactory.Create(pathObjectUnifier);
                case "PathObjectUnifierRequiresCompatibleObjectTypesError":
                    var pathObjectUnifierRequiresCompatibleObjectTypesError = dto as Kalliope.DTO.PathObjectUnifierRequiresCompatibleObjectTypesError;
                    var pathObjectUnifierRequiresCompatibleObjectTypesErrorFactory = new PathObjectUnifierRequiresCompatibleObjectTypesErrorFactory();
                    return pathObjectUnifierRequiresCompatibleObjectTypesErrorFactory.Create(pathObjectUnifierRequiresCompatibleObjectTypesError);
                case "PathOuterJoinRequiresOptionalRoleError":
                    var pathOuterJoinRequiresOptionalRoleError = dto as Kalliope.DTO.PathOuterJoinRequiresOptionalRoleError;
                    var pathOuterJoinRequiresOptionalRoleErrorFactory = new PathOuterJoinRequiresOptionalRoleErrorFactory();
                    return pathOuterJoinRequiresOptionalRoleErrorFactory.Create(pathOuterJoinRequiresOptionalRoleError);
                case "PathRequiresRootObjectTypeError":
                    var pathRequiresRootObjectTypeError = dto as Kalliope.DTO.PathRequiresRootObjectTypeError;
                    var pathRequiresRootObjectTypeErrorFactory = new PathRequiresRootObjectTypeErrorFactory();
                    return pathRequiresRootObjectTypeErrorFactory.Create(pathRequiresRootObjectTypeError);
                case "PathSameFactTypeRoleFollowsJoinError":
                    var pathSameFactTypeRoleFollowsJoinError = dto as Kalliope.DTO.PathSameFactTypeRoleFollowsJoinError;
                    var pathSameFactTypeRoleFollowsJoinErrorFactory = new PathSameFactTypeRoleFollowsJoinErrorFactory();
                    return pathSameFactTypeRoleFollowsJoinErrorFactory.Create(pathSameFactTypeRoleFollowsJoinError);
                case "PathStartRoleFollowsRootObjectTypeError":
                    var pathStartRoleFollowsRootObjectTypeError = dto as Kalliope.DTO.PathStartRoleFollowsRootObjectTypeError;
                    var pathStartRoleFollowsRootObjectTypeErrorFactory = new PathStartRoleFollowsRootObjectTypeErrorFactory();
                    return pathStartRoleFollowsRootObjectTypeErrorFactory.Create(pathStartRoleFollowsRootObjectTypeError);
                case "PictureRawDataDataType":
                    var pictureRawDataDataType = dto as Kalliope.DTO.PictureRawDataDataType;
                    var pictureRawDataDataTypeFactory = new PictureRawDataDataTypeFactory();
                    return pictureRawDataDataTypeFactory.Create(pictureRawDataDataType);
                case "PopulationMandatoryError":
                    var populationMandatoryError = dto as Kalliope.DTO.PopulationMandatoryError;
                    var populationMandatoryErrorFactory = new PopulationMandatoryErrorFactory();
                    return populationMandatoryErrorFactory.Create(populationMandatoryError);
                case "PopulationUniquenessError":
                    var populationUniquenessError = dto as Kalliope.DTO.PopulationUniquenessError;
                    var populationUniquenessErrorFactory = new PopulationUniquenessErrorFactory();
                    return populationUniquenessErrorFactory.Create(populationUniquenessError);
                case "PreferredIdentifierRequiresMandatoryError":
                    var preferredIdentifierRequiresMandatoryError = dto as Kalliope.DTO.PreferredIdentifierRequiresMandatoryError;
                    var preferredIdentifierRequiresMandatoryErrorFactory = new PreferredIdentifierRequiresMandatoryErrorFactory();
                    return preferredIdentifierRequiresMandatoryErrorFactory.Create(preferredIdentifierRequiresMandatoryError);
                case "QueryDerivationPath":
                    var queryDerivationPath = dto as Kalliope.DTO.QueryDerivationPath;
                    var queryDerivationPathFactory = new QueryDerivationPathFactory();
                    return queryDerivationPathFactory.Create(queryDerivationPath);
                case "QueryDerivationRequiresProjectionError":
                    var queryDerivationRequiresProjectionError = dto as Kalliope.DTO.QueryDerivationRequiresProjectionError;
                    var queryDerivationRequiresProjectionErrorFactory = new QueryDerivationRequiresProjectionErrorFactory();
                    return queryDerivationRequiresProjectionErrorFactory.Create(queryDerivationRequiresProjectionError);
                case "QueryDerivationRule":
                    var queryDerivationRule = dto as Kalliope.DTO.QueryDerivationRule;
                    var queryDerivationRuleFactory = new QueryDerivationRuleFactory();
                    return queryDerivationRuleFactory.Create(queryDerivationRule);
                case "QueryParameter":
                    var queryParameter = dto as Kalliope.DTO.QueryParameter;
                    var queryParameterFactory = new QueryParameterFactory();
                    return queryParameterFactory.Create(queryParameter);
                case "QueryRoleProjectionCompatibilityError":
                    var queryRoleProjectionCompatibilityError = dto as Kalliope.DTO.QueryRoleProjectionCompatibilityError;
                    var queryRoleProjectionCompatibilityErrorFactory = new QueryRoleProjectionCompatibilityErrorFactory();
                    return queryRoleProjectionCompatibilityErrorFactory.Create(queryRoleProjectionCompatibilityError);
                case "Reading":
                    var reading = dto as Kalliope.DTO.Reading;
                    var readingFactory = new ReadingFactory();
                    return readingFactory.Create(reading);
                case "ReadingOrder":
                    var readingOrder = dto as Kalliope.DTO.ReadingOrder;
                    var readingOrderFactory = new ReadingOrderFactory();
                    return readingOrderFactory.Create(readingOrder);
                case "ReadingRequiresUserModificationError":
                    var readingRequiresUserModificationError = dto as Kalliope.DTO.ReadingRequiresUserModificationError;
                    var readingRequiresUserModificationErrorFactory = new ReadingRequiresUserModificationErrorFactory();
                    return readingRequiresUserModificationErrorFactory.Create(readingRequiresUserModificationError);
                case "ReadingShape":
                    var readingShape = dto as Kalliope.DTO.ReadingShape;
                    var readingShapeFactory = new ReadingShapeFactory();
                    return readingShapeFactory.Create(readingShape);
                case "RecognizedPhrase":
                    var recognizedPhrase = dto as Kalliope.DTO.RecognizedPhrase;
                    var recognizedPhraseFactory = new RecognizedPhraseFactory();
                    return recognizedPhraseFactory.Create(recognizedPhrase);
                case "RecognizedPhraseDuplicateNameError":
                    var recognizedPhraseDuplicateNameError = dto as Kalliope.DTO.RecognizedPhraseDuplicateNameError;
                    var recognizedPhraseDuplicateNameErrorFactory = new RecognizedPhraseDuplicateNameErrorFactory();
                    return recognizedPhraseDuplicateNameErrorFactory.Create(recognizedPhraseDuplicateNameError);
                case "ReferenceModeKind":
                    var referenceModeKind = dto as Kalliope.DTO.ReferenceModeKind;
                    var referenceModeKindFactory = new ReferenceModeKindFactory();
                    return referenceModeKindFactory.Create(referenceModeKind);
                case "RelationalElementsNotOnDiagramError":
                    var relationalElementsNotOnDiagramError = dto as Kalliope.DTO.RelationalElementsNotOnDiagramError;
                    var relationalElementsNotOnDiagramErrorFactory = new RelationalElementsNotOnDiagramErrorFactory();
                    return relationalElementsNotOnDiagramErrorFactory.Create(relationalElementsNotOnDiagramError);
                case "RelationalShapeMissingGroupType":
                    var relationalShapeMissingGroupType = dto as Kalliope.DTO.RelationalShapeMissingGroupType;
                    var relationalShapeMissingGroupTypeFactory = new RelationalShapeMissingGroupTypeFactory();
                    return relationalShapeMissingGroupTypeFactory.Create(relationalShapeMissingGroupType);
                case "RingConstraint":
                    var ringConstraint = dto as Kalliope.DTO.RingConstraint;
                    var ringConstraintFactory = new RingConstraintFactory();
                    return ringConstraintFactory.Create(ringConstraint);
                case "RingConstraintShape":
                    var ringConstraintShape = dto as Kalliope.DTO.RingConstraintShape;
                    var ringConstraintShapeFactory = new RingConstraintShapeFactory();
                    return ringConstraintShapeFactory.Create(ringConstraintShape);
                case "RingConstraintTypeNotSpecifiedError":
                    var ringConstraintTypeNotSpecifiedError = dto as Kalliope.DTO.RingConstraintTypeNotSpecifiedError;
                    var ringConstraintTypeNotSpecifiedErrorFactory = new RingConstraintTypeNotSpecifiedErrorFactory();
                    return ringConstraintTypeNotSpecifiedErrorFactory.Create(ringConstraintTypeNotSpecifiedError);
                case "Role":
                    var role = dto as Kalliope.DTO.Role;
                    var roleFactory = new RoleFactory();
                    return roleFactory.Create(role);
                case "RoleNameShape":
                    var roleNameShape = dto as Kalliope.DTO.RoleNameShape;
                    var roleNameShapeFactory = new RoleNameShapeFactory();
                    return roleNameShapeFactory.Create(roleNameShape);
                case "RolePlayerRequiredError":
                    var rolePlayerRequiredError = dto as Kalliope.DTO.RolePlayerRequiredError;
                    var rolePlayerRequiredErrorFactory = new RolePlayerRequiredErrorFactory();
                    return rolePlayerRequiredErrorFactory.Create(rolePlayerRequiredError);
                case "RoleProxy":
                    var roleProxy = dto as Kalliope.DTO.RoleProxy;
                    var roleProxyFactory = new RoleProxyFactory();
                    return roleProxyFactory.Create(roleProxy);
                case "RoleSubPath":
                    var roleSubPath = dto as Kalliope.DTO.RoleSubPath;
                    var roleSubPathFactory = new RoleSubPathFactory();
                    return roleSubPathFactory.Create(roleSubPath);
                case "RoleText":
                    var roleText = dto as Kalliope.DTO.RoleText;
                    var roleTextFactory = new RoleTextFactory();
                    return roleTextFactory.Create(roleText);
                case "RoleValueConstraint":
                    var roleValueConstraint = dto as Kalliope.DTO.RoleValueConstraint;
                    var roleValueConstraintFactory = new RoleValueConstraintFactory();
                    return roleValueConstraintFactory.Create(roleValueConstraint);
                case "RootObjectType":
                    var rootObjectType = dto as Kalliope.DTO.RootObjectType;
                    var rootObjectTypeFactory = new RootObjectTypeFactory();
                    return rootObjectTypeFactory.Create(rootObjectType);
                case "RowIdOtherDataType":
                    var rowIdOtherDataType = dto as Kalliope.DTO.RowIdOtherDataType;
                    var rowIdOtherDataTypeFactory = new RowIdOtherDataTypeFactory();
                    return rowIdOtherDataTypeFactory.Create(rowIdOtherDataType);
                case "SetComparisonConstraintRoleSequence":
                    var setComparisonConstraintRoleSequence = dto as Kalliope.DTO.SetComparisonConstraintRoleSequence;
                    var setComparisonConstraintRoleSequenceFactory = new SetComparisonConstraintRoleSequenceFactory();
                    return setComparisonConstraintRoleSequenceFactory.Create(setComparisonConstraintRoleSequence);
                case "ShapeColorGroupType":
                    var shapeColorGroupType = dto as Kalliope.DTO.ShapeColorGroupType;
                    var shapeColorGroupTypeFactory = new ShapeColorGroupTypeFactory();
                    return shapeColorGroupTypeFactory.Create(shapeColorGroupType);
                case "ShapeMissingGroupType":
                    var shapeMissingGroupType = dto as Kalliope.DTO.ShapeMissingGroupType;
                    var shapeMissingGroupTypeFactory = new ShapeMissingGroupTypeFactory();
                    return shapeMissingGroupTypeFactory.Create(shapeMissingGroupType);
                case "SignedIntegerNumericDataType":
                    var signedIntegerNumericDataType = dto as Kalliope.DTO.SignedIntegerNumericDataType;
                    var signedIntegerNumericDataTypeFactory = new SignedIntegerNumericDataTypeFactory();
                    return signedIntegerNumericDataTypeFactory.Create(signedIntegerNumericDataType);
                case "SignedLargeIntegerNumericDataType":
                    var signedLargeIntegerNumericDataType = dto as Kalliope.DTO.SignedLargeIntegerNumericDataType;
                    var signedLargeIntegerNumericDataTypeFactory = new SignedLargeIntegerNumericDataTypeFactory();
                    return signedLargeIntegerNumericDataTypeFactory.Create(signedLargeIntegerNumericDataType);
                case "SignedSmallIntegerNumericDataType":
                    var signedSmallIntegerNumericDataType = dto as Kalliope.DTO.SignedSmallIntegerNumericDataType;
                    var signedSmallIntegerNumericDataTypeFactory = new SignedSmallIntegerNumericDataTypeFactory();
                    return signedSmallIntegerNumericDataTypeFactory.Create(signedSmallIntegerNumericDataType);
                case "SinglePrecisionFloatingPointNumericDataType":
                    var singlePrecisionFloatingPointNumericDataType = dto as Kalliope.DTO.SinglePrecisionFloatingPointNumericDataType;
                    var singlePrecisionFloatingPointNumericDataTypeFactory = new SinglePrecisionFloatingPointNumericDataTypeFactory();
                    return singlePrecisionFloatingPointNumericDataTypeFactory.Create(singlePrecisionFloatingPointNumericDataType);
                case "Subquery":
                    var subquery = dto as Kalliope.DTO.Subquery;
                    var subqueryFactory = new SubqueryFactory();
                    return subqueryFactory.Create(subquery);
                case "SubsetConstraint":
                    var subsetConstraint = dto as Kalliope.DTO.SubsetConstraint;
                    var subsetConstraintFactory = new SubsetConstraintFactory();
                    return subsetConstraintFactory.Create(subsetConstraint);
                case "SubsetConstraintImpliedByMandatoryConstraintsError":
                    var subsetConstraintImpliedByMandatoryConstraintsError = dto as Kalliope.DTO.SubsetConstraintImpliedByMandatoryConstraintsError;
                    var subsetConstraintImpliedByMandatoryConstraintsErrorFactory = new SubsetConstraintImpliedByMandatoryConstraintsErrorFactory();
                    return subsetConstraintImpliedByMandatoryConstraintsErrorFactory.Create(subsetConstraintImpliedByMandatoryConstraintsError);
                case "SubtypeDerivationExpression":
                    var subtypeDerivationExpression = dto as Kalliope.DTO.SubtypeDerivationExpression;
                    var subtypeDerivationExpressionFactory = new SubtypeDerivationExpressionFactory();
                    return subtypeDerivationExpressionFactory.Create(subtypeDerivationExpression);
                case "SubtypeDerivationPath":
                    var subtypeDerivationPath = dto as Kalliope.DTO.SubtypeDerivationPath;
                    var subtypeDerivationPathFactory = new SubtypeDerivationPathFactory();
                    return subtypeDerivationPathFactory.Create(subtypeDerivationPath);
                case "SubtypeDerivationRule":
                    var subtypeDerivationRule = dto as Kalliope.DTO.SubtypeDerivationRule;
                    var subtypeDerivationRuleFactory = new SubtypeDerivationRuleFactory();
                    return subtypeDerivationRuleFactory.Create(subtypeDerivationRule);
                case "SubtypeFact":
                    var subtypeFact = dto as Kalliope.DTO.SubtypeFact;
                    var subtypeFactFactory = new SubtypeFactFactory();
                    return subtypeFactFactory.Create(subtypeFact);
                case "SubtypeLink":
                    var subtypeLink = dto as Kalliope.DTO.SubtypeLink;
                    var subtypeLinkFactory = new SubtypeLinkFactory();
                    return subtypeLinkFactory.Create(subtypeLink);
                case "SubtypeMetaRole":
                    var subtypeMetaRole = dto as Kalliope.DTO.SubtypeMetaRole;
                    var subtypeMetaRoleFactory = new SubtypeMetaRoleFactory();
                    return subtypeMetaRoleFactory.Create(subtypeMetaRole);
                case "SupersetRoleOfSubtypeSubsetConstraintNotSubtypeError":
                    var supersetRoleOfSubtypeSubsetConstraintNotSubtypeError = dto as Kalliope.DTO.SupersetRoleOfSubtypeSubsetConstraintNotSubtypeError;
                    var supersetRoleOfSubtypeSubsetConstraintNotSubtypeErrorFactory = new SupersetRoleOfSubtypeSubsetConstraintNotSubtypeErrorFactory();
                    return supersetRoleOfSubtypeSubsetConstraintNotSubtypeErrorFactory.Create(supersetRoleOfSubtypeSubsetConstraintNotSubtypeError);
                case "SupertypeMetaRole":
                    var supertypeMetaRole = dto as Kalliope.DTO.SupertypeMetaRole;
                    var supertypeMetaRoleFactory = new SupertypeMetaRoleFactory();
                    return supertypeMetaRoleFactory.Create(supertypeMetaRole);
                case "TimeTemporalDataType":
                    var timeTemporalDataType = dto as Kalliope.DTO.TimeTemporalDataType;
                    var timeTemporalDataTypeFactory = new TimeTemporalDataTypeFactory();
                    return timeTemporalDataTypeFactory.Create(timeTemporalDataType);
                case "TooFewEntityTypeRoleInstancesError":
                    var tooFewEntityTypeRoleInstancesError = dto as Kalliope.DTO.TooFewEntityTypeRoleInstancesError;
                    var tooFewEntityTypeRoleInstancesErrorFactory = new TooFewEntityTypeRoleInstancesErrorFactory();
                    return tooFewEntityTypeRoleInstancesErrorFactory.Create(tooFewEntityTypeRoleInstancesError);
                case "TooFewFactTypeRoleInstancesError":
                    var tooFewFactTypeRoleInstancesError = dto as Kalliope.DTO.TooFewFactTypeRoleInstancesError;
                    var tooFewFactTypeRoleInstancesErrorFactory = new TooFewFactTypeRoleInstancesErrorFactory();
                    return tooFewFactTypeRoleInstancesErrorFactory.Create(tooFewFactTypeRoleInstancesError);
                case "TooFewReadingRolesError":
                    var tooFewReadingRolesError = dto as Kalliope.DTO.TooFewReadingRolesError;
                    var tooFewReadingRolesErrorFactory = new TooFewReadingRolesErrorFactory();
                    return tooFewReadingRolesErrorFactory.Create(tooFewReadingRolesError);
                case "TooFewRoleSequencesError":
                    var tooFewRoleSequencesError = dto as Kalliope.DTO.TooFewRoleSequencesError;
                    var tooFewRoleSequencesErrorFactory = new TooFewRoleSequencesErrorFactory();
                    return tooFewRoleSequencesErrorFactory.Create(tooFewRoleSequencesError);
                case "TooManyReadingRolesError":
                    var tooManyReadingRolesError = dto as Kalliope.DTO.TooManyReadingRolesError;
                    var tooManyReadingRolesErrorFactory = new TooManyReadingRolesErrorFactory();
                    return tooManyReadingRolesErrorFactory.Create(tooManyReadingRolesError);
                case "TooManyRoleSequencesError":
                    var tooManyRoleSequencesError = dto as Kalliope.DTO.TooManyRoleSequencesError;
                    var tooManyRoleSequencesErrorFactory = new TooManyRoleSequencesErrorFactory();
                    return tooManyRoleSequencesErrorFactory.Create(tooManyRoleSequencesError);
                case "TrueOrFalseLogicalDataType":
                    var trueOrFalseLogicalDataType = dto as Kalliope.DTO.TrueOrFalseLogicalDataType;
                    var trueOrFalseLogicalDataTypeFactory = new TrueOrFalseLogicalDataTypeFactory();
                    return trueOrFalseLogicalDataTypeFactory.Create(trueOrFalseLogicalDataType);
                case "UnaryRoleCardinalityConstraint":
                    var unaryRoleCardinalityConstraint = dto as Kalliope.DTO.UnaryRoleCardinalityConstraint;
                    var unaryRoleCardinalityConstraintFactory = new UnaryRoleCardinalityConstraintFactory();
                    return unaryRoleCardinalityConstraintFactory.Create(unaryRoleCardinalityConstraint);
                case "UniquenessConstraint":
                    var uniquenessConstraint = dto as Kalliope.DTO.UniquenessConstraint;
                    var uniquenessConstraintFactory = new UniquenessConstraintFactory();
                    return uniquenessConstraintFactory.Create(uniquenessConstraint);
                case "UnsignedIntegerNumericDataType":
                    var unsignedIntegerNumericDataType = dto as Kalliope.DTO.UnsignedIntegerNumericDataType;
                    var unsignedIntegerNumericDataTypeFactory = new UnsignedIntegerNumericDataTypeFactory();
                    return unsignedIntegerNumericDataTypeFactory.Create(unsignedIntegerNumericDataType);
                case "UnsignedLargeIntegerNumericDataType":
                    var unsignedLargeIntegerNumericDataType = dto as Kalliope.DTO.UnsignedLargeIntegerNumericDataType;
                    var unsignedLargeIntegerNumericDataTypeFactory = new UnsignedLargeIntegerNumericDataTypeFactory();
                    return unsignedLargeIntegerNumericDataTypeFactory.Create(unsignedLargeIntegerNumericDataType);
                case "UnsignedSmallIntegerNumericDataType":
                    var unsignedSmallIntegerNumericDataType = dto as Kalliope.DTO.UnsignedSmallIntegerNumericDataType;
                    var unsignedSmallIntegerNumericDataTypeFactory = new UnsignedSmallIntegerNumericDataTypeFactory();
                    return unsignedSmallIntegerNumericDataTypeFactory.Create(unsignedSmallIntegerNumericDataType);
                case "UnsignedTinyIntegerNumericDataType":
                    var unsignedTinyIntegerNumericDataType = dto as Kalliope.DTO.UnsignedTinyIntegerNumericDataType;
                    var unsignedTinyIntegerNumericDataTypeFactory = new UnsignedTinyIntegerNumericDataTypeFactory();
                    return unsignedTinyIntegerNumericDataTypeFactory.Create(unsignedTinyIntegerNumericDataType);
                case "UnspecifiedDataType":
                    var unspecifiedDataType = dto as Kalliope.DTO.UnspecifiedDataType;
                    var unspecifiedDataTypeFactory = new UnspecifiedDataTypeFactory();
                    return unspecifiedDataTypeFactory.Create(unspecifiedDataType);
                case "UUIDNumericDataType":
                    var uUIDNumericDataType = dto as Kalliope.DTO.UUIDNumericDataType;
                    var uUIDNumericDataTypeFactory = new UUIDNumericDataTypeFactory();
                    return uUIDNumericDataTypeFactory.Create(uUIDNumericDataType);
                case "ValueComparisonConstraint":
                    var valueComparisonConstraint = dto as Kalliope.DTO.ValueComparisonConstraint;
                    var valueComparisonConstraintFactory = new ValueComparisonConstraintFactory();
                    return valueComparisonConstraintFactory.Create(valueComparisonConstraint);
                case "ValueComparisonConstraintOperatorNotSpecifiedError":
                    var valueComparisonConstraintOperatorNotSpecifiedError = dto as Kalliope.DTO.ValueComparisonConstraintOperatorNotSpecifiedError;
                    var valueComparisonConstraintOperatorNotSpecifiedErrorFactory = new ValueComparisonConstraintOperatorNotSpecifiedErrorFactory();
                    return valueComparisonConstraintOperatorNotSpecifiedErrorFactory.Create(valueComparisonConstraintOperatorNotSpecifiedError);
                case "ValueComparisonConstraintShape":
                    var valueComparisonConstraintShape = dto as Kalliope.DTO.ValueComparisonConstraintShape;
                    var valueComparisonConstraintShapeFactory = new ValueComparisonConstraintShapeFactory();
                    return valueComparisonConstraintShapeFactory.Create(valueComparisonConstraintShape);
                case "ValueComparisonRolesNotComparableError":
                    var valueComparisonRolesNotComparableError = dto as Kalliope.DTO.ValueComparisonRolesNotComparableError;
                    var valueComparisonRolesNotComparableErrorFactory = new ValueComparisonRolesNotComparableErrorFactory();
                    return valueComparisonRolesNotComparableErrorFactory.Create(valueComparisonRolesNotComparableError);
                case "ValueConstraintShape":
                    var valueConstraintShape = dto as Kalliope.DTO.ValueConstraintShape;
                    var valueConstraintShapeFactory = new ValueConstraintShapeFactory();
                    return valueConstraintShapeFactory.Create(valueConstraintShape);
                case "ValueConstraintValueTypeDetachedError":
                    var valueConstraintValueTypeDetachedError = dto as Kalliope.DTO.ValueConstraintValueTypeDetachedError;
                    var valueConstraintValueTypeDetachedErrorFactory = new ValueConstraintValueTypeDetachedErrorFactory();
                    return valueConstraintValueTypeDetachedErrorFactory.Create(valueConstraintValueTypeDetachedError);
                case "ValueRange":
                    var valueRange = dto as Kalliope.DTO.ValueRange;
                    var valueRangeFactory = new ValueRangeFactory();
                    return valueRangeFactory.Create(valueRange);
                case "ValueRangeOverlapError":
                    var valueRangeOverlapError = dto as Kalliope.DTO.ValueRangeOverlapError;
                    var valueRangeOverlapErrorFactory = new ValueRangeOverlapErrorFactory();
                    return valueRangeOverlapErrorFactory.Create(valueRangeOverlapError);
                case "ValueType":
                    var valueType = dto as Kalliope.DTO.ValueType;
                    var valueTypeFactory = new ValueTypeFactory();
                    return valueTypeFactory.Create(valueType);
                case "ValueTypeInstance":
                    var valueTypeInstance = dto as Kalliope.DTO.ValueTypeInstance;
                    var valueTypeInstanceFactory = new ValueTypeInstanceFactory();
                    return valueTypeInstanceFactory.Create(valueTypeInstance);
                case "ValueTypeValueConstraint":
                    var valueTypeValueConstraint = dto as Kalliope.DTO.ValueTypeValueConstraint;
                    var valueTypeValueConstraintFactory = new ValueTypeValueConstraintFactory();
                    return valueTypeValueConstraintFactory.Create(valueTypeValueConstraint);
                case "VariableLengthRawDataDataType":
                    var variableLengthRawDataDataType = dto as Kalliope.DTO.VariableLengthRawDataDataType;
                    var variableLengthRawDataDataTypeFactory = new VariableLengthRawDataDataTypeFactory();
                    return variableLengthRawDataDataTypeFactory.Create(variableLengthRawDataDataType);
                case "VariableLengthTextDataType":
                    var variableLengthTextDataType = dto as Kalliope.DTO.VariableLengthTextDataType;
                    var variableLengthTextDataTypeFactory = new VariableLengthTextDataTypeFactory();
                    return variableLengthTextDataTypeFactory.Create(variableLengthTextDataType);
                case "YesOrNoLogicalDataType":
                    var yesOrNoLogicalDataType = dto as Kalliope.DTO.YesOrNoLogicalDataType;
                    var yesOrNoLogicalDataTypeFactory = new YesOrNoLogicalDataTypeFactory();
                    return yesOrNoLogicalDataTypeFactory.Create(yesOrNoLogicalDataType);
                default:
                    throw new System.NotSupportedException($"{typeName} not yet supported");
            }
        }
    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
