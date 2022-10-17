// -------------------------------------------------------------------------------------------------
// <copyright file="Hierarchy.cs" company="RHEA System S.A.">
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

namespace Kalliope.Absorption
{
    using Kalliope.Common;
    using Kalliope.Core;

    [Description("")]
    [Domain(isAbstract: false, general: "OrmNamedElement")]
    public class Hierarchy : OrmNamedElement
    {
        /// <summary>
        /// Gets or sets the XmlNamespace
        /// </summary>
        [Description("Gets or sets the XmlNamespace")]
        [Property(name: "XmlNamespace", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.String, defaultValue: "")]
        public string XmlNamespace { get; set; }

        /// <summary>
        /// Gets or sets the XmlPrefix
        /// </summary>
        [Description("Gets or sets the XmlPrefix")]
        [Property(name: "XmlPrefix", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.String, defaultValue: "")]
        public string XmlPrefix { get; set; }

        /// <summary>
        /// Gets or sets the SchemaFileTag
        /// </summary>
        [Description("Gets or sets the SchemaFileTag")]
        [Property(name: "SchemaFileTag", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.String, defaultValue: "")]
        public string SchemaFileTag { get; set; }

        /// <summary>
        /// Gets or sets the RootElementName
        /// </summary>
        [Description("Gets or sets the RootElementName")]
        [Property(name: "RootElementName", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.String, defaultValue: "")]
        public string RootElementName { get; set; }

        /// <summary>
        /// Gets or sets the ReferenceTypeSuffix
        /// </summary>
        [Description("Gets or sets the ReferenceTypeSuffix")]
        [Property(name: "ReferenceTypeSuffix", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.String, defaultValue: "")]
        public string ReferenceTypeSuffix { get; set; }

        /// <summary>
        /// Gets or sets the ReferenceTypeSuffix
        /// </summary>
        [Description("Gets or sets the DataValueName")]
        [Property(name: "DataValueName", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.String, defaultValue: "")]
        public string DataValueName { get; set; }
    }
}
