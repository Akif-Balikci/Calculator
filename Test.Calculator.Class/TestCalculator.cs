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
            //uut.Add(1, 4);//v�rdifuld
            Assert.That(uut.Add(a:1, b:4),Is.EqualTo(5.0));
            Assert.That(uut.Add(-1,2),Is.EqualTo(1.0));
            Assert.That(uut.Add(-4,-4),Is.EqualTo(-8.0));
        }

        [Test]
        public void TestSubtract()
        {
            handCalculator uut = new handCalculator();
            Assert.That(uut.Subtract(a: 5, b: 4), Is.EqualTo(1.0));
            Assert.That(uut.Subtract(-1,5),Is.EqualTo(-6.0));
            Assert.That(uut.Subtract(-1,-5),Is.EqualTo(4.0));
        }

        [Test]
        public void TestMultiply()
        {
            handCalculator uut = new handCalculator();
            Assert.That(uut.Multiply(a: 5, b: 4), Is.EqualTo(20.0));
            Assert.That(uut.Multiply(a: -5, b: 5), Is.EqualTo(-25.0));
            Assert.That(uut.Multiply(a: -1, b: -5), Is.EqualTo(5.0));
        }

        [Test]
        public void TestPower()
        {
            handCalculator uut = new handCalculator();
            Assert.That(uut.Power(x: 3, exp: 3), Is.EqualTo(27.0));
            Assert.That(uut.Power(x: -5, exp: 3), Is.EqualTo(-125.0));
            Assert.That(uut.Power(x: -2, exp: -2), Is.EqualTo(0.25));
        }

        [Test]
        public void TestDivide()
        {
            handCalculator uut = new handCalculator();
            Assert.That(uut.Divide(a: 3, b: 3), Is.EqualTo(1.0));
            Assert.That(uut.Divide(a: 3, b: 0), Is.EqualTo(0.0));
            Assert.That(uut.Divide(a: -5, b: 2), Is.EqualTo(-2.5));

        }

        //returns squareroot of sum
        [Test]
        public void TestSqrt()
        {
            handCalculator uut = new handCalculator();
            Assert.That(uut.Sqrt(a: 3, b: 6), Is.EqualTo(3));
            Assert.That(uut.Sqrt(a: -3, b: -6), Is.EqualTo(0.0)); //defined to return 0 instead of NaN
            Assert.That(uut.Sqrt(a: -5, b: 5), Is.EqualTo(0.0));

        }


        [Test]
        public void TestPytagoras() 
        {
            handCalculator uut = new handCalculator();
            Assert.That(uut.pytagoras(a: 3, b: 4), Is.EqualTo(5));
            Assert.That(uut.pytagoras(a: -3, b: 4), Is.EqualTo(5));
            Assert.That(uut.pytagoras(a: -3, b: -4), Is.EqualTo(5));

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
        [Test]
        public void TestAccumulator() {
            handCalculator uut = new handCalculator();
            Assert.That(uut.Accumulator,Is.EqualTo(0.0)); //0 by default
            uut.Add(3,4);
            Assert.That(uut.Accumulator,Is.EqualTo(7.0)); //0 by default
            uut.Add(2);
            Assert.That(uut.Accumulator,Is.EqualTo(9.0)); 
        }
        [Test] 
        public void TestClear() {
            handCalculator uut = new handCalculator();
            Assert.That(uut.Accumulator,Is.EqualTo(0.0));
            uut.Add(3,4);
            Assert.That(uut.Accumulator,!Is.EqualTo(0.0));
            uut.Clear();
            Assert.That(uut.Accumulator,Is.EqualTo(0.0));
        }
    }
}
