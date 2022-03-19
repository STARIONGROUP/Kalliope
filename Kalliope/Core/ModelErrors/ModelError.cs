// -------------------------------------------------------------------------------------------------
// <copyright file="ModelError.cs" company="RHEA System S.A.">
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
    using Kalliope.Common;

    [Description("")]
    [Domain(isAbstract: true, general: "ORMModelElement")]
    [Container(typeName: "ORMModel", propertyName: "Errors")]
    public abstract class ModelError : ORMModelElement
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ModelError"/> class.
        /// </summary>
        protected ModelError()
        {
            this.ErrorState = ModelErrorState.Error;
        }
        
        /// <summary>
        /// Description of the model validation error
        /// </summary>
        [Description("")]
        [Property(name: "ErrorText", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.String, defaultValue: "", typeName: "")]
        public string ErrorText { get; set; }

        [Description("")]
        [Property(name: "ErrorState", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Enumeration, defaultValue: "Error", typeName: "ModelErrorState")]
        public ModelErrorState ErrorState { get; set; }
    }
}
