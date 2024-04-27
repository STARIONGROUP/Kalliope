// -------------------------------------------------------------------------------------------------
// <copyright file="StructuralFeature.cs" company="Starion Group S.A.">
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
// -------------------------------------------------------------------------------------------------

namespace Kalliope.OO.StructuralFeature
{
    using Kalliope.OO.Generation;

    /// <summary>
    /// An abstract class from which all <see cref="StructuralFeature"/>s derive
    /// </summary>
    public abstract class StructuralFeature : IStructuralFeature
    {
        /// <summary>
        /// The <see cref="GeneratorSettings"/> to be used while generating this <see cref="StructuralFeature"/>
        /// </summary>
        protected GeneratorSettings GeneratorSettings { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="Name"/>
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="Definition"/>
        /// </summary>
        public string Definition { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="Note"/>
        /// </summary>
        public string Note { get; set; }
    }
}
