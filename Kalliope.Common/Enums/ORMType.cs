// -------------------------------------------------------------------------------------------------
// <copyright file="ORMType.cs" company="RHEA System S.A.">
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

namespace Kalliope.Common
{
    /// <summary>
    /// An enumeration of ORM model types that supports custom properties
    /// </summary>
    [Description("An enumeration of ORM model types that supports custom properties")]
    public enum ORMType
    {
        None = 0,

        EntityType = 1,

        ValueType = 2,

        FactType = 4,

        SubtypeFact = 8,

        Role = 16,

        FrequencyConstraint = 32,

        MandatoryConstraint = 64,

        RingConstraint = 128,

        UniquenessConstraint = 256,

        EqualityConstraint = 512,

        ExclusionConstraint = 1024,

        SubsetConstraint = 2028,

        ValueConstraint = 4096,

        ValueComparisonConstraint = 8192,

        CardinalityConstraint = 16384,

        AllConstraints = 32736,

        Model = 32768,

        ElementGrouping = 65536,

        ORMDiagram = 131072
    }
}
