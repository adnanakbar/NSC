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
    public class OddNumberSequenceTest
    {
        [TestMethod]
        public void OddNumberSequenceTest_GetSequence_Gives_Correct_Count()
        {
            // Arrange
            const int number = 10;
            const int expectedCount = 5;
            var sequence = new OddNumberSequence();
            
            // Act
            IEnumerable<string> result = sequence.GetSequence(number);

            // Assert
            Assert.AreEqual(expectedCount, result.Count(), "OddNumberSequenceTest_GetSequence_Gives_Correct_Count Failed");
        }

        [TestMethod]
        public void OddNumberSequenceTest_GetSequence_Gives_Correct_Sequence()
        {
            // Arrange
            const int number = 5;

            var sequence = new OddNumberSequence();


            // Act
            var result = sequence.GetSequence(number).ToList();

            // Assert
            Assert.AreEqual("1", result[0], "OddNumberSequenceTest_GetSequence_Gives_Correct_Sequence Failed");
            Assert.AreEqual("3", result[1], "OddNumberSequenceTest_GetSequence_Gives_Correct_Sequence Failed");
            Assert.AreEqual("5", result[2], "OddNumberSequenceTest_GetSequence_Gives_Correct_Sequence Failed");

        }

    }
}
