using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KataStringCalculator
{
    public static class SplitterExtension
    {
        public static IEnumerable<int> Splitter(this string numbers) => numbers.Split(new char[] { ',', '\n' }, StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x));

    }
}
