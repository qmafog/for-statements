namespace ForStatements
{
    public static class Factorial
    {
        public static int GetFactorial(int n)
        {
            int fact = 1;
            for (int i = n; i > 0; i--)
            {
                fact *= i;
            }

            return fact;
        }

        public static int SumFactorialDigits(int n)
        {
            int product = GetFactorial(n);
            int sum = 0;

            for (; product > 0; product /= 10)
            {
                sum += product % 10;
            }

            return sum;
        }
    }
}
