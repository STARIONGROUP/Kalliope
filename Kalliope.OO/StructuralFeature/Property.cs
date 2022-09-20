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
        /// Gets or sets the multiplicity of the <see cref="Property{T}"/> relationship
        /// </summary>
        public Multiplicity Multiplicity { get; protected set; } = Multiplicity.Unspecified;

        /// <summary>
        /// The <see cref="Role"/>
        /// </summary>
        public Role FactRole { get; }

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
        /// Creates a new instance of the 
        /// </summary>
        /// <param name="ormModel"></param>
        /// <param name="objectType"></param>
        /// <param name="factRole"></param>
        protected Property(OrmModel ormModel, T objectType, Role factRole)
        {
            this.OrmModel = ormModel;
            this.ObjectType = objectType;
            this.FactType = this.OrmModel.FactTypes.First(x => x.Roles.Contains(factRole));
            this.FactRole = factRole;
            this.Definition = objectType.Definition?.Text ?? string.Empty;
            this.Multiplicity = this.FactRole.Multiplicity;
            this.Initialize();
        }

        /// <summary>
        /// Initializes this class
        /// </summary>
        private void Initialize()
        {
            this.DataType = this.GetDataType().ToUsableName();
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
        /// <param name="multiplicity">The <see cref="Multiplicity"/> of the property</param>
        /// <returns></returns>
        protected string UpdateDataTypeStringWithMultiplicity(string dataType, Multiplicity multiplicity)
        {
            if (multiplicity is Multiplicity.OneToMany or Multiplicity.ZeroToMany)
            {
                return $"List<{dataType}>";
            }

            return dataType;
        }
    }
}
