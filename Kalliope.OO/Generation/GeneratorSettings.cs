// -------------------------------------------------------------------------------------------------
// <copyright file="GeneratorSettings.cs" company="Starion Group S.A.">
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

namespace Kalliope.OO.Generation
{
    using System.Collections.Generic;

    using Kalliope.OO.Mappers;
    using Kalliope.OO.StructuralFeature;

    /// <summary>
    /// A class that has settings to be used during generation of <see cref="Class"/>es and <see cref="IProperty"/>a
    /// </summary>
    public class GeneratorSettings
    {
        /// <summary>
        /// Gets of sets a value indicating that Entity name prefixes should be added to properties that don't have an explicitly set Role Name
        /// </summary>
        public bool AddEntityPrefixesForNonExplicitlyNamedRoles { get; set; } = true;

        /// <summary>
        /// The <see cref="IDataTypeMapper"/> to be used to define datatypes
        /// </summary>
        public IDataTypeMapper DataTypeMapper { get; set; } = new CSharpDataTypeMapper();

        /// <summary>
        /// Gets or sets a list of reserved words that don't need to be re capitalized
        /// </summary>
        public List<string> ReservedWords = new ();
    }
}
