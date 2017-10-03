using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class PseudoСhristmasTree : IPseudoGraphic
    {
        private int n;
        public void Display()
        {
            bool star = false;
            for (int j = n, k = 0; j > 0; --j, ++k)
            {
                int m = 2 + k;
                for (int i = 1; i <= m; ++i)
                {
                    if (!star)
                    {
                        Console.Write(new String(' ', (m - i + j)));
                        Console.WriteLine('*');
                        star = true;
                    }
                    Console.Write(new String(' ', (m - i + j)));
                    Console.Write(new String('*', (2 * (i - 1) + 1)));
                    Console.WriteLine();
                }
            }
        }

        public PseudoСhristmasTree(int N) => n = N;
    }
}
