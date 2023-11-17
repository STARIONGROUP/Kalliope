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

                        case "RoleSequences":
                            using (var roleSequencesSubtree = reader.ReadSubtree())
                            {
                                roleSequencesSubtree.MoveToContent();
                                this.ReadRoleSequences(constraint, roleSequencesSubtree, modelThings);
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
        protected virtual void ReadRoleSequences(Constraint constraint, XmlReader reader, List<ModelThing> modelThings)
        {
            throw new NotSupportedException($"RoleSequences is not allowed on the {nameof(Constraint)} abstract baseclass");
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
