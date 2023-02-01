using System;
using System.Collections.Generic;
using System.Globalization;

namespace System
{
    static class StringExtensions
    {
        public static string Cut(this string thisObj, int number)
        {
            if (thisObj.Length <= number)
            {
                return thisObj;
            }
            else
            {
                return thisObj.Substring(0, number) + "...";
            }
        }
    }
}
