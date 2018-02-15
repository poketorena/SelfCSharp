using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfCSharp.Chap08.ExtensionBasic
{
    static class StringExtensions
    {
        public static string Repeat(this string str, int count)
        {
            var builder = new StringBuilder();
            for (int i = 0; i < count; i++)
            {
                builder.Append(str);
            }
            return builder.ToString();
        }

        public static string ToTitleCase(this string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return null;
            }

            if (str.Length == 1)
            {
                return str[0].ToString().ToUpper();
            }
            return str[0].ToString().ToUpper() + str.Substring(1);
        }
    }
}
