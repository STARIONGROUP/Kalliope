﻿// -------------------------------------------------------------------------------------------------
// <copyright file="ContainerAttribute.cs" company="Starion Group S.A.">
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
    /// The purpose of the <see cref="ContainerAttribute"/> is to decorate classes that take part in a Composition
    /// relationship at the contained end. The <see cref="ContainerAttribute"/> has a property that specifies the name
    /// of the container property that contains the current class.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    public class ContainerAttribute : Attribute
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContainerAttribute"/> class.
        /// </summary>
        /// <param name="typeName">
        /// The name of the <see cref="Type"/> of the container.
        /// </param>
        /// <param name="propertyName">
        /// The name of the container property
        /// </param>
        public ContainerAttribute(string typeName, string propertyName)
        {
            this.TypeName = typeName;
            this.PropertyName = propertyName;
        }

        /// <summary>
        /// Gets the name of <see cref="Type"/> of the container
        /// </summary>
        public string TypeName { get; private set; }

        /// <summary>
        /// Gets the name of the container property
        /// </summary>
        public string PropertyName { get; private set; }
    }
}
