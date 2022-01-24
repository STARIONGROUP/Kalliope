// -------------------------------------------------------------------------------------------------
// <copyright file="ORMModel.cs" company="RHEA System S.A.">
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

namespace Kalliope.Core
{
    using System.Collections.Generic;
    using System.Xml;

    using Microsoft.Extensions.Logging;

    /// <summary>
    /// Definition of elements used in the primary definition of an ORM model
    /// </summary>
    public class ORMModel : ORMNamedElement
    {
        /// <summary>
        /// The (injected) <see cref="ILoggerFactory"/> used to setup logging
        /// </summary>
        private readonly ILoggerFactory loggerFactory;

        /// <summary>
        /// Initializes a new instance of the <see cref="ORMModel"/> class
        /// </summary>
        public ORMModel()
        { 
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ORMModel"/> class.
        /// </summary>
        /// <param name="loggerFactory">
        /// The (injected) <see cref="ILoggerFactory"/> used to setup logging
        /// </param>
        internal ORMModel(ILoggerFactory loggerFactory)
        {
            this.loggerFactory = loggerFactory;
        }

        /// <summary>
        /// An informal description of this Model.
        /// To insert new lines, use Control-Enter in the dropdown editor, or open the 'ORM Informal Description Editor' tool window
        /// </summary>
        public string DefinitionText { get; set; }

        /// <summary>
        /// A note to associate with this Model.
        /// To insert new lines, use Control-Enter in the dropdown editor, or open the 'ORM Notes Editor' tool window
        /// </summary>
        public string NoteText { get; set; }

        /// <summary>
        /// The value of the referenced element's unique id
        /// </summary>
        public string Reference { get; set; }

        /// <summary>
        /// The <see cref="Definitions"/>s contained by the <see cref="ORMModel"/>
        /// </summary>
        public List<Definition> Definitions { get; set; }

        /// <summary>
        /// The <see cref="Note"/>s contained by the <see cref="ORMModel"/>
        /// </summary>
        public List<Note> Notes { get; set; }

        /// <summary>
        /// The <see cref="ObjectType"/>s contained by the <see cref="ORMModel"/>
        /// </summary>
        public List<ObjectType> Objects { get; set; }

        /// <summary>
        /// The <see cref="FactType"/>s contained by the <see cref="ORMModel"/>
        /// </summary>
        public List<FactType> Facts { get; set; }

        /// <summary>
        /// The <see cref="DataType"/>s contained by the <see cref="ORMModel"/>
        /// </summary>
        public List<DataType> DataTypes { get; set; }

        /// <summary>
        /// The <see cref="Function"/>s contained by the <see cref="ORMModel"/>
        /// </summary>
        public List<Function> Functions { get; set; }

        /// <summary>
        /// The <see cref="CustomReferenceMode"/>s contained by the <see cref="ORMModel"/>
        /// </summary>
        public List<CustomReferenceMode> CustomReferenceModes { get; set; }

        /// <summary>
        /// The <see cref="ModelNote"/>s contained by the <see cref="ORMModel"/>
        /// </summary>
        public List<ModelNote> ModelNotes { get; set; }

        /// <summary>
        /// The <see cref="ModelError"/>s contained by the <see cref="ORMModel"/>
        /// </summary>
        public List<ModelError> ModelErrors { get; set; }

        /// <summary>
        /// The <see cref="ReferenceModeKind"/>s contained by the <see cref="ORMModel"/>
        /// </summary>
        public List<ReferenceModeKind> ReferenceModeKinds { get; set; }

        /// <summary>
        /// The <see cref="RecognizedPhrase"/>s contained by the <see cref="ORMModel"/>
        /// </summary>
        public List<RecognizedPhrase> RecognizedPhrases { get; set; }

        /// <summary>
        /// The <see cref="Extension"/>s contained by the <see cref="ORMModel"/>
        /// </summary>
        public List<Extension> Extensions { get; set; }


        /// <summary>
        /// Generates a <see cref="ORMModel"/> object from its XML representation.
        /// </summary>
        /// <param name="reader">
        /// an instance of <see cref="XmlReader"/>
        /// </param>
        internal void ReadXml(XmlReader reader)
        {
            this.Id = reader.GetAttribute("id");
            this.Name = reader.GetAttribute("Name");
        }
    }
}
