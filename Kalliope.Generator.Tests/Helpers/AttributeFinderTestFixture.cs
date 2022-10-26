// -------------------------------------------------------------------------------------------------
// <copyright file="DtoGeneratorTestFixture.cs" company="RHEA System S.A.">
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

namespace Kalliope.Generator.Tests.Helpers
{
    using System;
    using System.IO;

    using Kalliope.Generator.Helpers;

    using NUnit.Framework;

    [TestFixture]
    public class AttributeFinderTestFixture
    {
        private AttributeFinder attributeFinder;

        [SetUp]
        public void SetUp()
        {
            this.attributeFinder = new AttributeFinder();
        }

        [Test]
        public void QueryAttributeNames()
        {
            Assert.Ignore("used as utility during reverse engineering");

            var xmlPath = Path.Combine(TestContext.CurrentContext.TestDirectory, "Data", "some-patj.orm");

            var attributes = this.attributeFinder.Attributes("absorb:HierarchyChild", xmlPath);

            foreach (var attribute in attributes)
            {
                Console.WriteLine(attribute);
            }
        }
    }
}
