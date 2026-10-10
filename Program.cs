using System;
namespace Zadanie16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите трехзначное число:");
            int число = Convert.ToInt32(Console.ReadLine());

            int последняя = число % 10;
            int первыеДве = число / 10;
            int результат = последняя * 100 + первыеДве;

            Console.WriteLine("Полученное число: " + результат);
        }
    }
}

