namespace ClassLibrary1
{
    public class Calc
    {
        public double Sum(double x, double y)
        {
            return x + y;
        }

        public double Minus(double x, double y)
        {
            return x - y;
        }

        public double Multiply(double x, double y)
        {
            return x * y;
        }

        public double Divide(double x, double y)
        {
            if (y == 0)
            {
                throw new DivideByZeroException();
            }
                
            return x / y;
        }
    }
}