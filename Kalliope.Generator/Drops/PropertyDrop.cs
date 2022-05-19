// -------------------------------------------------------------------------------------------------
// <copyright file="PropertyDrop.cs" company="RHEA System S.A.">
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
// ------------------------------------------------------------------------------------------------

namespace Kalliope.Generator
{
    using System;
    using System.Reflection;

    using DotLiquid;

    using Kalliope.Common;

    /// <summary>
    /// The purpose of the <see cref="PropertyDrop"/> is to encapsulate a <see cref="PropertyInfo"/> in a <see cref="Drop"/>
    /// for the purpose of code generation
    /// </summary>
    public class PropertyDrop : Drop
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PropertyDrop"/> class
        /// </summary>
        /// <param name="propertyInfo">
        /// The <see cref="PropertyInfo"/> that is encapsulated by the <see cref="Drop"/>
        /// </param>
        /// <param name="propertyAttribute">
        /// The <see cref="PropertyAttribute"/> that provides metadata about the <see cref="Type"/>
        /// </param>
        /// <param name="descriptionAttribute">
        /// The <see cref="DescriptionAttribute"/> that contains a textual description of the <see cref="PropertyInfo"/>
        /// </param>
        public PropertyDrop(PropertyInfo propertyInfo, PropertyAttribute propertyAttribute, DescriptionAttribute descriptionAttribute)
        {
            this.PropertyInfo = propertyInfo;
            this.PropertyAttribute = propertyAttribute;
            this.DescriptionAttribute = descriptionAttribute;
        }

        /// <summary>
        /// Gets the <see cref="PropertyInfo"/> that is encapsulated by the <see cref="Drop"/>
        /// </summary>
        public PropertyInfo PropertyInfo { get; private set; }

        /// <summary>
        /// Gets the <see cref="PropertyAttribute"/> that was used to decorate the property in the originating Type
        /// </summary>
        public PropertyAttribute PropertyAttribute { get; private set; }

        /// <summary>
        /// Gets the <see cref="DescriptionAttribute"/> that was used to decorate the property in the originating Type
        /// </summary>
        public DescriptionAttribute DescriptionAttribute { get; private set; }

        /// <summary>
        /// Gets the name of the encapsulated <see cref="PropertyInfo"/>.
        /// </summary>
        public string Name => this.PropertyAttribute?.Name;
        
        /// <summary>
        /// Gets or sets the name of the type of the property
        /// </summary>
        public string TypeName 
        {
            get
            {
                switch (this.PropertyAttribute.TypeKind)
                {
                    case TypeKind.Object:
                    case TypeKind.Enumeration:
                        return this.PropertyAttribute.TypeName;
                    case TypeKind.Boolean:
                        return "bool";
                    case TypeKind.String:
                        return "string";
                    case TypeKind.Byte:
                        return "byte";
                    case TypeKind.Char:
                        return "char";
                    case TypeKind.Int16:
                        return "short";
                    case TypeKind.Int32:
                        return "int";
                    case TypeKind.Int64:
                        return "long";
                    case TypeKind.SByte:
                        return "sbyte";
                    case TypeKind.UInt16:
                        return "ushort";
                    case TypeKind.UInt32:
                        return "uint";
                    case TypeKind.UInt64:
                        return "ulong";
                    case TypeKind.Single:
                        return "float";
                    case TypeKind.Double:
                        return "double";
                    case TypeKind.Obj:
                        return "object";
                    default:
                        throw new NotSupportedException($"The {this.PropertyAttribute.TypeKind} is not supported");
                }
            }
        }

        /// <summary>
        /// Gets a value indicating the property is a reference type
        /// </summary>
        public bool IsReferenceType => this.PropertyAttribute.TypeKind == TypeKind.Object;

        /// <summary>
        /// Gets a value indicating the property is a value type
        /// </summary>
        public bool IsValueType => this.PropertyAttribute.TypeKind != TypeKind.Object;

        /// <summary>
        /// Gets a value indicating whether the property is an IEnumerable
        /// </summary>
        public bool IsEnumerable => this.PropertyAttribute.Multiplicity.Contains("*");

        /// <summary>
        /// Gets a value indicating whether the property is an enumeration
        /// </summary>
        public bool IsEnumeration => this.PropertyAttribute.TypeKind == TypeKind.Enumeration;

        /// <summary>
        /// Gets a value indicating whether the property is part of a <see cref="AggregationKind.Composite"/> relationship
        /// </summary>
        public bool IsComposite => this.PropertyAttribute.Aggregation == AggregationKind.Composite;

        /// <summary>
        /// Gets a value indicating whether the property is is allowed to be overriden
        /// </summary>
        public bool AllowOverride => this.PropertyAttribute.AllowOverride;

        /// <summary>
        /// Gets a value indicating whether the property is an override
        /// </summary>
        public bool IsOverride => this.PropertyAttribute.IsOverride;

        /// <summary>
        /// Gets a value indicating whether the property is a derived property
        /// </summary>
        public bool IsDerived => this.PropertyAttribute.IsDerived;
        
        /// <summary>
        /// Gets the default value for the property
        /// </summary>
        public string DefaultValue => this.PropertyAttribute.DefaultValue;
    }
}
