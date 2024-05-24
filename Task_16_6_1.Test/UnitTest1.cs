namespace Task_16_6_1.Test
{
    [TestFixture]
    public class CalculatorTests
    {
        private Calculator calculator;

        [SetUp]
        public void Setup()
        {
            calculator = new Calculator();
        }

        [Test]
        public void TestAdditional()
        {
            Assert.That(calculator.Additional(2, 3), Is.EqualTo(5));
        }

        [Test]
        public void TestSubtraction()
        {
            Assert.That(calculator.Subtraction(2, 3), Is.EqualTo(-1));
        }

        [Test]
        public void TestMultiplication()
        {
            Assert.That(calculator.Miltiplication(2, 3), Is.EqualTo(6));
        }

        [Test]
        public void TestDivision()
        {
            Assert.That(calculator.Division(6, 3), Is.EqualTo(2));
        }
    }
}