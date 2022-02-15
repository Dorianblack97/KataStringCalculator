using System.Collections.Generic;
using System.Linq;

namespace KataStringCalculator
{
    public static class OutnumberCheckerExtension 
    {
        public static IEnumerable<int> CheckOutnumber(this IEnumerable<int> list)
        {
            var result = list.ToList();
            for (int i = 0; i < result.Count(); i++)
            {
                result[i] = result[i].CheckOutnumber();
            }
            return result;
        }
        public static int CheckOutnumber(this int number)
        {
            if (number >= 1000)
                number = number % 1000;
            return number;
        }
    }
}