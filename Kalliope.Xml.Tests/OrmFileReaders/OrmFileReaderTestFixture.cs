// -------------------------------------------------------------------------------------------------
// <copyright file="OrmFileReader_ORMLAB1_TestFixture.cs" company="RHEA System S.A.">
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

namespace Kalliope.Xml.Tests.OrmFileReaders
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    
    using Moq;

    using NUnit.Framework;
    
    [TestFixture]
    public class OrmFileReaderTestFixture
    {
        private string ormfilePath;

        private OrmFileReader fileReader;

        private Mock<IOrmXmlReader> ormXmlReader;

        private List<DTO.ModelThing> dtos;
        
        [SetUp]
        public void SetUp()
        {
            this.ormfilePath = Path.Combine(TestContext.CurrentContext.TestDirectory, "Data", "ORM_Lab1.orm");

            this.dtos = new List<DTO.ModelThing>();

            this.ormXmlReader = new Mock<IOrmXmlReader>();
            this.ormXmlReader.Setup(x => x.Read(It.IsAny<string>(), false, null))
                .Returns(dtos);

            this.fileReader = new OrmFileReader();
            this.fileReader.OrmXmlReader = this.ormXmlReader.Object;
        }

        [Test]
        public void Verify_that_RoleText_objects_can_be_assembled()
        {
            var readingDto = new DTO.Reading
            {
                Id = "_76B4CE17-8622-4C32-9F33-A07942FDFB61",
                Data = "{0} has {1}",
            };
            readingDto.ExpandedData.Add("_76B4CE17-8622-4C32-9F33-A07942FDFB61:0");

            var roleTextDto = new DTO.RoleText
            {
                RoleIndex = 0,
                FollowingText = " is of ",
                Container = "_76B4CE17-8622-4C32-9F33-A07942FDFB61"
            };

            dtos.Add(readingDto);
            dtos.Add(roleTextDto);
            
            this.fileReader.Read(this.ormfilePath);

            Assert.That(this.fileReader.Assembler.Cache.Count, Is.EqualTo(2));

            Core.Reading reading = null;
            Lazy<Core.ModelThing> lazyReading;
            if (this.fileReader.Assembler.Cache.TryGetValue(readingDto.Id, out lazyReading))
            {
                reading = (Core.Reading)lazyReading.Value;
            }
            Assert.That(reading, Is.Not.Null);

            Core.RoleText roleText = null;
            Lazy<Core.ModelThing> lazyRoleText;
            if (this.fileReader.Assembler.Cache.TryGetValue(roleTextDto.Id, out lazyRoleText))
            {
                roleText = (Core.RoleText)lazyRoleText.Value;
            }
            Assert.That(roleText, Is.Not.Null);

            CollectionAssert.Contains(reading.ExpandedData, roleText);
            
            Assert.That(reading.Id, Is.EqualTo(readingDto.Id));
            Assert.That(reading.Data, Is.EqualTo(readingDto.Data));
        }

        [Test]
        public void Verify_that_EntityType_SubtypeDerivationRule_can_be_assembled()
        {
            var entityTypeDto = new DTO.EntityType
            {
                Id = "_DF0A619D-B95A-4C7C-85E3-A4B75394AE15",
                Name = "MaleEmployee",
                DerivationRule = "_DF0A619D-B95A-4C7C-85E3-A4B75394AE15:SubtypeDerivationRule"
            };
            entityTypeDto.PlayedRoles.Add("_508D0D53-A0AE-459B-8182-2E65CDE08439");
            entityTypeDto.PlayedRoles.Add("_2C1605C7-DC41-44FB-BC2E-387D0366474B");
            this.dtos.Add(entityTypeDto);

            var subtypeDerivationRuleDto = new DTO.SubtypeDerivationRule
            {
                Container = "_DF0A619D-B95A-4C7C-85E3-A4B75394AE15"
            };
            this.dtos.Add(subtypeDerivationRuleDto);

            this.fileReader.Read(this.ormfilePath);

            Assert.That(this.fileReader.Assembler.Cache.Count, Is.EqualTo(2));

            Core.EntityType entityType = null;
            Lazy<Core.ModelThing> lazyReading;
            if (this.fileReader.Assembler.Cache.TryGetValue(entityTypeDto.Id, out lazyReading))
            {
                entityType = (Core.EntityType)lazyReading.Value;
            }
            Assert.That(entityType, Is.Not.Null);

            Core.SubtypeDerivationRule subtypeDerivationRule = null;
            Lazy<Core.ModelThing> lazyRoleText;
            if (this.fileReader.Assembler.Cache.TryGetValue(subtypeDerivationRuleDto.Id, out lazyRoleText))
            {
                subtypeDerivationRule = (Core.SubtypeDerivationRule)lazyRoleText.Value;
            }
            Assert.That(subtypeDerivationRule, Is.Not.Null);
            
            Assert.That(entityTypeDto.Id, Is.EqualTo(entityType.Id));
            Assert.That(entityType.DerivationRule, Is.EqualTo(subtypeDerivationRule));
        }
    }
}
