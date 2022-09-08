namespace Calculator
{
    public class handCalculator
    {
        public double Add(double a, double b)
        {
            return a + b;
        }

        public double Subtract(double a, double b)
        {
            return a - b;
        }

        public double Multiply(double a, double b)
        {
            return a * b;
        }

        public double Power(double x, double exp)
        {
            return Math.Pow(x, exp);
        }
        
        // Divide
        public double Divide(double a, double b)
        {
            
            return a / b;
        }

        public double Sqrt(double a, double b)
        {

            return Math.Sqrt(a+b);    

        }


        public double pytagoras(double a, double b)
        {

            double c = Math.Pow(a, 2) + Math.Pow(b, 2);
            return Math.Sqrt(c);

        }
    }
}