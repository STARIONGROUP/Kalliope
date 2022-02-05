// -------------------------------------------------------------------------------------------------
// <copyright file="OrmRoot.cs" company="RHEA System S.A.">
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

namespace Kalliope
{
    using System.Collections.Generic;
    using System.Xml;

    using Kalliope.Core;
    using Kalliope.Diagrams;

    using Microsoft.Extensions.Logging;

    /// <summary>
    /// The <see cref="OrmRoot"/> represents the root node of an .orm file
    /// </summary>
    public class OrmRoot
    {
        /// <summary>
        /// The (injected) <see cref="ILoggerFactory"/> used to setup logging
        /// </summary>
        private readonly ILoggerFactory loggerFactory;

        /// <summary>
        /// Initializes a new instance of the <see cref="OrmRoot"/> class
        /// </summary>
        public OrmRoot()
        {
            this.Diagrams = new List<ORMDiagram>();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrmRoot"/> class.
        /// </summary>
        /// <param name="loggerFactory">
        /// The (injected) <see cref="ILoggerFactory"/> used to setup logging
        /// </param>
        internal OrmRoot(ILoggerFactory loggerFactory) : this()
        {
            this.loggerFactory = loggerFactory;
        }

        /// <summary>
        /// Gets or sets the <see cref="ORMModel"/> contained by .orm file
        /// </summary>
        public ORMModel Model { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="NameGenerator"/> contained by .orm file
        /// </summary>
        public NameGenerator NameGenerator { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="GenerationState"/> contained by .orm file
        /// </summary>
        public GenerationState GenerationState { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="ORMDiagram"/>s contained by the .orm file
        /// </summary>
        public List<ORMDiagram> Diagrams { get; set; }

        /// <summary>
        /// Generates a <see cref="ORMModel"/> object from its XML representation.
        /// </summary>
        /// <param name="reader">
        /// an instance of <see cref="XmlReader"/>
        /// </param>
        internal void ReadXml(XmlReader reader)
        {
            while (reader.Read())
            {
                if (reader.MoveToContent() == XmlNodeType.Element)
                {
                    var localName = reader.LocalName;

                    switch (localName)
                    {
                        case "ORMModel":
                            using (var ormModelSubtree = reader.ReadSubtree())
                            {
                                ormModelSubtree.MoveToContent();
                                var ormModel = new ORMModel(this.loggerFactory);
                                ormModel.ReadXml(ormModelSubtree);
                                this.Model = ormModel;
                            }
                            break;
                        case "NameGenerator":
                            using (var nameGeneratorSubtree = reader.ReadSubtree())
                            {
                                nameGeneratorSubtree.MoveToContent();
                                var nameGenerator = new NameGenerator();
                                nameGenerator.ReadXml(nameGeneratorSubtree);
                                this.NameGenerator = nameGenerator;
                            }
                            break;
                        case "GenerationState":
                            using (var generationStateSubTree = reader.ReadSubtree())
                            {
                                generationStateSubTree.MoveToContent();
                                var generationState = new GenerationState();
                                generationState.ReadXml(generationStateSubTree);
                                this.GenerationState = generationState;
                            }
                            break;
                        case "ORMDiagram":
                            using (var diagramSubtree = reader.ReadSubtree())
                            {
                                diagramSubtree.MoveToContent();
                                var ormDiagram = new ORMDiagram();
                                ormDiagram.ReadXml(diagramSubtree);

                                this.Diagrams.Add(ormDiagram);
                            }
                            break;
                    }
                }
            }
        }
    }
}
