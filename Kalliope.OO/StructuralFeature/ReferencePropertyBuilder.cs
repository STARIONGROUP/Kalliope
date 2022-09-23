// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ReferencePropertyBuilder.cs" company="RHEA System S.A.">
//  © Copyright European Space Agency, 2017-2022
//  <author>
//   Software developed by RHEA System S.A.
//  </author>
//  This file is subject to the terms and conditions defined in file 'LICENSE.txt', which is part of this source code package.
//  No part of the package, including this file, may be copied, modified, propagated, or distributed
//  except according to the terms contained in the file 'LICENSE.txt'.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Kalliope.OO.StructuralFeature
{
    using System;
    using System.Collections.Generic;

    using Kalliope.Core;

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
        /// <param name="objectType">The <see cref="ObjectType"/></param>
        /// <param name="propertyRole">The <see cref="Role"/></param>
        /// <param name="classRole">The <see cref="Class"/> <see cref="Role"/></param>
        /// <returns>a <see cref="ReferenceProperty{T}"/> of type <typeparamref name="T"/></returns>
        /// <exception cref="NotSupportedException">If <typeparamref name="T"/> is not <see cref="EntityType"/> or <see cref="ObjectifiedType"/></exception>
        public static ReferenceProperty<T> CreateReferenceProperty<T>(OrmModel ormModel, T objectType, Role propertyRole, Role classRole) where T : ObjectType
        {
            if (!new List<Type> { typeof(EntityType), typeof(ObjectifiedType) }.Contains(typeof(T)))
            {
                throw new NotSupportedException($"The Type {typeof(T).Name} is not supported to build a ReferenceProperty for.");
            }

            return new ReferenceProperty<T>(ormModel, objectType, propertyRole, classRole);
        }
    }
}
