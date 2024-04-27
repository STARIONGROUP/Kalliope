// -------------------------------------------------------------------------------------------------
// <copyright file="DropGeneratorTestFixture.cs" company="Starion Group S.A.">
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

namespace Kalliope.Generator.Tests
{
    using System.Collections.Generic;
    using System.Linq;

    using NUnit.Framework;

    /// <summary>
    /// Suite of tests for the <see cref="DropGenerator"/>
    /// </summary>
    [TestFixture]
    public class DropGeneratorTestFixture
    {
        private List<TypeDrop> typeDrops;

        [SetUp]
        public void SetUp()
        {
            var generator = new DropGenerator();
            this.typeDrops = generator.Generate().ToList();
        }

        [Test]
        public void Verify_that_the_generator_generates_the_expected_amount_of_type_drops()
        {
            Assert.That(this.typeDrops.Count, Is.EqualTo(274));
        }

        [Test]
        public void Verify_That_TypeDrop_behaves_as_expected()
        {
            var objectTypeDrop = this.typeDrops.Single(x => x.Name == "ObjectType");

            Assert.That(objectTypeDrop.IsAbstract, Is.True);
            Assert.That(objectTypeDrop.Description, Is.Empty.Or.Null);
            Assert.That(objectTypeDrop.Generalization, Is.EqualTo(" : OrmNamedElement"));
            Assert.That(objectTypeDrop.IsContained, Is.True);
        }

        [Test]
        public void Verify_that_container_attributes_are_only_present_on_the_type_where_they_are_defined()
        {
            var objectTypeDrop = this.typeDrops.Single(x => x.Name == "ObjectType");
            Assert.That(objectTypeDrop.IsContained, Is.True);

            var valueTypeDrop = this.typeDrops.Single(x => x.Name == "EntityType");
            Assert.That(valueTypeDrop.IsContained, Is.False);
        }

        [Test]
        public void Verify_that_TypeDrop_properties_return_expected_Resulst()
        {
            var roleTextDrop = this.typeDrops.Single(x => x.Name == "RoleText");
            Assert.That(roleTextDrop.IsContained, Is.True);
            Assert.That(roleTextDrop.AllReferencePropertiesCount, Is.EqualTo(0));

            var objectTypeDrop = this.typeDrops.Single(x => x.Name == "ObjectType");
            Assert.That(objectTypeDrop.IsContained, Is.True);
            Assert.That(objectTypeDrop.AllReferencePropertiesCount, Is.EqualTo(24));
        }
    }
}
