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

namespace Kalliope.Tests
{
    using System.IO;
    using System.Linq;

    using Kalliope;
    using Kalliope.Core;
    using Kalliope.Diagrams;

    using NUnit.Framework;

    /// <summary>
    /// Suite of tests to verify that an .orm file (ORMLAB2) can be read and the expected object graph is available
    /// </summary>
    [TestFixture]
    public class OrmReader_ORMLAB2_TestFixture
    {
        private string ormfilePath;

        private OrmReader ormReader;

        [SetUp]
        public void Setup()
        {
            this.ormfilePath = Path.Combine(TestContext.CurrentContext.TestDirectory, "Data", "ORM_Lab2.orm");

            this.ormReader = new OrmReader();
        }

        [Test]
        public void Verify_that_the_ORM_File_can_be_read_and_returns_expected_ORMModel()
        {
            var ormRoot = this.ormReader.Read(this.ormfilePath, false, null);

            Assert.That(ormRoot.Model.Id, Is.EqualTo("_BBB698D9-5392-42EB-98F9-0DD34E05B957"));
            Assert.That(ormRoot.Model.Name, Is.EqualTo("ORM_Lab2.orm"));

            // Objects
            Assert.That(ormRoot.Model.ObjectTypes.OfType<EntityType>().Count(), Is.EqualTo(5));
            Assert.That(ormRoot.Model.ObjectTypes.OfType<ValueType>().Count(), Is.EqualTo(10));
            Assert.That(ormRoot.Model.ObjectTypes.OfType<ObjectifiedType>().Count(), Is.EqualTo(1));

            var entityType = ormRoot.Model.ObjectTypes.OfType<EntityType>().Single(x => x.Id == "_2D2953A6-8E07-4158-93E5-FF241BC9838C");
            Assert.That(entityType.Name, Is.EqualTo("City"));
            Assert.That(entityType.ReferenceMode, Is.Empty);

            var valueType = ormRoot.Model.ObjectTypes.OfType<ValueType>().Single(x => x.Id == "_EA2FBA06-5757-4B69-8823-BDD954075EE5");
            Assert.That(valueType.Name, Is.EqualTo("State_code"));

            var objectifiedType = ormRoot.Model.ObjectTypes.OfType<ObjectifiedType>().Single(x => x.Id == "_BB1CD3E9-9118-40A3-A23B-260ED585267A");
            Assert.That(objectifiedType.Name, Is.EqualTo("CinemaFirstShowedMovieOnDate"));
            Assert.That(objectifiedType.IsIndependent, Is.False);
            Assert.That(objectifiedType.ReferenceMode, Is.Empty);

            // Facts
            Assert.That(ormRoot.Model.FactTypes.Count, Is.EqualTo(16));
            var factType = ormRoot.Model.FactTypes.Single(x => x.Id == "_2904A934-2B98-4EC1-925E-F18E545A22B1");
            Assert.That(factType.Name, Is.EqualTo("StateHasStateCode"));

            // Constraints
            Assert.That(ormRoot.Model.SetConstraints.OfType<MandatoryConstraint>().Count(), Is.EqualTo(25));
            var mandatoryConstraint = ormRoot.Model.SetConstraints.OfType<MandatoryConstraint>().Single(x => x.Id == "_4AF1D6BC-4EFB-4AF9-A1E7-6EBBF9FE8396");
            Assert.That(mandatoryConstraint.Name, Is.EqualTo("ImpliedMandatoryConstraint1"));
            Assert.That(mandatoryConstraint.IsSimple, Is.False);
            Assert.That(mandatoryConstraint.IsImplied, Is.True);

            Assert.That(ormRoot.Model.SetConstraints.OfType<UniquenessConstraint>().Count(), Is.EqualTo(22));
            var uniquenessConstraint = ormRoot.Model.SetConstraints.OfType<UniquenessConstraint>().Single(x => x.Id == "_2972925F-EF20-4D76-B52C-81F2B250B260");
            Assert.That(uniquenessConstraint.Name, Is.EqualTo("InternalUniquenessConstraint1"));
            Assert.That(uniquenessConstraint.IsInternal, Is.True);
            
            // DataTypes
            var fixedLengthTextDataType = ormRoot.Model.DataTypes.OfType<FixedLengthTextDataType>().Single();
            Assert.That(fixedLengthTextDataType.Id, Is.EqualTo("_D9C27BF7-D96F-43E5-95D3-8E3564C673C2"));

            var variableLengthTextDataType = ormRoot.Model.DataTypes.OfType<VariableLengthTextDataType>().Single();
            Assert.That(variableLengthTextDataType.Id, Is.EqualTo("_E373F568-5861-412F-82E1-0B54D5C1E0FF"));

            var signedIntegerNumericDataType = ormRoot.Model.DataTypes.OfType<SignedIntegerNumericDataType>().Single();
            Assert.That(signedIntegerNumericDataType.Id, Is.EqualTo("_C468C021-B3F1-4D22-B757-956BD0D17B15"));
            
            var unsignedIntegerNumericDataType = ormRoot.Model.DataTypes.OfType<UnsignedIntegerNumericDataType>().Single();
            Assert.That(unsignedIntegerNumericDataType.Id, Is.EqualTo("_AA1E2088-6261-4D48-A91E-2EE05ECBB067"));

            var dateTemporalDataType = ormRoot.Model.DataTypes.OfType<DateTemporalDataType>().Single();
            Assert.That(dateTemporalDataType.Id, Is.EqualTo("_52D54BE0-1507-4780-954B-80ACBE17F96A"));

            var trueOrFalseLogicalDataType = ormRoot.Model.DataTypes.OfType<TrueOrFalseLogicalDataType>().Single();
            Assert.That(trueOrFalseLogicalDataType.Id, Is.EqualTo("_33BFD2D0-785B-4750-8215-AE04CB185578"));

            // CustomReferenceModes
            Assert.That(ormRoot.Model.CustomReferenceModes.Count, Is.EqualTo(0));

            // ModelNotes
            Assert.That(ormRoot.Model.ModelNotes.Count, Is.EqualTo(1));
            
            // ReferenceModeKinds
            Assert.That(ormRoot.Model.ReferenceModeKinds.Count, Is.EqualTo(3));
            var referenceModeKindGeneral = ormRoot.Model.ReferenceModeKinds.Single(x => x.Id == "_2B4A7877-B9B5-40A5-854C-30392896A6A4");
            Assert.That(referenceModeKindGeneral.FormatString, Is.EqualTo("{1}"));
            Assert.That(referenceModeKindGeneral.ReferenceModeType, Is.EqualTo(ReferenceModeType.General));

            var referenceModeKindPopular = ormRoot.Model.ReferenceModeKinds.Single(x => x.Id == "_8ED25F0C-B843-45A9-8CA6-27D077590437");
            Assert.That(referenceModeKindPopular.FormatString, Is.EqualTo("{0}_{1}"));
            Assert.That(referenceModeKindPopular.ReferenceModeType, Is.EqualTo(ReferenceModeType.Popular));

            var referenceModeKindUnitBased = ormRoot.Model.ReferenceModeKinds.Single(x => x.Id == "_2FAF73C7-3C3E-4F9A-A381-03F7CA1BA108");
            Assert.That(referenceModeKindUnitBased.FormatString, Is.EqualTo("{1}Value"));
            Assert.That(referenceModeKindUnitBased.ReferenceModeType, Is.EqualTo(ReferenceModeType.UnitBased));
        }

        [Test]
        public void Verify_that_the_ORM_File_can_be_read_and_returns_expected_NameGenerator()
        {
            var ormRoot = this.ormReader.Read(this.ormfilePath, false, null);

            // Name Generator
            Assert.That(ormRoot.NameGenerator, Is.Null);
        }

        [Test]
        public void Verify_that_the_ORM_File_can_be_read_and_returns_expected_GenerationState()
        {
            var ormRoot = this.ormReader.Read(this.ormfilePath, false, null);

            // Generation State
            Assert.That(ormRoot.GenerationState, Is.Null);
        }

        [Test]
        public void Verify_that_the_ORM_File_can_be_read_and_returns_expected_Diagrams()
        {
            var ormRoot = this.ormReader.Read(this.ormfilePath, false, null);

            // Diagrams
            Assert.That(ormRoot.Diagrams.Count, Is.EqualTo(1));

            var diagram = ormRoot.Diagrams.Single(x => x.Id == "_019FB281-3506-4C64-9A83-7A64F7A01D55");
            Assert.That(diagram.IsCompleteView, Is.False);
            Assert.That(diagram.Name, Is.EqualTo("Cinema"));
            Assert.That(diagram.BaseFontName, Is.EqualTo("Tahoma"));
            Assert.That(diagram.BaseFontSize, Is.EqualTo(0.0972222238779068));

            // ObjectTypeShapes
            Assert.That(diagram.ObjectTypeShapes.Count, Is.EqualTo(9));
            var objectTypeShape = diagram.ObjectTypeShapes.Single(x => x.Id == "_3D692D51-D04C-4AE0-96B4-50A7B3A07641");
            Assert.That(objectTypeShape.IsExpanded, Is.True);
            Assert.That(objectTypeShape.AbsoluteBounds, Is.EqualTo("3.1645833333333329, 1.3916666865348812, 0.34875072062015533, 0.22950302660465241"));
            Assert.That(objectTypeShape.ExpandRefMode, Is.False);
            Assert.That(objectTypeShape.DisplayRelatedTypes, Is.EqualTo(RelatedTypesDisplay.AttachAllTypes));

            objectTypeShape = diagram.ObjectTypeShapes.Single(x => x.Id == "_0B5F48A9-9454-436F-A3C5-F1D94D1491BB");
            Assert.That(objectTypeShape.ExpandRefMode, Is.True);
            Assert.That(objectTypeShape.DisplayRelatedTypes, Is.EqualTo(RelatedTypesDisplay.AttachAllTypes));

            // ObjectTypeShapes.ValueConstraintShapes
            objectTypeShape = diagram.ObjectTypeShapes.Single(x => x.Id == "_6DB3F675-D1B1-41E9-9594-BFAE5AF23BFC");
            Assert.That(objectTypeShape.ExpandRefMode, Is.False);
            Assert.That(objectTypeShape.DisplayRelatedTypes, Is.EqualTo(RelatedTypesDisplay.AttachAllTypes));
            var constraintShape = objectTypeShape.ValueConstraintShapes.Single();
            Assert.That(constraintShape.Id, Is.EqualTo("_03A3C5F1-A42A-4B68-A877-EE514FD2D03F"));
            Assert.That(constraintShape.IsExpanded, Is.True);
            Assert.That(constraintShape.AbsoluteBounds, Is.EqualTo("2.0143245685100544, 2.7697733173953991, 0.35341161489486694, 0.12950302660465241"));
            
            // FactTypeShapes
            Assert.That(diagram.FactTypeShapes.Count, Is.EqualTo(10));

            var factTypeShape = diagram.FactTypeShapes.Single(x => x.Id == "_A8606B42-36D8-4D98-BEC2-91439FCAB1A3");
            Assert.That(factTypeShape.IsExpanded, Is.True);
            Assert.That(factTypeShape.AbsoluteBounds, Is.EqualTo("3.1808333532015478, 1.8949999999999998, 0.24388888899236916, 0.38388888899236917"));
            Assert.That(factTypeShape.ConstraintDisplayPosition, Is.EqualTo(ConstraintDisplayPosition.Top));
            Assert.That(factTypeShape.DisplayRoleNames, Is.EqualTo(DisplayRoleNames.UserDefault));
            Assert.That(factTypeShape.DisplayOrientation, Is.EqualTo(DisplayOrientation.VerticalRotatedLeft));
            Assert.That(factTypeShape.DisplayRelatedTypes, Is.EqualTo(RelatedTypesDisplay.AttachAllTypes));

            factTypeShape = diagram.FactTypeShapes.Single(x => x.Id == "_37834249-0C31-425F-B243-574EA4A414D4");
            Assert.That(factTypeShape.IsExpanded, Is.True);
            Assert.That(factTypeShape.AbsoluteBounds, Is.EqualTo("6.276041666666667, 2.857083412806193, 0.38388888899236917, 0.24388888899236916"));
            
            // FactTypeShapes.ReadingShapes
            Assert.That(factTypeShape.ReadingShapes.Count, Is.EqualTo(1));
            var readingShape = factTypeShape.ReadingShapes.Single();
            Assert.That(readingShape.Id, Is.EqualTo("_236F58BD-0E3F-4886-98B2-2C5ABC5497F4"));
            Assert.That(readingShape.IsExpanded, Is.True);
            Assert.That(readingShape.AbsoluteBounds, Is.EqualTo("6.276041666666667, 3.1657238151008884, 0.099959753453731537, 0.12950302660465241"));

            // FactTypeShapes.RoleNameShapes
            Assert.That(factTypeShape.RoleNameShapes.Count, Is.EqualTo(0));

            // FactTypeShapes.RoleDisplayOrder
            factTypeShape = diagram.FactTypeShapes.Single(x => x.Id == "_A8606B42-36D8-4D98-BEC2-91439FCAB1A3");
            // TODO: assert RoleDisplayOrder are resolved

            // ExternalConstraintShapes
            Assert.That(diagram.ExternalConstraintShapes.Count, Is.EqualTo(2));
            var externalConstraintShape = diagram.ExternalConstraintShapes.Single(x => x.Id == "_9E865D21-E51C-481C-950D-DDDACF98A7D1");
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
            var modelNoteShape = diagram.ModelNoteShapes.Single(x => x.Id == "_37CA8B9B-31F0-4C31-B479-A01A2A0E6A8C");
            Assert.That(modelNoteShape.IsExpanded, Is.True);
            Assert.That(modelNoteShape.AbsoluteBounds, Is.EqualTo("2.03125, 4.1458334922790527, 1.3454351778030396, 0.2588533217906952"));

            // Subject
        }
    }
}
