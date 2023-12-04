// -------------------------------------------------------------------------------------------------
// <copyright file="ConstraintXmlReader.cs" company="RHEA System S.A.">
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

using Kalliope.Common;

namespace Kalliope.Xml.Readers
{
    using System;
    using System.Collections.Generic;
    using System.Xml;

    using Kalliope.DTO;

    /// <summary>
    /// The purpose of the <see cref="ConstraintXmlReader"/> is to deserialize a <see cref="Constraint"/>
    /// from an .orm XML file
    /// </summary>
    public abstract class ConstraintXmlReader : OrmNamedElementXmlReader
    {
        /// <summary>
        /// Reads the properties of the provided <see cref="Constraint"/> from the <see cref="XmlReader"/>
        /// </summary>
        /// <param name="constraint">
        /// The subject <see cref="Constraint"/> that is to be deserialized
        /// </param>
        /// <param name="reader">
        /// The <see cref="XmlReader"/> that contains the .orm XML
        /// </param>
        /// <param name="modelThings">
        /// a list of <see cref="ModelThing"/>s to which the deserialized items are added
        /// </param>
        public void ReadXml(Constraint constraint, XmlReader reader, List<ModelThing> modelThings)
        {
            base.ReadXml(constraint, reader, modelThings);

            var constraintModalityString = reader.GetAttribute("Modality");
            if (constraintModalityString != null)
            {
                if (Enum.TryParse(constraintModalityString, out ConstraintModality constraintModality))
                {
                    constraint.Modality = constraintModality;
                }
            }

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
                                this.ReadDefinitions(constraint, definitionSubtree, modelThings);
                            }
                            break;

                        case "Notes":
                            using (var notesSubtree = reader.ReadSubtree())
                            {
                                notesSubtree.MoveToContent();
                                this.ReadNotes(constraint, notesSubtree, modelThings);
                            }
                            break;

                        case "RoleSequence":
                            using (var roleSequencesSubtree = reader.ReadSubtree())
                            {
                                roleSequencesSubtree.MoveToContent();
                                this.ReadRoleSequence(constraint, roleSequencesSubtree, modelThings);
                            }
                            break;


                        case "PreferredIdentifierFor":

                            using (var preferredIdentifierForSubtree = reader.ReadSubtree())
                            {
                                preferredIdentifierForSubtree.MoveToContent();
                                this.ReadPreferredIdentifierFor(constraint, preferredIdentifierForSubtree, modelThings);
                            }
                            break;

                        case "ImpliedByObjectType":

                            using (var impliedByObjectTypeSubtree = reader.ReadSubtree())
                            {
                                impliedByObjectTypeSubtree.MoveToContent();
                                this.ReadImpliedByObjectType(constraint, impliedByObjectTypeSubtree, modelThings);
                            }
                            break;

                        case "InherentForObjectType":

                            using (var inherentForObjectTypeSubtree = reader.ReadSubtree())
                            {
                                inherentForObjectTypeSubtree.MoveToContent();
                                this.ReadInherentForObjectType(constraint, inherentForObjectTypeSubtree, modelThings);
                            }
                            break;

                        case "ExclusiveOrExclusionConstraint":

                            using (var exclusiveOrExclusionConstraintSubtree = reader.ReadSubtree())
                            {
                                exclusiveOrExclusionConstraintSubtree.MoveToContent();
                                this.ReadExclusiveOrExclusionConstraint(constraint, exclusiveOrExclusionConstraintSubtree, modelThings);
                            }
                            break;


                        default:
                            throw new NotSupportedException($"{localName} not yet supported");
                    }
                }
            }
        }

        /// <summary>
        /// Reads <see cref="Role"/> sequences from the .orm file
        /// </summary>
        /// <param name="constraint">
        /// The <see cref="Constraint"/> that contains the <see cref="Role"/>s
        /// </param>
        /// <param name="reader">
        /// an instance of <see cref="XmlReader"/> used to read the .orm file
        /// </param>
        /// <param name="modelThings">
        /// a list of <see cref="ModelThing"/>s to which the deserialized items are added
        /// </param>
        protected virtual void ReadRoleSequence(Constraint constraint, XmlReader reader, List<ModelThing> modelThings)
        {
            throw new NotSupportedException($"RoleSequences is not allowed on the {nameof(Constraint)} abstract baseclass");
        }

        /// <summary>
        /// Reads PreferredIdentifierFor <see cref="ObjectType"/>  from the .orm file
        /// </summary>
        /// <param name="constraint">
        /// The <see cref="Constraint"/> that contains the <see cref="ObjectType"/>s
        /// </param>
        /// <param name="reader">
        /// an instance of <see cref="XmlReader"/> used to read the .orm file
        /// </param>
        /// <param name="modelThings">
        /// a list of <see cref="ModelThing"/>s to which the deserialized items are added
        /// </param>
        protected virtual void ReadPreferredIdentifierFor(Constraint constraint, XmlReader reader, List<ModelThing> modelThings)
        {
            throw new NotSupportedException($"PreferredIdentifierFor is not allowed on the {nameof(Constraint)} abstract baseclass");
        }

        /// <summary>
        /// Reads ImpliedByObjectType <see cref="ObjectType"/>  from the .orm file
        /// </summary>
        /// <param name="constraint">
        /// The <see cref="Constraint"/> that contains the <see cref="ObjectType"/>s
        /// </param>
        /// <param name="reader">
        /// an instance of <see cref="XmlReader"/> used to read the .orm file
        /// </param>
        /// <param name="modelThings">
        /// a list of <see cref="ModelThing"/>s to which the deserialized items are added
        /// </param>
        protected virtual void ReadImpliedByObjectType(Constraint constraint, XmlReader reader, List<ModelThing> modelThings)
        {
            throw new NotSupportedException($"ImpliedByObjectType is not allowed on the {nameof(Constraint)} abstract baseclass");
        }

        /// <summary>
        /// Reads InherentForObjectType <see cref="ObjectType"/>  from the .orm file
        /// </summary>
        /// <param name="constraint">
        /// The <see cref="Constraint"/> that contains the <see cref="ObjectType"/>s
        /// </param>
        /// <param name="reader">
        /// an instance of <see cref="XmlReader"/> used to read the .orm file
        /// </param>
        /// <param name="modelThings">
        /// a list of <see cref="ModelThing"/>s to which the deserialized items are added
        /// </param>
        protected virtual void ReadInherentForObjectType(Constraint constraint, XmlReader reader, List<ModelThing> modelThings)
        {
            throw new NotSupportedException($"InherentForObjectType is not allowed on the {nameof(Constraint)} abstract baseclass");
        }

        /// <summary>
        /// Reads ExclusiveOrExclusionConstraint <see cref="ObjectType"/>  from the .orm file
        /// </summary>
        /// <param name="constraint">
        /// The <see cref="Constraint"/> that contains the <see cref="ObjectType"/>s
        /// </param>
        /// <param name="reader">
        /// an instance of <see cref="XmlReader"/> used to read the .orm file
        /// </param>
        /// <param name="modelThings">
        /// a list of <see cref="ModelThing"/>s to which the deserialized items are added
        /// </param>
        protected virtual void ReadExclusiveOrExclusionConstraint(Constraint constraint, XmlReader reader, List<ModelThing> modelThings)
        {
            throw new NotSupportedException($"ExclusiveOrExclusionConstraint is not allowed on the {nameof(Constraint)} abstract baseclass");
        }

        /// <summary>
        /// reads the contained <see cref="Definition"/>s
        /// </summary>
        /// <param name="constraint">
        /// The container <see cref="Constraint"/> of the <see cref="Definition"/>
        /// </param>
        /// <param name="reader">
        /// an instance of <see cref="XmlReader"/> used to read the .orm file
        /// </param>
        /// <param name="modelThings">
        /// a list of <see cref="ModelThing"/>s to which the deserialized items are added
        /// </param>
        private void ReadDefinitions(Constraint constraint, XmlReader reader, List<ModelThing> modelThings)
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
                                definition.Container = constraint.Id;
                                constraint.Definition = definition.Id;
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
        /// <param name="constraint">
        /// The container <see cref="Constraint"/> of the <see cref="Definition"/>
        /// </param>
        /// <param name="reader">
        /// an instance of <see cref="XmlReader"/> used to read the .orm file
        /// </param>
        /// <param name="modelThings">
        /// a list of <see cref="ModelThing"/>s to which the deserialized items are added
        /// </param>
        private void ReadNotes(Constraint constraint, XmlReader reader, List<ModelThing> modelThings)
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
                                note.Container = constraint.Id;
                                constraint.Note = note.Id;
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
