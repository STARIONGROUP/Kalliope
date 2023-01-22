// -------------------------------------------------------------------------------------------------
// <copyright file="ObjectTypeCardinalityConstraintXmlReader.cs" company="RHEA System S.A.">
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

namespace Kalliope.Xml.Readers
{
	using System;
	using System.Collections.Generic;
	using System.Xml;
	using Kalliope.DTO;

	/// <summary>
	/// The purpose of the <see cref="ObjectTypeCardinalityConstraintXmlReader"/> is to deserialize a <see cref="ObjectTypeCardinalityConstraint"/>
	/// from an .orm XML file
	/// </summary>
    public class ObjectTypeCardinalityConstraintXmlReader : CardinalityConstraintXmlReader
    {
		/// <summary>
		/// Reads the properties of the provided <see cref="ObjectTypeCardinalityConstraint"/> from the <see cref="XmlReader"/>
		/// </summary>
		/// <param name="objectTypeCardinalityConstraint">
		/// The subject <see cref="ObjectTypeCardinalityConstraint"/> that is to be deserialized
		/// </param>
		/// <param name="reader">
		/// The <see cref="XmlReader"/> that contains the .orm XML
		/// </param>
		/// <param name="modelThings">
		/// a list of <see cref="ModelThing"/>s to which the deserialized items are added
		/// </param>
		public void ReadXml(ObjectTypeCardinalityConstraint objectTypeCardinalityConstraint, XmlReader reader, List<ModelThing> modelThings)
	    {
		    base.ReadXml(objectTypeCardinalityConstraint, reader, modelThings);
			
			while (reader.Read())
			{
				if (reader.MoveToContent() == XmlNodeType.Element)
				{
					var localName = reader.LocalName;

					switch (localName)
					{
						case "Ranges":
							using (var rangeSubtree = reader.ReadSubtree())
							{
								rangeSubtree.MoveToContent();
								this.ReadRanges(objectTypeCardinalityConstraint, rangeSubtree, modelThings);
							}
							break;
						default:
							throw new NotSupportedException($"{localName} not yet supported");
					}
				}
			}
		}

		/// <summary>
		/// Reads <see cref="CardinalityRange"/> sequences from the .orm file
		/// </summary>
		/// <param name="objectTypeCardinalityConstraint">
		/// The <see cref="ObjectTypeCardinalityConstraint"/> that contains the <see cref="CardinalityRange"/>s
		/// </param>
		/// <param name="reader">
		/// an instance of <see cref="XmlReader"/> used to read the .orm file
		/// </param>
		private void ReadRanges(ObjectTypeCardinalityConstraint objectTypeCardinalityConstraint, XmlReader reader, List<ModelThing> modelThings)
		{
			while (reader.Read())
			{
				if (reader.MoveToContent() == XmlNodeType.Element)
				{
					var localName = reader.LocalName;

					switch (localName)
					{
						case "CardinalityRange":
							using (var cardinalityRangehSubTree = reader.ReadSubtree())
							{
								cardinalityRangehSubTree.MoveToContent();
								var cardinalityRange = new CardinalityRange();
								var cardinalityRangeXmlReader = new CardinalityRangeXmlReader();
								cardinalityRangeXmlReader.ReadXml(cardinalityRange, cardinalityRangehSubTree, modelThings);
								cardinalityRange.Container = objectTypeCardinalityConstraint.Id;
								objectTypeCardinalityConstraint.Ranges.Add(cardinalityRange.Id);
							}
							break;
						default:
							throw new NotSupportedException($"{localName} not yet supported");
					}
				}
			}
		}
	}
}
