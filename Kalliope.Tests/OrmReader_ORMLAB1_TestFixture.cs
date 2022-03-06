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

namespace Kalliope.Tests
{
    using System.IO;
    using System.Linq;
    
    using Kalliope;
    using Kalliope.Common;
    using Kalliope.Core;
    using Kalliope.Diagrams;

    using NUnit.Framework;

    /// <summary>
    /// Suite of tests to verify that an .orm file (ORMLAB1) can be read and the expected object graph is available
    /// </summary>
    [TestFixture]
    public class OrmReader_ORMLAB1_TestFixture
    {
        private string ormfilePath;

        private OrmReader ormReader;

        [SetUp]
        public void Setup()
        {
            this.ormfilePath = Path.Combine(TestContext.CurrentContext.TestDirectory, "Data", "ORM_Lab1.orm");

            this.ormReader = new OrmReader();
        }

        [Test]
        public void Verify_that_the_ORM_File_can_be_read_and_returns_expected_ORMModel()
        {
            Assert.Ignore("implement once assembler business logic is complete");

            var ormRoot = this.ormReader.Read(this.ormfilePath, false, null);

            //ORM Model

            Assert.That(ormRoot.Model.Id, Is.EqualTo("_E7741B74-3A9E-4F55-A891-9C7AEDF9EA45"));
            Assert.That(ormRoot.Model.Name, Is.EqualTo("ORMModel1"));

            // Objects
            Assert.That(ormRoot.Model.ObjectTypes.OfType<EntityType>().Count(), Is.EqualTo(2));
            Assert.That(ormRoot.Model.ObjectTypes.OfType<ValueType>().Count(), Is.EqualTo(4));
            Assert.That(ormRoot.Model.ObjectTypes.OfType<ObjectifiedType>().Count(), Is.EqualTo(1));

            var entityType = ormRoot.Model.ObjectTypes.OfType<EntityType>().Single(x => x.Id == "_2BBF304E-05AE-4A81-AFF9-AFAAECC9A8A7");
            Assert.That(entityType.Name, Is.EqualTo("Patient"));
            Assert.That(entityType.ReferenceMode, Is.EqualTo("nr"));

            var valueType = ormRoot.Model.ObjectTypes.OfType<ValueType>().Single(x => x.Id == "_7F75CE34-D410-48E7-85AB-DD4A567C3E3E");
            Assert.That(valueType.Name, Is.EqualTo("Patient_nr"));

            var objectifiedType = ormRoot.Model.ObjectTypes.OfType<ObjectifiedType>().Single(x => x.Id == "_85FCF764-5AED-456D-A8F1-D8BAF3D5B098");
            Assert.That(objectifiedType.Name, Is.EqualTo("DrugAllergy"));
            Assert.That(objectifiedType.IsIndependent, Is.True);
            Assert.That(objectifiedType.ReferenceMode, Is.Empty);

            // Facts
            Assert.That(ormRoot.Model.FactTypes.Count, Is.EqualTo(7));
            var factType = ormRoot.Model.FactTypes.Single(x => x.Id == "_0EFF35AC-1E3B-43CF-AB58-454ABB8219EF");
            Assert.That(factType.Name, Is.EqualTo("PatientHasPatientNr"));

            // Constraints
            Assert.That(ormRoot.Model.SetConstraints.OfType<MandatoryConstraint>().Count(), Is.EqualTo(10));
            var mandatoryConstraint = ormRoot.Model.SetConstraints.OfType<MandatoryConstraint>().Single(x => x.Id == "_9F2A5E20-6CE9-4ECB-BC70-226121961401");
            Assert.That(mandatoryConstraint.Name, Is.EqualTo("SimpleMandatoryConstraint1"));
            Assert.That(mandatoryConstraint.IsSimple, Is.True);

            Assert.That(ormRoot.Model.SetConstraints.OfType<UniquenessConstraint>().Count(), Is.EqualTo(9));
            var uniquenessConstraint = ormRoot.Model.SetConstraints.OfType<UniquenessConstraint>().Single(x => x.Id == "_5724941F-9D32-4A9D-984C-11CD1F066233");
            Assert.That(uniquenessConstraint.Name, Is.EqualTo("InternalUniquenessConstraint1"));
            Assert.That(uniquenessConstraint.IsInternal, Is.True);

            // DataTypes
            Assert.That(ormRoot.Model.DataTypes.OfType<VariableLengthTextDataType>().Count(), Is.EqualTo(1));
            var variableLengthTextDataType = ormRoot.Model.DataTypes.OfType<VariableLengthTextDataType>().Single();
            Assert.That(variableLengthTextDataType.Id, Is.EqualTo("_D03565BE-6350-4A94-B533-8594C682FEBA"));

            Assert.That(ormRoot.Model.DataTypes.OfType<UnsignedIntegerNumericDataType>().Count(), Is.EqualTo(1));
            var unsignedIntegerNumericDataType = ormRoot.Model.DataTypes.OfType<UnsignedIntegerNumericDataType>().Single();
            Assert.That(unsignedIntegerNumericDataType.Id, Is.EqualTo("_856C99EF-744D-442A-A661-29B0E7AFF452"));

            Assert.That(ormRoot.Model.DataTypes.OfType<TrueOrFalseLogicalDataType>().Count(), Is.EqualTo(1));
            var trueOrFalseLogicalDataType = ormRoot.Model.DataTypes.OfType<TrueOrFalseLogicalDataType>().Single();
            Assert.That(trueOrFalseLogicalDataType.Id, Is.EqualTo("_158BA443-362E-4E4E-95C7-5BF6A81442A8"));

            // CustomReferenceModes
            Assert.That(ormRoot.Model.ReferenceModes.Count, Is.EqualTo(0));

            // ModelNotes
            Assert.That(ormRoot.Model.Notes.Count, Is.EqualTo(0));

            // ReferenceModeKinds
            Assert.That(ormRoot.Model.ReferenceModeKinds.Count, Is.EqualTo(3));
            var referenceModeKindGeneral = ormRoot.Model.ReferenceModeKinds.Single(x => x.Id == "_DE41D7D7-FE2F-42AD-A170-86E101B78378");
            Assert.That(referenceModeKindGeneral.FormatString, Is.EqualTo("{1}"));
            Assert.That(referenceModeKindGeneral.ReferenceModeType, Is.EqualTo(ReferenceModeType.General));
            var referenceModeKindPopular = ormRoot.Model.ReferenceModeKinds.Single(x => x.Id == "_CC952B64-7D18-4E81-98F4-8914F39CE1E7");
            Assert.That(referenceModeKindPopular.FormatString, Is.EqualTo("{0}_{1}"));
            Assert.That(referenceModeKindPopular.ReferenceModeType, Is.EqualTo(ReferenceModeType.Popular));
        }

        [Test]
        public void Verify_that_the_ORM_File_can_be_read_and_returns_expected_NameGenerator()
        {
            Assert.Ignore("implement once assembler business logic is complete");

            var ormRoot = this.ormReader.Read(this.ormfilePath, false, null);

            // Name Generator
            Assert.That(ormRoot.NameGenerator.Id, Is.EqualTo("_D4D4915E-BE77-4172-92D8-B9F70B635140"));
            Assert.That(ormRoot.NameGenerator.AutomaticallyShortenNames, Is.True);
            Assert.That(ormRoot.NameGenerator.UseTargetDefaultMaximum, Is.True);
            Assert.That(ormRoot.NameGenerator.UserDefinedMaximum, Is.EqualTo(128));
            Assert.That(ormRoot.NameGenerator.CasingOption, Is.EqualTo(NameGeneratorCasingOption.Uninitialized));
            Assert.That(ormRoot.NameGenerator.SpacingFormat, Is.EqualTo(NameGeneratorSpacingFormat.Retain));
            Assert.That(ormRoot.NameGenerator.SpacingReplacement, Is.Empty);
        }

        [Test]
        public void Verify_that_the_ORM_File_can_be_read_and_returns_expected_GenerationState()
        {
            Assert.Ignore("implement once assembler business logic is complete");

            var ormRoot = this.ormReader.Read(this.ormfilePath, false, null);

            // Generation State
            Assert.That(ormRoot.GenerationState.Id, Is.EqualTo("_AC554BE9-E14D-42F5-94EB-4F8531A3A5BC"));
            Assert.That(ormRoot.GenerationState.GenerationSettings, Is.Empty);
        }

        [Test]
        public void Verify_that_the_ORM_File_can_be_read_and_returns_expected_Diagrams()
        {
            Assert.Ignore("implement once assembler business logic is complete");

            var ormRoot = this.ormReader.Read(this.ormfilePath, false, null);
            
            // Diagrams
            Assert.That(ormRoot.Diagrams.Count, Is.EqualTo(1));

            var diagram = ormRoot.Diagrams.Single(x => x.Id == "_6378BFE3-D9A5-4F4D-9FBF-D8B42E954DB4");
            Assert.That(diagram.IsCompleteView, Is.False);
            Assert.That(diagram.Name, Is.EqualTo("ORMModel1"));
            Assert.That(diagram.BaseFontName, Is.EqualTo("Tahoma"));
            Assert.That(diagram.BaseFontSize, Is.EqualTo(0.0972222238779068));

            // ObjectTypeShapes
            Assert.That(diagram.ObjectTypeShapes.Count, Is.EqualTo(3));
            var objectTypeShape = diagram.ObjectTypeShapes.Single(x => x.Id == "_CCCB4466-BE49-4895-9424-6AB3E16A2942");
            Assert.That(objectTypeShape.IsExpanded, Is.True);
            Assert.That(objectTypeShape.AbsoluteBounds, Is.EqualTo("2.8487956374883652, 0.6539984866976738, 0.51518681168556213, 0.35900605320930479"));
            Assert.That(objectTypeShape.ExpandRefMode, Is.False);
            Assert.That(objectTypeShape.DisplayRelatedTypes, Is.EqualTo(RelatedTypesDisplay.AttachAllTypes));

            // FactTypeShapes
            Assert.That(diagram.FactTypeShapes.Count, Is.EqualTo(3));
            
            var factTypeShape = diagram.FactTypeShapes.Single(x => x.Id == "_82A927C5-1094-4600-A961-433A126ED626");
            Assert.That(factTypeShape.IsExpanded, Is.True);
            Assert.That(factTypeShape.AbsoluteBounds, Is.EqualTo("3.7291667461395264, 1.555, 0.38388888899236917, 0.24388888899236916"));
            Assert.That(factTypeShape.ConstraintDisplayPosition, Is.EqualTo(ConstraintDisplayPosition.Top));
            Assert.That(factTypeShape.DisplayRoleNames, Is.EqualTo(DisplayRoleNames.UserDefault));
            Assert.That(factTypeShape.DisplayOrientation, Is.EqualTo(DisplayOrientation.Horizontal));
            Assert.That(factTypeShape.DisplayRelatedTypes, Is.EqualTo(RelatedTypesDisplay.AttachAllTypes));

            // FactTypeShapes.ReadingShapes
            Assert.That(factTypeShape.ReadingShapes.Count, Is.EqualTo(1));
            var readingShape = factTypeShape.ReadingShapes.Single();
            Assert.That(readingShape.Id, Is.EqualTo("_B398CCD5-5BF6-413D-AA66-D578DB7E1B99"));
            Assert.That(readingShape.IsExpanded, Is.True);
            Assert.That(readingShape.AbsoluteBounds, Is.EqualTo("3.7291667461395264, 1.8636404022946953, 0.56190770864486694, 0.12950302660465241"));
            Assert.That(factTypeShape.ConstraintDisplayPosition, Is.EqualTo(ConstraintDisplayPosition.Top));
            Assert.That(factTypeShape.DisplayRoleNames, Is.EqualTo(DisplayRoleNames.UserDefault));
            Assert.That(factTypeShape.DisplayOrientation, Is.EqualTo(DisplayOrientation.Horizontal));
            Assert.That(factTypeShape.DisplayRelatedTypes, Is.EqualTo(RelatedTypesDisplay.AttachAllTypes));

            // FactTypeShapes.RoleNameShapes
            Assert.That(factTypeShape.RoleNameShapes.Count, Is.EqualTo(1));
            var roleNameShape = factTypeShape.RoleNameShapes.Single();
            Assert.That(roleNameShape.Id, Is.EqualTo("_81268D0A-D4C8-4C6F-ACB9-47D66FE744AD"));
            Assert.That(roleNameShape.IsExpanded, Is.True);
            Assert.That(roleNameShape.AbsoluteBounds, Is.EqualTo("3.9916667461395265, 1.4758333333333333, 0.40145307779312134, 0.12950302660465241"));

            // ExternalConstraintShapes
            Assert.That(diagram.ExternalConstraintShapes.Count, Is.EqualTo(0));

            // FrequencyConstraintShapes
            Assert.That(diagram.FrequencyConstraintShapes.Count, Is.EqualTo(0));

            // RingConstraintShapes
            Assert.That(diagram.RingConstraintShapes.Count, Is.EqualTo(0));

            // ValueComparisonConstraintShapes
            Assert.That(diagram.ValueComparisonConstraintShapes.Count, Is.EqualTo(0));

            // ModelNoteShapes
            Assert.That(diagram.ModelNoteShapes.Count, Is.EqualTo(0));
        }
    }
}