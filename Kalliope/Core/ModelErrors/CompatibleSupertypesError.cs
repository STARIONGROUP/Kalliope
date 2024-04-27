// -------------------------------------------------------------------------------------------------
// <copyright file="CompatibleSupertypesError.cs" company="Starion Group S.A.">
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

namespace Kalliope.Core
{
    using Kalliope.Common;

    /// <summary>
    /// Multiple supertypes are specified that do not share a common ancestor, or a supertype is specified that is implied by other supertypes
    /// </summary>
    [Description("Incompatible or Transitive Supertypes")]
    [Domain(isAbstract: false, general: "ModelError")]
    [Container(typeName: "ObjectType", propertyName: "CompatibleSupertypesError")]
    public class CompatibleSupertypesError : ModelError
    {
    }
}
