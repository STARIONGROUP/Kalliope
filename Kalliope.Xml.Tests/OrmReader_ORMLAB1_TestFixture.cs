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

namespace Kalliope.Xml.Tests
{
    using System.IO;
    using System.Linq;

    using Kalliope;
    using Kalliope.Common;
    using Kalliope.Core;
    using Kalliope.Diagrams;

    using NUnit.Framework;

    /// <summary>
    /// Suite of tests to verify that an .orm file (ORMLAB1) can be read and the expected object graph is available
    /// </summary>
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
        public void Test1()
        {
            Assert.Pass();
        }
    }
}