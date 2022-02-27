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

namespace Kalliope.DTO
{
    using System;
    using System.Collections.Generic;
 
    using Kalliope.Common;
 
    /// <summary>
    /// 
    /// </summary>
    public  abstract partial class DefaultReferenceModeNaming
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DefaultReferenceModeNaming"/> class.
        /// </summary>
        protected  DefaultReferenceModeNaming()
        {
            this.NamingChoice = EffectiveReferenceModeNamingChoice.ValueTypeName;
            this.PrimaryIdentifierNamingChoice = EffectiveReferenceModeNamingChoice.ValueTypeName;
            this.ReferenceModeTargetKind = ReferenceModeType.Popular;
        }
 
        /// <summary>
        /// Gets or sets a CustomFormat
        /// </summary>
        public string CustomFormat { get; set; }
 
        /// <summary>
        /// Gets or sets a Id
        /// </summary>
        public string Id { get; set; }
 
        /// <summary>
        /// Gets or sets a NamingChoice
        /// </summary>
        public EffectiveReferenceModeNamingChoice NamingChoice { get; set; }
 
        /// <summary>
        /// Gets or sets a PrimaryIdentifierCustomFormat
        /// </summary>
        public string PrimaryIdentifierCustomFormat { get; set; }
 
        /// <summary>
        /// Gets or sets a PrimaryIdentifierNamingChoice
        /// </summary>
        public EffectiveReferenceModeNamingChoice PrimaryIdentifierNamingChoice { get; set; }
 
        /// <summary>
        /// Gets or sets a ReferenceModeTargetKind
        /// </summary>
        public ReferenceModeType ReferenceModeTargetKind { get; set; }
 
    }
}
