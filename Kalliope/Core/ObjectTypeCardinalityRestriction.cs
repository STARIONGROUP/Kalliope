// -------------------------------------------------------------------------------------------------
// <copyright file="ObjectTypeCardinalityRestriction.cs" company="Starion Group S.A.">
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
	/// Restrict the size of a population of this object type
	/// </summary>
	[Description("Restrict the size of a population of this object type")]
	[Domain(isAbstract: false, general: "ModelThing")]
	[Container(typeName: "ObjectType", propertyName: "CardinalityRestriction")]
	public class ObjectTypeCardinalityRestriction : ModelThing
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="SubtypeDerivationRule"/> class
		/// </summary>
		public ObjectTypeCardinalityRestriction()
		{
		}

		/// <summary>
		/// Gets the unique identifier of the <see cref="ObjectTypeCardinalityRestriction"/>
		/// </summary>
		[Description("A unique identifier for this element")]
		[Property(name: "Id", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.String, defaultValue: "", typeName: "", allowOverride: false, isOverride: true, isDerived: true)]
		public override string Id { get; set; }
		
		/// <summary>
		/// Gets or sets the owned <see cref="CardinalityConstraint"/>
		/// </summary>
		[Description("")]
		[Property(name: "CardinalityConstraint", aggregation: AggregationKind.Composite, multiplicity: "0..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "CardinalityConstraint")]
		public CardinalityConstraint CardinalityConstraint { get; set; }
	}
}
