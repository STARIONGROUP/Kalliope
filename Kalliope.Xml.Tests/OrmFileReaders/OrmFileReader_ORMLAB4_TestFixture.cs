// -------------------------------------------------------------------------------------------------
// <copyright file="OrmFileReader_ORMLAB4_TestFixture.cs" company="Starion Group S.A.">
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

namespace Kalliope.Xml.Tests.OrmFileReaders
{
    using System;
    using System.IO;
    using System.Linq;

    using Kalliope.Common;

    using NUnit.Framework;

    [TestFixture]
    public class OrmFileReader_ORMLAB4_TestFixture
    {
        private string ormfilePath;

        private OrmFileReader fileReader;

        private OrmXmlReader ormXmlReader;

        private Kalliope.OrmRoot ormRoot;

        [SetUp]
        public void Setup()
        {
            this.ormfilePath = Path.Combine(TestContext.CurrentContext.TestDirectory, "Data", "ORM_Lab4.orm");

            this.ormXmlReader = new OrmXmlReader();

            this.fileReader = new OrmFileReader
            {
                OrmXmlReader = this.ormXmlReader
            };

            this.fileReader.Read(this.ormfilePath);
            var cache = this.fileReader.Assembler.Cache;
            Lazy<Kalliope.Core.ModelThing> lazyPoco;
            cache.TryGetValue("root:_A0258532-8AB1-4D5E-83F3-A2B8C96B2329", out lazyPoco);
            this.ormRoot = (Kalliope.OrmRoot)lazyPoco.Value;
        }

        [Test]
        public void Verify_that_the_ORM_File_can_be_read_and_returns_expected_ORMModel()
        {
            Assert.That(this.ormRoot.Model.Id, Is.EqualTo("_A0258532-8AB1-4D5E-83F3-A2B8C96B2329"));
            Assert.That(this.ormRoot.Model.Name, Is.EqualTo("ORMModel4"));
            Assert.That(this.ormRoot.Model.ReferenceMode, Is.Null.Or.Empty);

            // Objects
            Assert.That(this.ormRoot.Model.ObjectTypes.OfType<Core.EntityType>().Count(), Is.EqualTo(14));
            var entityType = this.ormRoot.Model.ObjectTypes.OfType<Core.EntityType>().Single(x => x.Id == "_A5DE0D30-AC21-496C-9051-A8CE684C9548");
            Assert.That(entityType.Name, Is.EqualTo("FemaleEmployee"));
            var derivationRule = entityType.DerivationRule;

            //Assert.That(derivationRule.SubtypeDerivationPath.InformalRule.DerivationNote.Id, Is.EqualTo("_9F8C3C13-E7FB-4CCC-861C-C48727DBD2C9"));
            //Assert.That(derivationRule.SubtypeDerivationPath.InformalRule.DerivationNote.Body, Is.EqualTo(@"Each FemaleEmployee is an Employee of Gender 'F'"));
            Assert.That(this.ormRoot.Model.ObjectTypes.OfType<Core.ValueType>().Count(), Is.EqualTo(11));
            var valueType = this.ormRoot.Model.ObjectTypes.OfType<Core.ValueType>().Single(x => x.Id == "_59F9F65F-2F50-46FC-8AD5-28BA64446924");
            Assert.That(valueType.Name, Is.EqualTo("Gender_code"));
            var valueTypeValueConstraint = valueType.ValueConstraint;
            Assert.That(valueTypeValueConstraint.Id, Is.EqualTo("_F2297911-44F2-4646-9E9F-B4E868CD8A24"));
            Assert.That(valueTypeValueConstraint.Name, Is.EqualTo("ValueTypeValueConstraint1"));
            var valueRange = valueTypeValueConstraint.ValueRanges.Single();
            Assert.That(valueRange.Id, Is.EqualTo("_40B7D8C4-CA40-4BA3-8137-FA995C42AE47"));
            Assert.That(valueRange.MinValue, Is.EqualTo("M, F"));
            Assert.That(valueRange.MaxValue, Is.EqualTo("M, F"));
            Assert.That(valueRange.MinInclusion, Is.EqualTo(RangeInclusion.NotSet));
            Assert.That(valueRange.MaxInclusion, Is.EqualTo(RangeInclusion.NotSet));

            Assert.That(this.ormRoot.Model.ObjectTypes.OfType<Core.ObjectifiedType>().Count(), Is.EqualTo(4));
            var objectifiedType = this.ormRoot.Model.ObjectTypes.OfType<Core.ObjectifiedType>().Single(x => x.Id == "_76A2B645-0CF9-4BD5-81D7-31F22BE79BB7");
            Assert.That(objectifiedType.Name, Is.EqualTo("FemaleManagerWasSentFlowersOnDate"));
            Assert.That(objectifiedType.IsIndependent, Is.True);
            Assert.That(objectifiedType.ReferenceMode, Is.Null.Or.Empty);
            //Assert.That(objectifiedType.NestedPredicate.Id, Is.EqualTo("_0979AE01-37FD-48F9-B690-2164D851238C"));
            //Assert.That(objectifiedType.NestedPredicate.IsImplied, Is.True);

            // Facts
            Assert.That(this.ormRoot.Model.FactTypes.Count, Is.EqualTo(38));
            Assert.That(this.ormRoot.Model.FactTypes.OfType<Core.SubtypeFact>().Count, Is.EqualTo(6));

            // Constraints


            // DataTypes

            // CustomReferenceModes
            //Assert.That(ormRoot.Model.CustomReferenceModes.Count, Is.EqualTo(1));
            //var customReferenceMode = ormRoot.Model.CustomReferenceModes.Single(x => x.Id == "_924FEE50-B6A2-490B-ACFC-9623A7425CDB");
            //Assert.That(customReferenceMode.Name, Is.EqualTo("size"));

            // ModelNotes
            //Assert.That(ormRoot.Model.ModelNotes.Count, Is.EqualTo(7));

            // ReferenceModeKinds
            //Assert.That(ormRoot.Model.ReferenceModeKinds.Count, Is.EqualTo(3));
            //var referenceModeKindGeneral = ormRoot.Model.ReferenceModeKinds.Single(x => x.Id == "_315FB9DD-A634-43EF-BD7D-A56429430A73");
            //Assert.That(referenceModeKindGeneral.FormatString, Is.EqualTo("{1}"));
            //Assert.That(referenceModeKindGeneral.ReferenceModeType, Is.EqualTo(ReferenceModeType.General));
            //var referenceModeKindPopular = ormRoot.Model.ReferenceModeKinds.Single(x => x.Id == "_0C2FB188-9276-41BC-9502-706FC0369F3E");
            //Assert.That(referenceModeKindPopular.FormatString, Is.EqualTo("{0}_{1}"));
            //Assert.That(referenceModeKindPopular.ReferenceModeType, Is.EqualTo(ReferenceModeType.Popular));
        }
    }
}
