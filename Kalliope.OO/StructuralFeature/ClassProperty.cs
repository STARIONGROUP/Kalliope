// -------------------------------------------------------------------------------------------------
// <copyright file="ClassProperty.cs" company="RHEA System S.A.">
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
    using Kalliope.Common;
    using Kalliope.Core;
    using Kalliope.OO.Extensions;

    /// <summary>
    /// Class that describes a ValueType property
    /// </summary>
    public class ClassProperty: ReferenceProperty<EntityType>
    {
        /// <summary>
        /// Creates a new instance of the <see cref="ReferenceProperty{T}"/> class
        /// </summary>
        /// <param name="ormModel">The <see cref="OrmModel"/></param>
        /// <param name="entityType">The <see cref="EntityType"/></param>
        /// <param name="factRole">The <see cref="Role"/></param>
        public ClassProperty(OrmModel ormModel, EntityType entityType, Role factRole) : base(ormModel, entityType, factRole)
        {
        }

        /// <summary>
        /// Get the Name of the <see cref="EntityType"/>
        /// </summary>
        /// <returns>The <see cref="EntityType"/>'s Name</returns>
        protected override string GetName()
        {
            var name = string.Empty;

            if (this.FactType.Roles.Count > 2)
            {
                name = string.IsNullOrWhiteSpace(this.FactRole.Name) ? this.ObjectType.Name : this.FactRole.Name;
            }
            else
            {
                name = string.IsNullOrWhiteSpace(this.FactRole.Name) ? string.IsNullOrWhiteSpace(this.FactType.Name) ? this.ObjectType.Name : this.FactType.Name : this.FactRole.Name;
            }

            name = name.ToUsableName();

            if (this.FactRole?.Multiplicity is Multiplicity.OneToMany or Multiplicity.ZeroToMany)
            {
                name += "s";
            }

            return name;
        }
    }
}
