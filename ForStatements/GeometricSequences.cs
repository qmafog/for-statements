namespace ForStatements
{
    public static class GeometricSequences
    {
        public static ulong GetGeometricSequenceTermsProduct(uint a, uint r, uint n)
        {
            ulong prod = 1;
            for (uint i = 0; i < n; i++)
            {
                prod *= a;
                for (uint j = 0; j < i; j++)
                {
                    prod *= r;
                }
            }

            return prod;
        }

        public static ulong SumGeometricSequenceTerms(uint n)
        {
            ulong sum = 0, elem;
            for (uint i = 0; i < n; i++)
            {
                elem = 5;
                for (uint j = 0; j < i; j++)
                {
                    elem *= 3;
                }

                sum += elem;
            }

            return sum;
        }

        public static ulong CountGeometricSequenceTerms1(uint a, uint r, uint maxTerm)
        {
            uint elem = 1;
            ulong counter = 0;
            for (uint i = 0; ; i++)
            {
                elem = a;
                for (uint j = 0; j < i; j++)
                {
                    elem *= r;
                }

                if (elem <= maxTerm)
                {
                    counter++;
                }
                else
                {
                    break;
                }
            }

            return counter;
        }

        public static ulong CountGeometricSequenceTerms2(uint a, uint r, uint n, uint minTerm)
        {
            uint elem = 1;
            ulong counter = 0;
            for (uint i = 0; i < n; i++)
            {
                elem = a;
                for (uint j = 0; j < i; j++)
                {
                    elem *= r;
                }

                if (elem >= minTerm)
                {
                    counter++;
                }
            }

            return counter;
        }
    }
}
