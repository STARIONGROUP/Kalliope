// -------------------------------------------------------------------------------------------------
// <copyright file="ReferenceModeKind.cs" company="RHEA System S.A.">
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
    /// Setting for a specific kind of reference mode pattern
    /// </summary>
    [Description("")]
    [Domain(isAbstract: false, general: "ORMModelElement")]
    [Container(typeName: "ORMModel", propertyName: "ReferenceModeKinds")]
    public class ReferenceModeKind : ORMModelElement
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReferenceModeKind"/> class
        /// </summary>
        /// <param name="model">
        /// The <see cref="ORMModel"/> that contains the current <see cref="ReferenceMode"/>
        /// </param>
        public ReferenceModeKind(ORMModel model)
        {
            this.ReferenceModeType = ReferenceModeType.General;

            this.Model = model;
            model.ReferenceModeKinds.Add(this);
        }

        /// <summary>
        /// Gets or sets the container <see cref="ORMModel"/>
        /// </summary>
        public ORMModel Model { get; set; }

        /// <summary>
        /// A string with replacement fields representing a custom format for a value type name based on the entity type name (replacement field {0}) 
        /// and reference mode name (replacement field {1}). Given an entity type name and a value type name, reference mode FormatStrings are used to 
        /// determine the associated reference mode and reference mode kind
        /// </summary>
        [Description("Default format string for reference mode patterns with this ReferenceModeKind. Replacement field {0}=EntityTypeName, {1}=ReferenceModeName")]
        [Property(name: "FormatString", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.String, defaultValue: "", typeName: "")]
        public string FormatString { get; set; }

        /// <summary>
        /// One of Popular, UnitBased, or General
        /// </summary>
        [Description("One of Popular, UnitBased, or General")]
        [Property(name: "ReferenceModeType", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Enumeration, defaultValue: "General", typeName: "ReferenceModeType")]
        public ReferenceModeType ReferenceModeType { get; set; }
    }
}
