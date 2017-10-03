using System;

namespace Task2
{
    class PseudoRightTriangle: IPseudoGraphic
    {
        private int n;

        public PseudoRightTriangle(int N) => n = N;

        public void Display()
        {
            for (int i = 1; i <= n; ++i)
            {
                Console.WriteLine(new String('*', i));
            }
        }
    }
}
