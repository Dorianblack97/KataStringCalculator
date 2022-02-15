using System;

namespace KataStringCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserisci una stringa di numeri:");
            var read = Console.ReadLine();
            Console.WriteLine($"Il risultato è => {Calculate(read)}");
            Console.ReadKey();
        }

        private static int Calculate(string input)
        {
            var validatorNotNegativeValidator = new NotNegativeValidator();
            validatorNotNegativeValidator.SetNext(new NumberLimitValidator());             
            Calculator calculator = new Calculator(validatorNotNegativeValidator);
            return calculator.Add(input);
        }
    }
}
