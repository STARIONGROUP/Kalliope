// -------------------------------------------------------------------------------------------------
// <copyright file="Expression.cs" company="RHEA System S.A.">
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

    [Description("")]
    [Domain(isAbstract: true, general: "OrmModelElement")]
    public abstract class Expression : OrmModelElement
    {
        /// <summary>
        /// Gets or sets the Body text of the <see cref="Expression"/>
        /// </summary>
        [Description("")]
        [Property(name: "Body", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.String, defaultValue: "", typeName: "")]
        public string Body { get; set; }

        /// <summary>
        /// Gets or sets the Language of the <see cref="Expression"/>
        /// </summary>
        [Description("")]
        [Property(name: "Language", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.String, defaultValue: "", typeName: "")]
        public string Language { get; set; }
    }
}
