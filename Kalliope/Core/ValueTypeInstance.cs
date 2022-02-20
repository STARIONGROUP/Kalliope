// -------------------------------------------------------------------------------------------------
// <copyright file="ValueTypeInstance.cs" company="RHEA System S.A.">
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
    using Kalliope.Attributes;

    [Description("")]
    [Domain(isAbstract: false, general: "ObjectTypeInstance")]
    [Container(typeName: "ObjectType", propertyName: "ValueTypeInstances")]
    public class ValueTypeInstance : ObjectTypeInstance
    {
        /// <summary>
        /// The instance value
        /// </summary>
        [Description("")]
        [Property(name: "Value", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.String, defaultValue: "", typeName: "")]
        public string Value { get; set; }

        /// <summary>
        /// The culture-invariant form of the value property
        /// </summary>
        [Description("The culture-invariant form of the value property")]
        [Property(name: "InvariantValue", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.String, defaultValue: "", typeName: "")]
        public string InvariantValue { get; set; }

        /// <summary>
        /// Gets or sets the owned <see cref="CompatibleValueTypeInstanceValueError"/>
        /// </summary>
        [Description("")]
        [Property(name: "CompatibleValueTypeInstanceValueError", aggregation: AggregationKind.Composite, multiplicity: "0..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "CompatibleValueTypeInstanceValueError")]
        public CompatibleValueTypeInstanceValueError CompatibleValueTypeInstanceValueError { get; set; }
    }
}
