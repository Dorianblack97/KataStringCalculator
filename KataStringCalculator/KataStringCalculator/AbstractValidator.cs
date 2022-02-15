using System;
using System.Collections.Generic;
using System.Text;

namespace KataStringCalculator
{
    public abstract class AbstractValidator : IValidator
    {
        protected IValidator Next;
        public IValidator SetNext(IValidator validator)
        {
            Next = validator;
            return Next;
        }
        public abstract List<int> Validate(List<int> numbers);
    }
}
