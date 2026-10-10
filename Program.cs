using System;
namespace Zadanie8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число:");
            int b = Convert.ToInt32(Console.ReadLine());

            int c = a;
            a = b;
            b = c;

            Console.WriteLine("Первое число: " + a);
            Console.WriteLine("Второе число: " + b);
        }
    }
}
