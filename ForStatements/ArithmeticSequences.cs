namespace ForStatements
{
    public static class ArithmeticSequences
    {
        public static int SumArithmeticSequenceTerms1(int a, int n)
        {
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += a + i;
            }

            return sum;
        }

        public static int SumArithmeticSequenceTerms2(int n)
        {
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                sum += 47 + (i * 13);
            }

            return sum;

        }

        public static int SumArithmeticSequenceTerms3(int a, int n)
        {
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += a + (i * 5);
            }

            return sum;
        }
    }
}
