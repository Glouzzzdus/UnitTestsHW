using FizzBuzzKata;

namespace FizzBuzzTests
{
    [TestClass]
    public class FizzBuzzTest
    {
        [TestMethod]
        public void Input1_Returns1()
        {
            // Arrange
            var fizzBuzz = new FizzBuzz();

            // Act
            var result = fizzBuzz.GetResult(1);

            // Assert
            Assert.AreEqual("1", result);
        }
    }
}