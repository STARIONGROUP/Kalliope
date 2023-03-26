// -------------------------------------------------------------------------------------------------
// <copyright file="CustomPropertyDataType.cs" company="RHEA System S.A.">
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

namespace Kalliope.Common
{
    /// <summary>
    /// List of data types
    /// </summary>
    [Description("List of data types")]
    public enum CustomPropertyDataType
    {
        String = 0,

        Integer = 1,

        Decimal = 2,

        DateTime = 3,

        CustomEnumeration = 4
    }
}
