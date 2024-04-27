// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IDataTypeMapper.cs" company="Starion Group S.A.">
//  © Copyright European Space Agency, 2017-2022
//  <author>
//   Software developed by Starion Group S.A.
//  </author>
//  This file is subject to the terms and conditions defined in file 'LICENSE.txt', which is part of this source code package.
//  No part of the package, including this file, may be copied, modified, propagated, or distributed
//  except according to the terms contained in the file 'LICENSE.txt'.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Kalliope.OO.Mappers
{
    using Kalliope.Core;

    /// <summary>
    /// Defines the properties and method of an <see cref="IDataTypeMapper"/>
    /// </summary>
    public interface IDataTypeMapper
    {
        /// <summary>
        /// Maps the ORM <see cref="DataType"/> to a string representation of the expected datatype.
        /// </summary>
        /// <param name="dataType">
        /// The <see cref="DataType"/> to map
        /// </param>
        /// <returns>
        /// the name of the C# data-type
        /// </returns>
        string MapDataType(DataType dataType);
    }
}
