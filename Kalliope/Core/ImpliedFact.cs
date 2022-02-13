﻿// -------------------------------------------------------------------------------------------------
// <copyright file="ImpliedFactType.cs" company="RHEA System S.A.">
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
    using System.Xml;

    public class ImpliedFactType : FactType
    {
        private string impliedByObjectificationReference = string.Empty;

        /// <summary>
        /// Initializes a new instance of the <see cref="SubtypeFact"/> class
        /// </summary>
        /// <param name="model">
        /// The <see cref="ORMModel"/> that contains the current <see cref="SubtypeFact"/>
        /// </param>
        public ImpliedFactType(ORMModel model)
        {
            this.Model = model;
            model.FactTypes.Add(this);
        }

        /// <summary>
        /// Gets or sets the referenced <see cref="Objectification"/>
        /// </summary>
        public Objectification ImpliedByObjectification { get; set; }

        /// <summary>
        /// Reads <see cref="Role"/>s from the .orm file
        /// </summary>
        /// <param name="reader">
        /// an instance of <see cref="XmlReader"/> used to read the .orm file
        /// </param>
        internal override void ReadImpliedByObjectification(XmlReader reader)
        {
            var impliedByObjectificationReference = reader.GetAttribute("ref");
        }
    }
}