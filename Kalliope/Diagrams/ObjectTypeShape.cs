// -------------------------------------------------------------------------------------------------
// <copyright file="ObjectTypeShape.cs" company="RHEA System S.A.">
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
    /// Shape that represents an <see cref="ObjectType"/>
    /// </summary>
    public class ObjectTypeShape : ORMBaseShape
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectTypeShape"/>
        /// </summary>
        public ObjectTypeShape()
        {
            this.DisplayRelatedTypes = RelatedTypesDisplay.AttachAllTypes;

            this.ValueConstraintShapes = new List<ValueConstraintShape>();
            this.CardinalityConstraintShapes = new List<CardinalityConstraintShape>();
        }

        /// <summary>
        /// Gets or sets the subject <see cref="ObjectType"/> that is represented by this shape
        /// </summary>
        public ObjectType Subject { get; set; }

        /// <summary>
        /// Gets or sets a value to determine whether shapes for the FactType and ValueType
        /// corresponding to this ReferenceMode pattern should be displayed on the diagram
        /// </summary>
        public bool ExpandRefMode { get; set; }

        /// <summary>
        /// Get or sets whether links to subtypes and supertypes should be attached to this shape
        /// </summary>
        public RelatedTypesDisplay DisplayRelatedTypes { get; set; }

        /// <summary>
        /// Gets or sets the relative <see cref="ValueConstraintShape"/>s
        /// </summary>
        public List<ValueConstraintShape> ValueConstraintShapes { get; set; }

        /// <summary>
        /// Gets or sets the relative <see cref="CardinalityConstraintShape"/>s
        /// </summary>
        public List<CardinalityConstraintShape> CardinalityConstraintShapes { get; set; }
    }
}
