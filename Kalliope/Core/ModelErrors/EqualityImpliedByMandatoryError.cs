﻿// -------------------------------------------------------------------------------------------------
// <copyright file="EqualityImpliedByMandatoryError.cs" company="Starion Group S.A.">
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
    /// An equality constraint is implied by a mandatory constraint (Deprecated, replaced by <see cref="EqualityConstraintImpliedByMandatoryConstraintsError"/>)
    /// </summary>
    [Description("An equality constraint is implied by a mandatory constraint")]
    [Domain(isAbstract: false, general: "ModelError")]
    public class EqualityImpliedByMandatoryError : ModelError
    {
    }
}
