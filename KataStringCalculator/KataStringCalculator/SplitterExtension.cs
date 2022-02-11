using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KataStringCalculator
{
    public static class SplitterExtension
    {
        public static IEnumerable<int> Splitter(this string numbers) 
            => 
            numbers.ValidateString2(out string[] separator)
            .Split(separator, StringSplitOptions.RemoveEmptyEntries)
            .Select(x => int.Parse(x));

        public static (string, string[]) CheckPersonalizedSeparator(this string numbers)
        {
            var DefaultSeparator = new string[] { ",", "\n" };
            if (!numbers.StartsWith("//"))
                return (numbers, DefaultSeparator);

            var temp = numbers.Split("\n", 2);
            var separator = new string[] { temp[0].Substring(2) };
            return (temp[1], separator);
        }

    }
}
