// -------------------------------------------------------------------------------------------------
// <copyright file="OrmXmlReaderTestFixture.cs" company="RHEA System S.A.">
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

namespace Kalliope.Xml.Tests.OrmXmlReaders
{
	using System;
	using System.IO;
	
	using NUnit.Framework;

	/// <summary>
	/// Suite of tests for the <see cref="OrmXmlReader"/> class used to make sure that the know
	/// ORM models are parsed without exception
	/// </summary>
	[TestFixture]
	public class OrmXmlReaderTestFixture
	{
		private OrmXmlReader ormXmlReader;

		[SetUp]
		public void Setup()
		{
			this.ormXmlReader = new OrmXmlReader();
		}

		[TestCase("Bird Identification.orm")]
		[TestCase("IT Management data model.orm")]
		[TestCase("ORM_Lab1.orm")]
		[TestCase("ORM_Lab2.orm")]
		[TestCase("ORM_Lab3.orm")]
		[TestCase("ORM_Lab4.orm")]
		[TestCase("ORM_Lab7.orm")]
		[TestCase("ORM_Lab8.orm")]
		[TestCase("ReservationModel5.orm")]
		[TestCase("Talent.orm")]
		public void VerifyThatTestModelsCanBeLoaded(string modelName)
		{
			var ormFilePath = Path.Combine(TestContext.CurrentContext.TestDirectory, "Data", modelName);

			Assert.That(() => this.ormXmlReader.Read(ormFilePath, false, null),
				Throws.Nothing);
		}
	}
}
