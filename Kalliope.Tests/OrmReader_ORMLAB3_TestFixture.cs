// -------------------------------------------------------------------------------------------------
// <copyright file="OrmReader_ORMLAB3_TestFixture.cs" company="RHEA System S.A.">
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
    public class OrmReader_ORMLAB3_TestFixture
    {
        private string ormfilePath;

        private OrmReader ormReader;

        [SetUp]
        public void Setup()
        {
            this.ormfilePath = Path.Combine(TestContext.CurrentContext.TestDirectory, "Data", "ORM_Lab3.orm");

            this.ormReader = new OrmReader();
        }

        [Test]
        public void Verify_that_the_ORM_File_can_be_read_and_returns_expected_ORMModel()
        {
            var ormRoot = this.ormReader.Read(this.ormfilePath, false, null);

            Assert.That(ormRoot.Model.Id, Is.EqualTo("_BBB698D9-5392-42EB-98F9-0DD34E05B957"));
            Assert.That(ormRoot.Model.Name, Is.EqualTo("ORM_Lab2.orm"));

            // Objects
            Assert.That(ormRoot.Model.ObjectTypes.OfType<EntityType>().Count(), Is.EqualTo(7));
            Assert.That(ormRoot.Model.ObjectTypes.OfType<ValueType>().Count(), Is.EqualTo(14));
            Assert.That(ormRoot.Model.ObjectTypes.OfType<ObjectifiedType>().Count(), Is.EqualTo(4));

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
            Assert.That(ormRoot.Model.FactTypes.Count, Is.EqualTo(22));
            var factType = ormRoot.Model.FactTypes.Single(x => x.Id == "_2904A934-2B98-4EC1-925E-F18E545A22B1");
            Assert.That(factType.Name, Is.EqualTo("StateHasStateCode"));

            // Constraints
            Assert.That(ormRoot.Model.SetConstraints.OfType<MandatoryConstraint>().Count(), Is.EqualTo(39));
            var mandatoryConstraint = ormRoot.Model.SetConstraints.OfType<MandatoryConstraint>().Single(x => x.Id == "_8AB3A94E-E1C7-4E85-B5C2-7D72E57C0952");
            Assert.That(mandatoryConstraint.Name, Is.EqualTo("SimpleMandatoryConstraint1"));
            Assert.That(mandatoryConstraint.IsSimple, Is.True);

            Assert.That(ormRoot.Model.SetConstraints.OfType<UniquenessConstraint>().Count(), Is.EqualTo(39));
            var uniquenessConstraint = ormRoot.Model.SetConstraints.OfType<UniquenessConstraint>().Single(x => x.Id == "_2972925F-EF20-4D76-B52C-81F2B250B260");
            Assert.That(uniquenessConstraint.Name, Is.EqualTo("InternalUniquenessConstraint1"));
            Assert.That(uniquenessConstraint.IsInternal, Is.True);

            // DataTypes
            Assert.That(ormRoot.Model.DataTypes.OfType<FixedLengthTextDataType>().Count(), Is.EqualTo(1));
            var fixedLengthTextDataType = ormRoot.Model.DataTypes.OfType<FixedLengthTextDataType>().Single();
            Assert.That(fixedLengthTextDataType.Id, Is.EqualTo("_D9C27BF7-D96F-43E5-95D3-8E3564C673C2"));

            Assert.That(ormRoot.Model.DataTypes.OfType<VariableLengthTextDataType>().Count(), Is.EqualTo(1));
            var variableLengthTextDataType = ormRoot.Model.DataTypes.OfType<VariableLengthTextDataType>().Single();
            Assert.That(variableLengthTextDataType.Id, Is.EqualTo("_E373F568-5861-412F-82E1-0B54D5C1E0FF"));

            Assert.That(ormRoot.Model.DataTypes.OfType<SignedIntegerNumericDataType>().Count(), Is.EqualTo(1));
            var signedIntegerNumericDataType = ormRoot.Model.DataTypes.OfType<SignedIntegerNumericDataType>().Single();
            Assert.That(signedIntegerNumericDataType.Id, Is.EqualTo("_C468C021-B3F1-4D22-B757-956BD0D17B15"));

            Assert.That(ormRoot.Model.DataTypes.OfType<UnsignedIntegerNumericDataType>().Count(), Is.EqualTo(1));
            var unsignedIntegerNumericDataType = ormRoot.Model.DataTypes.OfType<UnsignedIntegerNumericDataType>().Single();
            Assert.That(unsignedIntegerNumericDataType.Id, Is.EqualTo("_AA1E2088-6261-4D48-A91E-2EE05ECBB067"));

            Assert.That(ormRoot.Model.DataTypes.OfType<DateTemporalDataType>().Count(), Is.EqualTo(1));
            var dateTemporalDataType = ormRoot.Model.DataTypes.OfType<DateTemporalDataType>().Single();
            Assert.That(dateTemporalDataType.Id, Is.EqualTo("_52D54BE0-1507-4780-954B-80ACBE17F96A"));

            Assert.That(ormRoot.Model.DataTypes.OfType<TrueOrFalseLogicalDataType>().Count(), Is.EqualTo(1));
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
            Assert.That(ormRoot.Diagrams.Count, Is.EqualTo(2));

            var diagram = ormRoot.Diagrams.Single(x => x.Id == "_D80C0423-0227-477D-84AA-32E6BF3A0659");
            Assert.That(diagram.IsCompleteView, Is.True);
            Assert.That(diagram.Name, Is.EqualTo("Movie"));
            Assert.That(diagram.BaseFontName, Is.EqualTo("Tahoma"));
            Assert.That(diagram.BaseFontSize, Is.EqualTo(0.0972222238779068));

            // ObjectTypeShapes
            Assert.That(diagram.ObjectTypeShapes.Count, Is.EqualTo(6));
            var objectTypeShape = diagram.ObjectTypeShapes.Single(x => x.Id == "_E8AC4E21-B2EA-44EE-AB64-BF9A46014FBD");
            Assert.That(objectTypeShape.IsExpanded, Is.True);
            Assert.That(objectTypeShape.AbsoluteBounds, Is.EqualTo("1.5504014194011688, 2.59375, 0.72140424966812133, 0.22950302660465241"));
            Assert.That(objectTypeShape.ExpandRefMode, Is.False);
            Assert.That(objectTypeShape.DisplayRelatedTypes, Is.EqualTo(RelatedTypesDisplay.AttachAllTypes));

            // ObjectTypeShapes.RelativeShapes
            var valueConstraintShape = objectTypeShape.ValueConstraintShapes.Single();
            Assert.That(valueConstraintShape.Id, Is.EqualTo("_200444FA-B4DB-431C-9AE6-A9A6633B84ED"));
            Assert.That(valueConstraintShape.IsExpanded, Is.True);
            Assert.That(valueConstraintShape.AbsoluteBounds, Is.EqualTo("2.33180566906929, 2.4642469733953476, 0.93807417154312134, 0.12950302660465241"));

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

            // Subject
        }
    }
}
