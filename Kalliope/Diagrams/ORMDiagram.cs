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

    using Kalliope.Core;

    /// <summary>
    /// A diagram that represents items contained by an <see cref="ORMModel"/>
    /// </summary>
    public class ORMDiagram
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
        /// Gets or sets the unique identifier
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the human readable name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the name of the base font
        /// </summary>
        public  string BaseFontName { get; set; }

        /// <summary>
        /// Gets or sets the size of the base font
        /// </summary>
        public double BaseFontSize { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this a complete view or not
        /// </summary>
        public bool IsCompleteView { get; set; }

        /// <summary>
        /// Gets or sets a value whether the shapes should be automatically populated
        /// </summary>
        /// <remarks>
        /// If this is set to true, then all shapes in the model will be loaded onto this diagram when the diagram is first loaded.
        /// AutoPopulateShapes is never written, but is useful for importing models with no diagram information
        /// </remarks>
        public bool AutoPopulateShapes { get; set; }

        /// <summary>
        /// Gets or sets the contained <see cref="ObjectTypeShape"/>
        /// </summary>
        public List<ObjectTypeShape> ObjectTypeShapes { get; set; }

        /// <summary>
        /// Gets or sets the contained <see cref="FactTypeShape"/>
        /// </summary>
        public List<FactTypeShape> FactTypeShapes { get; set; }

        /// <summary>
        /// Gets or sets the contained <see cref="ExternalConstraintShape"/>
        /// </summary>
        public List<ExternalConstraintShape> ExternalConstraintShapes { get; set; }

        /// <summary>
        /// Gets or sets the contained <see cref="FrequencyConstraintShape"/>
        /// </summary>
        public List<FrequencyConstraintShape> FrequencyConstraintShapes { get; set; }

        /// <summary>
        /// Gets or sets the contained <see cref="RingConstraintShape"/>
        /// </summary>
        public List<RingConstraintShape> RingConstraintShapes { get; set; }

        /// <summary>
        /// Gets or sets the contained <see cref="ValueComparisonConstraintShape"/>
        /// </summary>
        public List<ValueComparisonConstraintShape> ValueComparisonConstraintShapes { get; set; }

        /// <summary>
        /// Gets or sets the contained <see cref="ModelNoteShape"/>
        /// </summary>
        public List<ModelNoteShape> ModelNoteShapes { get; set; }
    }
}
