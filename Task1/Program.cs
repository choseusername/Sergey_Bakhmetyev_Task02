using System;

namespace Task1
{
    class Program
    {
        static void GetUserInput(out int a, out int b)
        {
            Console.WriteLine("Чтобы вычислить площадь прямоугольника со сторонами a и b, введите:");

            Console.Write("a = ");
            while (!int.TryParse(Console.ReadLine(), out a) || a < 1)
            {
                Console.WriteLine("Пожалуйста, введите корректное числовое значение (a > 0).");
                Console.Write("a = ");
            }

            Console.Write("b = ");
            while (!int.TryParse(Console.ReadLine(), out b) || b < 1)
            {
                Console.WriteLine("Пожалуйста, введите корректное числовое значение (b > 0).");
                Console.Write("b = ");
            }
        }

        static void Main(string[] args)
        {
            int a = 0, b = 0;
            GetUserInput(out a, out b);
            Rectangle rect = new Rectangle(a, b);
            Console.WriteLine("Площадь прямоугольника со сторонами {0}, {1} равна {2}.",
                rect.Width, rect.Height, rect.Area);

            Console.ReadKey();
        }
    }
}
