using System;
namespace Zadanie5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите x:");
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Math.Cos(x);

            Console.WriteLine("y = " + y);
        }
    }
}
