// -------------------------------------------------------------------------------------------------
// <copyright file="IgnoreAttribute.cs" company="RHEA System S.A.">
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

namespace Kalliope.Common
{
    using System;
    
    /// <summary>
    /// The purpose of the <see cref="IgnoreAttribute"/> is to decorate classes and properties that are to be ingored
    /// for code generation purposes. The rationale for ignoring is provided in the <see cref="Description"/>
    /// </summary>
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Enum | AttributeTargets.Field, AllowMultiple = false)]
    public class IgnoreAttribute : Attribute
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IgnoreAttribute"/> class
        /// </summary>
        /// <param name="description">
        /// A string that contains the rationale for ignoring the class or property for code-generation purposes
        /// </param>
        public IgnoreAttribute(string description = "")
        {
            this.Description = description;
        }

        /// <summary>
        /// Gets a string that contains the rationale for ignoring the class or property for code-generation purposes
        /// </summary>
        public string Description { get; private set; }
    }
}
