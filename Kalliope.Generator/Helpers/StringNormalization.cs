// -------------------------------------------------------------------------------------------------
// <copyright file="StringNormalization.cs" company="Starion Group S.A.">
//
//   Copyright 2022-2026 Starion Group S.A.
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

namespace Kalliope.Generator.Helpers
{
    using System;

    /// <summary>
    /// Provides utility methods for normalizing strings, such as line endings.
    /// </summary>
    public static class StringNormalization
    {
        /// <summary>
        /// Normalizes line endings in a string by converting all occurrences of <c>\r\n</c> and <c>\r</c> to <c>\n</c>.
        /// </summary>
        /// <param name="value">The input string whose line endings will be normalized.</param>
        /// <returns>A new string with all line endings replaced by <c>\n</c>.</returns>
        /// <exception cref="ArgumentNullException">Thrown if <paramref name="value"/> is <see langword="null"/>.</exception>
        /// <remarks>
        /// This method ensures consistent line endings across different platforms (Windows, Unix, macOS).
        /// </remarks>
        public static string NormalizeLineEndings(string value)
        {
            ArgumentNullException.ThrowIfNull(value);

            return value
                .Replace("\r\n", "\n", StringComparison.Ordinal)
                .Replace("\r", "\n", StringComparison.Ordinal);
        }
    }
}
