// -------------------------------------------------------------------------------------------------
// <copyright file="DtoGenerator.cs" company="RHEA System S.A.">
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
    using System.Collections.Generic;
    using System.IO;

    using DotLiquid;
    
    /// <summary>
    /// The purpose of the <see cref="DtoGenerator"/> is to generate Kalliope DTO
    /// </summary>
    public class DtoGenerator : Generator
    {
        /// <summary>
        /// name of the DTO Template
        /// </summary>
        private const string Dtotemplate = "dto-class-template";

        /// <summary>
        /// Loads the liquid templates used for the generator
        /// </summary>
        public override void LoadTemplates()
        {
            this.LiquidTemplates.Add(Dtotemplate, this.LoadTemplate(Dtotemplate));
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
            
            foreach (var drop in this.TypeDrops)
            {
                var generatedType = this.GenerateType(drop);

                var fileName = $"{drop.Name}.cs";
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
            string dtoTemplate;
            if (!this.LiquidTemplates.TryGetValue(Dtotemplate, out dtoTemplate))
            {
                throw new KeyNotFoundException("Could not load the DTO Template");
            }

            var template = Template.Parse(dtoTemplate);

            var code = template.Render(Hash.FromAnonymousObject(new { TypeDrop = drop }));

            return this.RemoveRedundantLines(code);
        }
    }
}
