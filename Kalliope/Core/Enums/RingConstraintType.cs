// -------------------------------------------------------------------------------------------------
// <copyright file="RingConstraintType.cs" company="RHEA System S.A.">
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

namespace Kalliope.Core
{
    /// <summary>
    /// Restrictions on the intersections of instances associated with roles in a ring constraint
    /// </summary>
    public enum RingConstraintType
    {
        /// <summary>
        /// The ring type is undefined. Corresponds to a model validation error
        /// </summary>
        Undefined = 0,

        /// <summary>
        /// If instance A plays some instance then intance B plays itself
        /// </summary>
        Reflexive = 1,

        /// <summary>
        /// No instance can play itself
        /// </summary>
        Irreflexive = 2,

        /// <summary>
        /// Each instance plays itself and cannot play another instance
        /// </summary>
        PurelyReflexive = 3,

        /// <summary>
        /// If instance A plays instance B then intance B plays instance A
        /// </summary>
        Symmetric = 4,

        /// <summary>
        /// If instance A is not equal to instance B and A plays B, then B cannot play A
        /// </summary>
        Antisymmetric = 5,

        /// <summary>
        /// If instance A plays instance B then instance B cannot play instance A
        /// </summary>
        Asymmetric = 6,

        /// <summary>
        /// If instance A plays instance B that plays instance C then instance A plays instance C
        /// </summary>
        Transitive = 7,

        /// <summary>
        /// If instance A plays instance B and instance B plays instance C, then instance A cannot play instance C
        /// </summary>
        Intransitive = 8,

        /// <summary>
        /// If instance A plays instance B, then instance A cannot be indirectly related to instance B by repeatedly apply this fact type
        /// </summary>
        StronglyIntransitive = 9,

        /// <summary>
        /// Cycles are not allowed
        /// </summary>
        Acyclic = 10,

        /// <summary>
        /// Cycles are not allowed. If instance A plays instance B that plays instance C then instance A plays instance C
        /// </summary>
        AcyclicTransitive = 11,

        /// <summary>
        /// Cycles are not allowed; and if instance A plays instance B and instance B plays instance C, then instance A cannot play instance C
        /// </summary>
        AcyclicIntransitive = 12,

        /// <summary>
        /// Cycles are not allowed; and if instance A plays instance B, then instance A cannot be indirectly related to instance B by repeatedly apply this fact type
        /// </summary>
        AcyclicStronglyIntransitive = 13,

        /// <summary>
        /// If instance A plays some instance then intance B plays itself.
        /// If instance A plays instance B then intance B plays instance A
        /// </summary>
        ReflexiveSymmetric = 14,

        /// <summary>
        /// If instance A plays some instance then intance B plays itself.
        /// If instance A is not equal to instance B and A plays B, then B cannot play A
        /// </summary>
        ReflexiveAntisymmetric = 15,

        /// <summary>
        /// If instance A plays some instance then intance B plays itself.
        /// If instance A plays instance B that plays instance C then instance A plays instance C
        /// </summary>
        ReflexiveTransitive = 16,

        /// <summary>
        /// If instance A plays some instance then intance B plays itself.
        /// If instance A plays instance B that plays instance C then instance A plays instance C.
        /// If instance A is not equal to instance B and A plays B, then B cannot play A
        /// </summary>
        ReflexiveTransitiveAntisymmetric = 17,

        /// <summary>
        /// If instance A plays instance B then intance B plays instance A.
        /// If instance A plays instance B that plays instance C then instance A plays instance C
        /// </summary>
        SymmetricTransitive = 18,

        /// <summary>
        /// If instance A plays instance B then intance B plays instance A.
        /// No instance can play itself
        /// </summary>
        SymmetricIrreflexive = 19,

        /// <summary>
        /// If instance A plays instance B then intance B plays instance A.
        /// If instance A plays instance B and instance B plays instance C, then instance A cannot play instance C
        /// </summary>
        SymmetricIntransitive = 20,

        /// <summary>
        /// If instance A plays instance B then intance B plays instance A. 
        /// If instance A plays instance B, then instance A cannot be indirectly related to instance B by repeatedly apply this fact type
        /// </summary>
        SymmetricStronglyIntransitive = 21,

        /// <summary>
        /// If instance A plays instance B then instance B cannot play instance A.
        /// If instance A plays instance B and instance B plays instance C, then instance A cannot play instance C
        /// </summary>
        AsymmetricIntransitive = 22,

        /// <summary>
        /// If instance A plays instance B then instance B cannot play instance A.
        /// If instance A plays instance B, then instance A cannot be indirectly related to instance B by repeatedly apply this fact type
        /// </summary>
        AsymmetricStronglyIntransitive = 23,

        /// <summary>
        /// If instance A plays instance B that plays instance C then instance A plays instance C. 
        /// No instance can play itself
        /// </summary>
        TransitiveIrreflexive = 24,

        /// <summary>
        /// If instance A plays instance B that plays instance C then instance A plays instance C.
        /// If instance A is not equal to instance B and A plays B, then B cannot play A
        /// </summary>
        TransitiveAntisymmetric = 25,

        /// <summary>
        /// If instance A plays instance B that plays instance C then instance A plays instance C.
        /// If instance A plays instance B then instance B cannot play instance A
        /// </summary>
        TransitiveAsymmetric = 26
    }
}
