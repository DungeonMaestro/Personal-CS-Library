
using System;
using System.Collections.Generic;
using System.Text;

namespace UserMethods
{
    /// <summary>
    /// Character Extensions Library contains overloads and local implementations of methods used in multiple programs
    /// </summary>
    public static class CharExtLib
    {
        /// <summary>
        /// Checks if the passed char is a letter
        /// </summary>
        /// <param name="c"></param>
        /// <returns>true if the char is a letter, false otherwise</returns>
        public static bool IsLetter(this char c)
        {
            return !(c < 'A' || (c > 'Z' && c < 'a') || c > 'z');
        }

        public static string ToString(this IEnumerable<char> C)
        {
            return C.ToString('');
        }
    }
}
