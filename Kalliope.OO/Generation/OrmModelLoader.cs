// -------------------------------------------------------------------------------------------------
// <copyright file="OrmModelLoader.cs" company="RHEA System S.A.">
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
// -------------------------------------------------------------------------------------------------

namespace Kalliope.OO.Generation
{
    using System.IO;
    using System.Linq;

    using Kalliope;
    using Kalliope.Xml;

    /// <summary>
    /// The purpose of the <see cref="OrmModelLoader"/> is to load an ORM model from an XML file
    /// </summary>
    public static class OrmModelLoader
    {
        /// <summary>
        /// Creates a new instance of <see cref="ClassGenerator"/>
        /// </summary>
        /// <param name="modelLocation">
        /// The path to the subject ORM Model
        /// </param>
        /// <returns>
        /// the root <see cref="OrmRoot"/>
        /// </returns>
        public static OrmRoot Load(string modelLocation)
        {
            if (!File.Exists(modelLocation))
            {
                throw new FileNotFoundException($"File {modelLocation} not found.");
            }

            var ormXmlReader = new OrmXmlReader();

            var fileReader = new OrmFileReader
            {
                OrmXmlReader = ormXmlReader
            };

            fileReader.Read(modelLocation);

            var cache = fileReader.Assembler.Cache;

            var lazyPoco = cache.SingleOrDefault(x => x.Key.StartsWith("root:_")).Value;

            var ormRoot = lazyPoco?.Value as OrmRoot;

            return ormRoot;
        }
    }
}
