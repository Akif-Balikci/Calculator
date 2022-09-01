using Calculator;

namespace Test.Calculator.Class
{
    public class TestCalculator
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestAdd()
        {
            handCalculator uut = new handCalculator();
            //uut.Add(1, 4);
            Assert.That(uut.Add(a:1, b:4),Is.EqualTo(5.0));

        }

        [Test]
        public void TestSubtract()
        {
            handCalculator uut = new handCalculator();
            Assert.That(uut.Subtract(a: 5, b: 4), Is.EqualTo(1.0));

        }

        [Test]
        public void TestMultiply()
        {
            handCalculator uut = new handCalculator();
            Assert.That(uut.Multiply(a: 5, b: 4), Is.EqualTo(20.0));

        }

        [Test]
        public void TestPower()
        {
            handCalculator uut = new handCalculator();
            Assert.That(uut.Power(x: 3, exp: 3), Is.EqualTo(27.0));

        }

        [Test]
        public void TestDivide()
        {
            handCalculator uut = new handCalculator();
            Assert.That(uut.Divide(a: 3, b: 3), Is.EqualTo(1.0));

        }

        [TestCase(2, 3, 5)]
        [TestCase(6, 7, 13)]
        [TestCase(3, 3, 6)]
        public void TestAdd2(double p1, double p2, double expected)
        {
            handCalculator uut = new handCalculator();
            //uut.Add(1, 4);

            Assert.That(uut.Add(p1, p2), Is.EqualTo(expected));

        }
    }
}
