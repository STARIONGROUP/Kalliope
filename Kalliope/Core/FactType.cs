// -------------------------------------------------------------------------------------------------
// <copyright file="FactType.cs" company="RHEA System S.A.">
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
    /// <summary>
    /// A fact type directly specified by the modeler
    /// </summary>
    public class FactType : ORMModelElement
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FactType"/> class
        /// </summary>
        public FactType()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FactType"/> class
        /// </summary>
        /// <param name="model">
        /// The <see cref="ORMModel"/> that contains the current <see cref="FactType"/>
        /// </param>
        internal FactType(ORMModel model)
            : this()
        {
            this.Model = model;
        }

        /// <summary>
        /// Gets or sets the container <see cref="ORMModel"/>
        /// </summary>
        public ORMModel Model { get; set; }

        /// <summary>
        /// This fact type is externally defined (not used)
        /// </summary>
        public bool IsExternal { get; set; }

        /// <summary>
        /// An informal description of this FactType.
        /// To insert new lines, use Control-Enter in the dropdown editor, or open the 'ORM Informal Description Editor' tool window
        /// </summary>
        public string DefinitionText { get; set; }

        /// <summary>
        /// A note to associate with this FactType.
        /// To insert new lines, use Control-Enter in the dropdown editor, or open the 'ORM Notes Editor' tool window
        /// </summary>
        public string NoteText { get; set; }

        /// <summary>
        /// The name for this FactType.
        /// If the Name property is read-only, then it is a generated name based on primary reading.
        /// If the Name property is editable, then it is the name of an explicit or implicit objectifying EntityType
        /// The editable name can be reset to match the generated name by clearing the property value
        /// </summary>
        public string Name { get; set; }

        public int NameChanged { get; set; }

        /// <summary>
        /// A description of the derivation rule for this FactType
        /// </summary>
        public string DerivationNoteDisplay { get; set; }

        public DerivationExpressionStorageType DerivationStorageDisplay { get; set; }
    }
}
