// -------------------------------------------------------------------------------------------------
// <copyright file="ModelThingExtensionsGeneratorTestFixture.cs" company="Starion Group S.A.">
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

namespace Kalliope.Generator.Tests.Generators
{
    using System.IO;
    using System.Linq;

    using Kalliope.Generator.Generators;

    using NUnit.Framework;

    [TestFixture]
    public class ModelThingExtensionsGeneratorTestFixture
    {
        private ModelThingExtensionsGenerator modelThingExtensionsGenerator;
        private DirectoryInfo autoGenModelThingDirectoryInfo;

        [SetUp]
        public void SetUp()
        {
            var outputpath = TestContext.CurrentContext.TestDirectory;
            var directoryInfo = new DirectoryInfo(outputpath);
            this.autoGenModelThingDirectoryInfo = directoryInfo.CreateSubdirectory("AutoGenModelThing");

            this.modelThingExtensionsGenerator = new ModelThingExtensionsGenerator();
            this.modelThingExtensionsGenerator.LoadTemplates();
        }

        [Test]
        public void Verify_that_DTOs_are_generated()
        {
            Assert.DoesNotThrow(() => this.modelThingExtensionsGenerator.Generate(this.autoGenModelThingDirectoryInfo));
        }
    }
}
