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
    }
}