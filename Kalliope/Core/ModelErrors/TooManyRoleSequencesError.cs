// -------------------------------------------------------------------------------------------------
// <copyright file="TooManyRoleSequencesError.cs" company="RHEA System S.A.">
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
    /// A <see cref="SetConstraint"/> has too many roles for the constraint type, or a <see cref="SetComparisonConstraint"/> has too many role sequences
    /// </summary>
    [Description("Too Many Role Sequences")]
    [Domain(isAbstract: false, general: "ModelError")]
    [Container(typeName: "SetComparisonConstraint", propertyName: "TooManyRoleSequencesError")]
    [Container(typeName: "SetConstraint", propertyName: "TooManyRoleSequencesError")]
    public class TooManyRoleSequencesError : ModelError
    {
    }
}
