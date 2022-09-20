// -------------------------------------------------------------------------------------------------
// <copyright file="ReferenceProperty.cs" company="RHEA System S.A.">
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
    using Kalliope.Core;
    using System.Linq;

    /// <summary>
    /// Class that describes a ValueType property
    /// </summary>
    public abstract class ReferenceProperty<T> : Property<T> where T : ObjectType
    {
        /// <summary>
        /// Gets or sets the <see cref="Class"/> property
        /// </summary>
        public Class Class { get; set; }

        /// <summary>
        /// Creates a new instance of the <see cref="ReferenceProperty{T}"/> class
        /// </summary>
        /// <param name="ormModel">The <see cref="OrmModel"/></param>
        /// <param name="objectType">The <see cref="ObjectType"/></param>
        /// <param name="factRole">The <see cref="Role"/></param>
        protected ReferenceProperty(OrmModel ormModel, T objectType, Role factRole) : base(ormModel, objectType, factRole)
        {
        }

        /// <summary>
        /// Get the Datatype of the <see cref="ObjectType"/>
        /// </summary>
        /// <returns>The <see cref="ObjectType"/>'s datatype</returns>
        protected override string GetDataType()
        {
            var name = this.ObjectType.Name;

            var factRoles = this.FactType.Roles
                .OfType<Role>()
                .Union(
                    this.FactType.Roles
                        .OfType<RoleProxy>()
                        .Select(x => x.TargetRole));

            if (factRoles.Count(x => x.RolePlayer.Equals(this.ObjectType)) >= 2)
            {
                if (string.IsNullOrWhiteSpace(this.FactRole.Name))
                {
                    //Self reference having an unset specific propertyname
                    name = $"{name}{this.FactType.Roles.IndexOf(this.FactRole)+1}";
                }
            }

            return name;
        }
    }
}
