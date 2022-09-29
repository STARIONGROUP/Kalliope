// -------------------------------------------------------------------------------------------------
// <copyright file="ClassGenerator.cs" company="RHEA System S.A.">
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
        /// The <see cref="GenerationSettings"/> to be used when creating classes and properties
        /// </summary>
        private readonly GenerationSettings generationSettings;

        /// <summary>
        /// Gets the <see cref="OrmModel"/>
        /// </summary>
        public OrmModel OrmModel { get; }

        /// <summary>
        /// Creates a new instance of <see cref="ClassGenerator"/>
        /// </summary>
        /// <param name="ormModel">The <see cref="OrmModel"/></param>
        /// <param name="generationSettings">The <see cref="GenerationSettings"/></param>
        public ClassGenerator(OrmModel ormModel, GenerationSettings generationSettings)
        {
            this.generationSettings = generationSettings;
            this.OrmModel = ormModel;
        }

        /// <summary>
        /// Generates a <see cref="List{T}"/> of <see cref="Class"/> based on all <see cref="EntityType"/>s and <see cref="ObjectifiedType"/>in the <see cref="OrmModel"/>
        /// </summary>
        /// <returns>a <see cref="List{T}"/> of <see cref="Class"/></returns>
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
        /// Generates a <see cref="List{T}"/> of <see cref="Class"/> based on a <see cref="List{T}"/> of <see cref="Class"/>s
        /// </summary>
        /// <param name="objectTypes">The <see cref="List{T}"/> of <see cref="ObjectType"/></param>
        /// <returns>a <see cref="List{T}"/> of <see cref="Class"/></returns>
        public List<Class> Generate(IEnumerable<ObjectType> objectTypes)
        {
            var generatedClasses = new List<Class>();

            var entityTypes = objectTypes.OfType<EntityType>();

            foreach (var entityType in entityTypes)
            {
                var generatedClass = this.GenerateClassFromEntityType(entityType);
                generatedClasses.Add(generatedClass);
            }

            var objectifiedTypes = objectTypes.OfType<ObjectifiedType>();

            foreach (var objectifiedType in objectifiedTypes)
            {
                if (this.TryGenerateClassFromObjectifiedType(objectifiedType, out var generatedClass))
                {
                    generatedClasses.Add(generatedClass);
                }
            }

            //Assemble Sub- and SuperTypes
            foreach (var generatedClass in generatedClasses)
            {
                foreach (var superObjectType in generatedClass.SuperObjectTypes)
                {
                    var superClassType = generatedClasses.FirstOrDefault(x => x.ObjectType == superObjectType);

                    if (superClassType != null)
                    {
                        generatedClass.SuperClasses.Add(superClassType);
                    }
                }

                foreach (var subObjectType in generatedClass.SubObjectTypes)
                {
                    var subClassType = generatedClasses.FirstOrDefault(x => x.ObjectType == subObjectType);

                    if (subClassType != null)
                    {
                        generatedClass.SubClasses.Add(subClassType);
                    }
                }
            }

            return generatedClasses;
        }

        /// <summary>
        /// Generates the <see cref="Class"/>
        /// </summary>
        /// <param name="entityType"><see cref="EntityType"/></param>
        /// <returns>A <see cref="Class"/></returns>
        private Class GenerateClassFromEntityType(EntityType entityType)
        {
            var entityClass = new EntityClass(this.OrmModel, entityType, this.generationSettings);

            return entityClass;
        }

        /// <summary>
        /// Generates the <see cref="Class"/>
        /// </summary>
        /// <param name="objectifiedType"><see cref="ObjectifiedType"/></param>
        /// <param name="objectifiedClass">The to be returned <see cref="Class"/></param>
        /// <returns>A boolean indicating succesfull creation of the <see cref="Class"/></returns>
        private bool TryGenerateClassFromObjectifiedType(ObjectifiedType objectifiedType, out Class objectifiedClass)
        {
            objectifiedClass = new ObjectifiedClass(this.OrmModel, objectifiedType, this.generationSettings);

            return true;
        }
    }
}
