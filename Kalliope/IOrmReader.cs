// -------------------------------------------------------------------------------------------------
// <copyright file="IOrmReader.cs" company="RHEA System S.A.">
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
    using Kalliope.Core;
    using System.IO;
    using System.Threading;
    using System.Threading.Tasks;
    using System.Xml.Schema;

    /// <summary>
    /// The purpose of the <see cref="IOrmReader"/> is to read .orm models and return the content as an object graph
    /// </summary>
    public interface IOrmReader
    {
        /// <summary>
        /// Reads a <see cref="OrmRoot"/> from an .orm file
        /// </summary>
        /// <param name="xmlFilePath">
        /// The Path of the .orm file to deserialize
        /// </param>
        /// <param name="validate">
        /// a value indicating whether the XML document needs to be validated or not
        /// </param>
        /// <param name="validationEventHandler">
        /// The <see cref="ValidationEventHandler"/> that processes the result of the <see cref="OrmRoot"/> validation.
        /// </param>
        /// <returns>
        /// A fully de-referenced <see cref="ORMModel"/> object graph
        /// </returns>
        OrmRoot Read(string xmlFilePath, bool validate = false, ValidationEventHandler validationEventHandler = null);

        /// <summary>
        /// Reads a <see cref="OrmRoot"/> from an .orm <see cref="Stream"/>
        /// </summary>
        /// <param name="stream">
        /// The <see cref="Stream"/> that contains the .orm file to read
        /// </param>
        /// <param name="validate">
        /// a value indicating whether the XML document needs to be validated or not
        /// </param>
        /// <param name="validationEventHandler">
        /// The <see cref="ValidationEventHandler"/> that processes the result of the <see cref="OrmRoot"/> validation.
        /// </param>
        /// <returns>
        /// A fully de-referenced <see cref="ORMModel"/> object graph
        /// </returns>
        OrmRoot Read(Stream stream, bool validate = false, ValidationEventHandler validationEventHandler = null);

        /// <summary>
        /// Asynchronously reads a <see cref="OrmRoot"/> from an .orm file
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
        /// The <see cref="ValidationEventHandler"/> that processes the result of the <see cref="OrmRoot"/> validation.
        /// </param>
        /// <returns>
        /// A fully de-referenced <see cref="ORMModel"/> object graph
        /// </returns>
        Task<OrmRoot> ReadAsync(string xmlFilePath, CancellationToken token, bool validate = false, ValidationEventHandler validationEventHandler = null);

        /// <summary>
        /// Asynchronously reads a <see cref="OrmRoot"/> from an .orm <see cref="Stream"/>
        /// </summary>
        /// <param name="stream">
        /// The <see cref="Stream"/> that contains the .orm file to read
        /// </param>
        /// <param name="token">
        /// A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <param name="validate">
        /// a value indicating whether the XML document needs to be validated or not
        /// </param>
        /// <param name="validationEventHandler">
        /// The <see cref="ValidationEventHandler"/> that processes the result of the <see cref="OrmRoot"/> validation.
        /// </param>
        /// <returns>
        /// A fully de-referenced <see cref="ORMModel"/> object graph
        /// </returns>
        Task<OrmRoot> ReadAsync(Stream stream, CancellationToken token, bool validate = false, ValidationEventHandler validationEventHandler = null);
    }
}
