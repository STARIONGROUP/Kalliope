// -------------------------------------------------------------------------------------------------
// <copyright file="RingConstraintTypeValues.cs" company="RHEA System S.A.">
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

namespace Kalliope.ObjectModel
{
    /// <summary>
    /// Restrictions on the intersections of instances associated with roles in a ring constraint
    /// </summary>
    public enum RingConstraintTypeValues
    {
        /// <summary>
        /// The ring type is undefined. Corresponds to a model validation error
        /// </summary>
        Undefined,

        /// <summary>
        /// If instance A plays some instance then intance B plays itself
        /// </summary>
        Reflexive,

        /// <summary>
        /// No instance can play itself
        /// </summary>
        Irreflexive,

        /// <summary>
        /// Each instance plays itself and cannot play another instance
        /// </summary>
        PurelyReflexive,

        /// <summary>
        /// If instance A plays instance B then intance B plays instance A
        /// </summary>
        Symmetric,

        /// <summary>
        /// If instance A is not equal to instance B and A plays B, then B cannot play A
        /// </summary>
        Antisymmetric,

        /// <summary>
        /// If instance A plays instance B then instance B cannot play instance A
        /// </summary>
        Asymmetric,

        /// <summary>
        /// If instance A plays instance B that plays instance C then instance A plays instance C
        /// </summary>
        Transitive,

        /// <summary>
        /// If instance A plays instance B and instance B plays instance C, then instance A cannot play instance C
        /// </summary>
        Intransitive,

        /// <summary>
        /// If instance A plays instance B, then instance A cannot be indirectly related to instance B by repeatedly apply this fact type
        /// </summary>
        StronglyIntransitive,

        /// <summary>
        /// Cycles are not allowed
        /// </summary>
        Acyclic,

        /// <summary>
        /// Cycles are not allowed. If instance A plays instance B that plays instance C then instance A plays instance C
        /// </summary>
        AcyclicTransitive,

        /// <summary>
        /// Cycles are not allowed; and if instance A plays instance B and instance B plays instance C, then instance A cannot play instance C
        /// </summary>
        AcyclicIntransitive,

        /// <summary>
        /// Cycles are not allowed; and if instance A plays instance B, then instance A cannot be indirectly related to instance B by repeatedly apply this fact type
        /// </summary>
        AcyclicStronglyIntransitive,

        /// <summary>
        /// If instance A plays some instance then intance B plays itself.
        /// If instance A plays instance B then intance B plays instance A
        /// </summary>
        ReflexiveSymmetric,

        /// <summary>
        /// If instance A plays some instance then intance B plays itself.
        /// If instance A is not equal to instance B and A plays B, then B cannot play A
        /// </summary>
        ReflexiveAntisymmetric,

        /// <summary>
        /// If instance A plays some instance then intance B plays itself.
        /// If instance A plays instance B that plays instance C then instance A plays instance C
        /// </summary>
        ReflexiveTransitive,

        /// <summary>
        /// If instance A plays some instance then intance B plays itself.
        /// If instance A plays instance B that plays instance C then instance A plays instance C.
        /// If instance A is not equal to instance B and A plays B, then B cannot play A
        /// </summary>
        ReflexiveTransitiveAntisymmetric,

        /// <summary>
        /// If instance A plays instance B then intance B plays instance A.
        /// If instance A plays instance B that plays instance C then instance A plays instance C
        /// </summary>
        SymmetricTransitive,

        /// <summary>
        /// If instance A plays instance B then intance B plays instance A.
        /// No instance can play itself
        /// </summary>
        SymmetricIrreflexive,

        /// <summary>
        /// If instance A plays instance B then intance B plays instance A.
        /// If instance A plays instance B and instance B plays instance C, then instance A cannot play instance C
        /// </summary>
        SymmetricIntransitive,

        /// <summary>
        /// If instance A plays instance B then intance B plays instance A. 
        /// If instance A plays instance B, then instance A cannot be indirectly related to instance B by repeatedly apply this fact type
        /// </summary>
        SymmetricStronglyIntransitive,

        /// <summary>
        /// If instance A plays instance B then instance B cannot play instance A.
        /// If instance A plays instance B and instance B plays instance C, then instance A cannot play instance C
        /// </summary>
        AsymmetricIntransitive,

        /// <summary>
        /// If instance A plays instance B then instance B cannot play instance A.
        /// If instance A plays instance B, then instance A cannot be indirectly related to instance B by repeatedly apply this fact type
        /// </summary>
        AsymmetricStronglyIntransitive,

        /// <summary>
        /// If instance A plays instance B that plays instance C then instance A plays instance C. 
        /// No instance can play itself
        /// </summary>
        TransitiveIrreflexive,

        /// <summary>
        /// If instance A plays instance B that plays instance C then instance A plays instance C.
        /// If instance A is not equal to instance B and A plays B, then B cannot play A
        /// </summary>
        TransitiveAntisymmetric,

        /// <summary>
        /// If instance A plays instance B that plays instance C then instance A plays instance C.
        /// If instance A plays instance B then instance B cannot play instance A
        /// </summary>
        TransitiveAsymmetric
    }
}
