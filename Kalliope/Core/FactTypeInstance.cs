// -------------------------------------------------------------------------------------------------
// <copyright file="FactTypeInstance.cs" company="RHEA System S.A.">
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
    [Domain(isAbstract: false, general: "OrmModelElement")]
    [Container(typeName: "FactType", propertyName: "FactTypeInstances")]
    public class FactTypeInstance : OrmModelElement
    {
        [Description("")]
        [Property(name: "Name", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.String, defaultValue: "", typeName: "")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the owned <see cref="ObjectifyingInstanceRequiredError"/>
        /// </summary>
        [Description("")]
        [Property(name: "ObjectifyingInstanceRequiredError", aggregation: AggregationKind.Composite, multiplicity: "0..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "ObjectifyingInstanceRequiredError")]
        public ObjectifyingInstanceRequiredError ObjectifyingInstanceRequiredError { get; set; }

        /// <summary>
        /// Gets or sets the owned <see cref="TooFewFactTypeRoleInstancesError"/>
        /// </summary>
        [Description("")]
        [Property(name: "TooFewFactTypeRoleInstancesError", aggregation: AggregationKind.Composite, multiplicity: "0..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "TooFewFactTypeRoleInstancesError")]
        public TooFewFactTypeRoleInstancesError TooFewFactTypeRoleInstancesError { get; set; }

        /// <summary>
        /// Gets or sets the referenced <see cref="ObjectTypeInstance"/>
        /// </summary>
        [Description("")]
        [Property(name: "ObjectifyingInstance", aggregation: AggregationKind.None, multiplicity: "0..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "ObjectTypeInstance")]
        public ObjectTypeInstance ObjectifyingInstance { get; set; }
    }
}
