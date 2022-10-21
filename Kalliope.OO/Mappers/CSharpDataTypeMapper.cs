// -------------------------------------------------------------------------------------------------
// <copyright file="CSharpDataTypeMapper.cs" company="RHEA System S.A.">
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

namespace Kalliope.OO.Mappers
{
    using Kalliope.Core;

    /// <summary>
    /// The purpose of the <see cref="CSharpDataTypeMapper"/> is to map a <see cref="DataType"/> to a C# representation
    /// </summary>
    public class CSharpDataTypeMapper : IDataTypeMapper
    {
        /// <summary>
        /// Maps the ORM <see cref="DataType"/> to a C# data-type
        /// </summary>
        /// <param name="dataType">
        /// The <see cref="DataType"/> to map
        /// </param>
        /// <returns>
        /// the name of the C# data-type
        /// </returns>
        public string MapDataType(DataType dataType)
        {
            if (dataType != null)
            {
                if (dataType is TextDataType or LargeLengthRawDataDataType or ObjectIdOtherDataType or TimeTemporalDataType)
                {
                    return "string";
                }

                if (dataType is LogicalDataType)
                {
                    return "bool";
                }

                if (dataType is DateAndTimeTemporalDataType)
                {
                    return "DateTime";
                }

                if (dataType is DateTemporalDataType)
                {
                    return "Date";
                }

                if (dataType is SignedIntegerNumericDataType or UnsignedIntegerNumericDataType or AutoCounterNumericDataType)
                {
                    return "int";
                }

                if (dataType is AutoTimestampTemporalDataType or UnsignedLargeIntegerNumericDataType)
                {
                    return "long";
                }

                if (dataType is DecimalNumericDataType)
                {
                    return "decimal";
                }

                if (dataType is DoublePrecisionFloatingPointNumericDataType)
                {
                    return "double";
                }
            }

            return "Unknown type";
        }
    }
}
