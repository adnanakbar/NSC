using System.Collections.Generic;
using NumericSequenceCalculator.Common;
using NumericSequenceCalculator.SequenceEngine.Extensions;

namespace NumericSequenceCalculator.SequenceEngine
{
    public class AllNumbersMultipleSequence : IAllNumbersMultipleSequence
    {
        public IEnumerable<string> GetSequence(ulong number)
        {
            for (ulong i = 1; i <= number; i++)
            {
                yield return
                    i.IsMultipleOf3And5() ? "Z" : i.IsMultipleOf3() ? "C" : i.IsMultipleOf5() ? "E" : i.ToString();
            }
        }
    }
}