using KataStringCalculator.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KataStringCalculator
{
    public class NotNegativeValidator : AbstractValidator
    {
        public override List<int> Validate(List<int> numbers)
            =>
            numbers.Any(x => x < 0) ?
                 throw new NegativeNumberException() :
                 (Next == null ? numbers : Next.Validate(numbers));

    }
}
