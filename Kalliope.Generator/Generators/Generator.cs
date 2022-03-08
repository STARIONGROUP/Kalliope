// -------------------------------------------------------------------------------------------------
// <copyright file="Generator.cs" company="RHEA System S.A.">
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

namespace Kalliope.Generator
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;

    using DotLiquid;
    using DotLiquid.NamingConventions;
    
    /// <summary>
    /// Abstract superclass from which all generators should derive
    /// </summary>
    public abstract class Generator
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GeneratorBase"/> class.
        /// </summary>
        protected Generator()
        {
            Template.NamingConvention = new CSharpNamingConvention();
            this.RegisterSafeTypes();
            this.RegisterFilters();

            this.LiquidTemplates = new Dictionary<string, string>();
        }

        /// <summary>
        /// Gets the list of templates associated to this generator
        /// </summary>
        public Dictionary<string, string> LiquidTemplates { get; private set; }

        /// <summary>
        /// Loads the liquid templates used for the generator
        /// </summary>
        public abstract void LoadTemplates();

        /// <summary>
        /// Generate the source code
        /// </summary>
        /// <param name="outputDirectory">
        /// The output Directory where the source code files will be generated
        /// </param>
        public virtual void Generate(DirectoryInfo outputDirectory)
        {
            if (!this.LiquidTemplates.Any())
            {
                throw new InvalidOperationException("The templates need to be loaded before the Generate method can be invoked");
            }
            
            if (!outputDirectory.Exists)
            {
                throw new DirectoryNotFoundException($"The directory with path: {outputDirectory.FullName} does not exist.");
            }

            foreach (var fileInfo in outputDirectory.EnumerateFiles())
            {
                fileInfo.Delete();
            }
        }

        /// <summary>
        /// load a liquid template by name
        /// </summary>
        /// <param name="name">
        /// The name of the template excluding the extension
        /// </param>
        /// <returns>
        /// The content of the template
        /// </returns>
        public string LoadTemplate(string name)
        {
            var path = Path.Combine("Templates", $"{name}.liquid");

            return File.ReadAllText(path);
        }

        /// <summary>
        /// Register safe types with the DotLiquid <see cref="Template"/>
        /// </summary>
        protected virtual void RegisterSafeTypes()
        {
            var registrar = new TypeRegistrar.TypeRegistrar();
            registrar.RegisterKalliopeCommonTypes();
            registrar.RegisterKalliopeTypes();
        }

        /// <summary>
        /// Register custom filters with the DotLiquid <see cref="Template"/>
        /// </summary>
        protected virtual void RegisterFilters()
        {
        }

        /// <summary>
        /// Removes the lines from the code that start with a tab character
        /// </summary>
        /// <param name="code">
        /// The code snippet from which the tab-lines need to removed
        /// </param>
        /// <returns>
        /// a multi-line string that contains no lines that start with a tab
        /// </returns>
        protected virtual string RemoveRedundantLines(string code)
        {
            StringBuilder sb;

            // removed tabbed lines
            var lines = code.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
            var upperbound = lines.GetUpperBound(0);
            sb = new StringBuilder();
            for (int i = 0; i < upperbound; i++)
            {
                if (!lines[i].StartsWith("\t"))
                {
                    sb.AppendLine(lines[i]);
                }
            }

            // remove consecutive empty lines
            lines = sb.ToString().Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
            upperbound = lines.GetUpperBound(0);
            sb = new StringBuilder();
            for (int i = 0; i < upperbound; i++)
            {
                if (lines[i] == "" && lines[i + 1] == "")
                {
                    continue;
                }

                if (lines[i] == "" && lines[i + 1].Contains("}"))
                {
                    continue;
                }

                sb.AppendLine(lines[i]);
            }

            return sb.ToString();
        }
    }
}
