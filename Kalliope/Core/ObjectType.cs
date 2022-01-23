// -------------------------------------------------------------------------------------------------
// <copyright file="ObjectType.cs" company="RHEA System S.A.">
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
    public abstract class ObjectType : ORMNamedElement
    {
        /// <summary>
        /// An instance of this object type can exist without playing any non-identifying roles
        /// </summary>
        public bool IsIndependent { get; set; }

        /// <summary>
        /// This object type is externally defined (not used).
        /// </summary>
        public bool IsExternal { get; set; }

        /// <summary>
        /// This object type refers to a person, not a thing. A directive to tell the verbalization to use personal pronouns
        /// </summary>
        public bool IsPersonal { get; set; }
    }
}
