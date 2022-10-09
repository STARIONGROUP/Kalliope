// -------------------------------------------------------------------------------------------------
// <copyright file="ReferencePropertyBuilder.cs" company="RHEA System S.A.">
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

namespace Kalliope.OO.StructuralFeature
{
    using System;
    using System.Collections.Generic;

    using Kalliope.Core;
    using Kalliope.OO.Generation;

    /// <summary>
    /// Builder class that can build a <see cref="ReferenceProperty{T}"/> of a specific <see cref="ObjectType"/>
    /// </summary>
    public static class ReferencePropertyBuilder
    {
        /// <summary>
        /// Builds a <see cref="ReferenceProperty{T}"/> of a specific <see cref="ObjectType"/>
        /// </summary>
        /// <typeparam name="T">The <see cref="ObjectType"/> which can be <see cref="EntityType"/> or <see cref="ObjectifiedType"/></typeparam>
        /// <param name="ormModel">The <see cref="OrmModel"/></param>
        /// <param name="class">The <see cref="Class"/> that this property belongs to</param>
        /// <param name="objectType">The <see cref="ObjectType"/></param>
        /// <param name="propertyRole">The <see cref="Role"/></param>
        /// <param name="classRole">The <see cref="Class"/> <see cref="Role"/></param>
        /// <param name="generatorSettings">The <see cref="GeneratorSettings"/></param>
        /// <returns>a <see cref="ReferenceProperty{T}"/> of type <typeparamref name="T"/></returns>
        /// <exception cref="NotSupportedException">If <typeparamref name="T"/> is not <see cref="EntityType"/> or <see cref="ObjectifiedType"/></exception>
        public static ReferenceProperty<T> CreateReferenceProperty<T>(OrmModel ormModel, Class @class, T objectType, Role propertyRole, Role classRole, GeneratorSettings generatorSettings) where T : ObjectType
        {
            if (!new List<Type> { typeof(EntityType), typeof(ObjectifiedType) }.Contains(typeof(T)))
            {
                throw new NotSupportedException($"The Type {typeof(T).Name} is not supported to build a ReferenceProperty for.");
            }

            return new ReferenceProperty<T>(ormModel, @class, objectType, propertyRole, classRole, generatorSettings);
        }
    }
}
