// -------------------------------------------------------------------------------------------------
// <copyright file="PocoFactoryGenerator.cs" company="RHEA System S.A.">
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

namespace Kalliope.Generator.Generators
{
    using System;
    using System.IO;
    using System.Linq;

    using DotLiquid;

    /// <summary>
    /// The purpose of the <see cref="PocoFactoryGenerator"/> is to generate Kalliope POCO factory classes
    /// </summary>
    public class PocoFactoryGenerator : Generator
    {
        /// <summary>
        /// name of the POCO Factory Template
        /// </summary>
        private const string PocoFactorytemplate = "poco-factory-class-template";

        /// <summary>
        /// Loads the liquid templates used for the generator
        /// </summary>
        public override void LoadTemplates()
        {
            this.LiquidTemplates.Add(PocoFactorytemplate, this.LoadTemplate(PocoFactorytemplate));
        }

        /// <summary>
        /// Generate the DTO class files
        /// </summary>
        /// <param name="outputDirectory">
        /// The output Directory where the DTO's will be generated.
        /// </param>
        public override void Generate(DirectoryInfo outputDirectory)
        {
            base.Generate(outputDirectory);

            foreach (var drop in this.TypeDrops.Where(x => x.IsAbstract == false))
            {
                var generatedType = this.GenerateType(drop);

                var fileName = $"{drop.Name}Factory.cs";
                var filePath = Path.Combine(outputDirectory.FullName, fileName);

                File.WriteAllText(filePath, generatedType);
            }
        }

        /// <summary>
        /// Generate the code for a <see cref="TypeDrop"/>
        /// </summary>
        /// <param name="drop">
        /// The subject <see cref="TypeDrop"/>
        /// </param>
        /// <returns>
        /// returns the generated code
        /// </returns>
        public string GenerateType(TypeDrop drop)
        {
            string pocoFactorytemplate;
            if (!this.LiquidTemplates.TryGetValue(PocoFactorytemplate, out pocoFactorytemplate))
            {
                throw new Exception("Could not load the POCO Factory Template");
            }

            var template = Template.Parse(pocoFactorytemplate);

            var code = template.Render(Hash.FromAnonymousObject(new { TypeDrop = drop }));

            return this.RemoveRedundantLines(code);
        }
    }
}
