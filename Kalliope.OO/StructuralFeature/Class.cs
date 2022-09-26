// -------------------------------------------------------------------------------------------------
// <copyright file="Class.cs" company="RHEA System S.A.">
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
    using System.Collections.Generic;
    using System.Linq;

    using Kalliope.Core;
    using Kalliope.OO.Extensions;

    /// <summary>
    /// Base class from which all Class types derive
    /// </summary>
    public abstract class Class : StructuralFeature
    {
        /// <summary>
        /// Gets the <see cref="OrmModel"/>
        /// </summary>
        protected OrmModel OrmModel { get; }

        /// <summary>
        /// Gets the <see cref="ObjectType"/>
        /// </summary>
        public ObjectType ObjectType { get; }

        /// <summary>
        /// Gets a value that indicates that this is an Objectified class
        /// </summary>
        public bool IsObjectified => this.ObjectType is ObjectifiedType;

        /// <summary>
        /// A <see cref="List{T}"/> of type <see cref="IProperty"/> that contains all the properties of this <see cref="Class"/>
        /// </summary>
        public List<IProperty> Properties { get; set; } = new();

        /// <summary>
        /// Gets all properties also from super classes
        /// </summary>
        public List<IProperty> AllProperties => this.Properties.Union(this.SuperClasses.SelectMany(x => x.AllProperties)).OrderBy(y => y.Name).ToList();

        /// <summary>
        /// A <see cref="List{T}"/> of type <see cref="ObjectType"/> that contains all the <see cref="ObjectType"/>s that this <see cref="Class"/> derives from
        /// </summary>
        public List<ObjectType> SuperObjectTypes { get; set; } = new();

        /// <summary>
        /// A <see cref="List{T}"/> of type <see cref="ObjectType"/> that contains all the <see cref="ObjectType"/>s that derive from this <see cref="Class"/>
        /// </summary>
        public List<ObjectType> SubObjectTypes { get; set; } = new();

        /// <summary>
        /// A <see cref="List{T}"/> of type <see cref="Class"/> that contains all the <see cref="Class"/>es that this <see cref="Class"/> derives from
        /// </summary>
        public List<Class> SuperClasses { get; set; } = new();

        /// <summary>
        /// A <see cref="List{T}"/> of type <see cref="Class"/> that contains all the <see cref="Class"/>s that derive from this <see cref="Class"/>
        /// </summary>
        public List<Class> SubClasses { get; set; } = new();

        /// <summary>
        /// Gets a value indicating that this <see cref="Class"/> is a Sub type of another <see cref="Class"/>
        /// </summary>
        public bool IsSubType => this.SuperClasses.Any();

        /// <summary>
        /// Creates a new instance of the <see cref="Class"/> class
        /// </summary>
        /// <param name="ormModel">The <see cref="OrmModel"/></param>
        /// <param name="objectType">The <see cref="EntityType"/></param>
        protected Class(OrmModel ormModel, ObjectType objectType)
        {
            this.OrmModel = ormModel;
            this.ObjectType = objectType;
            this.Definition = objectType.Definition?.Text;
            this.Note = objectType.Note?.Text;
            this.Name = objectType.Name.ToUsableName();
            this.Initialize();
        }

        /// <summary>
        /// Initializes this class
        /// </summary>
        protected abstract void Initialize();

        /// <summary>
        /// Adds properties to this <see cref="Class"/>
        /// </summary>
        protected bool TryAddProperties()
        {
            var result = false;

            this.ObjectType.PlayedRoles
                .ToList()
                .ForEach(playedRole => 
                {
                    if (playedRole is SubtypeMetaRole subTypeMetaRole)
                    {
                        this.AddSuperObjectType(subTypeMetaRole);
                    }
                    else if (playedRole is SupertypeMetaRole superTypeMetaRole)
                    {
                        this.AddSubObjectType(superTypeMetaRole);
                    }
                    else
                    {
                        var impliedFactType =
                            this.OrmModel.FactTypes
                                .OfType<ImpliedFactType>()
                                .SingleOrDefault(f => f.Roles.OfType<RoleProxy>().Any(ff => ff.TargetRole.Id == playedRole.Id));

                        if (impliedFactType != null)
                        {
                            if (this.TryAddImpliedTypeProperty(impliedFactType))
                            {
                                result = true;
                            }
                        }
                        else
                        {
                            var factType = this.OrmModel.FactTypes
                                .SingleOrDefault(f => f.Roles.Any(ff => ff.Id == playedRole.Id));

                            if (factType != null)
                            {
                                var classRole =
                                    factType.Roles
                                        .Where(x => x.GetType() == typeof(Role))
                                        .Cast<Role>()
                                        .First(x => x.RolePlayer == this.ObjectType);

                                var propertyRoles =
                                    factType.Roles
                                        .Where(x => x.GetType() == typeof(Role))
                                        .Cast<Role>()
                                        .Union(factType.Roles.OfType<RoleProxy>().Select(x => x.TargetRole))
                                        .Where(x => x.RolePlayer != this.ObjectType)
                                        .ToList();

                                foreach (var propertyRole in propertyRoles)
                                {
                                    if (propertyRole.RolePlayer is ValueType valueType)
                                    {
                                        if (this.TryAddValueTypeProperty(valueType, propertyRole, classRole))
                                        {
                                            result = true;
                                        }
                                    }
                                    else if (propertyRole.RolePlayer is EntityType relatedEntityType)
                                    {
                                        if (this.TryAddEntityTypeProperty(relatedEntityType, propertyRole, classRole))
                                        {
                                            result = true;
                                        }
                                    }
                                }
                            }
                        }
                    }
                });

            var groupedPropertiesByName = this.Properties.GroupBy(x => x.Name).Where(x => x.Count() > 1);

            foreach (var group in groupedPropertiesByName)
            {
                for (var i = 0; i < group.Count(); i++)
                {
                    group.ToList()[i].Name += (i + 1);
                }
            }

            this.Properties = this.Properties.OrderBy(x => x.Name).ToList();

            return result;
        }

        /// <summary>
        /// Add a SuperType to the <see cref="SuperObjectTypes"/> property
        /// </summary>
        /// <param name="subtypeMetaRole">The <see cref="SubtypeMetaRole"/> for which to find its <see cref="SupertypeMetaRole"/> counterpart</param>
        private void AddSuperObjectType(SubtypeMetaRole subtypeMetaRole)
        {
            var factType = this.OrmModel.FactTypes.First(x => x.Roles.Contains(subtypeMetaRole));

            var superTypeRole = 
                factType.Roles
                    .OfType<SupertypeMetaRole>()
                    .Single();
            
            this.SuperObjectTypes.Add(superTypeRole.RolePlayer);
        }

        /// <summary>
        /// Add a SuperType to the <see cref="SubObjectTypes"/> property
        /// </summary>
        /// <param name="supertypeMetaRole">The <see cref="SupertypeMetaRole"/> for which to find its <see cref="SubtypeMetaRole"/> counterpart</param>
        private void AddSubObjectType(SupertypeMetaRole supertypeMetaRole)
        {
            var factType = this.OrmModel.FactTypes.First(x => x.Roles.Contains(supertypeMetaRole));

            var subTypeRole = 
                factType.Roles
                    .OfType<SubtypeMetaRole>()
                    .Single();
            
            this.SubObjectTypes.Add(subTypeRole .RolePlayer);
        }

        /// <summary>
        /// Tries to add a <see cref="ValueType"/> property to this <see cref="Class"/>
        /// </summary>
        /// <param name="valueType">The <see cref="ValueType"/></param>
        /// <param name="propertyRole">The current <see cref="Role"/></param>
        /// <param name="classRole">The <see cref="Class"/> <see cref="Role"/></param>
        /// <returns>True if a property was added, otherwise false</returns>
        protected bool TryAddValueTypeProperty(ValueType valueType, Role propertyRole, Role classRole)
        {
            if (valueType.Name.EndsWith("_UUID"))
            {
                return true;
            }

            var property = new ValueTypeProperty(this.OrmModel, valueType, propertyRole, classRole);
            this.Properties.Add(property);

            return false;
        }

        /// <summary>
        /// Tries to add an <see cref="EntityType"/> property to this <see cref="Class"/>
        /// </summary>
        /// <param name="entityType">The <see cref="EntityType"/></param>
        /// <param name="propertyRole">The current <see cref="Role"/></param>
        /// <param name="classRole">The <see cref="Class"/> <see cref="Role"/></param>
        /// <returns>True if a property was added, otherwise false</returns>
        protected bool TryAddEntityTypeProperty(EntityType entityType, Role propertyRole, Role classRole)
        {
            if (propertyRole is SupertypeMetaRole)
            {
                this.SuperObjectTypes.Add(entityType);
                return false;
            }

            if (propertyRole is SubtypeMetaRole)
            {
                this.SubObjectTypes.Add(entityType);
                return false;
            }

            var property = ReferencePropertyBuilder.CreateReferenceProperty(this.OrmModel, entityType, propertyRole, classRole);
            this.Properties.Add(property);

            return true;
        }

        /// <summary>
        /// Adds a property to an <see cref="Class"/> that represents a relationship to an <see cref="ObjectifiedType"/> in a <see cref="ImpliedFactType"/>
        /// </summary>
        /// <param name="impliedFactType">The <see cref="ImpliedFactType"/></param>
        protected bool TryAddImpliedTypeProperty(ImpliedFactType impliedFactType)
        {
            var result = false;

            var propertyRole =
                impliedFactType.Roles
                    .OfType<Role>()
                    .Where(x => x.RolePlayer != this.ObjectType)
                    .Union(
                        impliedFactType.Roles
                            .OfType<RoleProxy>()
                            .Where(x => x.TargetRole.RolePlayer != this.ObjectType)
                            .Select(x => x.TargetRole)
                    )
                    .ToList().SingleOrDefault();

            var classRole =
                impliedFactType.Roles
                    .OfType<Role>()
                    .Where(x => x.RolePlayer == this.ObjectType)
                    .Union(
                        impliedFactType.Roles
                            .OfType<RoleProxy>()
                            .Where(x => x.TargetRole.RolePlayer == this.ObjectType)
                            .Select(x => x.TargetRole)
                    )
                    .ToList().SingleOrDefault();

            if (propertyRole?.RolePlayer is ObjectifiedType objectifiedType)
            {
                var property = ReferencePropertyBuilder.CreateReferenceProperty(this.OrmModel, objectifiedType, propertyRole, classRole);

                this.Properties.Add(property);
                result = true;
            }

            return result;
        }
    }
}
