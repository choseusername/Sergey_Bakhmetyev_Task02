using System;

namespace Task4
{
    class Program
    {
        static void GetUserInput(out int N)
        {
            Console.WriteLine("Чтобы вывести изображение, состоящее из N строк, введите:");
            Console.Write("N = ");
            while (!int.TryParse(Console.ReadLine(), out N) || N < 1)
            {
                Console.WriteLine("Пожалуйста, введите корректное числовое значение (N > 0).");
                Console.Write("N = ");
            }
        }

        static void Main(string[] args)
        {
            // "Ёлочка"
            int N = 0;
            GetUserInput(out N);
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;

            PseudoСhristmasTree сhristmasTree = new PseudoСhristmasTree(N);
            сhristmasTree.Display();

            Console.ReadKey();
        }
    }
}
