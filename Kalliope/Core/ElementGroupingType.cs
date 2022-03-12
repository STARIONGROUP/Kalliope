// -------------------------------------------------------------------------------------------------
// <copyright file="ElementGroupingType.cs" company="RHEA System S.A.">
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
    using Kalliope.Common;

    /// <summary>
    /// A type for a group. Each Group is associated with a new instance of each of its GroupTypes, allowing individual settings per group
    /// </summary>
    [Description("A type for a group. Each Group is associated with a new instance of each of its GroupTypes, allowing individual settings per group")]
    [Domain(isAbstract: true, general: "ModelThing")]
    [Container(typeName: "ElementGrouping", propertyName: "GroupingTypes")]
    [Ignore("This class derives from ModelThing and therefore has no Id property and is an abstract class that has no subclasses defined in the domain model")]
    public abstract class ElementGroupingType : ModelThing
    {
    }
}
