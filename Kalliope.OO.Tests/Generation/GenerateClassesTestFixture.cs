// -------------------------------------------------------------------------------------------------
// <copyright file="GenerateClassesTestFixture.cs" company="RHEA System S.A.">
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

namespace Kalliope.OO.Tests
{
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Reflection;

    using Kalliope.Core;
    using Kalliope.OO.Generation;
    using Kalliope.OO.StructuralFeature;

    using NUnit.Framework;

    public class GenerateClassesTestFixture
    {
        private OrmRoot ormRoot;
        private ClassGenerator classGenerator;

        [SetUp]
        public void Setup()
        {
            var assemblyFolder = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            var ormFileName = Path.Combine(assemblyFolder, "Data", "Talent.orm");

            this.ormRoot = OrmModelLoader.Load(ormFileName);

            this.classGenerator = new ClassGenerator(this.ormRoot.Model);
        }

        [Test]
        public void VerifyThatAllEntityClassesAreCreated()
        {
            var classes = this.classGenerator.Generate(this.ormRoot.Model.ObjectTypes.OfType<EntityType>());

            foreach (var ooClass in classes)
            {
                foreach (var property in ooClass.Properties)
                {
                    Assert.That(property.Name, Is.Not.Empty);
                    Assert.That(property.DataType, Is.Not.EqualTo("Unknown type"));
                }
            }

            Assert.That(classes.Count, Is.EqualTo(52));
            Assert.That(classes.SelectMany(x => x.Properties).OfType<ValueTypeProperty>().Count(), Is.EqualTo(131));
            Assert.That(classes.SelectMany(x => x.Properties).OfType<ReferenceProperty<ObjectifiedType>>().Count(), Is.EqualTo(39));
            Assert.That(classes.SelectMany(x => x.Properties).OfType<ReferenceProperty<EntityType>>().Count(), Is.EqualTo(118));
            Assert.That(classes.SelectMany(x => x.SuperObjectTypes).Count(), Is.EqualTo(5));
            Assert.That(classes.SelectMany(x => x.SubObjectTypes).Count(), Is.EqualTo(5));
            Assert.That(classes.SelectMany(x => x.SuperClasses).Count(), Is.EqualTo(5));
            Assert.That(classes.SelectMany(x => x.SubClasses).Count(), Is.EqualTo(5));
        }

        [Test]
        public void VerifyThatEntityTypeClassIsCreated()
        {
            var classes = this.classGenerator.Generate(
                new List<ObjectType>
                {
                    this.ormRoot.Model.ObjectTypes.OfType<EntityType>().First(x => x.Name == "Talent")
                });

            foreach (var ooClass in classes)
            {
                foreach (var property in ooClass.Properties)
                {
                    Assert.That(property.Name, Is.Not.Empty);
                    Assert.That(property.DataType, Is.Not.EqualTo("Unknown type"));
                }
            }

            Assert.That(classes.Count, Is.EqualTo(1));
            Assert.That(classes.SelectMany(x => x.Properties).OfType<ValueTypeProperty>().Count(), Is.EqualTo(8));
            Assert.That(classes.SelectMany(x => x.Properties).OfType<ReferenceProperty<ObjectifiedType>>().Count(), Is.EqualTo(8));
            Assert.That(classes.SelectMany(x => x.Properties).OfType<ReferenceProperty<EntityType>>().Count(), Is.EqualTo(17));
            Assert.That(classes.SelectMany(x => x.SuperObjectTypes).Count(), Is.EqualTo(1));
            Assert.That(classes.SelectMany(x => x.SubObjectTypes).Count(), Is.EqualTo(0));
            Assert.That(classes.SelectMany(x => x.SuperClasses).Count(), Is.EqualTo(0));
            Assert.That(classes.SelectMany(x => x.SubClasses).Count(), Is.EqualTo(0));
        }

        [Test]
        public void VerifyThatObjectifiedTypeClassIsCreated()
        {
            var classes = this.classGenerator.Generate(
                new List<ObjectType>
                {
                    this.ormRoot.Model.ObjectTypes.OfType<ObjectifiedType>().First(x => x.Name == "TalentAuditionInvitation")
                });

            foreach (var ooClass in classes)
            {
                foreach (var property in ooClass.Properties)
                {
                    Assert.That(property.Name, Is.Not.Empty);
                    Assert.That(property.DataType, Is.Not.EqualTo("Unknown type"));
                }
            }

            Assert.That(classes.Count, Is.EqualTo(1));
            Assert.That(classes.SelectMany(x => x.Properties).OfType<ValueTypeProperty>().Count(), Is.EqualTo(2));
            Assert.That(classes.SelectMany(x => x.Properties).OfType<ReferenceProperty<ObjectifiedType>>().Count(), Is.EqualTo(0));
            Assert.That(classes.SelectMany(x => x.Properties).OfType<ReferenceProperty<EntityType>>().Count(), Is.EqualTo(2));
            Assert.That(classes.SelectMany(x => x.SuperObjectTypes).Count(), Is.EqualTo(0));
            Assert.That(classes.SelectMany(x => x.SubObjectTypes).Count(), Is.EqualTo(0));
        }

        [Test]
        public void VerifyThatJsonValueTypeDoesNotCreateClass()
        {
            var classes = this.classGenerator.Generate(
                new List<ObjectType>
                {
                    this.ormRoot.Model.ObjectTypes.OfType<ValueType>().First(x => x.Name == "JSON")
                });

            Assert.That(classes.Count, Is.EqualTo(0));
        }
    }
}
