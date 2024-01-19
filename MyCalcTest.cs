using ClassLibrary1;

namespace TestProject1
{
    [TestClass]
    public class MyCalcTest
    {
        [TestMethod]
        public void Sum_10and20_30()
        {
            Calc calc = new Calc();
            int x = 10;
            int y = 20;
            int ex = 30;

            double actual = calc.Sum(x, y);

            Assert.AreEqual(ex, actual);
        }

        [TestMethod]
        public void Min_10and20()
        {
            Calc calc = new Calc();
            int x = 10;
            int y = 20;
            int ex = -10;

            double actual = calc.Minus(x, y);

            Assert.AreEqual(ex, actual);
        }

        [TestMethod]
        public void Mult_10and20()
        {
            Calc calc = new Calc();
            int x = 10;
            int y = 20;
            int ex = 200;

            double actual = calc.Multiply(x, y);

            Assert.AreEqual(ex, actual);
        }

        [TestMethod]
        public void Div_10and2()
        {
            Calc calc = new Calc();
            int x = 10;
            int y = 2;
            int ex = 5;

            double actual = calc.Divide(x, y);

            Assert.AreEqual(ex, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException),"Делить на 0 нельзя!")]
        public void Div_10and0_ZeroDivException()
        {
            Calc calc = new Calc();
            int x = 10;
            int y = 0;
            
            double actual = calc.Divide(x, y);
        }

        [TestMethod]
        public void Mult_0and5()
        {
            Calc calc = new Calc();
            int x = 0;
            int y = 5;
            int ex = 0;

            double actual = calc.Multiply(x, y);

            Assert.AreEqual(ex, actual);
        }
    }
}