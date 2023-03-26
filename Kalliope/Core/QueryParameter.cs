// -------------------------------------------------------------------------------------------------
// <copyright file="QueryParameter.cs" company="RHEA System S.A.">
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

using System.Collections.Generic;

namespace Kalliope.Core
{
    using Kalliope.Common;

    /// <summary>
    /// A parameter defined as the input for a query element
    /// </summary>
    [Description("An input parameter for a query")]
    [Domain(isAbstract: false, general: "OrmModelElement")]
    [Container(typeName: "QueryBase", propertyName: "Parameters")]
    public class QueryParameter : OrmModelElement
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QueryParameter"/> class.
        /// </summary>
        public QueryParameter()
        {
            this.PathBindings = new List<LeadRolePath>();
        }

        /// <summary>
        /// The name of the parameter
        /// </summary>
        [Description("The explicit name for this parameter")]
        [Property(name: "Name", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.String, defaultValue: "", typeName: "")]
        public string Name { get; set; }

        [Description("")]
        [Property(name: "ParameterType", aggregation: AggregationKind.None, multiplicity: "0..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "ObjectType")]
        public ObjectType ParameterType { get; set; }

        [Description("")]
        [Property(name: "PathBindings", aggregation: AggregationKind.None, multiplicity: "0..*", typeKind: TypeKind.Object, defaultValue: "", typeName: "LeadRolePath")]
        public List<LeadRolePath> PathBindings { get; set; }
    }
}
