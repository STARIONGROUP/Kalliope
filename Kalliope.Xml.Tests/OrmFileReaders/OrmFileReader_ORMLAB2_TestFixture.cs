// -------------------------------------------------------------------------------------------------
// <copyright file="OrmFileReader_ORMLAB2_TestFixture.cs" company="RHEA System S.A.">
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

namespace Kalliope.Xml.Tests.OrmFileReaders
{
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Threading.Tasks;

    using Kalliope.Common;
    using Kalliope.DTO;

    using NUnit.Framework;

    [TestFixture]
    public class OrmFileReader_ORMLAB2_TestFixture
    {
        private string ormfilePath;

        private OrmFileReader fileReader;

        private OrmXmlReader ormXmlReader;

        [SetUp]
        public void Setup()
        {
            this.ormfilePath = Path.Combine(TestContext.CurrentContext.TestDirectory, "Data", "ORM_Lab2.orm");

            this.ormXmlReader = new OrmXmlReader();

            this.fileReader = new OrmFileReader
            {
                OrmXmlReader = this.ormXmlReader
            };
        }

        [Test]
        public void Verify_that_the_ORM_File_can_be_read_and_returns_expected_ORMModel()
        {
            this.fileReader.Read(this.ormfilePath);

            Assert.That(this.fileReader.Assembler.Cache.IsEmpty, Is.False);
        }
    }
}
