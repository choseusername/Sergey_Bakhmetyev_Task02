using System;

namespace Task3
{
    class PseudoTriangle: IPseudoGraphic
    {
        private int n;

        public void Display()
        {
            for (int i = 1; i <= n; ++i)
            {
                Console.Write(new String(' ', (n + 1 - i)));
                Console.Write(new String('*', (2 * (i - 1) + 1)));
                Console.WriteLine();
            }
        }

        public PseudoTriangle(int N) => n = N;
    }
}
