﻿// -------------------------------------------------------------------------------------------------
// <copyright file="ValueConstraintShape.cs" company="RHEA System S.A.">
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
    using Kalliope.Core;

    /// <summary>
    /// Shape that represents a <see cref="RoleValueConstraint"/> or a <see cref="ValueTypeValueConstraint"/>
    /// </summary>
    public class ValueConstraintShape : FloatingTextShape
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ValueConstraintShape"/> class
        /// </summary>
        public ValueConstraintShape()
        {
            this.MaximumDisplayedValues = 0;
            this.MaximumDisplayedColumns = 0;
        }

        /// <summary>
        /// Gets or sets the <see cref="ValueConstraint"/> that is represented by the shape
        /// </summary>
        public ValueConstraint Subject { get; set; }

        /// <summary>
        /// The maximum total number of values and ranges to be displayed with this shape
        /// </summary>
        public int MaximumDisplayedValues { get; set; }

        /// <summary>
        /// The maximum number of columns to be used to display the values and ranges in this shape
        /// </summary>
        public int MaximumDisplayedColumns { get; set; }
    }
}
