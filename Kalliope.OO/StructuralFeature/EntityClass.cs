// -------------------------------------------------------------------------------------------------
// <copyright file="ClassEntity.cs" company="RHEA System S.A.">
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
    using Kalliope.Core;

    /// <summary>
    /// Base class for a Class
    /// </summary>
    public class EntityClass : Class
    {
        /// <summary>
        /// Creates a new instance of the <see cref="Class"/> class
        /// </summary>
        /// <param name="ormModel">The <see cref="OrmModel"/></param>
        /// <param name="objectType">The <see cref="EntityType"/></param>
        public EntityClass(OrmModel ormModel, ObjectType objectType) : base(ormModel, objectType)
        {
        }

        /// <summary>
        /// Initializes this class
        /// </summary>
        protected override void Initialize()
        {
            if (!this.IsObjectified)
            {
                this.TryAddProperties();
            }
        }
    }
}
