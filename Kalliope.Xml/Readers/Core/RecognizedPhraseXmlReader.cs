// -------------------------------------------------------------------------------------------------
// <copyright file="RecognizedPhraseXmlReader.cs" company="Starion Group S.A.">
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

namespace Kalliope.Xml.Readers
{
	using System;
	using System.Collections.Generic;
    using System.Xml;
	using Kalliope.DTO;

	/// <summary>
	/// The purpose of the <see cref="RecognizedPhraseXmlReader"/> is to deserialize a <see cref="RecognizedPhrase"/>
	/// from an .orm XML file
	/// </summary>
    public class RecognizedPhraseXmlReader : OrmNamedElementXmlReader
    {
        /// <summary>
        /// Reads the properties of the provided <see cref="RecognizedPhrase"/> from the <see cref="XmlReader"/>
        /// </summary>
        /// <param name="recognizedPhrase">
        /// The subject <see cref="RecognizedPhrase"/> that is to be deserialized
        /// </param>
        /// <param name="reader">
        /// The <see cref="XmlReader"/> that contains the .orm XML
        /// </param>
        /// <param name="modelThings">
        /// a list of <see cref="ModelThing"/>s to which the deserialized items are added
        /// </param>
        public void ReadXml(RecognizedPhrase recognizedPhrase, XmlReader reader, List<ModelThing> modelThings)
        {
            base.ReadXml(recognizedPhrase, reader, modelThings);

			while (reader.Read())
			{
				if (reader.MoveToContent() == XmlNodeType.Element)
				{
					var localName = reader.LocalName;

					switch (localName)
					{
						case "Abbreviations":
							using (var abbreviationsSubtree = reader.ReadSubtree())
							{
								abbreviationsSubtree.MoveToContent();
								this.ReadAbbreviations(recognizedPhrase, abbreviationsSubtree, modelThings);
							}
							break;
						default:
							throw new NotSupportedException($"{localName} not yet supported");
					}
				}
			}
		}

		/// <summary>
		/// reads the contained <see cref="NameAlias"/>es
		/// </summary>
		/// <param name="recognizedPhrase">
		/// The container <see cref="RecognizedPhrase"/> of the <see cref="NameAlias"/>
		/// </param>
		/// <param name="reader">
		/// an instance of <see cref="XmlReader"/> used to read the .orm file
		/// </param>
		/// <param name="modelThings">
		/// a list of <see cref="ModelThing"/>s to which the deserialized items are added
		/// </param>
		private void ReadAbbreviations(RecognizedPhrase recognizedPhrase, XmlReader reader, List<ModelThing> modelThings)
        {
	        while (reader.Read())
	        {
		        if (reader.MoveToContent() == XmlNodeType.Element)
		        {
			        var localName = reader.LocalName;

			        switch (localName)
			        {
				        case "Alias":
					        using (var nameAliasSubtree = reader.ReadSubtree())
					        {
						        nameAliasSubtree.MoveToContent();
						        var nameAlias = new NameAlias();
						        var nameAliasXmlReader = new NameAliasXmlReader();
						        nameAliasXmlReader.ReadXml(nameAlias, nameAliasSubtree, modelThings);
						        nameAlias.Container = recognizedPhrase.Id;
						        recognizedPhrase.Abbreviations.Add(nameAlias.Id);
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
