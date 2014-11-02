using System.Collections.Generic;
using NumericSequenceCalculator.Common;

namespace NumericSequenceCalculator.SequenceEngine
{
    public class AllNumbersSequence : IAllNumbersSequence
    {
        public IEnumerable<string> GetSequence(ulong number)
        {
            for (ulong i = 1; i <= number; i++)
            {
                yield return i.ToString();
            }
        }
    }
}