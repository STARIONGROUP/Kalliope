// -------------------------------------------------------------------------------------------------
// <copyright file="ObjectTypeInstance.cs" company="RHEA System S.A.">
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
    using System.Collections.Generic;

    public abstract class ObjectTypeInstance : ORMModelElement
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectTypeInstance"/> class
        /// </summary>
        protected ObjectTypeInstance()
        {
            this.PopulationMandatoryErrors = new List<PopulationMandatoryError>();
        }

        /// <summary>
        /// An ordered tuple of values for this instance, ignores objectification of the associated <see cref="ObjectType"/>
        /// </summary>
        public string IdentifierName { get; set; }

        /// <summary>
        /// Gets or sets the owned <see cref="ObjectifiedInstanceRequiredError"/>
        /// </summary>
        public ObjectifiedInstanceRequiredError ObjectifiedInstanceRequiredError { get; set; }

        /// <summary>
        /// Gets or sets the contained <see cref="PopulationMandatoryError"/>s
        /// </summary>
        public List<PopulationMandatoryError> PopulationMandatoryErrors { get; set; }
    }
}
