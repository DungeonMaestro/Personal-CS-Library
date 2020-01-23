using System;
using System.Collections.Generic;
using System.Text;

namespace UserMethods
{
    /// <summary>
    /// This is a library of overloads and extensions for the List class
    /// </summary>
    public static class IEnumExtLib
    {

        /// <summary>
        /// This method overloads the ToString() of a generic IEnumerable to create a list of ToString()'s
        /// </summary>
        /// <typeparam name="T">A generic object type</typeparam>
        /// <param name="List">The set to be converted</param>
        /// <returns>A set containing the ToString() of each element of the passed list</returns>
        public static IEnumerable<string> ToString<T>(this IEnumerable<T> List)
        {
            List<string> result = new List<string>();
            foreach (T L in List)
            {
                result.Add(L.ToString());
            }
            return result;
        }


         /// <summary>
         /// This method converts a set of strings into a delimited string
         /// </summary>
         /// <param name="Set">The string set to be converted</param>
         /// <param name="delimiter">The character to separate each element with</param>
         /// <returns>A string containing each element separated by the provided delimiter</returns>
        public static string ToString<T>(this IEnumerable<T> Set, string delimiter = "\n")
        {
            string result = "";
            foreach (T s in Set)
            {
                //if l is the default value for a T or l is of type string and empty
                if (s == default || (typeof(T) == typeof(string) && s as string == "")) continue;
                result += s.ToString();
                result += delimiter;
            }
            return result.Trim(delimiter.ToCharArray());
        }
    }
}
