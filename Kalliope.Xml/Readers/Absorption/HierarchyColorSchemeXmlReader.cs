// -------------------------------------------------------------------------------------------------
// <copyright file="HierarchyColorSchemeXmlReader.cs" company="Starion Group S.A.">
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
    using System.Collections.Generic;
    using System.Linq;
    using System.Xml;

    using Kalliope.DTO;

    /// <summary>
    /// The purpose of the <see cref="HierarchyColorSchemeXmlReader"/> is to deserialize a <see cref="HierarchyColorScheme"/>
    /// from an .orm XML file
    /// </summary>
    public class HierarchyColorSchemeXmlReader : ModelThingXmlReader
    {
        /// <summary>
        /// Reads the properties of the provided <see cref="HierarchyColorScheme"/> from the <see cref="XmlReader"/>
        /// </summary>
        /// <param name="hierarchyColorScheme">
        /// The subject <see cref="HierarchyColorScheme"/> that is to be deserialized
        /// </param>
        /// <param name="reader">
        /// The <see cref="XmlReader"/> that contains the .orm XML
        /// </param>
        /// <param name="modelThings">
        /// a list of <see cref="ModelThing"/>s to which the deserialized items are added
        /// </param>
        public void ReadXml(HierarchyColorScheme hierarchyColorScheme, XmlReader reader, List<ModelThing> modelThings)
        {
            base.ReadXml(hierarchyColorScheme, reader, modelThings);
            
            hierarchyColorScheme.Id = reader.GetAttribute("id");
            
            while (reader.Read())
            {
                if (reader.MoveToContent() == XmlNodeType.Element)
                {
                    var localName = reader.LocalName;

                    switch (localName)
                    {
                        case "ColorAspects":
                            using (var colorAspectsSubtree = reader.ReadSubtree())
                            {
                                colorAspectsSubtree.MoveToContent();
                                this.ReadColorAspects(hierarchyColorScheme, colorAspectsSubtree, modelThings);
                            }
                            break;
                        case "DisplayedHierarchies":
                            using (var displayedHierarchiesSubtree = reader.ReadSubtree())
                            {
                                displayedHierarchiesSubtree.MoveToContent();
                                this.ReadDisplayedHierarchies(hierarchyColorScheme, displayedHierarchiesSubtree, modelThings);
                            }
                            break;
                        default:
                            throw new System.NotSupportedException($"{localName} not yet supported");
                    }
                }
            }
        }

        /// <summary>
        /// Reads color aspects of the <see cref="HierarchyColorScheme"/>  from the .orm file
        /// </summary>
        /// <param name="hierarchyColorScheme">
        /// The subject <see cref="HierarchyColorScheme"/> that is to be deserialized
        /// </param>
        /// <param name="reader">
        /// an instance of <see cref="XmlReader"/> used to read the .orm file
        /// </param>
        /// <param name="modelThings">
        /// a list of <see cref="ModelThing"/>s to which the deserialized items are added
        /// </param>
        private void ReadColorAspects(HierarchyColorScheme hierarchyColorScheme, XmlReader reader, List<ModelThing> modelThings)
        {
            while (reader.Read())
            {
                if (reader.MoveToContent() == XmlNodeType.Element)
                {
                    var localName = reader.LocalName;

                    switch (localName)
                    {
                        case "TopLevel":
                            using (var diagramDynamicColorSubtree = reader.ReadSubtree())
                            {
                                diagramDynamicColorSubtree.MoveToContent();
                                var diagramDynamicColors = this.ReadDiagramDynamicColors(hierarchyColorScheme, "TopLevel", diagramDynamicColorSubtree, modelThings).ToList();

                                foreach (var diagramDynamicColor in diagramDynamicColors)
                                {
                                    hierarchyColorScheme.TopLevel.Add(diagramDynamicColor.Id);
                                }
                            }
                            break;
                        case "Absorbed":
                            using (var diagramDynamicColorSubtree = reader.ReadSubtree())
                            {
                                diagramDynamicColorSubtree.MoveToContent();
                                var diagramDynamicColors = this.ReadDiagramDynamicColors(hierarchyColorScheme, "Absorbed", diagramDynamicColorSubtree, modelThings).ToList();

                                foreach (var diagramDynamicColor in diagramDynamicColors)
                                {
                                    hierarchyColorScheme.Absorbed.Add(diagramDynamicColor.Id);
                                }
                            }
                            break;
                        case "NotIncluded":
                            using (var diagramDynamicColorSubtree = reader.ReadSubtree())
                            {
                                diagramDynamicColorSubtree.MoveToContent();
                                var diagramDynamicColors = this.ReadDiagramDynamicColors(hierarchyColorScheme, "NotIncluded", diagramDynamicColorSubtree, modelThings).ToList();

                                foreach (var diagramDynamicColor in diagramDynamicColors)
                                {
                                    hierarchyColorScheme.NotIncluded.Add(diagramDynamicColor.Id);
                                }
                            }
                            break;
                        case "AbsorptionAttachPoint":
                            using (var diagramDynamicColorSubtree = reader.ReadSubtree())
                            {
                                diagramDynamicColorSubtree.MoveToContent();
                                var diagramDynamicColors = this.ReadDiagramDynamicColors(hierarchyColorScheme, "AbsorptionAttachPoint", diagramDynamicColorSubtree, modelThings).ToList();

                                foreach (var diagramDynamicColor in diagramDynamicColors)
                                {
                                    hierarchyColorScheme.AbsorptionAttachPoint.Add(diagramDynamicColor.Id);
                                }
                            }
                            break;
                        case "PrimaryLocation":
                            using (var diagramDynamicColorSubtree = reader.ReadSubtree())
                            {
                                diagramDynamicColorSubtree.MoveToContent();
                                var diagramDynamicColors = this.ReadDiagramDynamicColors(hierarchyColorScheme, "PrimaryLocation", diagramDynamicColorSubtree, modelThings).ToList();

                                foreach (var diagramDynamicColor in diagramDynamicColors)
                                {
                                    hierarchyColorScheme.PrimaryLocation.Add(diagramDynamicColor.Id);
                                }
                            }
                            break;
                        case "ReferenceLocation":
                            using (var diagramDynamicColorSubtree = reader.ReadSubtree())
                            {
                                diagramDynamicColorSubtree.MoveToContent();
                                var diagramDynamicColors = this.ReadDiagramDynamicColors(hierarchyColorScheme, "ReferenceLocation", diagramDynamicColorSubtree, modelThings).ToList();

                                foreach (var diagramDynamicColor in diagramDynamicColors)
                                {
                                    hierarchyColorScheme.ReferenceLocation.Add(diagramDynamicColor.Id);
                                }
                            }
                            break;
                        default:
                            throw new System.NotSupportedException($"{localName} not yet supported");
                    }
                }
            }
        }

        /// <summary>
        /// Reads <see cref="DiagramDynamicColor"/>s from the .orm file
        /// </summary>
        /// <param name="hierarchyColorScheme">
        /// The subject <see cref="HierarchyColorScheme"/> that is to be deserialized
        /// </param>
        /// <param name="colorAspect">
        /// the colorAspect of the <see cref="HierarchyColorScheme"/> (color aspect) that the 
        /// </param>
        /// <param name="reader">
        /// an instance of <see cref="XmlReader"/> used to read the .orm file
        /// </param>
        /// <param name="modelThings">
        /// a list of <see cref="ModelThing"/>s to which the deserialized items are added
        /// </param>
        private IEnumerable<DiagramDynamicColor> ReadDiagramDynamicColors(HierarchyColorScheme hierarchyColorScheme, string colorAspect, XmlReader reader, List<ModelThing> modelThings)
        {
            var diagramDynamicColors = new List<DiagramDynamicColor>();

            while (reader.Read())
            {
                if (reader.MoveToContent() == XmlNodeType.Element)
                {
                    var localName = reader.LocalName;

                    switch (localName)
                    {
                        case "ORMDiagramDynamicColor":
                            using (var diagramDynamicColorSubtree = reader.ReadSubtree())
                            {
                                diagramDynamicColorSubtree.MoveToContent();
                                var diagramDynamicColor = new DiagramDynamicColor();
                                var diagramDynamicColorXmlReader = new DiagramDynamicColorXmlReader();
                                diagramDynamicColorXmlReader.ReadXml(diagramDynamicColor, diagramDynamicColorSubtree, modelThings);
                                diagramDynamicColor.Id = $"{hierarchyColorScheme.Id}:{colorAspect}:{diagramDynamicColor.ColorRole}"; 
                                diagramDynamicColor.Container = hierarchyColorScheme.Id;
                                
                                diagramDynamicColors.Add(diagramDynamicColor);
                            }
                            break;
                        default:
                            throw new System.NotSupportedException($"{localName} not yet supported");
                    }
                }
            }

            return diagramDynamicColors;
        }

        /// <summary>
        /// Reads <see cref="DiagramDynamicColor"/>s from the .orm file
        /// </summary>
        /// <param name="hierarchyColorScheme">
        /// The subject <see cref="HierarchyColorScheme"/> that is to be deserialized
        /// </param>
        /// <param name="reader">
        /// an instance of <see cref="XmlReader"/> used to read the .orm file
        /// </param>
        /// <param name="modelThings">
        /// a list of <see cref="ModelThing"/>s to which the deserialized items are added
        /// </param>
        private void ReadDisplayedHierarchies(HierarchyColorScheme hierarchyColorScheme, XmlReader reader, List<ModelThing> modelThings)
        {
            while (reader.Read())
            {
                if (reader.MoveToContent() == XmlNodeType.Element)
                {
                    var localName = reader.LocalName;

                    switch (localName)
                    {
                        case "DisplayedHierarchy":
                            using (var displayedHierarchySubtree = reader.ReadSubtree())
                            {
                                displayedHierarchySubtree.MoveToContent();

                                var referencedHierarchy = reader.GetAttribute("ref");

                                if (!string.IsNullOrEmpty(referencedHierarchy))
                                {
                                    hierarchyColorScheme.DisplayedHierarchies.Add(referencedHierarchy);
                                }
                            }
                            break;
                        default:
                            throw new System.NotSupportedException($"{localName} not yet supported");
                    }
                }
            }
        }
    }
}
