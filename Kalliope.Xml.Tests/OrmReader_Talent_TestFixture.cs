// -------------------------------------------------------------------------------------------------
// <copyright file="OrmReader_Talent_TestFixture.cs" company="RHEA System S.A.">
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

    [TestFixture]
    public class OrmReader_Talent_TestFixture
    {
        private string ormfilePath;

        private OrmXmlReader ormXmlReader;

        [SetUp]
        public void Setup()
        {
            this.ormfilePath = Path.Combine(TestContext.CurrentContext.TestDirectory, "Data", "Talent.orm");

            this.ormXmlReader = new OrmXmlReader();
        }

        [Test]
        public void Verify_that_the_ORM_File_can_be_read_and_returns_expected_ORMModel()
        {
            var modelThings = this.ormXmlReader.Read(this.ormfilePath, false, null);

            var ormModel = modelThings.OfType<ORMModel>().Single();
            Assert.That(ormModel.Id, Is.EqualTo("_A1699447-0E2F-4761-A0F8-41728F39E722"));
            Assert.That(ormModel.Name, Is.EqualTo("TalentModel"));

            // Objects
            Assert.That(modelThings.OfType<EntityType>().Count(), Is.EqualTo(52));
            Assert.That(modelThings.OfType<ValueType>().Count(), Is.EqualTo(90));
            Assert.That(modelThings.OfType<ObjectifiedType>().Count(), Is.EqualTo(18));

            // Facts

            // Constraints

            // DataTypes

            // CustomReferenceModes
            Assert.That(ormModel.ReferenceModes.Count, Is.EqualTo(1));
            var customReferenceMode = modelThings.OfType<CustomReferenceMode>().Single(x => x.Id == "_924FEE50-B6A2-490B-ACFC-9623A7425CDB");
            Assert.That(customReferenceMode.Name, Is.EqualTo("size"));
            // TODO: implement Kind
            //Assert.That(customReferenceMode.Kind, Is.EqualTo("_4AD2AF8D-69D8-49B7-992C-A04A4AFC223B"));

            // ModelNotes
            Assert.That(ormModel.Notes.Count, Is.EqualTo(7));
            
            // ReferenceModeKinds
            Assert.That(ormModel.ReferenceModeKinds.Count, Is.EqualTo(3));
            var referenceModeKindGeneral = modelThings.OfType<ReferenceModeKind>().Single(x => x.Id == "_315FB9DD-A634-43EF-BD7D-A56429430A73");
            Assert.That(referenceModeKindGeneral.FormatString, Is.EqualTo("{1}"));
            Assert.That(referenceModeKindGeneral.ReferenceModeType, Is.EqualTo(ReferenceModeType.General));
            var referenceModeKindPopular = modelThings.OfType<ReferenceModeKind>().Single(x => x.Id == "_0C2FB188-9276-41BC-9502-706FC0369F3E");
            Assert.That(referenceModeKindPopular.FormatString, Is.EqualTo("{0}_{1}"));
            Assert.That(referenceModeKindPopular.ReferenceModeType, Is.EqualTo(ReferenceModeType.Popular));
        }

        [Test]
        public void Verify_that_the_ORM_File_can_be_read_and_returns_expected_NameGenerator()
        {
            var modelThings = this.ormXmlReader.Read(this.ormfilePath, false, null);
            
            var nameGenerator = modelThings.OfType<NameGenerator>().Single();

            // Name Generator
            Assert.That(nameGenerator.Id, Is.EqualTo("_D6BE94F4-6CC2-40E8-8A69-A1BEBF9AA16A"));
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
            Assert.That(generationState.Id, Is.EqualTo("_CFA57B1E-2C43-496B-8AC1-51F6B305989D"));
            Assert.That(generationState.GenerationSettings, Is.Null.Or.Empty);
        }
    }
}
