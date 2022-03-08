// -------------------------------------------------------------------------------------------------
// <copyright file="DropGenerator.cs" company="RHEA System S.A.">
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

namespace Kalliope.Generator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    
    using Kalliope.Common;

    /// <summary>
    /// The purpose of the <see cref="DropGenerator"/> is to create and assemble the <see cref="TypeDrop"/> and <see cref="PropertyDrop"/>
    /// instances from the Kalliope POCO classes.
    /// </summary>
    public class DropGenerator
    {
        /// <summary>
        /// Generates the <see cref="PropertyDrop"/> instances based on the Kalliope POCO classes.
        /// </summary>
        /// <returns>
        /// An <see cref="IEnumerable{TypeDrop}"/>
        /// </returns>
        public IEnumerable<TypeDrop> Generate()
        {
            var result = new List<TypeDrop>();

            var ormRootType = typeof(OrmRoot);

            var types = ormRootType.Assembly.GetTypes().ToList();

            foreach (var type in types)
            {
                var domainAttribute = (DomainAttribute)Attribute.GetCustomAttribute(type, typeof(DomainAttribute), false);
                var descriptionAttribute = (DescriptionAttribute)Attribute.GetCustomAttribute(type, typeof(DescriptionAttribute), false);
                var containerAttributes = (ContainerAttribute[])Attribute.GetCustomAttributes(type, typeof(ContainerAttribute), false);
                containerAttributes = containerAttributes.OrderBy(x => x.TypeName).ToArray();
                if (domainAttribute != null)
                {
                    var typeDrop = new TypeDrop(type, domainAttribute, descriptionAttribute, containerAttributes);
                    result.Add(typeDrop);
                }
            }
            
            return result;
        }
    }
}
