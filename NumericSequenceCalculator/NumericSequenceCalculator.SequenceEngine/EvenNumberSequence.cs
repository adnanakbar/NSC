using System.Collections.Generic;
using NumericSequenceCalculator.Common;

namespace NumericSequenceCalculator.SequenceEngine
{
    public class EvenNumberSequence : IEvenNumberSequence
    {
        public IEnumerable<string> GetSequence(ulong number)
        {
            for (ulong i = 1; i <= number; i++)
            {
                if (i % 2 == 0)
                    yield return i.ToString();
            }
        }
    }
}