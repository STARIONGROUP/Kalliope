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

namespace Kalliope.Common
{
    /// <summary>
    /// Restrictions on the intersections of instances associated with roles in a ring constraint
    /// </summary>
    [Description("Restrictions on the intersections of instances associated with roles in a ring constraint")]
    public enum RingConstraintType
    {
        /// <summary>
        /// The ring type is undefined. Corresponds to a model validation error
        /// </summary>
        [Description("The ring type is undefined. Corresponds to a model validation error")]
        Undefined = 0,

        /// <summary>
        /// If instance A plays some instance then intance B plays itself
        /// </summary>
        [Description("If instance A plays some instance then intance B plays itself")]
        Reflexive = 1,

        /// <summary>
        /// No instance can play itself
        /// </summary>
        [Description("No instance can play itself")]
        Irreflexive = 2,

        /// <summary>
        /// Each instance plays itself and cannot play another instance
        /// </summary>
        [Description("Each instance plays itself and cannot play another instance")]
        PurelyReflexive = 3,

        /// <summary>
        /// If instance A plays instance B then intance B plays instance A
        /// </summary>
        [Description("If instance A plays instance B then intance B plays instance A")]
        Symmetric = 4,

        /// <summary>
        /// If instance A is not equal to instance B and A plays B, then B cannot play A
        /// </summary>
        [Description("If instance A is not equal to instance B and A plays B, then B cannot play A")]
        Antisymmetric = 5,

        /// <summary>
        /// If instance A plays instance B then instance B cannot play instance A
        /// </summary>
        [Description("If instance A plays instance B then instance B cannot play instance A")]
        Asymmetric = 6,

        /// <summary>
        /// If instance A plays instance B that plays instance C then instance A plays instance C
        /// </summary>
        [Description("If instance A plays instance B that plays instance C then instance A plays instance C")]
        Transitive = 7,

        /// <summary>
        /// If instance A plays instance B and instance B plays instance C, then instance A cannot play instance C
        /// </summary>
        [Description("If instance A plays instance B and instance B plays instance C, then instance A cannot play instance C")]
        Intransitive = 8,

        /// <summary>
        /// If instance A plays instance B, then instance A cannot be indirectly related to instance B by repeatedly apply this fact type
        /// </summary>
        [Description("If instance A plays instance B, then instance A cannot be indirectly related to instance B by repeatedly apply this fact type")]
        StronglyIntransitive = 9,

        /// <summary>
        /// Cycles are not allowed
        /// </summary>
        [Description("Cycles are not allowed")]
        Acyclic = 10,

        /// <summary>
        /// Cycles are not allowed. If instance A plays instance B that plays instance C then instance A plays instance C
        /// </summary>
        [Description("Cycles are not allowed. If instance A plays instance B that plays instance C then instance A plays instance C")]
        AcyclicTransitive = 11,

        /// <summary>
        /// Cycles are not allowed; and if instance A plays instance B and instance B plays instance C, then instance A cannot play instance C
        /// </summary>
        [Description("Cycles are not allowed; and if instance A plays instance B and instance B plays instance C, then instance A cannot play instance C")]
        AcyclicIntransitive = 12,

        /// <summary>
        /// Cycles are not allowed; and if instance A plays instance B, then instance A cannot be indirectly related to instance B by repeatedly apply this fact type
        /// </summary>
        [Description("Cycles are not allowed; and if instance A plays instance B, then instance A cannot be indirectly related to instance B by repeatedly apply this fact type")]
        AcyclicStronglyIntransitive = 13,

        /// <summary>
        /// If instance A plays some instance then intance B plays itself.
        /// If instance A plays instance B then intance B plays instance A
        /// </summary>
        [Description("If instance A plays some instance then intance B plays itself. If instance A plays instance B then intance B plays instance A")]
        ReflexiveSymmetric = 14,

        /// <summary>
        /// If instance A plays some instance then intance B plays itself.
        /// If instance A is not equal to instance B and A plays B, then B cannot play A
        /// </summary>
        [Description("If instance A plays some instance then intance B plays itself. If instance A is not equal to instance B and A plays B, then B cannot play A")]
        ReflexiveAntisymmetric = 15,

        /// <summary>
        /// If instance A plays some instance then intance B plays itself.
        /// If instance A plays instance B that plays instance C then instance A plays instance C
        /// </summary>
        [Description("If instance A plays some instance then intance B plays itself. If instance A plays instance B that plays instance C then instance A plays instance C")]
        ReflexiveTransitive = 16,

        /// <summary>
        /// If instance A plays some instance then intance B plays itself.
        /// If instance A plays instance B that plays instance C then instance A plays instance C.
        /// If instance A is not equal to instance B and A plays B, then B cannot play A
        /// </summary>
        [Description("If instance A plays some instance then intance B plays itself. If instance A plays instance B that plays instance C then instance A plays instance C. If instance A is not equal to instance B and A plays B, then B cannot play A")]
        ReflexiveTransitiveAntisymmetric = 17,

        /// <summary>
        /// If instance A plays instance B then intance B plays instance A.
        /// If instance A plays instance B that plays instance C then instance A plays instance C
        /// </summary>
        [Description("If instance A plays instance B then intance B plays instance A. If instance A plays instance B that plays instance C then instance A plays instance C")]
        SymmetricTransitive = 18,

        /// <summary>
        /// If instance A plays instance B then intance B plays instance A.
        /// No instance can play itself
        /// </summary>
        [Description("If instance A plays instance B then intance B plays instance A. No instance can play itself")]
        SymmetricIrreflexive = 19,

        /// <summary>
        /// If instance A plays instance B then intance B plays instance A.
        /// If instance A plays instance B and instance B plays instance C, then instance A cannot play instance C
        /// </summary>
        [Description("If instance A plays instance B then intance B plays instance A. If instance A plays instance B and instance B plays instance C, then instance A cannot play instance C")]
        SymmetricIntransitive = 20,

        /// <summary>
        /// If instance A plays instance B then intance B plays instance A. 
        /// If instance A plays instance B, then instance A cannot be indirectly related to instance B by repeatedly apply this fact type
        /// </summary>
        [Description("If instance A plays instance B then intance B plays instance A. If instance A plays instance B, then instance A cannot be indirectly related to instance B by repeatedly apply this fact type")]
        SymmetricStronglyIntransitive = 21,

        /// <summary>
        /// If instance A plays instance B then instance B cannot play instance A.
        /// If instance A plays instance B and instance B plays instance C, then instance A cannot play instance C
        /// </summary>
        [Description("If instance A plays instance B then instance B cannot play instance A. If instance A plays instance B and instance B plays instance C, then instance A cannot play instance C")]
        AsymmetricIntransitive = 22,

        /// <summary>
        /// If instance A plays instance B then instance B cannot play instance A.
        /// If instance A plays instance B, then instance A cannot be indirectly related to instance B by repeatedly apply this fact type
        /// </summary>
        [Description("If instance A plays instance B then instance B cannot play instance A. If instance A plays instance B, then instance A cannot be indirectly related to instance B by repeatedly apply this fact type")]
        AsymmetricStronglyIntransitive = 23,

        /// <summary>
        /// If instance A plays instance B that plays instance C then instance A plays instance C. 
        /// No instance can play itself
        /// </summary>
        [Description("If instance A plays instance B that plays instance C then instance A plays instance C. No instance can play itself")]
        TransitiveIrreflexive = 24,

        /// <summary>
        /// If instance A plays instance B that plays instance C then instance A plays instance C.
        /// If instance A is not equal to instance B and A plays B, then B cannot play A
        /// </summary>
        [Description("If instance A plays instance B that plays instance C then instance A plays instance C. If instance A is not equal to instance B and A plays B, then B cannot play A")]
        TransitiveAntisymmetric = 25,

        /// <summary>
        /// If instance A plays instance B that plays instance C then instance A plays instance C.
        /// If instance A plays instance B then instance B cannot play instance A
        /// </summary>
        [Description("If instance A plays instance B that plays instance C then instance A plays instance C. If instance A plays instance B then instance B cannot play instance A")]
        TransitiveAsymmetric = 26
    }
}
