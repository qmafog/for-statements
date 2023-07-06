namespace ForStatements
{
    public static class PrimeNumbers
    {
        public static bool IsPrimeNumber(uint n)
        {
            if (n < 2)
            {
                return false;
            }

            for (uint i = 2; i <= n / 2; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        public static ulong SumDigitsOfPrimeNumbers(int start, int end)
        {
            uint sum = 0;

            for (uint number = (uint)start; number <= (uint)end; number++)
            {
                if (IsPrimeNumber(number))
                {
                    uint temp = number;
                    while (temp != 0)
                    {
                        uint digit = temp % 10;
                        sum += digit;
                        temp /= 10;
                    }
                }
            }

            return sum;
        }
    }
}
