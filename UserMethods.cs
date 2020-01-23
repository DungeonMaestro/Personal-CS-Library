using System;
using System.Collections.Generic;
using System.Text;

namespace UserMethods
{
    public static class UserMethods
    {
        public static void Sleep(double msec)
        {
            DateTime t = DateTime.Now.AddMilliseconds(msec);
            while(DateTime.Now < t) { }
        }
    }
}
