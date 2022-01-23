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

    /// <summary>
    /// Definition of elements used in the primary definition of an ORM model
    /// </summary>
    public class ORMModel : ORMNamedElement
    {
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
    }
}
