// -------------------------------------------------------------------------------------------------
// <copyright file="DtoGeneratorTestFixture.cs" company="Starion Group S.A.">
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
    public class DtoGeneratorTestFixture
    {
        private DtoGenerator dtoGenerator;
        private DirectoryInfo autogenDtoDirectoryInfo;

        [SetUp]
        public void SetUp()
        {
            var outputpath = TestContext.CurrentContext.TestDirectory;
            var directoryInfo = new DirectoryInfo(outputpath);
            this.autogenDtoDirectoryInfo = directoryInfo.CreateSubdirectory("AutoGenDto");

            this.dtoGenerator = new DtoGenerator();
            this.dtoGenerator.LoadTemplates();
        }

        [Test]
        public void Verify_that_DTOs_are_generated()
        {
            Assert.DoesNotThrow(() => this.dtoGenerator.Generate(this.autogenDtoDirectoryInfo));
        }

        [Test]
        public void Verify_That_Generate_Class_For_ModelThing_Returns_Expected_Result()
        {
            var entityType = this.dtoGenerator.TypeDrops.Single(x => x.Name == "ModelThing");

            var dto = this.dtoGenerator.GenerateType(entityType);

            var dtoPath = Path.Combine(this.autogenDtoDirectoryInfo.FullName, "ModelThing.cs");

            File.WriteAllText(dtoPath, dto);

            var expected = File.ReadAllText(Path.Combine(TestContext.CurrentContext.TestDirectory, "Expected/AutoGenDto/ModelThing.cs"));

            Assert.That(dto, Is.EqualTo(expected));
        }

        [Test]
        public void Verify_That_Generate_Class_For_EntityType_Returns_Expected_Result()
        {
            var entityType = this.dtoGenerator.TypeDrops.Single(x => x.Name == "EntityType");
            
            var dto = this.dtoGenerator.GenerateType(entityType);

            var dtoPath = Path.Combine(this.autogenDtoDirectoryInfo.FullName, "EntityType.cs");

            File.WriteAllText(dtoPath, dto);

            var expected = File.ReadAllText(Path.Combine(TestContext.CurrentContext.TestDirectory, "Expected/AutoGenDto/EntityType.cs"));

            Assert.That(dto, Is.EqualTo(expected));
        }

        [Test]
        public void Verify_That_Generate_Class_For_ObjectType_Returns_Expected_Result()
        {
            var objectType = this.dtoGenerator.TypeDrops.Single(x => x.Name == "ObjectType");

            var dto = this.dtoGenerator.GenerateType(objectType);

            var dtoPath = Path.Combine(this.autogenDtoDirectoryInfo.FullName, "ObjectType.cs");

            File.WriteAllText(dtoPath, dto);

            var expected = File.ReadAllText(Path.Combine(TestContext.CurrentContext.TestDirectory, "Expected/AutoGenDto/ObjectType.cs"));

            Assert.That(dto, Is.EqualTo(expected));
        }

        [Test]
        public void Verify_That_Generate_Class_For_RoleIndex_Returns_Expected_Result()
        {
            var roleText = this.dtoGenerator.TypeDrops.Single(x => x.Name == "RoleText");

            var dto = this.dtoGenerator.GenerateType(roleText);

            var dtoPath = Path.Combine(this.autogenDtoDirectoryInfo.FullName, "RoleText.cs");

            File.WriteAllText(dtoPath, dto);

            var expected = File.ReadAllText(Path.Combine(TestContext.CurrentContext.TestDirectory, "Expected/AutoGenDto/RoleText.cs"));

            Assert.That(dto, Is.EqualTo(expected));
        }

        [Test]
        public void Verify_That_Generate_Class_For_CustomPropertyDefinition_Returns_Expected_Result()
        {
            var customPropertyDefinition = this.dtoGenerator.TypeDrops.Single(x => x.Name == "CustomPropertyDefinition");

            var dto = this.dtoGenerator.GenerateType(customPropertyDefinition);

            var dtoPath = Path.Combine(this.autogenDtoDirectoryInfo.FullName, "CustomPropertyDefinition.cs");

            File.WriteAllText(dtoPath, dto);

            var expected = File.ReadAllText(Path.Combine(TestContext.CurrentContext.TestDirectory, "Expected/AutoGenDto/CustomPropertyDefinition.cs"));

            Assert.That(dto, Is.EqualTo(expected));
        }

        [Test]
        public void Verify_That_Generate_Class_For_Role_Returns_Expected_Result()
        {
            var customPropertyDefinition = this.dtoGenerator.TypeDrops.Single(x => x.Name == "Role");

            var dto = this.dtoGenerator.GenerateType(customPropertyDefinition);

            var dtoPath = Path.Combine(this.autogenDtoDirectoryInfo.FullName, "Role.cs");

            File.WriteAllText(dtoPath, dto);

            var expected = File.ReadAllText(Path.Combine(TestContext.CurrentContext.TestDirectory, "Expected/AutoGenDto/Role.cs"));

            Assert.That(dto, Is.EqualTo(expected));
        }
    }
}
