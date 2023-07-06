namespace ForStatements
{
    public static class FibonacciSequence
    {
        public static int GetFibonacciNumber(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            else if (n == 1)
            {
                return 1;
            }

            int num1 = 0, num2 = 1;
            for (int i = 0; i <= n - 2; i++)
            {
                num2 += num1;
                num1 = num2 - num1;
            }

            return num2;
        }

        public static ulong GetProductOfFibonacciNumberDigits(ulong n)
        {
            if (n <= 0)
            {
                return 0;
            }

            ulong fibNMinus2 = 0;
            ulong fibNMinus1 = 1;
            ulong fibN = 1;
            ulong product = 1;

            for (ulong i = 2; i <= n; i++)
            {
                product = 1;
                fibN = fibNMinus2 + fibNMinus1;
                ulong temp = fibN;
                for (; temp > 0; temp /= 10)
                {
                    product *= temp % 10;
                }

                fibNMinus2 = fibNMinus1;
                fibNMinus1 = fibN;
            }

            return product;
        }
    }
}
