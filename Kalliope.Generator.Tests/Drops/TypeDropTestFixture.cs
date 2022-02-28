// -------------------------------------------------------------------------------------------------
// <copyright file="TypeDropTestFixture.cs" company="RHEA System S.A.">
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

namespace Kalliope.Generator.Tests.Drops
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using Kalliope.Common;
    using Kalliope.Generator.Drops;

    using NUnit.Framework;

    [TestFixture]
    public class TypeDropTestFixture
    {
        private List<TypeDrop> typeDrops;

        [SetUp]
        public void SetUp()
        {
            this.typeDrops = new List<TypeDrop>();

            var ormRootType = typeof(OrmRoot);

            var types = ormRootType.Assembly.GetTypes().ToList();

            foreach (var type in types)
            {
                var domainAttribute = (DomainAttribute)Attribute.GetCustomAttribute(type, typeof(DomainAttribute));
                var descriptionAttribute = (Common.DescriptionAttribute)Attribute.GetCustomAttribute(type, typeof(System.ComponentModel.DescriptionAttribute));
                var containerAttributes = (ContainerAttribute[])Attribute.GetCustomAttributes(type, typeof(ContainerAttribute));
                if (domainAttribute != null)
                {
                    var typeDrop = new TypeDrop(type, domainAttribute, descriptionAttribute, containerAttributes);
                    this.typeDrops.Add(typeDrop);
                }
            }
        }

        [Test]
        public void Verify_That_TypeDrop_behaves_as_expected()
        {
            var objectTypeDrop = this.typeDrops.Single(x => x.Name == "ObjectType");

            Assert.That(objectTypeDrop.IsAbstract, Is.True);
            Assert.That(objectTypeDrop.Description, Is.Null);
            Assert.That(objectTypeDrop.Generalization, Is.EqualTo(" : ORMNamedElement"));
            Assert.That(objectTypeDrop.IsContained, Is.True);
        }
    }
}
