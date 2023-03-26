// -------------------------------------------------------------------------------------------------
// <copyright file="OrmSchemaResolverTestFixture.cs" company="RHEA System S.A.">
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

namespace Kalliope.Xml.Tests
{
    using System;
    using System.Reflection;
    using System.Xml.Schema;

    using NUnit.Framework;
    
    /// <summary>
    /// Suite of tests for the <see cref="OrmSchemaResolver"/> class
    /// </summary>
    [TestFixture]
    public class OrmSchemaResolverTestFixture
    {
        [Test]
        public void VerifyThatReferencedSchemaCanBeLoaded()
        {
            var a = Assembly.GetExecutingAssembly();
            var stream = a.GetManifestResourceStream("Kalliope.Xml.Tests.Resources.ORM2Core.xsd");

            var schema = XmlSchema.Read(stream, this.ValidationEventHandler);
            Assert.DoesNotThrow(() => schema.Compile(this.ValidationEventHandler, new OrmSchemaResolver()));
        }

        /// <summary>
        /// validation Call back method 
        /// </summary>
        /// <param name="sender">
        /// The sender of the event
        /// </param>
        /// <param name="args">
        /// The event argument
        /// </param>
        private void ValidationEventHandler(object sender, ValidationEventArgs args)
        {
            Console.WriteLine("[" + args.Exception.GetType().ToString() + "]: " + args.Message);
        }
    }
}
