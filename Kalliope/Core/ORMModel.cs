// -------------------------------------------------------------------------------------------------
// <copyright file="ORMModel.cs" company="RHEA System S.A.">
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
    using System.Collections.Generic;

    using Kalliope.Common;

    using Microsoft.Extensions.Logging;
    using Microsoft.Extensions.Logging.Abstractions;

    /// <summary>
    /// Definition of elements used in the primary definition of an ORM model
    /// </summary>
    [Description("Definition of elements used in the primary definition of an ORM model")]
    [Domain(isAbstract: false, general: "ORMNamedElement")]
    public class ORMModel : ORMNamedElement
    {
        /// <summary>
        /// The (injected) <see cref="ILoggerFactory"/> used to setup logging
        /// </summary>
        private readonly ILoggerFactory loggerFactory;

        /// <summary>
        /// The <see cref="ILogger"/> used to log
        /// </summary>
        private readonly ILogger<ORMModel> logger;

        /// <summary>
        /// Initializes a new instance of the <see cref="ORMModel"/> class
        /// </summary>
        public ORMModel()
        {
            this.logger = NullLogger<ORMModel>.Instance;

            this.Definitions = new List<Definition>();
            this.ObjectTypes = new List<ObjectType>();
            this.FactTypes = new List<FactType>();
            this.DataTypes = new List<DataType>();
            this.Functions = new List<Function>();
            this.Notes = new List<ModelNote>();
            this.Errors = new List<ModelError>();
            this.ReferenceModes = new List<ReferenceMode>();
            this.ReferenceModeKinds = new List<ReferenceModeKind>();
            this.RecognizedPhrases = new List<RecognizedPhrase>();
            this.Extensions = new List<Extension>();
            this.SetConstraints = new List<SetConstraint>();
            this.SetComparisonConstraints = new List<SetComparisonConstraint>();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ORMModel"/> class.
        /// </summary>
        /// <param name="loggerFactory">
        /// The (injected) <see cref="ILoggerFactory"/> used to setup logging
        /// </param>
        internal ORMModel(ILoggerFactory loggerFactory) : this()
        {
            this.loggerFactory = loggerFactory;
            this.logger = this.loggerFactory == null ? NullLogger<ORMModel>.Instance : this.loggerFactory.CreateLogger<ORMModel>();
        }
        
        /// <summary>
        /// The value of the referenced element's unique id
        /// </summary>
        public string Reference { get; set; }

        /// <summary>
        /// Gets or sets the referenced <see cref="ReferenceModeKind"/>
        /// </summary>
        public ReferenceModeKind ReferenceModeKind { get; set; }

        /// <summary>
        /// Gets or sets the referenced <see cref="ReferenceMode"/>
        /// </summary>
        public ReferenceMode ReferenceMode { get; set; }

        /// <summary>
        /// The <see cref="Definitions"/>s contained by the <see cref="ORMModel"/>
        /// </summary>
        public List<Definition> Definitions { get; set; }
        
        /// <summary>
        /// The <see cref="ObjectType"/>s contained by the <see cref="ORMModel"/>
        /// </summary>
        [Description("")]
        [Property(name: "ObjectTypes", aggregation: AggregationKind.Composite, multiplicity: "0..*", typeKind: TypeKind.Object, defaultValue: "", typeName: "ObjectType")]
        public List<ObjectType> ObjectTypes { get; set; }

        /// <summary>
        /// The <see cref="FactType"/>s contained by the <see cref="ORMModel"/>
        /// </summary>
        [Description("")]
        [Property(name: "FactTypes", aggregation: AggregationKind.Composite, multiplicity: "0..*", typeKind: TypeKind.Object, defaultValue: "", typeName: "FactType")]
        public List<FactType> FactTypes { get; set; }

        /// <summary>
        /// The <see cref="DataType"/>s contained by the <see cref="ORMModel"/>
        /// </summary>
        [Description("")]
        [Property(name: "DataTypes", aggregation: AggregationKind.Composite, multiplicity: "0..*", typeKind: TypeKind.Object, defaultValue: "", typeName: "DataType")]
        public List<DataType> DataTypes { get; set; }

        /// <summary>
        /// The <see cref="Function"/>s contained by the <see cref="ORMModel"/>
        /// </summary>
        /// <remarks>
        /// Function definitions used for calculated role path values
        /// </remarks>
        [Description("Function definitions used for calculated role path values")]
        [Property(name: "Functions", aggregation: AggregationKind.Composite, multiplicity: "0..*", typeKind: TypeKind.Object, defaultValue: "", typeName: "Function")]
        public List<Function> Functions { get; set; }
        
        /// <summary>
        /// The <see cref="ModelNote"/>s contained by the <see cref="ORMModel"/>
        /// </summary>
        [Description("")]
        [Property(name: "Notes", aggregation: AggregationKind.Composite, multiplicity: "0..*", typeKind: TypeKind.Object, defaultValue: "", typeName: "ModelNote")]
        public List<ModelNote> Notes { get; set; }

        /// <summary>
        /// The <see cref="ModelError"/>s contained by the <see cref="ORMModel"/>
        /// </summary>
        [Description("")]
        [Property(name: "Errors", aggregation: AggregationKind.Composite, multiplicity: "0..*", typeKind: TypeKind.Object, defaultValue: "", typeName: "ModelError")]
        public List<ModelError> Errors { get; set; }

        /// <summary>
        /// The <see cref="ReferenceModeKind"/>s contained by the <see cref="ORMModel"/>
        /// </summary>
        [Description("")]
        [Property(name: "ReferenceModeKinds", aggregation: AggregationKind.Composite, multiplicity: "0..*", typeKind: TypeKind.Object, defaultValue: "", typeName: "ReferenceModeKind")]
        public List<ReferenceModeKind> ReferenceModeKinds { get; set; }

        /// <summary>
        /// Gets or sets the contained <see cref="ReferenceMode"/>s
        /// </summary>
        [Description("")]
        [Property(name: "ReferenceModes", aggregation: AggregationKind.Composite, multiplicity: "0..*", typeKind: TypeKind.Object, defaultValue: "", typeName: "ReferenceMode")]
        public List<ReferenceMode> ReferenceModes { get; set; }

        /// <summary>
        /// The <see cref="RecognizedPhrase"/>s contained by the <see cref="ORMModel"/>
        /// </summary>
        [Description("")]
        [Property(name: "RecognizedPhrases", aggregation: AggregationKind.Composite, multiplicity: "0..*", typeKind: TypeKind.Object, defaultValue: "", typeName: "RecognizedPhrase")]
        public List<RecognizedPhrase> RecognizedPhrases { get; set; }

        /// <summary>
        /// The <see cref="Extension"/>s contained by the <see cref="ORMModel"/>
        /// </summary>
        public List<Extension> Extensions { get; set; }

        /// <summary>
        /// The <see cref="SetConstraint"/>s contained by the <see cref="ORMModel"/>
        /// </summary>
        [Description("")]
        [Property(name: "SetConstraints", aggregation: AggregationKind.Composite, multiplicity: "0..*", typeKind: TypeKind.Object, defaultValue: "", typeName: "SetConstraint")]
        public List<SetConstraint> SetConstraints { get; set; }

        /// <summary>
        /// The <see cref="SetComparisonConstraint"/>s contained by the <see cref="ORMModel"/>
        /// </summary>
        [Description("")]
        [Property(name: "SetComparisonConstraints", aggregation: AggregationKind.Composite, multiplicity: "0..*", typeKind: TypeKind.Object, defaultValue: "", typeName: "SetComparisonConstraint")]
        public List<SetComparisonConstraint> SetComparisonConstraints { get; set; }

        /// <summary>
        /// Gets or sets the owned <see cref="Definition"/>
        /// </summary>
        [Description("")]
        [Property(name: "Definition", aggregation: AggregationKind.Composite, multiplicity: "0..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "Definition")]
        public Definition Definition { get; set; }

        /// <summary>
        /// Gets or sets the owned <see cref="Note"/>
        /// </summary>
        [Description("")]
        [Property(name: "Note", aggregation: AggregationKind.Composite, multiplicity: "0..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "Note")]
        public Note Note { get; set; }

        /// <summary>
        /// Gets or sets the owned <see cref="ModelErrorDisplayFilter"/>
        /// </summary>
        [Description("")]
        [Property(name: "ModelErrorDisplayFilter", aggregation: AggregationKind.Composite, multiplicity: "0..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "ModelErrorDisplayFilter")]
        [Ignore(description: "The ModelErrorDisplayFilter class does not have an Id property. This class is most likely tool specific (display oriented) and is therefore ignored")]
        public ModelErrorDisplayFilter ModelErrorDisplayFilter { get; set; }
    }
}
