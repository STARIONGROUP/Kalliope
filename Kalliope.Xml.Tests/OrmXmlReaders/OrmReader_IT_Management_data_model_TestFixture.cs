// -------------------------------------------------------------------------------------------------
// <copyright file="OrmReader_IT_Management_data_model_TestFixture.cs" company="RHEA System S.A.">
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

namespace Kalliope.Xml.Tests
{
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    using Kalliope.Common;
    using Kalliope.DTO;

    using NUnit.Framework;

    /// <summary>
    /// Suite of tests to verify that an .orm file (IT Management data model) can be read and the expected object graph is available
    /// </summary>
    [TestFixture]
    public class OrmReader_IT_Management_data_model_TestFixture
    {
        private string ormfilePath;

        private OrmXmlReader ormXmlReader;

        [SetUp]
        public void Setup()
        {
            this.ormfilePath = Path.Combine(TestContext.CurrentContext.TestDirectory, "Data", "IT Management data model.orm");

            this.ormXmlReader = new OrmXmlReader();
        }

        [Test]
        public void Verify_that_the_ORM_File_can_be_read_and_returns_expected_ORMModel()
        {
            var modelThings = this.ormXmlReader.Read(this.ormfilePath, false, null);

            //ORM Model
            var ormModel = modelThings.OfType<OrmModel>().Single();
            Assert.That(ormModel.Id, Is.EqualTo("_8F1F2E20-E575-4533-9832-D033FA7E0A53"));
            Assert.That(ormModel.Name, Is.EqualTo("IT Management"));

            Assert.That(ormModel.Definition, Is.EqualTo("_2F18ED06-13A6-4E8D-A2C3-4089FBE2CB7D"));
            Assert.That(ormModel.Note, Is.EqualTo("_83DD20D1-3B28-4049-99A1-E17B70CD56EB"));

            // Objects
            Assert.That(modelThings.OfType<EntityType>().Count(), Is.EqualTo(39));
            Assert.That(modelThings.OfType<ValueType>().Count(), Is.EqualTo(67));
            Assert.That(modelThings.OfType<ObjectifiedType>().Count(), Is.EqualTo(34));

            var entityType = modelThings.OfType<EntityType>().Single(x => x.Id == "_E8974488-14A3-49FC-9213-403721BE4803");
            Assert.That(entityType.Name, Is.EqualTo("Database"));
            Assert.That(entityType.ReferenceMode, Is.EqualTo(""));
            Assert.That(entityType.PlayedRoles,
                Is.EqualTo(new List<string>
                {
                    "_FCDA3FD8-E99C-4090-A15F-58C71507C382",
                    "_507A3471-15AD-4714-A1DE-F10305A46000",
                }));
            Assert.That(entityType.PreferredIdentifier, Is.Null.Or.Empty);

            var valueType = modelThings.OfType<ValueType>().Single(x => x.Id == "_744D5394-44EC-49E2-8BF1-9EB2C4BD05B2");
            Assert.That(valueType.Name, Is.EqualTo("Application Type"));
            Assert.That(valueType.ConceptualDataType, Is.EqualTo("_DFBA4A89-3C3E-48ED-9317-8A59553A58F2"));
            Assert.That(valueType.PlayedRoles, Is.EqualTo(new List<string>
            {
                "_E5631AF9-1A99-4300-877B-E7AFA0A5E091"
            }));
            Assert.That(valueType.ValueConstraint, Is.EqualTo("_72EC2B6D-F248-41BE-B6BE-2F1FCD5E6900"));

            var valueRange = modelThings.OfType<ValueRange>().Single(x => x.Id == "_1DEFCD1E-077A-44E3-955F-FE135DA14FFA");
            Assert.That(valueRange.MinValue, Is.EqualTo("Business"));
            Assert.That(valueRange.MaxValue, Is.EqualTo("Business"));
            Assert.That(valueRange.MinInclusion, Is.EqualTo(RangeInclusion.NotSet));
            Assert.That(valueRange.MaxInclusion, Is.EqualTo(RangeInclusion.NotSet));
            
            // DataTypes
            Assert.That(modelThings.OfType<VariableLengthTextDataType>().Count(), Is.EqualTo(1));
            var variableLengthTextDataType = modelThings.OfType<VariableLengthTextDataType>().Single();
            Assert.That(variableLengthTextDataType.Id, Is.EqualTo("_2B6AA846-1B7B-4F9F-94EE-7FB5CE15B67A"));

            Assert.That(modelThings.OfType<AutoCounterNumericDataType>().Count(), Is.EqualTo(1));
            var autoCounterNumericDataType = modelThings.OfType<AutoCounterNumericDataType>().Single();
            Assert.That(autoCounterNumericDataType.Id, Is.EqualTo("_53BAF3A9-2669-4548-9226-9DE118919B25"));

            Assert.That(modelThings.OfType<SignedIntegerNumericDataType>().Count(), Is.EqualTo(1));
            var signedIntegerNumericDataType = modelThings.OfType<SignedIntegerNumericDataType>().Single();
            Assert.That(signedIntegerNumericDataType.Id, Is.EqualTo("_0233F65B-C1CD-450B-AE5B-648E70774D5E"));

            Assert.That(modelThings.OfType<FixedLengthTextDataType>().Count(), Is.EqualTo(1));
            var fixedLengthTextDataType = modelThings.OfType<FixedLengthTextDataType>().Single();
            Assert.That(fixedLengthTextDataType.Id, Is.EqualTo("_EB65DE05-9A46-418F-ABCE-8DAC283CF32B"));

            Assert.That(modelThings.OfType<UnsignedTinyIntegerNumericDataType>().Count(), Is.EqualTo(1));
            var unsignedTinyIntegerNumericDataType = modelThings.OfType<UnsignedTinyIntegerNumericDataType>().Single();
            Assert.That(unsignedTinyIntegerNumericDataType.Id, Is.EqualTo("_AFF7E5A8-A78D-48F7-A538-76FC0C8A4E8D"));

            Assert.That(modelThings.OfType<MoneyNumericDataType>().Count(), Is.EqualTo(1));
            var moneyNumericDataType = modelThings.OfType<MoneyNumericDataType>().Single();
            Assert.That(moneyNumericDataType.Id, Is.EqualTo("_6FA396D5-5C49-4014-B893-8197F755AEDB"));

            Assert.That(modelThings.OfType<DateTemporalDataType>().Count(), Is.EqualTo(1));
            var dateTemporalDataType = modelThings.OfType<DateTemporalDataType>().Single();
            Assert.That(dateTemporalDataType.Id, Is.EqualTo("_DE1E018C-6983-4946-BF4A-42E9EEFFC340"));

            Assert.That(modelThings.OfType<SinglePrecisionFloatingPointNumericDataType>().Count(), Is.EqualTo(1));
            var singlePrecisionFloatingPointNumericDataType = modelThings.OfType<SinglePrecisionFloatingPointNumericDataType>().Single();
            Assert.That(singlePrecisionFloatingPointNumericDataType.Id, Is.EqualTo("_E577B427-3B82-4446-BA19-CD93FB99BF3A"));

            // CustomReferenceModes
            Assert.That(ormModel.ReferenceModes.Count, Is.EqualTo(1));
            var customReferenceMode = modelThings.OfType<CustomReferenceMode>().Single();
            Assert.That(customReferenceMode.Id, Is.EqualTo("_15B5E099-D6A6-4AA1-B5A7-2E760E295D65"));
            Assert.That(customReferenceMode.Name, Is.EqualTo("Level"));
            Assert.That(customReferenceMode.CustomFormatString, Is.Null.Or.Empty);
            Assert.That(customReferenceMode.Kind, Is.EqualTo("_56AB076B-E6F0-4AF3-8C13-5545E5B5B9EC"));

            // ModelNotes
            Assert.That(ormModel.Notes.Count, Is.EqualTo(2));
            Assert.That(ormModel.Notes, Is.EqualTo(new List<string>
            {
                "_8CE0C1A9-CACF-4E0F-B758-DC007FA7FAD1",
                "_D8DEAFC6-9FFB-456C-A8FC-C76D39E2632C",
            }));

            var modelNote = modelThings.OfType<ModelNote>().Single(x => x.Id == "_8CE0C1A9-CACF-4E0F-B758-DC007FA7FAD1");
            Assert.That(modelNote.Text, Is.EqualTo("Expense"));

            // ReferenceModeKinds
            Assert.That(ormModel.ReferenceModeKinds.Count, Is.EqualTo(3));
            var referenceModeKindGeneral = modelThings.OfType<ReferenceModeKind>().Single(x => x.Id == "_BBA01037-6A2F-4158-91C0-8F4CDB650D1D");
            Assert.That(referenceModeKindGeneral.FormatString, Is.EqualTo("{1}"));
            Assert.That(referenceModeKindGeneral.ReferenceModeType, Is.EqualTo(ReferenceModeType.General));
            var referenceModeKindPopular = modelThings.OfType<ReferenceModeKind>().Single(x => x.Id == "_56AB076B-E6F0-4AF3-8C13-5545E5B5B9EC");
            Assert.That(referenceModeKindPopular.FormatString, Is.EqualTo("{0}_{1}"));
            Assert.That(referenceModeKindPopular.ReferenceModeType, Is.EqualTo(ReferenceModeType.Popular));

            var subtypeMetaRole = modelThings.OfType<SubtypeMetaRole>().Single(x => x.Id == "_94668E20-DBF6-4936-85B5-310B85896C45");
            Assert.That(subtypeMetaRole.Name, Is.EqualTo("SubtypeMetaRoleName"));
        }

        [Test]
        public void Verify_that_the_ORM_File_can_be_read_and_returns_expected_NameGenerator()
        {
            var modelThings = this.ormXmlReader.Read(this.ormfilePath, false, null);
            
            var nameGenerator =  modelThings.OfType<DTO.NameGenerator>().SingleOrDefault();

            Assert.That(nameGenerator, Is.Null);
        }

        [Test]
        public void Verify_that_the_ORM_File_can_be_read_and_returns_expected_GenerationState()
        {
            var modelThings = this.ormXmlReader.Read(this.ormfilePath, false, null);

            var generationState = modelThings.OfType<GenerationState>().SingleOrDefault();

            Assert.That(generationState, Is.Null);
        }

        [Test]
        public void Verify_that_the_ORM_File_can_be_read_and_returns_expected_CustomPropertyDefinitions()
        {
            var modelThings = this.ormXmlReader.Read(this.ormfilePath, false, null);
            
            var customPropertyGroups = modelThings.OfType<CustomPropertyGroup>();

            Assert.That(customPropertyGroups.Count(), Is.EqualTo(3));

            var customPropertyGroup = modelThings.OfType<CustomPropertyGroup>().Single(x => x.Id == "_736E04B8-E3EE-4950-A402-3CEE1EBD715A");
            Assert.That(customPropertyGroup.Name, Is.EqualTo("OSMoSEDoc: Diagrams"));
            Assert.That(customPropertyGroup.Description, Is.Null.Or.Empty);
            Assert.That(customPropertyGroup.IsDefault, Is.False);

            var customPropertyDefinition = modelThings.OfType<CustomPropertyDefinition>().Single(x => x.Id == "_19E22BD9-2299-42A9-A830-F47D7FE0D1FD");
            Assert.That(customPropertyDefinition.Name, Is.EqualTo("Glo-08: Synonyms"));
            Assert.That(customPropertyDefinition.Category, Is.EqualTo("OSMoSE Glossary"));
            Assert.That(customPropertyDefinition.DataType, Is.EqualTo(CustomPropertyDataType.String));
            Assert.That(customPropertyDefinition.ORMTypes, Is.EqualTo(new List<ORMType>
            {
                ORMType.EntityType,
                ORMType.ValueType,
                ORMType.Role 
            }));
        }
    }
}
