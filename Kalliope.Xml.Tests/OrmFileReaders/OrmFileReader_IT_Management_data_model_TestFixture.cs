// -------------------------------------------------------------------------------------------------
// <copyright file="OrmFileReader_IT_Management_data_model_TestFixture.cs" company="Starion Group S.A.">
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

namespace Kalliope.Xml.Tests.OrmFileReaders
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    using Kalliope.Core;
    using Kalliope.Common;
    using Kalliope.CustomProperties;
    
    using NUnit.Framework;

    [TestFixture]
    public class OrmFileReader_IT_Management_data_model_TestFixture
    {
        private string ormfilePath;

        private OrmFileReader fileReader;

        private OrmXmlReader ormXmlReader;

        private Kalliope.OrmRoot ormRoot;

        [SetUp]
        public void Setup()
        {
            this.ormfilePath = Path.Combine(TestContext.CurrentContext.TestDirectory, "Data", "IT Management data model.orm");

            this.ormXmlReader = new OrmXmlReader();

            this.fileReader = new OrmFileReader
            {
                OrmXmlReader = this.ormXmlReader
            };

            this.fileReader.Read(this.ormfilePath);
            var cache = this.fileReader.Assembler.Cache;
            Lazy<Kalliope.Core.ModelThing> lazyPoco;
            cache.TryGetValue("root:_8F1F2E20-E575-4533-9832-D033FA7E0A53", out lazyPoco);
            this.ormRoot = (Kalliope.OrmRoot)lazyPoco.Value;
        }
        
        [Test]
        public void Verify_that_the_ORM_File_can_be_read_and_returns_expected_ORMModel()
        {
            Assert.That(this.ormRoot, Is.Not.Null);

            //ORM Model
            Assert.That(this.ormRoot.Model.Id, Is.EqualTo("_8F1F2E20-E575-4533-9832-D033FA7E0A53"));
            Assert.That(this.ormRoot.Model.Name, Is.EqualTo("IT Management"));

            Assert.That(this.ormRoot.Model.Definition.Id, Is.EqualTo("_2F18ED06-13A6-4E8D-A2C3-4089FBE2CB7D"));
            Assert.That(this.ormRoot.Model.Definition.Text, Is.EqualTo("Management is the act, manner, or practice of managing; handling, supervision, or control [dictionary.com]"));

            Assert.That(this.ormRoot.Model.Note.Id, Is.EqualTo("_83DD20D1-3B28-4049-99A1-E17B70CD56EB"));
            Assert.That(this.ormRoot.Model.Note.Text, Is.EqualTo("Objective is to fulfill IT business strategy."));

            // Objects
            Assert.That(this.ormRoot.Model.ObjectTypes.OfType<Core.EntityType>().Count(), Is.EqualTo(39));
            Assert.That(this.ormRoot.Model.ObjectTypes.OfType<Core.ValueType>().Count(), Is.EqualTo(67));
            Assert.That(this.ormRoot.Model.ObjectTypes.OfType<Core.ObjectifiedType>().Count(), Is.EqualTo(34));

            var entityType = this.ormRoot.Model.ObjectTypes.OfType<Core.EntityType>().Single(x => x.Id == "_E8974488-14A3-49FC-9213-403721BE4803");
            Assert.That(entityType.Name, Is.EqualTo("Database"));
            Assert.That(entityType.ReferenceMode, Is.EqualTo(""));
            Assert.That(entityType.PlayedRoles.Count, Is.EqualTo(2));

            var subtypeMetaRole = entityType.PlayedRoles.OfType<SubtypeMetaRole>().Single();
            Assert.That(subtypeMetaRole.IsMandatory, Is.True);
            Assert.That(subtypeMetaRole.Multiplicity, Is.EqualTo(Multiplicity.ZeroToOne));
            Assert.That(subtypeMetaRole.Name, Is.Null.Or.Empty);

            var customProperty = entityType.Extensions.OfType<CustomProperty>().Single();
            Assert.That(customProperty.Id, Is.EqualTo("_46CE9835-1FA9-45AE-91A1-FB18CDC88152"));
            Assert.That(customProperty.Value, Is.EqualTo("instantiated"));
            Assert.That(customProperty.CustomPropertyDefinition.Id, Is.EqualTo("_9CE3DE6D-5AE4-4739-B094-4A14D7E6F1B9"));
            
            var valueType = ormRoot.Model.ObjectTypes.OfType<Core.ValueType>().Single(x => x.Id == "_744D5394-44EC-49E2-8BF1-9EB2C4BD05B2");
            Assert.That(valueType.Name, Is.EqualTo("Application Type"));
            Assert.That(valueType.ConceptualDataType.Id, Is.EqualTo("_DFBA4A89-3C3E-48ED-9317-8A59553A58F2"));
            Assert.That(valueType.ConceptualDataType.Reference, Is.EqualTo("_2B6AA846-1B7B-4F9F-94EE-7FB5CE15B67A"));
            Assert.That(valueType.ConceptualDataType.Scale, Is.EqualTo(0));
            Assert.That(valueType.ConceptualDataType.Length, Is.EqualTo(0));
            
            // CustomReferenceModes
            var customReferenceMode = this.ormRoot.Model.ReferenceModes.Single();
            Assert.That(customReferenceMode.Id, Is.EqualTo("_15B5E099-D6A6-4AA1-B5A7-2E760E295D65"));
            Assert.That(customReferenceMode.Name, Is.EqualTo("Level"));
            Assert.That(customReferenceMode.Kind.Id, Is.EqualTo("_56AB076B-E6F0-4AF3-8C13-5545E5B5B9EC"));

            // ModelNotes
            var modelNote = this.ormRoot.Model.Notes.Single(x => x.Id == "_8CE0C1A9-CACF-4E0F-B758-DC007FA7FAD1");
            Assert.That(modelNote.Text, Is.EqualTo("Expense"));

            // ReferenceModeKinds
            Assert.That(this.ormRoot.Model.ReferenceModeKinds.Count, Is.EqualTo(3));
            var referenceModeKindGeneral = this.ormRoot.Model.ReferenceModeKinds.Single(x => x.Id == "_BBA01037-6A2F-4158-91C0-8F4CDB650D1D");
            Assert.That(referenceModeKindGeneral.FormatString, Is.EqualTo("{1}"));
            Assert.That(referenceModeKindGeneral.ReferenceModeType, Is.EqualTo(ReferenceModeType.General));
            var referenceModeKindPopular = this.ormRoot.Model.ReferenceModeKinds.Single(x => x.Id == "_56AB076B-E6F0-4AF3-8C13-5545E5B5B9EC");
            Assert.That(referenceModeKindPopular.FormatString, Is.EqualTo("{0}_{1}"));
            Assert.That(referenceModeKindPopular.ReferenceModeType, Is.EqualTo(ReferenceModeType.Popular));
        }

        [Test]
        public void Verify_that_the_ORM_File_can_be_read_and_returns_expected_NameGenerator()
        {
            Assert.That(this.ormRoot.NameGenerator, Is.Null);
        }

        [Test]
        public void Verify_that_the_ORM_File_can_be_read_and_returns_expected_GenerationState()
        {
            Assert.That(this.ormRoot.GenerationState, Is.Null);
        }

        [Test]
        public void Verify_that_the_ORM_File_can_be_read_and_returns_expected_CustomPropertyDefinitions()
        {
            Assert.That(this.ormRoot.CustomPropertyGroups.Count, Is.EqualTo(3));
            var customPropertyGroup = this.ormRoot.CustomPropertyGroups.Single(x => x.Id == "_736E04B8-E3EE-4950-A402-3CEE1EBD715A");
            Assert.That(customPropertyGroup.Name, Is.EqualTo("OSMoSEDoc: Diagrams"));
            Assert.That(customPropertyGroup.Description, Is.Null.Or.Empty);
            Assert.That(customPropertyGroup.IsDefault, Is.False);

            var customPropertyDefinition = customPropertyGroup.PropertyDefinitions.Single(x => x.Id == "_867F0515-C4FE-4646-8CEA-BECE4F8ED994");
            Assert.That(customPropertyDefinition.Name, Is.EqualTo("Doc-01: Module Name"));
            Assert.That(customPropertyDefinition.Description, Is.EqualTo("name of the conceptual module"));
            Assert.That(customPropertyDefinition.Category, Is.EqualTo("OSMoSE Diagram"));
            Assert.That(customPropertyDefinition.DataType, Is.EqualTo(CustomPropertyDataType.String));
            Assert.That(customPropertyDefinition.ORMTypes, Is.EqualTo(new List<ORMType>
            {
                ORMType.ORMDiagram,
            }));
        }
    }
}