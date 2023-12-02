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
        [TestMethod]
        public void Input33_ReturnsFizz()
        {
            // Arrange
            var fizzBuzz = new FizzBuzz();

            // Act
            var result = fizzBuzz.GetResult(33);

            // Assert
            Assert.AreEqual("Fizz", result);
        }
        [TestMethod]
        public void Input55_ReturnsBuzz()
        {
            // Arrange
            var fizzBuzz = new FizzBuzz();

            // Act
            var result = fizzBuzz.GetResult(55);

            // Assert
            Assert.AreEqual("Buzz", result);
        }
        [TestMethod]
        public void Input15_ReturnsFizzBuzz()
        {
            // Arrange
            var fizzBuzz = new FizzBuzz();

            // Act
            var result = fizzBuzz.GetResult(15);

            // Assert
            Assert.AreEqual("FizzBuzz", result);
        }
        [TestMethod]
        public void InputNegative_ReturnsEmpty()
        {
            // Arrange
            var fizzBuzz = new FizzBuzz();

            // Act
            var result = fizzBuzz.GetResult(-1);

            // Assert
            Assert.AreEqual(string.Empty, result);
        }
    }
}