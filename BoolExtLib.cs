using System;
using System.Collections.Generic;
using System.Text;

namespace UserMethods
{
    ///<summary>
    ///Boolean Extensions Library contains overloads and local implementations of methods used in multiple programs
    ///</summary>
    public static class BoolExtLib
    {
        /// <summary>
        /// Toggles the caller between true and false
        /// </summary>
        /// <returns>The caller</returns>
        public static bool T(this bool b)
        {
            b = !b;
            return b;
        }
    }
}
