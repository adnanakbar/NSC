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
    public class AllNumbersMultipleSequenceTest
    {
        [TestMethod]
        public void AllNumbersMultipleSequence_GetSequence_Gives_Correct_Count()
        {
            // Arrange
            const int number = 10;
            const int expectedCount = 10;
            var sequence = new AllNumbersMultipleSequence();
            
            // Act
            IEnumerable<string> result = sequence.GetSequence(number);

            // Assert
            Assert.AreEqual(expectedCount, result.Count(), "AllNumbersMultipleSequence_GetSequence Failed");
        }


        [TestMethod]
        public void AllNumbersMultipleSequence_GetSequence_Gives_Correct_Expected_Multiple_Of_3()
        {
            // Arrange
            const int number = 10;
            const int expectedCount = 10;
            const string expectedMultipleOf3 = "C";

            var sequence = new AllNumbersMultipleSequence();


            // Act
            var result = sequence.GetSequence(number).ToList();

            // Assert
            Assert.AreEqual(expectedCount, result.Count(), "AllNumbersMultipleSequence_GetSequence_Gives_Correct_Expected_Multiple_Of_All_Combinations Failed");
            Assert.AreEqual(expectedMultipleOf3, result[2], "AllNumbersMultipleSequence_GetSequence_Gives_Correct_Expected_Multiple_Of_All_Combinations Failed");

        }

        [TestMethod]
        public void AllNumbersMultipleSequence_GetSequence_Gives_Correct_Expected_Multiple_Of_5()
        {
            // Arrange
            const int number = 10;
            const int expectedCount = 10;
            const string expectedMultipleOf5 = "E";

            var sequence = new AllNumbersMultipleSequence();


            // Act
            var result = sequence.GetSequence(number).ToList();

            // Assert
            Assert.AreEqual(expectedCount, result.Count(), "AllNumbersMultipleSequence_GetSequence_Gives_Correct_Expected_Multiple_Of_All_Combinations Failed");
            Assert.AreEqual(expectedMultipleOf5, result[4], "AllNumbersMultipleSequence_GetSequence_Gives_Correct_Expected_Multiple_Of_All_Combinations Failed");

        }

        [TestMethod]
        public void AllNumbersMultipleSequence_GetSequence_Gives_Correct_Expected_Multiple_Of_All_Combinations()
        {
            // Arrange
            const int number = 15;
            const int expectedCount = 15;
            const string expectedMultipleOf3 = "C";
            const string expectedMultipleOf5 = "E";
            const string expectedMultipleOf3And5 = "Z";

            var sequence = new AllNumbersMultipleSequence();

            // Act
            var result = sequence.GetSequence(number).ToList();

            // Assert
            Assert.AreEqual(expectedCount, result.Count(), "AllNumbersMultipleSequence_GetSequence_Gives_Correct_Expected_Multiple_Of_All_Combinations Failed");
            Assert.AreEqual("1", result[0], "AllNumbersMultipleSequence_GetSequence_Gives_Correct_Expected_Multiple_Of_All_Combinations Failed");
            Assert.AreEqual(expectedMultipleOf3, result[2], "AllNumbersMultipleSequence_GetSequence_Gives_Correct_Expected_Multiple_Of_All_Combinations Failed");
            Assert.AreEqual(expectedMultipleOf5, result[4], "AllNumbersMultipleSequence_GetSequence_Gives_Correct_Expected_Multiple_Of_All_Combinations Failed");
            Assert.AreEqual(expectedMultipleOf3And5, result[14], "AllNumbersMultipleSequence_GetSequence_Gives_Correct_Expected_Multiple_Of_All_Combinations Failed");

        }

        

    }
}
