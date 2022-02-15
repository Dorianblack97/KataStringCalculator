using KataStringCalculator.Exceptions;
using System.Collections.Generic;
using System.Linq;

namespace KataStringCalculator
{
    public static class NegativeNumberChecketExtension
    {
        public static IEnumerable<int> CheckNegativeNumber(this IEnumerable<int> list)
            =>
            list.Any(x => x < 0) ?
                throw new NegativeNumberException() :
                list;

        public static int CheckNegativeNumber(this int number)
            =>
            number < 0 ?
                throw new NegativeNumberException() :
                number;
    }
}