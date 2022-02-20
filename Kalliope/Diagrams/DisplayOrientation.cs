// -------------------------------------------------------------------------------------------------
// <copyright file="DisplayOrientation.cs" company="RHEA System S.A.">
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

namespace Kalliope.Diagrams
{
    using Kalliope.Attributes;
    using Kalliope.Core;

    /// <summary>
    /// Determines whether a <see cref="FactTypeShape"/> is drawn horizontally or vertically
    /// </summary>
    [Description("Determines whether a FactTypeShape is drawn horizontally or vertically")]
    public enum DisplayOrientation
    {
        /// <summary>
        /// The <see cref="FactType"/> is drawn with a horizontal orientation
        /// </summary>
        [Description("The fact type is drawn with a horizontal orientation")]
        Horizontal = 0,

        /// <summary>
        /// The <see cref="FactType"/> is drawn with a vertical orientation rotated to the right
        /// </summary>
        [Description("The fact type is drawn with a vertical orientation rotated to the right")]
        VerticalRotatedRight = 1,

        /// <summary>
        /// The <see cref="FactType"/> is drawn with a vertical orientation rotated to the left
        /// </summary>
        [Description("The fact type is drawn with a vertical orientation rotated to the left")]
        VerticalRotatedLeft = 2,
    }
}