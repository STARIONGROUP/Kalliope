// -------------------------------------------------------------------------------------------------
// <copyright file="Property.cs" company="RHEA System S.A.">
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
    using System.Linq;

    using Kalliope.Common;
    using Kalliope.Core;
    using Kalliope.CustomProperties;
    using Kalliope.OO.Extensions;
    using Kalliope.OO.Generation;

    using ValueType = Kalliope.Core.ValueType;

    /// <summary>
    /// Class that defines a Property
    /// </summary>
    public abstract class Property<T> : StructuralFeature, IProperty where T : ObjectType
    {
        /// <summary>
        /// Gets the <see cref="Class"/> that this <see cref="IProperty"/> belongs to
        /// </summary>
        public Class Class { get; }

        /// <summary>
        /// Gets or sets the property's DataType as a string
        /// </summary>
        public string DataType { get; protected set; }

        /// <summary>
        /// Gets the ORM ReferenceMode as a string
        /// </summary>
        public string ReferenceMode => this.GetReferenceMode();

        /// <summary>
        /// Retrieves the ReferenceMode
        /// </summary>
        /// <returns>the ReferenceMode as a string</returns>
        private string GetReferenceMode()
        {
            if (this.ObjectType.PlayedRoles.OfType<SubtypeMetaRole>().Any())
            {
                foreach (var subTypeMetaRole in this.ObjectType.PlayedRoles.OfType<SubtypeMetaRole>())
                {
                    var inheritanceFactType = this.OrmModel.FactTypes.OfType<SubtypeFact>().SingleOrDefault(x => x.Roles.Contains(subTypeMetaRole) && (x.PreferredIdentificationPath || x.ProvidesPreferredIdentifier));

                    var superTypeMetaRole = inheritanceFactType?.Roles.OfType<SupertypeMetaRole>().FirstOrDefault();

                    if (superTypeMetaRole != null)
                    {
                        return superTypeMetaRole.RolePlayer.ReferenceMode;
                    }
                }
            }

            return this.ObjectType.ReferenceMode;
        }

        /// <summary>
        /// Gets or sets the scale of the property
        /// </summary>
        public int Scale { get; protected set; } = -1;

        /// <summary>
        /// Gets or sets the Length of the property
        /// </summary>
        public int Length { get; protected set; } = -1;

        /// <summary>
        /// Gets a value indicating if the property is mandatory
        /// </summary>
        public bool IsMandatory => this.ClassRole.IsMandatory;

        /// <summary>
        /// Gets a value indicating that this property is part of the primary key
        /// </summary>
        public bool IsPartOfIdentifier { get; private set; }

        /// <summary>
        /// Gets a value indicating that this property of an enum type
        /// </summary>
        public bool IsEnum => this.ObjectType is ValueType valueType && valueType.ValueConstraint?.ValueRanges.Count > 0 && !valueType.IsImplicitBooleanValue;

        /// <summary>
        /// Calculates if this property is (part of) the identifier
        /// </summary>
        /// <returns>True if the property is part of the identifier</returns>
        private bool CalculateIsPartOfIdentity()
        {
            if (this.ClassRole.RolePlayer is EntityType entityType)
            {
                return
                    (entityType
                        .PreferredIdentifier?
                        .Roles
                        .OfType<Role>()
                        .Contains(this.PropertyRole) ?? false)
                    ||
                    (entityType
                        .PreferredIdentifier?
                        .Roles
                        .OfType<RoleProxy>()
                        .Select(x => x.TargetRole)
                        .Contains(this.PropertyRole) ?? false);
            }

            if (this.ClassRole.RolePlayer is ObjectifiedType objectifiedType)
            {
                return (objectifiedType
                           .PreferredIdentifier?
                           .Roles
                           .OfType<Role>()
                           .Contains(this.PropertyRole) ?? false)
                       ||
                       (objectifiedType
                           .PreferredIdentifier?
                           .Roles
                           .OfType<RoleProxy>()
                           .Select(x => x.TargetRole)
                           .Contains(this.PropertyRole) ?? false);
            }

            return false;
        }

        /// <summary>
        /// Gets or sets the <see cref="IProperty"/>'s ORM <see cref="DataType"/>
        /// </summary>
        public DataType OrmDataType => this.GetOrmDataType();

        /// <summary>
        /// Retrieves the ORM <see cref="DataType"/> for a <see cref="IProperty"/>
        /// </summary>
        /// <returns>The ORM <see cref="DataType"/></returns>
        private DataType GetOrmDataType()
        {
            if (this.ObjectType.ValueConstraint?.ValueRanges.Count > 0 && !this.ObjectType.IsImplicitBooleanValue)
            {
                return null;
            }

            if (this.ObjectType.ConceptualDataType == null)
            {
                return null;
            }

            var dataTypeId = this.ObjectType.ConceptualDataType.Reference;
            return this.OrmModel.DataTypes.FirstOrDefault(dt => dt.Id == dataTypeId);
        }

        /// <summary>
        /// Gets or sets the multiplicity of the <see cref="Property{T}"/> relationship
        /// </summary>
        public Multiplicity Multiplicity => this.CalculateMultiplicity();

        /// <summary>
        /// Calculates the Multiplicity for this property 
        /// </summary>
        /// <returns>The Calculated <see cref="Multiplicity"/></returns>
        protected abstract Multiplicity CalculateMultiplicity();

        /// <summary>
        /// The property's <see cref="Role"/>
        /// </summary>
        public Role PropertyRole { get; }

        /// <summary>
        /// The class's <see cref="Role"/>
        /// </summary>
        public Role ClassRole { get; }

        /// <summary>
        /// The <see cref="FactType"/>
        /// </summary>
        public FactType FactType { get; }

        /// <summary>
        /// The <see cref="Core.OrmModel"/>
        /// </summary>
        public OrmModel OrmModel { get; }

        /// <summary>
        /// The <see cref="ObjectType"/>
        /// </summary>
        public T ObjectType { get; }

        /// <summary>
        /// Gets a value indicating if the property type is an Enumerable type
        /// </summary>
        public bool IsEnumerable => this.CalculateIsEnumerable();

        /// <summary>
        /// Calculates if this property is an Enumerable type
        /// </summary>
        /// <returns>True if this property is an Enumerable type</returns>
        protected abstract bool CalculateIsEnumerable();

        /// <summary>
        /// Gets a value indicating if the property type is a reference type
        /// </summary>
        public bool IsReferenceProperty => this is IReferenceProperty;

                /// <summary>
        /// Gets a value indicating the RelationType of a ReferencedProperty
        /// </summary>
        public RelationType RelationType => this.CalculateRelationType();

        /// <summary>
        /// Calculates the <see cref="RelationType"/> of the relationship that belongs to this <see cref="ReferenceProperty{T}"/>
        /// </summary>
        /// <returns>The <see cref="RelationType"/></returns>
        private RelationType CalculateRelationType()
        {
            var modelRelationType = this.FactType.Extensions?
                       .OfType<CustomProperty>()
                       .SingleOrDefault(x =>
                           x.CustomPropertyDefinition.Category == "KALLIOPE"
                           && x.CustomPropertyDefinition.Name == "RelationshipType")?
                       .Value.ToString();

            if (modelRelationType == null || !Enum.TryParse<RelationType>(modelRelationType, true, out var relationType))
            {
                return RelationType.Aggregation;
            }

            return relationType;
        }

        /// <summary>
        /// Gets a value indicating that the property represents the owner of the Role
        /// </summary>
        public bool IsRoleOwner => this.CalculateIsRoleOwner(this.PropertyRole);

        /// <summary>
        /// Calculates if the Class that belongs to a Role is the Role Owner of the relationship that belongs to this <see cref="ReferenceProperty{T}"/>
        /// </summary>
        /// <returns>True if the class that belongs to the Role is the role owner, otherwise false</returns>
        protected bool CalculateIsRoleOwner(Role role)
        {
            var modelRoleOwner = role.Extensions?
                .OfType<CustomProperty>()
                .SingleOrDefault(x =>
                    x.CustomPropertyDefinition.Category == "KALLIOPE"
                    && x.CustomPropertyDefinition.Name == "RoleOwner")?
                .Value.ToString();

            if (modelRoleOwner == null || !bool.TryParse(modelRoleOwner, out var isRoleOwner))
            {
                return false;
            }

            return isRoleOwner;
        }

        /// <summary>
        /// Creates a new instance of the <see cref="Property{T}"/> class
        /// </summary>
        /// <param name="ormModel">The <see cref="OrmModel"/></param>
        /// <param name="class">The <see cref="Class"/> that this property belongs to</param>
        /// <param name="objectType">The <see cref="ObjectType"/></param>
        /// <param name="propertyRole">The <see cref="Property{Role}"/></param>
        /// <param name="classRole">The <see cref="Class"/> <see cref="Role"/></param>
        /// <param name="generatorSettings">The <see cref="GeneratorSettings"/></param>
        protected Property(OrmModel ormModel, Class @class, T objectType, Role propertyRole, Role classRole, GeneratorSettings generatorSettings)
        {
            this.GeneratorSettings = generatorSettings;
            this.Class = @class;
            this.OrmModel = ormModel;
            this.ObjectType = objectType;
            this.FactType = this.OrmModel.FactTypes.Single(x => x.Roles.Contains(propertyRole));
            this.PropertyRole = propertyRole;
            this.ClassRole = classRole;
            this.Definition = objectType.Definition?.Text ?? string.Empty;
            this.Initialize();
        }

        /// <summary>
        /// Initializes this class
        /// </summary>
        protected virtual void Initialize()
        {
            this.DataType = this.GetDataType();
            this.Name = this.GetName().ToUsableName(this.GeneratorSettings.ReservedWords);
            this.IsPartOfIdentifier = this.CalculateIsPartOfIdentity();
        }

        /// <summary>
        /// Get the Datatype of the <see cref="ObjectType"/>
        /// </summary>
        /// <returns>The <see cref="ObjectType"/>'s datatype</returns>
        protected abstract string GetDataType();

        /// <summary>
        /// Get the Name of the <see cref="ObjectType"/>
        /// </summary>
        /// <returns>The <see cref="ObjectType"/>'s Name</returns>
        protected abstract string GetName();
    }
}
