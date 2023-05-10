// -------------------------------------------------------------------------------------------------
// <copyright file="XmlReaderExtensions.cs" company="RHEA System S.A.">
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

namespace Kalliope.Xml.Extensions
{
    using System.Xml;

    /// <summary>
    /// Extensions for the <see cref="XmlReader"/> class
    /// </summary>
    internal static class XmlReaderExtensions
    {
        /// <summary>
        /// Proceeds an <see cref="XmlReader"/> to the next xml element based on the same hierarchical level of the currently selected xml element
        /// </summary>
        /// <param name="reader">The <see cref="XmlReader"/></param>
        internal static void RunToEndOfSubtree(this XmlReader reader)
        {
            using (var subtree = reader.ReadSubtree())
            {
                subtree.MoveToContent();

                while (subtree.Read())
                {
                    if (subtree.MoveToContent() == XmlNodeType.Element)
                    {
                        RunToEndOfSubtree(subtree);
                    }
                }
            }
        }
    }
}