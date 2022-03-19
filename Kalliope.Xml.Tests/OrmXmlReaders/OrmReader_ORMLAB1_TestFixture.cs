// -------------------------------------------------------------------------------------------------
// <copyright file="OrmReader_ORMLAB1_TestFixture.cs" company="RHEA System S.A.">
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

namespace Kalliope.Xml.Tests
{
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    using Kalliope.Common;
    using Kalliope.DTO;
    
    using NUnit.Framework;

    /// <summary>
    /// Suite of tests to verify that an .orm file (ORMLAB1) can be read and the expected object graph is available
    /// </summary>
    [TestFixture]
    public class OrmReader_ORMLAB1_TestFixture
    {
        private string ormfilePath;

        private OrmXmlReader ormXmlReader;

        [SetUp]
        public void Setup()
        {
            this.ormfilePath = Path.Combine(TestContext.CurrentContext.TestDirectory, "Data", "ORM_Lab1.orm");

            this.ormXmlReader = new OrmXmlReader();
        }

        [Test]
        public void Verify_that_the_ORM_File_can_be_read_and_returns_expected_ORMModel()
        {
            var modelThings = this.ormXmlReader.Read(this.ormfilePath, false, null);

            //ORM Model
            var ormModel = modelThings.OfType<ORMModel>().Single();
            Assert.That(ormModel.Id, Is.EqualTo("_E7741B74-3A9E-4F55-A891-9C7AEDF9EA45"));
            Assert.That(ormModel.Name, Is.EqualTo("ORMModel1"));

            // Objects
            Assert.That(modelThings.OfType<EntityType>().Count(), Is.EqualTo(2));
            Assert.That(modelThings.OfType<ValueType>().Count(), Is.EqualTo(4));
            Assert.That(modelThings.OfType<ObjectifiedType>().Count(), Is.EqualTo(1));

            var entityType = modelThings.OfType<EntityType>().Single(x => x.Id == "_2BBF304E-05AE-4A81-AFF9-AFAAECC9A8A7");
            Assert.That(entityType.Name, Is.EqualTo("Patient"));
            Assert.That(entityType.ReferenceMode, Is.EqualTo("nr"));
            Assert.That(entityType.PlayedRoles, 
                Is.EqualTo(new List<string>()
                {
                    "_A8AC7568-EC79-438D-A49B-0CBB9C9B0EB5",
                    "_D9168A8F-4925-4B0B-9D19-77F53CA4BA8C",
                    "_573A2E66-F6A4-484C-95C0-B1F0FE447635",
                    "_50F7D397-5AE3-4387-B752-9D0A9A62B3AE"
                }));
            
            var valueType = modelThings.OfType<ValueType>().Single(x => x.Id == "_7F75CE34-D410-48E7-85AB-DD4A567C3E3E");
            Assert.That(valueType.Name, Is.EqualTo("Patient_nr"));
            Assert.That(valueType.ConceptualDataType, Is.EqualTo("_8E7F7E67-F6F1-4075-B768-B0563947EF82"));
            var dataTypeRef = modelThings.OfType<DataTypeRef>().Single(x => x.Id == "_8E7F7E67-F6F1-4075-B768-B0563947EF82");
            Assert.That(dataTypeRef.Container, Is.EqualTo("_7F75CE34-D410-48E7-85AB-DD4A567C3E3E"));
            Assert.That(dataTypeRef.Scale, Is.EqualTo(0));
            Assert.That(dataTypeRef.Length, Is.EqualTo(0));
            Assert.That(dataTypeRef.Reference, Is.EqualTo("_856C99EF-744D-442A-A661-29B0E7AFF452"));
            
            var objectifiedType = modelThings.OfType<ObjectifiedType>().Single(x => x.Id == "_85FCF764-5AED-456D-A8F1-D8BAF3D5B098");
            Assert.That(objectifiedType.Name, Is.EqualTo("DrugAllergy"));
            Assert.That(objectifiedType.IsIndependent, Is.True);
            Assert.That(objectifiedType.ReferenceMode, Is.Empty);

            var valueTypeValueConstraint = modelThings.OfType<ValueTypeValueConstraint>().Single(x => x.Id == "_75F3C566-D9CA-4E6C-ADDA-71E4849F4210");
            Assert.That(valueTypeValueConstraint.Name, Is.EqualTo("ValueTypeValueConstraint1"));
            Assert.That(valueTypeValueConstraint.Container, Is.EqualTo("_3381A8A4-F6FF-4EDD-AA10-59565A25EC8B"));

            var valueRange = modelThings.OfType<ValueRange>().Single(x => x.Id == "_B2DE9302-B4F1-49C3-9857-0F91510C0EEF");
            Assert.That(valueRange.Container, Is.EqualTo("_75F3C566-D9CA-4E6C-ADDA-71E4849F4210"));
            Assert.That(valueRange.MaxValue, Is.EqualTo("True"));
            Assert.That(valueRange.MinValue, Is.EqualTo("True"));
            Assert.That(valueRange.MaxInclusion, Is.EqualTo(RangeInclusion.NotSet));
            Assert.That(valueRange.MinInclusion, Is.EqualTo(RangeInclusion.NotSet));

            // Facts
            Assert.That(modelThings.OfType<FactType>().Count, Is.EqualTo(7));
            var factType = modelThings.OfType<FactType>().Single(x => x.Id == "_0EFF35AC-1E3B-43CF-AB58-454ABB8219EF");
            Assert.That(factType.Name, Is.EqualTo("PatientHasPatientNr"));

            // Constraints
            Assert.That(modelThings.OfType<MandatoryConstraint>().Count(), Is.EqualTo(10));
            var mandatoryConstraint = modelThings.OfType<MandatoryConstraint>().Single(x => x.Id == "_9F2A5E20-6CE9-4ECB-BC70-226121961401");
            Assert.That(mandatoryConstraint.Name, Is.EqualTo("SimpleMandatoryConstraint1"));
            Assert.That(mandatoryConstraint.IsSimple, Is.True);

            Assert.That(modelThings.OfType<UniquenessConstraint>().Count(), Is.EqualTo(9));
            var uniquenessConstraint = modelThings.OfType<UniquenessConstraint>().Single(x => x.Id == "_5724941F-9D32-4A9D-984C-11CD1F066233");
            Assert.That(uniquenessConstraint.Name, Is.EqualTo("InternalUniquenessConstraint1"));
            Assert.That(uniquenessConstraint.IsInternal, Is.True);

            // DataTypes
            Assert.That(modelThings.OfType<VariableLengthTextDataType>().Count(), Is.EqualTo(1));
            var variableLengthTextDataType = modelThings.OfType<VariableLengthTextDataType>().Single();
            Assert.That(variableLengthTextDataType.Id, Is.EqualTo("_D03565BE-6350-4A94-B533-8594C682FEBA"));

            Assert.That(modelThings.OfType<UnsignedIntegerNumericDataType>().Count(), Is.EqualTo(1));
            var unsignedIntegerNumericDataType = modelThings.OfType<UnsignedIntegerNumericDataType>().Single();
            Assert.That(unsignedIntegerNumericDataType.Id, Is.EqualTo("_856C99EF-744D-442A-A661-29B0E7AFF452"));

            Assert.That(modelThings.OfType<TrueOrFalseLogicalDataType>().Count(), Is.EqualTo(1));
            var trueOrFalseLogicalDataType = modelThings.OfType<TrueOrFalseLogicalDataType>().Single();
            Assert.That(trueOrFalseLogicalDataType.Id, Is.EqualTo("_158BA443-362E-4E4E-95C7-5BF6A81442A8"));

            // CustomReferenceModes
            Assert.That(ormModel.ReferenceModes.Count, Is.EqualTo(0));
            Assert.That(modelThings.OfType<ReferenceMode>(), Is.Empty);

            // ModelNotes
            Assert.That(ormModel.Notes.Count, Is.EqualTo(0));
            Assert.That(modelThings.OfType<ModelNote>(), Is.Empty);
            
            // ReferenceModeKinds
            Assert.That(ormModel.ReferenceModeKinds.Count, Is.EqualTo(3));
            var referenceModeKindGeneral = modelThings.OfType<ReferenceModeKind>().Single(x => x.Id == "_DE41D7D7-FE2F-42AD-A170-86E101B78378");
            Assert.That(referenceModeKindGeneral.FormatString, Is.EqualTo("{1}"));
            Assert.That(referenceModeKindGeneral.ReferenceModeType, Is.EqualTo(ReferenceModeType.General));
            var referenceModeKindPopular = modelThings.OfType<ReferenceModeKind>().Single(x => x.Id == "_CC952B64-7D18-4E81-98F4-8914F39CE1E7");
            Assert.That(referenceModeKindPopular.FormatString, Is.EqualTo("{0}_{1}"));
            Assert.That(referenceModeKindPopular.ReferenceModeType, Is.EqualTo(ReferenceModeType.Popular));
        }

        [Test]
        public void Verify_that_the_ORM_File_can_be_read_and_returns_expected_NameGenerator()
        {
            var modelThings = this.ormXmlReader.Read(this.ormfilePath, false, null);

            var ormRoot = modelThings.OfType<OrmRoot>().Single();
            Assert.That(ormRoot.NameGenerator, Is.EqualTo("_D4D4915E-BE77-4172-92D8-B9F70B635140"));

            var nameGenerator = modelThings.OfType<NameGenerator>().Single();

            // Name Generator
            Assert.That(nameGenerator.Id, Is.EqualTo("_D4D4915E-BE77-4172-92D8-B9F70B635140"));
            Assert.That(nameGenerator.AutomaticallyShortenNames, Is.True);
            Assert.That(nameGenerator.UseTargetDefaultMaximum, Is.True);
            Assert.That(nameGenerator.UserDefinedMaximum, Is.EqualTo(128));
            Assert.That(nameGenerator.CasingOption, Is.EqualTo(NameGeneratorCasingOption.Uninitialized));
            Assert.That(nameGenerator.SpacingFormat, Is.EqualTo(NameGeneratorSpacingFormat.Retain));
            Assert.That(nameGenerator.SpacingReplacement, Is.Null.Or.Empty);
        }

        [Test]
        public void Verify_that_the_ORM_File_can_be_read_and_returns_expected_GenerationState()
        {
            var modelThings = this.ormXmlReader.Read(this.ormfilePath, false, null);

            var generationState = modelThings.OfType<GenerationState>().Single();

            // Generation State
            Assert.That(generationState.Id, Is.EqualTo("_AC554BE9-E14D-42F5-94EB-4F8531A3A5BC"));
            Assert.That(generationState.GenerationSettings, Is.Empty);
        }

        [Test]
        public void Verify_that_the_ORM_File_can_be_read_and_returns_expected_Diagrams()
        {
            var modelThings = this.ormXmlReader.Read(this.ormfilePath, false, null);

            var ormRoot = modelThings.OfType<OrmRoot>().Single();

            // Diagrams
            Assert.That(ormRoot.Diagrams.Count, Is.EqualTo(1));

            var diagram = modelThings.OfType<ORMDiagram>().Single(x => x.Id == "_6378BFE3-D9A5-4F4D-9FBF-D8B42E954DB4");
            Assert.That(diagram.IsCompleteView, Is.False);
            Assert.That(diagram.Name, Is.EqualTo("ORMModel1"));
            Assert.That(diagram.BaseFontName, Is.EqualTo("Tahoma"));
            Assert.That(diagram.BaseFontSize, Is.EqualTo(0.0972222238779068));
            Assert.That(diagram.Subject, Is.EqualTo("_E7741B74-3A9E-4F55-A891-9C7AEDF9EA45"));

            // ObjectTypeShapes
            Assert.That(diagram.ObjectTypeShapes.Count, Is.EqualTo(3));
            var objectTypeShape = modelThings.OfType<ObjectTypeShape>().Single(x => x.Id == "_CCCB4466-BE49-4895-9424-6AB3E16A2942");
            Assert.That(objectTypeShape.IsExpanded, Is.True);
            Assert.That(objectTypeShape.AbsoluteBounds, Is.EqualTo("2.8487956374883652, 0.6539984866976738, 0.51518681168556213, 0.35900605320930479"));
            Assert.That(objectTypeShape.ExpandRefMode, Is.False);
            Assert.That(objectTypeShape.DisplayRelatedTypes, Is.EqualTo(RelatedTypesDisplay.AttachAllTypes));
            Assert.That(objectTypeShape.Container, Is.EqualTo("_6378BFE3-D9A5-4F4D-9FBF-D8B42E954DB4"));
            Assert.That(objectTypeShape.Subject, Is.EqualTo("_2BBF304E-05AE-4A81-AFF9-AFAAECC9A8A7"));
            
            // FactTypeShapes
            Assert.That(diagram.FactTypeShapes.Count, Is.EqualTo(3));
            var factTypeShape = modelThings.OfType<FactTypeShape>().Single(x => x.Id == "_82A927C5-1094-4600-A961-433A126ED626");
            Assert.That(factTypeShape.IsExpanded, Is.True);
            Assert.That(factTypeShape.AbsoluteBounds, Is.EqualTo("3.7291667461395264, 1.555, 0.38388888899236917, 0.24388888899236916"));
            Assert.That(factTypeShape.ConstraintDisplayPosition, Is.EqualTo(ConstraintDisplayPosition.Top));
            Assert.That(factTypeShape.DisplayRoleNames, Is.EqualTo(DisplayRoleNames.UserDefault));
            Assert.That(factTypeShape.DisplayOrientation, Is.EqualTo(DisplayOrientation.Horizontal));
            Assert.That(factTypeShape.DisplayRelatedTypes, Is.EqualTo(RelatedTypesDisplay.AttachAllTypes));
            Assert.That(factTypeShape.Container, Is.EqualTo("_6378BFE3-D9A5-4F4D-9FBF-D8B42E954DB4"));
            Assert.That(factTypeShape.Subject, Is.EqualTo("_86DD69FC-86B7-4807-A267-419D2B0F92F3"));

            // FactTypeShapes.ReadingShapes
            Assert.That(factTypeShape.ReadingShapes.Count, Is.EqualTo(1));
            var readingShapeId = factTypeShape.ReadingShapes.Single();
            var readingShape = modelThings.OfType<ReadingShape>().Single(x => x.Id == readingShapeId);
            Assert.That(readingShape.Id, Is.EqualTo("_B398CCD5-5BF6-413D-AA66-D578DB7E1B99"));
            Assert.That(readingShape.IsExpanded, Is.True);
            Assert.That(readingShape.AbsoluteBounds, Is.EqualTo("3.7291667461395264, 1.8636404022946953, 0.56190770864486694, 0.12950302660465241"));
            Assert.That(readingShape.Subject, Is.EqualTo("_B52CA537-A21F-40F9-AD58-87523C0FB61B"));
            Assert.That(factTypeShape.ConstraintDisplayPosition, Is.EqualTo(ConstraintDisplayPosition.Top));
            Assert.That(factTypeShape.DisplayRoleNames, Is.EqualTo(DisplayRoleNames.UserDefault));
            Assert.That(factTypeShape.DisplayOrientation, Is.EqualTo(DisplayOrientation.Horizontal));
            Assert.That(factTypeShape.Container, Is.EqualTo("_6378BFE3-D9A5-4F4D-9FBF-D8B42E954DB4"));
            Assert.That(factTypeShape.DisplayRelatedTypes, Is.EqualTo(RelatedTypesDisplay.AttachAllTypes));
            
            // FactTypeShapes.RoleNameShapes
            Assert.That(factTypeShape.RoleNameShapes.Count, Is.EqualTo(1));
            var roleNameShapeId = factTypeShape.RoleNameShapes.Single();
            var roleNameShape = modelThings.OfType<RoleNameShape>().Single(x => x.Id == roleNameShapeId);
            Assert.That(roleNameShape.Id, Is.EqualTo("_81268D0A-D4C8-4C6F-ACB9-47D66FE744AD"));
            Assert.That(roleNameShape.IsExpanded, Is.True);
            Assert.That(roleNameShape.AbsoluteBounds, Is.EqualTo("3.9916667461395265, 1.4758333333333333, 0.40145307779312134, 0.12950302660465241"));
            Assert.That(roleNameShape.Container, Is.EqualTo("_82A927C5-1094-4600-A961-433A126ED626"));
            Assert.That(roleNameShape.Subject, Is.EqualTo("_7786BF93-28FB-40BC-92FD-951FEFC9F3FB"));

            // ExternalConstraintShapes
            Assert.That(diagram.ExternalConstraintShapes.Count, Is.EqualTo(0));
            Assert.That(modelThings.OfType<ExternalConstraintShape>(), Is.Empty);

            // FrequencyConstraintShapes
            Assert.That(diagram.FrequencyConstraintShapes.Count, Is.EqualTo(0));
            Assert.That(modelThings.OfType<FrequencyConstraintShape>(), Is.Empty);

            // RingConstraintShapes
            Assert.That(diagram.RingConstraintShapes.Count, Is.EqualTo(0));
            Assert.That(modelThings.OfType<RingConstraintShape>(), Is.Empty);

            // ValueComparisonConstraintShapes
            Assert.That(diagram.ValueComparisonConstraintShapes.Count, Is.EqualTo(0));
            Assert.That(modelThings.OfType<ValueComparisonConstraintShape>(), Is.Empty);

            // ModelNoteShapes
            Assert.That(diagram.ModelNoteShapes.Count, Is.EqualTo(0));
            Assert.That(modelThings.OfType<ModelNoteShape>(), Is.Empty);
        }
    }
}