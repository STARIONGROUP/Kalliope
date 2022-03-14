// -------------------------------------------------------------------------------------------------
// <copyright file="ModelThing.cs" company="RHEA System S.A.">
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
    /// Abstract super type from which all Kalliope Core classes derive
    /// </summary>
    /// <remarks>
    /// The <see cref="ModelThing"/> class is not a present in the ORM DSL nor in the XML Schema
    /// but is a class added to the library for convenience
    /// </remarks>
    [Description("Abstract super type from which all Kalliope Core classes derive")]
    [Domain(isAbstract: true, general: "")]
    public abstract class ModelThing
    {
        /// <summary>
        /// A unique identifier for this element
        /// </summary>
        [Description("A unique identifier for this element")]
        [Property(name: "Id", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.String, defaultValue: "")]
        public virtual string Id { get; set; }
    }
}
