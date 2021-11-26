using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Katas
{
    /// <summary>
    /// Избранные задачки из CodeWars
    /// </summary>
    internal class Main
    {
        /// <summary>
        /// The Western Suburbs Croquet Club has two categories of membership, Senior and Open. They would like your help with an application form that will tell prospective members which category they will be placed.
        /// To be a senior, a member must be at least 55 years old and have a handicap greater than 7. In this croquet club, handicaps range from -2 to +26; the better the player the lower the handicap.
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static IEnumerable<string> OpenOrSenior(int[][] data) => data.Select(i => (i[0] >= 55 && i[1] > 7) ? "Senior" : "Open");

        /// <summary>
        /// Simple, given a string of words, return the length of the shortest word(s).
        /// String will never be empty and you do not need to account for different data types.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static int FindShort(string s) => s.Split().Min(x => x.Length);
    }
}
