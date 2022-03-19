// -------------------------------------------------------------------------------------------------
// <copyright file="OrmFileReader.cs" company="RHEA System S.A.">
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

namespace Kalliope.Xml
{
    using System;
    using System.Threading.Tasks;

    using Kalliope.Dal;

    using Microsoft.Extensions.Logging;
    using Microsoft.Extensions.Logging.Abstractions;

    public class OrmFileReader
    {
        /// <summary>
        /// The (injected) <see cref="ILoggerFactory"/> used to setup logging
        /// </summary>
        private readonly ILoggerFactory loggerFactory;

        /// <summary>
        /// The <see cref="ILogger"/> used to log
        /// </summary>
        private readonly ILogger<OrmFileReader> logger;

        /// <summary>
        /// Initializes a new instance of the <see cref="OrmFileReader"/>
        /// </summary>
        /// <param name="loggerFactory">
        /// The (injected) <see cref="ILoggerFactory"/> used to setup logging
        /// </param>
        public OrmFileReader(ILoggerFactory loggerFactory = null)
        {
            this.loggerFactory = loggerFactory;

            this.logger = this.loggerFactory == null ? NullLogger<OrmFileReader>.Instance : this.loggerFactory.CreateLogger<OrmFileReader>();
        }

        /// <summary>
        /// Gets the <see cref="Assembler"/> associated with the FileReader
        /// </summary>
        public Assembler Assembler { get; private set; }

        /// <summary>
        /// Gets or sets the (injected) <see cref="IOrmXmlReader"/>
        /// </summary>
        public IOrmXmlReader OrmXmlReader { get; set; }

        /// <summary>
        /// Opens a file and populates the cache of the associated <see cref="Assembler"/>
        /// </summary>
        /// <param name="xmlFilePath">
        /// The Path of the .orm file to read
        /// </param>
        /// <returns></returns>
        public void Read(string xmlFilePath)
        {
            var uri = new Uri(xmlFilePath);
            
            var dtos = this.OrmXmlReader.Read(xmlFilePath, false, null);

            this.Assembler = new Assembler();
            this.Assembler.Synchronize(dtos);
        }

        public async Task Write()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Closes the file
        /// </summary>
        public void Close()
        {
            throw new NotImplementedException();
        }
    }
}
