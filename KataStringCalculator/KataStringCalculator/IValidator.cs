using System;
using System.Collections.Generic;
using System.Text;

namespace KataStringCalculator
{
    public interface IValidator
    {
        public List<int> Validate(List<int> numbers);
    }
}
