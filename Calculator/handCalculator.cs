namespace Calculator
{
    public class handCalculator
    {
        private double accumulated = 0;
        public double Add(double a, double b)
        {
            accumulated = a+b;
            return accumulated;
        }
        //Overloaded to use with accumulator
        public double Add(double a) {
            accumulated = a + accumulated;
            return accumulated;
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
            if (b==0) { return 0;}
            return a / b;
        }

        public double Sqrt(double a, double b)
        {
            if (a+b < 0) return 0; //NaN not defined in testing context
            return Math.Sqrt(a+b);    

        }


        public double pytagoras(double a, double b)
        {
            double c = Math.Pow(a, 2) + Math.Pow(b, 2);
            return Math.Sqrt(c);
        }
        public double Accumulator{get{return accumulated;} set{accumulated = value;}
        }
        public void Clear() {
            this.Accumulator = 0;
        }
    }
}