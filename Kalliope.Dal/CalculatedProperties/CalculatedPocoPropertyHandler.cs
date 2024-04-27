// -------------------------------------------------------------------------------------------------
// <copyright file="CalculatedPocoPropertyHandler.cs" company="Starion Group S.A.">
//
//   Copyright 2022-2024 Starion Group S.A.
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

namespace Kalliope.Dal.CalculatedProperties
{
    using System;
    using System.Collections.Concurrent;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Handles the calculation of calculated properties after the model has been completely assembled as POCO's
    /// </summary>
    public class CalculatedPocoPropertyHandler
    {
        /// <summary>
        /// Gets the Cache that contains all the <see cref="Core.ModelThing"/>s
        /// </summary>
        private ConcurrentDictionary<string, Lazy<Core.ModelThing>> Cache { get; set; }

        /// <summary>
        /// Gets all or sets a collection of <see cref="Type"/>s that can be used for property calculation purposes
        /// </summary>
        private IEnumerable<Type> AllCalculationModuleTypes { get; set; }

        /// <summary>
        /// Creates a new instance of the CalculatedPocoPropertyHandler class
        /// </summary>
        /// <param name="cache">
        /// The Cache that contains all the <see cref="Core.ModelThing"/>s
        /// </param>
        public CalculatedPocoPropertyHandler(ConcurrentDictionary<string, Lazy<Core.ModelThing>> cache)
        {
            this.Cache = cache;
            this.RegisterAllCalculationModules();
        }

        /// <summary>
        /// Clalculates all the properties that have to be calculated
        /// </summary>
        public void CalculateProperties()
        {
            foreach (var calculationType in this.AllCalculationModuleTypes)
            {
                if (Activator.CreateInstance(calculationType) is ICalculationModule calculationModule)
                {
                    calculationModule.CalculateProperties(this.Cache);
                }
            }
        }

        /// <summary>
        /// Finds all classes that implement <see cref="ICalculationModule"/> in all assemblies
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        private void RegisterAllCalculationModules()
        {
            var type = typeof(ICalculationModule);

            var types = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(s => s.GetTypes())
                .Where(p => type.IsAssignableFrom(p) && p.IsClass);

            this.AllCalculationModuleTypes = types;
        }
    }
}
