// -------------------------------------------------------------------------------------------------
// <copyright file="RoleText.cs" company="RHEA System S.A.">
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
    using System.Xml;

    /// <summary>
    /// Text bound to or occurring after a given role.
    /// Roles with no text are not represented
    /// </summary>
    public class RoleText
    {
        /// <summary>
        /// The zero-based index of the role
        /// </summary>
        public int RoleIndex { get; set; }

        /// <summary>
        /// Text that is bound to the role as leading text through hyphen binding semantics in the full reading text
        /// </summary>
        public string PreBoundText { get; set; }

        /// <summary>
        /// Text that is bound to the role as trailing text through hyphen binding semantics in the full reading text
        /// </summary>
        public string PostBoundText { get; set; }

        /// <summary>
        /// Text following a role replacement field and associated bound text
        /// </summary>
        public string FollowingText { get; set; }

        /// <summary>
        /// Generates a <see cref="Reading"/> object from its XML representation.
        /// </summary>
        /// <param name="reader">
        /// an instance of <see cref="XmlReader"/> used to read the .orm file
        /// </param>
        internal  void ReadXml(XmlReader reader)
        {
            var roleIndexAttribute = reader.GetAttribute("RoleIndex");
            if (!string.IsNullOrEmpty(roleIndexAttribute))
            {
                this.RoleIndex = XmlConvert.ToInt32(roleIndexAttribute);
            }

            this.PreBoundText = reader.GetAttribute("PreBoundText");

            this.PostBoundText = reader.GetAttribute("PostBoundText");

            this.FollowingText = reader.GetAttribute("FollowingText");
        }
    }
}
