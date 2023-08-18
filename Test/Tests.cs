global using NUnit.Framework;
using Calculator;

namespace Test
{
    public class Tests
    {
        [Test]
        public void PlusTest()
        {
            int result = FluentCalculator.one.plus.two.plus.three.plus.four;
            Assert.AreEqual(result, 10);
        }

        [Test]
        public void MinusTest()
        {
            int result = FluentCalculator.four.minus.two.minus.one;
            Assert.AreEqual(result, 1);
        }

        [Test]
        public void TimesTest()
        {
            int result = FluentCalculator.four.times.six;
            Assert.AreEqual(result, 24);
        }

        [Test]
        public void DividedByTest()
        {
            int result = FluentCalculator.six.dividedBy.two;
            Assert.AreEqual(result, 3);
        }

        [Test]
        public void StackableTest()
        {
            int result = FluentCalculator.one.plus.two.plus.three.minus.one.minus.two.minus.four;
            Assert.AreEqual(result, -1);
        }

        [Test]
        public void ResolveTest()
        {
            int result = FluentCalculator.one.plus.ten - 10;
            Assert.AreEqual(result, 1);
        }

        [Test]
        public void DivideByZeroCrashTest()
        {
            Assert.Throws<DivideByZeroException>(() =>
            {
                int result = FluentCalculator.ten.dividedBy.zero;
            });
        }

        [Test]
        public void InfinityTest()
        {
            int result = FluentCalculator.zero.plus.one.plus.two.plus.three.plus.four.plus.five.plus.six.plus.seven.plus.eight.plus.nine.plus.ten
                    .dividedBy.five
                    .minus.one
                    .times.ten
                    - 100;

            Assert.AreEqual(result, 0);
        }
    }
}