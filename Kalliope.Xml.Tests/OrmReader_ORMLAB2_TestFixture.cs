// -------------------------------------------------------------------------------------------------
// <copyright file="OrmReader_ORMLAB2_TestFixture.cs" company="RHEA System S.A.">
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
    using System.IO;
    using System.Linq;
    
    using Kalliope.Common;
    using Kalliope.DTO;

    using NUnit.Framework;

    /// <summary>
    /// Suite of tests to verify that an .orm file (ORMLAB2) can be read and the expected object graph is available
    /// </summary>
    [TestFixture]
    public class OrmReader_ORMLAB2_TestFixture
    {
        private string ormfilePath;

        private OrmXmlReader ormXmlReader;

        [SetUp]
        public void Setup()
        {
            this.ormfilePath = Path.Combine(TestContext.CurrentContext.TestDirectory, "Data", "ORM_Lab2.orm");

            this.ormXmlReader = new OrmXmlReader();
        }

        [Test]
        public void Verify_that_the_ORM_File_can_be_read_and_returns_expected_ORMModel()
        {
            var modelThings = this.ormXmlReader.Read(this.ormfilePath, false, null);

            //ORM Model
            var ormModel = modelThings.OfType<ORMModel>().Single();
            Assert.That(ormModel.Id, Is.EqualTo("_BBB698D9-5392-42EB-98F9-0DD34E05B957"));
            Assert.That(ormModel.Name, Is.EqualTo("ORM_Lab2.orm"));

            // Objects
            Assert.That(modelThings.OfType<EntityType>().Count(), Is.EqualTo(5));
            Assert.That(modelThings.OfType<ValueType>().Count(), Is.EqualTo(10));
            Assert.That(modelThings.OfType<ObjectifiedType>().Count(), Is.EqualTo(1));

            var entityType = modelThings.OfType<EntityType>().Single(x => x.Id == "_2D2953A6-8E07-4158-93E5-FF241BC9838C");
            Assert.That(entityType.Name, Is.EqualTo("City"));
            Assert.That(entityType.ReferenceMode, Is.Empty);

            var valueType = modelThings.OfType<ValueType>().Single(x => x.Id == "_EA2FBA06-5757-4B69-8823-BDD954075EE5");
            Assert.That(valueType.Name, Is.EqualTo("State_code"));

            var objectifiedType = modelThings.OfType<ObjectifiedType>().Single(x => x.Id == "_BB1CD3E9-9118-40A3-A23B-260ED585267A");
            Assert.That(objectifiedType.Name, Is.EqualTo("CinemaFirstShowedMovieOnDate"));
            Assert.That(objectifiedType.IsIndependent, Is.False);
            Assert.That(objectifiedType.ReferenceMode, Is.Empty);

            // Facts
            Assert.That(modelThings.OfType<FactType>().Count, Is.EqualTo(16));
            var factType = modelThings.OfType<FactType>().Single(x => x.Id == "_2904A934-2B98-4EC1-925E-F18E545A22B1");
            Assert.That(factType.Name, Is.EqualTo("StateHasStateCode"));

            // Constraints
            Assert.That(modelThings.OfType<MandatoryConstraint>().Count(), Is.EqualTo(25));
            var mandatoryConstraint = modelThings.OfType<MandatoryConstraint>().Single(x => x.Id == "_4AF1D6BC-4EFB-4AF9-A1E7-6EBBF9FE8396");
            Assert.That(mandatoryConstraint.Name, Is.EqualTo("ImpliedMandatoryConstraint1"));
            Assert.That(mandatoryConstraint.IsSimple, Is.False);
            Assert.That(mandatoryConstraint.IsImplied, Is.True);

            Assert.That(modelThings.OfType<UniquenessConstraint>().Count(), Is.EqualTo(22));
            var uniquenessConstraint = modelThings.OfType<UniquenessConstraint>().Single(x => x.Id == "_2972925F-EF20-4D76-B52C-81F2B250B260");
            Assert.That(uniquenessConstraint.Name, Is.EqualTo("InternalUniquenessConstraint1"));
            Assert.That(uniquenessConstraint.IsInternal, Is.True);
            
            // DataTypes
            var fixedLengthTextDataType = modelThings.OfType<FixedLengthTextDataType>().Single();
            Assert.That(fixedLengthTextDataType.Id, Is.EqualTo("_D9C27BF7-D96F-43E5-95D3-8E3564C673C2"));

            var variableLengthTextDataType = modelThings.OfType<VariableLengthTextDataType>().Single();
            Assert.That(variableLengthTextDataType.Id, Is.EqualTo("_E373F568-5861-412F-82E1-0B54D5C1E0FF"));

            var signedIntegerNumericDataType = modelThings.OfType<SignedIntegerNumericDataType>().Single();
            Assert.That(signedIntegerNumericDataType.Id, Is.EqualTo("_C468C021-B3F1-4D22-B757-956BD0D17B15"));
            
            var unsignedIntegerNumericDataType = modelThings.OfType<UnsignedIntegerNumericDataType>().Single();
            Assert.That(unsignedIntegerNumericDataType.Id, Is.EqualTo("_AA1E2088-6261-4D48-A91E-2EE05ECBB067"));

            var dateTemporalDataType = modelThings.OfType<DateTemporalDataType>().Single();
            Assert.That(dateTemporalDataType.Id, Is.EqualTo("_52D54BE0-1507-4780-954B-80ACBE17F96A"));

            var trueOrFalseLogicalDataType = modelThings.OfType<TrueOrFalseLogicalDataType>().Single();
            Assert.That(trueOrFalseLogicalDataType.Id, Is.EqualTo("_33BFD2D0-785B-4750-8215-AE04CB185578"));

            // CustomReferenceModes
            Assert.That(ormModel.ReferenceModes.Count, Is.EqualTo(0));
            Assert.That(modelThings.OfType<ReferenceMode>(), Is.Empty);

            // ModelNotes
            Assert.That(ormModel.Notes.Count, Is.EqualTo(1));
            var modelNote = modelThings.OfType<ModelNote>().Single();
            Assert.That(modelNote.Id, Is.EqualTo("_122AC1BC-F9B4-4D43-B95C-0003BED9601D"));
            Assert.That(modelNote.Text, Is.EqualTo("Cinema is multiplex iff\nCinema has NrThreaters >=1"));
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
            Assert.That(ormRoot.Diagrams.Count, Is.EqualTo(1));

            var diagram = modelThings.OfType<ORMDiagram>().Single(x => x.Id == "_019FB281-3506-4C64-9A83-7A64F7A01D55");
            Assert.That(diagram.IsCompleteView, Is.False);
            Assert.That(diagram.Name, Is.EqualTo("Cinema"));
            Assert.That(diagram.BaseFontName, Is.EqualTo("Tahoma"));
            Assert.That(diagram.BaseFontSize, Is.EqualTo(0.0972222238779068));
            Assert.That(diagram.Subject, Is.EqualTo("_BBB698D9-5392-42EB-98F9-0DD34E05B957"));

            // ObjectTypeShapes
            Assert.That(diagram.ObjectTypeShapes.Count, Is.EqualTo(9));
            var objectTypeShape = modelThings.OfType<ObjectTypeShape>().Single(x => x.Id == "_3D692D51-D04C-4AE0-96B4-50A7B3A07641");
            Assert.That(objectTypeShape.IsExpanded, Is.True);
            Assert.That(objectTypeShape.AbsoluteBounds, Is.EqualTo("3.1645833333333329, 1.3916666865348812, 0.34875072062015533, 0.22950302660465241"));
            Assert.That(objectTypeShape.ExpandRefMode, Is.False);
            Assert.That(objectTypeShape.DisplayRelatedTypes, Is.EqualTo(RelatedTypesDisplay.AttachAllTypes));
            Assert.That(objectTypeShape.Container, Is.EqualTo("_019FB281-3506-4C64-9A83-7A64F7A01D55"));
            Assert.That(objectTypeShape.Subject, Is.EqualTo("_2D2953A6-8E07-4158-93E5-FF241BC9838C"));

            objectTypeShape = modelThings.OfType<ObjectTypeShape>().Single(x => x.Id == "_0B5F48A9-9454-436F-A3C5-F1D94D1491BB");
            Assert.That(objectTypeShape.ExpandRefMode, Is.True);
            Assert.That(objectTypeShape.DisplayRelatedTypes, Is.EqualTo(RelatedTypesDisplay.AttachAllTypes));
            Assert.That(objectTypeShape.Container, Is.EqualTo("_019FB281-3506-4C64-9A83-7A64F7A01D55"));

            // ObjectTypeShapes.ValueConstraintShapes
            objectTypeShape = modelThings.OfType<ObjectTypeShape>().Single(x => x.Id == "_6DB3F675-D1B1-41E9-9594-BFAE5AF23BFC");
            Assert.That(objectTypeShape.ExpandRefMode, Is.False);
            Assert.That(objectTypeShape.DisplayRelatedTypes, Is.EqualTo(RelatedTypesDisplay.AttachAllTypes));
            Assert.That(objectTypeShape.Container, Is.EqualTo("_019FB281-3506-4C64-9A83-7A64F7A01D55"));

            var constraintShapeId = objectTypeShape.ValueConstraintShapes.Single();
            var constraintShape = modelThings.OfType<ValueConstraintShape>().Single(x => x.Id == constraintShapeId);
            Assert.That(constraintShape.Id, Is.EqualTo("_03A3C5F1-A42A-4B68-A877-EE514FD2D03F"));
            Assert.That(constraintShape.IsExpanded, Is.True);
            Assert.That(constraintShape.AbsoluteBounds, Is.EqualTo("2.0143245685100544, 2.7697733173953991, 0.35341161489486694, 0.12950302660465241"));
            Assert.That(constraintShape.Container, Is.EqualTo("_6DB3F675-D1B1-41E9-9594-BFAE5AF23BFC"));
            Assert.That(constraintShape.Subject, Is.EqualTo("_BF638CD9-3932-47DB-A90D-C66D8EA33D25"));

            // FactTypeShapes
            Assert.That(diagram.FactTypeShapes.Count, Is.EqualTo(10));

            var factTypeShape = modelThings.OfType<FactTypeShape>().Single(x => x.Id == "_A8606B42-36D8-4D98-BEC2-91439FCAB1A3");
            Assert.That(factTypeShape.IsExpanded, Is.True);
            Assert.That(factTypeShape.AbsoluteBounds, Is.EqualTo("3.1808333532015478, 1.8949999999999998, 0.24388888899236916, 0.38388888899236917"));
            Assert.That(factTypeShape.ConstraintDisplayPosition, Is.EqualTo(ConstraintDisplayPosition.Top));
            Assert.That(factTypeShape.DisplayRoleNames, Is.EqualTo(DisplayRoleNames.UserDefault));
            Assert.That(factTypeShape.DisplayOrientation, Is.EqualTo(DisplayOrientation.VerticalRotatedLeft));
            Assert.That(factTypeShape.DisplayRelatedTypes, Is.EqualTo(RelatedTypesDisplay.AttachAllTypes));
            Assert.That(factTypeShape.Container, Is.EqualTo("_019FB281-3506-4C64-9A83-7A64F7A01D55"));
            Assert.That(factTypeShape.Subject, Is.EqualTo("_71B6380B-34E5-4008-A65C-6CC5A89A16EE"));
            
            factTypeShape = modelThings.OfType<FactTypeShape>().Single(x => x.Id == "_37834249-0C31-425F-B243-574EA4A414D4");
            Assert.That(factTypeShape.IsExpanded, Is.True);
            Assert.That(factTypeShape.AbsoluteBounds, Is.EqualTo("6.276041666666667, 2.857083412806193, 0.38388888899236917, 0.24388888899236916"));
            
            // FactTypeShapes.ReadingShapes
            Assert.That(factTypeShape.ReadingShapes.Count, Is.EqualTo(1));
            var readingShapeId = factTypeShape.ReadingShapes.Single();
            var readingShape = modelThings.OfType<ReadingShape>().Single(x => x.Id == readingShapeId);
            Assert.That(readingShape.Id, Is.EqualTo("_236F58BD-0E3F-4886-98B2-2C5ABC5497F4"));
            Assert.That(readingShape.IsExpanded, Is.True);
            Assert.That(readingShape.AbsoluteBounds, Is.EqualTo("6.276041666666667, 3.1657238151008884, 0.099959753453731537, 0.12950302660465241"));
            Assert.That(readingShape.Container, Is.EqualTo("_37834249-0C31-425F-B243-574EA4A414D4"));
            Assert.That(readingShape.Subject, Is.EqualTo("_DF16EE23-9D8E-4A45-B9F3-0304707A2876"));

            // FactTypeShapes.RoleNameShapes
            Assert.That(factTypeShape.RoleNameShapes.Count, Is.EqualTo(0));

            // FactTypeShapes.RoleDisplayOrder
            factTypeShape = modelThings.OfType<FactTypeShape>().Single(x => x.Id == "_A8606B42-36D8-4D98-BEC2-91439FCAB1A3");
            // TODO: assert RoleDisplayOrder are resolved
            Assert.That(factTypeShape.RoleDisplayOrder.Count, Is.EqualTo(2));
            
            // ExternalConstraintShapes
            Assert.That(diagram.ExternalConstraintShapes.Count, Is.EqualTo(2));
            var externalConstraintShape = modelThings.OfType<ExternalConstraintShape>().Single(x => x.Id == "_9E865D21-E51C-481C-950D-DDDACF98A7D1");
            Assert.That(externalConstraintShape.IsExpanded, Is.True);
            Assert.That(externalConstraintShape.AbsoluteBounds, Is.EqualTo("4.5416667064030962, 1.4895833134651182, 0.16, 0.16"));
            
            // FrequencyConstraintShapes
            Assert.That(diagram.FrequencyConstraintShapes.Count, Is.EqualTo(0));

            // RingConstraintShapes
            Assert.That(diagram.RingConstraintShapes.Count, Is.EqualTo(0));

            // ValueComparisonConstraintShapes
            Assert.That(diagram.ValueComparisonConstraintShapes.Count, Is.EqualTo(0));

            // ModelNoteShapes
            Assert.That(diagram.ModelNoteShapes.Count, Is.EqualTo(1));
            var modelNoteShape = modelThings.OfType<ModelNoteShape>().Single(x => x.Id == "_37CA8B9B-31F0-4C31-B479-A01A2A0E6A8C");
            Assert.That(modelNoteShape.IsExpanded, Is.True);
            Assert.That(modelNoteShape.AbsoluteBounds, Is.EqualTo("2.03125, 4.1458334922790527, 1.3454351778030396, 0.2588533217906952"));
        }
    }
}
