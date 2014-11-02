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
    public class EvenNumberSequenceTest
    {
        [TestMethod]
        public void EvenNumberSequence_GetSequence_Gives_Correct_Count()
        {
            // Arrange
            const int number = 10;
            const int expectedCount = 5;
            var sequence = new EvenNumberSequence();
            
            // Act
            IEnumerable<string> result = sequence.GetSequence(number);

            // Assert
            Assert.AreEqual(expectedCount, result.Count(), "EvenNumberSequence_GetSequence_Gives_Correct_Count Failed");
        }

        [TestMethod]
        public void EvenNumberSequence_GetSequence_Gives_Correct_Sequence()
        {
            // Arrange
            const int number = 6;

            var sequence = new EvenNumberSequence();


            // Act
            var result = sequence.GetSequence(number).ToList();

            // Assert
            Assert.AreEqual("2", result[0], "EvenNumberSequence_GetSequence_Gives_Correct_Sequence Failed");
            Assert.AreEqual("4", result[1], "EvenNumberSequence_GetSequence_Gives_Correct_Sequence Failed");
            Assert.AreEqual("6", result[2], "EvenNumberSequence_GetSequence_Gives_Correct_Sequence Failed");

        }

    }
}
