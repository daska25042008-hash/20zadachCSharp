using System;
namespace Zadanie11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число:");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите второе число:");
            int b = Convert.ToInt32(Console.ReadLine());

            double среднееАрифметическое = (a + b) / 2.0;
            double среднееГеометрическое = Math.Sqrt(a * b);
            Console.WriteLine("Среднее арифметическое: " + среднееАрифметическое);
            Console.WriteLine("Среднее геометрическое: " + среднееГеометрическое);
        }
    }
}
