// -------------------------------------------------------------------------------------------------
// <copyright file="DomainAttribute.cs" company="RHEA System S.A.">
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
    /// The purpose of the <see cref="DomainAttribute"/> is to decorate classes
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public class DomainAttribute : Attribute
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DomainAttribute"/> class
        /// </summary>
        /// <param name="isRoot">
        /// A value indicating whether this class is the root class of the domain model
        /// </param>
        /// <param name="isAbstract">
        /// A value indicating whether this is an abstract class
        /// </param>
        /// <param name="general">
        /// The name of the abstract super type
        /// </param>
        public DomainAttribute(bool isAbstract = false, string general = "")
        {
            this.IsAbstract = isAbstract;
            this.General = general;
        }

        /// <summary>
        /// Gets a value indicating whether this is an abstract class
        /// </summary>
        public bool IsAbstract { get; private set; }

        /// <summary>
        /// Gets the name(s) of the abstract super type
        /// </summary>
        public string General { get; private set; }
    }
}
