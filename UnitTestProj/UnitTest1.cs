using NUnit.Framework;

namespace Calculator.Tests
{
    [TestFixture]
    public class UnitTestsSimpleCalculator
    {
        private SimpleCalculator _calculator;

        [SetUp]
        public void SetUp()
        {
            _calculator = new SimpleCalculator();
        }

        [Test]
        public void Add_ReturnsCorrectResult()
        {
            // Arrange
            int x = 1;
            int y = 2;

            // Act
            int result = _calculator.Add(x, y);

            // Assert
            Assert.That(result, Is.EqualTo(3));
        }

        [Test]
        public void Add_WithNegativeNumbers_ReturnsCorrectResult()
        {
            // Arrange
            int x = -1;
            int y = -2;

            // Act
            int result = _calculator.Add(x, y);

            // Assert
            Assert.That(result, Is.EqualTo(-3));
        }

        [Test]
        public void Add_WithLargeNumbers_ReturnsCorrectResult()
        {
            // Arrange
            int x = int.MaxValue - 1;
            int y = 1;

            // Act
            int result = _calculator.Add(x, y);

            // Assert
            Assert.That(result, Is.EqualTo(int.MaxValue));
        }

        [Test]
        public void Subtract_ReturnsCorrectResult()
        {
            // Arrange
            int x = 3;
            int y = 2;

            // Act
            int result = _calculator.Subtract(x, y);

            // Assert
            Assert.That(result, Is.EqualTo(1));
        }

        [Test]
        public void Subtract_WithNegativeNumbers_ReturnsCorrectResult()
        {
            // Arrange
            int x = -3;
            int y = -2;

            // Act
            int result = _calculator.Subtract(x, y);

            // Assert
            Assert.That(result, Is.EqualTo(-1));
        }

        [Test]
        public void Subtract_WithLargeNumbers_ReturnsCorrectResult()
        {
            // Arrange
            int x = int.MinValue + 1;
            int y = 1;

            // Act
            int result = _calculator.Subtract(x, y);

            // Assert
            Assert.That(result, Is.EqualTo(int.MinValue));
        }
    }
}