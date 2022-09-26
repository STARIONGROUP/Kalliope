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
    using System.Linq;

    using Kalliope.Common;
    using Kalliope.Core;
    using Kalliope.OO.Extensions;

    /// <summary>
    /// Class that defines a Property
    /// </summary>
    public abstract class Property<T> : StructuralFeature, IProperty where T : ObjectType
    {
        /// <summary>
        /// Gets or sets the property's DataType as a string
        /// </summary>
        public string DataType { get; protected set; }

        /// <summary>
        /// Gets or sets the <see cref="IProperty"/>'s Raw DataType as a string
        /// </summary>
        public string RawDataType => this.GetRawDataType();

        private string GetRawDataType()
        {
            if (!this.IsReferenceProperty)
            {
                return this.DataType;
            }

            var rawDataType = "Guid";

            rawDataType = this.UpdateDataTypeStringWithMultiplicity(rawDataType);

            return rawDataType;
        }

        /// <summary>
        /// Gets or sets the multiplicity of the <see cref="Property{T}"/> relationship
        /// </summary>
        public Multiplicity Multiplicity => this.PropertyRole.Multiplicity;

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
        public bool IsEnumerable => this.Multiplicity is Multiplicity.OneToMany or Multiplicity.ZeroToMany;

        /// <summary>
        /// Gets a value indicating if the property type is a nullable type
        /// </summary>
        public bool IsNullable => this.Multiplicity is Multiplicity.ZeroToOne or Multiplicity.ZeroToMany;

        /// <summary>
        /// Gets a value indicating if the property type is a reference type
        /// </summary>
        public bool IsReferenceProperty => this.ObjectType is ObjectifiedType or EntityType;

        /// <summary>
        /// Creates a new instance of the <see cref="Property{T}"/> class
        /// </summary>
        /// <param name="ormModel">The <see cref="OrmModel"/></param>
        /// <param name="objectType">The <see cref="ObjectType"/></param>
        /// <param name="propertyRole">The <see cref="Property{T}"/> <see cref="Role"/></param>
        /// <param name="classRole">The <see cref="Class"/> <see cref="Role"/></param>
        protected Property(OrmModel ormModel, T objectType, Role propertyRole, Role classRole)
        {
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
        private void Initialize()
        {
            this.DataType = this.GetDataType();
            this.Name = this.GetName().ToUsableName();
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

        /// <summary>
        /// Updates the datatype of the property according to the <see cref="Multiplicity"/>
        /// </summary>
        /// <param name="dataType">A string representing the field data type</param>
        /// <returns></returns>
        protected string UpdateDataTypeStringWithMultiplicity(string dataType)
        {
            if (this.IsEnumerable)
            {
                return $"List<{dataType}>";
            }

            return dataType;
        }
    }
}
