﻿// -------------------------------------------------------------------------------------------------
// <copyright file="ModelNote.cs" company="Starion Group S.A.">
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
    /// A miscellaneous note for this model
    /// </summary>
    [Description("A miscellaneous note for this model")]
    [Domain(isAbstract: false, general: "Note")]
    [Container(typeName: "OrmModel", propertyName: "Notes")]
    public class ModelNote : Note
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ModelNote"/> class
        /// </summary>
        public ModelNote()
        {
            this.Elements = new List<OrmModelElement>();
            this.FactTypes = new List<FactType>();
            this.ObjectTypes = new List<ObjectType>();
            this.SetConstraints = new List<SetConstraint>();
            this.SetComparisonConstraints = new List<SetComparisonConstraint>();
        }

        [Description("")]
        [Property(name: "Elements", aggregation: AggregationKind.None, multiplicity: "0..*", typeKind: TypeKind.Object, defaultValue: "", typeName: "OrmModelElement")]
        public List<OrmModelElement> Elements { get; set; }

        [Description("")]
        [Property(name: "FactTypes", aggregation: AggregationKind.None, multiplicity: "0..*", typeKind: TypeKind.Object, defaultValue: "", typeName: "FactType")]
        public List<FactType> FactTypes { get; set; }

        [Description("")]
        [Property(name: "ObjectTypes", aggregation: AggregationKind.None, multiplicity: "0..*", typeKind: TypeKind.Object, defaultValue: "", typeName: "ObjectType")]
        public List<ObjectType> ObjectTypes { get; set; }

        [Description("")]
        [Property(name: "SetConstraints", aggregation: AggregationKind.None, multiplicity: "0..*", typeKind: TypeKind.Object, defaultValue: "", typeName: "SetConstraint")]
        public List<SetConstraint> SetConstraints { get; set; }

        [Description("")]
        [Property(name: "SetComparisonConstraints", aggregation: AggregationKind.None, multiplicity: "0..*", typeKind: TypeKind.Object, defaultValue: "", typeName: "SetComparisonConstraint")]
        public List<SetComparisonConstraint> SetComparisonConstraints { get; set; }
    }
}
