using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using NumericSequenceCalculator.Common;

namespace NumericSequenceCalculator.BLL.Test
{
    [TestClass]
    [ExcludeFromCodeCoverage]
    public class SequenceCalculatorManagerTest
    {
        [TestMethod]
        public async Task SequenceCalculatorManager_GetAllNumberSequence()
        {
            // Arrange
            IEnumerable<string> returnedValue = new []{"1","2","3","4","5"};
            var expected = "1 , 2 , 3 , 4 , 5";

            var mockedAllNumbersSequence = new Mock<IAllNumbersSequence>();

            mockedAllNumbersSequence.Setup(m => m.GetSequence(It.IsAny<ulong>())).Returns(returnedValue);

            var manager = new SequenceCalculatorManager(mockedAllNumbersSequence.Object, null, null, null, null);

            //Act
            var result = await manager.GetAllNumberSequence(5);

            //Assert
            Assert.AreEqual(expected, result, "SequenceCalculatorManager_GetAllNumberSequence Failed");
        }

        [TestMethod]
        public async Task SequenceCalculatorManager_GetEvenNumberSequence()
        {
            // Arrange
            IEnumerable<string> returnedValue = new[] { "2", "4", "6", "8", "10" };
            var expected = "2 , 4 , 6 , 8 , 10";

            var mockedEvenNumberSequence = new Mock<IEvenNumberSequence>();

            mockedEvenNumberSequence.Setup(m => m.GetSequence(It.IsAny<ulong>())).Returns(returnedValue);

            var manager = new SequenceCalculatorManager(null, null, null, mockedEvenNumberSequence.Object, null);

            //Act
            var result = await manager.GetEvenNumberSequence(10);

            //Assert
            Assert.AreEqual(expected, result, "SequenceCalculatorManager_GetEvenNumberSequence Failed");
        }

        [TestMethod]
        public async Task SequenceCalculatorManager_GetOddNumberSequence()
        {
            // Arrange
            IEnumerable<string> returnedValue = new[] { "1", "3", "5", "7", "9" };
            var expected = "1 , 3 , 5 , 7 , 9";

            var mockedOddNumberSequence = new Mock<IOddNumberSequence>();

            mockedOddNumberSequence.Setup(m => m.GetSequence(It.IsAny<ulong>())).Returns(returnedValue);

            var manager = new SequenceCalculatorManager(null, null, mockedOddNumberSequence.Object, null, null);

            //Act
            var result = await manager.GetOddNumberSequence(10);

            //Assert
            Assert.AreEqual(expected, result, "SequenceCalculatorManager_GetOddNumberSequence Failed");
        }

        [TestMethod]
        public async Task SequenceCalculatorManager_GetAllNumberMultipleSequence()
        {
            // Arrange
            IEnumerable<string> returnedValue = new[] { "1", "2", "C", "4", "E", "C", "7","8","C","E","11","C","13","14","Z" };
            var expected = "1 , 2 , C , 4 , E , C , 7 , 8 , C , E , 11 , C , 13 , 14 , Z";

            var mockedAllNumbersMultipleSequence= new Mock<IAllNumbersMultipleSequence>();

            mockedAllNumbersMultipleSequence.Setup(m => m.GetSequence(It.IsAny<ulong>())).Returns(returnedValue);

            var manager = new SequenceCalculatorManager(null, mockedAllNumbersMultipleSequence.Object, null, null, null);

            //Act
            var result = await manager.GetAllNumberMultipleSequence(15);

            //Assert
            Assert.AreEqual(expected, result, "SequenceCalculatorManager_GetAllNumberMultipleSequence Failed");
        }

        [TestMethod]
        public async Task SequenceCalculatorManager_GetFibonacciSequence()
        {
            // Arrange
            IEnumerable<string> returnedValue = new[] { "0", "1", "1", "2", "3", "5", "8", "13" };
            var expected = "0 , 1 , 1 , 2 , 3 , 5 , 8 , 13";

            var mockedFibonacciSequence = new Mock<IFibonacciSequence>();

            mockedFibonacciSequence.Setup(m => m.GetSequence(It.IsAny<ulong>())).Returns(returnedValue);

            var manager = new SequenceCalculatorManager(null, null, null, null, mockedFibonacciSequence.Object);

            //Act
            var result = await manager.GetFibonacciSequence(15);

            //Assert
            Assert.AreEqual(expected, result, "SequenceCalculatorManager_GetFibonacciSequence Failed");
        }

    }
}
