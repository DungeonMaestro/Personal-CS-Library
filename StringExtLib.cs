using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UserMethods
{
    public static class StringExtLib
    {
        /// <summary>
        /// This method checks a passed set of strings to see if any of them are a substring of the main string
        /// </summary>
        /// <param name="s">The string being processed</param>
        /// <param name="vals">The set of possible substrings being considered</param>
        /// <returns>Returns true if any element of vals is a substring of s, false otherwise</returns>
        public static bool Contains(this string s, IEnumerable<string> vals)
        {
            foreach (var v in vals)
            {
                if (s.Contains(v)) return true;
            }
            return false;
        }

        /// <summary>
        /// This method checks a passed set of strings to see if any of them are a substring of the main string
        /// </summary>
        /// <param name="s">The string being processed</param>
        /// <param name="vals">The set of possible substrings being considered</param>
        /// <returns>Return true if all elements of vals is a substring of s, false otherwise</returns>
        public static bool ContainsAll(this string s, IEnumerable<string> vals)
        {
            foreach (var v in vals)
            {
                if (!s.Contains(v)) return false;
            }
            return true;
        }

        /// <summary>
        /// This method converts a string into the Title case
        /// </summary>
        /// <example>
        /// "1:of miCe & men" -> "1:Of Mice & Men"
        /// </example>
        /// <remarks>
        /// This method will not correctly modify strings whose words have no delimiter
        /// </remarks>
        /// <param name="input">The string being processed</param>
        /// <param name="delimiter">An optional parameter if the string doesn't use spaces to isolate words</param>
        /// <returns>The main string in the titular case</returns>
        public static string ToTitular(this string input, char delimiter = ' ')
        {
            string[] tmp = input.Split(delimiter);                  //Split the string up by the delimiter..
            for (int i = 0; i < tmp.Length; i++)                    //then for each segment...
            {
                int j = 0;

                while (!(tmp[i][j].IsLetter()) && j < tmp[i].Length)
                {
                    j++;                                            //Walk through each character until you find a letter
                }
                if (j < tmp[i].Length)
                {
                    tmp[i] = (j > 0 ? tmp[i].Substring(0, j) : "") + tmp[i].Substring(j, 1).ToUpper() + tmp[i].Substring(1).ToLower();  //convert the segment into the capitalized first letter and the rest of the segment if there are any letters.
                }
            }
            return tmp.ToString(" ");                                  //Return the re-combined array as a string
        }

        /// <summary>
        /// checks if a string is null or empty
        /// </summary>
        /// <param name="s">the passed string</param>
        /// <returns>true if the string is null or empty, false otherwise</returns>
        public static bool IsNullOrEmpty(this string s)
        {
            return s == "" || s == null;
        }
        /// <summary>
        /// overloads the Contains() method of the string class to test an array of characters
        /// </summary>
        /// <param name="s">The string being processed</param>
        /// <param name="characters">The collection of characters being considered</param>
        /// <returns>Returns true if s contains any elements of characters, false otherwise</returns>
        public static bool Contains(this string s, IEnumerable<char> characters)
        {
            foreach (char c in characters)
            {
                if (s.Contains(c)) return true;
            }
            return false;
        }

        /// <summary>
        /// overloads the Contains() method of the string class to test an array of characters
        /// </summary>
        /// <param name="s">The string being processed</param>
        /// <param name="characters">The array of characters being considered</param>
        /// <returns>Returns true if s contains all elements of characters, false otherwise</returns>
        public static bool ContainsAll(this string s, IEnumerable<char> characters)
        {
            foreach (char c in characters)
            {
                if (!s.Contains(c)) return false;
            }
            return true;
        }

        /// <summary>
        /// Converts the string to a list of strings based on a provided or implied delimiter
        /// </summary>
        /// <param name="s">The string being processed</param>
        /// <param name="delimiter">The character to considered to separate elements</param>
        /// <returns>A list of substrings of s</returns>
        public static List<string> ToList(this string s, char delimiter = ' ')
        {
            return s.Split(delimiter).ToList();
        }

        /// <summary>
        /// This method converts a string to an int
        /// </summary>
        /// <param name="s">The string being processed</param>
        /// <returns>Returns an int if successful, null otherwise</returns>
        public static int? stoi(this string s)
        {
            try
            {
                return Int32.Parse(s);
            }
            catch
            {
                return null;
            }
        }
    }
}
