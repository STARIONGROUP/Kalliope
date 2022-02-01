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
    using System.Threading;
    using System.Threading.Tasks;

    using Kalliope;
    using Kalliope.Core;

    using NUnit.Framework;

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
        public void Verify_that_the_ORM_File_can_be_read_and_returns_expected_result()
        {
            var ormRoot = this.ormReader.Read(this.ormfilePath, false, null);

            Assert.That(ormRoot.Model.Id, Is.EqualTo("_E7741B74-3A9E-4F55-A891-9C7AEDF9EA45"));
            Assert.That(ormRoot.Model.Name, Is.EqualTo("ORMModel1"));

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

            Assert.That(ormRoot.Model.DataTypes.OfType<VariableLengthTextDataType>().Count(), Is.EqualTo(1));
            var variableLengthTextDataType = ormRoot.Model.DataTypes.OfType<VariableLengthTextDataType>().Single();
            Assert.That(variableLengthTextDataType.Id, Is.EqualTo("_D03565BE-6350-4A94-B533-8594C682FEBA"));

            Assert.That(ormRoot.Model.DataTypes.OfType<UnsignedIntegerNumericDataType>().Count(), Is.EqualTo(1));
            var unsignedIntegerNumericDataType = ormRoot.Model.DataTypes.OfType<UnsignedIntegerNumericDataType>().Single();
            Assert.That(unsignedIntegerNumericDataType.Id, Is.EqualTo("_856C99EF-744D-442A-A661-29B0E7AFF452"));

            Assert.That(ormRoot.Model.DataTypes.OfType<TrueOrFalseLogicalDataType>().Count(), Is.EqualTo(1));
            var trueOrFalseLogicalDataType = ormRoot.Model.DataTypes.OfType<TrueOrFalseLogicalDataType>().Single();
            Assert.That(trueOrFalseLogicalDataType.Id, Is.EqualTo("_158BA443-362E-4E4E-95C7-5BF6A81442A8"));
        }
    }
}