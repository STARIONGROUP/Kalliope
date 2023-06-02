// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ICalculationModule.cs" company="RHEA System S.A.">
//    Copyright (c) 2023 RHEA System S.A.
// 
//    Author: Sam Gerené, Alexander van Delft, Steve Pearson, Omar Elebiary
// 
//    This file is part of the PASaaS web application. PASaaS is a Product Assurance and Safety
//    web application and associated micro-services backend
// 
//    PASaaS is distributed under the terms and conditions of the
//    European Space Agency Public License (ESA-PL) Weak Copyleft (Type 2) – v2.4
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Kalliope.Dal.CalculatedProperties
{
    using System;
    using System.Collections.Concurrent;

    /// <summary>
    /// Interface that defines the properties and methods of a class that implements the <see cref="ICalculationModule"/> interface
    /// </summary>
    public interface ICalculationModule
    {
        /// <summary>
        /// Calculates property values for a specific <see cref="Core.ModelThing"/> object
        /// </summary>
        /// <param name="cache">The cache object that contains all <see cref="Core.ModelThing"/> retrieved from an ORM model</param>
        void CalculateProperties(ConcurrentDictionary<string, Lazy<Core.ModelThing>> cache);
    }
}
