using System;
using System.Collections.Generic;
using System.Text;

namespace ExampleUI
{
    public static class StringExtension
    {
        public static string ConvertStringToPascalCase(this string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                return "";
            }
            var pascalCase = value.Substring(0, 1).ToUpper() + value.Substring(1, value.Length - 1).ToLower();
            
            return pascalCase;
        }
    }
}
