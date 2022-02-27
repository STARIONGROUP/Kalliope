// -------------------------------------------------------------------------------------------------
// <copyright file="NMinusOneError.cs" company="RHEA System S.A.">
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
    using Kalliope.Common;

    /// <summary>
    /// An internal uniqueness constraint must span at least n minus one roles, where n is the number of roles in the fact type
    /// </summary>
    [Description("Insufficient Roles for Internal Uniqueness Constraint")]
    [Domain(isAbstract: false, general: "ModelError")]
    [Container(typeName: "UniquenessConstraint", propertyName: "NMinusOneError")]
    public class NMinusOneError : ModelError
    {
    }
}
