using System;
using System.Threading.Tasks;
using NumericSequenceCalculator.Common;

namespace NumericSequenceCalculator.BLL
{
    public class SequenceCalculatorManager : ISequenceCalculatorManager
    {
        private readonly IAllNumbersMultipleSequence _allNumbersMultipleSequence;
        private readonly IAllNumbersSequence _allNumbersSequence;
        private readonly IEvenNumberSequence _evenNumberSequence;
        private readonly IFibonacciSequence _fibonacciSequence;
        private readonly IOddNumberSequence _oddNumberSequence;

        public SequenceCalculatorManager(IAllNumbersSequence allNumbersSequence,
            IAllNumbersMultipleSequence allNumbersMultipleSequence, IOddNumberSequence oddNumberSequence,
            IEvenNumberSequence evenNumberSequence, IFibonacciSequence fibonacciSequence)
        {
            _allNumbersSequence = allNumbersSequence;
            _allNumbersMultipleSequence = allNumbersMultipleSequence;
            _oddNumberSequence = oddNumberSequence;
            _evenNumberSequence = evenNumberSequence;
            _fibonacciSequence = fibonacciSequence;
        }

        public async Task<string> GetAllNumberSequence(ulong number)
        {
            string result = String.Empty;

            await Task.Run(() => { result = string.Join(" , ", _allNumbersSequence.GetSequence(number)); });

            return result;
        }

        public async Task<string> GetEvenNumberSequence(ulong number)
        {
            string result = String.Empty;

            await Task.Run(() => { result = string.Join(" , ", _evenNumberSequence.GetSequence(number)); });

            return result;
        }

        public async Task<string> GetOddNumberSequence(ulong number)
        {
            string result = String.Empty;

            await Task.Run(() => { result = string.Join(" , ", _oddNumberSequence.GetSequence(number)); });

            return result;
        }

        public async Task<string> GetAllNumberMultipleSequence(ulong number)
        {
            string result = String.Empty;

            await Task.Run(() => { result = string.Join(" , ", _allNumbersMultipleSequence.GetSequence(number)); });

            return result;
        }

        public async Task<string> GetFibonacciSequence(ulong number)
        {
            string result = String.Empty;

            await Task.Run(() => { result = string.Join(" , ", _fibonacciSequence.GetSequence(number)); });

            return result;
        }
    }
}