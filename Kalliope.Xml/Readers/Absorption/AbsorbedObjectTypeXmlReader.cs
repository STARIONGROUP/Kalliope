// -------------------------------------------------------------------------------------------------
// <copyright file="AbsorbedObjectTypeXmlReader.cs" company="RHEA System S.A.">
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
    /// The purpose of the <see cref="AbsorbedObjectTypeXmlReader"/> is to deserialize a <see cref="AbsorbedObjectType"/>
    /// from an .orm XML file
    /// </summary>
    public class AbsorbedObjectTypeXmlReader : ModelThingXmlReader
    {
        /// <summary>
        /// Reads the properties of the provided <see cref="AbsorbedObjectType"/> from the <see cref="XmlReader"/>
        /// </summary>
        /// <param name="absorbedObjectType">
        /// The subject <see cref="AbsorbedObjectType"/> that is to be deserialized
        /// </param>
        /// <param name="reader">
        /// The <see cref="XmlReader"/> that contains the .orm XML
        /// </param>
        /// <param name="modelThings">
        /// a list of <see cref="ModelThing"/>s to which the deserialized items are added
        /// </param>
        public void ReadXml(AbsorbedObjectType absorbedObjectType, XmlReader reader, List<ModelThing> modelThings)
        {
            base.ReadXml(absorbedObjectType, reader, modelThings);

            absorbedObjectType.Id = reader.GetAttribute("id");

            absorbedObjectType.AbsorptionPattern = reader.GetAttribute("AbsorptionPattern");
            
            var nested = reader.GetAttribute("Nested");
            if (!string.IsNullOrEmpty(nested))
            {
                absorbedObjectType.Nested= XmlConvert.ToBoolean(nested);
            }
            
            var topLevel = reader.GetAttribute("TopLevel");
            if (!string.IsNullOrEmpty(topLevel))
            {
                absorbedObjectType.TopLevel= XmlConvert.ToBoolean(topLevel);
            }

            var forceTopLevel = reader.GetAttribute("ForceTopLevel");
            if (!string.IsNullOrEmpty(forceTopLevel))
            {
                absorbedObjectType.ForceTopLevel = XmlConvert.ToBoolean(forceTopLevel);
            }

            absorbedObjectType.XmlName = reader.GetAttribute("XmlName");

            absorbedObjectType.XmlSimpleIdentifierReferenceForm = reader.GetAttribute("XmlSimpleIdentifierReferenceForm");

            var withSupertype = reader.GetAttribute("WithSupertype");
            if (!string.IsNullOrEmpty(withSupertype))
            {
                absorbedObjectType.WithSupertype = XmlConvert.ToBoolean(withSupertype);
            }

            absorbedObjectType.ObjectType = reader.GetAttribute("ref");

            while (reader.Read())
            {
                if (reader.MoveToContent() == XmlNodeType.Element)
                {
                    var localName = reader.LocalName;

                    switch (localName)
                    {
                        case "AbsorbedRoles":
                            using (var absorbedRolesSubtree = reader.ReadSubtree())
                            {
                                absorbedRolesSubtree.MoveToContent();
                                this.ReadAbsorbedRoles(absorbedObjectType, absorbedRolesSubtree, modelThings);
                            }
                            break;
                        case "HierarchyChildren":
                            using (var hierarchyChildrenSubtree = reader.ReadSubtree())
                            {
                                hierarchyChildrenSubtree.MoveToContent();
                                this.ReadHierarchyChildren(absorbedObjectType, hierarchyChildrenSubtree, modelThings);
                            }
                            break;
                        case "PossibleChildRoles":
                            using (var possibleChildRolesSubtree = reader.ReadSubtree())
                            {
                                possibleChildRolesSubtree.MoveToContent();
                                this.ReadPossibleChildRoles(absorbedObjectType, possibleChildRolesSubtree, modelThings);
                            }
                            break;
                        default:
                            throw new System.NotSupportedException($"{localName} not yet supported");
                    }
                }
            }
        }

        /// <summary>
        /// Reads <see cref="ChildRole"/>s from the .orm file
        /// </summary>
        /// <param name="absorbedObjectType">
        /// The subject <see cref="AbsorbedObjectType"/> that is to be deserialized
        /// </param>
        /// <param name="reader">
        /// an instance of <see cref="XmlReader"/> used to read the .orm file
        /// </param>
        /// <param name="modelThings">
        /// a list of <see cref="ModelThing"/>s to which the deserialized items are added
        /// </param>
        private void ReadAbsorbedRoles(AbsorbedObjectType absorbedObjectType, XmlReader reader, List<ModelThing> modelThings)
        {
            while (reader.Read())
            {
                if (reader.MoveToContent() == XmlNodeType.Element)
                {
                    var localName = reader.LocalName;

                    switch (localName)
                    {
                        case "AbsorbedRole":
                            using (var absorbedRoleSubtree = reader.ReadSubtree())
                            {
                                absorbedRoleSubtree.MoveToContent();
                                var absorbedRole = new AbsorbedRole();
                                var absorbedRoleXmlReader = new AbsorbedRoleXmlReader();
                                absorbedRoleXmlReader.ReadXml(absorbedRole, absorbedRoleSubtree, modelThings);
                                absorbedRole.Container = absorbedObjectType.Id;
                                absorbedObjectType.AbsorbedRoles.Add(absorbedRole.Id);
                            }
                            break;
                        default:
                            throw new System.NotSupportedException($"{localName} not yet supported");
                    }
                }
            }
        }

        /// <summary>
        /// Reads <see cref="HierarchyChild"/>s from the .orm file
        /// </summary>
        /// <param name="absorbedObjectType">
        /// The subject <see cref="AbsorbedObjectType"/> that is to be deserialized
        /// </param>
        /// <param name="reader">
        /// an instance of <see cref="XmlReader"/> used to read the .orm file
        /// </param>
        /// <param name="modelThings">
        /// a list of <see cref="ModelThing"/>s to which the deserialized items are added
        /// </param>
        private void ReadHierarchyChildren(AbsorbedObjectType absorbedObjectType, XmlReader reader, List<ModelThing> modelThings)
        {
            while (reader.Read())
            {
                if (reader.MoveToContent() == XmlNodeType.Element)
                {
                    var localName = reader.LocalName;

                    switch (localName)
                    {
                        case "HierarchyChild":
                            using (var hierarchyChildSubtree = reader.ReadSubtree())
                            {
                                hierarchyChildSubtree.MoveToContent();
                                var hierarchyChild = new HierarchyChild();
                                var hierarchyChildXmlReader = new HierarchyChildXmlReader();
                                hierarchyChildXmlReader.ReadXml(hierarchyChild, hierarchyChildSubtree, modelThings);
                                hierarchyChild.Container = absorbedObjectType.Id;
                                absorbedObjectType.HierarchyChildren.Add(hierarchyChild.Id);
                            }
                            break;
                        default:
                            throw new System.NotSupportedException($"{localName} not yet supported");
                    }
                }
            }
        }

        /// <summary>
        /// Reads <see cref="ChildRole"/>s from the .orm file
        /// </summary>
        /// <param name="absorbedObjectType">
        /// The subject <see cref="AbsorbedObjectType"/> that is to be deserialized
        /// </param>
        /// <param name="reader">
        /// an instance of <see cref="XmlReader"/> used to read the .orm file
        /// </param>
        /// <param name="modelThings">
        /// a list of <see cref="ModelThing"/>s to which the deserialized items are added
        /// </param>
        private void ReadPossibleChildRoles(AbsorbedObjectType absorbedObjectType, XmlReader reader, List<ModelThing> modelThings)
        {
            while (reader.Read())
            {
                if (reader.MoveToContent() == XmlNodeType.Element)
                {
                    var localName = reader.LocalName;

                    switch (localName)
                    {
                        case "ChildRole":
                            using (var childRoleSubtree = reader.ReadSubtree())
                            {
                                childRoleSubtree.MoveToContent();
                                var childRole = new ChildRole();
                                var childRoleXmlReader = new ChildRoleXmlReader();
                                childRoleXmlReader.ReadXml(childRole, childRoleSubtree, modelThings);
                                childRole.Container = absorbedObjectType.Id;
                                absorbedObjectType.PossibleChildRoles.Add(childRole.Id);
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
