// -------------------------------------------------------------------------------------------------
// <copyright file="EntityClass.cs" company="Starion Group S.A.">
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

namespace Kalliope.OO.StructuralFeature
{
    using System.Collections.Generic;

    using Kalliope.Core;
    using Kalliope.OO.Generation;

    /// <summary>
    /// An <see cref="EntityClass"/> is a <see cref="Class"/> that represents an Entity with properties
    /// </summary>
    public class EntityClass : Class
    {
        /// <summary>
        /// Creates a new instance of the <see cref="EntityClass"/> class
        /// </summary>
        /// <param name="ormModel">The <see cref="OrmModel"/></param>
        /// <param name="classes">The Complete <see cref="List{Class}"/></param>
        /// <param name="objectType">The <see cref="EntityType"/></param>
        /// <param name="generatorSettings">The <see cref="GeneratorSettings"/></param>
        public EntityClass(OrmModel ormModel, List<Class> classes, ObjectType objectType, GeneratorSettings generatorSettings) : base(ormModel, classes, objectType, generatorSettings)
        {
        }

        /// <summary>
        /// Initializes this class
        /// </summary>
        protected override void Initialize()
        {
            if (!this.IsObjectified)
            {
                this.TryAddProperties();
            }
        }
    }
}
