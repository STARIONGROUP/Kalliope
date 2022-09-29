// -------------------------------------------------------------------------------------------------
// <copyright file="IProperty.cs" company="RHEA System S.A.">
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

    /// <summary>
    /// Defines the properties and methods of an <see cref="IProperty"/>
    /// </summary>
    public interface IProperty : IStructuralFeature
    {
        /// <summary>
        /// Gets or sets the <see cref="IProperty"/>'s DataType as a string
        /// </summary>
        string DataType { get; }

        /// <summary>
        /// Gets or sets the <see cref="IProperty"/>'s Raw DataType as a string
        /// </summary>
        DataType OrmDataType { get; }

        /// <summary>
        /// Gets or sets the multiplicity of the <see cref="IProperty"/> relationship
        /// </summary>
        Multiplicity Multiplicity { get; }

        /// <summary>
        /// The <see cref="Role"/>
        /// </summary>
        Role PropertyRole { get; }

        /// <summary>
        /// The <see cref="Core.OrmModel"/>
        /// </summary>
        OrmModel OrmModel { get; }

        /// <summary>
        /// The <see cref="FactType"/>
        /// </summary>
        FactType FactType { get; }

        /// <summary>
        /// The class's <see cref="Role"/>
        /// </summary>
        Role ClassRole { get; }

        /// <summary>
        /// Gets a value indicating if the property type is an Enumerable type
        /// </summary>
        bool IsEnumerable { get; }

        /// <summary>
        /// Gets a value indicating if the property type is a reference type
        /// </summary>
        bool IsReferenceProperty { get; }

        /// <summary>
        /// Gets the ORM ReferenceMode as a string
        /// </summary>
        string ReferenceMode { get; }

        /// <summary>
        /// Gets or sets the scale of the property
        /// </summary>
        int Scale { get; }

        /// <summary>
        /// Gets or sets the Length of the property
        /// </summary>
        int Length { get; }

        /// <summary>
        /// Gets a value indicating if the property is mandatory
        /// </summary>
        bool IsMandatory { get; }

        /// <summary>
        /// Gets a value indicating that this property is part of the primary key
        /// </summary>
        bool IsPartOfIdentifier { get; }

        /// <summary>
        /// Gets a value indicating that this property of an enum type
        /// </summary>
        bool IsEnum { get; }
    }
}
