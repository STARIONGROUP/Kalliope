// -------------------------------------------------------------------------------------------------
// <copyright file="OrmReader_ORMLAB3_TestFixture.cs" company="Starion Group S.A.">
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

namespace Kalliope.Xml.Tests
{
    using System.IO;
    using System.Linq;
    
    using Kalliope.Common;
    using Kalliope.DTO;

    using NUnit.Framework;

    /// <summary>
    /// Suite of tests to verify that an .orm file (ORMLAB2) can be read and the expected object graph is available
    /// </summary>
    [TestFixture]
    public class OrmReader_ORMLAB3_TestFixture
    {
        private string ormfilePath;

        private OrmXmlReader ormXmlReader;

        [SetUp]
        public void Setup()
        {
            this.ormfilePath = Path.Combine(TestContext.CurrentContext.TestDirectory, "Data", "ORM_Lab3.orm");

            this.ormXmlReader = new OrmXmlReader();
        }

        [Test]
        public void Verify_that_the_ORM_File_can_be_read_and_returns_expected_ORMModel()
        {
            var modelThings = this.ormXmlReader.Read(this.ormfilePath, false, null);

            var ormRoot = modelThings.OfType<OrmRoot>().Single();

            var ormModel = modelThings.OfType<OrmModel>().Single();
            Assert.That(ormModel.Id, Is.EqualTo("_BBB698D9-5392-42EB-98F9-0DD34E05B957"));
            Assert.That(ormModel.Name, Is.EqualTo("ORM_Lab2.orm"));
            
            // Objects
            Assert.That(modelThings.OfType<EntityType>().Count(), Is.EqualTo(7));
            Assert.That(modelThings.OfType<ValueType>().Count(), Is.EqualTo(14));
            Assert.That(modelThings.OfType<ObjectifiedType>().Count(), Is.EqualTo(4));

            var entityType = modelThings.OfType<EntityType>().Single(x => x.Id == "_2D2953A6-8E07-4158-93E5-FF241BC9838C");
            Assert.That(entityType.Name, Is.EqualTo("City"));
            Assert.That(entityType.ReferenceMode, Is.Empty);
            Assert.That(entityType.Container, Is.EqualTo(ormModel.Id));

            var valueType = modelThings.OfType<ValueType>().Single(x => x.Id == "_EA2FBA06-5757-4B69-8823-BDD954075EE5");
            Assert.That(valueType.Name, Is.EqualTo("State_code"));
            Assert.That(valueType.Container, Is.EqualTo(ormModel.Id));
            Assert.That(valueType.Container, Is.EqualTo(ormModel.Id));

            var objectifiedType = modelThings.OfType<ObjectifiedType>().Single(x => x.Id == "_BB1CD3E9-9118-40A3-A23B-260ED585267A");
            Assert.That(objectifiedType.Name, Is.EqualTo("CinemaFirstShowedMovieOnDate"));
            Assert.That(objectifiedType.IsIndependent, Is.False);
            Assert.That(objectifiedType.ReferenceMode, Is.Empty);
            Assert.That(objectifiedType.Container, Is.EqualTo(ormModel.Id));

            // Facts
            Assert.That(modelThings.OfType<FactType>().Count, Is.EqualTo(31));
            var factType = modelThings.OfType<FactType>().Single(x => x.Id == "_2904A934-2B98-4EC1-925E-F18E545A22B1");
            Assert.That(factType.Name, Is.EqualTo("StateHasStateCode"));
            Assert.That(factType.Container, Is.EqualTo(ormModel.Id));

            // Constraints
            Assert.That(modelThings.OfType<MandatoryConstraint>().Count(), Is.EqualTo(39));
            var mandatoryConstraint = modelThings.OfType<MandatoryConstraint>().Single(x => x.Id == "_8AB3A94E-E1C7-4E85-B5C2-7D72E57C0952");
            Assert.That(mandatoryConstraint.Name, Is.EqualTo("SimpleMandatoryConstraint1"));
            Assert.That(mandatoryConstraint.IsSimple, Is.True);
            Assert.That(mandatoryConstraint.Container, Is.EqualTo(ormModel.Id));

            Assert.That(modelThings.OfType<UniquenessConstraint>().Count(), Is.EqualTo(39));
            var uniquenessConstraint = modelThings.OfType<UniquenessConstraint>().Single(x => x.Id == "_2972925F-EF20-4D76-B52C-81F2B250B260");
            Assert.That(uniquenessConstraint.Name, Is.EqualTo("InternalUniquenessConstraint1"));
            Assert.That(uniquenessConstraint.IsInternal, Is.True);
            Assert.That(uniquenessConstraint.Container, Is.EqualTo(ormModel.Id));

            // DataTypes
            Assert.That(modelThings.OfType<FixedLengthTextDataType>().Count(), Is.EqualTo(1));
            var fixedLengthTextDataType = modelThings.OfType<FixedLengthTextDataType>().Single();
            Assert.That(fixedLengthTextDataType.Id, Is.EqualTo("_D9C27BF7-D96F-43E5-95D3-8E3564C673C2"));
            Assert.That(fixedLengthTextDataType.Container, Is.EqualTo(ormModel.Id));

            Assert.That(modelThings.OfType<VariableLengthTextDataType>().Count(), Is.EqualTo(1));
            var variableLengthTextDataType = modelThings.OfType<VariableLengthTextDataType>().Single();
            Assert.That(variableLengthTextDataType.Id, Is.EqualTo("_E373F568-5861-412F-82E1-0B54D5C1E0FF"));
            Assert.That(variableLengthTextDataType.Container, Is.EqualTo(ormModel.Id));

            Assert.That(modelThings.OfType<SignedIntegerNumericDataType>().Count(), Is.EqualTo(1));
            var signedIntegerNumericDataType = modelThings.OfType<SignedIntegerNumericDataType>().Single();
            Assert.That(signedIntegerNumericDataType.Id, Is.EqualTo("_C468C021-B3F1-4D22-B757-956BD0D17B15"));
            Assert.That(signedIntegerNumericDataType.Container, Is.EqualTo(ormModel.Id));

            Assert.That(modelThings.OfType<UnsignedIntegerNumericDataType>().Count(), Is.EqualTo(1));
            var unsignedIntegerNumericDataType = modelThings.OfType<UnsignedIntegerNumericDataType>().Single();
            Assert.That(unsignedIntegerNumericDataType.Id, Is.EqualTo("_AA1E2088-6261-4D48-A91E-2EE05ECBB067"));
            Assert.That(unsignedIntegerNumericDataType.Container, Is.EqualTo(ormModel.Id));

            Assert.That(modelThings.OfType<DateTemporalDataType>().Count(), Is.EqualTo(1));
            var dateTemporalDataType = modelThings.OfType<DateTemporalDataType>().Single();
            Assert.That(dateTemporalDataType.Id, Is.EqualTo("_52D54BE0-1507-4780-954B-80ACBE17F96A"));
            Assert.That(dateTemporalDataType.Container, Is.EqualTo(ormModel.Id));

            Assert.That(modelThings.OfType<TrueOrFalseLogicalDataType>().Count(), Is.EqualTo(1));
            var trueOrFalseLogicalDataType = modelThings.OfType<TrueOrFalseLogicalDataType>().Single();
            Assert.That(trueOrFalseLogicalDataType.Id, Is.EqualTo("_33BFD2D0-785B-4750-8215-AE04CB185578"));
            Assert.That(trueOrFalseLogicalDataType.Container, Is.EqualTo(ormModel.Id));

            // CustomReferenceModes
            Assert.That(ormModel.ReferenceModes.Count, Is.EqualTo(0));
            Assert.That(modelThings.OfType<ReferenceMode>(), Is.Empty);

            // ModelNotes
            Assert.That(ormModel.Notes.Count, Is.EqualTo(1));
            var modelNote = modelThings.OfType<ModelNote>().Single();
            Assert.That(modelNote.Id, Is.EqualTo("_122AC1BC-F9B4-4D43-B95C-0003BED9601D"));
            Assert.That(modelNote.Text, Is.EqualTo("Cinema is multiplex iff\nCinema has NrThreaters >=1"));
            Assert.That(modelNote.Container, Is.EqualTo(ormModel.Id));
            //TODO: verify ReferencedBy property

            // ReferenceModeKinds
            Assert.That(ormModel.ReferenceModeKinds.Count, Is.EqualTo(3));
            var referenceModeKindGeneral = modelThings.OfType<ReferenceModeKind>().Single(x => x.Id == "_2B4A7877-B9B5-40A5-854C-30392896A6A4");
            Assert.That(referenceModeKindGeneral.FormatString, Is.EqualTo("{1}"));
            Assert.That(referenceModeKindGeneral.ReferenceModeType, Is.EqualTo(ReferenceModeType.General));
            var referenceModeKindPopular = modelThings.OfType<ReferenceModeKind>().Single(x => x.Id == "_8ED25F0C-B843-45A9-8CA6-27D077590437");
            Assert.That(referenceModeKindPopular.FormatString, Is.EqualTo("{0}_{1}"));
            Assert.That(referenceModeKindPopular.ReferenceModeType, Is.EqualTo(ReferenceModeType.Popular));
            var referenceModeKindUnitBased = modelThings.OfType<ReferenceModeKind>().Single(x => x.Id == "_2FAF73C7-3C3E-4F9A-A381-03F7CA1BA108");
            Assert.That(referenceModeKindUnitBased.FormatString, Is.EqualTo("{1}Value"));
            Assert.That(referenceModeKindUnitBased.ReferenceModeType, Is.EqualTo(ReferenceModeType.UnitBased));
        }

        [Test]
        public void Verify_that_the_ORM_File_can_be_read_and_returns_expected_NameGenerator()
        {
            var modelThings = this.ormXmlReader.Read(this.ormfilePath, false, null);

            var ormRoot = modelThings.OfType<OrmRoot>().Single();

            // Name Generator
            Assert.That(ormRoot.NameGenerator, Is.Null.Or.Empty);
        }

        [Test]
        public void Verify_that_the_ORM_File_can_be_read_and_returns_expected_GenerationState()
        {
            var modelThings = this.ormXmlReader.Read(this.ormfilePath, false, null);

            var ormRoot = modelThings.OfType<OrmRoot>().Single();

            // Generation State
            Assert.That(ormRoot.GenerationState, Is.Null.Or.Empty);
        }

        [Test]
        public void Verify_that_the_ORM_File_can_be_read_and_returns_expected_Diagrams()
        {
            var modelThings = this.ormXmlReader.Read(this.ormfilePath, false, null);

            var ormRoot = modelThings.OfType<OrmRoot>().Single();

            // Diagrams
            Assert.That(ormRoot.Diagrams.Count, Is.EqualTo(2));

            var diagram = modelThings.OfType<OrmDiagram>().Single(x => x.Id == "_D80C0423-0227-477D-84AA-32E6BF3A0659");
            Assert.That(diagram.IsCompleteView, Is.True);
            Assert.That(diagram.Name, Is.EqualTo("Movie"));
            Assert.That(diagram.BaseFontName, Is.EqualTo("Tahoma"));
            Assert.That(diagram.BaseFontSize, Is.EqualTo(0.0972222238779068));
            Assert.That(diagram.Subject, Is.EqualTo("_BBB698D9-5392-42EB-98F9-0DD34E05B957"));

            // ObjectTypeShapes
            Assert.That(diagram.ObjectTypeShapes.Count, Is.EqualTo(6));
            var objectTypeShape = modelThings.OfType<ObjectTypeShape>().Single(x => x.Id == "_E8AC4E21-B2EA-44EE-AB64-BF9A46014FBD");
            Assert.That(objectTypeShape.IsExpanded, Is.True);
            Assert.That(objectTypeShape.AbsoluteBounds, Is.EqualTo("1.5504014194011688, 2.59375, 0.72140424966812133, 0.22950302660465241"));
            Assert.That(objectTypeShape.ExpandRefMode, Is.False);
            Assert.That(objectTypeShape.DisplayRelatedTypes, Is.EqualTo(RelatedTypesDisplay.AttachAllTypes));
            Assert.That(objectTypeShape.Subject, Is.EqualTo("_FF7C9E69-E901-42EA-9B45-4D282378C797"));

            // ObjectTypeShapes.RelativeShapes
            var valueConstraintShapeId = objectTypeShape.ValueConstraintShapes.Single();
            var valueConstraintShape = modelThings.OfType<ValueConstraintShape>().Single(x => x.Id == valueConstraintShapeId);
            Assert.That(valueConstraintShape.Id, Is.EqualTo("_200444FA-B4DB-431C-9AE6-A9A6633B84ED"));
            Assert.That(valueConstraintShape.IsExpanded, Is.True);
            Assert.That(valueConstraintShape.AbsoluteBounds, Is.EqualTo("2.33180566906929, 2.4642469733953476, 0.93807417154312134, 0.12950302660465241"));
            Assert.That(valueConstraintShape.Subject, Is.EqualTo("_5B9303F3-5217-4A2E-BFD5-667C9695F9A4"));

            // FactTypeShapes
            Assert.That(diagram.FactTypeShapes.Count, Is.EqualTo(7));
            
            // ExternalConstraintShapes
            Assert.That(diagram.ExternalConstraintShapes.Count, Is.EqualTo(2));

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
