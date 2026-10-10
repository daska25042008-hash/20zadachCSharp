using System;
namespace Zadanie10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите a:");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите b:");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите c:");
            double c = Convert.ToDouble(Console.ReadLine());

            double d = b * b - 4 * a * c;

            if (d > 0)
            {
                double x1 = (-b + Math.Sqrt(d)) / (2 * a);
                double x2 = (-b - Math.Sqrt(d)) / (2 * a);

                Console.WriteLine("Первый корень: " + x1);
                Console.WriteLine("Второй корень: " + x2);
            }
            else if (d == 0)
            {
                double x = -b / (2 * a);

                Console.WriteLine("Корень: " + x);
            }
            else if (d < 0)
            {
                Console.WriteLine("Корней нет, дискриминант отрицательный");
            }
        }
    }
}

