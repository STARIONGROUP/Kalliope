// --------------------------------------------------------------------------------------------------------------------
// <copyright file="RelationType.cs" company="RHEA System S.A.">
//  © Copyright European Space Agency, 2017-2022
//  <author>
//   Software developed by RHEA System S.A.
//  </author>
//  This file is subject to the terms and conditions defined in file 'LICENSE.txt', which is part of this source code package.
//  No part of the package, including this file, may be copied, modified, propagated, or distributed
//  except according to the terms contained in the file 'LICENSE.txt'.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Kalliope.OO.StructuralFeature
{
    /// <summary>
    /// Defines the type of Relation for a reference type property
    /// </summary>
    public enum RelationType
    {
        /// <summary>
        /// Relation is of the Aggregation type (is the default RelationType)
        /// </summary>
        Aggregation,

        /// <summary>
        /// Relation is of the Composition type
        /// </summary>
        Composite
    }
}
