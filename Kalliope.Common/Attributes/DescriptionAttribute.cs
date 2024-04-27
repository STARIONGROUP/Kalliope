﻿// -------------------------------------------------------------------------------------------------
// <copyright file="DescriptionAttribute.cs" company="Starion Group S.A.">
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
    /// The purpose of the <see cref="DescriptionAttribute"/> is to decorate classes and properties with the
    /// description as stated in the ORM DSL or in the ORM XSD
    /// </summary>
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Enum | AttributeTargets.Field, AllowMultiple = false)]
    public class DescriptionAttribute : Attribute
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Description"/> class
        /// </summary>
        /// <param name="description">
        /// The human readable description
        /// </param>
        public DescriptionAttribute(string description = "")
        {
            this.Description = description;
        }

        /// <summary>
        /// Gets or sets the human readable description
        /// </summary>
        public string Description { get; private set; }
    }
}
