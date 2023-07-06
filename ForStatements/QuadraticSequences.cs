﻿namespace ForStatements
{
    public static class QuadraticSequences
    {
        public static uint CountQuadraticSequenceTerms(long a, long b, long c, long maxTerm)
        {
            uint count = 0;

            for (long n = 1; ; n++)
            {
                long term = (a * n * n) + (b * n) + c;
                if (term <= maxTerm)
                {
                    count++;
                }
                else
                {
                    break;
                }
            }

            return count;
        }

        public static ulong GetQuadraticSequenceTermsProduct1(uint count)
        {
            ulong product = 1;

            for (uint n = 1; n <= count; n++)
            {
                ulong term = (7 * n * n) + (4 * n) + 2;
                product *= term;
            }

            return product;
        }

        public static ulong GetQuadraticSequenceProduct2(long a, long b, long c, long startN, long count)
        {
            ulong product = 1;

            for (ulong n = (ulong)startN; n < (ulong)startN + (ulong)count; n++)
            {
                ulong term = ((ulong)a * n * n) + ((ulong)b * n) + (ulong)c;
                product = product * term;
            }

            return product;
        }
    }
}
