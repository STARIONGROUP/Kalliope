// -------------------------------------------------------------------------------------------------
// <copyright file="ExclusionConstraintXmlReader.cs" company="RHEA System S.A.">
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
    /// The purpose of the <see cref="ExclusionConstraintXmlReader"/> is to deserialize a <see cref="ExclusionConstraint"/>
    /// from an .orm XML file
    /// </summary>
    public class ExclusionConstraintXmlReader : SetComparisonConstraintXmlReader
    {
        /// <summary>
        /// Reads the properties of the provided <see cref="ExclusionConstraint"/> from the <see cref="XmlReader"/>
        /// </summary>
        /// <param name="exclusionConstraint">
        /// The subject <see cref="ExclusionConstraint"/> that is to be deserialized
        /// </param>
        /// <param name="reader">
        /// The <see cref="XmlReader"/> that contains the .orm XML
        /// </param>
        /// <param name="modelThings">
        /// a list of <see cref="ModelThing"/>s to which the deserialized items are added
        /// </param>
        public void ReadXml(ExclusionConstraint exclusionConstraint, XmlReader reader, List<ModelThing> modelThings)
        {
            base.ReadXml(exclusionConstraint, reader, modelThings);
        }
    }
}
