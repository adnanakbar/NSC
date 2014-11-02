namespace NumericSequenceCalculator.SequenceEngine.Extensions
{
    public static class NumberExtension
    {
        public static bool IsMultipleOf3(this ulong number)
        {
            return number % 3 == 0;
        }

        public static bool IsMultipleOf5(this ulong number)
        {
            return number % 5 == 0;
        }

        public static bool IsMultipleOf3And5(this ulong number)
        {
            return (number % 3 == 0 && number % 5 == 0);
        }
    }
}