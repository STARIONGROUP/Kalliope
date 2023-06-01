// --------------------------------------------------------------------------------------------------------------------
// <copyright file="RoleCalculationModule.cs" company="RHEA System S.A.">
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
    using System.Collections.Generic;
    using System.Linq;

    using Kalliope.Common;
    using Kalliope.Core;

    /// <summary>
    /// Class that handles calculated properties for <see cref="Role"/> instances
    /// </summary>
    public class RoleCalculationModule : ICalculationModule
    {
        /// <summary>
        /// Calculate the properties
        /// </summary>
        /// <param name="cache">The collection of retrieved <see cref="ModelThing"/>s in an ORM model</param>
        public void CalculateProperties(ConcurrentDictionary<string, Lazy<ModelThing>> cache)
        {
            var roles =
                cache
                    .Values
                    .Where(x => x.Value is Role)
                    .Select(x => x.Value)
                    .OfType<Role>();

            this.CalculateMandatoryConstraintModality(cache, roles);
        }

        /// <summary>
        /// Calculates all
        /// </summary>
        /// <param name="cache">The collection of retrieved <see cref="ModelThing"/>s in an ORM model</param>
        /// <param name="roles">A collection of <see cref="Role"/> objects found in the <paramref name="cache"/></param>
        private void CalculateMandatoryConstraintModality(ConcurrentDictionary<string, Lazy<ModelThing>> cache, IEnumerable<Role> roles)
        {
            var mandatoryRoles = roles.Where(x => x.IsMandatory);

            var factTypes = cache
                .Values
                .Select(x => x.Value)
                .OfType<FactType>()
                .ToList();

            foreach (var role in mandatoryRoles)
            {
                var roleFactTypes = factTypes.Where(x => x.Roles.ContainsRole(role));

                foreach (var roleFactType in roleFactTypes)
                {
                    var mandatoryConstraint = 
                        roleFactType.InternalConstraints
                            .OfType<MandatoryConstraint>()
                            .SingleOrDefault(x => x.IsSimple && x.Roles.ContainsRole(role));

                    if (mandatoryConstraint != null)
                    {
                        role.MandatoryConstraintModality = mandatoryConstraint.Modality;
                        break;
                    }
                }
            }
        }
    }
}
