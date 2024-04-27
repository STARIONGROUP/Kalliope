﻿// -------------------------------------------------------------------------------------------------
// <copyright file="PathObjectUnifier.cs" company="Starion Group S.A.">
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

using System.Collections.Generic;

namespace Kalliope.Core
{
    using Kalliope.Common;

    /// <summary>
    /// A unification indicating that pathed roles and path roots that are not naturally connected refer to the same object type
    /// </summary>
    [Description("A unification indicating that pathed roles and path roots that are not naturally connected refer to the same object type")]
    [Domain(isAbstract: false, general: "OrmModelElement")]
    [Container(typeName: "LeadRolePath", propertyName: "ObjectUnifiers")]
    public class PathObjectUnifier : OrmModelElement
    {
        /// <summary>
        /// Gets or sets the owned <see cref="PathObjectUnifierRequiresCompatibleObjectTypesError"/>
        /// </summary>
        [Description("")]
        [Property(name: "CompatibilityError", aggregation: AggregationKind.Composite, multiplicity: "0..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "PathObjectUnifierRequiresCompatibleObjectTypesError")]
        public PathObjectUnifierRequiresCompatibleObjectTypesError CompatibilityError { get; set; }
    }
}
