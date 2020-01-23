using System;
using System.Collections.Generic;
using System.Text;

namespace UserMethods
{
    /// <summary>
    /// This is a wrapper class for Boolean called TBoolean (Togglable Boolean), allowing the implementation of operator overloads prohibited by bool being sealed
    /// </summary>
    public class TBoolean
    {
        /// <summary>
        /// The wrapped Boolean
        /// </summary>
        private bool B { get; set; }

        /// <summary>
        /// Toggles the Togglable Boolean's Boolean
        /// </summary>
        /// <returns>The toggled Togglable Boolean</returns>
        public TBoolean T()
        {
            B = !B;
            return B;
        }

        /// <summary>
        /// Overloads the ToString() method as the ToString() of the wrapped boolean
        /// </summary>
        /// <returns>B.ToString()</returns>
        public override string ToString()
        {
            return B.ToString();
        }

        /// <summary>
        /// implicit conversion overloads that let the code treat a boolean as a togglable boolean
        /// </summary>
        /// <param name="b">The boolean/TBoolean being cast</param>
        public static implicit operator bool(TBoolean b)
        {
            return b.B;
        }
        /// <summary>
        /// implicit conversion overloads that let the code treat a togglable boolean as a boolean
        /// </summary>
        /// <param name="b"></param>
        public static implicit operator TBoolean(bool b)
        {
            return new TBoolean { B = b };
        }


        //This doesn't work. Should overload the bitwise compliment operator as a replacement for the t() operator below, but C# amd I disagree on how developers should be allowed to implement overloading
        //public static TBoolean operator ~(ref TBoolean b)
        //{
        //    b = !b;
        //    return b;
        //}

#pragma warning disable IDE0060 // Remove unused parameter
                               /// <summary>
                               /// Overloads the decrement operator to set a TBoolean to false
                               /// </summary>
                               /// <param name="b">A possibly unnecessary parameter that represents the TBoolean being operated on</param>
                               /// <returns>false</returns>
        public static TBoolean operator --(TBoolean b)
        {
            return false;
        }
        /// <summary>
        /// Overloads the increment operator to set a TBoolean to true
        /// </summary>
        /// <param name="b">A possibly unnecessary parameter that represents the TBoolean being operated on</param>
        /// <returns>true</returns>
        public static TBoolean operator ++(TBoolean b)
        {
            return true;
        }
#pragma warning restore IDE0060 // Remove unused parameter
    }
}
