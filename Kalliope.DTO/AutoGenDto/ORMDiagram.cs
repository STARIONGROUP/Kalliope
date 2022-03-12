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
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
 
namespace Kalliope.DTO
{
    using System;
    using System.Collections.Generic;
 
    using Kalliope.Common;
 
    /// <summary>
    /// A Data Transfer Object that represents a ORMDiagram
    /// </summary>
    public partial class ORMDiagram : ModelThing
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ORMDiagram"/> class.
        /// </summary>
        public ORMDiagram()
        {
            this.ExternalConstraintShapes = new List<string>();
            this.FactTypeShapes = new List<string>();
            this.FrequencyConstraintShapes = new List<string>();
            this.ModelNoteShapes = new List<string>();
            this.ObjectTypeShapes = new List<string>();
            this.RingConstraintShapes = new List<string>();
            this.ValueComparisonConstraintShapes = new List<string>();
        }
 

        /// <summary>
        /// Gets or sets a AutoPopulateShapes
        /// </summary>
        [Description("If this is set to true, then all shapes in the model will be loaded onto this diagram when the diagram is first loaded. AutoPopulateShapes is never written, but is useful for importing models with no diagram information")]
        [Property(name: "AutoPopulateShapes", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Boolean, defaultValue: "false", typeName: "")]
        public bool AutoPopulateShapes { get; set; }
 
        /// <summary>
        /// Gets or sets a BaseFontName
        /// </summary>
        [Description("")]
        [Property(name: "BaseFontName", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.String, defaultValue: "", typeName: "")]
        public string BaseFontName { get; set; }
 
        /// <summary>
        /// Gets or sets a BaseFontSize
        /// </summary>
        [Description("")]
        [Property(name: "BaseFontSize", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Double, defaultValue: "", typeName: "")]
        public double BaseFontSize { get; set; }
 
        /// <summary>
        /// Gets or sets a list unique identifiers of the contained <see cref="ExternalConstraintShape"/> instances
        /// </summary>
        [Description("")]
        [Property(name: "ExternalConstraintShapes", aggregation: AggregationKind.Composite, multiplicity: "0..*", typeKind: TypeKind.Object, defaultValue: "", typeName: "ExternalConstraintShape")]
        public List<string> ExternalConstraintShapes { get; set; }
 
        /// <summary>
        /// Gets or sets a list unique identifiers of the contained <see cref="FactTypeShape"/> instances
        /// </summary>
        [Description("")]
        [Property(name: "FactTypeShapes", aggregation: AggregationKind.Composite, multiplicity: "0..*", typeKind: TypeKind.Object, defaultValue: "", typeName: "FactTypeShape")]
        public List<string> FactTypeShapes { get; set; }
 
        /// <summary>
        /// Gets or sets a list unique identifiers of the contained <see cref="FrequencyConstraintShape"/> instances
        /// </summary>
        [Description("")]
        [Property(name: "FrequencyConstraintShapes", aggregation: AggregationKind.Composite, multiplicity: "0..*", typeKind: TypeKind.Object, defaultValue: "", typeName: "FrequencyConstraintShape")]
        public List<string> FrequencyConstraintShapes { get; set; }
 
        /// <summary>
        /// Gets or sets a Id
        /// </summary>
        [Description("")]
        [Property(name: "Id", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.String, defaultValue: "", typeName: "")]
        public string Id { get; set; }
 
        /// <summary>
        /// Gets or sets a IsCompleteView
        /// </summary>
        [Description("")]
        [Property(name: "IsCompleteView", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Boolean, defaultValue: "false", typeName: "")]
        public bool IsCompleteView { get; set; }
 
        /// <summary>
        /// Gets or sets a list unique identifiers of the contained <see cref="ModelNoteShape"/> instances
        /// </summary>
        [Description("")]
        [Property(name: "ModelNoteShapes", aggregation: AggregationKind.Composite, multiplicity: "0..*", typeKind: TypeKind.Object, defaultValue: "", typeName: "ModelNoteShape")]
        public List<string> ModelNoteShapes { get; set; }
 
        /// <summary>
        /// Gets or sets a Name
        /// </summary>
        [Description("")]
        [Property(name: "Name", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.String, defaultValue: "", typeName: "")]
        public string Name { get; set; }
 
        /// <summary>
        /// Gets or sets a list unique identifiers of the contained <see cref="ObjectTypeShape"/> instances
        /// </summary>
        [Description("")]
        [Property(name: "ObjectTypeShapes", aggregation: AggregationKind.Composite, multiplicity: "0..*", typeKind: TypeKind.Object, defaultValue: "", typeName: "ObjectTypeShape")]
        public List<string> ObjectTypeShapes { get; set; }
 
        /// <summary>
        /// Gets or sets a list unique identifiers of the contained <see cref="RingConstraintShape"/> instances
        /// </summary>
        [Description("")]
        [Property(name: "RingConstraintShapes", aggregation: AggregationKind.Composite, multiplicity: "0..*", typeKind: TypeKind.Object, defaultValue: "", typeName: "RingConstraintShape")]
        public List<string> RingConstraintShapes { get; set; }
 
        /// <summary>
        /// Gets or sets the unique identifier of the referenced <see cref="ORMModel"/>
        /// </summary>
        [Description("The subject ORMModel that is represented by this Diagram")]
        [Property(name: "Subject", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "ORMModel")]
        public string Subject { get; set; }
 
        /// <summary>
        /// Gets or sets a list unique identifiers of the contained <see cref="ValueComparisonConstraintShape"/> instances
        /// </summary>
        [Description("")]
        [Property(name: "ValueComparisonConstraintShapes", aggregation: AggregationKind.Composite, multiplicity: "0..*", typeKind: TypeKind.Object, defaultValue: "", typeName: "ValueComparisonConstraintShape")]
        public List<string> ValueComparisonConstraintShapes { get; set; }
 
    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
