using DiversionKata;

namespace DiversionTests
{
    [TestClass]
    public class DiversionTest
    {
        [TestMethod]
        public void Test_CountBinarySequences_WhenNIs1()
        {
            // Arrange
            int n = 1;
            int expected = 2;
            var sequenceCounter = new Diversion();

            // Act
            int actual = sequenceCounter.CountBinarySequencesWithoutAdjacentOnes(n);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_CountBinarySequences_WhenNIs5()
        {
            // Arrange
            int n = 5;
            int expected = 13;
            var sequenceCounter = new Diversion();

            // Act
            int actual = sequenceCounter.CountBinarySequencesWithoutAdjacentOnes(n);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_CountBinarySequences_WhenNIs10()
        {
            // Arrange
            int n = 10;
            int expected = 144;
            var sequenceCounter = new Diversion();

            // Act
            int actual = sequenceCounter.CountBinarySequencesWithoutAdjacentOnes(n);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_CountBinarySequences_WhenNIsLarge()
        {
            // Arrange
            int n = 50;
            var sequenceCounter = new Diversion();

            // Act
            int result = sequenceCounter.CountBinarySequencesWithoutAdjacentOnes(n);

            // Assert
            Assert.IsTrue(result > 0);
        }
    }
}