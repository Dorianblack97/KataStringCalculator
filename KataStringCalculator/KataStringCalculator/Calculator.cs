using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KataStringCalculator
{
    public class Calculator : ICalculator
    {
        public int Add(string numbers) => numbers.Splitter().Sum();        

    }
}
