namespace KataStringCalculator
{
    public static class PersonalizedSeparatorCheckerExtension
    {
        public static (string, string[]) CheckPersonalizedSeparator(this string numbers)
        {
            var DefaultSeparator = new string[] { ",", "\n" };
            if (!numbers.StartsWith("//"))
                return (numbers, DefaultSeparator);

            var temp = numbers.Split("\n", 2);
            var separator = new string[] { temp[0].Substring(2) };
            return (temp[1], separator);
        }
    }
}