using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KataStringCalculator
{
    public class NumberLimitValidator : AbstractValidator
    {
        public override List<int> Validate(List<int> numbers)
        {
            for (int i = 0; i < numbers.Count(); i++)
            {
                numbers[i] = numbers[i].CheckOutnumber();
            }
            if (Next == null)
                return numbers;

            return Next.Validate(numbers);
        }
    }
}
