// -------------------------------------------------------------------------------------------------
// <copyright file="StringExtensions.cs" company="Starion Group S.A.">
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

namespace Kalliope.OO.Extensions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    /// <summary>
    /// <see cref="string"/> extension methods
    /// </summary>
    public static class StringExtensions
    {
        /// <summary>
        /// Cleans the type name 
        /// </summary>
        /// <param name="typeName">
        /// The input type name
        /// </param>
        /// <param name="reservedWords">A list of reserved words that don't need to be re capitalized</param>
        /// <returns>
        /// Returns a cleaned type name
        /// </returns>
        public static string ToUsableName(this string typeName, List<string> reservedWords)
        {
            if (string.IsNullOrEmpty(typeName)) throw new ArgumentException($"{nameof(typeName)} can't be empty!");

            return typeName.ToTitleCase(reservedWords);
        }

        /// <summary>
        /// Converts a string to Camel Casing
        /// </summary>
        /// <param name="value">The to be converted string</param>
        /// <returns>The converted string</returns>
        public static string ToCamelCase(this string value)
        {
            value = char.ToUpper(value[0]) + value.Substring(1);

            var words = value.Split(new[] { "_", " " }, StringSplitOptions.RemoveEmptyEntries);

            var leadWord = 
                Regex.Replace(words[0], @"([A-Z])([A-Z]+|[a-z0-9]+)($|[A-Z]\w*)",
                m => 
                    m.Groups[1].Value.ToLower() + m.Groups[2].Value.ToLower() + m.Groups[3].Value);
            
            var tailWords = words.Skip(1)
                .Select(word => char.ToUpper(word[0]) + word.Substring(1))
                .ToArray();
            
            return $"{leadWord}{string.Join(string.Empty, tailWords)}";
        }

        /// <summary>
        /// Converts a string to Title Casing
        /// </summary>
        /// <param name="value">The to be converted string</param>
        /// <param name="reservedWords">A list of reserved words that don't need to be re capitalized</param>
        /// <returns>The converted string</returns>
        public static string ToTitleCase(this string value, List<string> reservedWords)
        {
            value = char.ToUpper(value[0]) + value.Substring(1);
            value = value.SplitWords();

            var words = value.Split(new[] { "_", " ", "-" }, StringSplitOptions.RemoveEmptyEntries);

            var leadWord = 
                Regex.Replace(words[0], @"([A-Z])([A-Z]+|[a-z0-9]+)($|[A-Z]\w*)",
                    m => 
                        m.Groups[1].Value.ToLower() + m.Groups[2].Value.ToLower() + m.Groups[3].Value);
            
            var tailWords = words.Skip(1)
                .Select(word => char.ToUpper(word[0]) + word.Substring(1))
                .ToArray();

            leadWord = (char.ToUpper(leadWord[0]) + leadWord.Substring(1)).CheckReservedWords(reservedWords);

            for (var i = 0; i<tailWords.Length; i++)
            {
                tailWords[i] = tailWords[i].CheckReservedWords(reservedWords);
            }

            return $"{leadWord}{string.Join(string.Empty, tailWords)}";
        }

        /// <summary>
        /// Split a string to seperate words based on casing
        /// </summary>
        /// <param name="value">The <see cref="string"/> to split</param>
        /// <returns>The splitted <see cref="string"/></returns>
        public static string SplitWords(this string value)
        {
            var r = new Regex(@"
                (?<=[A-Z])(?=[A-Z][a-z]) |
                 (?<=[^A-Z])(?=[A-Z]) |
                 (?<=[A-Za-z])(?=[^A-Za-z])", RegexOptions.IgnorePatternWhitespace);

            return r.Replace(value, " ");
        }

        /// <summary>
        /// Checks if a string is a reserved word for PASaaS and returns the reserved word accordingly.
        /// </summary>
        /// <param name="value">The <see cref="string"/></param>
        /// <param name="reservedWords">A list of reserved words that don't need to be re capitalized</param>
        /// <returns>The original string, of the reserved word in case it is a reserved word having the correct casing.</returns>
        public static string CheckReservedWords(this string value, List<string> reservedWords)
        {
            if (reservedWords.Select(x => x.ToUpper()).Contains(value.ToUpper()))
            {
                return reservedWords.Single(x => x.ToUpper() == value.ToUpper());
            }

            return value;
        }
    }
}
