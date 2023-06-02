// -------------------------------------------------------------------------------------------------
// <copyright file="TypeDrop.cs" company="RHEA System S.A.">
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
// ------------------------------------------------------------------------------------------------

namespace Kalliope.Generator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;

    using DotLiquid;

    using Kalliope.Common;

    /// <summary>
    /// The purpose of the <see cref="TypeDrop"/> is to encapsulate a <see cref="Type"/> in a <see cref="Drop"/>
    /// for the purpose of code generation
    /// </summary>
    public class TypeDrop : Drop
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TypeDrop"/> class
        /// </summary>
        /// <param name="type">
        /// The <see cref="Type"/> that is encapsulated by the <see cref="Drop"/>
        /// </param>
        /// <param name="domainAttribute">
        /// The <see cref="DomainAttribute"/> that provides metadata about the <see cref="Type"/>
        /// </param>
        /// <param name="descriptionAttribute">
        /// The <see cref="DescriptionAttribute"/> that contains a textual description of the <see cref="Type"/>
        /// </param>
        /// <param name="containerAttributes">
        /// The array of  <see cref="ContainerAttribute"/> owned by this <see cref="TypeDrop"/>
        /// </param>
        /// <param name="isContainedThroughSuperClass">
        /// a value indicating whether this Type is contained (part of a composite aggregation) through its inheritance hierarchy
        /// </param>
        public TypeDrop(Type type, DomainAttribute domainAttribute, DescriptionAttribute descriptionAttribute, ContainerAttribute[] containerAttributes, bool isContainedThroughSuperClass =false)
        {
            this.Type = type;
            this.DomainAttribute = domainAttribute;
            this.DescriptionAttribute = descriptionAttribute;
            this.ContainerAttributes = containerAttributes ?? new List<ContainerAttribute>().ToArray();
            this.IsContainedThroughSuperClass = isContainedThroughSuperClass;

            this.CreatePropertyDrops();
        }

        /// <summary>
        /// Creates <see cref="PropertyDrop"/>
        /// </summary>
        private void CreatePropertyDrops()
        {
            this.Properties = new List<PropertyDrop>();
            this.AllProperties = new List<PropertyDrop>();

            var properties = this.Type.GetProperties(BindingFlags.Public | BindingFlags.Instance).OrderBy(x => x.Name);
            foreach (var propertyInfo in properties)
            {
                var ignoreAttribute = propertyInfo.GetCustomAttribute<IgnoreAttribute>();
                var propertyAttribute = propertyInfo.GetCustomAttribute<PropertyAttribute>();
                var descriptionAttribute = propertyInfo.GetCustomAttribute<DescriptionAttribute>();
                var calculatedAttribute = propertyInfo.GetCustomAttribute<CalculatedAttribute>();
                
                if (ignoreAttribute == null && propertyAttribute != null)
                {
                    var propertyDrop = new PropertyDrop(propertyInfo, propertyAttribute, descriptionAttribute, calculatedAttribute);

                    if (propertyInfo.DeclaringType == this.Type)
                    {
                        this.Properties.Add(propertyDrop);
                    }

                    this.AllProperties.Add(propertyDrop);
                }
            }
        }

        /// <summary>
        /// Gets the <see cref="Type"/> that is encapsulated by the <see cref="Drop"/>
        /// </summary>
        public Type Type { get; private set; }

        /// <summary>
        /// Gets the <see cref="DomainAttribute"/> that provides metadata about the <see cref="Type"/>
        /// </summary>
        public DomainAttribute DomainAttribute { get; private set; }

        /// <summary>
        /// Gets the <see cref="DescriptionAttribute"/> that contains a textual description of the <see cref="Type"/>
        /// </summary>
        public DescriptionAttribute DescriptionAttribute { get; private set; }

        /// <summary>
        /// Gets the <see cref="ContainerAttribute"/> that contains the name of the Type that contains the current Type
        /// </summary>
        public ContainerAttribute[] ContainerAttributes { get; private set; }

        /// <summary>
        /// Gets the contained <see cref="PropertyDrop"/>s of the current type <see cref="TypeDrop"/>
        /// </summary>
        public List<PropertyDrop> Properties { get; private set;  }

        /// <summary>
        /// Gets all the properties that are defined on the Type, including the properties of the super classes
        /// </summary>
        public List<PropertyDrop> AllProperties { get; internal set; }

        /// <summary>
        /// Gets the amount of reference properties from the <see cref="AllProperties"/> property
        /// </summary>
        public int AllReferencePropertiesCount => this.AllProperties.Count(x => x.IsReferenceType);

        /// <summary>
        /// Gets the name of the Class / Type
        /// </summary>
        public string Name => Type.Name;
        
        /// <summary>
        /// Gets a value indicating whether this is an abstract class
        /// </summary>
        public bool IsAbstract => this.DomainAttribute.IsAbstract;

        /// <summary>
        /// Gets the description of the associated <see cref="Type"/>
        /// </summary>
        public string Description => this.DescriptionAttribute?.Description;

        /// <summary>
        /// Gets the generalization statement ( e.g. : supertypename)
        /// </summary>
        public string Generalization  => !string.IsNullOrEmpty(this.DomainAttribute.General) ? $" : {this.DomainAttribute.General}" : string.Empty;

        /// <summary>
        /// Gets a value indicating whether this Type is contained (part of a composite aggregation) through its inheritance hierarchy
        /// </summary>
        public bool IsContainedThroughSuperClass { get; private set; }

        /// <summary>
        /// Gets a value indicating whether the Type is contained (part of a composite aggregation) by another type
        /// </summary>
        public bool IsContained => this.ContainerAttributes.Any();

        /// <summary>
        /// Gets the namespace of the encapsulated <see cref="Type"/>
        /// </summary>
        public string Namespace => this.Type.Namespace;
    }
}
