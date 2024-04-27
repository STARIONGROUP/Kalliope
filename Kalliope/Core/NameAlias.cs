﻿// -------------------------------------------------------------------------------------------------
// <copyright file="NameAlias.cs" company="Starion Group S.A.">
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
    using Kalliope.Common;

    /// <summary>
    /// An alternative name for the containing named element
    /// </summary>
    [Description("An alternative name for the containing named element")]
    [Domain(isAbstract: false, general: "OrmNamedElement")]
    [Container(typeName: "ObjectType", propertyName: "Abbreviations")]
    [Container(typeName: "RecognizedPhrase", propertyName: "Abbreviations")]
    public class NameAlias : OrmNamedElement
    {
        /// <summary>
        /// The type of consumer for this form of the name. NameConsumer types are provided by extension models
        /// </summary>
        [Description("")]
        [Property(name: "NameConsumer", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.String, defaultValue: "")]
        public string NameConsumer { get; set; }

        /// <summary>
        /// Additional extension-provided categorization type for how a name should be used
        /// </summary>
        [Description("")]
        [Property(name: "NameUsage", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.String, defaultValue: "")]
        public string NameUsage { get; set; }

		/// <summary>
		/// Bind an <see cref="NameAlias"/> or <see cref="NameGenerator"/> to a specific generated instance
		/// </summary>
		[Description("Bind an Alias or NameGenerator to a specific generated instance")]
		[Property(name: "RefinedInstance", aggregation: AggregationKind.None, multiplicity: "0..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "ModelThing")]
		public ModelThing RefinedInstance { get; set; }
	}
}
