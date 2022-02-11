using KataStringCalculator.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KataStringCalculator
{
    public static class ValidatorExtension
    {
        public static (string, string[]) ValidateString(this string numbers)
        {
            var tupla = numbers.CheckPersonalizedSeparator();
            foreach (var item in tupla.Item2)
            {
                if (numbers.EndsWith(item))
                    throw new SeparatorAtTheEndOfStringException("String ends with separator");
            }
            return (tupla.Item1, tupla.Item2);
        }
        public static string ValidateString2(this string numbers, out string[] separator)
        {
            var tupla = numbers.CheckPersonalizedSeparator();
            foreach (var item in tupla.Item2)
            {
                if (numbers.EndsWith(item))
                    throw new SeparatorAtTheEndOfStringException("String ends with separator");
            }
            separator = tupla.Item2;
            return tupla.Item1;
        }
        public static IEnumerable<int> CheckNegativeNumber(this IEnumerable<int> list)
            =>
            list.Any(x => x < 0) ?
                throw new NegativeNumberException() :
                list;
    }
}
