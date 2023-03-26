// -------------------------------------------------------------------------------------------------
// <copyright file="Class.cs" company="RHEA System S.A.">
//
//   Copyright 2022-2023 RHEA System S.A.
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
    using Kalliope.CustomProperties;
    using Kalliope.OO.Extensions;
    using Kalliope.OO.Generation;

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
        /// A <see cref="List{Class}"/> that contains all Classes
        /// </summary>
        public List<Class> Classes { get; }

        /// <summary>
        /// Gets the <see cref="ObjectType"/>
        /// </summary>
        protected ObjectType ObjectType { get; }

        /// <summary>
        /// Gets a value indicating if this <see cref="Class"/> is an abstract class.
        /// </summary>
        public bool IsAbstract => this.CalculateAbstract();

        /// <summary>
        /// Calculates if this <see cref="Class"/> is an abstract class.
        /// </summary>
        /// <returns>True is it is an abstract class, otherwise false</returns>
        private bool CalculateAbstract()
        {
            var modelIsAbstract = this.ObjectType.Extensions?
                .OfType<CustomProperty>()
                .SingleOrDefault(x =>
                    x.CustomPropertyDefinition.Category == "KALLIOPE"
                    && x.CustomPropertyDefinition.Name == "IsAbstract")?
                .Value.ToString();

            if (modelIsAbstract== null || !bool.TryParse(modelIsAbstract, out var isAbstract))
            {
                return false;
            }

            return isAbstract;
        }

        /// <summary>
        /// Gets a value that indicates that this is an Objectified class
        /// </summary>
        public bool IsObjectified => this.ObjectType is ObjectifiedType;

        /// <summary>
        /// Gets a value indicating that the relationship that resulted in the creation of this <see cref="ObjectifiedClass"/> is an Implied Binary Relationship
        /// </summary>
        public bool IsImplied => this.IsObjectified && this.ObjectType is ObjectifiedType objectifiedType && objectifiedType.NestedPredicate.IsImplied && this.Properties.Count == 2;

        /// <summary>
        /// A <see cref="List{IProperty}"/> that contains all the properties of this <see cref="Class"/>
        /// </summary>
        public List<IProperty> Properties { get; set; } = new();

        /// <summary>
        /// Gets all identifier properties 
        /// </summary>
        public List<IProperty> IdentifierProperties => this.GetIdentifierProperties();

        /// <summary>
        /// Gets all properties also from super classes
        /// </summary>
        public List<IProperty> IdentifierPropertiesIncludingSuperTypes => this.GetIdentifierProperties(includeSuperTypeProperties: true);

        /// <summary>
        /// Retrieves all the identifier properties of this class
        /// </summary>
        /// <returns>A <see cref="List{IProperty}"/></returns>
        private List<IProperty> GetIdentifierProperties(bool includeSuperTypeProperties = false)
        {
            var properties = this.Properties.Where(y => y.IsPartOfIdentifier).ToList();

            if (properties.Any())
            {
                return properties;
            }

            if (includeSuperTypeProperties)
            {
                foreach (var superClass in this.SuperClasses)
                {
                    properties = superClass.IdentifierPropertiesIncludingSuperTypes;

                    if (properties.Any())
                    {
                        return properties;
                    }
                }
            }

            return new List<IProperty>();
        }

        /// <summary>
        /// Gets all properties also from super classes
        /// </summary>
        public List<IProperty> NonIdentifierProperties => this.GetNonIdentifierProperties();

        /// <summary>
        /// Gets all properties also from super classes
        /// </summary>
        public List<IProperty> NonIdentifierPropertiesIncludingSuperTypes => this.GetNonIdentifierProperties(includeSuperTypeProperties: true);

        /// <summary>
        /// Retrieves all the non identifier properties of this class
        /// </summary>
        /// <returns>A <see cref="List{IProperty}"/></returns>
        private List<IProperty> GetNonIdentifierProperties(bool includeSuperTypeProperties = false)
        {
            var result = this.Properties.Where(y => !y.IsPartOfIdentifier);

            if (includeSuperTypeProperties)
            {
                result = result
                    .Union(
                        this.SuperClasses
                            .SelectMany(x => x.NonIdentifierPropertiesIncludingSuperTypes.Where(y => !y.IsPartOfIdentifier)));
            }

            return result
                .OrderBy(y => y.Name)
                .ToList();
        }

        /// <summary>
        /// A <see cref="List{ObjectType}"/> that contains all the <see cref="ObjectType"/>s that this <see cref="Class"/> derives from
        /// </summary>
        protected List<ObjectType> SuperObjectTypes { get; set; } = new();

        /// <summary>
        /// A <see cref="List{ObjectType}"/> that contains all the <see cref="ObjectType"/>s that derive from this <see cref="Class"/>
        /// </summary>
        protected List<ObjectType> SubObjectTypes { get; set; } = new();

        /// <summary>
        /// A <see cref="List{Class}"/> that contains all the <see cref="Class"/>es that this <see cref="Class"/> derives from
        /// </summary>
        public List<Class> SuperClasses => this.Classes.Where(x => this.SuperObjectTypes.Contains(x.ObjectType)).ToList();

        /// <summary>
        /// A <see cref="List{Class}"/> that contains all the <see cref="Class"/>s that derive from this <see cref="Class"/>
        /// </summary>
        public List<Class> SubClasses => this.Classes.Where(x => this.SubObjectTypes.Contains(x.ObjectType)).ToList();

        /// <summary>
        /// Gets a value indicating that this <see cref="Class"/> is a Sub type of another <see cref="Class"/>
        /// </summary>
        public bool IsSubType => this.SuperClasses.Any();

        /// <summary>
        /// Gets a value indicating that this <see cref="Class"/> is a Sub type of another <see cref="Class"/>
        /// </summary>
        public bool HasBaseClass => this.CalculateHasBaseClass();

        /// <summary>
        /// Calculates if this <see cref="Class"/> has a base class
        /// </summary>
        /// <returns></returns>
        private bool CalculateHasBaseClass()
        {
            return this.CalculateMainSuperType() != null;
        }

        /// <summary>
        /// Gets the main super type <see cref="Class"/>
        /// </summary>
        public Class MainSuperType => this.CalculateMainSuperType();

        /// <summary>
        /// Calculates the main super type <see cref="Class"/>
        /// </summary>
        private Class CalculateMainSuperType()
        {
            if (this.IsSubType)
            {
                foreach (var subTypeMetaRole in this.ObjectType.PlayedRoles.OfType<SubtypeMetaRole>())
                {
                    var inheritanceFactType = this.OrmModel.FactTypes.OfType<SubtypeFact>().SingleOrDefault(x => x.Roles.Contains(subTypeMetaRole) && (x.PreferredIdentificationPath || x.ProvidesPreferredIdentifier));

                    var superTypeMetaRole = inheritanceFactType?.Roles.OfType<SupertypeMetaRole>().FirstOrDefault();

                    if (superTypeMetaRole != null)
                    {
                        return this.SuperClasses.Single(x => x.ObjectType == superTypeMetaRole.RolePlayer);
                    }
                }
            }

            return null;
        }

        /// <summary>
        /// Creates a new instance of the <see cref="Class"/> class
        /// </summary>
        /// <param name="ormModel">The <see cref="OrmModel"/></param>
        /// <param name="classes">The Complete <see cref="List{Class}"/></param>
        /// <param name="objectType">The <see cref="EntityType"/></param>
        /// <param name="generatorSettings">The <see cref="GeneratorSettings"/></param>
        protected Class(OrmModel ormModel, List<Class> classes, ObjectType objectType, GeneratorSettings generatorSettings)
        {
            this.GeneratorSettings = generatorSettings;
            this.OrmModel = ormModel;
            this.Classes = classes;
            this.ObjectType = objectType;
            this.Definition = objectType.Definition?.Text;
            this.Note = objectType.Note?.Text;
            this.Name = objectType.Name.ToUsableName(generatorSettings.ReservedWords);
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

                        if (impliedFactType != null && this.TryAddImpliedTypeProperty(impliedFactType))
                        {
                            result = true;
                        }
                        else
                        {
                            FactType factType;
                            var isImpliedProperty = false;

                            if (impliedFactType != null && impliedFactType.Roles.Count == 2)
                            {
                                factType = impliedFactType.ImpliedByObjectification.NestedFactType;
                                isImpliedProperty = true;
                            }
                            else
                            {
                                factType = this.OrmModel.FactTypes
                                    .SingleOrDefault(f => f.Roles.Any(ff => ff.Id == playedRole.Id));
                            }

                            if (factType != null)
                            {
                                var classRole =
                                    factType.Roles
                                        .Where(x => x.GetType() == typeof(Role))
                                        .Cast<Role>()
                                        .First(x => x.Id == playedRole.Id);

                                var propertyRoles =
                                    factType.Roles
                                        .Where(x => x.GetType() == typeof(Role))
                                        .Cast<Role>()
                                        .Union(factType.Roles.OfType<RoleProxy>().Select(x => x.TargetRole))
                                        .Where(x => x.Id != playedRole.Id)
                                        .ToList();

                                foreach (var propertyRole in propertyRoles)
                                {
                                    var calculatedRole = propertyRole;

                                    if (calculatedRole.RolePlayer is ValueType valueType)
                                    {
                                        if (this.TryAddValueTypeProperty(valueType, calculatedRole, classRole))
                                        {
                                            result = true;
                                        }
                                    }
                                    else if (calculatedRole.RolePlayer is EntityType relatedEntityType)
                                    {
                                        if (this.TryAddReferenceTypeProperty(relatedEntityType, calculatedRole, classRole, isImpliedProperty))
                                        {
                                            result = true;
                                        }
                                    }
                                    else if (calculatedRole.RolePlayer is ObjectifiedType relatedObjectifiedType)
                                    {
                                        if (this.TryAddReferenceTypeProperty(relatedObjectifiedType, calculatedRole, classRole, isImpliedProperty))
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
                    group.ToList()[i].Name += i + 1;
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

            this.SubObjectTypes.Add(subTypeRole.RolePlayer);
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
            var property = new ValueTypeProperty(this.OrmModel, this, valueType, propertyRole, classRole, this.GeneratorSettings);
            this.Properties.Add(property);

            return true;
        }

        /// <summary>
        /// Tries to add an reference <see cref="ObjectType"/> property to this <see cref="Class"/>
        /// </summary>
        /// <param name="referenceType">The <see cref="ObjectType"/></param>
        /// <param name="propertyRole">The current <see cref="Role"/></param>
        /// <param name="classRole">The <see cref="Class"/> <see cref="Role"/></param>
        /// <param name="isImpliedProperty">Indication that this is a property from an implied FactType </param>
        /// <returns>True if a property was added, otherwise false</returns>
        protected bool TryAddReferenceTypeProperty<T>(T referenceType, Role propertyRole, Role classRole, bool isImpliedProperty) where T : ObjectType
        {
            if (propertyRole is SupertypeMetaRole)
            {
                this.SuperObjectTypes.Add(referenceType);
                return false;
            }

            if (propertyRole is SubtypeMetaRole)
            {
                this.SubObjectTypes.Add(referenceType);
                return false;
            }

            var property = ReferencePropertyBuilder.CreateReferenceProperty(this.OrmModel, this, referenceType, propertyRole, classRole, this.GeneratorSettings);
            property.IsImpliedProperty = isImpliedProperty;

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
                if (objectifiedType.NestedPredicate.IsImplied && objectifiedType.NestedPredicate.NestedFactType.Roles.Count == 2)
                {
                    return false;
                }

                var property = ReferencePropertyBuilder.CreateReferenceProperty(this.OrmModel, this, objectifiedType, propertyRole, classRole, this.GeneratorSettings);

                this.Properties.Add(property);
                result = true;
            }

            return result;
        }
    }
}
