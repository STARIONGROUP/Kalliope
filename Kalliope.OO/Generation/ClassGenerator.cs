// -------------------------------------------------------------------------------------------------
// <copyright file="ClassGenerator.cs" company="Starion Group S.A.">
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
// -------------------------------------------------------------------------------------------------

namespace Kalliope.OO.Generation
{
    using System.Collections.Generic;
    using System.Linq;

    using Kalliope.Core;
    using Kalliope.OO.StructuralFeature;

    /// <summary>
    /// The purpose of the <see cref="ClassGenerator"/> is to generate instances of <see cref="Class"/> based
    /// on the provided <see cref="OrmModel"/>
    /// </summary>
    public class ClassGenerator
    {
        /// <summary>
        /// The <see cref="GeneratorSettings"/> to be used when creating classes and properties
        /// </summary>
        private readonly GeneratorSettings generatorSettings;

        /// <summary>
        /// Gets the <see cref="OrmModel"/>
        /// </summary>
        public OrmModel OrmModel { get; }

        /// <summary>
        /// Creates a new instance of <see cref="ClassGenerator"/>
        /// </summary>
        /// <param name="ormModel">The <see cref="OrmModel"/></param>
        /// <param name="generatorSettings">The <see cref="GeneratorSettings"/></param>
        public ClassGenerator(OrmModel ormModel, GeneratorSettings generatorSettings)
        {
            this.generatorSettings = generatorSettings;
            this.OrmModel = ormModel;
        }

        /// <summary>
        /// Generates a <see cref="List{Class}"/> based on all <see cref="EntityType"/>s and <see cref="ObjectifiedType"/>in the <see cref="OrmModel"/>
        /// </summary>
        /// <returns>a <see cref="List{Class}"/></returns>
        public List<Class> Generate()
        {
            return this.Generate(
                this.OrmModel.ObjectTypes.OfType<EntityType>()
                    .Cast<ObjectType>()
                    .Union(
                        this.OrmModel.ObjectTypes.OfType<ObjectifiedType>()
                        ));
        }

        /// <summary>
        /// Generates a <see cref="List{Class}"/> based on a <see cref="List{ObjectType}"/>
        /// </summary>
        /// <param name="objectTypes">The <see cref="List{ObjectType}"/></param>
        /// <returns>a <see cref="List{Class}"/></returns>
        public List<Class> Generate(IEnumerable<ObjectType> objectTypes)
        {
            var generatedClasses = new List<Class>();

            var entityTypes = objectTypes.OfType<EntityType>();

            foreach (var entityType in entityTypes)
            {
                var generatedClass = this.GenerateClassFromEntityType(entityType, generatedClasses);
                generatedClasses.Add(generatedClass);
            }

            var objectifiedTypes = objectTypes.OfType<ObjectifiedType>();

            foreach (var objectifiedType in objectifiedTypes)
            {
                if (this.TryGenerateClassFromObjectifiedType(objectifiedType, generatedClasses, out var generatedClass))
                {
                    generatedClasses.Add(generatedClass);
                }
            }

            return generatedClasses;
        }

        /// <summary>
        /// Generates the <see cref="Class"/>
        /// </summary>
        /// <param name="entityType"><see cref="EntityType"/></param>
        /// <param name="classes">The Complete <see cref="List{Class}"/></param>
        /// <returns>A <see cref="Class"/></returns>
        private Class GenerateClassFromEntityType(EntityType entityType, List<Class> classes)
        {
            var entityClass = new EntityClass(this.OrmModel, classes, entityType, this.generatorSettings);

            return entityClass;
        }

        /// <summary>
        /// Generates the <see cref="Class"/>
        /// </summary>
        /// <param name="objectifiedType"><see cref="ObjectifiedType"/></param>
        /// <param name="classes">The Complete <see cref="List{Class}"/></param>
        /// <param name="objectifiedClass">The to be returned <see cref="Class"/></param>
        /// <returns>A boolean indicating successful creation of the <see cref="Class"/></returns>
        private bool TryGenerateClassFromObjectifiedType(ObjectifiedType objectifiedType, List<Class> classes, out ObjectifiedClass objectifiedClass)
        {
            objectifiedClass = new ObjectifiedClass(this.OrmModel, classes, objectifiedType, this.generatorSettings);

            if (objectifiedClass.IsImplied)
            {
                return false;
            }

            return true;
        }
    }
}
