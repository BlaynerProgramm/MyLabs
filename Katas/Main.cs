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

        /// <summary>
        /// Write a function that takes in a string of one or more words, and returns the same string, but with all five or more letter words reversed (Just like the name of this Kata). Strings passed in will consist of only letters and spaces. Spaces will be included only when more than one word is present.
        /// Examples: spinWords( "Hey fellow warriors" ) => returns "Hey wollef sroirraw" spinWords( "This is a test") => returns "This is a test" spinWords( "This is another test" ) => returns "This is rehtona test"
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string SpinWords(string str)
        {
            string[] strArray = str.Split();
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < strArray.Length; i++)
            {
                if (strArray[i].Length >= 5)
                {
                    char[] spinWord = strArray[i].ToCharArray();
                    Array.Reverse(spinWord);
                    sb.Append(spinWord);
                }
                else
                {
                    sb.Append(strArray[i]);
                }

                sb.Append(" ");
            }

            return sb.ToString().TrimEnd();
        }

        /// <summary>
        /// Given an array of integers, find the one that appears an odd number of times.
        ///There will always be only one integer that appears an odd number of times.
        ///Examples
        ///[7] should return 7, because it occurs 1 time (which is odd).
        ///[0] should return 0, because it occurs 1 time(which is odd).
        ///[1,1,2] should return 2, because it occurs 1 time(which is odd).
        ///[0,1,0,1,0] should return 0, because it occurs 3 times(which is odd).
        ///[1,2,2,3,3,3,4,3,3,3,2,2,1] should return 4, because it appears 1 time(which is odd).
        /// </summary>
        /// <param name="seq"></param>
        /// <returns></returns>
        public static int find_it(int[] seq) => seq.GroupBy(x => x).ToDictionary(x => x.Key, x => x.Count()).SingleOrDefault(x => x.Value % 2 != 0).Key;
    }
}
