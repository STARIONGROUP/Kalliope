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

    using Kalliope.Common;
    using Kalliope.OO.Extensions;

    /// <summary>
    /// Class that describes a Reference property
    /// </summary>
    public class ReferenceProperty<T> : Property<T>, IReferenceProperty where T : ObjectType
    {
        /// <summary>
        /// The number of roles that are involved in the FactType
        /// </summary>
        public int NumberOfRoles => this.FactType.Roles.Count;

        /// <summary>
        /// Creates a new instance of the <see cref="ReferenceProperty{T}"/> class
        /// </summary>
        /// <param name="ormModel">The <see cref="OrmModel"/></param>
        /// <param name="objectType">The <see cref="ObjectType"/></param>
        /// <param name="propertyRole">The <see cref="Role"/></param>
        /// <param name="classRole">The <see cref="Class"/> <see cref="Role"/></param>
        public ReferenceProperty(OrmModel ormModel, T objectType, Role propertyRole, Role classRole) : base(ormModel, objectType, propertyRole, classRole)
        {
        }

        /// <summary>
        /// Get the Datatype of the <see cref="ObjectType"/>
        /// </summary>
        /// <returns>The <see cref="ObjectType"/>'s datatype</returns>
        protected override string GetDataType()
        {
            var dataType = this.ObjectType.Name.ToUsableName();
            dataType = this.UpdateDataTypeStringWithMultiplicity(dataType);

            return dataType;
        }

        /// <summary>
        /// Get the Name of the <see cref="ObjectType"/>
        /// </summary>
        /// <returns>The <see cref="ObjectType"/>'s Name</returns>
        protected override string GetName()
        {
            var name = string.Empty;

            if (!string.IsNullOrWhiteSpace(this.PropertyRole?.Name))
            {
                name = this.PropertyRole.Name;
            }
            else if (this.ClassRole.RolePlayer is ObjectifiedType)
            {
                name = this.ObjectType.Name;
            }
            else
            {
                var readingOrder =
                    this.FactType.ReadingOrders.FirstOrDefault(x =>
                        x.Roles.First() is Role role && role == this.ClassRole
                        ||
                        x.Roles.First() is RoleProxy roleProxy && roleProxy.TargetRole == this.ClassRole);

                if (readingOrder != null)
                {
                    var text = readingOrder.Readings.First().Data.Replace("{", " {").Replace("}", "} ");

                    for (var i=0; i < readingOrder.Roles.Count; i++)
                    {
                        var role = readingOrder.Roles[i] is RoleProxy roleProxy ? roleProxy.TargetRole : readingOrder.Roles[i] as Role;

                        // Extra whitespaces arount names are nesessary for the TitleCasing to be performed correctly
                        text = text.Replace("{" + i + "}", $" {(string.IsNullOrWhiteSpace(role.Name) ? role.RolePlayer.Name : role.Name)} ");
                    }

                    name = string.IsNullOrWhiteSpace(text) ? this.ObjectType.Name : text;
                }
                else
                {
                    name = string.IsNullOrWhiteSpace(this.FactType?.Name) ? this.ObjectType.Name : this.FactType?.Name;
                }
            }

            name = name.ToUsableName();

            if (this.PropertyRole?.Multiplicity is Multiplicity.OneToMany or Multiplicity.ZeroToMany)
            {
                name += "s";
            }

            return name;
        }
    }
}
