﻿// -------------------------------------------------------------------------------------------------
// <copyright file="ValueTypeProperty.cs" company="RHEA System S.A.">
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
// -------------------------------------------------------------------------------------------------

namespace Kalliope.OO.StructuralFeature
{
    using System.Linq;

    using Kalliope.Common;
    using Kalliope.Core;
    using Kalliope.OO.Generation;

    /// <summary>
    /// Class that describes a ValueType property
    /// </summary>
    public class ValueTypeProperty : Property<ValueType>
    {
        /// <summary>
        /// Gets or sets a value indicating that the ValueType represents an implicit boolean value
        /// </summary>
        public bool IsImplicitBooleanValue => this.ObjectType.IsImplicitBooleanValue;

        /// <summary>
        /// Creates a new instance of the <see cref="ValueTypeProperty"/> class
        /// </summary>
        /// <param name="ormModel">The <see cref="OrmModel"/></param>
        /// <param name="valueType">The <see cref="ValueType"/></param>
        /// <param name="propertyRole">The <see cref="Role"/></param>
        /// <param name="classRole">The <see cref="Class"/> <see cref="Role"/></param>
        /// <param name="generationSettings">The <see cref="GenerationSettings"/></param>
        public ValueTypeProperty(OrmModel ormModel, ValueType valueType, Role propertyRole, Role classRole, GenerationSettings generationSettings) : base(ormModel, valueType, propertyRole, classRole, generationSettings)
        {
        }

        /// <summary>
        /// Calculates the Multiplicity for this property 
        /// </summary>
        /// <returns>The Calculated <see cref="Multiplicity"/></returns>
        protected override Multiplicity CalculateMultiplicity()
        {
            return this.PropertyRole.Multiplicity;
        }

        /// <summary>
        /// Initializes this class
        /// </summary>
        protected override void Initialize()
        {
            base.Initialize();
            this.Scale = this.ObjectType.ConceptualDataType.Scale;
            this.Length = this.ObjectType.ConceptualDataType.Length;
        }

        /// <summary>
        /// Get the Datatype of the <see cref="ValueType"/>
        /// </summary>
        /// <returns>The <see cref="ValueType"/> datatype</returns>
        protected override string GetDataType()
        {
            if (this.IsEnum)
            {
                return this.ObjectType.Name;
            }

            var dataType = this.GenerationSettings.DataTypeMapper.MapDataType(this.OrmDataType);

            return dataType;
        }

        /// <summary>
        /// Get the Name of the <see cref="ValueType"/>
        /// </summary>
        /// <returns>The <see cref="ValueType"/>'s Name</returns>
        protected override string GetName()
        {
            if (this.IsImplicitBooleanValue)
            {
                var text = this.FactType.ReadingOrders.First().Readings.First().Data;
                var numberOfVariablesInReadingText = text.Count(x => x == '{');

                if (numberOfVariablesInReadingText > 0)
                {
                    var stringArray = new object[numberOfVariablesInReadingText];

                    text = string.Format(text, stringArray);
                }

                return text.Trim();
            }

            return string.IsNullOrWhiteSpace(this.PropertyRole.Name) ? this.ObjectType.Name : this.PropertyRole.Name;
        }
    }
}
