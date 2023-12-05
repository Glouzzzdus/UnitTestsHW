using OddEvenKata;

namespace OddEvenTests
{
    [TestClass]
    public class OddEvenTest
    {
        [TestMethod]
        public void Input1_ReturnsOdd()
        {
            // Arrange
            var oddEven = new OddEven();

            // Act
            var result = oddEven.GetResult(1);

            // Assert
            Assert.AreEqual("Odd ", result);
        }

        [TestMethod]
        public void Input2_ReturnsEvenPrime()
        {
            // Arrange
            var oddEven = new OddEven();

            // Act
            var result = oddEven.GetResult(2);

            // Assert
            Assert.AreEqual("Even Prime", result);
        }

        [TestMethod]
        public void Input3_ReturnsOddPrime()
        {
            // Arrange
            var oddEven = new OddEven();

            // Act
            var result = oddEven.GetResult(3);

            // Assert
            Assert.AreEqual("Odd Prime", result);
        }

        [TestMethod]
        public void Input4_ReturnsEvenComposite()
        {
            // Arrange
            var oddEven = new OddEven();

            // Act
            var result = oddEven.GetResult(4);

            // Assert
            Assert.AreEqual("Even Composite", result);
        }
    }
}