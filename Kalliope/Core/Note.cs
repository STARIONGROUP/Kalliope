// -------------------------------------------------------------------------------------------------
// <copyright file="Note.cs" company="RHEA System S.A.">
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

namespace Kalliope.Core
{
    using Kalliope.Common;

    /// <summary>
    /// A note for the containing element
    /// </summary>
    [Description("A note for the containing element")]
    [Domain(isAbstract: false, general: "OrmModelElement")]
    [Container(typeName: "CardinalityConstraint", propertyName: "Note")]
    [Container(typeName: "ElementGrouping", propertyName: "Note")]
    [Container(typeName: "FactType", propertyName: "Note")]
    [Container(typeName: "LeadRolePath", propertyName: "Note")]
    [Container(typeName: "ObjectType", propertyName: "Note")]
    [Container(typeName: "OrmModel", propertyName: "Note")]
    [Container(typeName: "SetComparisonConstraint", propertyName: "Note")]
    [Container(typeName: "SetConstraint", propertyName: "Note")]
    [Container(typeName: "ValueConstraint", propertyName: "Note")]
    public class Note : OrmModelElement
    {
        /// <summary>
        /// Plain text note
        /// </summary>
        [Description("The note contents")]
        [Property(name: "Text", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.String, defaultValue: "", typeName: "")]
        public string Text { get; set; }
    }
}
