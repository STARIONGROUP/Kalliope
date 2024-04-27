﻿// -------------------------------------------------------------------------------------------------
// <copyright file="JoinPathRequiredError.cs" company="Starion Group S.A.">
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
    /// The roles in a constraint role sequence span multiple fact types that are not implicitly joined
    /// </summary>
    [Description("Join Required for Multiple Fact Types")]
    [Domain(isAbstract: false, general: "ModelError")]
    [Container(typeName: "ConstraintRoleSequence", propertyName: "JoinPathRequiredError")]
    public class JoinPathRequiredError : ModelError
    {
    }
}
