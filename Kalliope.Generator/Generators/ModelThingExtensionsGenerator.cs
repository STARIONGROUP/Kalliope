// -------------------------------------------------------------------------------------------------
// <copyright file="ModelThingExtensionsGenerator.cs" company="RHEA System S.A.">
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

namespace Kalliope.Generator.Generators
{
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    using DotLiquid;
    
    /// <summary>
    /// The purpose of the <see cref="ModelThingExtensionsGenerator"/> is to generate Kalliope ModelThing Extension class
    /// </summary>
    public class ModelThingExtensionsGenerator : Generator
    {
        /// <summary>
        /// name of the DTO Template
        /// </summary>
        private const string ModelThingExtensionsTemplate = "modelthing-extensions-template";

        /// <summary>
        /// Loads the liquid templates used for the generator
        /// </summary>
        public override void LoadTemplates()
        {
            this.LiquidTemplates.Add(ModelThingExtensionsTemplate, this.LoadTemplate(ModelThingExtensionsTemplate));
        }

        /// <summary>
        /// Generate the Extension class files 
        /// </summary>
        /// <param name="outputDirectory">
        /// The output Directory where the extension classes will be generated.
        /// </param>
        public override void Generate(DirectoryInfo outputDirectory)
        {
            base.Generate(outputDirectory);

            var drops = this.TypeDrops.Where(x => !x.IsAbstract).ToList();
            
            var generatedExtensionClass = this.GenerateType(drops);
            
            var filePath = Path.Combine(outputDirectory.FullName, "ModelThingExtensions.cs");

            File.WriteAllText(filePath, generatedExtensionClass);
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
        public string GenerateType(List<TypeDrop> drops)
        {
            string modelThingExtensionsTemplate;
            if (!this.LiquidTemplates.TryGetValue(ModelThingExtensionsTemplate, out modelThingExtensionsTemplate))
            {
                throw new KeyNotFoundException("Could not load the ModelThing Extensions Template");
            }

            var template = Template.Parse(modelThingExtensionsTemplate);

            var code = template.Render(Hash.FromAnonymousObject(new { TypeDrops = drops }));

            return this.RemoveRedundantLines(code);
        }
    }
}
