// -------------------------------------------------------------------------------------------------
// <copyright file="DisplayStateXmlReader.cs" company="RHEA System S.A.">
//
//   Copyright 2022-2023 RHEA System S.A.
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
    using Kalliope.Xml.Extensions;

    /// <summary>
    /// The purpose of the <see cref="DisplayStateXmlReader"/> is to deserialize a <see cref="DisplayState"/>
    /// from an .orm XML file
    /// </summary>
    public class DisplayStateXmlReader : ModelThingXmlReader
    {
        /// <summary>
        /// Reads the properties of the provided <see cref="DisplayState"/> from the <see cref="XmlReader"/>
        /// </summary>
        /// <param name="displayState">
        /// The subject <see cref="DisplayState"/> that is to be deserialized
        /// </param>
        /// <param name="reader">
        /// The <see cref="XmlReader"/> that contains the .orm XML
        /// </param>
        /// <param name="modelThings">
        /// a list of <see cref="ModelThing"/>s to which the deserialized items are added
        /// </param>
        public void ReadXml(DisplayState displayState, XmlReader reader, List<ModelThing> modelThings)
        {
            base.ReadXml(displayState, reader, modelThings);

            displayState.Id = reader.GetAttribute("id");

            while (reader.Read())
            {
                if (reader.MoveToContent() == XmlNodeType.Element)
                {
                    var localName = reader.LocalName;

                    switch (localName)
                    {
                        case "ORMModel":
                            displayState.Model = reader.GetAttribute("ref");
                            break;
                        case "GlobalDisplayOptions":
                            //TODO: GH42
                            Console.WriteLine($"{localName} not yet supported");
                            reader.RunToEndOfSubtree();
                            break;
                        default:
                            throw new System.NotSupportedException($"{localName} not yet supported");
                    }
                }
            }
        }
    }
}