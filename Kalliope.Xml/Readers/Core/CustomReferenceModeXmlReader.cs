﻿// -------------------------------------------------------------------------------------------------
// <copyright file="CustomReferenceModeXmlReader.cs" company="Starion Group S.A.">
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
    /// The purpose of the <see cref="CustomReferenceModeXmlReader"/> is to deserialize a <see cref="CustomReferenceMode"/>
    /// from an .orm XML file
    /// </summary>
    public class CustomReferenceModeXmlReader : ReferenceModeXmlReader
    {
        /// <summary>
        /// Reads the properties of the provided <see cref="CustomReferenceMode"/> from the <see cref="XmlReader"/>
        /// </summary>
        /// <param name="customReferenceMode">
        /// The subject <see cref="CustomReferenceMode"/> that is to be deserialized
        /// </param>
        /// <param name="reader">
        /// The <see cref="XmlReader"/> that contains the .orm XML
        /// </param>
        /// <param name="modelThings">
        /// a list of <see cref="ModelThing"/>s to which the deserialized items are added
        /// </param>
        public void ReadXml(CustomReferenceMode customReferenceMode, XmlReader reader, List<ModelThing> modelThings)
        {
            base.ReadXml(customReferenceMode, reader, modelThings);
        }

        /// <summary>
        /// reads the CustomFormatString for the <see cref="ReferenceMode"/>
        /// </summary>
        /// <param name="referenceMode">
        /// The subject <see cref="ReferenceMode"/>
        /// </param>
        /// <param name="reader">
        /// an instance of <see cref="XmlReader"/> used to read the .orm file
        /// </param>
        public override void ReadCustomFormatString(ReferenceMode referenceMode, XmlReader reader)
        {
            var customReferenceMode = (CustomReferenceMode)referenceMode;
            customReferenceMode.CustomFormatString = string.Empty;
        }
    }
}
