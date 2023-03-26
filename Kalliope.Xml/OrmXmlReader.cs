// -------------------------------------------------------------------------------------------------
// <copyright file="OrmXmlReader.cs" company="RHEA System S.A.">
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

namespace Kalliope.Xml
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.IO;
    using System.Reflection;
    using System.Resources;
    using System.Threading;
    using System.Threading.Tasks;
    using System.Xml;
    using System.Xml.Schema;

    using Kalliope.DTO;
    using Kalliope.Xml.Readers;

    using Microsoft.Extensions.Logging;
    using Microsoft.Extensions.Logging.Abstractions;

    /// <summary>
    /// The purpose of the <see cref="OrmXmlReader"/> is to read .orm models and return the content as an object graph
    /// </summary>
    public class OrmXmlReader : IOrmXmlReader
    {
        /// <summary>
        /// The <see cref="ILogger"/> used to log
        /// </summary>
        private readonly ILogger<OrmXmlReader> logger;

        /// <summary>
        /// Initializes a new instance of the <see cref="OrmXmlReader"/> class.
        /// </summary>
        /// <param name="loggerFactory">
        /// The (injected) <see cref="ILoggerFactory"/> used to setup logging
        /// </param>
        public OrmXmlReader(ILoggerFactory loggerFactory = null)
        {
            this.logger = loggerFactory == null ? NullLogger<OrmXmlReader>.Instance : loggerFactory.CreateLogger<OrmXmlReader>();
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
        /// An <see cref="IEnumerable{ModelThing}"/> which have been read from the data-source
        /// </returns>
        public IEnumerable<DTO.ModelThing> Read(string xmlFilePath, bool validate = false, ValidationEventHandler validationEventHandler = null)
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
        /// An <see cref="IEnumerable{ModelThing}"/> which have been read from the data-source
        /// </returns>
        public IEnumerable<DTO.ModelThing> Read(Stream stream, bool validate = false, ValidationEventHandler validationEventHandler = null)
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
        /// An <see cref="IEnumerable{ModelThing}"/> which have been read from the data-source
        /// </returns>
        public async Task<IEnumerable<DTO.ModelThing>> ReadAsync(string xmlFilePath, CancellationToken token, bool validate = false, ValidationEventHandler validationEventHandler = null)
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
        /// An <see cref="IEnumerable{ModelThing}"/> which have been read from the data-source
        /// </returns>
        public async Task<IEnumerable<DTO.ModelThing>> ReadAsync(Stream stream, CancellationToken token, bool validate = false, ValidationEventHandler validationEventHandler = null)
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
        /// An <see cref="IEnumerable{ModelThing}"/> which have been read from the data-source
        /// </returns>
        private IEnumerable<DTO.ModelThing> ReadOrmRoot(Stream stream, bool validate = false, ValidationEventHandler validationEventHandler = null)
        {
            XmlReader xmlReader;

            var settings = this.CreateXmlReaderSettings(validate, validationEventHandler);

            this.logger.LogTrace("reading from ORM file");

            var result = new List<DTO.ModelThing>();

            using (xmlReader = XmlReader.Create(stream, settings))
            {
                var sw = Stopwatch.StartNew();

                OrmRoot ormRoot = null;

                this.logger.LogTrace("starting to read xml");

                while (xmlReader.Read())
                {
                    if ((xmlReader.NodeType == XmlNodeType.Element) && (xmlReader.Name == "ormRoot:ORM2"))
                    {
                        ormRoot = new OrmRoot();
                        var ormRootXmlReader = new OrmRootXmlReader();
                        ormRootXmlReader.ReadXml(ormRoot, xmlReader, result);
                        result.Add(ormRoot);
                    }
                }

                this.logger.LogTrace("xml read in {time}", sw.ElapsedMilliseconds);
                sw.Stop();
            }

            return result;
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
        /// An <see cref="IEnumerable{ModelThing}"/> which have been read from the data-source
        /// </returns>
        private Task<IEnumerable<DTO.ModelThing>> ReadOrmAsync(Stream stream, CancellationToken token, bool validate = false, ValidationEventHandler validationEventHandler = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Creates an instance of <see cref="XmlReaderSettings"/> with or without validation settings
        /// </summary>
        /// <param name="validate">
        /// a value indicating whether the <see cref="XmlReaderSettings"/> should be created with validation settings or not
        /// </param>
        /// <param name="validationEventHandler">
        /// The <see cref="ValidationEventHandler"/> that processes the result of the <see cref="ORMModel"/> validation.
        /// </param>
        /// <returns>
        /// An instance of <see cref="XmlReaderSettings"/>
        /// </returns>
        private XmlReaderSettings CreateXmlReaderSettings(bool validate = false, ValidationEventHandler validationEventHandler = null, bool asynchronous = false)
        {
            XmlReaderSettings settings;

            if (validate)
            {
                settings = new XmlReaderSettings { ValidationType = ValidationType.Schema };
                settings.ValidationFlags |= XmlSchemaValidationFlags.ProcessInlineSchema;
                settings.ValidationFlags |= XmlSchemaValidationFlags.ProcessSchemaLocation;
                settings.ValidationFlags |= XmlSchemaValidationFlags.ReportValidationWarnings;
                settings.ValidationEventHandler += validationEventHandler;

                var schemaSet = new XmlSchemaSet { XmlResolver = new OrmSchemaResolver() };

                // add validation schema
                schemaSet.Add(this.GetSchemaFromResource("ORM2Root.xsd", validationEventHandler));
                schemaSet.ValidationEventHandler += validationEventHandler;

                // now combine and use the custom xmlresolver to serve all xsd references from resource manifest
                schemaSet.Compile();

                // register the resolved schema set to the reader settings
                settings.Schemas.Add(schemaSet);
            }
            else
            {
                settings = new XmlReaderSettings();
            }

            settings.Async = asynchronous;

            return settings;
        }

        /// <summary>
        /// Gets the <see cref="ORMModel"/> schema for the embedded resources.
        /// </summary>
        /// <param name="resourceName">
        /// The resource Name.
        /// </param>
        /// <param name="validationEventHandler">
        /// The <see cref="ValidationEventHandler"/> that processes the result of the <see cref="ORMModel"/> validation.
        /// </param>
        /// <returns>
        /// An fully resolved instance of <see cref="XmlSchema"/>
        /// </returns>
        /// <exception cref="MissingManifestResourceException">
        /// the schema resource could not be found.
        /// </exception>
        private XmlSchema GetSchemaFromResource(string resourceName, ValidationEventHandler validationEventHandler)
        {
            var a = Assembly.GetExecutingAssembly();
            var type = this.GetType();
            var @namespace = type.Namespace;
            var reqifSchemaResourceName = $"{@namespace}.Resources.{resourceName}";

            var stream = a.GetManifestResourceStream(reqifSchemaResourceName);

            if (stream == null)
            {
                throw new MissingManifestResourceException($"The {reqifSchemaResourceName} resource could not be found");
            }

            return XmlSchema.Read(stream, validationEventHandler);
        }
    }
}
