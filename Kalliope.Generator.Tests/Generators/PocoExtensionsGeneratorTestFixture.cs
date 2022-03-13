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

namespace Kalliope.Generator.Tests.Generators
{
    using System.IO;
    using System.Linq;

    using Kalliope.Generator.Generators;

    using NUnit.Framework;

    [TestFixture]
    public class PocoExtensionsGeneratorTestFixture
    {
        private PocoExtensionsGenerator pocoExtensionsGenerator;
        private DirectoryInfo autoGenExtensionDirectoryInfo;

        [SetUp]
        public void SetUp()
        {
            var outputpath = TestContext.CurrentContext.TestDirectory;
            var directoryInfo = new DirectoryInfo(outputpath);
            this.autoGenExtensionDirectoryInfo = directoryInfo.CreateSubdirectory("AutoGenExtension");

            this.pocoExtensionsGenerator = new PocoExtensionsGenerator();
            this.pocoExtensionsGenerator.LoadTemplates();
        }

        [Test]
        public void Verify_that_ExtensionClasses_are_generated()
        {
            Assert.DoesNotThrow(() => this.pocoExtensionsGenerator.Generate(this.autoGenExtensionDirectoryInfo));
        }

        [Test]
        public void Verify_That_Generate_Class_For_EntityType_Returns_Expected_Result()
        {
            var entityType = this.pocoExtensionsGenerator.TypeDrops.Single(x => x.Name == "EntityType");

            var dto = this.pocoExtensionsGenerator.GenerateType(entityType);

            var dtoPath = Path.Combine(this.autoGenExtensionDirectoryInfo.FullName, "EntityTypeExtensions.cs");

            File.WriteAllText(dtoPath, dto);

            var expected = File.ReadAllText(Path.Combine(TestContext.CurrentContext.TestDirectory, "Expected/AutoGenExtension/EntityTypeExtensions.cs"));

            Assert.AreEqual(expected, dto);
        }

        [Test]
        public void Verify_That_Generate_Class_For_ObjectType_Returns_Expected_Result()
        {
            var objectType = this.pocoExtensionsGenerator.TypeDrops.Single(x => x.Name == "ObjectType");

            var dto = this.pocoExtensionsGenerator.GenerateType(objectType);

            var dtoPath = Path.Combine(this.autoGenExtensionDirectoryInfo.FullName, "ObjectTypeExtensions.cs");

            File.WriteAllText(dtoPath, dto);

            var expected = File.ReadAllText(Path.Combine(TestContext.CurrentContext.TestDirectory, "Expected/AutoGenExtension/ObjectTypeExtensions.cs"));

            Assert.AreEqual(expected, dto);
        }

        [Test]
        public void Verify_That_Generate_Class_For_FactTypeShape_Returns_Expected_Result()
        {
            var factTypeShape = this.pocoExtensionsGenerator.TypeDrops.Single(x => x.Name == "FactTypeShape");

            var dto = this.pocoExtensionsGenerator.GenerateType(factTypeShape);

            var dtoPath = Path.Combine(this.autoGenExtensionDirectoryInfo.FullName, "FactTypeShapeExtensions.cs");

            File.WriteAllText(dtoPath, dto);

            var expected = File.ReadAllText(Path.Combine(TestContext.CurrentContext.TestDirectory, "Expected/AutoGenExtension/FactTypeShapeExtensions.cs"));

            Assert.AreEqual(expected, dto);
        }

       
    }
}
