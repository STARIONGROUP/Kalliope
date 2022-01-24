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
            var ormModel = this.ormReader.Read(this.ormfilePath, false, null);

            Assert.That(ormModel.Id, Is.EqualTo("_E7741B74-3A9E-4F55-A891-9C7AEDF9EA45"));
            Assert.That(ormModel.Name, Is.EqualTo("ORMModel1"));

        }
    }
}