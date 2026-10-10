using System;
namespace Zadanie6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите большее основание:");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите меньшее основание:");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите высоту:");
            double h = Convert.ToDouble(Console.ReadLine());

            double x = (a - b) / 2;
            double c = Math.Sqrt(x * x + h * h);

            double p = a + b + 2 * c;

            Console.WriteLine("Периметр = " + p);
        }
    }
}
