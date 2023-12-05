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
    }
}