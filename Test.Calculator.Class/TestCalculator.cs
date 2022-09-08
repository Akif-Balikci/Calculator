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
            //uut.Add(1, 4);//værdifuld
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
        [Test]
        public void TestSqrt()
        {
            handCalculator uut = new handCalculator();
            Assert.That(uut.Sqrt(a: 3, b: 6), Is.EqualTo(3));

        }


        [Test]
        public void TestPytagoras() 
        {
            handCalculator uut = new handCalculator();
            Assert.That(uut.pytagoras(a: 3, b: 4), Is.EqualTo(5));
        
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
