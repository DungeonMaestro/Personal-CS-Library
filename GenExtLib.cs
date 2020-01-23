using System;
using System.Collections.Generic;
using System.Text;

namespace UserMethods
{
    /// <summary>
    /// Generics Extensions Library contains overloads and local implementations of methods used in multiple programs
    /// </summary>
    public static class GenExtLib
    {
        /// <summary>
        /// This tests to see if a value of Type T is an element of the array
        /// </summary>
        /// <typeparam name="T">The Datatype of the array studied</typeparam>
        /// <param name="S">The array being challenged</param>
        /// <param name="t">the challenging object</param>
        /// <returns>true if S contains an elemetn matching t, false otherwise</returns>
        public static bool Contains<T>(this IEnumerable<T> S, T t)
        {
            foreach (var s in S)
            {
                if (t.Equals(s)) return true;
            }
            return false;
        }
    }
}
