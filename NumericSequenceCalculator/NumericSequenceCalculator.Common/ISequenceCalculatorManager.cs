using System.Threading.Tasks;

namespace NumericSequenceCalculator.Common
{
    public interface ISequenceCalculatorManager
    {
        Task<string> GetAllNumberSequence(ulong number);
        Task<string> GetEvenNumberSequence(ulong number);
        Task<string> GetOddNumberSequence(ulong number);
        Task<string> GetAllNumberMultipleSequence(ulong number);
        Task<string> GetFibonacciSequence(ulong number);
    }
}