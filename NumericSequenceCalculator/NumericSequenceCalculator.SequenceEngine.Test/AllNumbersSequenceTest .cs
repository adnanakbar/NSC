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
    public class AllNumbersSequenceTest
    {
        [TestMethod]
        public void AllNumbersSequence_GetSequence_Gives_Correct_Count()
        {
            // Arrange
            const int number = 10;
            const int expectedCount = 10;
            var sequence = new AllNumbersSequence();
            
            // Act
            IEnumerable<string> result = sequence.GetSequence(number);

            // Assert
            Assert.AreEqual(expectedCount, result.Count(), "AllNumbersSequence_GetSequence_Gives_Correct_Count Failed");
        }


        [TestMethod]
        public void AllNumbersSequence_GetSequence_Gives_Correct_Sequence()
        {
            // Arrange
            const int number = 3;
            const int expectedCount = 3;

            var sequence = new AllNumbersSequence();


            // Act
            var result = sequence.GetSequence(number).ToList();

            // Assert
            Assert.AreEqual(expectedCount, result.Count(), "AllNumbersSequence_GetSequence_Gives_Correct_Sequence Failed");
            Assert.AreEqual("1", result[0], "AllNumbersSequence_GetSequence_Gives_Correct_Sequence Failed");
            Assert.AreEqual("2", result[1], "AllNumbersSequence_GetSequence_Gives_Correct_Sequence Failed");
            Assert.AreEqual("3", result[2], "AllNumbersSequence_GetSequence_Gives_Correct_Sequence Failed");

        }

    }
}
