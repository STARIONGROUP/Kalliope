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

namespace Kalliope.Tests
{
    using System.IO;
    using System.Linq;

    using Kalliope;
    using Kalliope.Core;

    using NUnit.Framework;

    [TestFixture]
    public class OrmReader_Talent_TestFixture
    {
        private string ormfilePath;

        private OrmReader ormReader;

        [SetUp]
        public void Setup()
        {
            this.ormfilePath = Path.Combine(TestContext.CurrentContext.TestDirectory, "Data", "Talent.orm");

            this.ormReader = new OrmReader();
        }

        [Test]
        public void Verify_that_the_ORM_File_can_be_read_and_returns_expected_ORMModel()
        {
            var ormRoot = this.ormReader.Read(this.ormfilePath, false, null);

            Assert.That(ormRoot.Model.Id, Is.EqualTo("_A1699447-0E2F-4761-A0F8-41728F39E722"));
            Assert.That(ormRoot.Model.Name, Is.EqualTo("TalentModel"));

            // Objects
            Assert.That(ormRoot.Model.ObjectTypes.OfType<EntityType>().Count(), Is.EqualTo(52));
            Assert.That(ormRoot.Model.ObjectTypes.OfType<ValueType>().Count(), Is.EqualTo(90));
            Assert.That(ormRoot.Model.ObjectTypes.OfType<ObjectifiedType>().Count(), Is.EqualTo(18));

            // Facts

            // Constraints

            // DataTypes

            // CustomReferenceModes
            Assert.That(ormRoot.Model.CustomReferenceModes.Count, Is.EqualTo(1));
            var customReferenceMode = ormRoot.Model.CustomReferenceModes.Single(x => x.Id == "_924FEE50-B6A2-490B-ACFC-9623A7425CDB");
            Assert.That(customReferenceMode.Name, Is.EqualTo("size"));

            // ModelNotes
            Assert.That(ormRoot.Model.ModelNotes.Count, Is.EqualTo(7));
            
            // ReferenceModeKinds
            Assert.That(ormRoot.Model.ReferenceModeKinds.Count, Is.EqualTo(3));
            var referenceModeKindGeneral = ormRoot.Model.ReferenceModeKinds.Single(x => x.Id == "_315FB9DD-A634-43EF-BD7D-A56429430A73");
            Assert.That(referenceModeKindGeneral.FormatString, Is.EqualTo("{1}"));
            Assert.That(referenceModeKindGeneral.ReferenceModeType, Is.EqualTo(ReferenceModeType.General));
            var referenceModeKindPopular = ormRoot.Model.ReferenceModeKinds.Single(x => x.Id == "_0C2FB188-9276-41BC-9502-706FC0369F3E");
            Assert.That(referenceModeKindPopular.FormatString, Is.EqualTo("{0}_{1}"));
            Assert.That(referenceModeKindPopular.ReferenceModeType, Is.EqualTo(ReferenceModeType.Popular));
        }

        [Test]
        public void Verify_that_the_ORM_File_can_be_read_and_returns_expected_NameGenerator()
        {
            var ormRoot = this.ormReader.Read(this.ormfilePath, false, null);

            // Name Generator
            Assert.That(ormRoot.NameGenerator.Id, Is.EqualTo("_D6BE94F4-6CC2-40E8-8A69-A1BEBF9AA16A"));
            Assert.That(ormRoot.NameGenerator.AutomaticallyShortenNames, Is.True);
            Assert.That(ormRoot.NameGenerator.UseTargetDefaultMaximum, Is.True);
            Assert.That(ormRoot.NameGenerator.UserDefinedMaximum, Is.EqualTo(128));
            Assert.That(ormRoot.NameGenerator.CasingOption, Is.EqualTo(NameGeneratorCasingOption.None));
            Assert.That(ormRoot.NameGenerator.SpacingFormat, Is.EqualTo(NameGeneratorSpacingFormat.Retain));
            Assert.That(ormRoot.NameGenerator.SpacingReplacement, Is.Empty);
        }

        [Test]
        public void Verify_that_the_ORM_File_can_be_read_and_returns_expected_GenerationState()
        {
            var ormRoot = this.ormReader.Read(this.ormfilePath, false, null);

            // Generation State
            Assert.That(ormRoot.GenerationState.Id, Is.EqualTo("_CFA57B1E-2C43-496B-8AC1-51F6B305989D"));
            Assert.That(ormRoot.GenerationState.GenerationSettings, Is.Empty);
        }
    }
}
