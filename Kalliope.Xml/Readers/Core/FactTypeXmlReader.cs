﻿// -------------------------------------------------------------------------------------------------
// <copyright file="FactTypeXmlReader.cs" company="Starion Group S.A.">
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
    /// The purpose of the <see cref="FactTypeXmlReader"/> is to deserialize a <see cref="FactType"/>
    /// from an .orm XML file
    /// </summary>
    public class FactTypeXmlReader : OrmModelElementXmlReader
    {
        /// <summary>
        /// Reads the properties of the provided <see cref="FactType"/> from the <see cref="XmlReader"/>
        /// </summary>
        /// <param name="factType">
        /// The subject <see cref="FactType"/> that is to be deserialized
        /// </param>
        /// <param name="reader">
        /// The <see cref="XmlReader"/> that contains the .orm XML
        /// </param>
        /// <param name="modelThings">
        /// a list of <see cref="ModelThing"/>s to which the deserialized items are added
        /// </param>
        public void ReadXml(FactType factType, XmlReader reader, List<ModelThing> modelThings)
        {
            base.ReadXml(factType, reader, modelThings);

            factType.Name = reader.GetAttribute("_Name");

            while (reader.Read())
            {
                if (reader.MoveToContent() == XmlNodeType.Element)
                {
                    var localName = reader.LocalName;

                    switch (localName)
                    {
                        case "Definitions":
                            using (var definitionSubtree = reader.ReadSubtree())
                            {
                                definitionSubtree.MoveToContent();
                                this.ReadDefinitions(factType, definitionSubtree, modelThings);
                            }
                            break;
                        case "Notes":
                            using (var notesSubtree = reader.ReadSubtree())
                            {
                                notesSubtree.MoveToContent();
                                this.ReadNotes(factType, notesSubtree, modelThings);
                            }
                            break;
                        case "FactRoles":
                            using (var rolesSubtree = reader.ReadSubtree())
                            {
                                rolesSubtree.MoveToContent();
                                this.ReadFactRoles(factType, rolesSubtree, modelThings);
                            }
                            break;
                        case "ReadingOrders":
                            using (var readingOrdersSubtree = reader.ReadSubtree())
                            {
                                readingOrdersSubtree.MoveToContent();
                                this.ReadReadingOrders(factType, readingOrdersSubtree, modelThings);
                            }
                            break;
                        case "InternalConstraints":
                            using (var internalConstraintsSubtree = reader.ReadSubtree())
                            {
                                internalConstraintsSubtree.MoveToContent();
                                this.ReadInternalConstraints(factType, internalConstraintsSubtree);
                            }
                            break;
                        case "DerivationRule":
                            using (var derivationRuleSubtree = reader.ReadSubtree())
                            {
                                derivationRuleSubtree.MoveToContent();
                                this.ReadDerivationRule(factType, derivationRuleSubtree, modelThings);
                            }
                            break;
                        case "ImpliedByObjectification":
                            this.ReadImpliedByObjectification(factType, reader);
                            break;
                        case "Extensions":
                            using (var extensionsSubtree = reader.ReadSubtree())
                            {
                                extensionsSubtree.MoveToContent();
                                this.ReadExtensions(factType, extensionsSubtree, modelThings);
                            }
                            break;
                        default:
                            throw new NotSupportedException($"{localName} not yet supported");
                    }
                }
            }
        }

        /// <summary>
        /// Reads the referenced <see cref="Objectification"/>s from the .orm file
        /// </summary>
        /// <param name="impliedFactType">
        /// The subject <see cref="ImpliedFactType"/> that is to be deserialized
        /// </param>
        /// <param name="reader">
        /// an instance of <see cref="XmlReader"/> used to read the .orm file
        /// </param>
        public virtual void ReadImpliedByObjectification(FactType impliedFactType, XmlReader reader)
        {
            throw new InvalidOperationException("shall only be implemented by ImpliedFact");
        }

        /// <summary>
        /// reads the contained <see cref="Definition"/>s
        /// </summary>
        /// <param name="factType">
        /// The container <see cref="FactType"/> of the <see cref="Definition"/>
        /// </param>
        /// <param name="reader">
        /// an instance of <see cref="XmlReader"/> used to read the .orm file
        /// </param>
        /// <param name="modelThings">
        /// a list of <see cref="ModelThing"/>s to which the deserialized items are added
        /// </param>
        private void ReadDefinitions(FactType factType, XmlReader reader, List<ModelThing> modelThings)
        {
            while (reader.Read())
            {
                if (reader.MoveToContent() == XmlNodeType.Element)
                {
                    var localName = reader.LocalName;

                    switch (localName)
                    {
                        case "Definition":
                            using (var definitionSubtree = reader.ReadSubtree())
                            {
                                definitionSubtree.MoveToContent();
                                var definition = new Definition();
                                var definitionXmlReader = new DefinitionXmlReader();
                                definitionXmlReader.ReadXml(definition, definitionSubtree, modelThings);
                                definition.Container = factType.Id;
                                factType.Definition = definition.Id;
                            }
                            break;
                        default:
                            throw new NotSupportedException($"{localName} not yet supported");
                    }
                }
            }
        }

        /// <summary>
        /// reads the contained <see cref="Note"/>s
        /// </summary>
        /// <param name="factType">
        /// The container <see cref="FactType"/> of the <see cref="Definition"/>
        /// </param>
        /// <param name="reader">
        /// an instance of <see cref="XmlReader"/> used to read the .orm file
        /// </param>
        /// <param name="modelThings">
        /// a list of <see cref="ModelThing"/>s to which the deserialized items are added
        /// </param>
        private void ReadNotes(FactType factType, XmlReader reader, List<ModelThing> modelThings)
        {
            while (reader.Read())
            {
                if (reader.MoveToContent() == XmlNodeType.Element)
                {
                    var localName = reader.LocalName;

                    switch (localName)
                    {
                        case "Note":

                            using (var noteSubtree = reader.ReadSubtree())
                            {
                                noteSubtree.MoveToContent();
                                var note = new Note();
                                var noteXmlReader = new NoteXmlReader();
                                noteXmlReader.ReadXml(note, noteSubtree, modelThings);
                                note.Container = factType.Id;
                                factType.Note = note.Id;
                            }
                            break;
                        default:
                            throw new NotSupportedException($"{localName} not yet supported");
                    }
                }
            }
        }

        /// <summary>
        /// Reads <see cref="Role"/>s from the .orm file
        /// </summary>
        /// <param name="factType">
        /// The subject <see cref="FactType"/> that is to be deserialized and is the container of the <see cref="RoleBase"/>s
        /// </param>
        /// <param name="reader">
        /// an instance of <see cref="XmlReader"/> used to read the .orm file
        /// </param>
        /// <param name="modelThings">
        /// a list of <see cref="ModelThing"/>s to which the deserialized items are added
        /// </param>
        public virtual void ReadFactRoles(FactType factType, XmlReader reader, List<ModelThing> modelThings)
        {
            while (reader.Read())
            {
                if (reader.MoveToContent() == XmlNodeType.Element)
                {
                    var localName = reader.LocalName;

                    switch (localName)
                    {
                        case "Role":
                            using (var roleSubtree = reader.ReadSubtree())
                            {
                                roleSubtree.MoveToContent();
                                var role = new Role();
                                var roleXmlReader = new RoleXmlReader();
                                roleXmlReader.ReadXml(role, roleSubtree, modelThings);
                                role.Container = factType.Id;
                                factType.Roles.Add(role.Id);
                            }
                            break;
                        case "RoleProxy":
                            using (var roleProxySubtree = reader.ReadSubtree())
                            {
                                roleProxySubtree.MoveToContent();
                                var roleProxy = new RoleProxy();
                                var roleProxyXmlReader = new RoleProxyXmlReader();
                                roleProxyXmlReader.ReadXml(roleProxy, roleProxySubtree, modelThings);
                                roleProxy.Container = factType.Id;
                                factType.Roles.Add(roleProxy.Id);
                            }
                            break;
                        default:
                            throw new NotSupportedException($"{localName} not yet supported");
                    }
                }
            }
        }

        /// <summary>
        /// Reads <see cref="ReadingOrder"/>s from the .orm file
        /// </summary>
        /// <param name="factType">
        /// The subject <see cref="FactType"/> that is to be deserialized and is the container of the <see cref="ReadingOrder"/>s
        /// </param>
        /// <param name="reader">
        /// an instance of <see cref="XmlReader"/> used to read the .orm file
        /// </param>
        /// <param name="modelThings">
        /// a list of <see cref="ModelThing"/>s to which the deserialized items are added
        /// </param>
        private void ReadReadingOrders(FactType factType, XmlReader reader, List<ModelThing> modelThings)
        {
            while (reader.Read())
            {
                if (reader.MoveToContent() == XmlNodeType.Element)
                {
                    var localName = reader.LocalName;

                    switch (localName)
                    {
                        case "ReadingOrder":
                            using (var readingOrderSubtree = reader.ReadSubtree())
                            {
                                readingOrderSubtree.MoveToContent();
                                var readingOrder = new ReadingOrder();
                                var readingOrderXmlReader = new ReadingOrderXmlReader();
                                readingOrderXmlReader.ReadXml(readingOrder, readingOrderSubtree, modelThings);
                                readingOrder.Container = factType.Id;
                                factType.ReadingOrders.Add(readingOrder.Id);
                            }
                            break;
                        default:
                            throw new NotSupportedException($"{localName} not yet supported");
                    }
                }
            }
        }

        /// <summary>
        /// Reads <see cref="SetConstraint"/>s from the .orm file
        /// </summary>
        /// <param name="factType">
        /// The subject <see cref="FactType"/> that is to be deserialized and references the internal constraints
        /// </param>
        /// <param name="reader">
        /// an instance of <see cref="XmlReader"/> used to read the .orm file
        /// </param>
        private void ReadInternalConstraints(FactType factType, XmlReader reader)
        {
            while (reader.Read())
            {
                if (reader.MoveToContent() == XmlNodeType.Element)
                {
                    var localName = reader.LocalName;

                    switch (localName)
                    {
                        case "MandatoryConstraint":
                            var mandatoryConstraintReference = reader.GetAttribute("ref");
                            if (!string.IsNullOrEmpty(mandatoryConstraintReference))
                            {
                                factType.InternalConstraints.Add(mandatoryConstraintReference);
                            }
                            break;
                        case "UniquenessConstraint":
                            var uniquenessConstraintReference = reader.GetAttribute("ref");
                            if (!string.IsNullOrEmpty(uniquenessConstraintReference))
                            {
                                factType.InternalConstraints.Add(uniquenessConstraintReference);
                            }
                            break;
                        default:
                            throw new NotSupportedException($"{localName} not yet supported");
                    }
                }
            }
        }

        /// <summary>
        /// Reads <see cref="FactTypeDerivationRule"/>s and <see cref="FactTypeDerivationPath"/> from the .orm file
        /// </summary>
        /// <param name="factType">
        /// The subject <see cref="FactType"/> that is to be deserialized and is the container of the <see cref="FactTypeDerivationExpression"/>s and <see cref="FactTypeDerivationPath"/>
        /// </param>
        /// <param name="reader">
        /// an instance of <see cref="XmlReader"/> used to read the .orm file
        /// </param>
        /// <param name="modelThings">
        /// a list of <see cref="ModelThing"/>s to which the deserialized items are added
        /// </param>
        private void ReadDerivationRule(FactType factType, XmlReader reader, List<ModelThing> modelThings)
        {
            using (var factTypeDerivationRuleSubtree = reader.ReadSubtree())
            {
                factTypeDerivationRuleSubtree.MoveToContent();
                var factTypeDerivationRule = new FactTypeDerivationRule();
                var factTypeDerivationRuleXmlReader = new FactTypeDerivationRuleXmlReader();
                factTypeDerivationRuleXmlReader.ReadXml(factTypeDerivationRule, factTypeDerivationRuleSubtree, modelThings);
                factTypeDerivationRule.Id = $"{factType.Id}:DerivationRuleHavingPath:{factTypeDerivationRule.FactTypeDerivationPath}"; 
                factType.DerivationRule = factTypeDerivationRule.Id;
                factTypeDerivationRule.Container = factType.Id;
            }
        }

        /// <summary>
        /// reads the <see cref="Extension"/>s
        /// </summary>
        /// <param name="factType">
        /// The <see cref="FactType"/> that contains the <see cref="Extension"/>s
        /// </param>
        /// <param name="reader">
        /// an instance of <see cref="XmlReader"/> used to read the .orm file
        /// </param>
        /// <param name="modelThings">
        /// a list of <see cref="ModelThing"/>s to which the deserialized items are added
        /// </param>
        private void ReadExtensions(FactType factType, XmlReader reader, List<ModelThing> modelThings)
        {
            while (reader.Read())
            {
                if (reader.MoveToContent() == XmlNodeType.Element)
                {
                    var localName = reader.LocalName;

                    switch (localName)
                    {
                        case "CustomProperty":

                            using (var customPropertySubtree = reader.ReadSubtree())
                            {
                                customPropertySubtree.MoveToContent();
                                var customProperty = new CustomProperty();
                                var customPropertyXmlReader = new CustomPropertyXmlReader();
                                customPropertyXmlReader.ReadXml(customProperty, customPropertySubtree, modelThings);
                                customProperty.Container = factType.Id;
                                factType.Extensions.Add(customProperty.Id);
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
