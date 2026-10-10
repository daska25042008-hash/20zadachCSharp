using System;
namespace Zadanie13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите a:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите b:");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите c:");
            int c = Convert.ToInt32(Console.ReadLine());

            int d;

            d = b;
            b = c;
            c = a;
            a = d;

            Console.WriteLine("Схема а:");
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
            Console.WriteLine("c = " + c);

            d = a;
            a = b;
            b = c;
            c = d;

            Console.WriteLine("Схема б:");
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
            Console.WriteLine("c = " + c);
        }
    }
}
