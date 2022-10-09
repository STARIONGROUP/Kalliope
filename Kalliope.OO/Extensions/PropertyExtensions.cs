// -------------------------------------------------------------------------------------------------
// <copyright file="PropertyExtensions.cs" company="RHEA System S.A.">
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

namespace Kalliope.OO.Extensions
{
    using System.Collections.Generic;
    using System.Linq;

    using Kalliope.OO.StructuralFeature;

    /// <summary>
    /// <see cref="IProperty"/> extension methods
    /// </summary>
    public static class PropertyExtensions
    {
        /// <summary>
        /// Returns a <see cref="List{T}"/> of type <see cref="IProperty"/> that contains all properties except the UUID Primary Key properties
        /// </summary>
        /// <param name="properties">
        /// The input <see cref="List{T}"/> of type <see cref="IProperty"/>
        /// </param>
        /// <returns>
        /// Returns a filtered <see cref="List{T}"/> of type <see cref="IProperty"/>
        /// </returns>
        public static List<IProperty> WithoutGuidIdentifier(this List<IProperty> properties)
        {
            return properties.Where(x => !x.Name.EndsWith("UUID")).ToList();
        }
    }
}
