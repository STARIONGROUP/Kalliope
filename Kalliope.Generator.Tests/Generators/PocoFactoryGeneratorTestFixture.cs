// -------------------------------------------------------------------------------------------------
// <copyright file="PocoFactoryGeneratorTestFixture.cs" company="Starion Group S.A.">
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
    public class PocoFactoryGeneratorTestFixture
    {
        private PocoFactoryGenerator pocoFactoryGenerator;
        private DirectoryInfo autogenPocoFactoryDirectoryInfo;

        [SetUp]
        public void SetUp()
        {
            var outputpath = TestContext.CurrentContext.TestDirectory;
            var directoryInfo = new DirectoryInfo(outputpath);
            this.autogenPocoFactoryDirectoryInfo = directoryInfo.CreateSubdirectory("AutoGenModelThingFactories");

            this.pocoFactoryGenerator = new PocoFactoryGenerator();
            this.pocoFactoryGenerator.LoadTemplates();
        }

        [Test]
        public void Verify_that_DTOs_are_generated()
        {
            Assert.DoesNotThrow(() => this.pocoFactoryGenerator.Generate(this.autogenPocoFactoryDirectoryInfo));
        }

        [Test]
        public void Verify_That_Generate_Class_For_EntityType_Returns_Expected_Result()
        {
            var entityType = this.pocoFactoryGenerator.TypeDrops.Single(x => x.Name == "EntityType");

            var entityTypeFactory = this.pocoFactoryGenerator.GenerateType(entityType);

            var dtoPath = Path.Combine(this.autogenPocoFactoryDirectoryInfo.FullName, "EntityTypeFactory.cs");

            File.WriteAllText(dtoPath, entityTypeFactory);

            var expected = File.ReadAllText(Path.Combine(TestContext.CurrentContext.TestDirectory, "Expected/AutoGenModelThingFactories/EntityTypeFactory.cs"));

            Assert.That(entityTypeFactory, Is.EqualTo(expected));
        }

        [Test]
        public void Verify_That_Generate_Class_For_FactTypeShape_Returns_Expected_Result()
        {
            var factTypeShape = this.pocoFactoryGenerator.TypeDrops.Single(x => x.Name == "FactTypeShape");

            var factTypeShapeFactory = this.pocoFactoryGenerator.GenerateType(factTypeShape);

            var dtoPath = Path.Combine(this.autogenPocoFactoryDirectoryInfo.FullName, "FactTypeShapeFactory.cs");

            File.WriteAllText(dtoPath, factTypeShapeFactory);

            var expected = File.ReadAllText(Path.Combine(TestContext.CurrentContext.TestDirectory, "Expected/AutoGenModelThingFactories/FactTypeShapeFactory.cs"));

            Assert.That(factTypeShapeFactory, Is.EqualTo(expected));
        }
    }
}
