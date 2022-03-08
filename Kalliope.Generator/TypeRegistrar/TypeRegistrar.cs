// -------------------------------------------------------------------------------------------------
// <copyright file="TypeRegistrar.cs" company="RHEA System S.A.">
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

namespace Kalliope.Generator.TypeRegistrar
{
    using System;
    using System.Linq;
    using System.Reflection;

    using DotLiquid;

    using Kalliope.Common;

    /// <summary>
    /// The purpose of the <see cref="TypeRegistrar"/> class is to register
    /// all Kalliope type with DotLiquid
    /// </summary>
    public class TypeRegistrar
    {
        /// <summary>
        /// Registers all Kalliope.Common types with DotLiquid
        /// </summary>
        public void RegisterKalliopeCommonTypes()
        {
            var domainAttribute = typeof(DomainAttribute);
            var types = domainAttribute.Assembly.GetTypes().ToList();

            foreach (var type in types)
            {
                this.RegisterKalliopeTypeWithTemplate(type);
            }
        }

        /// <summary>
        /// Registers all Kalliope types with DotLiquid
        /// </summary>
        public void RegisterKalliopeTypes()
        {
            var ormRoottype = typeof(OrmRoot);
            var types = ormRoottype.Assembly.GetTypes().ToList();

            foreach (var type in types)
            {
                this.RegisterKalliopeTypeWithTemplate(type);
            }
        }

        /// <summary>
        /// Registers a Kalliope types with DotLiquid
        /// </summary>
        /// <param name="type">
        /// The subject <see cref="Type"/> that is to be registered
        /// </param>
        private void RegisterKalliopeTypeWithTemplate(Type type)
        {
            var propertyNames = type.GetProperties(BindingFlags.Public | BindingFlags.Instance).Select(memberInfo => memberInfo.Name);
            var methods = type.GetMethods(BindingFlags.Public | BindingFlags.Instance)
                .Where(x => !x.IsSpecialName)
                .Select(memberInfo => memberInfo.Name);

            var members = propertyNames.Union(methods).ToArray();

            Template.RegisterSafeType(type, members);
        }
    }
}
