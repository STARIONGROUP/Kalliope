// -------------------------------------------------------------------------------------------------
// <copyright file="AttributeFinder.cs" company="RHEA System S.A.">
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

namespace Kalliope.Generator.Helpers
{
    using System.Collections.Generic;
    using System.Xml;
    
    /// <summary>
    /// The purpose of the <see cref="AttributeFinder"/> is to print all the attributes of a kind of XmlNode
    /// </summary>
    public class AttributeFinder
    {
        /// <summary>
        /// Gets the names of all the xml attributes of the xml elements with the specified nodeName
        /// </summary>
        /// <param name="nodeName">
        /// The name of the xml element of interest
        /// </param>
        /// <param name="filePath">
        /// the path to the xml document
        /// </param>
        /// <returns></returns>
        public IEnumerable<string> Attributes(string nodeName, string filePath)
        {
            var xmlDocument = new XmlDocument();
            xmlDocument.Load(filePath);

            var attributeNames = new List<string>();

            var nodes = xmlDocument.GetElementsByTagName(nodeName);

            foreach (XmlNode node in nodes)
            {
                foreach (XmlAttribute attribute in node.Attributes)      
                {
                    if (!attributeNames.Contains(attribute.Name))
                    {
                        attributeNames.Add(attribute.Name);
                    }
                }
            }
            
            attributeNames.Sort();

            return attributeNames;
        }
    }
}
