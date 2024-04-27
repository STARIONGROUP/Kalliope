﻿// -------------------------------------------------------------------------------------------------
// <copyright file="PropertyAttribute.cs" company="Starion Group S.A.">
//
//   Copyright 2022-2024 Starion Group S.A.
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
// ------------------------------------------------------------------------------------------------

namespace Kalliope.Common
{
    using System;
    
    /// <summary>
    /// <see cref="AggregationKind"/> is an Enumeration for specifying the kind of aggregation of a Property.
    /// </summary>
    public enum AggregationKind
    {
        /// <summary>
        /// Indicates that the Property has no aggregation.
        /// </summary>
        None,

        /// <summary>
        /// Indicates that the Property has shared aggregation.
        /// </summary>
        Shared,

        /// <summary>
        /// Indicates that the Property is aggregated compositely, i.e., the composite object has responsibility for the existence and storage of the composed objects (parts).
        /// </summary>
        Composite
    }

    /// <summary>
    /// The <see cref="TypeKind"/> is an Enumeration for specifying the type of a property
    /// </summary>
    public enum TypeKind
    {
        Object = 0,

        Boolean = 1,

        String = 2,

        Char = 3,

        Byte = 4,

        Int16 = 5,

        Int32 = 6,

        Int64 = 7,

        SByte = 8,

        UInt16 = 9,

        UInt32 = 10,

        UInt64 = 11,

        Single = 12,

        Double = 13,

        Enumeration  = 14,

        /// <summary>
        /// The <see cref="object"/> type
        /// </summary>
        Obj = 15
    }
    
    /// <summary>
    /// The purpose of the <see cref="PropertyAttribute"/> is to decorate properties of classes
    /// to be able to use reflection to determine the kind of property
    /// </summary>
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public class PropertyAttribute : Attribute
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PropertyAttribute"/> class.
        /// </summary>
        /// <param name="name">
        /// The name of the property
        /// </param>
        /// <param name="aggregation">
        /// The kind of aggregation
        /// </param>
        /// <param name="multiplicity">
        /// The range of allowable cardinality values - the size - that a set may assume
        /// </param>
        /// <param name="typeKind">
        /// The kind of type for this property
        /// </param>
        /// <param name="defaultValue">
        /// The string based default value for this property
        /// </param>
        /// <param name="typeName">
        /// the name of the type, this property should only be set when the <see cref="TypeKind"/> is set to <see cref="TypeKind.Object"/>
        /// </param>
        /// <param name="allowOverride">
        /// A value indicating whether the property may be overriden
        /// </param>
        /// <param name="isOverride">
        /// A value indicating whether the property is an override
        /// </param>
        /// <param name="isDerived">
        /// A value indicating whether the property is derived. In case the property is derived it requires manual implementation in code generated files.
        /// </param>
        public PropertyAttribute(string name, AggregationKind aggregation = AggregationKind.None, string multiplicity = "1..1", TypeKind typeKind = TypeKind.Object, string defaultValue = "none", string typeName = "", bool allowOverride = false, bool isOverride = false, bool isDerived = false)
        {
            this.Name = name;
            this.Aggregation = aggregation;
            this.Multiplicity = multiplicity;
            this.TypeKind = typeKind;
            this.DefaultValue = defaultValue;
            this.TypeName = typeName;
            this.AllowOverride = allowOverride;
            this.IsOverride = isOverride;
            this.IsDerived = isDerived;
        }

        /// <summary>
        /// Gets the name of the property
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// Gets the <see cref="AggregationKind"/> of the decorated property
        /// </summary>
        public AggregationKind Aggregation { get; private set; }

        /// <summary>
        /// Gets the <see cref="TypeKind"/> of the decorated property
        /// </summary>
        public TypeKind TypeKind { get; private set; }

        /// <summary>
        /// Gets the name of the type, this property should only be set when the <see cref="TypeKind"/> is set to <see cref="TypeKind.Object"/>
        /// </summary>
        public string TypeName { get; private set; }

        /// <summary>
        /// Gets the range of allowable cardinality values - the size - that a set may assume
        /// </summary>
        public string Multiplicity { get; private set; }

        /// <summary>
        /// Gets the string representation of the default value
        /// </summary>
        public string DefaultValue { get; private set; }

        /// <summary>
        /// Gets a value indicating whether the property may be overriden
        /// </summary>
        /// <remarks>
        /// for code generation this means that the property should be declared as virtual
        /// </remarks>
        public bool AllowOverride { get; private set; }

        /// <summary>
        /// Gets a value indicating whether the property is an override
        /// </summary>
        public bool IsOverride { get; private set; }

        /// <summary>
        /// Gets a value indicating whether the property is derived. In case the property is derived it requires
        /// manual implementation in code generated files.
        /// </summary>
        public bool IsDerived { get; private set; }
    }
}
