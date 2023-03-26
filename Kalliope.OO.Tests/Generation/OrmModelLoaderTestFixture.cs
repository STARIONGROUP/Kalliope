// -------------------------------------------------------------------------------------------------
// <copyright file="OrmModelLoaderTestFixture.cs" company="RHEA System S.A.">
//
//   Copyright 2022-2023 RHEA System S.A.
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
    using System;
    using System.IO;
    using System.Reflection;

    using Kalliope.OO.Generation;

    using NUnit.Framework;

    public class OrmModelLoaderTestFixture
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase("Bird Identification.orm", false)]
        [TestCase("IT Management data model.orm", false)]
        [TestCase("ORM_Lab1.orm", false)]
        [TestCase("ORM_Lab2.orm", false)]
        [TestCase("ORM_Lab3.orm", false)]
        [TestCase("ORM_Lab4.orm", false)]
        [TestCase("ORM_Lab7.orm", false)]
        [TestCase("ORM_Lab8.orm", false)]
        [TestCase("ReservationModel5.orm", false)]
        [TestCase("Talent.orm", false)]
        public void VerifyThatTestModelsCanBeLoaded(string modelName, bool throws)
        {
            var assemblyFolder = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            var ormFileName = Path.Combine(assemblyFolder, "Data", modelName);

            OrmRoot ormRoot = null;

            Assert.That(() => ormRoot = OrmModelLoader.Load(ormFileName), throws ? Throws.InstanceOf<NotSupportedException>() : Throws.Nothing);

            if (!throws)
            {
                Assert.That(ormRoot, Is.Not.Null);
            }
        }
    }
}
