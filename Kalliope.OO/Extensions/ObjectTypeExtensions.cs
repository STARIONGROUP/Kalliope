// -------------------------------------------------------------------------------------------------
// <copyright file="ObjectTypeExtensions.cs" company="RHEA System S.A.">
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

namespace Kalliope.OO.Extensions
{
    using System.Linq;

    using Kalliope.Core;

    /// <summary>
    /// <see cref="ObjectTypeExtensions"/> extension methods
    /// </summary>
    public static class ObjectTypeExtensions
    {
        /// <summary>
        /// Returns a value indicating if an <see cref="ObjectType"/> represents an enumeration
        /// </summary>
        /// <param name="objectType">
        /// The <see cref="ObjectType"/>
        /// </param>
        /// <param name="model">
        /// The <see cref="OrmModel"/> in which the datatypes are stored</param>
        /// <returns>
        /// Returns true if an ObjectType represents an enumeration
        /// </returns>
        public static bool IsEnum(this ObjectType objectType, OrmModel model)
        {
            if (objectType is ValueType valueType 
                && valueType.ValueConstraint?.ValueRanges.Count > 0 
                && !valueType.IsImplicitBooleanValue)
            {
                var dataTypeId = valueType.ConceptualDataType.Reference;
                var dataType = model.DataTypes.FirstOrDefault(dt => dt.Id == dataTypeId);

                return dataType is TextDataType;
            }

            return false;
        }
    }
}
