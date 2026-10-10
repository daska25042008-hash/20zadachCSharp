using System;
namespace Zadanie4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число:");
            int число = Convert.ToInt32(Console.ReadLine());
            число = число + 10;
            Console.WriteLine(число);
        }
    }
}
