// -------------------------------------------------------------------------------------------------
// <copyright file="ORMDiagram.cs" company="RHEA System S.A.">
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

namespace Kalliope.Diagrams
{
    using System.Collections.Generic;

    using Kalliope.Common;
    using Kalliope.Core;

    /// <summary>
    /// A diagram that represents items contained by an <see cref="ORMModel"/>
    /// </summary>
    [Description("")]
    [Domain(isAbstract: false, general: "ModelThing")]
    public class ORMDiagram : ModelThing
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ORMDiagram"/>
        /// </summary>
        public ORMDiagram()
        {
            this.ObjectTypeShapes = new List<ObjectTypeShape>();
            this.FactTypeShapes = new List<FactTypeShape>();
            this.ExternalConstraintShapes = new List<ExternalConstraintShape>();
            this.FrequencyConstraintShapes = new List<FrequencyConstraintShape>();
            this.RingConstraintShapes = new List<RingConstraintShape>();
            this.ValueComparisonConstraintShapes = new List<ValueComparisonConstraintShape>();
            this.ModelNoteShapes = new List<ModelNoteShape>();
        }

        /// <summary>
        /// Gets or sets the subject <see cref="ORMModel"/> that is represented by this shape
        /// </summary>
        [Description("The subject ORMModel that is represented by this Diagram")]
        [Property(name: "Subject", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "ORMModel")]
        public ORMModel Subject { get; set; }
        
        /// <summary>
        /// Gets or sets the human readable name
        /// </summary>
        [Description("")]
        [Property(name: "Name", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.String, defaultValue: "", typeName: "")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the name of the base font
        /// </summary>
        [Description("")]
        [Property(name: "BaseFontName", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.String, defaultValue: "", typeName: "")]
        public string BaseFontName { get; set; }

        /// <summary>
        /// Gets or sets the size of the base font
        /// </summary>
        [Description("")]
        [Property(name: "BaseFontSize", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Double, defaultValue: "", typeName: "")]
        public double BaseFontSize { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this a complete view or not
        /// </summary>
        [Description("")]
        [Property(name: "IsCompleteView", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Boolean, defaultValue: "false", typeName: "")]
        public bool IsCompleteView { get; set; }

        /// <summary>
        /// Gets or sets a value whether the shapes should be automatically populated
        /// </summary>
        /// <remarks>
        /// If this is set to true, then all shapes in the model will be loaded onto this diagram when the diagram is first loaded.
        /// AutoPopulateShapes is never written, but is useful for importing models with no diagram information
        /// </remarks>
        [Description("If this is set to true, then all shapes in the model will be loaded onto this diagram when the diagram is first loaded. AutoPopulateShapes is never written, but is useful for importing models with no diagram information")]
        [Property(name: "AutoPopulateShapes", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Boolean, defaultValue: "false", typeName: "")]
        public bool AutoPopulateShapes { get; set; }

        /// <summary>
        /// Gets or sets the contained <see cref="ObjectTypeShape"/>
        /// </summary>
        [Description("")]
        [Property(name: "ObjectTypeShapes", aggregation: AggregationKind.Composite, multiplicity: "0..*", typeKind: TypeKind.Object, defaultValue: "", typeName: "ObjectTypeShape")]
        public List<ObjectTypeShape> ObjectTypeShapes { get; set; }

        /// <summary>
        /// Gets or sets the contained <see cref="FactTypeShape"/>
        /// </summary>
        [Description("")]
        [Property(name: "FactTypeShapes", aggregation: AggregationKind.Composite, multiplicity: "0..*", typeKind: TypeKind.Object, defaultValue: "", typeName: "FactTypeShape")]
        public List<FactTypeShape> FactTypeShapes { get; set; }

        /// <summary>
        /// Gets or sets the contained <see cref="ExternalConstraintShape"/>
        /// </summary>
        [Description("")]
        [Property(name: "ExternalConstraintShapes", aggregation: AggregationKind.Composite, multiplicity: "0..*", typeKind: TypeKind.Object, defaultValue: "", typeName: "ExternalConstraintShape")]
        public List<ExternalConstraintShape> ExternalConstraintShapes { get; set; }

        /// <summary>
        /// Gets or sets the contained <see cref="FrequencyConstraintShape"/>
        /// </summary>
        [Description("")]
        [Property(name: "FrequencyConstraintShapes", aggregation: AggregationKind.Composite, multiplicity: "0..*", typeKind: TypeKind.Object, defaultValue: "", typeName: "FrequencyConstraintShape")]
        public List<FrequencyConstraintShape> FrequencyConstraintShapes { get; set; }

        /// <summary>
        /// Gets or sets the contained <see cref="RingConstraintShape"/>
        /// </summary>
        [Description("")]
        [Property(name: "RingConstraintShapes", aggregation: AggregationKind.Composite, multiplicity: "0..*", typeKind: TypeKind.Object, defaultValue: "", typeName: "RingConstraintShape")]
        public List<RingConstraintShape> RingConstraintShapes { get; set; }

        /// <summary>
        /// Gets or sets the contained <see cref="ValueComparisonConstraintShape"/>
        /// </summary>
        [Description("")]
        [Property(name: "ValueComparisonConstraintShapes", aggregation: AggregationKind.Composite, multiplicity: "0..*", typeKind: TypeKind.Object, defaultValue: "", typeName: "ValueComparisonConstraintShape")]
        public List<ValueComparisonConstraintShape> ValueComparisonConstraintShapes { get; set; }

        /// <summary>
        /// Gets or sets the contained <see cref="ModelNoteShape"/>
        /// </summary>
        [Description("")]
        [Property(name: "ModelNoteShapes", aggregation: AggregationKind.Composite, multiplicity: "0..*", typeKind: TypeKind.Object, defaultValue: "", typeName: "ModelNoteShape")]
        public List<ModelNoteShape> ModelNoteShapes { get; set; }
    }
}
