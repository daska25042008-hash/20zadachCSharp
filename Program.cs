using System;
namespace Zadanie12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите x1:");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите y1:");
            double y1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите x2:");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите y2:");
            double y2 = Convert.ToDouble(Console.ReadLine());

            double расстояние = Math.Sqrt(
                (x2 - x1) * (x2 - x1) +
                (y2 - y1) * (y2 - y1));

            Console.WriteLine("Расстояние между точками: " + расстояние);
        }
    }
}
