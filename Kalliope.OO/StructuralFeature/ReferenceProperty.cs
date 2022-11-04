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
    using System.Linq;

    using Kalliope.Common;
    using Kalliope.Core;
    using Kalliope.OO.Extensions;
    using Kalliope.OO.Generation;

    /// <summary>
    /// Class that describes a Reference property
    /// </summary>
    public class ReferenceProperty<T> : Property<T>, IReferenceProperty where T : ObjectType
    {
        /// <summary>
        /// Gets a value indicating if this <see cref="IReferenceProperty"/> represents the main relationship role.
        /// </summary>
        public bool IsMainRelationshipRole => this.CalculateMainRelationshipRole();

        /// <summary>
        /// Retrieves a value indicating if this <see cref="IReferenceProperty"/> represents the main relationship role.
        /// </summary>
        /// <returns>True if this <see cref="IReferenceProperty"/> represents the main relationship role, otherwise false</returns>
        private bool CalculateMainRelationshipRole()
        {
            // Is this class the role owner?
            if (this.CalculateIsRoleOwner(this.ClassRole))
            {
                return true;
            }

            // Is the other property the RoleOwner
            if (this.CalculateIsRoleOwner(this.PropertyRole))
            {
                return false;
            }

            //otherwise fallback to First Role in FactType.Roles
            return
                this.FactType.Roles.OfType<Role>().FirstOrDefault() == this.ClassRole
                ||
                this.FactType.Roles.OfType<RoleProxy>().FirstOrDefault()?.TargetRole == this.ClassRole;
        }

        /// <summary>
        /// Gets a value indicating that this property is an implied property
        /// </summary>
        public bool IsImpliedProperty { get; set; }

        /// <summary>
        /// Gets the reference entity name for a property based on an Implied type
        /// </summary>
        public string ImpliedReferenceEntityName => this.IsImpliedProperty ? this.FactType.Name : "";

        /// <summary>
        /// Creates a new instance of the <see cref="ReferenceProperty{T}"/> class
        /// </summary>
        /// <param name="ormModel">The <see cref="OrmModel"/></param>
        /// <param name="class">The <see cref="Class"/> that this property belongs to</param>
        /// <param name="objectType">The <see cref="ObjectType"/></param>
        /// <param name="propertyRole">The <see cref="Role"/></param>
        /// <param name="classRole">The <see cref="Class"/> <see cref="Role"/></param>
        /// <param name="generatorSettings">The <see cref="GeneratorSettings"/></param>
        public ReferenceProperty(OrmModel ormModel, Class @class, T objectType, Role propertyRole, Role classRole, GeneratorSettings generatorSettings) : base(ormModel, @class, objectType, propertyRole, classRole, generatorSettings)
        {
        }

        /// <summary>
        /// Calculates the Multiplicity for this property 
        /// </summary>
        /// <returns>The Calculated <see cref="Multiplicity"/></returns>
        protected override Multiplicity CalculateMultiplicity()
        {
            if (this.ClassRole.RolePlayer is ObjectifiedType)
            {
                if (this.PropertyRole.Multiplicity is Multiplicity.OneToMany)
                {
                    return Multiplicity.ExactlyOne;
                }

                if (this.PropertyRole.Multiplicity is Multiplicity.ZeroToMany)
                {
                    return Multiplicity.ZeroToOne;
                }
            }

            return this.PropertyRole.Multiplicity;
        }

        /// <summary>
        /// Calculates if this property is an Enumerable type
        /// </summary>
        /// <returns>True if this property is an Enumerable type</returns>
        protected override bool CalculateIsEnumerable()
        {
            return this.Multiplicity is Multiplicity.OneToMany or Multiplicity.ZeroToMany;
        }

        /// <summary>
        /// Get the Datatype of the <see cref="ObjectType"/>
        /// </summary>
        /// <returns>The <see cref="ObjectType"/>'s datatype</returns>
        protected override string GetDataType()
        {
            return this.ObjectType.Name.ToUsableName(this.GeneratorSettings.ReservedWords);
        }

        /// <summary>
        /// Get the Name of the <see cref="ObjectType"/>
        /// </summary>
        /// <returns>The <see cref="ObjectType"/>'s Name</returns>
        protected override string GetName()
        {
            var name = string.Empty;
            var factType = this.FactType;

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
                    factType.ReadingOrders.FirstOrDefault(x =>
                        (x.Roles.First() is Role role && role == this.ClassRole)
                        ||
                        (x.Roles.First() is RoleProxy roleProxy && roleProxy.TargetRole == this.ClassRole));

                if (readingOrder != null)
                {
                    var text = readingOrder.Readings.First().Data.Replace("{", " {").Replace("}", "} ");

                    var entityReplaceStartingIndex = 1;

                    if (this.GeneratorSettings.AddEntityPrefixesForNonExplicitlyNamedRoles)
                    {
                        entityReplaceStartingIndex = 0;
                    }

                    for (var i = entityReplaceStartingIndex; i < readingOrder.Roles.Count; i++)
                    {
                        var role = readingOrder.Roles[i] is RoleProxy roleProxy ? roleProxy.TargetRole : readingOrder.Roles[i] as Role;

                        // Extra whitespaces around names are necessary for the TitleCasing to be performed correctly
                        text = text.Replace("{" + i + "}", $" {(string.IsNullOrWhiteSpace(role.Name) ? role.RolePlayer.Name : role.Name)} ");
                    }

                    name = string.IsNullOrWhiteSpace(text) ? this.ObjectType.Name : text;
                }
                else
                {
                    name = string.IsNullOrWhiteSpace(this.FactType?.Name) ? this.ObjectType.Name : this.FactType?.Name;
                }
            }

            name = name.ToUsableName(this.GeneratorSettings.ReservedWords);

            return name;
        }
    }
}
