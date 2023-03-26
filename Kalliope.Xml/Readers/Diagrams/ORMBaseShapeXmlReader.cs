// -------------------------------------------------------------------------------------------------
// <copyright file="OrmBaseShapeXmlReader.cs" company="RHEA System S.A.">
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
    using System.Collections.Generic;
    using System.Xml;

    using Kalliope.DTO;

    /// <summary>
    /// The purpose of the <see cref="OrmBaseShapeXmlReader"/> is to deserialize a <see cref="ORMBaseShape"/>
    /// from an .orm XML file
    /// </summary>
    public abstract class OrmBaseShapeXmlReader : ModelThingXmlReader
    {
        /// <summary>
        /// Reads the properties of the provided <see cref="ORMBaseShape"/> from the <see cref="XmlReader"/>
        /// </summary>
        /// <param name="ormBaseShape">
        /// The subject <see cref="OrmBaseShape"/> that is to be deserialized
        /// </param>
        /// <param name="reader">
        /// The <see cref="XmlReader"/> that contains the .orm XML
        /// </param>
        /// <param name="modelThings">
        /// a list of <see cref="ModelThing"/>s to which the deserialized items are added
        /// </param>
        public void ReadXml(OrmBaseShape ormBaseShape, XmlReader reader, List<ModelThing> modelThings)
        {
            base.ReadXml(ormBaseShape, reader, modelThings);

            ormBaseShape.Id = reader.GetAttribute("id");

            var isExpanded = reader.GetAttribute("IsExpanded");
            if (!string.IsNullOrEmpty(isExpanded))
            {
                ormBaseShape.IsExpanded = XmlConvert.ToBoolean(isExpanded);
            }

            ormBaseShape.AbsoluteBounds = reader.GetAttribute("AbsoluteBounds");
        }
    }
}
