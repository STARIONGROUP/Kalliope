﻿// -------------------------------------------------------------------------------------------------
// <copyright file="PartialConstraintRoleSequenceJoinPathProjectionError.cs" company="Starion Group S.A.">
//
//   Copyright 2022-2024 Starion Group S.A.
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
    /// A constraint role sequence join path projection must project on every role in the sequence
    /// </summary>
    [Description("A constraint role sequence join path projection must project on every role in the sequence")]
    [Domain(isAbstract: false, general: "ModelError")]
    public class PartialConstraintRoleSequenceJoinPathProjectionError : ModelError
    {
    }
}
