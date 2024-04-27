// -------------------------------------------------------------------------------------------------
// <copyright file="QueryBase.cs" company="Starion Group S.A.">
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
    using System.Collections.Generic;

    using Kalliope.Common;

    /// <summary>
    /// A query representation based on a fact type structure. Queries support parameterization and do not need readings
    /// </summary>
    [Description("A query representation based on a fact type structure. Queries support parameterization and do not need readings")]
    [Domain(isAbstract: true, general: "FactType")]
    public abstract class QueryBase : FactType
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QueryBase"/> class
        /// </summary>
        protected QueryBase()
        {
            this.Parameters = new List<QueryParameter>();
        }

        /// <summary>
        /// Gets or sets the contained <see cref="QueryParameter"/>s
        /// </summary>
        [Description("")]
        [Property(name: "Parameters", aggregation: AggregationKind.Composite, multiplicity: "0..*", typeKind: TypeKind.Object, defaultValue: "", typeName: "QueryParameter")]
        public List<QueryParameter> Parameters { get; set; }
    }
}
