// -------------------------------------------------------------------------------------------------
// <copyright file="PictureRawDataDataType.cs" company="RHEA System S.A.">
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
    /// Values are in the set of binary data representing an image
    /// </summary>
    [Description("")]
    [Domain(isAbstract: false, general: "RawDataDataType")]
    public class PictureRawDataDataType : RawDataDataType
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PictureRawDataDataType"/> class
        /// </summary>
        public PictureRawDataDataType()
        {
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="PictureRawDataDataType"/> class
        /// </summary>
        /// <param name="model">
        /// The <see cref="ORMModel"/> that contains the current <see cref="PictureRawDataDataType"/>
        /// </param>
        public PictureRawDataDataType(ORMModel model) : base(model)
        {
        }
    }
}
