using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.InteropServices;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NumericSequenceCalculator.SequenceEngine.Test
{
    [TestClass]
    [ExcludeFromCodeCoverage]
    public class FibonacciSequenceTest
    {
        [TestMethod]
        public void FibonacciSequence_GetSequence_Gives_Correct_Count()
        {
            // Arrange
            const int number = 10;
            const int expectedCount = 7;
            var sequence = new FibonacciSequence();
            
            // Act
            IEnumerable<string> result = sequence.GetSequence(number);

            // Assert
            Assert.AreEqual(expectedCount, result.Count(), "FibonacciSequence_GetSequence_Gives_Correct_Count Failed");
        }

        [TestMethod]
        public void FibonacciSequence_GetSequence_Gives_Correct_Sequence()
        {
            // Arrange
            const int number = 20;

            var sequence = new FibonacciSequence();


            // Act
            var result = sequence.GetSequence(number).ToList();

            // Assert
            Assert.AreEqual("0", result[0], "FibonacciSequence_GetSequence_Gives_Correct_Sequence Failed");
            Assert.AreEqual("1", result[1], "FibonacciSequence_GetSequence_Gives_Correct_Sequence Failed");
            Assert.AreEqual("1", result[2], "FibonacciSequence_GetSequence_Gives_Correct_Sequence Failed");
            Assert.AreEqual("2", result[3], "FibonacciSequence_GetSequence_Gives_Correct_Sequence Failed");
            Assert.AreEqual("3", result[4], "FibonacciSequence_GetSequence_Gives_Correct_Sequence Failed");
            Assert.AreEqual("5", result[5], "FibonacciSequence_GetSequence_Gives_Correct_Sequence Failed");
            Assert.AreEqual("8", result[6], "FibonacciSequence_GetSequence_Gives_Correct_Sequence Failed");
            Assert.AreEqual("13", result[7], "FibonacciSequence_GetSequence_Gives_Correct_Sequence Failed");

        }

    }
}
