// -------------------------------------------------------------------------------------------------
// <copyright file="CustomProperty.cs" company="RHEA System S.A.">
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

namespace Kalliope.CustomProperties
{
    using Kalliope.Common;
    using Kalliope.Core;

    /// <summary>
    /// A custom property that can be used to annotate <see cref="ModelThing"/>s
    /// </summary>
    [Description("A custom property that can be used to annotate ModelThings")]
    [Domain(isAbstract: false, general: "Extension")]
    public class CustomProperty : Extension
    {
        /// <summary>
        /// Gets or sets the value which can be of type String, Integer, Decimal, DateTime
        /// </summary>
        [Description("Gets or sets the value which can be of type String, Integer, Decimal, DateTime")]
        [Property(name: "Value", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Obj, defaultValue: "", typeName: "object")]
        public object Value { get; set; }

        /// <summary>
        /// Gets or sets the referenced <see cref="CustomPropertyDefinition"/>.
        /// </summary>
        [Description("Gets or sets the referenced CustomPropertyDefinition")]
        [Property(name: "CustomPropertyDefinition", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "CustomPropertyDefinition")]
        public CustomPropertyDefinition CustomPropertyDefinition { get; set; }
    }
}
