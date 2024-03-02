using TRPO_Lab3.ClassLibrary;

namespace TRPO_Lab3.TestProject
{
    [TestFixture]
    public class CalcTests
    {
        [Test]
        public void AddTest1()
        {
            const int a = 1;
            const int h = 2;
            const double expected = 0.29;
            var result = Square.Calc(a, h);
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void AddTest2()
        {
            const int a = 54;
            const int h = 1;
            const double expected = 420.89;
            var result = Square.Calc(a, h);
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void AddTest3()
        {
            const int a = 1;
            const int h = 1;
            const double expected = 0.14;
            var result = Square.Calc(a, h);
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void AddTest4()
        {
            const double a = 5.4;
            const double h = 5.2;
            const double expected = 21.89;
            var result = Square.Calc(a, h);
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void AddTest5()
        {
            const int a = 0;
            const int h = 1;

            Assert.Throws<Exception>(() => Square.Calc(a, h));
        }
        [Test]
        public void AddTest6()
        {
            const int a = 1;
            const int h = 0;

            Assert.Throws<Exception>(() => Square.Calc(a, h));
        }
        [Test]
        public void AddTest7()
        {
            const int a = 0;
            const int h = 0;

            Assert.Throws<Exception>(() => Square.Calc(a, h));
        }
    }
}