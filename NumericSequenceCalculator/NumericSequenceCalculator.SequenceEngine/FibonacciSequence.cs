using System.Collections.Generic;
using NumericSequenceCalculator.Common;

namespace NumericSequenceCalculator.SequenceEngine
{
    public class FibonacciSequence : IFibonacciSequence
    {
        public IEnumerable<string> GetSequence(ulong number)
        {
            ulong previous = 0;
            ulong next = 1;
            ulong returnValue = 0;

            for (ulong i = 0; i <= number; i++)
            {
                if (i > 1)
                {
                    returnValue = previous + next;
                    previous = next;
                    next = returnValue;
                }
                else
                {
                    returnValue = i;
                }

                if (returnValue > number)
                    yield break;
                yield return returnValue.ToString();
            }
        }
    }
}