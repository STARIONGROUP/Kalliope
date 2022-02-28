// -------------------------------------------------------------------------------------------------
// <copyright file="ModelErrorDisplayFilter.cs" company="RHEA System S.A.">
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
    /// Validation error display filters based on error type and category
    /// </summary>
    [Domain(isAbstract: false, general: "ModelThing")]
    [Container(typeName: "ORMModel", propertyName: "ModelErrorDisplayFilter")]
    public class ModelErrorDisplayFilter : ModelThing
    {
        [Description("")]
        [Property(name: "ExcludedCategories", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.String, defaultValue: "")]
        public string ExcludedCategories { get; set; }

        [Description("")]
        [Property(name: "IncludedErrors", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.String, defaultValue: "")]
        public string IncludedErrors { get; set; }

        [Description("")]
        [Property(name: "ExcludedErrors", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.String, defaultValue: "")]
        public string ExcludedErrors { get; set; }
    }
}
