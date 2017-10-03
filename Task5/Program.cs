using System;
using System.Linq;

namespace Task5
{
    class Program
    {
        static int SumNaturalMultiples3Or5(int n)
        {
            return Enumerable.Range(1, n - 1).Sum(x =>
            {
                if ((x % 3) == 0 || (x % 5) == 0)
                    return x;
                return 0;
            });
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Сумма всех чисел меньше 1000, кратных 3, или 5 равна {0}.",
                SumNaturalMultiples3Or5(1000));
            Console.ReadKey();
        }
    }
}
