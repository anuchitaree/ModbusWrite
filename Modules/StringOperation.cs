using System;

namespace ModbusWrite.Modules
{
    public static class StringOperation
    {



        public static string RemoveWhitespace(this string str)
        {
            return string.Join("", str.Split(default(string[]), StringSplitOptions.RemoveEmptyEntries));
        }

    }
}
