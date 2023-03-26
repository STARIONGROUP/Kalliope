// -------------------------------------------------------------------------------------------------
// <copyright file="ObjectTypeXmlReader.cs" company="RHEA System S.A.">
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

namespace Kalliope.Xml.Readers
{
    using System;
    using System.Collections.Generic;
    using System.Xml;

    using Kalliope.DTO;

    /// <summary>
    /// The purpose of the <see cref="ObjectTypeXmlReader"/> is to deserialize a <see cref="ObjectType"/>
    /// from an .orm XML file
    /// </summary>
    public abstract class ObjectTypeXmlReader : OrmNamedElementXmlReader
    {
        /// <summary>
        /// Reads the properties of the provided <see cref="ObjectType"/> from the <see cref="XmlReader"/>
        /// </summary>
        /// <param name="objectType">
        /// The subject <see cref="ObjectType"/> that is to be deserialized
        /// </param>
        /// <param name="reader">
        /// The <see cref="XmlReader"/> that contains the .orm XML
        /// </param>
        /// <param name="modelThings">
        /// a list of <see cref="ModelThing"/>s to which the deserialized items are added
        /// </param>
        public void ReadXml(ObjectType objectType, XmlReader reader, List<ModelThing> modelThings)
        {
            base.ReadXml(objectType, reader, modelThings);
            
            var isImplicitBooleanValue = reader.GetAttribute("IsImplicitBooleanValue");
            if (isImplicitBooleanValue != null)
            {
                objectType.IsImplicitBooleanValue = XmlConvert.ToBoolean(isImplicitBooleanValue);
            }

            var isIndependent = reader.GetAttribute("IsIndependent");
            if (isIndependent != null)
            {
                objectType.IsIndependent = XmlConvert.ToBoolean(isIndependent);
            }

            objectType.ReferenceMode = reader.GetAttribute("_ReferenceMode");

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
                                this.ReadDefinitions(objectType, definitionSubtree, modelThings);
                            }
                            break;
                        case "Abbreviations":
	                        using (var abbreviationsSubtree = reader.ReadSubtree())
	                        {
		                        abbreviationsSubtree.MoveToContent();
		                        this.ReadAbbreviations(objectType, abbreviationsSubtree, modelThings);
	                        }
	                        break;
						case "Notes":
                            using (var notesSubtree = reader.ReadSubtree())
                            {
                                notesSubtree.MoveToContent();
                                this.ReadNotes(objectType, notesSubtree, modelThings);
                            }
                            break;
                        case "PlayedRoles":
                            using (var roleSubtree = reader.ReadSubtree())
                            {
                                roleSubtree.MoveToContent();
                                this.ReadPlayedRoles(objectType, roleSubtree);
                            }
                            break;
                        case "PreferredIdentifier":
                            this.ReadPreferredIdentifier(reader, objectType);
                            break;
                        case "ConceptualDataType":
                            using (var dataTypeUseSubtree = reader.ReadSubtree())
                            {
                                if (dataTypeUseSubtree.MoveToContent() == XmlNodeType.Element)
                                {
                                    var dataTypeRef = new DataTypeUse();
                                    var dataTypeRefXmlReader = new DataTypeUseXmlReader();
                                    dataTypeRefXmlReader.ReadXml(dataTypeRef, dataTypeUseSubtree, modelThings);
                                    dataTypeRef.Container = objectType.Id;
                                    objectType.ConceptualDataType = dataTypeRef.Id;
                                }
                            }
                            break;
                        case "NestedPredicate":
                            using (var nestedPredicateSubtree = reader.ReadSubtree())
                            {
                                nestedPredicateSubtree.MoveToContent();
                                this.ReadNestedPredicate(objectType, nestedPredicateSubtree, modelThings);
                            }
                            break;
                        case "ValueRestriction":
                            using (var valueRestrictionSubtree = reader.ReadSubtree())
                            {
                                this.ReadValueRestriction(objectType, valueRestrictionSubtree, modelThings);
                            }
                            break;
                        case "SubtypeDerivationRule":
                            using (var subtypeDerivationRuleSubtree = reader.ReadSubtree())
                            {
                                subtypeDerivationRuleSubtree.MoveToContent();
                                var subtypeDerivationRule = new SubtypeDerivationRule();
                                var subtypeDerivationRuleXmlReader = new SubtypeDerivationRuleXmlReader();
                                subtypeDerivationRuleXmlReader.ReadXml(subtypeDerivationRule, subtypeDerivationRuleSubtree, modelThings);
                                subtypeDerivationRule.Container = objectType.Id;
                                objectType.DerivationRule = subtypeDerivationRule.Id;
                            }
                            break;
                        case "Extensions":
                            using (var extensionsSubtree = reader.ReadSubtree())
                            {
                                extensionsSubtree.MoveToContent();
                                this.ReadExtensions(objectType, extensionsSubtree, modelThings);
                            }
                            break;
                        case "CardinalityRestriction":
	                        using (var cardinalityRestrictionSubtree = reader.ReadSubtree())
	                        {
		                        cardinalityRestrictionSubtree.MoveToContent();
		                        var objectTypeCardinalityRestriction = new ObjectTypeCardinalityRestriction();
		                        var objectTypeCardinalityRestrictionXmlReader = new ObjectTypeCardinalityRestrictionXmlReader();
		                        objectTypeCardinalityRestrictionXmlReader.ReadXml(objectTypeCardinalityRestriction, cardinalityRestrictionSubtree, modelThings);
		                        objectTypeCardinalityRestriction.Container = objectType.Id;
		                        objectType.Cardinality = objectTypeCardinalityRestriction.Id;
	                        }
	                        break;
                        default:
                            throw new NotSupportedException($"{localName} not yet supported");
                    }
                }
            }
        }

        /// <summary>
        /// reads the <see cref="Objectification"/>
        /// </summary>
        /// <param name="objectType">
        /// The <see cref="ObjectType"/> that owns the <see cref="Objectification"/>
        /// </param>
        /// <param name="reader">
        /// an instance of <see cref="XmlReader"/> used to read the .orm file
        /// </param>
        /// <param name="modelThings">
        /// a list of <see cref="ModelThing"/>s to which the deserialized items are added
        /// </param>
        public virtual void ReadNestedPredicate(ObjectType objectType, XmlReader reader, List<ModelThing> modelThings)
        {
            throw new InvalidOperationException("only supported by ObjectifiedType");
        }

        /// <summary>
        /// Reads the preferred identifier
        /// </summary>
        /// <param name="reader">
        /// an instance of <see cref="XmlReader"/> used to read the .orm file
        /// </param>
        /// <param name="objectType">
        /// The <see cref="EntityType"/> or <see cref="ObjectifiedType"/> for which the PreferredIdentifier is to be read
        /// </param>
        public virtual void ReadPreferredIdentifier(XmlReader reader, ObjectType objectType)
        {
            throw new InvalidOperationException("only supported by EntityType and ObjectifiedType");
        }

        /// <summary>
        /// reads the contained <see cref="Definition"/>s
        /// </summary>
        /// <param name="objectType">
        /// The container <see cref="ObjectType"/> of the <see cref="Definition"/>
        /// </param>
        /// <param name="reader">
        /// an instance of <see cref="XmlReader"/> used to read the .orm file
        /// </param>
        /// <param name="modelThings">
        /// a list of <see cref="ModelThing"/>s to which the deserialized items are added
        /// </param>
        private void ReadDefinitions(ObjectType objectType, XmlReader reader, List<ModelThing> modelThings)
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
                                definition.Container = objectType.Id;
                                objectType.Definition = definition.Id;
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
        /// <param name="objectType">
        /// The container <see cref="ObjectType"/> of the <see cref="NameAlias"/>
        /// </param>
        /// <param name="reader">
        /// an instance of <see cref="XmlReader"/> used to read the .orm file
        /// </param>
        /// <param name="modelThings">
        /// a list of <see cref="ModelThing"/>s to which the deserialized items are added
        /// </param>
		private void ReadAbbreviations(ObjectType objectType, XmlReader reader, List<ModelThing> modelThings)
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
						        nameAlias.Container = objectType.Id;
								objectType.Abbreviations.Add(nameAlias.Id);
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
		/// <param name="objectType">
		/// The container <see cref="ObjectType"/> of the <see cref="Definition"/>
		/// </param>
		/// <param name="reader">
		/// an instance of <see cref="XmlReader"/> used to read the .orm file
		/// </param>
		/// <param name="modelThings">
		/// a list of <see cref="ModelThing"/>s to which the deserialized items are added
		/// </param>
		private void ReadNotes(ObjectType objectType, XmlReader reader, List<ModelThing> modelThings)
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
                                note.Container = objectType.Id;
                                objectType.Note = note.Id;
                            }
                            break;
                        default:
                            throw new NotSupportedException($"{localName} not yet supported");
                    }
                }
            }
        }

        /// <summary>
        /// reads the referenced played Role
        /// </summary>
        /// <param name="objectType">
        /// The <see cref="ObjectType"/> that references the played roles
        /// </param>
        /// <param name="reader">
        /// an instance of <see cref="XmlReader"/> used to read the .orm file
        /// </param>
        private void ReadPlayedRoles(ObjectType objectType, XmlReader reader)
        {
            while (reader.Read())
            {
                if (reader.MoveToContent() == XmlNodeType.Element)
                {
                    var localName = reader.LocalName;

                    switch (localName)
                    {
                        case "Role":
                            var roleReference = reader.GetAttribute("ref");
                            if (!string.IsNullOrEmpty(roleReference))
                            {
                                objectType.PlayedRoles.Add(roleReference);
                            }
                            break;
                        case "SubtypeMetaRole":
                            var subtypeMetaRoleReference = reader.GetAttribute("ref");
                            if (!string.IsNullOrEmpty(subtypeMetaRoleReference))
                            {
                                objectType.PlayedRoles.Add(subtypeMetaRoleReference);
                            }
                            break;
                        case "SupertypeMetaRole":
                            var supertypeMetaRoleReference = reader.GetAttribute("ref");
                            if (!string.IsNullOrEmpty(supertypeMetaRoleReference))
                            {
                                objectType.PlayedRoles.Add(supertypeMetaRoleReference);
                            }
                            break;
                        default:
                            throw new NotSupportedException($"{localName} not yet supported");
                    }
                }
            }
        }

        /// <summary>
        /// reads the <see cref="ValueTypeValueConstraint"/>
        /// </summary>
        /// <param name="objectType">
        /// The <see cref="ObjectType"/> that contains the <see cref="ValueTypeValueConstraint"/>
        /// </param>
        /// <param name="reader">
        /// an instance of <see cref="XmlReader"/> used to read the .orm file
        /// </param>
        /// <param name="modelThings">
        /// a list of <see cref="ModelThing"/>s to which the deserialized items are added
        /// </param>
        private void ReadValueRestriction(ObjectType objectType, XmlReader reader, List<ModelThing> modelThings)
        {
            while (reader.Read())
            {
                var localName = reader.LocalName;

                if (localName == "ValueConstraint")
                {
                    var valueTypeValueConstraint = new ValueTypeValueConstraint();
                    var valueTypeValueConstraintXmlReader = new ValueTypeValueConstraintXmlReader();
                    valueTypeValueConstraintXmlReader.ReadXml(valueTypeValueConstraint,reader, modelThings);
                    valueTypeValueConstraint.Container = objectType.Id;
                    objectType.ValueConstraint = valueTypeValueConstraint.Id;
                }
            }
        }

        /// <summary>
        /// reads the <see cref="Extension"/>s
        /// </summary>
        /// <param name="objectType">
        /// The <see cref="ObjectType"/> that contains the <see cref="Extension"/>s
        /// </param>
        /// <param name="reader">
        /// an instance of <see cref="XmlReader"/> used to read the .orm file
        /// </param>
        /// <param name="modelThings">
        /// a list of <see cref="ModelThing"/>s to which the deserialized items are added
        /// </param>
        private void ReadExtensions(ObjectType objectType, XmlReader reader, List<ModelThing> modelThings)
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
                                customProperty.Container = objectType.Id;
                                objectType.Extensions.Add(customProperty.Id);
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
