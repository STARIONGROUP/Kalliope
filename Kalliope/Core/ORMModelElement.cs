// -------------------------------------------------------------------------------------------------
// <copyright file="OrmModelElement.cs" company="RHEA System S.A.">
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

namespace Kalliope.Core
{
    using System.Collections.Generic;

    using Kalliope.Common;
    
    [Description("")]
    [Domain(isAbstract: true, general: "ModelThing")]
    public abstract class OrmModelElement : ModelThing
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrmModelElement"/> class
        /// </summary>
        protected OrmModelElement()
        {
            this.AssociatedModelErrors = new List<ModelError>();
            this.ExtensionModelErrors = new List<ModelError>();
            this.Extensions = new List<Extension>();
        }
        
        [Description("")]
        [Property(name: "ExtensionModelErrors", aggregation: AggregationKind.None, multiplicity: "0..*", typeKind: TypeKind.Object, defaultValue: "", typeName: "ModelError")]
        public List<ModelError> ExtensionModelErrors { get; set; }

        [Description("")]
        [Property(name: "AssociatedModelErrors", aggregation: AggregationKind.None, multiplicity: "0..*", typeKind: TypeKind.Object, defaultValue: "", typeName: "ModelError")]
        public List<ModelError> AssociatedModelErrors { get; set; }

        /// <summary>
        /// Gets or sets the contained Extensions 
        /// </summary>
        [Description("extension data related to the containing element")]
        [Property(name: "Extensions", aggregation: AggregationKind.Composite, multiplicity: "0..*", typeKind: TypeKind.Object, defaultValue: "", typeName: "Extension")]
        public List<Extension> Extensions { get; set; }
    }
}
