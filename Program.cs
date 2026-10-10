using System;
namespace Zadanie18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("a)\nВведите ваше имя:");
            string имя = Console.ReadLine()!;
            Console.WriteLine(имя);

            Console.WriteLine("b)\nВведите ваше имя:");
            string имя2 = Console.ReadLine()!;
            Console.WriteLine("Привет, " + имя2 + "!");
        }
    }
}

