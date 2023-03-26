// -------------------------------------------------------------------------------------------------
// <copyright file="CalculatedPathValueRequiresFunctionError.cs" company="RHEA System S.A.">
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

namespace Kalliope.Core
{
    using Kalliope.Common;

    /// <summary>
    /// A calculated value in a role path must have a function specified to perform the calculation
    /// </summary>
    [Description("A calculation is specified but does not have an associated function")]
    [Domain(isAbstract: false, general: "ModelError")]
    [Container(typeName: "CalculatedPathValue", propertyName: "FunctionRequiredError")]
    public class CalculatedPathValueRequiresFunctionError : ModelError
    {
    }
}
