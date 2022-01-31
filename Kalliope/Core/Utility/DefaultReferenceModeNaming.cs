// -------------------------------------------------------------------------------------------------
// <copyright file="DefaultReferenceModeNaming.cs" company="RHEA System S.A.">
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
    /// Represent a set of defaults for how reference modes should be used in generated code.
    /// This type must be extended in extension models to associate another element as the owning context for this default
    /// </summary>
    public abstract class DefaultReferenceModeNaming
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DefaultReferenceModeNaming"/> class.
        /// </summary>
        protected DefaultReferenceModeNaming()
        {
            this.NamingChoice = EffectiveReferenceModeNamingChoice.ValueTypeName;
            this.PrimaryIdentifierNamingChoice = EffectiveReferenceModeNamingChoice.ValueTypeName;
            this.ReferenceModeTargetKind = ReferenceModeType.Popular;
        }

        /// <summary>
        /// A unique identifier for this element
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// pecify if these are the defaults for popular, unit based, or general reference modes
        /// </summary>
        public ReferenceModeType ReferenceModeTargetKind { get; set; }

        /// <summary>
        /// Specify how a reference to a reference-mode identified instance is to be represented
        /// </summary>
        public EffectiveReferenceModeNamingChoice NamingChoice { get; set; }

        /// <summary>
        /// Specify how the primary identifier of a reference-mode identified instance is to be represented
        /// </summary>
        public EffectiveReferenceModeNamingChoice PrimaryIdentifierNamingChoice { get; set; }

        /// <summary>
        /// May be set if NamingChoice is CustomFormat.
        /// The replacement field {0} is the ValueTypeName, {1} is the EntityTypeName, and {2} is the ReferenceModeName
        /// </summary>
        public string CustomFormat { get; set; }

        /// <summary>
        /// May be set if PrimaryIdentifierNamingChoice is CustomFormat.
        /// The replacement field {0} is the ValueTypeName, {1} is the EntityTypeName, and {2} is the ReferenceModeName
        /// </summary>
        public string PrimaryIdentifierCustomFormat { get; set; }
    }
}
