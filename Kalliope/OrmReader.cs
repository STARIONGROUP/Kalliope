// -------------------------------------------------------------------------------------------------
// <copyright file="OrmReader.cs" company="RHEA System S.A.">
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
    using System;
    using System.Diagnostics;
    using System.IO;
    using System.Threading;
    using System.Threading.Tasks;
    using System.Xml.Schema;

    using Kalliope.Core;

    using Microsoft.Extensions.Logging;
    using Microsoft.Extensions.Logging.Abstractions;

    /// <summary>
    /// The purpose of the <see cref="OrmReader"/> is to read .orm models and return the content as an object graph
    /// </summary>
    public class OrmReader : IOrmReader
    {
        /// <summary>
        /// The (injected) <see cref="ILoggerFactory"/> used to setup logging
        /// </summary>
        private readonly ILoggerFactory loggerFactory;

        /// <summary>
        /// The <see cref="ILogger"/> used to log
        /// </summary>
        private readonly ILogger<OrmReader> logger;

        /// <summary>
        /// Initializes a new instance of the <see cref="OrmReader"/> class.
        /// </summary>
        /// <param name="loggerFactory">
        /// The (injected) <see cref="ILoggerFactory"/> used to setup logging
        /// </param>
        public OrmReader(ILoggerFactory loggerFactory = null)
        {
            this.loggerFactory = loggerFactory;

            this.logger = this.loggerFactory == null ? NullLogger<OrmReader>.Instance : this.loggerFactory.CreateLogger<OrmReader>();
        }

        /// <summary>
        /// Reads a <see cref="ORMModel"/> from an .orm file
        /// </summary>
        /// <param name="xmlFilePath">
        /// The Path of the .orm file to deserialize
        /// </param>
        /// <param name="validate">
        /// a value indicating whether the XML document needs to be validated or not
        /// </param>
        /// <param name="validationEventHandler">
        /// The <see cref="ValidationEventHandler"/> that processes the result of the <see cref="ORMModel"/> validation.
        /// </param>
        /// <returns>
        /// A fully de-referenced <see cref="ORMModel"/> object graph
        /// </returns>
        public OrmRoot Read(string xmlFilePath, bool validate = false, ValidationEventHandler validationEventHandler = null)
        {
            if (string.IsNullOrEmpty(xmlFilePath))
            {
                throw new ArgumentException("The xml file path may not be null or empty");
            }

            using (var fileStream = File.OpenRead(xmlFilePath))
            {
                var sw = Stopwatch.StartNew();

                this.logger.LogTrace("start reading from {path}", xmlFilePath);

                var result = this.Read(fileStream, validate, validationEventHandler);

                this.logger.LogTrace("File {path} read in {time} [ms]", xmlFilePath, sw.ElapsedMilliseconds);

                return result;
            }
        }

        /// <summary>
        /// Reads a <see cref="ORMModel"/> from an .orm <see cref="Stream"/>
        /// </summary>
        /// <param name="stream">
        /// The <see cref="Stream"/> that contains the .orm file to read
        /// </param>
        /// <param name="validate">
        /// a value indicating whether the XML document needs to be validated or not
        /// </param>
        /// <param name="validationEventHandler">
        /// The <see cref="ValidationEventHandler"/> that processes the result of the <see cref="ORMModel"/> validation.
        /// </param>
        /// <returns>
        /// A fully de-referenced <see cref="ORMModel"/> object graph
        /// </returns>
        public OrmRoot Read(Stream stream, bool validate = false, ValidationEventHandler validationEventHandler = null)
        {
            if (!validate && validationEventHandler != null)
            {
                throw new ArgumentException("validationEventHandler must be null when validate is false");
            }

            if (stream == null)
            {
                throw new ArgumentNullException(nameof(stream), $"The {nameof(stream)} may not be null");
            }

            if (stream.Length == 0)
            {
                throw new ArgumentException($"The {nameof(stream)} may not be empty", nameof(stream));
            }

            return this.ReadOrmRoot(stream, validate, validationEventHandler);
        }

        /// <summary>
        /// Asynchronously reads a <see cref="ORMModel"/> from an .orm file
        /// </summary>
        /// <param name="xmlFilePath">
        /// The Path of the .orm file to deserialize
        /// </param>
        /// <param name="token">
        /// A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <param name="validate">
        /// a value indicating whether the XML document needs to be validated or not
        /// </param>
        /// <param name="validationEventHandler">
        /// The <see cref="ValidationEventHandler"/> that processes the result of the <see cref="ORMModel"/> validation.
        /// </param>
        /// <returns>
        /// A fully de-referenced <see cref="ORMModel"/> object graph
        /// </returns>
        public async Task<OrmRoot> ReadAsync(string xmlFilePath, CancellationToken token, bool validate = false, ValidationEventHandler validationEventHandler = null)
        {
            if (string.IsNullOrEmpty(xmlFilePath))
            {
                throw new ArgumentException("The xml file path may not be null or empty");
            }

            using (var fileStream = File.OpenRead(xmlFilePath))
            {
                var sw = Stopwatch.StartNew();

                this.logger.LogTrace("start reading from {path}", xmlFilePath);

                byte[] result = new byte[fileStream.Length];
                await fileStream.ReadAsync(result, 0, (int)fileStream.Length, token);

                this.logger.LogTrace("File {path} read in {time} [ms]", xmlFilePath, sw.ElapsedMilliseconds);

                return await this.ReadAsync(fileStream, token, validate, validationEventHandler);
            }
        }

        /// <summary>
        /// Asynchronously reads a <see cref="ORMModel"/> from an .orm <see cref="Stream"/>
        /// </summary>
        /// <param name="stream">
        /// The <see cref="Stream"/> that contains the .orm file to read
        /// </param>
        /// <param name="validate">
        /// a value indicating whether the XML document needs to be validated or not
        /// </param>
        /// <param name="validationEventHandler">
        /// The <see cref="ValidationEventHandler"/> that processes the result of the <see cref="ORMModel"/> validation.
        /// </param>
        /// <returns>
        /// A fully de-referenced <see cref="ORMModel"/> object graph
        /// </returns>
        public async Task<OrmRoot> ReadAsync(Stream stream, CancellationToken token, bool validate = false, ValidationEventHandler validationEventHandler = null)
        {
            if (!validate && validationEventHandler != null)
            {
                throw new ArgumentException("validationEventHandler must be null when validate is false");
            }

            if (stream == null)
            {
                throw new ArgumentNullException(nameof(stream), $"The {nameof(stream)} may not be null");
            }

            if (stream.Length == 0)
            {
                throw new ArgumentException($"The {nameof(stream)} may not be empty", nameof(stream));
            }

            return await this.ReadOrmAsync(stream, token, validate, validationEventHandler);
        }

        /// <summary>
        /// Read the provided <see cref="Stream"/> to <see cref="OrmRoot"/>
        /// </summary>
        /// <param name="stream">
        /// The <see cref="Stream"/> that contains the .orm file to deserialize
        /// </param>
        /// <param name="validate">
        /// a value indicating whether the XML document needs to be validated or not
        /// </param>
        /// <param name="validationEventHandler">
        /// The <see cref="ValidationEventHandler"/> that processes the result of the <see cref="ORMModel"/> validation.
        /// </param>
        /// <returns>
        /// Fully de-referenced <see cref="OrmRoot"/> object graph
        /// </returns>
        private OrmRoot ReadOrmRoot(Stream stream, bool validate = false, ValidationEventHandler validationEventHandler = null)
        {
            var ormRoot = new OrmRoot(this.loggerFactory);
            return ormRoot;
        }

        /// <summary>
        /// Asynchronously read the provided <see cref="Stream"/> to <see cref="ORMModel"/>
        /// </summary>
        /// <param name="stream">
        /// The <see cref="Stream"/> that contains the .orm file to deserialize
        /// </param>
        /// <param name="token">
        /// A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <param name="validate">
        /// a value indicating whether the XML document needs to be validated or not
        /// </param>
        /// <param name="validationEventHandler">
        /// The <see cref="ValidationEventHandler"/> that processes the result of the <see cref="ORMModel"/> validation.
        /// </param>
        /// <returns>
        /// Fully de-referenced <see cref="ORMModel"/> object graph
        /// </returns>
        private Task<OrmRoot> ReadOrmAsync(Stream stream, CancellationToken token, bool validate = false, ValidationEventHandler validationEventHandler = null)
        {
            throw new NotImplementedException();
        }
    }
}
