// -------------------------------------------------------------------------------------------------
// <copyright file="OrmRootXmlReader.cs" company="RHEA System S.A.">
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

namespace Kalliope.Xml.Readers
{
    using System.Collections.Generic;
    using System.Xml;

    using Kalliope.DTO;
    
    /// <summary>
    /// The purpose of the <see cref="ORMModelXmlReader"/> is to read the contents of the
    /// <see cref="ORMModel"/> XML element
    /// </summary>
    public class ORMModelXmlReader : ORMNamedElementXmlReader
    {
        /// <summary>
        /// Generates a <see cref="ORMModel"/> object from its XML representation.
        /// </summary>
        /// <param name="ormModel">
        /// The subject <see cref="ORMModel"/> that is to be deserialized
        /// </param>
        /// <param name="reader">
        /// an instance of <see cref="XmlReader"/> used to read the .orm file
        /// </param>
        /// <param name="modelThings">
        /// a list of <see cref="ModelThing"/>s to which the deserialized items are added
        /// </param>
        public void ReadXml(ORMModel ormModel, XmlReader reader, List<ModelThing> modelThings)
        {
            base.ReadXml(ormModel, reader, modelThings);

            while (reader.Read())
            {
                if (reader.MoveToContent() == XmlNodeType.Element)
                {
                    var localName = reader.LocalName;

                    switch (localName)
                    {
                        case "Objects":
                            using (var objectsSubtree = reader.ReadSubtree())
                            {
                                objectsSubtree.MoveToContent();
                                this.ReadObjects(ormModel, objectsSubtree, modelThings);
                            }
                            break;
                        case "Facts":
                            using (var factsSubtree = reader.ReadSubtree())
                            {
                                factsSubtree.MoveToContent();
                                this.ReadFacts(ormModel, factsSubtree, modelThings);
                            }
                            break;
                        case "Constraints":
                            using (var constraintsSubTree = reader.ReadSubtree())
                            {
                                constraintsSubTree.MoveToContent();
                                this.ReadConstraints(ormModel, constraintsSubTree, modelThings);
                            }
                            break;
                        case "DataTypes":
                            using (var dataTypesSubtree = reader.ReadSubtree())
                            {
                                dataTypesSubtree.MoveToContent();
                                this.ReadDataTypes(ormModel, dataTypesSubtree, modelThings);
                            }
                            break;
                        case "CustomReferenceModes":
                            using (var customReferenceModesSubtree = reader.ReadSubtree())
                            {
                                customReferenceModesSubtree.MoveToContent();
                                this.ReadCustomReferenceModes(ormModel, customReferenceModesSubtree, modelThings);
                            }
                            break;
                        case "ModelNotes":
                            using (var modelNotesSubtree = reader.ReadSubtree())
                            {
                                modelNotesSubtree.MoveToContent();
                                this.ReadModelNotes(ormModel, modelNotesSubtree, modelThings);
                            }
                            break;
                        case "ReferenceModeKinds":
                            using (var referenceModeKindsSubtree = reader.ReadSubtree())
                            {
                                referenceModeKindsSubtree.MoveToContent();
                                this.ReadReferenceModeKinds(ormModel, referenceModeKindsSubtree, modelThings);
                            }
                            break;
                        default:
                            throw new System.NotSupportedException($"{localName} not yet supported");
                    }
                }
            }
        }

        /// <summary>
        /// Reads <see cref="ObjectType"/>s from the .orm file
        /// </summary>
        /// <param name="ormModel">
        /// The subject <see cref="ORMModel"/> that is to be deserialized and is the container of the <see cref="ObjectType"/>s
        /// </param>
        /// <param name="reader">
        /// an instance of <see cref="XmlReader"/> used to read the .orm file
        /// </param>
        /// <param name="modelThings">
        /// a list of <see cref="ModelThing"/>s to which the deserialized items are added
        /// </param>
        private void ReadObjects(ORMModel ormModel, XmlReader reader, List<ModelThing> modelThings)
        {
            while (reader.Read())
            {
                if (reader.MoveToContent() == XmlNodeType.Element)
                {
                    var localName = reader.LocalName;

                    switch (localName)
                    {
                        case "EntityType":
                            using (var entityTypeSubtree = reader.ReadSubtree())
                            {
                                entityTypeSubtree.MoveToContent();
                                var entityType = new EntityType();
                                var entityTypeXmlReader = new EntityTypeXmlReader();
                                entityTypeXmlReader.ReadXml(entityType, entityTypeSubtree, modelThings);
                                entityType.Container = ormModel.Id;
                                ormModel.ObjectTypes.Add(entityType.Id);
                            }
                            break;
                        case "ValueType":
                            using (var valueTypeSubtree = reader.ReadSubtree())
                            {
                                valueTypeSubtree.MoveToContent();
                                var valueType = new ValueType();
                                var valueTypeXmlReader = new ValueTypeXmlReader();
                                valueTypeXmlReader.ReadXml(valueType, valueTypeSubtree, modelThings);
                                valueType.Container = ormModel.Id;
                                ormModel.ObjectTypes.Add(valueType.Id);
                            }
                            break;
                        case "ObjectifiedType":
                            using (var objectifiedTypeSubtree = reader.ReadSubtree())
                            {
                                objectifiedTypeSubtree.MoveToContent();
                                var objectifiedType = new ObjectifiedType();
                                var objectifiedTypeXmlReader = new ObjectifiedTypeXmlReader();
                                objectifiedTypeXmlReader.ReadXml(objectifiedType, objectifiedTypeSubtree, modelThings);
                                objectifiedType.Container = ormModel.Id;
                                ormModel.ObjectTypes.Add(objectifiedType.Id);
                            }
                            break;
                        default:
                            throw new System.NotSupportedException($"{localName} not yet supported");
                    }
                }
            }
        }

        /// <summary>
        /// Reads the <see cref="FactType"/>s
        /// </summary>
        /// <param name="ormModel">
        /// The subject <see cref="ORMModel"/> that is to be deserialized and is the container of the <see cref="FactType"/>s
        /// </param>
        /// <param name="reader">
        /// an instance of <see cref="XmlReader"/> used to read the .orm file
        /// </param>
        /// <param name="modelThings">
        /// a list of <see cref="ModelThing"/>s to which the deserialized items are added
        /// </param>
        private void ReadFacts(ORMModel ormModel, XmlReader reader, List<ModelThing> modelThings)
        {
            while (reader.Read())
            {
                if (reader.MoveToContent() == XmlNodeType.Element)
                {
                    var localName = reader.LocalName;

                    switch (localName)
                    {
                        case "Fact":
                            using (var factSubtree = reader.ReadSubtree())
                            {
                                factSubtree.MoveToContent();
                                var factType = new FactType();
                                var factTypeXmlReader = new FactTypeXmlReader();
                                factTypeXmlReader.ReadXml(factType, factSubtree, modelThings);
                                factType.Container = ormModel.Id;
                                ormModel.FactTypes.Add(factType.Id);
                            }
                            break;
                        case "ImpliedFact":
                            using (var impliedFactSubtree = reader.ReadSubtree())
                            {
                                impliedFactSubtree.MoveToContent();
                                var impliedFact = new ImpliedFactType();
                                var impliedFactXmlReader = new ImpliedFactTypeXmlReader();
                                impliedFactXmlReader.ReadXml(impliedFact, impliedFactSubtree, modelThings);
                                impliedFact.Container = ormModel.Id;
                                ormModel.FactTypes.Add(impliedFact.Id);
                            }
                            break;
                        case "SubtypeFact":
                            using (var subtypeFactSubtree = reader.ReadSubtree())
                            {
                                subtypeFactSubtree.MoveToContent();
                                var subtypeFact = new SubtypeFact();
                                var subtypeFactXmlReader = new SubtypeFactXmlReader();
                                subtypeFactXmlReader.ReadXml(subtypeFact, subtypeFactSubtree, modelThings);
                                subtypeFact.Container = ormModel.Id;
                                ormModel.FactTypes.Add(subtypeFact.Id);
                            }
                            break;
                        default:
                            throw new System.NotSupportedException($"{localName} not yet supported");
                    }
                }
            }
        }

        /// <summary>
        /// Reads the Constraints
        /// </summary>
        /// <param name="ormModel">
        /// The subject <see cref="ORMModel"/> that is to be deserialized and is the container
        /// of the <see cref="SetConstraint"/>s and <see cref="SetComparisonConstraint"/>s
        /// </param>
        /// <param name="reader">
        /// an instance of <see cref="XmlReader"/> used to read the .orm file
        /// </param>
        /// <param name="modelThings">
        /// a list of <see cref="ModelThing"/>s to which the deserialized items are added
        /// </param>
        private void ReadConstraints(ORMModel ormModel, XmlReader reader, List<ModelThing> modelThings)
        {
            while (reader.Read())
            {
                if (reader.MoveToContent() == XmlNodeType.Element)
                {
                    var localName = reader.LocalName;

                    switch (localName)
                    {
                        case "EqualityConstraint":
                            using (var constraintSubtree = reader.ReadSubtree())
                            {
                                constraintSubtree.MoveToContent();
                                var equalityConstraint = new EqualityConstraint();
                                var equalityConstraintXmlReader = new EqualityConstraintXmlReader();
                                equalityConstraintXmlReader.ReadXml(equalityConstraint, constraintSubtree, modelThings);
                                equalityConstraint.Container = ormModel.Id;
                                ormModel.SetComparisonConstraints.Add(equalityConstraint.Id);
                            }
                            break;
                        case "ExclusionConstraint":
                            using (var constraintSubtree = reader.ReadSubtree())
                            {
                                constraintSubtree.MoveToContent();
                                var exclusionConstraint = new ExclusionConstraint();
                                var exclusionConstraintXmlReader = new ExclusionConstraintXmlReader();
                                exclusionConstraintXmlReader.ReadXml(exclusionConstraint, constraintSubtree, modelThings);
                                exclusionConstraint.Container = ormModel.Id;
                                ormModel.SetComparisonConstraints.Add(exclusionConstraint.Id);
                            }
                            break;
                        case "FrequencyConstraint":
                            using (var constraintSubtree = reader.ReadSubtree())
                            {
                                constraintSubtree.MoveToContent();
                                var frequencyConstraint = new FrequencyConstraint();
                                var frequencyConstraintXmlReader = new FrequencyConstraintXmlReader();
                                frequencyConstraintXmlReader.ReadXml(frequencyConstraint, constraintSubtree, modelThings);
                                frequencyConstraint.Container = ormModel.Id;
                                ormModel.SetConstraints.Add(frequencyConstraint.Id);
                            }
                            break;
                        case "MandatoryConstraint":
                            using (var constraintSubtree = reader.ReadSubtree())
                            {
                                constraintSubtree.MoveToContent();
                                var mandatoryConstraint = new MandatoryConstraint();
                                var mandatoryConstraintXmlReader = new MandatoryConstraintXmlReader();
                                mandatoryConstraintXmlReader.ReadXml(mandatoryConstraint, constraintSubtree, modelThings);
                                mandatoryConstraint.Container = ormModel.Id;
                                ormModel.SetConstraints.Add(mandatoryConstraint.Id);
                            }
                            break;
                        case "RingConstraint":
                            using (var constraintSubtree = reader.ReadSubtree())
                            {
                                constraintSubtree.MoveToContent();
                                var ringConstraint = new RingConstraint();
                                var ringConstraintXmlReader = new RingConstraintXmlReader();
                                ringConstraintXmlReader.ReadXml(ringConstraint, constraintSubtree, modelThings);
                                ringConstraint.Container = ormModel.Id;
                                ormModel.SetConstraints.Add(ringConstraint.Id);
                            }
                            break;
                        case "SubsetConstraint":
                            using (var constraintSubtree = reader.ReadSubtree())
                            {
                                constraintSubtree.MoveToContent();
                                var subsetConstraint = new SubsetConstraint();
                                var subsetConstraintXmlReader = new SubsetConstraintXmlReader();
                                subsetConstraintXmlReader.ReadXml(subsetConstraint, constraintSubtree, modelThings);
                                subsetConstraint.Container = ormModel.Id;
                                ormModel.SetComparisonConstraints.Add(subsetConstraint.Id);
                            }
                            break;
                        case "UniquenessConstraint":
                            using (var constraintSubtree = reader.ReadSubtree())
                            {
                                constraintSubtree.MoveToContent();
                                var uniquenessConstraint = new UniquenessConstraint();
                                var uniquenessConstraintXmlReader = new UniquenessConstraintXmlReader();
                                uniquenessConstraintXmlReader.ReadXml(uniquenessConstraint, constraintSubtree, modelThings);
                                uniquenessConstraint.Container = ormModel.Id;
                                ormModel.SetConstraints.Add(uniquenessConstraint.Id);
                            }
                            break;
                        case "ValueComparisonConstraint":
                            using (var constraintSubtree = reader.ReadSubtree())
                            {
                                constraintSubtree.MoveToContent();
                                var valueComparisonConstraint = new ValueComparisonConstraint();
                                var valueComparisonConstraintXmlReader = new ValueComparisonConstraintXmlReader();
                                valueComparisonConstraintXmlReader.ReadXml(valueComparisonConstraint, constraintSubtree, modelThings);
                                valueComparisonConstraint.Container = ormModel.Id;
                                ormModel.SetConstraints.Add(valueComparisonConstraint.Id);
                            }
                            break;
                        default:
                            throw new System.NotSupportedException($"{localName} not yet supported");
                    }
                }
            }
        }

        /// <summary>
        /// Reads the <see cref="DataType"/>s
        /// </summary>
        /// <param name="ormModel">
        /// The subject <see cref="ORMModel"/> that is to be deserialized and is the container of the <see cref="DataType"/>s
        /// </param>
        /// <param name="reader">
        /// an instance of <see cref="XmlReader"/> used to read the .orm file
        /// </param>
        /// <param name="modelThings">
        /// a list of <see cref="ModelThing"/>s to which the deserialized items are added
        /// </param>
        private void ReadDataTypes(ORMModel ormModel, XmlReader reader, List<ModelThing> modelThings)
        {
            while (reader.Read())
            {
                if (reader.MoveToContent() == XmlNodeType.Element)
                {
                    var localName = reader.LocalName;

                    switch (localName)
                    {
                        case "AutoCounterNumericDataType":
                            using (var dataTypeSubtree = reader.ReadSubtree())
                            {
                                dataTypeSubtree.MoveToContent();
                                var autoCounterNumericDataType = new AutoCounterNumericDataType();
                                var autoCounterNumericDataTypeXmlReader = new AutoCounterNumericDataTypeXmlReader();
                                autoCounterNumericDataTypeXmlReader.ReadXml(autoCounterNumericDataType, dataTypeSubtree, modelThings );
                                autoCounterNumericDataType.Container = ormModel.Id;
                                ormModel.DataTypes.Add(autoCounterNumericDataType.Id);
                            }
                            break;
                        case "AutoTimestampTemporalDataType":
                            using (var dataTypeSubtree = reader.ReadSubtree())
                            {
                                dataTypeSubtree.MoveToContent();
                                var autoTimestampTemporalDataType = new AutoTimestampTemporalDataType();
                                var autoTimestampTemporalDataTypeXmlReader = new AutoTimestampTemporalDataTypeXmlReader();
                                autoTimestampTemporalDataTypeXmlReader.ReadXml(autoTimestampTemporalDataType, dataTypeSubtree, modelThings);
                                autoTimestampTemporalDataType.Container = ormModel.Id;
                                ormModel.DataTypes.Add(autoTimestampTemporalDataType.Id);
                            }
                            break;
                        case "DateAndTimeTemporalDataType":
                            using (var dataTypeSubtree = reader.ReadSubtree())
                            {
                                dataTypeSubtree.MoveToContent();
                                var dateAndTimeTemporalDataType = new DateAndTimeTemporalDataType();
                                var dateAndTimeTemporalDataTypeXmlReader = new DateAndTimeTemporalDataTypeXmlReader();
                                dateAndTimeTemporalDataTypeXmlReader.ReadXml(dateAndTimeTemporalDataType, dataTypeSubtree, modelThings);
                                dateAndTimeTemporalDataType.Container = ormModel.Id;
                                ormModel.DataTypes.Add(dateAndTimeTemporalDataType.Id);
                            }
                            break;
                        case "DateTemporalDataType":
                            using (var dataTypeSubtree = reader.ReadSubtree())
                            {
                                dataTypeSubtree.MoveToContent();
                                var dateTemporalDataType = new DateTemporalDataType();
                                var dateTemporalDataTypeXmlReader = new DateTemporalDataTypeXmlReader();
                                dateTemporalDataTypeXmlReader.ReadXml(dateTemporalDataType, dataTypeSubtree, modelThings );
                                dateTemporalDataType.Container = ormModel.Id;
                                ormModel.DataTypes.Add(dateTemporalDataType.Id);
                            }
                            break;
                        case "DecimalNumericDataType":
                            using (var dataTypeSubtree = reader.ReadSubtree())
                            {
                                dataTypeSubtree.MoveToContent();
                                var decimalNumericDataType = new DecimalNumericDataType();
                                var decimalNumericDataTypeXmlReader = new DecimalNumericDataTypeXmlReader();
                                decimalNumericDataTypeXmlReader.ReadXml(decimalNumericDataType, dataTypeSubtree, modelThings);
                                decimalNumericDataType.Container = ormModel.Id;
                                ormModel.DataTypes.Add(decimalNumericDataType.Id);
                            }
                            break;
                        case "DoublePrecisionFloatingPointNumericDataType":
                            using (var dataTypeSubtree = reader.ReadSubtree())
                            {
                                dataTypeSubtree.MoveToContent();
                                var doublePrecisionFloatingPointNumericDataType = new DoublePrecisionFloatingPointNumericDataType();
                                var doublePrecisionFloatingPointNumericDataTypeXmlReader = new DoublePrecisionFloatingPointNumericDataTypeXmlReader();
                                doublePrecisionFloatingPointNumericDataTypeXmlReader.ReadXml(doublePrecisionFloatingPointNumericDataType, dataTypeSubtree, modelThings);
                                doublePrecisionFloatingPointNumericDataType.Container = ormModel.Id;
                                ormModel.DataTypes.Add(doublePrecisionFloatingPointNumericDataType.Id);
                            }
                            break;
                        case "FixedLengthRawDataDataType":
                            using (var dataTypeSubtree = reader.ReadSubtree())
                            {
                                dataTypeSubtree.MoveToContent();
                                var fixedLengthRawDataDataType = new FixedLengthRawDataDataType();
                                var fixedLengthRawDataDataTypeXmlReader = new FixedLengthRawDataDataTypeXmlReader();
                                fixedLengthRawDataDataTypeXmlReader.ReadXml(fixedLengthRawDataDataType, dataTypeSubtree, modelThings);
                                fixedLengthRawDataDataType.Container = ormModel.Id;
                                ormModel.DataTypes.Add(fixedLengthRawDataDataType.Id);
                            }
                            break;
                        case "FixedLengthTextDataType":
                            using (var dataTypeSubtree = reader.ReadSubtree())
                            {
                                dataTypeSubtree.MoveToContent();
                                var fixedLengthTextDataType = new FixedLengthTextDataType();
                                var fixedLengthTextDataTypeXmlReader = new FixedLengthTextDataTypeXmlReader();
                                fixedLengthTextDataTypeXmlReader.ReadXml(fixedLengthTextDataType, dataTypeSubtree, modelThings);
                                fixedLengthTextDataType.Container = ormModel.Id;
                                ormModel.DataTypes.Add(fixedLengthTextDataType.Id);
                            }
                            break;
                        case "FloatingPointNumericDataType":
                            using (var dataTypeSubtree = reader.ReadSubtree())
                            {
                                dataTypeSubtree.MoveToContent();
                                var floatingPointNumericDataType = new FloatingPointNumericDataType();
                                var floatingPointNumericDataTypeXmlReader = new FloatingPointNumericDataTypeXmlReader();
                                floatingPointNumericDataTypeXmlReader.ReadXml(floatingPointNumericDataType, dataTypeSubtree, modelThings);
                                floatingPointNumericDataType.Container = ormModel.Id;
                                ormModel.DataTypes.Add(floatingPointNumericDataType.Id);
                            }
                            break;
                        case "LargeLengthRawDataDataType":
                            using (var dataTypeSubtree = reader.ReadSubtree())
                            {
                                dataTypeSubtree.MoveToContent();
                                var largeLengthRawDataDataType = new LargeLengthRawDataDataType();
                                var largeLengthRawDataDataTypeXmlReader = new LargeLengthRawDataDataTypeXmlReader();
                                largeLengthRawDataDataTypeXmlReader.ReadXml(largeLengthRawDataDataType, dataTypeSubtree, modelThings);
                                largeLengthRawDataDataType.Container = ormModel.Id;
                                ormModel.DataTypes.Add(largeLengthRawDataDataType.Id);
                            }
                            break;
                        case "LargeLengthTextDataType":
                            using (var dataTypeSubtree = reader.ReadSubtree())
                            {
                                dataTypeSubtree.MoveToContent();
                                var largeLengthTextDataType = new LargeLengthTextDataType();
                                var largeLengthTextDataTypeXmlReader = new LargeLengthTextDataTypeXmlReader();
                                largeLengthTextDataTypeXmlReader.ReadXml(largeLengthTextDataType, dataTypeSubtree, modelThings);
                                largeLengthTextDataType.Container = ormModel.Id;
                                ormModel.DataTypes.Add(largeLengthTextDataType.Id);
                            }
                            break;
                        case "MoneyNumericDataType":
                            using (var dataTypeSubtree = reader.ReadSubtree())
                            {
                                dataTypeSubtree.MoveToContent();
                                var moneyNumericDataType = new MoneyNumericDataType();
                                var moneyNumericDataTypeXmlReader = new MoneyNumericDataTypeXmlReader();
                                moneyNumericDataTypeXmlReader.ReadXml(moneyNumericDataType, dataTypeSubtree, modelThings);
                                moneyNumericDataType.Container = ormModel.Id;
                                ormModel.DataTypes.Add(moneyNumericDataType.Id);
                            }
                            break;
                        case "ObjectIdOtherDataType":
                            using (var dataTypeSubtree = reader.ReadSubtree())
                            {
                                dataTypeSubtree.MoveToContent();
                                var objectIdOtherDataType = new ObjectIdOtherDataType();
                                var objectIdOtherDataTypeXmlReader = new ObjectIdOtherDataTypeXmlReader();
                                objectIdOtherDataTypeXmlReader.ReadXml(objectIdOtherDataType, dataTypeSubtree, modelThings);
                                objectIdOtherDataType.Container = ormModel.Id;
                                ormModel.DataTypes.Add(objectIdOtherDataType.Id);
                            }
                            break;
                        case "OleObjectRawDataDataType":
                            using (var dataTypeSubtree = reader.ReadSubtree())
                            {
                                dataTypeSubtree.MoveToContent();
                                var oleObjectRawDataDataType = new OleObjectRawDataDataType();
                                var oleObjectRawDataDataTypeXmlReader = new OleObjectRawDataDataTypeXmlReader();
                                oleObjectRawDataDataTypeXmlReader.ReadXml(oleObjectRawDataDataType, dataTypeSubtree, modelThings);
                                oleObjectRawDataDataType.Container = ormModel.Id;
                                ormModel.DataTypes.Add(oleObjectRawDataDataType.Id);
                            }
                            break;
                        case "PictureRawDataDataType":
                            using (var dataTypeSubtree = reader.ReadSubtree())
                            {
                                dataTypeSubtree.MoveToContent();
                                var pictureRawDataDataType = new PictureRawDataDataType();
                                var pictureRawDataDataTypeXmlReader = new PictureRawDataDataTypeXmlReader();
                                pictureRawDataDataTypeXmlReader.ReadXml(pictureRawDataDataType, dataTypeSubtree, modelThings);
                                pictureRawDataDataType.Container = ormModel.Id;
                                ormModel.DataTypes.Add(pictureRawDataDataType.Id);
                            }
                            break;
                        case "RowIdOtherDataType":
                            using (var dataTypeSubtree = reader.ReadSubtree())
                            {
                                dataTypeSubtree.MoveToContent();
                                var rowIdOtherDataType = new RowIdOtherDataType();
                                var rowIdOtherDataTypeXmlReader = new RowIdOtherDataTypeXmlReader();
                                rowIdOtherDataTypeXmlReader.ReadXml(rowIdOtherDataType, dataTypeSubtree, modelThings);
                                rowIdOtherDataType.Container = ormModel.Id;
                                ormModel.DataTypes.Add(rowIdOtherDataType.Id);
                            }
                            break;
                        case "SignedIntegerNumericDataType":
                            using (var dataTypeSubtree = reader.ReadSubtree())
                            {
                                dataTypeSubtree.MoveToContent();
                                var signedIntegerNumericDataType = new SignedIntegerNumericDataType();
                                var signedIntegerNumericDataTypeXmlReader = new SignedIntegerNumericDataTypeXmlReader();
                                signedIntegerNumericDataTypeXmlReader.ReadXml(signedIntegerNumericDataType, dataTypeSubtree, modelThings);
                                signedIntegerNumericDataType.Container = ormModel.Id;
                                ormModel.DataTypes.Add(signedIntegerNumericDataType.Id);
                            }
                            break;
                        case "SignedLargeIntegerNumericDataType":
                            using (var dataTypeSubtree = reader.ReadSubtree())
                            {
                                dataTypeSubtree.MoveToContent();
                                var signedLargeIntegerNumericDataType = new SignedLargeIntegerNumericDataType();
                                var signedLargeIntegerNumericDataTypeXmlReader = new SignedLargeIntegerNumericDataTypeXmlReader();
                                signedLargeIntegerNumericDataTypeXmlReader.ReadXml(signedLargeIntegerNumericDataType, dataTypeSubtree, modelThings);
                                signedLargeIntegerNumericDataType.Container = ormModel.Id;
                                ormModel.DataTypes.Add(signedLargeIntegerNumericDataType.Id);
                            }
                            break;
                        case "SignedSmallIntegerNumericDataType":
                            using (var dataTypeSubtree = reader.ReadSubtree())
                            {
                                dataTypeSubtree.MoveToContent();
                                var smallIntegerNumericDataType = new SignedSmallIntegerNumericDataType();
                                var smallIntegerNumericDataTypeXmlReader = new SignedSmallIntegerNumericDataTypeXmlReader();
                                smallIntegerNumericDataTypeXmlReader.ReadXml(smallIntegerNumericDataType, dataTypeSubtree, modelThings);
                                smallIntegerNumericDataType.Container = ormModel.Id;
                                ormModel.DataTypes.Add(smallIntegerNumericDataType.Id);
                            }
                            break;
                        case "SinglePrecisionFloatingPointNumericDataType":
                            using (var dataTypeSubtree = reader.ReadSubtree())
                            {
                                dataTypeSubtree.MoveToContent();
                                var singlePrecisionFloatingPointNumericDataType = new SinglePrecisionFloatingPointNumericDataType();
                                var singlePrecisionFloatingPointNumericDataTypeXmlReader = new SinglePrecisionFloatingPointNumericDataTypeXmlReader();
                                singlePrecisionFloatingPointNumericDataTypeXmlReader.ReadXml(singlePrecisionFloatingPointNumericDataType, dataTypeSubtree, modelThings);
                                singlePrecisionFloatingPointNumericDataType.Container = ormModel.Id;
                                ormModel.DataTypes.Add(singlePrecisionFloatingPointNumericDataType.Id);
                            }
                            break;
                        case "TimeTemporalDataType":
                            using (var dataTypeSubtree = reader.ReadSubtree())
                            {
                                dataTypeSubtree.MoveToContent();
                                var timeTemporalDataType = new TimeTemporalDataType();
                                var timeTemporalDataTypeXmlReader = new TimeTemporalDataTypeXmlReader();
                                timeTemporalDataTypeXmlReader.ReadXml(timeTemporalDataType, dataTypeSubtree, modelThings);
                                timeTemporalDataType.Container = ormModel.Id;
                                ormModel.DataTypes.Add(timeTemporalDataType.Id);
                            }
                            break;
                        case "TrueOrFalseLogicalDataType":
                            using (var dataTypeSubtree = reader.ReadSubtree())
                            {
                                dataTypeSubtree.MoveToContent();
                                var trueOrFalseLogicalDataType = new TrueOrFalseLogicalDataType();
                                var trueOrFalseLogicalDataTypeXmlReader = new TrueOrFalseLogicalDataTypeXmlReader();
                                trueOrFalseLogicalDataTypeXmlReader.ReadXml(trueOrFalseLogicalDataType, dataTypeSubtree, modelThings);
                                trueOrFalseLogicalDataType.Container = ormModel.Id;
                                ormModel.DataTypes.Add(trueOrFalseLogicalDataType.Id);
                            }
                            break;
                        case "UnsignedIntegerNumericDataType":
                            using (var dataTypeSubtree = reader.ReadSubtree())
                            {
                                dataTypeSubtree.MoveToContent();
                                var unsignedIntegerNumericDataType = new UnsignedIntegerNumericDataType();
                                var unsignedIntegerNumericDataTypeXmlReader = new UnsignedIntegerNumericDataTypeXmlReader();
                                unsignedIntegerNumericDataTypeXmlReader.ReadXml(unsignedIntegerNumericDataType, dataTypeSubtree, modelThings);
                                unsignedIntegerNumericDataType.Container = ormModel.Id;
                                ormModel.DataTypes.Add(unsignedIntegerNumericDataType.Id);
                            }
                            break;
                        case "UnsignedLargeIntegerNumericDataType":
                            using (var dataTypeSubtree = reader.ReadSubtree())
                            {
                                dataTypeSubtree.MoveToContent();
                                var unsignedLargeIntegerNumericDataType = new UnsignedLargeIntegerNumericDataType();
                                var unsignedLargeIntegerNumericDataTypeXmlReader = new UnsignedLargeIntegerNumericDataTypeXmlReader();
                                unsignedLargeIntegerNumericDataTypeXmlReader.ReadXml(unsignedLargeIntegerNumericDataType, dataTypeSubtree, modelThings);
                                unsignedLargeIntegerNumericDataType.Container = ormModel.Id;
                                ormModel.DataTypes.Add(unsignedLargeIntegerNumericDataType.Id);
                            }
                            break;
                        case "UnsignedSmallIntegerNumericDataType":
                            using (var dataTypeSubtree = reader.ReadSubtree())
                            {
                                dataTypeSubtree.MoveToContent();
                                var unsignedSmallIntegerNumericDataType = new UnsignedSmallIntegerNumericDataType();
                                var unsignedSmallIntegerNumericDataTypeXmlReader = new UnsignedSmallIntegerNumericDataTypeXmlReader();
                                unsignedSmallIntegerNumericDataTypeXmlReader.ReadXml(unsignedSmallIntegerNumericDataType, dataTypeSubtree, modelThings);
                                unsignedSmallIntegerNumericDataType.Container = ormModel.Id;
                                ormModel.DataTypes.Add(unsignedSmallIntegerNumericDataType.Id);
                            }
                            break;
                        case "UnsignedTinyIntegerNumericDataType":
                            using (var dataTypeSubtree = reader.ReadSubtree())
                            {
                                dataTypeSubtree.MoveToContent();
                                var unsignedTinyIntegerNumericDataType = new UnsignedTinyIntegerNumericDataType();
                                var unsignedTinyIntegerNumericDataTypeXmlReader = new UnsignedTinyIntegerNumericDataTypeXmlReader();
                                unsignedTinyIntegerNumericDataTypeXmlReader.ReadXml(unsignedTinyIntegerNumericDataType, dataTypeSubtree, modelThings);
                                unsignedTinyIntegerNumericDataType.Container = ormModel.Id;
                                ormModel.DataTypes.Add(unsignedTinyIntegerNumericDataType.Id);
                            }
                            break;
                        case "UnspecifiedDataType":
                            using (var dataTypeSubtree = reader.ReadSubtree())
                            {
                                dataTypeSubtree.MoveToContent();
                                var unspecifiedDataType = new UnspecifiedDataType();
                                var unspecifiedDataTypeXmlReader = new UnspecifiedDataTypeXmlReader();
                                unspecifiedDataTypeXmlReader.ReadXml(unspecifiedDataType, dataTypeSubtree, modelThings);
                                unspecifiedDataType.Container = ormModel.Id;
                                ormModel.DataTypes.Add(unspecifiedDataType.Id);
                            }
                            break;
                        case "VariableLengthRawDataDataType":
                            using (var dataTypeSubtree = reader.ReadSubtree())
                            {
                                dataTypeSubtree.MoveToContent();
                                var variableLengthRawDataDataType = new VariableLengthRawDataDataType();
                                var variableLengthRawDataDataTypeXmlReader = new VariableLengthRawDataDataTypeXmlReader();
                                variableLengthRawDataDataTypeXmlReader.ReadXml(variableLengthRawDataDataType, dataTypeSubtree, modelThings);
                                variableLengthRawDataDataType.Container = ormModel.Id;
                                ormModel.DataTypes.Add(variableLengthRawDataDataType.Id);
                            }
                            break;
                        case "VariableLengthTextDataType":

                            using (var dataTypeSubtree = reader.ReadSubtree())
                            {
                                dataTypeSubtree.MoveToContent();
                                var variableLengthTextDataType = new VariableLengthTextDataType();
                                var variableLengthTextDataTypeXmlReader = new VariableLengthTextDataTypeXmlReader();
                                variableLengthTextDataTypeXmlReader.ReadXml(variableLengthTextDataType, dataTypeSubtree, modelThings);
                                variableLengthTextDataType.Container = ormModel.Id;
                                ormModel.DataTypes.Add(variableLengthTextDataType.Id);
                            }
                            break;
                        case "YesOrNoLogicalDataType":

                            using (var dataTypeSubtree = reader.ReadSubtree())
                            {
                                dataTypeSubtree.MoveToContent();
                                var yesOrNoLogicalDataType = new YesOrNoLogicalDataType();
                                var yesOrNoLogicalDataTypeXmlReader = new YesOrNoLogicalDataTypeXmlReader();
                                yesOrNoLogicalDataTypeXmlReader.ReadXml(yesOrNoLogicalDataType, dataTypeSubtree, modelThings);
                                yesOrNoLogicalDataType.Container = ormModel.Id;
                                ormModel.DataTypes.Add(yesOrNoLogicalDataType.Id);
                            }
                            break;
                        default:
                            throw new System.NotSupportedException($"{localName} not yet supported");
                    }
                }
            }
        }

        /// <summary>
        /// Reads the <see cref="ModelNote"/>s
        /// </summary>
        /// <param name="ormModel">
        /// The subject <see cref="ORMModel"/> that is to be deserialized and is the container of the <see cref="ModelNote"/>s
        /// </param>
        /// <param name="reader">
        /// an instance of <see cref="XmlReader"/> used to read the .orm file
        /// </param>
        /// <param name="modelThings">
        /// a list of <see cref="ModelThing"/>s to which the deserialized items are added
        /// </param>
        private void ReadModelNotes(ORMModel ormModel, XmlReader reader, List<ModelThing> modelThings)
        {
            while (reader.Read())
            {
                if (reader.MoveToContent() == XmlNodeType.Element)
                {
                    var localName = reader.LocalName;

                    switch (localName)
                    {
                        case "ModelNote":
                            using (var modelNoteSubtree = reader.ReadSubtree())
                            {
                                modelNoteSubtree.MoveToContent();
                                var modelNote = new ModelNote();
                                var modelNoteXmlReader = new ModelNoteXmlReader();
                                modelNoteXmlReader.ReadXml(modelNote, modelNoteSubtree, modelThings);
                                modelNote.Container = ormModel.Id;
                                ormModel.Notes.Add(modelNote.Id);
                            }
                            break;
                        default:
                            throw new System.NotSupportedException($"{localName} not yet supported");
                    }
                }
            }
        }

        /// <summary>
        /// Reads the <see cref="CustomReferenceMode"/>s
        /// </summary>
        /// <param name="ormModel">
        /// The subject <see cref="ORMModel"/> that is to be deserialized and is the container of the <see cref="CustomReferenceMode"/>s
        /// </param>
        /// <param name="reader">
        /// an instance of <see cref="XmlReader"/> used to read the .orm file
        /// </param>
        /// <param name="modelThings">
        /// a list of <see cref="ModelThing"/>s to which the deserialized items are added
        /// </param>
        private void ReadCustomReferenceModes(ORMModel ormModel, XmlReader reader, List<ModelThing> modelThings)
        {
            while (reader.Read())
            {
                if (reader.MoveToContent() == XmlNodeType.Element)
                {
                    var localName = reader.LocalName;

                    switch (localName)
                    {
                        case "CustomReferenceMode":
                            using (var customReferenceModeSubtree = reader.ReadSubtree())
                            {
                                customReferenceModeSubtree.MoveToContent();
                                var customReferenceMode = new CustomReferenceMode();
                                var customReferenceModeXmlReader = new CustomReferenceModeXmlReader();
                                customReferenceModeXmlReader.ReadXml(customReferenceMode, customReferenceModeSubtree, modelThings);
                                customReferenceMode.Container = ormModel.Id;
                                ormModel.ReferenceModes.Add(customReferenceMode.Id);
                            }
                            break;
                        default:
                            throw new System.NotSupportedException($"{localName} not yet supported");
                    }
                }
            }
        }

        /// <summary>
        /// Reads the <see cref="ReferenceModeKind"/>s
        /// </summary>
        /// <param name="ormModel">
        /// The subject <see cref="ORMModel"/> that is to be deserialized and is the container of the <see cref="ReferenceModeKind"/>s
        /// </param>
        /// <param name="reader">
        /// an instance of <see cref="XmlReader"/> used to read the .orm file
        /// </param>
        /// <param name="modelThings">
        /// a list of <see cref="ModelThing"/>s to which the deserialized items are added
        /// </param>
        private void ReadReferenceModeKinds(ORMModel ormModel, XmlReader reader, List<ModelThing> modelThings)
        {
            while (reader.Read())
            {
                if (reader.MoveToContent() == XmlNodeType.Element)
                {
                    var localName = reader.LocalName;

                    switch (localName)
                    {
                        case "ReferenceModeKind":
                            using (var referenceModeKindsSubtree = reader.ReadSubtree())
                            {
                                referenceModeKindsSubtree.MoveToContent();
                                var referenceModeKind = new ReferenceModeKind();
                                var referenceModeKindXmlReader = new ReferenceModeKindXmlReader();
                                referenceModeKindXmlReader.ReadXml(referenceModeKind, referenceModeKindsSubtree, modelThings);
                                referenceModeKind.Container = ormModel.Id;
                                ormModel.ReferenceModeKinds.Add(referenceModeKind.Id);
                            }
                            break;
                        default:
                            throw new System.NotSupportedException($"{localName} not yet supported");
                    }
                }
            }
        }
    }
}
