using System.Collections.Generic;

namespace NumericSequenceCalculator.Common
{
    public interface ISequence
    {
        IEnumerable<string> GetSequence(ulong number);
    }
}