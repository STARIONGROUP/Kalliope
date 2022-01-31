// -------------------------------------------------------------------------------------------------
// <copyright file="ObjectifiedType.cs" company="RHEA System S.A.">
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

namespace Kalliope.Core
{
    using System.Xml;

    using Microsoft.Extensions.Logging;

    /// <summary>
    /// An entity type that objectifies a fact type
    /// </summary>
    public class ObjectifiedType : ObjectType
    {
        /// <summary>
        /// The (injected) <see cref="ILoggerFactory"/> used to setup logging
        /// </summary>
        private readonly ILoggerFactory loggerFactory;

        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectifiedType"/> class
        /// </summary>
        /// <param name="model">
        /// The <see cref="ORMModel"/> that contains the current <see cref="ObjectifiedType"/>
        /// </param>
        internal ObjectifiedType(ORMModel model, ILoggerFactory loggerFactory)
            : base(model)
        {
            this.loggerFactory = loggerFactory;

            model.ObjectTypes.Add(this);
        }

        /// <summary>
        /// Generates a <see cref="EntityType"/> object from its XML representation.
        /// </summary>
        /// <param name="reader">
        /// an instance of <see cref="XmlReader"/> used to read the .orm file
        /// </param>
        internal void ReadXml(XmlReader reader)
        {
        }
    }
}
